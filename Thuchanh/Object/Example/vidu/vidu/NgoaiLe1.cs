using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace vidu
{
    public class NgoaiLe1
    {
        public static void Main()
        {
            FileStream file = new FileStream($"E:\\Học hành\\Codegym\\Module_Csharp" +
                $"\\Filelog\\log{DateTime.Now.ToString("dd-MM-yyyy")}.txt",FileMode.Append);

            try
            {
                Console.WriteLine("Input a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input b");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}/{1} = {2}", a, b, a / b);
            }
            catch (DivideByZeroException div)
            {
                using(StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine($"[Log]:{DateTime.Now.ToString("dd / MM / yyyy hh:mm:ss:tt")}:{div.Message}");
                }
                Console.WriteLine("Error: ", div.Message);
            }
            
           
            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);
               
            }
            finally
            {
                Console.WriteLine("go to finally");
            }
            file.Close();
            FileStream file1 = new FileStream($"E:\\Học hành\\Codegym\\Module_Csharp" +
              $"\\Filelog\\log{DateTime.Now.ToString("dd-MM-yyyy")}.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(file1))
            {
                var content = reader.ReadToEnd();
                Console.Write(content);
            }

        }
    }
}
