// Methods are block of codes which is run only when it is called.
// You can pass data, known as parameters, into a method.
//Methods are used to perform certain actions, and they are also known as functions.
//Why use methods? To reuse code: define the code once, and use it many times.

//--------------------------------------------Creating METHOD--------------------------------------------

//class Program1
//{
//    static void methode() // static tells that this methode belongs to class Program and void means this methode does not have to return value
//    {
//        string methode = "This how a methode is created";
//        Console.WriteLine(methode);
//    }


//    //--------------------------------------------Calling METHOD--------------------------------------------

//    static void Main(string[] args)
//    {
//        methode(); // Methode is simply called by calling methode's name
//    }
//}

//--------------------------------------------Parameters and Arguments--------------------------------------------

//Information can be passed to methods as parameter. Parameters act as variables inside the method.
//hey are specified after the method name, inside the parentheses. You can add as many parameters as you want, just separate them with a comma.
class Program2
{
    static void parameterized_methode(int a,int b)
    {
        int c = a + b;
        Console.WriteLine(" Value of A is : {0} \n Value of B is : {1} \n Value of C by adding A and B is : {2}", a , b , c);
    }

    //-------------------------------------------- Default Parameter --------------------------------------------
    static void default_parameter(string name = "OOP")
    {
        Console.WriteLine("The Name of the programming language is " +  name);
    }

    //-------------------------------------------- Return Values --------------------------------------------
    //If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void
    //and use the return keyword inside the method

    static int Return(int a)
    {
        return a;
    }

    //-------------------------------------------- Named Arguments --------------------------------------------
    //It is also possible to send arguments with the key: value syntax.


    static void Named(string name1,string name2,string name3)
    {
        Console.WriteLine("The Name of 3rd student is : " + name3);
    }

    //-------------------------------------------- Method Overloading --------------------------------------------
    //Multiple methods can have the same name with different parameters
    static void Overloading1(int x,int y)
    {
        int z = x + y;
        Console.WriteLine("By Adding two arguments : " + z);
    }
    static void Overloading2(double x,double y)
    {
        double z = x / y;
        Console.WriteLine("By Dividing two arguments : " + z);
    }
    static void Main(String[] args)
    {
        parameterized_methode(2, 4);
        Console.WriteLine();

        default_parameter();//if the a parameter is not passed and the value of provided in parameter of methode is called
        default_parameter("Python");
        Console.WriteLine();

        Console.WriteLine("Return Value is : "+Return(5));

        Console.WriteLine();
        Named(name1: "Sam", name3: "Lee", name2: "Mirza");// The order of the arguments does not matter
        
        Console.WriteLine();
        Overloading1(5, 7);
        Overloading2(4.7, 3.2);
    }
}