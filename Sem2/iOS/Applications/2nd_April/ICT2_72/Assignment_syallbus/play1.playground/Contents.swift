import UIKit

var msg="iOS"

let str=5.5

//print(msg+str)
//print("Welcome \(msg) to \(str)")




// Explicit Optional
var fname:String?
fname="Bharat"
print(fname!)


// Implicit Optional

var lname:String!
lname="Patel"
print(lname.lowercased())
/*
var name: String!="Bharat Patel"
//name =
if name != nil
{ print("\(name)")
}
else {
print("No Name ")
}

*/
/*
var lName: String? = "World"
if lName != nil {
    print(lName!.lowercased())
}
var name: String!
name="MANISH"
if name != nil {
    print(name.lowercased())
}
*/

//Explicit optional
var msg1:String?
msg1="iOS Development"
print(msg1!)


//Implicit Optional
//var msg2="iOS Program"
var msg2:String!
msg2="Apple"
print(msg2.lowercased())

//if-else
var i=15
if i<10
{
    print("i is less than 10")
}
else
{
    print("i is greater than 10")
}
// for loop
var nums=[1,2,3,5,9,10]
for x in nums
{
    print(x)
}
// while loop
var a=0
while a<=5
{
    a=a+1
    print(a)
}


//repeat while loop
var b=0
repeat
{
    b=b+1
    print(b)
} while b<=5

//Collections
//un-named tupple
//var t1=(1,"Bharat","Surat")
var t1:(Int,String,String)=(1,"Bharat","Surat")
print(t1.2)



//named tupple

var t2:(Int,String,String)=(rn:1,name:"Bharat",city:"Surat")
print(t2.0)

            //Collections in swift
            //Array
//var list=[5,10,15,20,25]
var list:Array<Int>=[5,10,15,20,25]
  print(list)
print(list.isEmpty)
            print(list.count)
print(list[2])
list[1]=20
            list.removeLast()
            list.remove(at: 1)
            list.append(30)
            list.insert(22, at: 1)
            print(list)
            for x in list
{
    print(x)
}

//Dictionary
var dict=Dictionary<String,String>()
dict=["1":"Bharat", "2":"Manish"]
print(dict.isEmpty)
print(dict.count)
print(dict.values)
print(dict.keys)
//dict.updateValue("Ravi", forKey: "1")
dict["3"]="Aakash"
//dict.removeValue(forKey: "2")
for x in dict
{
    print(x.value)
    print(x.key)
}
print(dict)



//Set
//var s1:Set=[2,4,6,8,10]
var s1:Set<Int>=[2,4,6,8,10]
var s2:Set<Int>=[1,2,3,4,5]
var fruits:Set<String>=["Apple","Banana","Mango"]
print(fruits.isEmpty)
print(fruits.count)
print(s1.union(s2))
print(s1.intersection(s2))
print(s1.subtracting(s2))
print(s2.subtracting(s1))
print(s1.symmetricDifference(s2))
for x in s2.sorted()
{
    print(x)
}

//UDF

func show()
{
    print("Welcome to iOS....")
}
show()

//with Parameter
func show2(msg:String)
{
    print("Welcome to \(msg)....")
}
show2(msg:"iOS Program")

//with return type
func disp(a:Int, b:Int) -> Int
{
    return a+b
}
print(disp(a:2,b:3))

//OOPs in Swift
class abc
{
    var uname:String?
    init(n:String)
    {
        self.uname=n
    }
    func show()
    {
        print("Welcome \(uname!)...")
    }
}
var obj=abc(n:"Manish")
obj.show()

//inheritance
/*
class a1
{
    func show(){
        print("a class method...")
    }
}
class a2: a1{
    func disp(){
        print("b class method...")
    }
}
var ob=a2()
ob.show()
ob.disp()
*/
class a1
{
    func show(){
        print("a class method...")
    }
}
class a2: a1{
    override func show(){
        print("b class method...")
    }
}
var ob=a2()
ob.show()

