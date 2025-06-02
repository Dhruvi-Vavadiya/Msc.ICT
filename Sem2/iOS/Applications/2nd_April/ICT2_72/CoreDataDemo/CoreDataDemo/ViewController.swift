//
//  ViewController.swift
//  CoreDataDemo
//
//  Created by mscit on 2/6/25.
//

import UIKit
import CoreData

class ViewController: UIViewController {

    @IBOutlet weak var txt_rn: UITextField!
    
    @IBOutlet weak var txt_address: UITextField!
    
    @IBOutlet weak var txt_age: UITextField!
    
    
    override func viewDidLoad() {
        super.viewDidLoad()
            
        let dirPath = NSSearchPathForDirectoriesInDomains(.documentDirectory, .userDomainMask, true)
        print(dirPath[0])

       // add_record()
      //  read_data()
       // del_rec()
       // update_record()
        
       
    }
    
    @IBAction func add_record(){
        let appD=UIApplication.shared.delegate as! AppDelegate

            //memery to secondary storege
        let mangeObjectCont = appD.persistentContainer.viewContext
        
//        ===================================

        //Entity
        let student=NSEntityDescription.entity(forEntityName: "Stud", in: mangeObjectCont)!

        //blank record in memery
        let data = NSManagedObject(entity: student, insertInto: mangeObjectCont)

        data.setValue(Int32(txt_rn.text!), forKey: "rn")
        data.setValue(txt_age.text!, forKey: "age")
        data.setValue(txt_address.text!, forKey: "address")

        do{
           try mangeObjectCont.save()
            print("Record inserteedddd....")
        }catch{

        }
    }
    
    //read data fetch data
    @IBAction func read_data(){
        let appD1=UIApplication.shared.delegate as! AppDelegate

            //memery to secondary storege
        let mangeObjectCont1 = appD1.persistentContainer.viewContext
        
        //NSFe(entityname:)
        let fr=NSFetchRequest<NSManagedObject>(entityName: "Stud")
        
        do{
            let result=try mangeObjectCont1.fetch(fr)
            
            for data in result
            {
                print(data.value(forKey: "rn"))
                print(data.value(forKey: "age")!)
                print(data.value(forKey: "address")!)
            }
        }catch{
            
        }
    }
    
    @IBAction func del_rec()
        {
            let appD2=UIApplication.shared.delegate as! AppDelegate

                //memery to secondary storege
            let mangeObjectCont2 = appD2.persistentContainer.viewContext
            
            let fre=NSFetchRequest<NSFetchRequestResult>(entityName: "Stud")
            
            //filtering
            fre.predicate=NSPredicate(format: "age=%@", txt_age!)
            
            do{
                let results = try mangeObjectCont2.fetch(fre)
                let obj = results[0] as! NSManagedObject
                mangeObjectCont2.delete(obj)
                do{
                    try mangeObjectCont2.save()
                    print("Record deleted....")
                }catch{
                    
                }
            }catch{
                
            }
        }
    
    //update
    @IBAction func update_record()
        {
            let appD3=UIApplication.shared.delegate as! AppDelegate

                //memery to secondary storege
            let mangeObjectCont3 = appD3.persistentContainer.viewContext
            
            let fre=NSFetchRequest<NSFetchRequestResult>(entityName: "Stud")
            
            //filtering
            fre.predicate=NSPredicate(format: "address=%@", "Rajkot")
            
            do{
                let results = try mangeObjectCont3.fetch(fre)
                let obj = results[0] as! NSManagedObject
                //mangeObjectCont2.delete(obj)
                obj.setValue("jamnager", forKey: "address")
                do{
                    try mangeObjectCont3.save()
                    print("Record updated....")
                }catch{
                    
                }
            }catch{
                
            }
        }
    //end update_record function


   
}

