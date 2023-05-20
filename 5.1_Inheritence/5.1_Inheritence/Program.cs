// See https://aka.ms/new-console-template for more information

class Program
{// inheritance 1- reusable
 //             2- can inherit form 1 class to another
 //             public human{}---parent class
 //             public man:human{}---child class
 //             public woman:human{}---child class
 //             3- extend or inherit on class at a time
 //             4- always top to down relationship exit , no sibling (left--right or right--left) relation
 //             5- generalization is common method and specialization is uncommon
    static void Main(string[] args)
    {
        Man obj_man = new Man();
        obj_man.Eat(); // coming from human
        obj_man.Sleep(); // coming from human
        obj_man.Work();
        Console.WriteLine();
        Woman obj_woman = new Woman();
        obj_woman.Eat(); // coming from human
        obj_woman.Sleep(); // coming from human
        obj_woman.Cook();
    }
    public class Human
    {
        public virtual void Eat() // if virtual is written , it has given the permission to change 
        {
            Console.WriteLine("Human Eat");
        }
        public void Sleep()
        {
            Console.WriteLine("Human Sleep");
        }
    }
    public class Man : Human
    {
        public void Work()
        {
            Console.WriteLine("Man Works");
        }
        public override void Eat() // overriding (having same name of method as parent class , it will execute Eat() form Man) 
        {
            Console.WriteLine("Man Eat");
        }
    }
    public class Woman : Human
    {
        public void Eat() // if override is not written it will change but it is forced to change
        {
            Console.WriteLine("Woman Eat");
        }
        public void Cook()
        {
            Console.WriteLine("Woman Cooks");
        }
    }
}