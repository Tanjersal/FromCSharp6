using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //_showEnvironmentDetails();
            //_formatNumericalData();
            //_charFunctionality();
            //_parseFromString();
            //_stringEquality();
            //_stringEqualityPerformingCompareRules();
            //_funWithStringBuilder();
            //_patternMatchingSwitch();
            //_secondPatternMatchingSwitch();
            //_simpleArrays();
            //_implicitTypedArrays();
            //_arrayOfObjects();
            //_passByValue();
            //_passByOutParameter();
            //_passByReference();
            _returnRefToLocal();

            Console.ReadLine();
        }

        private static void _showEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Driver: {0}", drive);
            }

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of process {0}", Environment.ProcessorCount);
            Console.WriteLine(".Net version {0}", Environment.Version);
            Console.WriteLine("Is 64 bit: ? {0}", Environment.Is64BitOperatingSystem);
        }

        private static void _formatNumericalData()
        {
            Console.WriteLine("The value 9999 in other formats:");
            Console.WriteLine("c format: {0:c}", 9999);
            Console.WriteLine("d9 format: {0:d9}", 9999);
            Console.WriteLine("f3 format: {0:f3}", 9999);
            Console.WriteLine("N formfat: {0:n}", 9999);
        }

        private static void _charFunctionality()
        {
            char myChar = 'a';

            Console.WriteLine("char.isDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.isLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.isWhitespace('Hello there', 5): {0}", char.IsWhiteSpace("hello there", 5));
            Console.WriteLine("char.isPunctuation('?'): {0}", char.IsPunctuation('?'));

        }

        private static void _parseFromString()
        {
            bool b = Boolean.Parse("True");
            Console.WriteLine("Value of b is: {0}", b);

            double d = double.Parse("99.32");
            Console.WriteLine("Value of d is: {0}", d);

            int i = int.Parse("1");
            Console.WriteLine("value of i is: {0}", i);

            char c = char.Parse("c");
            Console.WriteLine("Value of c is: {0}", c);
        }

        private static void _stringEquality()
        {
            string s1 = "Hello!";
            string s2 = "Yo!";

            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);

            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");

            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine("Hello!.Equals(s1): {0}", "Hello!".Equals(s1));
        }

        private static void _stringEqualityPerformingCompareRules()
        {
            string s1 = "Hello!";
            string s2 = "HELLO!";

            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            Console.WriteLine("Default rules: s1={0}, s2={1}, s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
            Console.WriteLine("Ignore case, Invariant culture: " +
                "s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", 
                s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();

            Console.WriteLine("Default rules: s1={0}, s2={1}, s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", 
                s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, invariant culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}",
                s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
        }

        private static void _funWithStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.AppendLine("Half life");
            sb.AppendLine("MorrowLine");
            sb.AppendLine("Deux Ex" + "2");

            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible bar");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars", sb.Length);
        }

        private static void _patternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], 2[String (\"Hi\")], 3[Decimal (2.5)]");
            Console.WriteLine("Please choose an option: ");
            string userChoice = Console.ReadLine();

            object choice;

            //standard pattern matching
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = "2.5";
                    break;
                default:
                    break;
            }

            //switch (choice)
            //{
            //    case int i:
            //        Console.WriteLine("Your choice is an {0}", i);
            //        break;
            //    case string s:
            //        Console.WriteLine("Your choice is a string");
            //        break;
            //    case decimal d:
            //        Console.WriteLine("Your choice is a decimal");
            //        break;
            //    default:
            //        break;
            //}

            Console.WriteLine();
        }

        private static void _secondPatternMatchingSwitch()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.WriteLine("Pick your favorite language");

            object langChoice = Console.ReadLine();
            var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB, OOP, multithreading and more!");
                    break;
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("C#, is a fine language");
                    break;
                default:
                    Console.WriteLine("Well, good luck!");
                    break;
            }
            Console.WriteLine();
        }

        private static void _simpleArrays()
        {
            //array of int with 3 elements
            int[] myInts = new int[3];

            myInts[0] = 1;
            myInts[1] = 4;
            myInts[2] = 0;

            foreach (int element in myInts)
            {
                Console.WriteLine(element);
            }

            //array of strings
            string[] books = new string[100];
        }

        private static void _implicitTypedArrays()
        {
            var a = new[] { 1, 2, 6, 100 };
            Console.WriteLine("a is a {0}", a.ToString());

            var b = new[] { 1.2, 4.6, 100.3 };
            Console.WriteLine("b is a {0}", b.ToString());

            var s = new[] { "Hello", "Faie", "Too" };
            Console.WriteLine("s is a {0}", s.ToString());
        }

        private static void _arrayOfObjects()
        {
            object[] myObjects = new object[3];

            myObjects[0] = 4;
            myObjects[1] = false;
            myObjects[2] = new DateTime(2020, 11, 20);

            foreach(object obj in myObjects)
            {
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj.ToString());
            }
        }

        private static void _passByValue()
        {
            // pass by value variables
            int x = 9;
            int y = 1000;

            Console.WriteLine("Before call, x is {0} and y is {1}", x, y);
            Console.WriteLine("Answer with call is: {0}", Add(x, y));
            Console.WriteLine("After call, x is {0} and y is {1}", x, y);
        }

        private static void _passByOutParameter()
        {
            Add(90, 90, out int ans);
            ReturnMultipleValues(out int i, out string s, out bool b);

            Console.WriteLine("90 + 90 = {0}", ans);
            Console.WriteLine("The values are: a={0}, b={1}, c={2}", i, s, b);
        }

        private static void _passByReference()
        {
            string str1 = "Flip";
            string str2 = "Flop";

            Console.WriteLine("Before: {0}, {1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1}", str1, str2);
        }

        private static void _returnRefToLocal()
        {
            string[] array = { "one", "two", "three" };
            int pos = 1;

            Console.WriteLine("Before: {0}, {1}, {2}", array[0], array[1], array[2]);
            var ouput = SimpleReturn(array, pos);
            Console.WriteLine(ouput);

            ouput = "new";
            Console.WriteLine("After: {0}, {1}, {2}", array[0], array[1], array[2]);

            Console.WriteLine();

            Console.WriteLine("Before ref call: {0}, {1}, {2}", array[0], array[1], array[2]);
            ref var output = ref ReferenceReturn(array, 2);

            output = "test";
            Console.WriteLine("After ref call: {0}, {1}, {2}", array[0], array[1], array[2]);
        }


        #region private functions

        private static int Add(int x, int y)
        {
            int ans = x + y;

            x = 1000;
            y = 999;

            return ans;
        }

        private static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        private static void ReturnMultipleValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Oivla!";
            c = true;
        }

        private static void SwapStrings(ref string p1, ref string p2)
        {
            string temp = p1;
            p1 = p2;
            p2 = temp;
        }

        private static string SimpleReturn(string[] array, int position)
        {
            return array[position];
        }

        /// <summary>
        /// Return the reference position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        private static ref string ReferenceReturn(string[] array, int position)
        {
            return ref array[position];
        }

        #endregion
    }
}
