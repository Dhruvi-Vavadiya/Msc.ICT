//
//  dvcsegue.swift
//  Login_Registar
//
//  Created by Ictbatch1 on 01/04/25.
//

//two way to perform crud in core data
//1.hanTraditional
//2.oops

//create entity
//select entity attribute inspector change codegen select maual/none
//select editor=> create NSMAnagedObject subclass and add enetity


//tableView
//add refrence datasourse and delegate
import UIKit
import CoreData

class dvcsegue: UIViewController,UITableViewDelegate,UITableViewDataSource {
    
    @IBOutlet weak var txt_age: UITextField!
    @IBOutlet weak var txt_name: UITextField!
    @IBOutlet weak var txt_id: UITextField!
    @IBOutlet weak var tableview: UITableView!

    @IBOutlet weak var date_piker: UIDatePicker!
    
    @IBOutlet weak var seg_gender: UISegmentedControl!
    
    var emps: [Employee] = []
    var selectupdate:Employee?
    
    override func viewDidLoad() {
        super.viewDidLoad()
        tableview.delegate = self
        tableview.dataSource = self
        fetchEmployee()
        
        //NSSearchPath For Directories domain
        let dirPath = NSSearchPathForDirectoriesInDomains(.documentDirectory, .userDomainMask, true)
        print(dirPath[0])
        
        //register(UITableViewCell.self
        tableview.register(UITableViewCell.self, forCellReuseIdentifier: "cell")
        
    }
    func fetchEmployee(){
        let appD = UIApplication.shared.delegate as! AppDelegate
        let mo = appD.persistentContainer.viewContext
        let request: NSFetchRequest<Employee> = Employee.fetchRequest()
        do{
            emps = try mo.fetch(request)
            tableview.reloadData()
        }catch{
            
        }
    }
    
    @IBAction func btn_insert(_ sender: Any) {
        
        let appD = UIApplication.shared.delegate as! AppDelegate
        let mo = appD.persistentContainer.viewContext
        
        let emp = Employee(context: mo)
        emp.id = Int16(txt_id.text!)!
        emp.ename = txt_name.text!
        emp.age = Int16(txt_age.text!)!
        
        if seg_gender.selectedSegmentIndex == 0 {
            emp.gender = "Male"
        }else{
            emp.gender = "FeMale"
        }
        emp.dob = date_piker.date
        
        do{
            try! mo.save()
            emps.append(emp)
            tableview.reloadData()
            self.loadalert(string: "Insert", string: "Employee add sucessfully")
        }catch{
//            print("Error deleting book: \(error)")
            self.loadalert(string: "btn_insert", string: "\(error)")
        }
        
    
    }
    
    func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        return emps.count
    }
    
    func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        
        let cell = tableView.dequeueReusableCell(withIdentifier: "cell", for: indexPath)
        let emp = emps[indexPath.row]
        
        
        cell.textLabel?.text = "(\(emp.id)) - \(emp.ename ?? "")(\(emp.dob)) (\(emp.age)) (\(emp.gender)) "
        return cell
        
    }
    
    //didseleRow At
    //update
    func tableView(_ tableView: UITableView, didSelectRowAt indexPath: IndexPath) {
      
        let e = emps[indexPath.row]
        txt_id.text = "\(e.id)"
        txt_name.text = e.ename
        txt_age.text = "\(e.age)"
        if seg_gender.selectedSegmentIndex == 0 {
            e.gender = "Male"
        }else{
            e.gender = "FeMale"
        }
        date_piker.date
        selectupdate = e

    }
    
    @IBAction func btn_update(_ sender: Any) {
        guard let selectemp = selectupdate else{
           
            self.loadalert(string: "Error", string: "Edit and press update")
            return
        }
        selectemp.id = Int16(txt_id.text!)!
        selectemp.ename = txt_name.text!
        selectemp.age = Int16(txt_age.text!)!
        if seg_gender.selectedSegmentIndex == 0 {
            selectemp.gender = "Male"
        }else{
            selectemp.gender = "FeMale"
        }
        selectemp.dob = date_piker.date
        
                let appD = UIApplication.shared.delegate as! AppDelegate
               let mo = appD.persistentContainer.viewContext
            do{
                try! mo.save()
                self.loadalert(string: "Success employee", string: "record update sucessfully")
                        self.fetchEmployee()
            }catch{
//              print("Error updating employee : \(error)")
                self.loadalert(string: "btn_update", string: "\(error)")
            }
        
        
        
    }
   
    
    //delete
    //commit...
    func tableView(_ tableView: UITableView, commit editingStyle: UITableViewCell.EditingStyle, forRowAt indexPath: IndexPath) {
        
        let appD = UIApplication.shared.delegate as! AppDelegate
        let mo = appD.persistentContainer.viewContext
        
        
        if editingStyle == .delete{
            let employeetodelete = emps[indexPath.row]
            mo.delete(employeetodelete)
            
            do{
                try! mo.save()
                emps.remove(at: indexPath.row)
                tableView.deleteRows(at: [indexPath], with: .fade)
            }catch{
//                print("Error updating employee : \(error)")
                self.loadalert(string: "commit tableview", string: "\(error)")
            }
            
        }
        

    }
    
    
    
    
    @IBAction func btn_delete(_ sender: Any) {
        let appD = UIApplication.shared.delegate as! AppDelegate
        let mo = appD.persistentContainer.viewContext
        
        //delete using text box txtx_id
        let fre = NSFetchRequest<NSFetchRequestResult>(entityName: "Employee")
        
        //filtering
        fre.predicate = NSPredicate(format: "id=%@",txt_id.text!)
        
                do{
                    let result = try! mo.fetch(fre)
                    let obj = result[0] as! NSManagedObject
                    mo.delete(obj)
                    do{
                        try! mo.save()
                        self.loadalert(string: "Error", string: "delete sucessfully")
                        fetchEmployee()
                    }catch{
                        self.loadalert(string: "btn_delete", string: "\(error)")
                    }
                }catch{
                    self.loadalert(string: "btn_delete", string: "\(error)")
                }
    }
    
    func loadalert(string tit:String,string mess:String){
        let alert = UIAlertController(title: tit, message: mess, preferredStyle: .alert)
        alert.addAction(UIAlertAction(title: "ok", style: .default))
        present(alert, animated: true)
    }
    
    
    
    
    
}









