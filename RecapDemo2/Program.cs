using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//create a basic implementation with using interface
namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
           // customerManager.Logger = new DatabaseLogger();
            customerManager.Logger = new FileLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        
            public ILogger Logger { get; set; }
            public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added.");
        }
           
    }

    // if only class logger, (no interface ect) you can use it only with new()
    // db'e de basılabilir veya txt ye json formatında da eklenebilir
    class DatabaseLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class SMSLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS!");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
