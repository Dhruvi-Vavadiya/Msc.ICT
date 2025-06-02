//
//  ViewController.swift
//  example
//
//  Created by mscit on 1/21/25.
//

import UIKit

class ViewController: UIViewController {
    @IBOutlet weak var mylabel: UILabel!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
//        mylabel.text="Welcome"
    }

    @IBAction func btnclick(_ sender: Any) {
        mylabel.text="Welcome"
    }
    
    @IBOutlet var mainn: UIView!
    @IBOutlet weak var msg: UILabel!
    @IBOutlet weak var change_small: UIButton!
    
    @IBOutlet weak var change_medium: UIButton!
    
    @IBOutlet weak var change_large: UIButton!
    
    @IBAction func btn_small(_ sender: Any) {
        msg.font = UIFont.systemFont(ofSize: 10)
        msg.textColor = UIColor.systemBlue
        msg.text = "Small text"
//        mainn.backgroundColor = UIColor.init(red: 255, green: 247, blue: 152, alpha: 1)
        change_small.setTitle("ClickMe", for: .normal)
        change_medium.setTitle("Medium", for: .normal)
        change_large.setTitle("Large", for: .normal)
    }
    
   
    @IBAction func btn_medium(_ sender: Any) {
        msg.font = UIFont.systemFont(ofSize: 20)
        msg.textColor = UIColor.systemPink
        msg.text = "Medium text"
        mainn.backgroundColor = UIColor.init(named: "green")
        change_small.setTitle("Small", for: .normal)
        change_medium.setTitle("ClickMe", for: .normal)
        change_large.setTitle("Large", for: .normal)
    }
    
    @IBAction func btn_large(_ sender: Any) {
        msg.font = UIFont.systemFont(ofSize: 30)
        msg.textColor = UIColor.systemYellow
        msg.text = "Large text"
        mainn.backgroundColor = UIColor.init(named: "blue")
        change_small.setTitle("Small", for: .normal)
        change_medium.setTitle("Medium", for: .normal)
        change_large.setTitle("Clickme", for: .normal)
    }
    
    
}

