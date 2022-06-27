using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryBasicParser
{
    public class VeryBasicParser
    {
        /// <summary>
        /// The object that stores key and value pairs.
        /// </summary>
        public IDictionary<string, string> keyValues = new Dictionary<string, string>();
        /// <summary>
        /// Initilize the class to parse your file to keys and values by a seperator.
        /// </summary>
        /// <param name="filepath">File path to the text file to parse.</param>
        /// <param name="seperator">The character used to seperate your keys with their values</param>
        public VeryBasicParser(string filepath,char seperator)
        {
            foreach(string value in File.ReadAllLines(filepath))
            {
                string[] pair = value.Split(seperator);
                keyValues.Add(pair[0], pair[1]);
            }
        }
    }
}
