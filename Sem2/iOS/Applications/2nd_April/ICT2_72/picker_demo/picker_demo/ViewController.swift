//
//  ViewController.swift
//  picker_demo
//
//  Created by ICT-2 Batch1 on 1/25/25.
//

import UIKit

class ViewController: UIViewController,UIPickerViewDelegate,UIPickerViewDataSource {
    
    var fruit = ""
    var color = ""
    
    @IBOutlet weak var outputlbl: UILabel!
    
    func pickerView(_ pickerView: UIPickerView, didSelectRow row: Int, inComponent component: Int) {
        
        outputlbl.text = fruits[row]
    }
    
    func numberOfComponents(in pickerView: UIPickerView) -> Int {
        return 2
    }
    
    func pickerView(_ pickerView: UIPickerView, numberOfRowsInComponent component: Int) -> Int {
        if component == 1
        {
            return fruits.count
        }
        else{
            return color.count
        }
        
    }
    func pickerView(_ pickerView: UIPickerView, titleForRow row: Int, forComponent component: Int) -> String? {
        if component == 1
        {
            return fruits[row]
        }
        else{
            return color[row]
        }
        
    }
    
    
    
    
    var fruits:[String] = ["Apple","gavava","Banana","Mengo"]
    var color:[String] = ["red","blue","green","white"]
    
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
       
        
    }


}

