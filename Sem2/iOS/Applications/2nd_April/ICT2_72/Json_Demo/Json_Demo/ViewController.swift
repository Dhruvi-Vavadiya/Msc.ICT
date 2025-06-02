//
//  ViewController.swift
//  Json_Demo
//
//  Created by Ictbatch1 on 26/03/25.
//

import UIKit

class ViewController: UIViewController {
    //create json file
//    step 1:- select project right click new file
//    step 2 :- select swift file
//    step 3 :- give file name.json
//    and create

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        
        let path=Bundle.main.url(forResource: "response", withExtension: "json")!
        let data=(try? Data(contentsOf: path))!
        let json=try?JSONSerialization.jsonObject(with: data)
        let dict = json as? [String : Any]
        let rn=dict?["rn"] as? Int
            print(rn)
        
       
    }


}

