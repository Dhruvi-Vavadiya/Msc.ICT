//
//  Leave_Details+CoreDataProperties.swift
//  stafflio_app
//
//  Created by Batch1 on 12/06/25.
//
//

import Foundation
import CoreData


extension Leave_Details {

    @nonobjc public class func fetchRequest() -> NSFetchRequest<Leave_Details> {
        return NSFetchRequest<Leave_Details>(entityName: "Leave_Details")
    }

    @NSManaged public var emp_id: Int32
    @NSManaged public var from_date: Date?
    @NSManaged public var is_approved: String?
    @NSManaged public var leave_id: Int32
    @NSManaged public var leave_reason: String?
    @NSManaged public var leave_type: String?
    @NSManaged public var to_date: Date?
    @NSManaged public var email: String?

}

extension Leave_Details : Identifiable {

}
