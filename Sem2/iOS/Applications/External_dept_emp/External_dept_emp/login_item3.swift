//
//  login_item3.swift
//  External_dept_emp
//
//  Created by exam on 24/04/25.
//

import UIKit
import CoreData

class login_item3: UIViewController {

    var obj = UserDefaults.standard
    
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
    }
    
    @IBOutlet weak var txt_unm: UITextField!
    
    @IBOutlet weak var txt_pwd: UITextField!
    
    @IBAction func btn_login(_ sender: Any) {
        let appD = UIApplication.shared.delegate as! AppDelegate
               let moc = appD.persistentContainer.viewContext
        
        let fetch: NSFetchRequest<Dept> = Dept.fetchRequest()
        fetch.predicate = NSPredicate(format: "dname =[c] %@ AND did == %@", txt_unm.text!, txt_pwd.text!)


        
        if txt_unm.text != "" && txt_pwd.text != ""{
            
            let depts = try! moc.fetch(fetch)
            if let _ = depts.first {
                
                           // Login validated
                obj.set(txt_unm.text! ,forKey: "unm")
                obj.set(txt_pwd.text!, forKey: "pwd")
                
                var alrt = UIAlertController(title: "donee  ", message: "enter unm and pwd", preferredStyle: .alert)
                alrt.addAction(UIAlertAction(title: "ok", style: .default))
                present(alrt, animated: true)
                
            }else{
                var alrt = UIAlertController(title: "not valid", message: "enter unm and pwd", preferredStyle: .alert)
                alrt.addAction(UIAlertAction(title: "cancel", style: .default))
                present(alrt, animated: true)
            }
            
        }else{
            var alrt = UIAlertController(title: "not valid", message: "enter unm and pwd", preferredStyle: .alert)
            alrt.addAction(UIAlertAction(title: "enter uname and pwd", style: .default))
            present(alrt, animated: true)
        }
        
    }
    

}
