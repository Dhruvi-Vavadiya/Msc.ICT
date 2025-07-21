//
//  ApplyLeaveViewController.swift
//  stafflio_app
//
//  Created by Batch1 on 11/06/25.
//

import UIKit
import CoreData

class ApplyLeaveViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
    }
    
    
    @IBOutlet weak var txt_from_date: UIDatePicker!
    @IBOutlet weak var txt_leave_type: UISegmentedControl!
   
    
    @IBOutlet weak var txt_leave_reason: UITextField!
    @IBOutlet weak var txt_to_date: UIDatePicker!
    
    @IBAction func btn_apply_leave_click(_ sender: Any) {
        let loggedInEmpId = UserDefaults.standard.string(forKey: "loggedInUserEmpId")
        let appD=UIApplication.shared.delegate as! AppDelegate
        let moc=appD.persistentContainer.viewContext
        let leave=Leave_Details(context: moc)
       
        leave.emp_id=Int32(loggedInEmpId!) ?? 0
        leave.from_date=txt_from_date.date
        leave.to_date=txt_to_date.date
        leave.leave_reason=txt_leave_reason.text
        leave.is_approved="pending"
        guard let loggedInEmail = UserDefaults.standard.string(forKey: "loggedInEmail") else {
            print("No logged-in user's email found")
            return
        }
        leave.email=loggedInEmail
        if(txt_leave_type.selectedSegmentIndex == 0){
            leave.leave_type="Single Day"
        }
        else if (txt_leave_type.selectedSegmentIndex==1){
            leave.leave_type="Multiple Day"
        }
        else{
            leave.leave_type="Half Day"
        }
        
        let fetchRequest: NSFetchRequest<Leave_Details> = Leave_Details.fetchRequest()
        let sortDescriptor = NSSortDescriptor(key: "leave_id", ascending: false)
        fetchRequest.sortDescriptors = [sortDescriptor]
        fetchRequest.fetchLimit = 1

        do {
            let lastLeaves = try moc.fetch(fetchRequest)
            let lastId = lastLeaves.first?.leave_id ?? 0
            leave.leave_id = lastId + 1
        } catch {
            print("Failed to fetch last leave ID: \(error)")
            leave.leave_id = 1 // fallback
        }

     
        
        
    
        
        do{
           
            try moc.save()
            view.endEditing(true)
               let alert = UIAlertController(
                   title: "Leave Applied",
                   message: "Your leave has been successfully submitted!",
                   preferredStyle: .alert
               )
               alert.addAction(UIAlertAction(title: "OK", style: .default, handler: { _ in
                   
                   self.txt_leave_reason.text = ""
                   self.txt_from_date.date = Date()
                   self.txt_to_date.date = Date()
                   self.txt_leave_type.selectedSegmentIndex = 0
               }))
               present(alert, animated: true)
               
           } catch {
               print("Error saving leave: \(error)")
               view.endEditing(true)  
             
               let errorAlert = UIAlertController(
                   title: "Error",
                   message: "Something went wrong while applying for leave.",
                   preferredStyle: .alert
               )
               errorAlert.addAction(UIAlertAction(title: "OK", style: .default))
               present(errorAlert, animated: true)
           }
        
    }
    
    
    /*
    // MARK: - Navigation

    // In a storyboard-based application, you will often want to do a little preparation before navigation
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        // Get the new view controller using segue.destination.
        // Pass the selected object to the new view controller.
    }
    */

}
