using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkrivebordOpgave
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ProgramManager ProgramManager { get; }

        public MainWindow()
        {
            ProgramManager = new ProgramManager();
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string selectedFile = openFileDialog.FileName;

            if (selectedFile != null) 
            {
                ProgramManager.MoveNewImageToFolder(selectedFile);
            }

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog =new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory + "\\backgrounds";
            openFileDialog.ShowDialog();
            string selectedFileToRemove = openFileDialog.FileName;
            ProgramManager.RemoveBackgroundFile(selectedFileToRemove);
        }

        private void SubmitTimeButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
