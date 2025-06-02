//
//  ViewController.swift
//  Login_Registar
//
//  Created by Ictbatch1 on 01/04/25.
//


//one viewcontroller
//button navigate -> click show
//segue slick identifier name s1
//create cococa touch file
//view controller first yellow button click cusom class file name

import UIKit
import CoreData

class ViewController: UIViewController {
   

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        
//        self.navigationItem.hidesBackButton=true
//        if(UserDefaults.standard.bool(forKey: "isLog")){
//            navigateToDVC()
//        }
    }

    @IBOutlet weak var txt_pwd: UITextField!
    @IBOutlet weak var txt_unm: UITextField!
    
   
    @IBAction func btn_login(_ sender: Any) {
        if(txt_unm.text != "" && txt_pwd.text != ""){
            if txt_unm.text == "admin" && txt_pwd.text == "123"
            {
                //2 para
//                UserDefaults.standard.set(true, forKey: "isLog")
//                navigateToDVC()
                //performseg.. //2 para
                performSegue(withIdentifier: "s1", sender: self)
            }else{
                //3 para
                let ale = UIAlertController(title: "", message: "Invalid username or password", preferredStyle: .alert)
                ale.addAction(UIAlertAction(title: "dismiss", style: .cancel))
                present(ale, animated: true)
                
            }
        }else{
            var err:String = " ";
            if(txt_unm.text == "" && txt_pwd.text == ""){
                err = "Enter email and password"
            }else if(txt_unm.text == " " ){
                err = "Enter email"
            }else{
                err = "Enter password"
            }
            //ui alert controller //3 para
            let alert = UIAlertController(title: "", message: err, preferredStyle: .alert)
            
            alert.addAction(UIAlertAction(title: "dismiss", style: .cancel))
            present(alert, animated: true)
        }
    }
    
    //func
    func navigateToDVC(){
        // ?.instantiate view controller // 1 paara
        let  s1 = self.storyboard?.instantiateViewController(withIdentifier: "s1") as? dvcsegue
        self.navigationController?.pushViewController(s1!, animated: true)
    }
    
    
    
}
