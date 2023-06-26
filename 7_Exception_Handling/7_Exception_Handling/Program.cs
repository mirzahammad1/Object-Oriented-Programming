 // See https://aka.ms/new-console-template for more information

int[] number = { 8, 9, 18, 90 };
int[] divisor = { 2, 2, 3, 5 }; 

for (int i = 0; i < number.Length; i++)
{   
    try    // try block contains the code that can throw and exception
    {        
        Console.WriteLine("Number: " + number[i]);
        Console.WriteLine();
        Console.WriteLine("Divisor: " + divisor[i]);
        Console.WriteLine();
        Console.WriteLine("Quotient: " + number[i] / divisor[i]);
        Console.WriteLine();
        Console.WriteLine(number[i+2]);
    }
    catch (DivideByZeroException) // catch block contains the code that handle that exceptions
    {
        Console.WriteLine("not possible to divide bt zero");
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("index is out of range");
    }
    finally // the code return in this block is always executed weather the exception is handled or not
    {
        Console.WriteLine("The 'TRY CATCH' is finished {0} time/times",i);
    }
}
string p_number = Console.ReadLine();
if (p_number.Length > 11)
{
    throw new ArithmeticException("Phone number must contain 11 digits"); //it allows you to create a custom error 
}
else if (p_number.Length < 11)
{
    throw new ArithmeticException("Phone number must contain 11 digits"); //it allows you to create a custom error 
}
else 
{
    Console.WriteLine(p_number);
}