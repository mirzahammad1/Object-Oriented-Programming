// See https://aka.ms/new-console-template for more information

//-----------------------------------------------Q#1-----------------------------------------------
class Vision
{

    private int length;
    private int width;

    public Vision()
    {
        SetLength();
        SetWidth();
    }

    public Vision(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    public Vision(float length, float width)
    {
        this.length = (int)length;
        this.width = (int)width;
    }

    private void SetLength()
    {
        Console.Write("Enter length: ");
        length = Convert.ToInt32(Console.ReadLine());
    }

    private void SetWidth()
    {
        Console.Write("Enter width: ");
        width = Convert.ToInt32(Console.ReadLine());
    }

    private int CalculateArea()
    {
        return length * width;
    }

    public int CalculatePrice()
    {
        int area = CalculateArea();
        return area * 65;
    }

    public void Display()
    {
        Console.WriteLine("Your LED purchase details :");
        Console.WriteLine();
        Console.WriteLine("Length = " + length);
        Console.WriteLine("Width = " + width);
        Console.WriteLine();
        Console.WriteLine("Price = " + CalculatePrice());
    }
}
//-----------------------------------------------Q#2-----------------------------------------------



class Igloo
{
    private const int PriceTwoScoops = 100;
    private const int PriceThreeScoops = 150;
    private const int WaferPrice = 10;
    private const int ChocolateFlavourPriceTwoScoops = 120;
    private const int ChocolateFlavourPriceThreeScoops = 180;

    private string[] flavours = { "Chocolate", "Vanilla", "Strawberry", "Mango", "Tutti Fruit", "Almond Crunch", "Coffee" };

    private int numberOfScoops;
    private bool wantsWafer;
    private string selectedFlavour;

    public Igloo()
    {
        GetCustomerRequirements();
        DisplayPaymentDetails();
    }

    private void GetCustomerRequirements()
    {
        Console.WriteLine("Welcome to Igloo Ice Cream Vendor!");
        Console.WriteLine("Available Flavours:");
        DisplayFlavours();

        Console.Write("Enter the number of scoops (2 or 3): ");
        numberOfScoops = Convert.ToInt32(Console.ReadLine());

        if (numberOfScoops != 2 && numberOfScoops != 3)
        {
            Console.WriteLine("Invalid input. Number of scoops must be 2 or 3.");
            Environment.Exit(0);
        }

        Console.Write("Do you want to purchase a vanilla wafer? (Yes/No): ");
        string answer = Console.ReadLine();

        wantsWafer = (answer == "Yes" || answer == "yes");

        Console.Write("Enter the flavour: ");
        selectedFlavour = Console.ReadLine();
    }

    private void DisplayFlavours()
    {
        for (int i = 0; i < flavours.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {flavours[i]}");
        }
    }

    private int Price()
    {
        int totalPrice = 0;

        if (numberOfScoops == 2)
        {
            totalPrice += PriceTwoScoops;

            if (selectedFlavour == "Chocolate")
            {
                totalPrice += ChocolateFlavourPriceTwoScoops;
            }
        }
        else if (numberOfScoops == 3)
        {
            totalPrice += PriceThreeScoops;

            if (selectedFlavour == "Chocolate")
            {
                totalPrice += ChocolateFlavourPriceThreeScoops;
            }
        }

        if (wantsWafer)
        {
            totalPrice += WaferPrice;
        }

        return totalPrice;
    }

    private void DisplayPaymentDetails()
    {
        Console.WriteLine("\nBILL:");
        Console.WriteLine("Flavour: " + selectedFlavour);
        Console.WriteLine("Number of Scoops: " + numberOfScoops);
        Console.WriteLine("Wafer: " + (wantsWafer ? "is required " : "is not required"));
        Console.WriteLine("Total Amount: Rs. " + Price());
    }

}


class Program
{
    static void Main(string[] args)
    {
        //-----------------------------------------------Q#1-----------------------------------------------

        Console.WriteLine("Using the Nullary constructor");
        Vision tv1 = new Vision();
        tv1.Display();

        Console.WriteLine("Using the Parameterized constructor with integers");
        Vision tv2 = new Vision(50, 40); 
        tv2.Display();

        Console.WriteLine("Using the Parameterized constructor with floats");
        Vision tv3 = new Vision(55.5f, 42.2f);  
        tv3.Display();

        //-----------------------------------------------Q#2-----------------------------------------------
        
        Igloo igloo = new Igloo();
    }
}
