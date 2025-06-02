//
//  ViewController.swift
//  gesture_demo_2025
//
//  Created by Ictbatch1 on 21/03/25.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var btn: UIButton!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        let tabG=UITapGestureRecognizer(target: self, action: #selector(tapR))
        btn.addGestureRecognizer(tabG)
        
        let tabL=UILongPressGestureRecognizer(target: self, action: #selector(tapL))
        btn.addGestureRecognizer(tabL)
        let swap=UISwipeGestureRecognizer(target: self, action: #selector(tapSw))
        btn.addGestureRecognizer(swap)
    }
 

    @objc func tapR(){
        print("Tap Recognised.....")
    }
    @objc func tapL(){
        print("Log Press Recognised.....")
    }
    @objc func tapSw(){
        print("Log Press Recognised.....")
    }
}

