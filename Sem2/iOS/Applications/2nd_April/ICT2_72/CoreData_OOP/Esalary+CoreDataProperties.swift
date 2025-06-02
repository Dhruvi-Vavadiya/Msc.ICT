//
//  Esalary+CoreDataProperties.swift
//  CoreData_OOP
//
//  Created by Ictbatch1 on 28/03/25.
//
//

import Foundation
import CoreData


extension Esalary {

    @nonobjc public class func fetchRequest() -> NSFetchRequest<Esalary> {
        return NSFetchRequest<Esalary>(entityName: "Esalary")
    }

    @NSManaged public var eid: Int16
    @NSManaged public var ebasic: Double
    @NSManaged public var ehra: Double
    @NSManaged public var eda: Double
    @NSManaged public var toEmp: NSSet?

}

// MARK: Generated accessors for toEmp
extension Esalary {

    @objc(addToEmpObject:)
    @NSManaged public func addToToEmp(_ value: Emp)

    @objc(removeToEmpObject:)
    @NSManaged public func removeFromToEmp(_ value: Emp)

    @objc(addToEmp:)
    @NSManaged public func addToToEmp(_ values: NSSet)

    @objc(removeToEmp:)
    @NSManaged public func removeFromToEmp(_ values: NSSet)

}

extension Esalary : Identifiable {

}
