//Application program for  Method Overriding

using System;
class Base
{
    public void fun()
    {
        Console.WriteLine("In base fun");
    }
    // Virtual method of class
    public virtual void gun()
    {
        Console.WriteLine("In base gun");
    }
}
// Inherit Base class
class Derived : Base
{
    // Redefinition of fun method
    public void fun()
    {
        Console.WriteLine("In Derived fun");
    }
    // Overriding gun method
    public override void gun()
    {
        Console.WriteLine("In Derived gun");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base bobj1 = new Base();
        Derived dobj = new Derived();
        bobj1.fun();
        bobj1.gun();
        dobj.fun();
        dobj.gun();
        // Upcasting
        Base bobj2 = new Derived();
        bobj2.fun();
        bobj2.gun();
    }
}