//
//  RegistrationViewController.swift
//  stafflio_app
//
//  Created by Batch1 on 11/06/25.
//

import UIKit
import CoreData

class RegistrationViewController: UIViewController {

    var username=UserDefaults.standard
    override func viewDidLoad() {
        super.viewDidLoad()
        let path=NSSearchPathForDirectoriesInDomains(.documentDirectory, .userDomainMask, true)
        print(path[0])
        // Do any additional setup after loading the view.
    }
   
    
    @IBOutlet weak var txt_role: UISegmentedControl!
    @IBOutlet weak var txt_lname: UITextField!
    @IBOutlet weak var txt_fname: UITextField!
    @IBOutlet weak var txt_password: UITextField!
    @IBOutlet weak var txt_email: UITextField!
    
    /*
    // MARK: - Navigation

    // In a storyboard-based application, you will often want to do a little preparation before navigation
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        // Get the new view controller using segue.destination.
        // Pass the selected object to the new view controller.
    }
    */
    
    func showAlert(title: String, message: String, onOK: (() -> Void)? = nil) {
        let alert = UIAlertController(title: title, message: message, preferredStyle: .alert)
        alert.addAction(UIAlertAction(title: "OK", style: .default, handler: { _ in
            onOK?()
        }))
        present(alert, animated: true)
    }

    @IBAction func btn_register_click(_ sender: Any) {
        
        let appD=UIApplication.shared.delegate as! AppDelegate
        let moc=appD.persistentContainer.viewContext
        let user=Users(context: moc)
      
        user.email=txt_email.text
        user.fname=txt_fname.text
        user.lname=txt_lname.text
        if(txt_role.selectedSegmentIndex == 0){
            user.role="Admin"
        }
        else{
            user.role="Employee"
        }
        user.password=txt_password.text
        
        // Step 1: Fetch latest emp_id
        let fetchRequest: NSFetchRequest<Users> = Users.fetchRequest()
        let sortDescriptor = NSSortDescriptor(key: "emp_id", ascending: false)
        fetchRequest.sortDescriptors = [sortDescriptor]
        fetchRequest.fetchLimit = 1

        do {
            let lastUser = try moc.fetch(fetchRequest).first
            let lastEmpId = lastUser?.emp_id ?? 0
            user.emp_id = lastEmpId + 1
        } catch {
            print("Error fetching last emp_id: \(error)")
            user.emp_id = 1 // fallback
        }

        
        
        
        do{
           
            try moc.save()

                   
                   showAlert(title: "Success", message: "User registered successfully!") {
                       // Optionally clear fields
                       self.txt_email.text = ""
                       self.txt_fname.text = ""
                       self.txt_lname.text = ""
                       self.txt_password.text = ""
                       self.txt_role.selectedSegmentIndex = 0
                   }

               } catch {
                   print("Error saving user: \(error)")
                   showAlert(title: "Error", message: "Failed to register user.")
               }
        
    }
    }
 

