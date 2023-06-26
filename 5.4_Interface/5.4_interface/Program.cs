// See https://aka.ms/new-console-template for more information

//-------------------------INTERFACE
//An interface is a contract between it self and any class that impelment it.
//This contaract states that "any class that implement the interface will implement the interface's properties"
//The interface defines "WHAT" part of syntactical contarct and classes define "HOW" part.
//We can achive multiple inheritance by using interface.

a obj = new a();
obj.Show();
Console.WriteLine(obj.add(7, 9));

Test obj2 = new Test();
obj2.show_1();
obj2.show_2();

person teach = new teacher();
teach.show_3();
interface in_a
{
    void Show();
    int add(int x,int y);
}

class a : in_a
{
    public void Show()
    {
        Console.WriteLine("interface method");
    }
    public int add(int x, int y)
    {
        int sum = x + y;
        return sum;
    }
}

//multi-inheritance is a feature in which a class can inherate charaters and features from more than 1 parents
interface test
{
    void show_1();
}
interface test_1
{
    void show_2();
}
class Test :test,test_1
{
    public void show_1()
    {
        Console.WriteLine("1234");
    }
    public void show_2()
    {
        Console.WriteLine("5678");
    }
}

class person 
{
    public void show_3()
    {
        Console.WriteLine("Person show method");
    }
}
interface employee 
{
    void show_3() { }
}
class teacher : person , employee , test_1
{
    public void show_3()
    {
        Console.WriteLine("Teacher show 3");
    }
    public void show_2()
    {
        Console.WriteLine("interface 2");
    }
}