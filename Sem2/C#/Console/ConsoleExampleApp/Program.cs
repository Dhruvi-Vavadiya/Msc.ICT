// See https://aka.ms/new-console-template for more information
using ConsoleExampleApp;

Console.WriteLine("Hello, World!");

StudentCollection students = new();

students[0] = new Student()
{
    id = 1,
    name = "dhruvi",
    age=24
};
students[1] = new Student()
{
    id = 2,
    name = "janvi",
    age = 24
};
students[2] = new Student()
{
    id = 3,
    name = "nency",
    age = 24
};

for(int i = 0; i < 3; i++)
{
    students[i].getData();
}

String str = Console.ReadLine();

for (int i = 0; i < 3; i++)
{
    //students[i].getRecord();
}
