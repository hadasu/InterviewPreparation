using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparation
{
    class Program
    {
        static List<string> list = new List<string>();
        static Dictionary<string, string> Dictionary = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            //DirSearch("C:\\Users\\Nikita\\Desktop\\New folder"); *1*
            //Dictionary.Reverse();
            //list.Reverse();

            //RegularExpressions(); *2*

            //BinaryTree b = new BinaryTree(); *3*
            //b.insert(1);
            //b.insert(6);
            //b.insert(2);
            //b.insert(4);
            //b.insert(5);
            //b.insert(3);
            //b.ReverseTree(b.root);
            //b.display();



            Console.ReadLine();
        }

        // DirSearch 1
        static void DirSearch(string sDir) 
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(sDir))
                {
                    foreach (string file in Directory.GetFiles(dir))
                    {
                        list.Add(file);
                        Dictionary.Add(file, file);
                        Console.WriteLine(file);
                    }
                    DirSearch(dir);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        // RegularExpressions - 2
        // https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
        static void RegularExpressions()
        {
            string[] numbers =
            {
            "123-555-0190",
            "444-234-22450",
            "690-555-0178",
            "146-893-232",
            "146-555-0122",
            "4007-555-0111",
            "407-555-0111",
            "407-2-5555",
        };

            string sPattern = "^\\d{3}-\\d{3}-\\d{4}$";

            foreach (string s in numbers)
            {
                System.Console.Write(s);

                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern))
                {
                    System.Console.WriteLine(" - valid");
                }
                else
                {
                    System.Console.WriteLine(" - invalid");
                }
            }
        }


    }
}
