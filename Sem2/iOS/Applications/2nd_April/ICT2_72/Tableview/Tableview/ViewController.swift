//
//  ViewController.swift
//  Tableview
//
//  Created by mscit on 2/14/25.
//1.
//datasource
//delegate
//outlet
//import UITableViewDataSource,UITableViewDelegate
//numberOfRowsInSection,cellForRowAt

import UIKit

class ViewController: UIViewController,UITableViewDataSource,UITableViewDelegate {
    
    @IBOutlet weak var tv: UITableView!
    @IBOutlet weak var lbl_fruits: UILabel!
    @IBOutlet weak var txt_add: UITextField!
    
    var fruits:[String]=["Apple","Pineapple","Watermalan","Banana","Mango"]
    var si : Int?
    
    func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return fruits.count
    }
    
    //this function repeat a cout of item
    func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        
        let cell:UITableViewCell=tableView.dequeueReusableCell(withIdentifier: "cell", for: indexPath)
        cell.textLabel?.text=fruits[indexPath.row]
        return cell
    }
    
    
    func tableView(_ tableView: UITableView, didSelectRowAt indexPath: IndexPath) {
        lbl_fruits.text=fruits[indexPath.row]
        si=indexPath.row
        if lbl_fruits.text == "Mango"{
            
            let sb1:UIStoryboard=UIStoryboard(name: "Main", bundle: nil)
            let dvc=sb1.instantiateViewController(withIdentifier: "dvc_Mango") as! dvc_Mango
            self.present(dvc, animated: true)
        }
        if lbl_fruits.text == "Apple"{
            
            let sb1:UIStoryboard=UIStoryboard(name: "Main", bundle: nil)
            let dvc=sb1.instantiateViewController(withIdentifier: "dvcApple") as! dvc_Apple
            self.present(dvc, animated: true)
        }
        if lbl_fruits.text == "Pineapple"{
            
            let sb1:UIStoryboard=UIStoryboard(name: "Main", bundle: nil)
            let dvc=sb1.instantiateViewController(withIdentifier: "dvcPineapple") as! dvc_Pineapple
            self.present(dvc, animated: true)
        }
    }
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        tv.register(UITableViewCell.self, forCellReuseIdentifier: "cell")
    }
    @IBAction func btn_add(_ sender: Any) {
        fruits.append(txt_add.text!)
        tv.beginUpdates()
        tv.insertRows(at: [IndexPath(row: fruits.count-1, section: 0)], with: .automatic)
        tv.endUpdates()
    }

    @IBAction func btn_del(_ sender: Any) {
        fruits.remove(at: si!)
        tv.beginUpdates()
        tv.deleteRows(at: [IndexPath(row: si!, section: 0)], with: .automatic)
        lbl_fruits.text=""
        tv.endUpdates()
    }
    
    
}

