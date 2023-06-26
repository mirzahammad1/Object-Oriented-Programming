// See https://aka.ms/new-console-template for more information

//---------------------------------------- Abstract

C obj = new C();
obj.walk();
B obj_1 = new B();
Console.WriteLine(obj_1.test());
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Sealed Class");
calculator obj1 = new calculator();
Add obj2 = new Add();
int res = obj2.Sum(2, 8);
Console.WriteLine(res);
abstract public class A
{
    public abstract void walk();
    public abstract int test();   
}
public class B : A
{
    public override int test()
    {
        return 2;
    }
    public override void walk()
    {
        Console.WriteLine("B walks");
    }
}
public class C : A
{
    public override int test()
    {
        return 8;
    }
    public override void walk()
    {
        Console.WriteLine("C walks");
    }
}


//---------------------------------------- Abstract
//sealed key-word is uesd to prevent inheritence. but can b instentiated
//we can not inherit a sealed class
//also the member in the sealed class cannet be changed from other classes.
// a constructor cannot b sealed

public sealed class Add
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}
public class calculator : Add
{
    // can not inherit because of sealed class
}