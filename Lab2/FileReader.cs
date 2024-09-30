using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    public class FileReader : IFileReader
    {
        public string[] Read(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"The file {path} does not exist.");
            }

            return File.ReadAllLines(path);
        }
    }

}
