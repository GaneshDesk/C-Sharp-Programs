//Application which demonstrates user defined namespace and its use by specifying its name directly.
/*
Namespace is considered as set of related classes.
Due to namespace it becomes easy to manage related classes.
In below program we access classes from user defined namespaces directly.
*/
using System;
namespace Marvellous
{
    class PPA
    { }
}
namespace MySys
{
    class Angular
    { }
}
class Program
{
    static void Main(string[] args)
    {
        Marvellous.PPA pobj = new Marvellous.PPA();
        MySys.Angular aobj = new MySys.Angular();
    }
}