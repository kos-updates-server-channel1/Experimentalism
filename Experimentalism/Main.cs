using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Experimentalism
{
    class Exp_Main : IExpBase
    {
        public Exp_Main()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Experimental is run on " + ExpAPI.GetOSConfig());
            if(File.Exists("//SerializationOverview.xml") == false)
            {
                Console.WriteLine("The game need World creating work for First start.");
                Console.WriteLine("Taking a lot times...");
                Exp_WorldGen();
                Console.WriteLine("World creating work has finished.");
            }           
            Console.WriteLine("Press key to use Function. H Key to view help");
            for (; ; )
            {
                Thread.Sleep(1000);
                var rk = Console.ReadLine();
                var word = Exp_Function(rk);
                Console.WriteLine(word);
            }
        }

        static void Main(string[] args)
        {
            ExpAPI_Post ea = new ExpAPI_Post();
            Exp_Main em = new Exp_Main();
            Console.ReadKey();
        }

        private void Exp_WorldGen()
        {
            long a = 0; a++;
            while (a < 1000)
            {
                a++;
                ExpAPI_Version expv = new ExpAPI_Version(1.0);
                String generatedWorld = a.ToString() + "Ver: " + expv.ver;
                Console.WriteLine(a);
                System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(String));

                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
                System.IO.FileStream file = System.IO.File.Create(path);

                writer.Serialize(file, generatedWorld);
                file.Close();

            }
        }

        private string Exp_Function(string Func)
        {
            
            return "s";
        }

        public void Experimentalism_Dummy()
        {
            Console.Write("");
        }
    }
}