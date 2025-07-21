import UIKit
import CoreData

class ManageLeaveViewController: UIViewController, UITableViewDelegate, UITableViewDataSource {
    
    var list: [Leave_Details] = []
    
    @IBOutlet weak var tblvw: UITableView!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        tblvw.delegate = self
        tblvw.dataSource = self
        
        // Use default separators for clarity
        tblvw.separatorStyle = .singleLine
        tblvw.rowHeight = UITableView.automaticDimension
        tblvw.estimatedRowHeight = 140
        
        fetchData()
    }
    
    func fetchData() {
        let appD = UIApplication.shared.delegate as! AppDelegate
        let moc = appD.persistentContainer.viewContext
        let fetchRequest: NSFetchRequest<Leave_Details> = Leave_Details.fetchRequest()
        do {
            list = try moc.fetch(fetchRequest)
            tblvw.reloadData()
        } catch {
            print("Failed to fetch leaves: \(error)")
        }
    }
    
    // MARK: - TableView DataSource
    
    func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return list.count
    }
    
    func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {

        let cellId = "EmpCell"
        let cell = tableView.dequeueReusableCell(withIdentifier: cellId) ??
            UITableViewCell(style: .default, reuseIdentifier: cellId)
        
        cell.selectionStyle = .none
        
        // Clear previous subviews
        cell.contentView.subviews.forEach { $0.removeFromSuperview() }
        
        let leave = list[indexPath.row]
        
        // Container view (card style)
        let container = UIView()
        container.translatesAutoresizingMaskIntoConstraints = false
        container.backgroundColor = UIColor.systemBackground
        container.layer.cornerRadius = 12
        container.layer.shadowColor = UIColor.black.cgColor
        container.layer.shadowOpacity = 0.1
        container.layer.shadowRadius = 4
        container.layer.shadowOffset = CGSize(width: 0, height: 2)
        
        cell.contentView.addSubview(container)
        
        NSLayoutConstraint.activate([
            container.topAnchor.constraint(equalTo: cell.contentView.topAnchor, constant: 8),
            container.leadingAnchor.constraint(equalTo: cell.contentView.leadingAnchor, constant: 16),
            container.trailingAnchor.constraint(equalTo: cell.contentView.trailingAnchor, constant: -16),
            container.bottomAnchor.constraint(equalTo: cell.contentView.bottomAnchor, constant: -8)
        ])
        
        // Vertical StackView to hold all info labels
        let infoStack = UIStackView()
        infoStack.axis = .vertical
        infoStack.spacing = 6
        infoStack.translatesAutoresizingMaskIntoConstraints = false
        
        container.addSubview(infoStack)
        
        NSLayoutConstraint.activate([
            infoStack.topAnchor.constraint(equalTo: container.topAnchor, constant: 12),
            infoStack.leadingAnchor.constraint(equalTo: container.leadingAnchor, constant: 12),
            infoStack.trailingAnchor.constraint(equalTo: container.trailingAnchor, constant: -12)
        ])
        
        // Helper to create label with bold title and regular detail
        func makeLabel(title: String, detail: String) -> UILabel {
            let label = UILabel()
            label.numberOfLines = 0
            let attributed = NSMutableAttributedString(
                string: title + ": ",
                attributes: [.font: UIFont.boldSystemFont(ofSize: 14)]
            )
            attributed.append(NSAttributedString(
                string: detail,
                attributes: [.font: UIFont.systemFont(ofSize: 14)]
            ))
            label.attributedText = attributed
            return label
        }
        
        // Date formatter
        let dateFormatter = DateFormatter()
        dateFormatter.dateStyle = .medium
        
        // Labels for info
        let emailLabel = makeLabel(title: "Employee Email", detail: leave.email ?? "-")
        let typeLabel = makeLabel(title: "Type", detail: leave.leave_type ?? "-")
        let reasonLabel = makeLabel(title: "Reason", detail: leave.leave_reason ?? "-")
        let statusLabel = makeLabel(title: "Status", detail: (leave.is_approved ?? "Pending").capitalized)
        
        let fromDate = leave.from_date != nil ? dateFormatter.string(from: leave.from_date!) : "-"
        let toDate = leave.to_date != nil ? dateFormatter.string(from: leave.to_date!) : "-"
        let dateLabel = makeLabel(title: "From-To", detail: "\(fromDate) to \(toDate)")
        
        // Add all labels to stack
        [emailLabel, typeLabel, reasonLabel, statusLabel, dateLabel].forEach { infoStack.addArrangedSubview($0) }
        
        // Horizontal stack view for buttons
        let buttonStack = UIStackView()
        buttonStack.axis = .horizontal
        buttonStack.spacing = 16
        buttonStack.distribution = .fillEqually
        buttonStack.translatesAutoresizingMaskIntoConstraints = false
        
        container.addSubview(buttonStack)
        
        NSLayoutConstraint.activate([
            buttonStack.topAnchor.constraint(equalTo: infoStack.bottomAnchor, constant: 12),
            buttonStack.leadingAnchor.constraint(equalTo: container.leadingAnchor, constant: 12),
            buttonStack.trailingAnchor.constraint(equalTo: container.trailingAnchor, constant: -12),
            buttonStack.bottomAnchor.constraint(equalTo: container.bottomAnchor, constant: -12),
            buttonStack.heightAnchor.constraint(equalToConstant: 40)
        ])
        
        // Approve Button
        let approveButton = UIButton(type: .system)
        approveButton.setTitle("Approve", for: .normal)
        approveButton.backgroundColor = UIColor.systemGreen.withAlphaComponent(0.15)
        approveButton.tintColor = .systemGreen
        approveButton.layer.cornerRadius = 8
        approveButton.titleLabel?.font = UIFont.boldSystemFont(ofSize: 16)
        approveButton.tag = indexPath.row
        approveButton.addTarget(self, action: #selector(approveLeave(_:)), for: .touchUpInside)
        
        // Reject Button
        let rejectButton = UIButton(type: .system)
        rejectButton.setTitle("Reject", for: .normal)
        rejectButton.backgroundColor = UIColor.systemRed.withAlphaComponent(0.15)
        rejectButton.tintColor = .systemRed
        rejectButton.layer.cornerRadius = 8
        rejectButton.titleLabel?.font = UIFont.boldSystemFont(ofSize: 16)
        rejectButton.tag = indexPath.row
        rejectButton.addTarget(self, action: #selector(rejectLeave(_:)), for: .touchUpInside)
        
        buttonStack.addArrangedSubview(approveButton)
        buttonStack.addArrangedSubview(rejectButton)
        
        return cell
    }
    
    // MARK: - TableView Delegate
    
    func tableView(_ tableView: UITableView, heightForRowAt indexPath: IndexPath) -> CGFloat {
        UITableView.automaticDimension
    }
    
    // MARK: - Button Actions
    
    @objc func approveLeave(_ sender: UIButton) {
        updateLeaveStatus(at: sender.tag, approved: true)
    }
    
    @objc func rejectLeave(_ sender: UIButton) {
        updateLeaveStatus(at: sender.tag, approved: false)
    }
    
    // MARK: - Update Leave Status
    
    func updateLeaveStatus(at index: Int, approved: Bool) {
        let appD = UIApplication.shared.delegate as! AppDelegate
        let moc = appD.persistentContainer.viewContext
        let leave = list[index]
        
        leave.is_approved = approved ? "approved" : "rejected"
        
        do {
            try moc.save()
            // Show toast-style confirmation (instead of alert)
            showToast(message: "Leave has been \(leave.is_approved ?? "")")
            fetchData()
        } catch {
            print("Failed to update leave status: \(error)")
        }
    }
    
    // MARK: - Toast Message
    
    func showToast(message : String, font: UIFont = UIFont.systemFont(ofSize: 14)) {
        let toastLabel = UILabel()
        toastLabel.backgroundColor = UIColor.black.withAlphaComponent(0.7)
        toastLabel.textColor = UIColor.white
        toastLabel.font = font
        toastLabel.textAlignment = .center;
        toastLabel.text = message
        toastLabel.alpha = 0.0
        toastLabel.numberOfLines = 0
        toastLabel.layer.cornerRadius = 10;
        toastLabel.clipsToBounds  =  true
        
        toastLabel.translatesAutoresizingMaskIntoConstraints = false
        view.addSubview(toastLabel)
        
        NSLayoutConstraint.activate([
            toastLabel.leadingAnchor.constraint(equalTo: view.leadingAnchor, constant: 40),
            toastLabel.trailingAnchor.constraint(equalTo: view.trailingAnchor, constant: -40),
            toastLabel.bottomAnchor.constraint(equalTo: view.safeAreaLayoutGuide.bottomAnchor, constant: -40),
            toastLabel.heightAnchor.constraint(greaterThanOrEqualToConstant: 35)
        ])
        
        UIView.animate(withDuration: 0.5, animations: {
            toastLabel.alpha = 1.0
        }) { (_) in
            UIView.animate(withDuration: 0.5, delay: 2.0, options: [], animations: {
                toastLabel.alpha = 0.0
            }) { (_) in
                toastLabel.removeFromSuperview()
            }
        }
    }
}
