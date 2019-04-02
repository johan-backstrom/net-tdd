using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace net_tdd.se.claremont.util
{
    public class FileReadingUtility
    {
        public List<string> readFileLinesFromResources(string fileName)
        {
            List<string> lines = File.ReadAllLines(fileName).ToList();

            return lines;
        }
    }
   
}
