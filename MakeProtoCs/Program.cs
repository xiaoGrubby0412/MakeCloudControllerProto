using Baidu.VR.Zion;
using System;

namespace MakeProtoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CloudControlManager manager = new CloudControlManager();
            manager.Start();
        }
    }
}
