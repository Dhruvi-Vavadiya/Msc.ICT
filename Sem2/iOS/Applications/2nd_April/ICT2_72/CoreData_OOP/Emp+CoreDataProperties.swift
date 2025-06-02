//
//  Emp+CoreDataProperties.swift
//  CoreData_OOP
//
//  Created by Ictbatch1 on 28/03/25.
//
//

import Foundation
import CoreData


extension Emp {

    @nonobjc public class func fetchRequest() -> NSFetchRequest<Emp> {
        return NSFetchRequest<Emp>(entityName: "Emp")
    }

    @NSManaged public var eage: Int16
    @NSManaged public var eid: Int16
    @NSManaged public var ename: String?
    @NSManaged public var toEsalary: NSSet?

}

// MARK: Generated accessors for toEsalary
extension Emp {

    @objc(addToEsalaryObject:)
    @NSManaged public func addToToEsalary(_ value: Esalary)

    @objc(removeToEsalaryObject:)
    @NSManaged public func removeFromToEsalary(_ value: Esalary)

    @objc(addToEsalary:)
    @NSManaged public func addToToEsalary(_ values: NSSet)

    @objc(removeToEsalary:)
    @NSManaged public func removeFromToEsalary(_ values: NSSet)

}

extension Emp : Identifiable {

}
