using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            string beautify = "";
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/Kshatriya Indraja/Documents/Visual Studio 2012/Projects/JSON/JSON/unbeautify.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        beautify = string.Concat(beautify, line);
                    }
                    Console.WriteLine(beautify);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            int count = 0;
            using (StreamWriter sw = new StreamWriter("C:/Users/Kshatriya Indraja/Documents/Visual Studio 2012/Projects/JSON/JSON/beautify.txt"))
            {
                foreach (char s in beautify)
                {
                    switch (s)
                    {
                        case '{':
                            {
                                sw.WriteLine("{" + "\n");
                                count++;
                                for (int i = 0; i < count; i++)
                                    sw.Write("\t");
                                continue;
                            }
                        case ',':
                            {
                                sw.WriteLine("," + "\n");
                                for (int i = 0; i < count; i++)
                                    sw.Write("\t");
                                continue;
                            }
                        case ':':
                            {
                                sw.Write(":" + " ");
                                continue;
                            }
                        case '[':
                            {
                                sw.WriteLine("[" + "\n");
                                count++;
                                for (int i = 0; i < count; i++)
                                    sw.Write("\t");
                                continue;
                            }
                        case ']':
                            {
                                sw.WriteLine("\n");
                                count--;
                                for (int i = 0; i < count; i++)
                                    sw.Write("\t");
                                sw.Write("]");
                                continue;
                            }
                        case '}':
                            {
                                sw.WriteLine("\n");
                                count--;
                                for (int i = 0; i < count; i++)
                                   sw.Write("\t");
                                sw.Write("}");
                                continue;
                            }
                        case ' ':
                            {
                                sw.Write(s);
                                break;
                            }
                        default:
                            {
                                sw.Write(s);
                                break;
                            }
                    }
                }
            }
            string loadline = "";
            using (StreamReader sr = new StreamReader("beautify.txt"))
            {
                while ((loadline = sr.ReadLine()) != null)
                  Console.WriteLine(loadline);
            }
            Console.ReadKey();
        }
    }
}
