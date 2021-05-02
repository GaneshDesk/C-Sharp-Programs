// Application which demonstrates user defined namespace and its use with using keyword.
/*
Namespace is considered as set of related classes.
Due to namespace it becomes easy to manage related classes.
We can use using keyword so that we don't have to use complete name all the time.
*/
using System;
using Marvellous;
using Mysys;
namespace Marvellous
{
    class PPA
    { }
}
namespace Mysys
{
    class Angular
    { }
}
class Program
{
    static void Main(string[] args)
    {
        PPA pobj = new PPA();
        Angular aobj = new Angular();
    }
}