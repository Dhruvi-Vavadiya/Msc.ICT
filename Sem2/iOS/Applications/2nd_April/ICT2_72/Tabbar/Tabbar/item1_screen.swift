//
//  item1_screen.swift
//  Tabbar
//
//  Created by mscit on 2/21/25.
//

import UIKit

class item1_screen: UIViewController {

    @IBOutlet weak var lbl_welcome: UILabel!
    override func viewDidLoad() {
        super.viewDidLoad()
        
        lbl_welcome.text="Welcome ios"

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
