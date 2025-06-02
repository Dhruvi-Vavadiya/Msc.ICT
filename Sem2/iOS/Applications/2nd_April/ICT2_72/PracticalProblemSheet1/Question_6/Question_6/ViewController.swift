//
//  ViewController.swift
//  Question_6
//
//  Created by Ictbatch1 on 18/03/25.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var text_number: UITextField!
   
    @IBOutlet weak var text_unm: UITextField!
    
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        if segue.identifier == "s1_segue"
        {
            let obj = segue.destination as! dvc_fileViewController
            obj.msg=text_unm.text! + text_number.text!

        }
    }

}

