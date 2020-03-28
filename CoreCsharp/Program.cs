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
            _funWithStringBuilder();

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
    }
}
