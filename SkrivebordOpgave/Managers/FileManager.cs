using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkrivebordOpgave.Managers
{
    public class FileManager
    {
        private string bgFolderPath = Environment.CurrentDirectory + "\\backgrounds";


        public void InsertBackground(string newBackgroungPath)
        {
            if (PathExists())
            {
                FileInfo file = new FileInfo(newBackgroungPath);


                string fileName = file.Name;

                File.Move(newBackgroungPath, bgFolderPath + "\\" + fileName, true);
            }
            else
            {
                CreatePath();
            }

        }

        public void RemoveBackground(string backgroundToRemove)
        {
            if (File.Exists(backgroundToRemove))
            {
                File.Delete(backgroundToRemove);
            }
            
        }

        public void ReadBackground()
        {

        }

        private bool PathExists()
        {
            return Directory.Exists(bgFolderPath);
        }

        private void CreatePath()
        {
            Directory.CreateDirectory(bgFolderPath);
        }


    }
}
