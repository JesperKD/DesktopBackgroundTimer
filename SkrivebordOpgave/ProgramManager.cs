using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkrivebordOpgave.Managers;

namespace SkrivebordOpgave
{
    public class ProgramManager
    {
        public FileManager FileManager { get; }
        public TimeManager TimeManager { get; }

        public ProgramManager()
        {
            FileManager = new FileManager();
            TimeManager = new TimeManager();
        }

        public  void MoveNewImageToFolder(string selectedFilePath)
        {
       
            FileManager.InsertBackground(selectedFilePath);
        }

        public void RemoveBackgroundFile(string selectedFile)
        {
            FileManager.RemoveBackground(selectedFile);
            //WindowsManager.DisplayPicture(selectedFile);
        }

    }
}
