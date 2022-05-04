using System;
using System.IO;
using System.Linq;

namespace Antura
{
    /// <summary>
    ///  Antura programming test
    /// </summary>
    public class AnturaProgTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnturaProgTest"/> class.
        /// </summary>
        public AnturaProgTest()
        { }

        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        /// <owner>Thomas Jeppsson</owner>
        static void Main(string[] args)
        {
            AnturaProgTest anturaProgTest = new AnturaProgTest();

            Console.WriteLine("Count words in the file which are the same as the filename");
            Console.WriteLine("Please input path to the file: ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("Valid textfile is missing");
                return;
            }

            //
            // Extract the searchkey (which is the filename without extension)
            //
            string searchKey = Path.GetFileNameWithoutExtension(filename);

            var file = File.Open(filename, FileMode.Open);
            StreamReader streamReader = new StreamReader(file);

            string fileContent = streamReader.ReadToEnd();

            Console.WriteLine("We have " + anturaProgTest.CountKeysInString(fileContent, searchKey) + " matches of " + searchKey+ " in the file.");

            Console.ReadKey();
        }

        /// <summary>Counts the keys in string.</summary>
        /// Note: In this method I have taken the assumption that the searchkey can be inbedded in the test. 
        /// For example: the search key is "test" the searchString could be "test test testapabpatestapa test". In this case the count should be 5
        /// <param name="searchString">The search string.</param>
        /// <param name="searchKey">The search key.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public int CountKeysInString(string searchString, string searchKey)
        {
            int result = 0;
            if (string.IsNullOrWhiteSpace(searchString) || string.IsNullOrWhiteSpace(searchKey))
            {
                return 0;
            }

            int i = 0;
            int searchIndex = 0;
            while (i < searchString.Length && searchIndex != -1)
            {
                searchIndex = searchString.IndexOf(searchKey, i);
                if (searchIndex != -1)
                {
                    result++;
                    i = searchIndex + 1;
                }
            }


            return result;

        }
    }
}
