using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExClass example = new ExClass();

            example.PropertyChanged += Example_PropertyChanged;

            example.Name = "NewName";
        }

        private static void Example_PropertyChanged(object sender, PropertyEventArgs e)
        {
            Console.WriteLine($"Свойство {e.PropertyName} было изменено.");
        }
    }
}
