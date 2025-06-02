//
//  ViewController.swift
//  Question_5_10
//
//  Created by Ictbatch1 on 18/03/25.
//

import UIKit
import SQLite3

class ViewController: UIViewController {

    var dbPath:String="studentregist.sqlite"
    var db:OpaquePointer?
    
    @IBOutlet weak var txt_unm: UITextField!
    
    @IBOutlet weak var txt_age: UITextField!
    @IBOutlet weak var txt_gender: UISegmentedControl!
    @IBOutlet weak var txt_pwd: UITextField!
    @IBOutlet weak var txt_address: UITextField!
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        
        database_creation()
        //if you create table execute  database_creation() method first
        //create_table()
        
        var dirpath=NSSearchPathForDirectoriesInDomains(.documentDirectory, .userDomainMask, true)
        print(dirpath[0])
    }


    @IBAction func btn_add(_ sender: Any) {
        let inserrow:String = "insert into tblregist(unm,pwd,address,gender,Age) values (?,?,?,?,?)"
        
        
        var unm:String=txt_unm.text ?? "unm"
        var pwd:String=txt_pwd.text ?? "pwd"
        var address:String=txt_address.text ?? "address"
        
        var gender:String="Male"
        if txt_gender.selectedSegmentIndex == 0 {
            gender="Male"
        }else{
            gender="Female"
        }
        var Age:Int=Int(txt_age.text!)!
        
        var insert_stmt:OpaquePointer?=nil
        
        if sqlite3_prepare_v2(db, inserrow, -1, &insert_stmt, nil) == SQLITE_OK
        {
           //2nd parameter start with 1
            sqlite3_bind_text(insert_stmt, 1, (unm as NSString).utf8String, -1, nil)
            sqlite3_bind_text(insert_stmt, 2, (pwd as NSString).utf8String, -1, nil)
            sqlite3_bind_text(insert_stmt, 3, (address as NSString).utf8String, -1, nil)
            sqlite3_bind_text(insert_stmt, 4, (gender as NSString).utf8String, -1, nil)
            sqlite3_bind_int(insert_stmt, 5, Int32(Int(Age)))
            
            if sqlite3_step(insert_stmt) == SQLITE_DONE
            {
                print("Record Done....")
            }else{
                print("insertion failed!!!!!!!")
            }
             
        }
    }
    @IBAction func btn_click(_ sender: Any) {
        print("username :- \(txt_unm.text!)")
        print("password :- \(txt_pwd.text!)")
        print("age :- \(txt_age.text!)")
        if txt_gender.selectedSegmentIndex == 0
        {
            print("Gender :- male")
        }else{
            print("Gender :- female")
        }
        print("address :- \(txt_address.text!)")
    }
    func database_creation(){
        let filePath=try!FileManager.default.url(for: .documentDirectory, in: .userDomainMask, appropriateFor: nil, create: false).appending(path: dbPath)
        
        if sqlite3_open(filePath.path, &db) != SQLITE_OK{
            print("Error database creation!!!")
        }else{
            print("Databse created...")
        }
    }
    func create_table(){
        //create table
        let createTable = "CREATE TABLE if not exists tblregist(unm TEXT,pwd TEXT,address TEXT,gender TEXT,Age INTEGER)"
        var create_stmt:OpaquePointer?=nil
        if sqlite3_prepare_v2(db, createTable, -1, &create_stmt, nil) == SQLITE_OK
        {
            if sqlite3_step(create_stmt) == SQLITE_DONE
            {
                print("tblregist table created....")
            }else{
                print("table not created !!!!")
            }
        }
    }
}

