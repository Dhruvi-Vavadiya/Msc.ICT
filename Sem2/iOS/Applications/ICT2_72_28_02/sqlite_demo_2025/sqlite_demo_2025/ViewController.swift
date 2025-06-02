//
//  ViewController.swift
//  sqlite_demo_2025
//
//  Created by mscit on 1/29/25.
//

import UIKit
import SQLite3

class ViewController: UIViewController {

    var dbPath:String="mydb.sqlite"
    var db:OpaquePointer?
    
    @IBOutlet weak var txtrollno: UITextField!
    
    
    @IBOutlet weak var txtsname: UITextField!
    
    @IBOutlet weak var txtaddress: UITextField!
        
    @IBOutlet weak var txt_id_del: UITextField!
    
    
    @IBOutlet weak var txt_up_rollno: UITextField!
    
    @IBOutlet weak var txt_up_sname: UITextField!
    
    @IBOutlet weak var txt_up_address: UITextField!
    
    
    @IBAction func btnsave(_ sender: Any) {
//        let inserrow:String = "insert into tblstud(rn,sn,address) values(\(txtrollno.text!),'\(txtsname.text!)','\(txtaddress.text!)')"
        let inserrow:String = "insert into tblstud(rn,sn,address) values(?,?,?)"
        
        var id:Int=Int(Int32(txtrollno.text!) ?? 0)
        var sn:String=txtsname.text ?? "Hello"
        var addre:String=txtaddress.text ?? "Mahadev"
        
        var insert_stmt:OpaquePointer?=nil
        
        if sqlite3_prepare_v2(db, inserrow, -1, &insert_stmt, nil) == SQLITE_OK
        {
            sqlite3_bind_int(insert_stmt, 1, Int32(id))
            sqlite3_bind_text(insert_stmt, 2, (sn as NSString).utf8String, -1, nil)
            sqlite3_bind_text(insert_stmt, 3, (addre as NSString).utf8String, -1, nil)
            
            if sqlite3_step(insert_stmt) == SQLITE_DONE
            {
                print("Record Done....")
            }else{
                print("insertion failed!!!!!!!")
            }
        }
    }
    
    @IBAction func btn_delete(_ sender: Any) {
        let delerow:String = "delete from tblstud where rn=?"
        
        var id:Int=Int(Int32(txt_id_del.text!) ?? 0)
        
        
        var delete_stmt:OpaquePointer?=nil
        if sqlite3_prepare_v2(db, delerow, -1, &delete_stmt, nil) == SQLITE_OK
        {
            sqlite3_bind_int(delete_stmt, 1, Int32(id))
            
            
            if sqlite3_step(delete_stmt) == SQLITE_DONE
            {
                print("Record deleted Done....")
            }else{
                print("deleted failed!!!!!!!")
            }
        }
    }
    
    
    @IBAction func btn_update(_ sender: Any) {
        let updaterow:String = "update tblstud set sn=? where rn=?"
        
        
        var sn:String=txt_up_sname.text ?? "Hello"
//        var addre:String=txt_up_address.text ?? "Mahadev"
        var id:Int=Int(Int32(txt_up_rollno.text!) ?? 0)
        
        var update_stmt:OpaquePointer?=nil
        
        if sqlite3_prepare_v2(db, updaterow, -1, &update_stmt, nil) == SQLITE_OK
        {
            
            sqlite3_bind_text(update_stmt, 1, (sn as NSString).utf8String, -1, nil)
//            sqlite3_bind_text(update_stmt, 2, (addre as NSString).utf8String, -1, nil)
            sqlite3_bind_int(update_stmt, 2, Int32(id))
            
            if sqlite3_step(update_stmt) == SQLITE_DONE
            {
                print("Record deleted Done....")
            }else{
                print("deletetion failed!!!!!!!")
            }
        }
    }
    
    override func viewDidLoad() {
        
        super.viewDidLoad()
        
        
        //FileManager.default.url
        let filePath=try!FileManager.default.url(for: .documentDirectory, in: .userDomainMask, appropriateFor: nil, create: false).appending(path: dbPath)
        
        if sqlite3_open(filePath.path, &db) != SQLITE_OK{
            print("Error database creation!!!")
        }else{
            print("Databse created...")
        }
        
        //create table
        let createTable = "CREATE TABLE if not exists tblstud(rn INTEGER PRIMARY KEY,sn TEXT,address TEXT)"
        var create_stmt:OpaquePointer?=nil
//        if sqlite3_prepare_v2(db, createTable, -1, &create_stmt, nil) == SQLITE_OK
//        {
//            if sqlite3_step(create_stmt) == SQLITE_DONE
//            {
//                print("tblstud table created....")
//            }else{
//                print("table not created !!!!")
//            }
//        }
        //NSSerachPat
        var dirpath=NSSearchPathForDirectoriesInDomains(.documentDirectory, .userDomainMask, true)
        print(dirpath[0])
        
        //Databse created...
       // tblstud table created....
       // /Users/mscit/Library/Developer/CoreSimulator/Devices/424777D9-F717-4BB4-BD77-3AFBB52044AD/data/Containers/Data/Application/696556E7-3795-4572-B088-1DD2C47B623A/Documents
        
        //insert
        let inserrow:String = "insert into tblstud(rn,sn,address) values(2,'puja','Rajkot')"
        var insert_stmt:OpaquePointer?=nil
//        if sqlite3_prepare_v2(db, inserrow, -1, &insert_stmt, nil) == SQLITE_OK
//        {
//            if sqlite3_step(insert_stmt) == SQLITE_DONE
//            {
//                print("Record Done....")
//            }else{
//                print("insertion failed!!!!!!!")
//            }
//        }
        //delete
        let delete_Query:String = "delete from tblstud where rn=2"
        var del_stmt:OpaquePointer?=nil
//        if sqlite3_prepare_v2(db, delete_Query, -1, &del_stmt, nil) == SQLITE_OK
//        {
//            if sqlite3_step(del_stmt) == SQLITE_DONE
//            {
//                print("Deleteed record..")
//            }else{
//                print("deletetion failed!!!!!!!")
//            }
//        }
        
        //update
        let update_Query:String = "update tblstud set address='05,vinhose,katargam,surat' where rn=1"
        var up_stmt:OpaquePointer?=nil
//        if sqlite3_prepare_v2(db, update_Query, -1, &up_stmt, nil) == SQLITE_OK
//        {
//            if sqlite3_step(up_stmt) == SQLITE_DONE
//            {
//                print("update record..")
//            }else{
//                print("updation failed!!!!!!!")
//            }
//        }
        
        
        
        
    }

   
}

