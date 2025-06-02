//
//  dvc_fileViewController.swift
//  Question_6
//
//  Created by Ictbatch1 on 18/03/25.
//

import UIKit

class dvc_fileViewController: UIViewController {

    @IBOutlet weak var lbl_text: UILabel!
    var msg:String=""
    var num:String=""
    
    override func viewDidLoad() {
        super.viewDidLoad()
        lbl_text.text=msg.description
        // Do any additional setup after loading the view.
    }
    

    /*
    // MARK: - Navigation

    // In a storyboard-based application, you will often want to do a little preparation before navigation
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        // Get the new view controller using segue.destination.
        // Pass the selected object to the new view controller.
    }
    */

}
