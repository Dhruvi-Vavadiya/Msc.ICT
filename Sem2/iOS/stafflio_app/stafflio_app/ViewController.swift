import UIKit
import CoreData

class ViewController: UIViewController {

    // MARK: - UI Elements
    let logoImageView: UIImageView = {
        let iv = UIImageView()
        iv.image = UIImage(named: "favicon.png") // Replace with your logo image name
        iv.contentMode = .scaleAspectFit
        iv.translatesAutoresizingMaskIntoConstraints = false
        return iv
    }()
    
    let txt_uname: UITextField = {
        let tf = UITextField()
        tf.placeholder = "Email"
        tf.autocapitalizationType = .none
        tf.autocorrectionType = .no
        tf.borderStyle = .roundedRect
        tf.keyboardType = .emailAddress
        tf.translatesAutoresizingMaskIntoConstraints = false
        tf.heightAnchor.constraint(equalToConstant: 44).isActive = true
        return tf
    }()
    
    let txt_password: UITextField = {
        let tf = UITextField()
        tf.placeholder = "Password"
        tf.isSecureTextEntry = true
        tf.borderStyle = .roundedRect
        tf.translatesAutoresizingMaskIntoConstraints = false
        tf.heightAnchor.constraint(equalToConstant: 44).isActive = true
        return tf
    }()
    
    let btn_login: UIButton = {
        let btn = UIButton(type: .system)
        btn.setTitle("Login", for: .normal)
        btn.backgroundColor = UIColor.systemBlue
        btn.tintColor = .white
        btn.layer.cornerRadius = 8
        btn.titleLabel?.font = UIFont.boldSystemFont(ofSize: 18)
        btn.translatesAutoresizingMaskIntoConstraints = false
        btn.heightAnchor.constraint(equalToConstant: 50).isActive = true
        return btn
    }()
    
    // MARK: - View Life Cycle
    override func viewDidLoad() {
        super.viewDidLoad()
        view.backgroundColor = UIColor.systemBackground
        
        setupLayout()
        
        // Add target for button
        btn_login.addTarget(self, action: #selector(btn_login_click(_:)), for: .touchUpInside)
        
        let path = NSSearchPathForDirectoriesInDomains(.documentDirectory, .userDomainMask, true)
        print(path[0])
    }
    
    // MARK: - Layout Setup
    func setupLayout() {
        // Container stack view for vertical layout
        let stackView = UIStackView(arrangedSubviews: [logoImageView, txt_uname, txt_password, btn_login])
        stackView.axis = .vertical
        stackView.spacing = 20
        stackView.alignment = .fill
        stackView.translatesAutoresizingMaskIntoConstraints = false
        
        view.addSubview(stackView)
        
        // Constraints for stackView
        NSLayoutConstraint.activate([
            // Center stackView vertically with some offset upwards
            stackView.centerYAnchor.constraint(equalTo: view.centerYAnchor, constant: -50),
            stackView.leadingAnchor.constraint(equalTo: view.leadingAnchor, constant: 30),
            stackView.trailingAnchor.constraint(equalTo: view.trailingAnchor, constant: -30),
            
            // Set fixed height for logo image view (e.g., 120 pts)
            logoImageView.heightAnchor.constraint(equalToConstant: 120)
        ])
    }
    
    // MARK: - Login Button Action
    @objc func btn_login_click(_ sender: UIButton) {
        let appDelegate = UIApplication.shared.delegate as! AppDelegate
        let managedContext = appDelegate.persistentContainer.viewContext
        
        guard let email = txt_uname.text?.trimmingCharacters(in: .whitespacesAndNewlines), !email.isEmpty,
              let password = txt_password.text?.trimmingCharacters(in: .whitespacesAndNewlines), !password.isEmpty else {
            showAlert(message: "Please enter both Username and Password")
            return
        }
        
        let fetchRequest: NSFetchRequest<Users> = Users.fetchRequest()
        fetchRequest.predicate = NSPredicate(format: "email == %@ AND password == %@", email, password)
        
        DispatchQueue.global(qos: .userInitiated).async {
            do {
                let users = try managedContext.fetch(fetchRequest)
                
                DispatchQueue.main.async {
                    if let existingUser = users.first {
                        if existingUser.role == "Admin" {
                            self.performSegue(withIdentifier: "admin", sender: self)
                        } else {
                            UserDefaults.standard.set(existingUser.emp_id, forKey: "loggedInUserEmpId")
                            UserDefaults.standard.set(existingUser.email, forKey: "loggedInEmail")
                            self.performSegue(withIdentifier: "emp", sender: self)
                        }
                    } else {
                        self.showAlert(message: "Invalid Username or Password")
                    }
                }
            } catch {
                print("Fetch error: \(error)")
            }
        }
    }
    
    // MARK: - Helper Alert
    func showAlert(title: String = "Error", message: String) {
        let alert = UIAlertController(title: title, message: message, preferredStyle: .alert)
        alert.addAction(UIAlertAction(title: "Dismiss", style: .cancel))
        present(alert, animated: true)
    }
}
