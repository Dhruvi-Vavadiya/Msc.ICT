//
//  dvc.swift
//  segue_dest
//
//  Created by mscit on 1/24/25.
//

import UIKit

class dvc: UIViewController {
    
    var msg:String=""
    var num:String=""
   
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
        
        lbl_text.text=msg.description
       
        
    }
    

    @IBOutlet weak var lbl_text: UILabel!
   
   
    
}
