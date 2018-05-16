using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DocumentClass
{
    public class Folder
    {
        //не совсем поняла как и что должен делать метод "путь до файла"
        public void PathToFile(string pathTo)
        {
            var files = Directory.GetDirectories(pathTo);
            foreach (var item in files)
            {
                var file = File.ReadAllText(item);
            }
        }
    }
}
