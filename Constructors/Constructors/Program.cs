// See https://aka.ms/new-console-template for more information

//A constructor is a special method that is used to initialize objects. The advantage of a constructor,
//is that it is called when an object of a class is created. It can be used to set initial values for fields.
using System.IO;

class Constructor
{
    public string firstName;
    public string lastName;
    public string course;
    public int id;
    //----------------------------------------------- Default Constructor -----------------------------------------------
    //A constructor with no parameters is called a default constructor. A default constructor has every instance
    //of the class to be initialized to the same values. The default constructor initializes all numeric fields
    //to zero and all string and object fields to null inside a class.
    public Constructor()
    {
        firstName = "Mirza Hammad";
        lastName = "Baig";
        course = "OOP";
        id = 1234;
    }

    //-------------------------------------------- Parametrized Constructor --------------------------------------------
    //A constructor having at least one parameter is called as parameterized constructor.
    //It can initialize each instance of the class to different values.
    
    public Constructor(string firstName, string lastName, string course, int id)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.course = course;
        this.id = id;
    }

    //-------------------------------------------- Copy Constructor --------------------------------------------
    // Its is used to clone a constructor so that we can edit the cloned constructor rather than changing
    // orignal constructor
    //This constructor creates an object by copying variables from another object.
    //Its main use is to initialize a new instance to the values of an existing instance. 
    public Constructor(Constructor def)
    {
        this.firstName = def.firstName;
        this.lastName = def.lastName;
        this.course = def.course;
        this.id = def.id;
    }

    //-------------------------------------------- Static Constructor --------------------------------------------
    //Static Constructor has to be invoked only once in the class and it has been invoked during the creation
    //of the first reference to a static member in the class. A static constructor is initialized static fields
    //or data of the class and to be executed only once. 

    //Points To Remember :  

    //It can’t be called directly.
    //When it is executing then the user has no control.
    //It does not take access modifiers or any parameters.
    //It is called automatically to initialize the class before the first instance created.
    static Constructor()
    {
        Console.WriteLine("Static Constructor is called");
    }

    static void Main(string[] args)
    {

        Constructor def = new Constructor();
        Console.WriteLine();
        Console.WriteLine("Student Name : {0} {1} \nStudent ID : {2} \n Cousre : {3}", def.firstName, def.lastName, def.id, def.course);

        Console.WriteLine();
        Constructor para = new Constructor("MIRZA HAMMAD", "BAIG", "PYTHON", 4321);
        Console.WriteLine("Student Name : {0} {1} \nStudent ID : {2} \n Cousre : {3}", para.firstName, para.lastName, para.id, para.course);

        Console.WriteLine();
        Constructor copy = new Constructor();
        copy.id = 5678;
        copy.course = "c++";
        Console.WriteLine("Student Name : {0} {1} \nStudent ID : {2} \n Cousre : {3}", copy.firstName, copy.lastName, copy.id, copy.course);

        Constructor _static = new Constructor();

    }
}