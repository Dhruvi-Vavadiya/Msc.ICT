import UIKit

var greeting = "Hello, playground"
var str="stirng"
var msg=10
print(greeting+str)


var string:Int?

//explicit
var firstname:String?
firstname="Dhuvi"
print(firstname!)

//implicit optional
var lnm:String!
lnm="DHRUVI"
print(lnm!)
print(lnm.lowercased())

//explicit optional
var name:String?
name="iOS Devlopment"
print(name!)
print(name!.lowercased())

//Implicit optional
var imp:String!
imp="ApPlE"
print(imp!)
print(imp.lowercased())

//if condition
var i=5
if i<10
{
    print("i is less than 10")
}else{
    print("i is greter than 10")
}

//for loop
var num=[1,2,5,4,7]
for x in num{
    print(x)
}

//while loop
var a=0;
while a<=5{
    a=a+1
    print(a)
}

//do..while
var b=0
repeat{
    b=b+1
    print(b)
}while b<=5

//collection
var t1=(1,"dhrui","vavdiya")
print(t1.2)

var f2:(Int,String,String)=(1,"suart","suart")
//print(f2.1)

//collection unnamed
var t3=(id:1,city:"surat",state:"gujrat")
//print(t3.city)


//Array
var t=["df","gh","yu"]
//print(t)

var list:Array<Int>=[5,24,75,78]
//print(list)
//print(list.isEmpty)

//array in my leptop

//Dictionary 2 type
var dict=Dictionary<Int,String>()
//dict=[1:"dhruv",2:"manish"]
//print(dict)

var di=Dictionary<String,String>()
di=["id":"101","name":"dhruviii"]
print(di)

//print(di.isEmpty)
//print(di.count)
//print(di.values)
//print(di.keys)


//di.updateValue("Ravi", forKey: "name")
//di=["age":"20"]
di["age"]="21"
//di.removeValue(forKey: "name")
print(di)


//loop
for x in di{
    print(x.value)
    print(x.key)
}

//set
//var s1:Set=[2,4,8,10]
var s1:Set<Int>=[5,7,8,4]
print(s1)
var s2:Set<Int>=[1,2,3,4,5]
var friuits:Set<String>=["apple","banana","mnago"]
print(friuits.isEmpty)
print(friuits.count)
print(s1.union(s2))
print(s1.intersection(s2))
print(s1.subtracting(s2))
print(s1.symmetricDifference(s2))
for x in s2.sorted(){
    print(x)
}

//UDF


//func <#name#>(<#parameters#>) -> <#return type#> {
//    <#function body#>
//}

//simple UDF
func show(){
    print("Welcome to iOS")
}
show()

//UDF With para
func showPara(msg:String){
   print("UDF With Parameters\(msg)....")
}
showPara(msg: "  Ios Parameter")

//UDF WIth return type argument
func disp(a:Int)-> Int{
    return a*2
}
print(disp(a:5))

func disp(a:Int,b:Int)-> Int{
    return a+b
}
print(disp(a:5,b:3))

//Oops in swift
class abc{
    var unm:String?
    init(){ //init like defalut constractor
        print("Default cons...")
    }
    init(n:String){
        self.unm=n
    }
    func show(){
        print("show method of abc class.. \(unm!)..")
    }
}
var obj=abc(n:"Manish")
obj.show()

//inheritance
//class a1{
//    func show(){
//        print("Class A method show..")
//    }
//}
//class a2:a1{
//    func disp(){
//        print("Class B method disp..")
//    }
//}
//
//var obja2=a2()
//obja2.disp()
//obja2.show()

//polymorphism

class a1{
    func show(){
        print("Class A method show..")
    }
}
class a2:a1{
    override func show(){
        print("Class B method disp..")
    }
}

var obja2=a2()

obja2.show()

//protocol  multiple inheritance

protocol pro1{
    func p1()
}

protocol pro2{
    func p2()
}

class myclass:pro1,pro2{ //when you inherit then define all the method
    func p1(){
        print("pro1 mthod...")
    }
    func p2(){
        print("pro2 mthod...")
    }
}
var proto=myclass();
proto.p1()
proto.p2()

//extension

extension myclass{
    func addional(){
        print("additional function in myclass")
    }
}

proto.addional()
