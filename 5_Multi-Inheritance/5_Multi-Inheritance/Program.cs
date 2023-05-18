// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        A obj = new B(); // will call from A to B
        Console.WriteLine();

        C obj1 = new D(); // will call from A to D , because C is drived form B and B is drived from A (base class)
        Console.WriteLine();

        A obj2 = new C(); // will call from A to C
        Console.WriteLine();

        Console.ReadLine();
    }
}
public class A // base class or Parent class
{
    public int A_a;
    public A()
    {
        Console.WriteLine("Class A, constructor called");
    }
}
public class B : A // drived form Base class / 1st child class
{
    public int B_a;
    public B()
    {
        Console.WriteLine("Class B, constructor called");
    }
}
public class C : B // drived from 1st child class / 2nd child class
{
    public int C_a;
    public C()
    {
        Console.WriteLine("Class C, constructor called");
    }

}
public class D : C // drived from 2nd child class / 3rd child class
{
    public int D_a;
    public D()
    {
        Console.WriteLine("Class D, constructor called");
    }
}