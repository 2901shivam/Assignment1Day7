using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {//1
         //Console.WriteLine("Enter the file name for creation");
         //string fname = Console.ReadLine();
         //string path = "C:\\Users\\shiva\\OneDrive\\Desktop\\mphasis-b2\\Day7";
         //string fpath = path + "//" + fname;
         //try
         //{
         //    if (!File.Exists(fpath))
         //    {
         //        File.Create(fpath);
         //        Console.WriteLine("File created successfully"+fpath);

            //    }
            //    else
            //    {
            //        Console.WriteLine("File Already exits");
            //    }
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Error occured "+e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Programm end Here");

            //}

            //2Reading 
            //StreamReader str;
            //try
            //{
            //    string fpath= "C:\\Users\\shiva\\OneDrive\\Desktop\\mphasis-b2\\Day7\\file.txt";
            //    str = new StreamReader(fpath);
            //    string text = "";

            //    while ((text = str.ReadLine()) != null)
            //    {
            //        Console.WriteLine(text);
            //    }
            //    str.Close();

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Error occured"+ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Programm end Here");
            //    Console.ReadKey();
            //}


            //3 Appending

            //StreamWriter str=null;
            //try
            //{ Console.WriteLine("Enter the file name");
            //    string filename = Console.ReadLine();
            //    Console.WriteLine("Entere the content u want to append");
            //    string content = Console.ReadLine();
            //    if (File.Exists(filename))
            //    {
            //        str = File.AppendText(filename);
            //        str.WriteLine(content);
            //    }
            //    else
            //    {
            //        Console.WriteLine("File not exist");
            //    }
                

            //    }
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Error"+ex.Message);
            //}
            //finally
            //{
            //    if(str != null)
            //    {
            //        str.Close();
            //    }
            //    Console.WriteLine("end here");
            //    Console.ReadKey();
            //}


            //4 deletion of the file
           
                Console.WriteLine("Enter the file name which u want to delet");
                string name = Console.ReadLine();
                try
                {
                    if (File.Exists(name))
                    {
                        File.Delete(name);
                        Console.WriteLine("file deletd succes fully");
                    }
                    else
                    {
                        Console.WriteLine("file doesnot exist");
                    }
                }
                catch(Exception m)
                {
                    Console.WriteLine("Error!! "+m.Message);
                }
            finally
            {
                Console.WriteLine("Programm end here");
                Console.ReadKey();
            }
            
            
        }
    }
}
