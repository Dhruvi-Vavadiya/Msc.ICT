// See https://aka.ms/new-console-template for more information
using ConsoleStudentApp;
using static System.Formats.Asn1.AsnWriter;

//Console.WriteLine("Hello, World!");

StudnetCollection studentscollection = new StudnetCollection();
studentscollection[0] = new students() { id = 1, name = "dhruvi", age = 21 };
studentscollection[1] = new students() { id = 2, name = "nency", age = 16 };
studentscollection[2] = new students() { id = 3, name = "ABC", age = 25 };

for (int i = 0; i < 3; i++)
{
    //students[i].getData();
}

String str = Console.ReadLine();
studentscollection[str].getData();

// 1. Data source.
int[] numbers = [0, 1, 2, 3, 4, 5, 6];

// 2. Query creation.
// numQuery is an IEnumerable<int>
var numQuery = from num in numbers where (num % 2) == 0 select num;

//var numQuery =
//    from score in numbers
//    where score >4 
//    orderby score descending
//    select $"The score is {score}";


int evenNumCount = numQuery.Count();
var highScoreCount = (
    from score in numQuery
    where score > 4
    select score
).Count();
//Console.WriteLine(evenNumCount);
//Console.WriteLine(highScoreCount);
// 3. Query execution.
foreach (int num in numQuery)
{
    //Console.Write("{0,1} ", num);
}
Console.WriteLine("\n---------------------------");
//lambda expression
int[] square_find = { 1, 2, 3, 4, 5, 6, 7, 8 };

var square = square_find.Select(x => x * x);
//Console.WriteLine(string.Join(",", square));

var find_even = square_find.FirstOrDefault(x=>(x%2) == 0);
//Console.WriteLine("\n" + find_even);
//Console.WriteLine("\n---------------------------");

int[] nums = new int[] { 0, 4, 2, 6, 3, 81, 31 };
int[] num1 = new int[] { 4,2,10, 15, 3, 81, 74, 85};

//var newVal = nums.Union(num1);
//var newVal = nums.Intersect(num1);
//var newVal = nums.Except(num1);

string[] names = new String[] { "jatin", "mahesh", "puja", "dhruvi", "priyanka" };

var newName = from n in names where n.ToLower().Contains("u") select n;

//var newName = names.Where(n=>n.Contains("i")).Where(m=>m.Contains("d")).ToList();

//var ame=from d in names select d.Length; //LINQ

var ame = names.Select(s=>s.Length).ToArray(); //Lemda

foreach (string i in newName)
{
    //Console.WriteLine(i);
}
Console.WriteLine("\n---------------------------");
// index based generic collection (arraylist)

List<int> listObj = new List<int>();

listObj.Add(123);
listObj.Add(235);

foreach (int i in listObj)
{

//Console.WriteLine(i); 
}
Console.WriteLine("---------------------------");
// Key based generic Collection (Dictionary)

Dictionary<int, string> objDic = new Dictionary<int, string>();

//objDic.Add(123, "Ramakrishna");

//Console.WriteLine("Dictionary Value: {0}", objDic[123]);

Console.WriteLine("----------LIFO-----------------");
// Priority based Generic Collection (Stack)
Stack<int> objStack = new Stack<int>();
objStack.Push(1);
objStack.Push(2);
objStack.Push(3);
// Display first value from Stack
//Console.WriteLine("First Get Value from Stack: {0}", objStack.Pop());
Console.WriteLine("------------FIFO---------------");
// Priority based Generic Collection (Queues)
Queue<int> objQueue = new Queue<int>();
objQueue.Enqueue(1);
objQueue.Enqueue(2);
objQueue.Enqueue(3);
// Display first value from Stack
//Console.WriteLine("First Get Value from Queue: {0}", objQueue.Dequeue());
Console.WriteLine();

// Creating Employee records
Employee empObj1 = new Employee();
empObj1.ID = 1001;
empObj1.Name = "Ramakrishna";
empObj1.Address = "Hyderabad";
Employee empObj2 = new Employee();
empObj2.ID = 1002;
empObj2.Name = "Praveenkumar";
empObj2.Address = "Hyderabad";
// Creating generic List with Employee records
List<Employee> empListObj = new List<Employee>();
//empListObj.Add(empObj1);
//empListObj.Add(empObj2);
// Displaying employee records from list collection
foreach (Employee emp in empListObj)
{
    //Console.WriteLine(emp.ID);
    //Console.WriteLine(emp.Name);
    //Console.WriteLine(emp.Address);
    //Console.WriteLine();
}