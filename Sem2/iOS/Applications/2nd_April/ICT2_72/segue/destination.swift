//
//  destination.swift
//  segue
//
//  Created by mscit on 1/24/25.
//

import UIKit

class destination: UIViewController {
    @IBOutlet weak var lbl: UILabel!
    
    var msg:String=""
    
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
        lbl.text=msg.description
    }
    
//    lbl.text=msg.description
    
    
    

}
