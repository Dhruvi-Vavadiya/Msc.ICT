//
//  ViewController.swift
//  UserDefault
//
//  Created by mscit on 2/20/25.
//

import UIKit

class ViewController: UIViewController {
    
    let obj=UserDefaults.standard
    @IBOutlet weak var txt_pwd: UITextField!
    @IBOutlet weak var txt_unm: UITextField!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        let uname=obj.object(forKey: "unm")
        let pwd=obj.object(forKey: "pwd")
        
        txt_unm.text=uname as! String?
        txt_pwd.text=pwd as! String?
    }


    @IBAction func btn_save(_ sender: Any) {
        obj.set(txt_unm.text, forKey: "unm")
        obj.set(txt_pwd.text, forKey: "pwd")
    }
    @IBAction func btn_reset(_ sender: Any) {
    }
    
}

