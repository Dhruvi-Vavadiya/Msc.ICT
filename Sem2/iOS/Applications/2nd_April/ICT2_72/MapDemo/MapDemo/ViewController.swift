//
//  ViewController.swift
//  MapDemo
//
//  Created by Ictbatch1 on 12/03/25.
//

import UIKit
import MapKit

class ViewController: UIViewController {

 
    @IBOutlet weak var mymap: MKMapView!
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        let location:CLLocationCoordinate2D=CLLocationCoordinate2D(latitude: 21.170240, longitude: 72.831062)
        let span:MKCoordinateSpan=MKCoordinateSpan(latitudeDelta: 0.0125, longitudeDelta: 0.0125)
        let region:MKCoordinateRegion=MKCoordinateRegion(center: location, span: span)
        mymap.setRegion(region, animated: true)
        self.mymap.showsUserLocation=true
        let ant:MKPointAnnotation=MKPointAnnotation()
        ant.coordinate = CLLocationCoordinate2D(latitude: 21.170240, longitude: 72.831062)
        ant.title="where am I ?.."
        ant.subtitle="I am at VNSGU...."
        mymap.addAnnotation(ant)
    }


}

