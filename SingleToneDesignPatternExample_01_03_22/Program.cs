using System;

namespace SingleToneDesignPatternExample_01_03_22
{

    class Program
    {
        static TableServer host1list = TableServer.GetTableServer(); /*= new TableServer();*/
        static TableServer host2list = TableServer.GetTableServer(); /* = new TableServer();*/
        static void Main(string[] args)
        {
            TableServer ts = TableServer.GetTableServer(); /*= new TableServer();*/
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine($"The next server is {ts.GetNextServer()}");
                host1ListNextServer();
                host2ListNextServer();
            }
            Console.ReadLine();
        }
        private static void host1ListNextServer()
        {
            Console.WriteLine($"H1 The next server is : {host1list.GetNextServer()}");
        }
        private static void host2ListNextServer()
        {
            Console.WriteLine($"H2 The next server is : {host2list.GetNextServer()}");
        }
    }
}
