// See https://aka.ms/new-console-template for more information

//-----------------------Polymorphsim
//it mean many forms, int other words name with multiple functionality
//   1---Run_time Polymorphsim (Over riding)
//   2---Compile_time polymorphsim (over loading)
// base keyword is used to access members of base class from derived class

Console.WriteLine("Run-Time");
A obj1 = new A();
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
obj1.SUB(a, b);
Console.WriteLine();
Console.WriteLine("Compile-Time");
B obj2 = new B();
obj2.ADD();
//------------------------------------------------------
class A
{
    int a=40, b=50;
    public void ADD() 
    {
        int sum = a + b;
        Console.WriteLine(sum);
    }
    public void SUB(int a, int b) 
    {
        Console.WriteLine(a - b);
    }
}
class B : A
{
    int a = 400, b = 500;
    public void ADD()
    {
    base.ADD();
        int sum = a + b;
        Console.WriteLine(sum);
    }
    public void SUB(int a, int b)
    {
        Console.WriteLine(a - b);
    }
}
//------------------------------------------------------