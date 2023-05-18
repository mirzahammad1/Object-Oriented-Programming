// See https://aka.ms/new-console-template for more information

//private variables can only be accessed within the same class (an outside class has no access to it).
//However, sometimes we need to access them - and it can be done with properties.
//A property is like a combination of a variable and a method, and it has two methods: a get and a set method

class Person
{
    private string name; // field
    public string Name   // property
    {
        get { return name; }  // The get returns the value of the variable name
        set { name = value; } // The set assigns a value to the name variable.
                              // The value keyword represents the value we assign to the property.


    }
        //------------------------------ Short-Hand / Automatic Properties ------------------------------
        //C# also provides a way to use short-hand / automatic properties, where you do not
        //have to define the field for the property, and you only have to write get; and set; inside the property.
    private string lastname; // field
    public string Lastname { get; set; } // property
}

class Program
{
    static void Main(string[] args)
    {
        Person Obj1 = new Person();
        Obj1.Name = "Mirza";
        Console.WriteLine(Obj1.Name);
        Person Obj2 = new Person();
        Obj2.Lastname = "Hammad Baig";
        Console.WriteLine(Obj2.Lastname);
    }
}