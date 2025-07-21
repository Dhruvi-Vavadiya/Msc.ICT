import UIKit
import CoreData

class ManageUsersViewController: UIViewController, UITableViewDelegate, UITableViewDataSource {
    var usersList: [Users] = []
    
    @IBOutlet weak var tblvw: UITableView!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        tblvw.delegate = self
        tblvw.dataSource = self
        
        // No need to register default cell if using storyboard prototype cell with same reuse id
        // But just in case:
        tblvw.register(UITableViewCell.self, forCellReuseIdentifier: "UserCell")
        
        // Enable dynamic row height
        tblvw.rowHeight = UITableView.automaticDimension
        tblvw.estimatedRowHeight = 100
        
        // Add some spacing between cells by setting separator inset or use section header/footer trick
        tblvw.separatorStyle = .none
        tblvw.backgroundColor = UIColor.systemGroupedBackground
        
        fetchUsers()
    }
    
    override func viewWillAppear(_ animated: Bool) {
        super.viewWillAppear(animated)
        fetchUsers()
    }
    
    func fetchUsers() {
        let appD = UIApplication.shared.delegate as! AppDelegate
        let moc = appD.persistentContainer.viewContext
        
        let fetchRequest: NSFetchRequest<Users> = Users.fetchRequest()
        
        do {
            usersList = try moc.fetch(fetchRequest)
            tblvw.reloadData()
        } catch {
            print("Error fetching users: \(error)")
        }
    }
    
    // MARK: - TableView DataSource
    
    func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return usersList.count
    }
    
    func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        
        let cellId = "UserCell"
        let cell = tableView.dequeueReusableCell(withIdentifier: cellId) ??
            UITableViewCell(style: .default, reuseIdentifier: cellId)
        
        // Clear previous subviews
        cell.contentView.subviews.forEach { $0.removeFromSuperview() }
        cell.selectionStyle = .none
        
        let user = usersList[indexPath.row]
        
        // Container view for card effect
        let container = UIView()
        container.translatesAutoresizingMaskIntoConstraints = false
        container.backgroundColor = UIColor.systemBackground
        container.layer.cornerRadius = 12
        container.layer.shadowColor = UIColor.black.cgColor
        container.layer.shadowOpacity = 0.08
        container.layer.shadowRadius = 5
        container.layer.shadowOffset = CGSize(width: 0, height: 2)
        
        cell.contentView.addSubview(container)
        
        NSLayoutConstraint.activate([
            container.topAnchor.constraint(equalTo: cell.contentView.topAnchor, constant: 8),
            container.leadingAnchor.constraint(equalTo: cell.contentView.leadingAnchor, constant: 16),
            container.trailingAnchor.constraint(equalTo: cell.contentView.trailingAnchor, constant: -16),
            container.bottomAnchor.constraint(equalTo: cell.contentView.bottomAnchor, constant: -8)
        ])
        
        // Vertical stack to hold all labels
        let stack = UIStackView()
        stack.axis = .vertical
        stack.spacing = 6
        stack.translatesAutoresizingMaskIntoConstraints = false
        
        container.addSubview(stack)
        
        NSLayoutConstraint.activate([
            stack.topAnchor.constraint(equalTo: container.topAnchor, constant: 12),
            stack.leadingAnchor.constraint(equalTo: container.leadingAnchor, constant: 12),
            stack.trailingAnchor.constraint(equalTo: container.trailingAnchor, constant: -12),
            stack.bottomAnchor.constraint(equalTo: container.bottomAnchor, constant: -12)
        ])
        
        func makeLabel(title: String, detail: String) -> UILabel {
            let label = UILabel()
            label.numberOfLines = 0
            let attributedText = NSMutableAttributedString(
                string: title + ": ",
                attributes: [.font: UIFont.boldSystemFont(ofSize: 15)]
            )
            attributedText.append(NSAttributedString(
                string: detail,
                attributes: [.font: UIFont.systemFont(ofSize: 15), .foregroundColor: UIColor.label]
            ))
            label.attributedText = attributedText
            return label
        }
        
        let nameLabel = makeLabel(title: "Name", detail: "\(user.fname ?? "") \(user.lname ?? "")")
        let emailLabel = makeLabel(title: "Email", detail: user.email ?? "")
        let roleLabel = makeLabel(title: "Role", detail: user.role ?? "")
        
        [nameLabel, emailLabel, roleLabel].forEach { stack.addArrangedSubview($0) }
        
        return cell
    }
    
    // Optional: Add spacing between cells by adding footer height for section
    
    func tableView(_ tableView: UITableView, heightForFooterInSection section: Int) -> CGFloat {
        return 8
    }
    
    func tableView(_ tableView: UITableView, viewForFooterInSection section: Int) -> UIView? {
        let v = UIView()
        v.backgroundColor = .clear
        return v
    }
}
