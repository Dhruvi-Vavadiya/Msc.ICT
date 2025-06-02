//
//  dept_item1.swift
//  External_dept_emp
//
//  Created by exam on 24/04/25.
//

import UIKit
import CoreData

class dept_item1: UIViewController {
    
   
    
    var obj = UserDefaults.standard
    override func viewDidLoad() {
        super.viewDidLoad()
        
        let direparth = NSSearchPathForDirectoriesInDomains(.documentDirectory, .userDomainMask, true)
        print(direparth)
        // Do any additional setup after loading the view.
    }
    

    @IBOutlet weak var txt_did: UITextField!
  
    @IBOutlet weak var txt_dname: UITextField!
    
    
   

    @IBAction func btn_insert(_ sender: Any) {
        
        let appD=UIApplication.shared.delegate as! AppDelegate
               let moc=appD.persistentContainer.viewContext
        let studobj = Dept(context:moc)
        studobj.did=Int16(txt_did.text!)!
        studobj.dname=txt_dname.text!
              
               do{
                   try moc.save()
                   obj.set(txt_dname.text! ,forKey: "unm")
                   obj.set(txt_did.text!, forKey: "pwd")
                   
                   let alert=UIAlertController(title: "Success", message: "record inserted successfully...", preferredStyle: .alert)
                   alert.addAction(UIAlertAction(title: "okk", style: .default))
                   present(alert, animated: true)
                   
                   txt_did.text=""
                   txt_dname.text=""
                   
                   
                   
               }catch let error as NSError{
                   print(error)
               }
        
    }
    @IBAction func btn_update(_ sender: Any) {
        
    }
    @IBAction func btn_delete(_ sender: Any) {
        
    }
}
