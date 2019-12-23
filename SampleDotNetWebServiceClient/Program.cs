using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDotNetWebServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.Service1 client = new localhost.Service1();
            bool response = client.AuthenticateUser("admin", "admin");
            Console.WriteLine(response);
        }
    }
}
