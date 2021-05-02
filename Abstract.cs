/* 
The abstract modifier indicates that the thing being modified has a missing or
incomplete implementation.
The abstract modifier can be used with classes, methods.
Use the abstract modifier in a class declaration to indicate that a class is
intended only to be a base class of other classes.
Members marked as abstract, or included in an abstract class, must be
implemented by classes that derive from the abstract class.
*/

using System;
abstract class Marvellous
{
    // We can create characteristics in abstract class
    public int i;
    // We can write constructor in abstract class
    public Marvellous()
    {
        Console.WriteLine("Inside constructor of Abstract Marvellous\n");
        i = 11;
    }
    // Abstract method declaration
    public abstract void fun();
    // Concrete method defination
    public void gun()
    {
        Console.WriteLine("Inside concrete gun of Marvellous");
    }
}

class MyClass : Marvellous
{
    // Overrided method fun
    public override void fun()
    {
        Console.WriteLine("Inside concrete fun of MyClass");
    }
}
// It is manadatory to define abstract method in derived class
/*
class NewInfosystems : Marvellous
{
}
*/
class Program
{
    static void Main(string[] args)
    {
        // We can not create object of abstact class
        // Marvellous mobj = new Marvellous();
        // We can create reference of abstract class
        Marvellous mobj = new MyClass();
        mobj.gun();
        mobj.fun();
    }
}