using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20181116_Windows_Forms
{
    public partial class Form1 : Form //partial - gdzies w kodzie jest dalsza definicja klasy
    {
        private FileSystemWatcher _watcher;

        public Form1()
        {
            InitializeComponent();

            InitializeWatcher();

        }

        private void InitializeWatcher()
        {
            _watcher = new FileSystemWatcher();
            _watcher.Changed += _watcher_Changed;
            _watcher.Created += _watcher_Changed;
            _watcher.Deleted += _watcher_Changed;
            _watcher.Renamed += _watcher_Changed;
        }

        private void _watcher_Changed(object sender, FileSystemEventArgs e)
        {

            string log = "";

            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Created:
             //       MessageBox.Show($"Stworzono w folderze: {textBox_Path.Text}");
                    log = $"File Created: {e.Name}";
                    break;
                case WatcherChangeTypes.Deleted:
                    //MessageBox.Show($"Skasowano w folderze: {textBox_Path.Text}");
                    log = $"File Deleted: {e.Name}";
                    break;
                case WatcherChangeTypes.Changed:
                    //   MessageBox.Show($"Zmiana w folderze: {textBox_Path.Text}");
                    log = $"File Changed: {e.Name}";
                    break;
                case WatcherChangeTypes.Renamed:
                    //   MessageBox.Show($"Zmieniono nazwę w folderze: {textBox_Path.Text}");
                    log = $"File Renamed: {e.Name}";
                    break;
                case WatcherChangeTypes.All:
                    break;
                default:
                    break;
            }

            if (InvokeRequired)     // dodanie wyjatku do watku monitorowania folderu
            {
                BeginInvoke((Action)(() =>
                {
                    listBox_Logs.Items.Insert(0, log);

                }));
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show($"Wpisane imie to: {textBox_Name.Text}");
           
        }

        private void button_choose_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK) // jezeli wybierzemy folder -> warunek jest spelniony
            {
                textBox_Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _watcher.Path = textBox_Path.Text;
            
            if (_watcher.EnableRaisingEvents)
            {
        
                button_togglemonitor.Text = "Stop";
                button_togglemonitor.BackColor = Color.Red;

            }
            else 
            {
             
                button_togglemonitor.Text = "Start";
                button_togglemonitor.BackColor = Color.Green;
         
            }

            _watcher.EnableRaisingEvents = !_watcher.EnableRaisingEvents; //negacja stanu po kliknieciu przycisku
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();  //zapisanie zmian do zamykaniu okna
        }
    }
}