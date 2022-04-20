using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
        }

        public void SetTimerInterval(int interval)
        {
            TimeManager.SetTimer(interval);
            TimeManager.Timer.Elapsed += T_Elapsed;
            TimeManager.Timer.Enabled = true;
        }


        private void T_Elapsed(object source, ElapsedEventArgs e)
        {
            WindowsManager.DisplayPicture(FileManager.ReadNextBackground());
        }

    }
}
