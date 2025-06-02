//
//  ViewController.swift
//  CoreData_OOP
//
//  Created by Ictbatch1 on 27/03/25.
//

//two way to perform crud in core data
//1.hanTraditional
//2.oops

//create entity
//select entity attribute inspector change codegen select maual/none
//select editor=> create NSMAnagedObject subclass and add enetity
import UIKit
import CoreData

class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        /*
        // Do any additional setup after loading the view.
        let appD1 = UIApplication.shared.delegate as! AppDelegate
        let moc1 = appD1.persistentContainer.viewContext
        let obj = Emp(context: moc1)
        
        obj.eid = 20
        obj.ename = "nenu"
        obj.eage = 16
        
        let obj2 = Esalary(context: moc1)
        obj2.eid = 20
        obj2.ebasic = 20.67
        obj2.ehra = 20.66
        obj2.eda = 20.00
        
        let obj3 = Esalary(context: moc1)
        obj3.eid = 20
        obj3.ebasic = 20.09
        obj3.ehra = 20.43
        obj3.eda = 20.76
        
        obj.toEsalary = NSSet.init(array: [obj2,obj3])
        
        
        
        do{
           try moc1.save()
            print("Record inserted... ")
            let path=NSSearchPathForDirectoriesInDomains(.documentDirectory, .userDomainMask, true)
            print(path[0])
        }catch{
            
        }
         */
    }


    @IBAction func btn_del(_ sender: Any) {
        let appD2 = UIApplication.shared.delegate as! AppDelegate
        let moc2 = appD2.persistentContainer.viewContext
        
        let fr=NSFetchRequest<NSFetchRequestResult>(entityName: "Emp")
        do{
           let delRecords = try! moc2.fetch(fr)
            for r in delRecords as! [NSManagedObject]{
                moc2.delete(r)
                print(r)
            }
          try  moc2.save()
        }
        catch{
            
        }
    }
}