////Display
////
////  BooksTableViewController.swift
////  BookCRUD
////
////  Created by Yash Dhaduk on 25/03/25.
////
//
//import UIKit
//import CoreData
//
//class BooksTableViewController: UITableViewController {
//
//    var books:[Book] = []
//
//    override func viewDidLoad() {
//        super.viewDidLoad()
//        loadData()
//
//        // Uncomment the following line to preserve selection between presentations
//        // self.clearsSelectionOnViewWillAppear = false
//
//        // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
//        // self.navigationItem.rightBarButtonItem = self.editButtonItem
//    }
//
//    func loadData(){
//        let appD = UIApplication.shared.delegate as! AppDelegate
//        let mo=appD.persistentContainer.viewContext
//
//        let fr=NSFetchRequest<Book>(entityName: "Book")
//
//        do{
//            books=try mo.fetch(fr)
//            tableView.reloadData()
//        }catch let error as NSError{
//            print(error)
//        }
//    }
//
//    // MARK: - Table view data source
//
//    override func numberOfSections(in tableView: UITableView) -> Int {
//        // #warning Incomplete implementation, return the number of sections
//        return 1
//    }
//
//    override func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
//        // #warning Incomplete implementation, return the number of rows
//        return books.count
//    }
//
//
//    override func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
//        let cell = tableView.dequeueReusableCell(withIdentifier: "cell", for: indexPath)
//
//        let book=books[indexPath.row]
//
//        cell.textLabel?.text = "\(book.name!) \(book.author!) \(book.price) Rs."
//
//        return cell
//    }
//
//    override func setEditing(_ editing: Bool, animated: Bool) {
//        super.setEditing(editing, animated: animated)
//        tableView.setEditing(editing, animated: animated)
//    }
//
//
//    /*
//    // Override to support conditional editing of the table view.
//    override func tableView(_ tableView: UITableView, canEditRowAt indexPath: IndexPath) -> Bool {
//        // Return false if you do not want the specified item to be editable.
//        return true
//    }
//    */
//
//
//    // Override to support editing the table view.
//    override func tableView(_ tableView: UITableView, commit editingStyle: UITableViewCell.EditingStyle, forRowAt indexPath: IndexPath) {
//        if editingStyle == .delete {
//            let appD=UIApplication.shared.delegate as! AppDelegate
//            let mo=appD.persistentContainer.viewContext
//
//            do{
//                mo.delete(books[indexPath.row])
//                try mo.save()
//                books.remove(at: indexPath.row)
//                tableView.deleteRows(at: [indexPath], with: .fade)
//            }catch let error as NSError{
//                print(error)
//            }
//        }
//    }
//
//    override func tableView(
//        _ tableView: UITableView,
//        didSelectRowAt indexPath: IndexPath
//    ) {
//        let appD=UIApplication.shared.delegate as! AppDelegate
//        let mo=appD.persistentContainer.viewContext
//
//        let booktoedit=books[indexPath.row]
//
//        let alert=UIAlertController(
//            title: "Update Book",
//            message: "",
//            preferredStyle: .alert
//        )
//
//        alert.addTextField{ (textfield) in
//            textfield.placeholder="Enter Book Name"
//            textfield.text=booktoedit.name
//            textfield.textAlignment = .center
//        }
//
//        alert.addTextField { (textfield) in
//            textfield.placeholder="Enter Author Name"
//            textfield.text=booktoedit.author
//            textfield.textAlignment = .center
//        }
//
//        alert.addTextField { (textfield) in
//            textfield.placeholder="Enter Price"
//            textfield.text=String(booktoedit.price)
//            textfield.textAlignment = .center
//        }
//
//        alert
//            .addAction(
//                UIAlertAction(
//                    title: "Save",
//                    style: .default,
//                    handler: {action in
//                        booktoedit.name=alert.textFields![0].text
//                        booktoedit.author=alert.textFields![1].text
//                        booktoedit.price=Int32(alert.textFields![2].text!)!
//
//                        do{
//                            try mo.save()
//                            self.books[indexPath.row]=booktoedit
//                            tableView.reloadData()
//                        }catch let error as NSError{
//                            print(error)
//                        }
//                    })
//            )
//
//        alert.addAction(UIAlertAction(title: "Cancel", style: .default))
//
//        present(alert, animated: true)
//    }
//
//
//    /*
//    // Override to support rearranging the table view.
//    override func tableView(_ tableView: UITableView, moveRowAt fromIndexPath: IndexPath, to: IndexPath) {
//
//    }
//    */
//
//    /*
//    // Override to support conditional rearranging of the table view.
//    override func tableView(_ tableView: UITableView, canMoveRowAt indexPath: IndexPath) -> Bool {
//        // Return false if you do not want the item to be re-orderable.
//        return true
//    }
//    */
//
//    /*
//    // MARK: - Navigation
//
//    // In a storyboard-based application, you will often want to do a little preparation before navigation
//    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
//        // Get the new view controller using segue.destination.
//        // Pass the selected object to the new view controller.
//    }
//    */
//
//
//
//}
//
//
//
//==============================================================
//    //Add
////  BookViewController.swift
////  BookCRUD
////
////  Created by Yash Dhaduk on 22/03/25.
////
//
//import UIKit
//
//class BookViewController: UIViewController {
//
//    @IBOutlet weak var bnamefield: UITextField!
//    @IBOutlet weak var anamefield: UITextField!
//    @IBOutlet weak var pricefield: UITextField!
//    override func viewDidLoad() {
//        super.viewDidLoad()
//
//        // Do any additional setup after loading the view.
//        self.navigationItem.hidesBackButton=true
//    }
//
//    @IBAction func addBtn(_ sender: Any) {
//        let appD=UIApplication.shared.delegate as! AppDelegate
//        let mo=appD.persistentContainer.viewContext
//
//        let bookobj=Book(context: mo)
//        bookobj.name=bnamefield.text
//        bookobj.author=anamefield.text
//        bookobj.price=Int32(pricefield.text!)!
//
//        do{
//            try mo.save()
//
//            let alert=UIAlertController(title: "Success", message: "Book added successfully", preferredStyle: .alert)
//            alert.addAction(UIAlertAction(title: "OK", style: .default))
//
//
//            bnamefield.text=""
//            anamefield.text=""
//            pricefield.text=""
//
//            present(alert, animated: true)
//
//        }catch let error as NSError{
//            print(error)
//        }
//    }
//
//    @IBAction func logoutBtn(_ sender: Any) {
//        UserDefaults.standard.set(false, forKey: "isloggedin")
//
//        let lvc=storyboard?.instantiateViewController(
//            withIdentifier: "lvc"
//        ) as! ViewController
//        navigationController?.pushViewController(lvc, animated: true)
//
//    }
//    /*
//    // MARK: - Navigation
//
//    // In a storyboard-based application, you will often want to do a little preparation before navigation
//    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
//        // Get the new view controller using segue.destination.
//        // Pass the selected object to the new view controller.
//    }
//    */
//
//}
//
//============================================================
////Login
////
////  ViewController.swift
////  BookCRUD
////
////  Created by Yash Dhaduk on 22/03/25.
////
//
//import UIKit
//
//class ViewController: UIViewController {
//
//    @IBOutlet weak var emailfield: UITextField!
//    @IBOutlet weak var passwordfield: UITextField!

