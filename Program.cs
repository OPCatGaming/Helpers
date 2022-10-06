using System;
using System.Collections.Generic;

namespace Helpers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //var ahStr = new ArrayHelpers<string>();
            var ah = new ArrayHelpers();
            var sh = new StringHelpers();
            var Ih = new NumberHelpers();
            var vh = new VectorHelpers();
            string[] s = { "hi", "bye" };
            string[] k = { "hola", "adios" };
            List<string> j = new List<string> { "hola", "adios" };
            s = ah.AddItemToArray(s, j);
            List<string> f = new List<string>();
            f = ah.ToList(s);
            //Console.WriteLine(sh.AdvancedContains("sssharpss", "sharp"));
            //Console.WriteLine(Ih.RoundToNearest(101, 100, 2));

            Position pos1 = new Position(1, 1, 1);
            Position pos2 = new Position(2, 2, 1);

            Console.WriteLine(vh.DistanceBetween(pos1, pos2));


            //int[] shelby = { 1, 2 };
            //int[] cat = { 3, 4 };
            //var good = ah.addItemToArray(shelby, "s");
            //good = ah.removeItemFromArray(good, 2);
            //ahInt.printArrayContents(good);

            //var helpers = new ArrayHelpers();

            ////var helpers = new BadArrayHelpers();
            ////var helpers = new BetterArrayHelpers();

            //var testClass = new TestClass(helpers);
            //testClass.ThisBetterNotBreak();
        }
    }

    //public class BadArrayHelpers : IArrayHelpers
    //{
    //    public string[] addItemToArray(string[] array, string itemToAdd, int index = -1)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class TestClass
    {
        //private readonly IArrayHelpers _arrayHelpers;

        //public TestClass(IArrayHelpers arrayHelpers)
        //{
        //    _arrayHelpers = arrayHelpers;
        //}

        //public void ThisBetterNotBreak()
        //{
        //    string[] myArray = new string[10];

        //    _arrayHelpers.addItemToArray(myArray, "joe");

        //    if (myArray[0] != "joe")
        //    {
        //        Console.WriteLine("Congratulations, the program just crashed!");
        //    }
        //}
    }
}
