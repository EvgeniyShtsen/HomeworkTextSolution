using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace TextSolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            string way = @"C:\Users\SECTOR\source\repos\HomeworkTextSolution\TextSolution\sample.txt";
            using (StreamReader sw = new StreamReader(way, Encoding.UTF8))
            {
                var text = sw.ReadToEnd();
                var strings = text.Split(new char[] { '.', '!', '?', }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < strings.Length; i++)
                {
                    using (StreamWriter fstream = new StreamWriter(@"C:\Users\SECTOR\source\repos\HomeworkTextSolution\TextSolution\words.txt", false, Encoding.UTF8))
                    {
                        fstream.WriteLine(strings[i]);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
 







    //C: \Users\SECTOR\source\repos\HomeworkTextSolution\TextSolution\sample.txt

   // List<string> paragraphs = text.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries).ToList();

           //     foreach (string paragraph in paragraphs)
           //     {  
                     //       fstream.WriteLine(paragraph);
    //
         //using (StreamWriter fstream = new StreamWriter(@"C:\Users\SECTOR\source\repos\HomeworkTextSolution\TextSolution\strings.txt", false, Encoding.UTF8))
                //{
                  //  text = text.Trim();
                    //text = text.Replace('"', ' ');
                    //string[] sentences = Regex.Split(text, @"([A-Z]*[a-z]*[? \\-\\,\""\'']*)");
                    //var point = sentences[0];
                    //foreach (var sen in sentences)
                    //{
                      //  fstream.WriteLine(sen);
                    //}
                //}
                //using (StreamWriter fstream = new StreamWriter(@"C:\Users\SECTOR\source\repos\HomeworkTextSolution\TextSolution\words.txt", false, Encoding.UTF8))
                //{
                  //  text = text.Replace("  ", " ");
                    //text = text.Replace("\n\r", string.Empty);
                    //text.Trim();
                    //string[] sentences = Regex.Split(text, @"([^\s]*)");
                    //var point = sentences[0];
                    //foreach (var sen in sentences)
                    //{
                      //  fstream.WriteLine(sen);
                    //}
                //}
                //using (StreamWriter fstream = new StreamWriter(@"C:\Users\SECTOR\source\repos\HomeworkTextSolution\TextSolution\pointers.txt", false, Encoding.UTF8))
                //{
                    //text = text.Trim();
                    //text = text.Replace('"', ' ');
                    //string[] sentences = Regex.Split(text, @"([A-Z]*[a-z]*[? \\-\\,\""\'']*)");
                    //var point = sentences[0];
                    //foreach (var sen in sentences)
                    // {
                    //       fstream.WriteLine(sen);
                    //     }
                    //   }

// }


