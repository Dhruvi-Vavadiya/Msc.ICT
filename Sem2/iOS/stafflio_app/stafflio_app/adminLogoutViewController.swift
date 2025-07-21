//
//  adminLogoutViewController.swift
//  stafflio_app
//
//  Created by Batch1 on 11/06/25.
//

import UIKit

class adminLogoutViewController: UIViewController {

    override func viewDidAppear(_ animated: Bool) {
           super.viewDidAppear(animated)
           
           // Clear session or user info
           UserDefaults.standard.removeObject(forKey: "loggedInUserEmpId")
           
           redirectToLogin()
       }

       func redirectToLogin() {
           guard let windowScene = UIApplication.shared.connectedScenes.first as? UIWindowScene,
                 let delegate = windowScene.delegate as? SceneDelegate,
                 let window = delegate.window else {
               return
           }

           let storyboard = UIStoryboard(name: "Main", bundle: nil)
           let loginVC = storyboard.instantiateViewController(withIdentifier: "LoginViewController")

           window.rootViewController = loginVC
           window.makeKeyAndVisible()
       }
    override func viewDidLoad() {
        super.viewDidLoad()
        view.isHidden = true
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
