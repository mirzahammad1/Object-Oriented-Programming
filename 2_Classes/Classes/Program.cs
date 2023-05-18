// See https://aka.ms/new-console-template for more information

//Classes and objects are the two main aspects of object-oriented programming.

//Everything in C# is associated with classes and objects, along with its attributes and methods.

//For example: in real life, a Human is an object.

//The car has attributes, such as ears and eyes, and methods, such as Eat and Walk.

//A Class is like an object constructor, or a "blueprint" for creating objects.
using System.Security.Claims;
using System.Threading.Channels;

class Human
    //An object is created from a class. We have created the class named Human, so now we can use this to create objects.
{
    string name = "Mirza Hammad Baig";
    static void Main(string[] args)
    {
    //To create an object of Human, specify the class name, followed by the object name, and use the keyword new.
        Human Obj1 = new Human();
        Console.WriteLine("My name is " + Obj1.name);
        Console.WriteLine();

        // We can also create multiple object of one class

        Human Obj2 = new Human();
        Console.WriteLine(Obj1.name);
        Console.WriteLine(Obj2.name);

    }
}
//----------------------------------------------Class Members----------------------------------------------
//Fields and methods inside classes are often referred to as "Class Members"
class Car
{
    string Name = "Honda"; // field
    string Color = "Red"; // field

    static void Info() // methode
    {
        Console.WriteLine("The name of car is : ");
    }

    static void Main(String[] args)
    {
        Car Obj1 = new Car();
        Info();
        Console.WriteLine(Obj1.Name);
        Console.WriteLine("And its Color is : " + Obj1.Color);
    }
}