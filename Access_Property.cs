// Below application demonstrates use of get and set property in MarvellousBook class
using System;
using System.Text;

class MarvellousBook
{
    private string name = "not known";
    private int price = 0;
    // Declare a Name property of type string:
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    // Declare a Price property of type int
    public int Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }

// Override the method from Object class
public override string ToString()
    {
        return "Book name = " + Name +", Price = " + Price;
    }
}
class Marvellous
{
    static void Main(string[] args)
    {
        MarvellousBook s1 = new MarvellousBook();
        s1.Name = "Windows Internals";
        s1.Price = 900;
        Console.WriteLine("Book Info: {0}", s1);
        s1.Price += 100;
        Console.WriteLine("Book Info: {0}", s1);
        MarvellousBook s2 = new MarvellousBook();
        s2.Name = "Web Development";
    s2.Price = 750;
        Console.WriteLine("Book Info: {0}", s2);
        s2.Price -= 50;
        Console.WriteLine("Book Info: {0}", s2);
    }
}