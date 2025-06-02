//
//  Dept+CoreDataProperties.swift
//  External_dept_emp
//
//  Created by exam on 24/04/25.
//
//

import Foundation
import CoreData


extension Dept {

    @nonobjc public class func fetchRequest() -> NSFetchRequest<Dept> {
        return NSFetchRequest<Dept>(entityName: "Dept")
    }

    @NSManaged public var did: Int16
    @NSManaged public var dname: String?
    @NSManaged public var toemp: Emp?

}

extension Dept : Identifiable {

}
