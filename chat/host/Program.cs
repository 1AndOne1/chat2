using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using chat;
using System.ServiceModel.Description;

namespace host
{

    internal class Program
    {

        static void Main(string[] args)
         {
            using(var host = new ServiceHost(typeof(chat.ServiceChat)))
            {
                host.Open();
                Console.WriteLine("Host Start");
                Console.ReadLine();
            }
         }
    }
}
