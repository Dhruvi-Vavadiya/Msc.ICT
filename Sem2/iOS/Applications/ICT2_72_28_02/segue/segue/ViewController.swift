//
//  ViewController.swift
//  segue
//
//  Created by mscit on 1/24/25.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet var txt_unm: UITextField!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        if segue.identifier == "mysegue"
        {
            let destination_obj = segue.destination as! destination
            destination_obj.msg=txt_unm.text!
        }
    }
    
    @IBAction func btn_clickme(_ sender: Any) {
        
    }
    
}

