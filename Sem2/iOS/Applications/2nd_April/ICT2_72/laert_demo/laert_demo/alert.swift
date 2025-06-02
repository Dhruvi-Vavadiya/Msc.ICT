//
//  ViewController.swift
//  laert_demo
//
//  Created by mscit on 2/19/25.
//

import UIKit

class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    @IBOutlet weak var txt_box: UITextField!
    
    @IBAction func btn_alert(_ sender: Any) {
        /*
        let alert=UIAlertController(title: "my alert dialog", message: "Welcome to ios alert", preferredStyle: .alert)
        
        alert.addTextField(configurationHandler: {(t1) in  t1.text="entre your name"})
        
        alert.addAction(UIAlertAction(title: "ok", style: .default,handler: {_ in print(alert.textFields?[0].text!)}))
        
        alert.addAction(UIAlertAction(title: "Cancel", style: .cancel))
        
        alert.addTextField(configurationHandler: {(t2) in t2.text="Enter password";t2.isSecureTextEntry=true})
        
        self.present(alert, animated: true)
         */
        
       // action(bottom) sheet
        let actionsheet = UIAlertController(title: "my action sheet", message: "click on option", preferredStyle: .actionSheet)
        
        actionsheet.addAction(UIAlertAction(title: "OK", style: .default,handler: {_ in print("ok clicked")}))
        
        actionsheet.addAction(UIAlertAction(title: "More", style: .default,handler: {_ in print("more clicked")}))

        actionsheet.addAction(UIAlertAction(title: "Destruct", style: .destructive,handler: {_ in print("destruct clicked")}))

        
        self.present(actionsheet, animated: true)
    }
}

