//
//  Employee+CoreDataProperties.swift
//  Login_Registar
//
//  Created by Ictbatch1 on 02/04/25.
//
//

import Foundation
import CoreData


extension Employee {

    @nonobjc public class func fetchRequest() -> NSFetchRequest<Employee> {
        return NSFetchRequest<Employee>(entityName: "Employee")
    }

    @NSManaged public var age: Int16
    @NSManaged public var ename: String?
    @NSManaged public var id: Int16
    @NSManaged public var gender: String?
    @NSManaged public var dob: Date?

}

extension Employee : Identifiable {

}
