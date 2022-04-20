using System;
using System.IO;
using System.Linq;

namespace SkrivebordOpgave.Managers
{
    public class FileManager
    {
        private readonly string bgFolderPath = Environment.CurrentDirectory + "\\backgrounds";

        private string currentBackgroundName = string.Empty;


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

        public string ReadNextBackground()
        {
            if (PathExists())
            {
                var files = Directory.GetFiles(bgFolderPath).ToList();

                if (String.IsNullOrEmpty(currentBackgroundName))
                {
                    currentBackgroundName = files.First();
                    return files.First();
                }

                foreach (var item in files)
                {
                    var file = new FileInfo(item);
                    if (file.FullName == currentBackgroundName)
                    {

                        if (files.IndexOf(item) == files.Count() - 1)
                        {
                            currentBackgroundName = files[0];
                            return files[0];
                        }

                        var chosenFile = new FileInfo(files[files.IndexOf(item) + 1]);

                        currentBackgroundName = chosenFile.FullName;
                        return chosenFile.FullName;
                    }
                }
            }

            return String.Empty;
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
