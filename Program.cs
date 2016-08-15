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
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/Kshatriya Indraja/Documents/Visual Studio 2012/Projects/JSON/JSON/unbeautify.txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        beautify = string.Concat(beautify, line);
                        //Console.WriteLine(line);
                    }
                    Console.WriteLine(beautify);
                }
            }
            catch (Exception e)
            {

                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            int count = 0;
            //Console.WriteLine(str);
            //foreach (char c in beautify)
            //{
            //    //Console.WriteLine(str);
                


            //}

            using (StreamWriter sw = new StreamWriter("C:/Users/Kshatriya Indraja/Documents/Visual Studio 2012/Projects/JSON/JSON/beautify.txt"))
            {

                foreach (char s in beautify)
                {
                   // sw.WriteLine(s);
                    switch (s)
                    {
                        case '{':
                            {
                                sw.WriteLine("{" + "\n");
                                count++;
                                //Console.Write(count);

                                for (int i = 0; i < count; i++)
                                {
                                    sw.Write("\t");
                                }

                                // Console.WriteLine("\n");
                                continue;
                            }
                        case ',':
                            {
                                sw.WriteLine("," + "\n");
                                for (int i = 0; i < count; i++)
                                {
                                    sw.Write("\t");
                                }
                                continue;
                            }
                        case ':':
                            {
                                sw.Write(":" + " ");
                                continue;
                            }
                        case '[':
                            {
                                // Console.WriteLine("hai");
                                sw.WriteLine("[" + "\n");
                                count++;
                                // Console.Write(count);
                                for (int i = 0; i < count; i++)
                                {
                                    sw.Write("\t");
                                }
                                continue;
                            }
                        case ']':
                            {
                                sw.WriteLine("\n");
                                count--;
                                // Console.Write(count);
                                for (int i = 0; i < count; i++)
                                {
                                    sw.Write("\t");
                                }
                                sw.Write("]");
                                continue;
                            }
                        case '}':
                            {
                                sw.WriteLine("\n");
                                count--;
                                //  Console.Write(count);
                                for (int i = 0; i < count; i++)
                                {
                                    sw.Write("\t");
                                }
                                sw.Write("}");
                                continue;
                            }
                        case ' ':
                            {
                                sw.Write(s);
                                continue;

                            }
                        default:
                            {
                                sw.Write(s);

                                break;
                            }
                    }
                }
            }

            // Read and show each line from the file.
            string loadline = "";
            using (StreamReader sr = new StreamReader("beautify.txt"))
            {
                while ((loadline = sr.ReadLine()) != null)
                {
                    Console.WriteLine(loadline);
                }
            }

            Console.ReadKey();
        }
    }
}
