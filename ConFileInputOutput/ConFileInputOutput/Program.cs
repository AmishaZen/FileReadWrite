using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConFileInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader srr = null;
            using (FileStream fstream = new FileStream("G:\\input.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter srr = new StreamWriter(fstream))
                { 
                   Console.WriteLine("Write content to enter into File : ");
                   srr.WriteLine(Console.ReadLine());
                }
                using (StreamReader sr = new StreamReader("G:\\input.txt"))
                {
                    //string line;
                    //while((line = sr.ReadLine()) != null)
                    //{
                    //    Console.WriteLine(line);
                    //}
                   Console.WriteLine("Reading contents of input.txt : \n" + sr.ReadToEnd());
                    
                }
            }
        }
    }
}
