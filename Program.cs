using System;
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
            string str = "{menu:{id:file,value:File,popup:{menuitem:[{value:New,onclick:CreateNewDoc()},{value:Open,onclick:OpenDoc()},{value:Close,onclick:CloseDoc()}]}}} ";
            int count = 0;
            Console.WriteLine(str);
            foreach(char c in str)
            {
                //Console.WriteLine(str);
                switch(c){
                   case '{':
                       {
                            Console.Write("{"+"\n");
                            count++;
                           //Console.Write(count);

                           for(int i=0;i<count;i++)
                           {
                               Console.Write("  ");
                           }
                           
                           // Console.WriteLine("\n");
                            continue;
                       }
                   case ',':
                       {
                           Console.Write(","+" ");
                           continue;
                       }
                   case ':':
                       {
                            Console.Write(":"+" ");
                           continue;
                       }
                   case '[':
                       {
                          // Console.WriteLine("hai");
                           Console.Write("["+"\n");
                           count++;
                          // Console.Write(count);
                           for (int i = 0; i < count; i++)
                           {
                               Console.Write("  ");
                           }
                           continue;
                       }
                   case ']':
                       {
                           Console.Write("\n");
                           count--;
                          // Console.Write(count);
                           for (int i = 0; i < count; i++)
                           {
                               Console.Write("  ");
                           }
                           Console.Write("]");
                           continue;
                       }
                   case '}':
                       {
                          Console.Write("\n");
                           count--;
                         //  Console.Write(count);
                           for (int i = 0; i < count; i++)
                           {
                               Console.Write("  ");
                           }
                           Console.Write("}");
                           continue;
                       }
                   default :
                       {
                           Console.Write(c);
                           break;
                       }
               }
               
               
            }
            Console.ReadKey();
        }
    }
}
/*{"menu": {
  "id": "file",
  "value": "File",
  "popup": {
    "menuitem": [
      {"value": "New", "onclick": "CreateNewDoc()"},
      {"value": "Open", "onclick": "OpenDoc()"},
      {"value": "Close", "onclick": "CloseDoc()"}
    ]
  }
 * {menu:{id:file,value:File,popup:{menuitem:[{value:New,onclick:CreateNewDoc()},{value:Open,onclick:OpenDoc()},{value:Close,onclick:CloseDoc()}]}}}
}}*/