//    override func viewDidLoad() {
//        super.viewDidLoad()
//        // Do any additional setup after loading the view.
//
//        self.navigationItem.hidesBackButton=true
//        if(UserDefaults.standard.bool(forKey: "isloggedin")){
//            navigateToBVC()
//        }
//    }
//
//    @IBAction func loginBtn(_ sender: Any) {
//        if(emailfield.text != "" && passwordfield.text != ""){
//            if emailfield.text=="admin@gmail.com" && passwordfield.text=="admin@007"{
//                UserDefaults.standard.set(true, forKey: "isloggedin")
//                navigateToBVC()
//            }else{
//                let alert=UIAlertController(title: "", message: "Invalid Username or Password", preferredStyle: .alert)

//                alert.addAction(UIAlertAction(title: "Dismiss", style: .cancel))
//                present(alert, animated: true)
//            }
//        }else{
//            var err:String="";
//            if(emailfield.text=="" && passwordfield.text==""){
//                err="Enter Email and Password"
//            }else if(emailfield.text==""){
//                err="Enter Email"
//            }else{
//                err="Enter Password"
//            }
//
//            let alert=UIAlertController(
//                title: "",
//                message: err,
//                preferredStyle: .alert
//            )
//
//            alert.addAction(UIAlertAction(title: "Dismiss", style: .cancel))
//
//            present(alert, animated: true)
//        }
//    }
//
//
//    func navigateToBVC(){
//        let bvc=self.storyboard?.instantiateViewController(withIdentifier: "bvc") as? BookViewController
//        self.navigationController?.pushViewController(bvc!, animated: true)
//    }
//
//}
//
