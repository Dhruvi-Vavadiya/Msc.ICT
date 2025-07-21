//
//  Users+CoreDataProperties.swift
//  stafflio_app
//
//  Created by Batch1 on 12/06/25.
//
//

import Foundation
import CoreData


extension Users {

    @nonobjc public class func fetchRequest() -> NSFetchRequest<Users> {
        return NSFetchRequest<Users>(entityName: "Users")
    }

    @NSManaged public var email: String?
    @NSManaged public var emp_id: Int32
    @NSManaged public var fname: String?
    @NSManaged public var lname: String?
    @NSManaged public var password: String?
    @NSManaged public var role: String?

}

extension Users : Identifiable {

}
