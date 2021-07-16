using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace EssentialTrainingApp
{
    class Program
    {
        public static List<string> words;
        public static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Trace("The Program started.");
            words = new List<string>();
            words.Add("Bread");
            words.Add("Milk");
            words.Add("Cheese");
            ReadTextFile();
        }
        
        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (int i = 0; i < 10; i++)
            {
                income = income / i;
            }
            return income;
        }

        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine();
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("No Directory.");
                logger.Error("The Directory not found");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("No file.");
                logger.Error("The Directory not found");
            }
        }
    }
}
