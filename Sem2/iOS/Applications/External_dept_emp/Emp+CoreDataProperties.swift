//
//  Emp+CoreDataProperties.swift
//  External_dept_emp
//
//  Created by exam on 24/04/25.
//
//

import Foundation
import CoreData


extension Emp {

    @nonobjc public class func fetchRequest() -> NSFetchRequest<Emp> {
        return NSFetchRequest<Emp>(entityName: "Emp")
    }

    @NSManaged public var eid: Int16
    @NSManaged public var ename: String?
    @NSManaged public var esalary: Int16
    @NSManaged public var did: Int16
    @NSManaged public var todept: NSSet?

}

// MARK: Generated accessors for todept
extension Emp {

    @objc(addTodeptObject:)
    @NSManaged public func addToTodept(_ value: Dept)

    @objc(removeTodeptObject:)
    @NSManaged public func removeFromTodept(_ value: Dept)

    @objc(addTodept:)
    @NSManaged public func addToTodept(_ values: NSSet)

    @objc(removeTodept:)
    @NSManaged public func removeFromTodept(_ values: NSSet)

}

extension Emp : Identifiable {

}
