import UIKit
import CoreData

class ViewStatusViewController: UIViewController, UITableViewDataSource, UITableViewDelegate {
    var list: [Leave_Details] = []

    @IBOutlet weak var tblvw: UITableView!

    func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return list.count
    }

    func tableView(_ tableView: UITableView, heightForRowAt indexPath: IndexPath) -> CGFloat {
        return 130 // a bit taller for card style
    }

    func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {

        let cell = tableView.dequeueReusableCell(withIdentifier: "EmpCell", for: indexPath)
        
        // Remove old content
        cell.contentView.subviews.forEach { $0.removeFromSuperview() }
        
        let emp = list[indexPath.row]
        
        // Container view for card effect
        let container = UIView()
        container.backgroundColor = UIColor.systemBackground
        container.layer.cornerRadius = 12
        container.layer.shadowColor = UIColor.black.withAlphaComponent(0.1).cgColor
        container.layer.shadowOffset = CGSize(width: 0, height: 2)
        container.layer.shadowRadius = 5
        container.layer.shadowOpacity = 0.3
        container.translatesAutoresizingMaskIntoConstraints = false
        
        cell.contentView.addSubview(container)
        
        NSLayoutConstraint.activate([
            container.topAnchor.constraint(equalTo: cell.contentView.topAnchor, constant: 8),
            container.leadingAnchor.constraint(equalTo: cell.contentView.leadingAnchor, constant: 15),
            container.trailingAnchor.constraint(equalTo: cell.contentView.trailingAnchor, constant: -15),
            container.bottomAnchor.constraint(equalTo: cell.contentView.bottomAnchor, constant: -8)
        ])
        
        // Date formatting
        let dateFormatter = DateFormatter()
        dateFormatter.dateStyle = .medium
        
        let fromDate = emp.from_date != nil ? dateFormatter.string(from: emp.from_date!) : "-"
        let toDate = emp.to_date != nil ? dateFormatter.string(from: emp.to_date!) : "-"
        let status = emp.is_approved?.lowercased() ?? "pending"
        
        // Title Label (Leave Type)
        let titleLabel = UILabel()
        titleLabel.text = emp.leave_type ?? "-"
        titleLabel.font = UIFont.boldSystemFont(ofSize: 18)
        titleLabel.textColor = .label
        titleLabel.translatesAutoresizingMaskIntoConstraints = false
        container.addSubview(titleLabel)
        
        // Reason Label
        let reasonLabel = UILabel()
        reasonLabel.text = "Reason: \(emp.leave_reason ?? "-")"
        reasonLabel.font = UIFont.systemFont(ofSize: 14)
        reasonLabel.textColor = .secondaryLabel
        reasonLabel.numberOfLines = 2
        reasonLabel.translatesAutoresizingMaskIntoConstraints = false
        container.addSubview(reasonLabel)
        
        // Date Range Label
        let dateLabel = UILabel()
        dateLabel.text = "From: \(fromDate)  To: \(toDate)"
        dateLabel.font = UIFont.systemFont(ofSize: 14)
        dateLabel.textColor = .secondaryLabel
        dateLabel.translatesAutoresizingMaskIntoConstraints = false
        container.addSubview(dateLabel)
        
        // Status Badge Label
        let statusLabel = UILabel()
        statusLabel.font = UIFont.boldSystemFont(ofSize: 14)
        statusLabel.textAlignment = .center
        statusLabel.layer.cornerRadius = 10
        statusLabel.layer.masksToBounds = true
        statusLabel.translatesAutoresizingMaskIntoConstraints = false
        
        switch status {
        case "approved":
            statusLabel.text = "APPROVED"
            statusLabel.backgroundColor = UIColor.systemGreen.withAlphaComponent(0.2)
            statusLabel.textColor = UIColor.systemGreen
        case "rejected":
            statusLabel.text = "REJECTED"
            statusLabel.backgroundColor = UIColor.systemRed.withAlphaComponent(0.2)
            statusLabel.textColor = UIColor.systemRed
        default:
            statusLabel.text = "PENDING"
            statusLabel.backgroundColor = UIColor.systemGray4
            statusLabel.textColor = UIColor.systemGray
        }
        container.addSubview(statusLabel)
        
        // Constraints
        NSLayoutConstraint.activate([
            titleLabel.topAnchor.constraint(equalTo: container.topAnchor, constant: 15),
            titleLabel.leadingAnchor.constraint(equalTo: container.leadingAnchor, constant: 15),
            
            statusLabel.centerYAnchor.constraint(equalTo: titleLabel.centerYAnchor),
            statusLabel.trailingAnchor.constraint(equalTo: container.trailingAnchor, constant: -15),
            statusLabel.widthAnchor.constraint(equalToConstant: 90),
            statusLabel.heightAnchor.constraint(equalToConstant: 25),
            
            reasonLabel.topAnchor.constraint(equalTo: titleLabel.bottomAnchor, constant: 8),
            reasonLabel.leadingAnchor.constraint(equalTo: container.leadingAnchor, constant: 15),
            reasonLabel.trailingAnchor.constraint(equalTo: container.trailingAnchor, constant: -15),
            
            dateLabel.topAnchor.constraint(equalTo: reasonLabel.bottomAnchor, constant: 8),
            dateLabel.leadingAnchor.constraint(equalTo: container.leadingAnchor, constant: 15),
            dateLabel.trailingAnchor.constraint(equalTo: container.trailingAnchor, constant: -15),
            dateLabel.bottomAnchor.constraint(lessThanOrEqualTo: container.bottomAnchor, constant: -15)
        ])
        
        // Remove cell selection style
        cell.selectionStyle = .none
        
        return cell
    }

    func fetchData() {
        guard let loggedInEmpId = UserDefaults.standard.string(forKey: "loggedInUserEmpId") else {
            print("No logged-in user's empId found")
            return
        }

        let appD = UIApplication.shared.delegate as! AppDelegate
        let moc = appD.persistentContainer.viewContext
        let fetchRequest: NSFetchRequest<Leave_Details> = Leave_Details.fetchRequest()

        fetchRequest.predicate = NSPredicate(format: "emp_id == %@", loggedInEmpId)

        do {
            list = try moc.fetch(fetchRequest)
            tblvw.reloadData()
        } catch {
            print("Failed to fetch leave details for empId \(loggedInEmpId): \(error)")
        }
    }

    override func viewWillAppear(_ animated: Bool) {
        super.viewWillAppear(animated)
        fetchData()
    }

    override func viewDidLoad() {
        super.viewDidLoad()

        tblvw.register(UITableViewCell.self, forCellReuseIdentifier: "EmpCell")
        tblvw.isScrollEnabled = true
        tblvw.separatorStyle = .none
        tblvw.backgroundColor = UIColor.systemGroupedBackground
        
        fetchData()
    }
}
