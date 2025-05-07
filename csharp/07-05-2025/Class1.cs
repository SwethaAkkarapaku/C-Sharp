using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImporter
{
    public class FileManager
    {
        public string ReadFileContent(string InpPath)
        {
            return "Content read from: " + InpPath;
        }
        public string WriteFileContent(string InpPath,bool OverWrite)
        {
            return "Writing Content to: " + InpPath;
        }
    }
    public class PathHelper
    {
        public string ParsePath()
        {
            return "Path loaded from Azure..";
        }
    }
}
