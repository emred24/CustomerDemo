using CustomerDemo.Abstract;
using CustomerDemo.Adapters;
using CustomerDemo.Concrete;
using CustomerDemo.Entities;
using CustomerDemo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
            

            string Name, Surname, IdentificationId, Birthday;

            Console.Clear();
            Console.WriteLine("Lütfen adı giriniz :");
            Name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Lütfen soyadı giriniz :");
            Surname = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Lütfen TC kimlik numarası giriniz :");
            IdentificationId = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Lütfen doğum yılını giriniz :");
            Birthday = Console.ReadLine();

            try
            {
                //Console.WriteLine($"Adı : {Name} - Soyadı : {Surname} - TC kimlik numarası : {IdentificationId} - Doğum yılı : {Birthday}");
                int IntBirthday = ValueHelper.toInt(Birthday);
                //BaseCustomerManager baseCustomerManager = new FreeCustomerManager();
                BaseCustomerManager baseCustomerManager = new EnterpriseCustomerManager(new MernisServiceAdapter());
                baseCustomerManager.Save(new Customer { CustomerId = 1, Name = Name, Surname = Surname, IdentificationId = IdentificationId, Birthday = new DateTime(IntBirthday, 01, 01) });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata : {ex}");
            }
            Console.ReadKey();
        }
    }
}
