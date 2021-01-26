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
        static void WriteIntoFile()
        {
            try
            {
                using (FileStream fstream = new FileStream(@"D:\DotNETBatch2021\Assignments\ConsoleAssignment25Jan2021\ConFileInputOutput\ConFileInputOutput\file.txt", FileMode.Create, FileAccess.ReadWrite))
                {
                    using (StreamWriter srr = new StreamWriter(fstream))
                    {
                        
                        Console.WriteLine("Write content to enter into File : ");
                        srr.WriteLine(Console.ReadLine());
                       
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void ReadFromFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"D:\DotNETBatch2021\Assignments\ConsoleAssignment25Jan2021\ConFileInputOutput\ConFileInputOutput\file.txt"))
                {

                    Console.WriteLine("Reading contents of input.txt : \n" + sr.ReadToEnd());
                    

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            
            Program.WriteIntoFile();
            Program.ReadFromFile();
            
        }
    }
}
