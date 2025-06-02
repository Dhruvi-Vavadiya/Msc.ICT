import UIKit

var greeting = "dhruvi"
print("welcome \(greeting) to the world\n")

var i: [Int] = [1,2]
for week in i{
    if week == 1 {
        let day : [String] = ["Mon","Tue","Wed","Thur","Sat","Sun"]
        var ind = 0
        
        print("1st week")
        
        while ind < day.count{
            print(day[ind])
            ind+=1
        }
        print("  ")
    }
    else if week == 2 {
        let day : [String] = ["Mon","Tue","Wed","Thur","Sat","Sun"]
        var ind = 0
        
        print("2nd week")
        
        while ind < day.count{
            print(day[ind])
            ind+=1
        }
    }
    else{
        print("no days for such week")
    }
}


var n:Int = 1

while n<6{
    print(n)
    n=n+1
}

var r:Int = 1
repeat{
    print(r)
    r=r+1
}while r <= 5
