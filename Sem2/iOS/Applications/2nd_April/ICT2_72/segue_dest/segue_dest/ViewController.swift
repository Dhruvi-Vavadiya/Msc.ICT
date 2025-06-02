//
//  ViewController.swift
//  segue_dest
//
//  Created by mscit on 1/24/25.
//

import UIKit

class ViewController:UIViewController,UIPickerViewDelegate,UIPickerViewDataSource {
    
    //generate automatically when you are implement the UIPickerViewDelegate,UIPickerViewDataSource
    func numberOfComponents(in pickerView: UIPickerView) -> Int {
        return 2
    }
    
    func pickerView(_ pickerView: UIPickerView, numberOfRowsInComponent component: Int) -> Int {
        if component == 1{
                    return friits.count
                }
                else{
                    return color.count
                }
    }
    
    
    var friits:[String]=["Banana","Apple","Mango","Lamon"]
    var  color:[String]=["Red","Orange","Pick","Green"]
    
    //titlefor
    func pickerView(_ pickerView: UIPickerView, titleForRow row: Int, forComponent component: Int) -> String? {
        if component == 1{
            return friits[row]
        }
        else{
            return color[row]
        }
    }
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }


    @IBOutlet weak var btn_clickme: UIButton!
    
    @IBOutlet weak var text_unm: UITextField!
    
    @IBOutlet weak var text_number: UITextField!
    
    
    //prep
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {

        if segue.identifier == "s1"
        {
            let obj = segue.destination as! dvc
            obj.msg=text_unm.text! + text_number.text!

        }
    }
    //didi
    @IBOutlet weak var lbl_picker: UILabel!
    func pickerView(_ pickerView: UIPickerView, didSelectRow row: Int, inComponent component: Int) {
        lbl_picker.text=color[row]
    }
}

