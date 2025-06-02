//
//  ViewController.swift
//  core_location_demo
//
//  Created by Ictbatch1 on 21/03/25.
//

import UIKit
import CoreLocation

class ViewController: UIViewController,CLLocationManagerDelegate {

    var clm:CLLocationManager? = nil
    var geo:CLGeocoder?
    var places:CLPlacemark?
    
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        self.clm = CLLocationManager()
        clm?.delegate=self
        clm?.desiredAccuracy=kCLLocationAccuracyBest
        clm?.requestWhenInUseAuthorization()
        clm?.startUpdatingLocation()
    }
    
    //didupdaetlo
    func locationManager(_ manager: CLLocationManager, didUpdateLocations locations: [CLLocation]) {
        let myloc=locations.first
        print(myloc!.coordinate.latitude)
        print(myloc!.coordinate.longitude)
        geo?.geocodeAddressString("VNSGU, Surat, Gujarat, India", completionHandler:
        {_,_ in
            do{
                print(locations.last?.coordinate.latitude)
                print(locations.last?.coordinate.longitude)
            }
        })
        geo?.reverseGeocodeLocation(CLLocation(latitude: 21.170240, longitude: 72.831062), completionHandler: <#T##CLGeocodeCompletionHandler##CLGeocodeCompletionHandler##([CLPlacemark]?, (any Error)?) -> Void#>)
    }


}

