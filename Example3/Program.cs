using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            F6();
        }

        private static void F6()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("test");
        }

        private static void F5()
        {
            bool alive = true;
            while (alive)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("YES!");
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Bye!");
                        alive = false;
                        break;
                    default:
                        Console.WriteLine("NO!");
                        break;
                }
               
            }
        }

        private static void F4()
        {
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.A)
                {
                    Console.WriteLine("YES!");
                }
                else if (pressedKey.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("NO!");
                }
            }
        }
        static void ShowDirectoryContent(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            /*DirectoryInfo[] x = di.GetDirectories();
              var y = di.GetDirectories();
            /*for (int i = 0; i < x.Length; ++i)
            {
                Console.WriteLine(x[i].Name);
            }*/
            foreach (DirectoryInfo d in di.GetDirectories())
            {
                Console.WriteLine(d.Name);
            }

            foreach (FileInfo f in di.GetFiles())
            {
                Console.WriteLine(f.Name);
            }
            
        }
        private static void F1()
        {
            ShowDirectoryContent(@"C:\QtSDK\Desktop\Qt\4.8.0\mingw");
        }

        private static void F2()
        {
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Hello world!");

            sw.Close();
            fs.Close();
        }

        private static void F3()
        {
            FileStream fs = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string text = sr.ReadToEnd();

            Console.WriteLine(text);

            sr.Close();
            fs.Close();
        }



    }
}
