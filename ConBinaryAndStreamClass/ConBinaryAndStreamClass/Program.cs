using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConBinaryAndStreamClass
{
    class Program
    {
        public void BinaryWriterMethod()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("Binary1.txt", FileMode.Create)))
            {
                bw.Write(12.43);
                bw.Write("122 this is Binary Writer class");
                bw.Write(false);
            }
        }
        public void BinaryReaderMethod()
        {
            using(BinaryReader br= new BinaryReader(File.Open("Binary1.txt", FileMode.Open)))
            {
                Console.WriteLine("Double content is :"+br.ReadDouble());
                Console.WriteLine("string content is :"+br.ReadString());
                Console.WriteLine("Boolean value is :"+br.ReadBoolean());
            }
        }
        
        public void MemoryBufferedStream()
        {
            byte[] file = File.ReadAllBytes(@"G:\memory.txt"); //wrong file name will generate error
            using(MemoryStream ms = new MemoryStream(file))
            {
                //used to read content of memory.txt file
                using(BufferedStream bf= new BufferedStream(ms))
                {
                    for (int i = 0; i < file.Length; i++)
                    {
                        byte res = (byte)bf.ReadByte();
                        Console.WriteLine(res);
                    }
                }

                //another way to read file content

                //using(BinaryReader br = new BinaryReader(ms))
                //{
                //    for (int i = 0; i < file.Length; i++)
                //    {
                //        byte res = br.ReadByte();
                //        Console.WriteLine(res);
                //    }
                //}
            }
        }


        static void Main(string[] args)
        {
            Program pg = new Program();
            
            Console.WriteLine("Content of binary.txt file is :");
            pg.BinaryWriterMethod();
            pg.BinaryReaderMethod();
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("Content of memory.txt file is : ");
            pg.MemoryBufferedStream();
        }
    }
}
