    //
    //  emp_item2.swift
    //  External_dept_emp
    //
    //  Created by exam on 24/04/25.
    //

    import UIKit
    import CoreData

    class emp_item2: UIViewController,UITableViewDelegate,UITableViewDataSource {
        
        var emps: [Emp] = []
        var selectupdate:Emp?
        override func viewDidLoad() {
            super.viewDidLoad()
            fetchEmployee()
            tabletv.register(UITableViewCell.self, forCellReuseIdentifier: "cell")
            // Do any additional setup after loading the view.
        }
        @IBOutlet weak var tabletv: UITableView!
        
        func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
            return emps.count
        }
        
        func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
            let cell = tabletv.dequeueReusableCell(withIdentifier: "cell",for: indexPath)
            let e = emps[indexPath.row]
            
            
            let appD=UIApplication.shared.delegate as! AppDelegate
                   let moc=appD.persistentContainer.viewContext
            let fetch:NSFetchRequest<Dept> = Dept.fetchRequest()
            fetch.predicate = NSPredicate(format: "did == %d", e.did)
            
            let depts = try! moc.fetch(fetch)
            
            
            if let dept = depts.first {  // safely unwrapping the first Dept object
                      cell.textLabel?.text = "\(e.eid ?? 0) - \(e.ename ?? "") - \(dept.dname ?? "")"
                  } else {
                      cell.textLabel?.text = "\(e.eid ?? 0) - \(e.ename ?? "") - No Department"
                  }
            return cell
        }
        func fetchEmployee(){
               let appD = UIApplication.shared.delegate as! AppDelegate
               let mo = appD.persistentContainer.viewContext
            let request: NSFetchRequest<Emp> = Emp.fetchRequest()
               do{
                   emps = try mo.fetch(request)
                   tabletv.reloadData()
               }catch{
                   //alert
               }
           }

        
        

        var obj = UserDefaults.standard
        @IBOutlet weak var txt_esalaray: UITextField!
        @IBOutlet weak var txt_ename: UITextField!
        @IBOutlet weak var txt_eid: UITextField!
        
        @IBOutlet weak var txt_dept_id: UITextField!
        
        @IBAction func btn_insert(_ sender: Any) {
            let appD=UIApplication.shared.delegate as! AppDelegate
                   let moc=appD.persistentContainer.viewContext
            
            let employee = Emp(context: moc)
            
            employee.eid = Int16(txt_eid.text!)!
            employee.ename = txt_ename.text
            employee.esalary = Int16(txt_esalaray.text!)!
            employee.did = Int16(txt_dept_id.text!)!
            
            let fetch:NSFetchRequest<Dept> = Dept.fetchRequest()
            fetch.predicate = NSPredicate(format: "did == %d", employee.did)
            
            do{
                let depts = try moc.fetch(fetch)
                
                if depts.isEmpty{
                    var alrt = UIAlertController(title: "not valid", message: "enter unm and pwd", preferredStyle: .alert)
                    alrt.addAction(UIAlertAction(title: "enter uname and pwd", style: .default))
                    present(alrt, animated: true)
                    return
                }
                try moc.save()
               
                
                let alert=UIAlertController(title: "Success", message: "record inserted successfully...", preferredStyle: .alert)
                alert.addAction(UIAlertAction(title: "okk", style: .default))
                present(alert, animated: true)
                
                txt_ename.text=""
                txt_eid.text=""
                
                
                
            }catch let error as NSError{
                print(error)
            }
            
        }
        
        func tableView(_ tableView: UITableView, didSelectRowAt indexPath: IndexPath) {
             
               let e = emps[indexPath.row]
            txt_eid.text = "\(e.eid)"
            txt_ename.text = e.ename
            txt_esalaray.text = "\(e.esalary)"
               
             
              
             
             
               selectupdate = e

           }
        
        @IBAction func btn_update(_ sender: Any) {
            guard let selectemp = selectupdate else{
                       
                            return
                    }
            selectemp.eid = Int16(txt_eid.text!)!
            selectemp.ename = txt_ename.text!
            selectemp.esalary = Int16(txt_esalaray.text!)!
                    
                    
                    
                    
                            let appD = UIApplication.shared.delegate as! AppDelegate
                           let mo = appD.persistentContainer.viewContext
                        do{
                            try! mo.save()
                            let alert=UIAlertController(title: "Success", message: "record inserted successfully...", preferredStyle: .alert)
                            alert.addAction(UIAlertAction(title: "okk", style: .default))
                            present(alert, animated: true)
                                    self.fetchEmployee()
                        }catch{
                            var alrt = UIAlertController(title: "not valid", message: "enter unm and pwd", preferredStyle: .alert)
                            alrt.addAction(UIAlertAction(title: "enter uname and pwd", style: .default))
                            present(alrt, animated: true)
            //              print("Error updating employee : \(error)")
                            
                        }
        }
        
        @IBAction func btn_delete(_ sender: Any) {
            
            let appD = UIApplication.shared.delegate as! AppDelegate
                  let mo = appD.persistentContainer.viewContext
                  
                  //delete using text box txtx_id
                  let fre = NSFetchRequest<NSFetchRequestResult>(entityName: "Emp")
                  
                  //filtering
            fre.predicate = NSPredicate(format: "eid=%@",txt_eid.text!)
                  
                          do{
                              let result = try! mo.fetch(fre)
                              let obj = result[0] as! NSManagedObject
                              mo.delete(obj)
                              do{
                                  try! mo.save()
                                  let alert=UIAlertController(title: "Success", message: "record deleted successfully...", preferredStyle: .alert)
                                  alert.addAction(UIAlertAction(title: "okk", style: .default))
                                  present(alert, animated: true)
//                                  self.loadalert(string: "Error", string: "delete sucessfully")
                                  fetchEmployee()
                              }catch{
//                                  self.loadalert(string: "btn_delete", string: "\(error)")
                              }
                          }catch{
//                              self.loadalert(string: "btn_delete", string: "\(error)")
                          }
        }
    }
