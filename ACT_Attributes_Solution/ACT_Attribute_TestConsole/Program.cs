using System;

namespace ACT.TestConsole.Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ACT_ATTRIBUTE_EXAMPLE B = new ACT_ATTRIBUTE_EXAMPLE();
            var _D = ACT_ATTRIBUTE_EXAMPLE.GetAllAttributes<ACT_ATTRIBUTE_EXAMPLE>(B);
            foreach (var D in _D.Keys) {
                Console.WriteLine(D + " = " + _D[D].ToString());
            }
        }
    }
}