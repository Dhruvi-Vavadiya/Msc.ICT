//
//  ViewController.swift
//  Question_4
//
//  Created by Ictbatch1 on 18/03/25.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var lbl_nm: UILabel!
    @IBOutlet weak var txt_nm: UITextField!
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    @IBAction func btn_text(_ sender: Any) {
        lbl_nm.text = "Hello \(txt_nm.text!)"
    }
    
}

