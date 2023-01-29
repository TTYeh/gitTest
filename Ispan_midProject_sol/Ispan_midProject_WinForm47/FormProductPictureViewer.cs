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

namespace Ispan_midProject_WinForm47
{
    public partial class FormProductPictureViewer : Form
    {
        private string[] ImageList;
        private string picPath;

        public FormProductPictureViewer(string prdPicPath)
        {
            InitializeComponent();
            Load += FormProductPictureViewer_Load;
            this.picPath = prdPicPath;
        }

        private void FormProductPictureViewer_Load(object sender, EventArgs e)
        {
            ImageList = LoadImages();
            CreatePictureBoxs();
        }

        private string[] LoadImages()
        {
            string myImageSource = $@"\source\image_hw";
            var imgsPath = PathExtension.ProjectDirConcat(myImageSource);
            // Utility.ConcatWithProjectPath(myImageSource);
            var fileEntries = ProcessDirectory(imgsPath);
            return fileEntries;
        }

        private object CreatePictureBox(int number)
        {
            int eachRowNum = 5;
            int x = number % eachRowNum;
            int y = number / eachRowNum;
            int PicRecWidth = 100;
            int eachPicDistance = PicRecWidth;


            PictureBox newPictureBox = new PictureBox
            {
                Name = $"myPictureBox{number}",
                Location = new Point(x * eachPicDistance, y * eachPicDistance),
                Size = new Size(PicRecWidth, PicRecWidth),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            newPictureBox.Image = Image.FromFile(ImageList[number]);

            return newPictureBox;
        }

        public void AddControl(object obj)
        {
            this.Controls.Add((Control)obj);
        }

        delegate object ButtonDelegate(int number);


        public void CreatePictureBoxs()
        {

            for (int i = 0; i < ImageList.Count(); i++)
            {
                ButtonDelegate del = CreatePictureBox;
                AddControl((Control)del(i));
            }
        }

        public static string[] ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            //foreach (string fileName in fileEntries)
            //    ProcessFile(fileName);

            //// Recurse into subdirectories of this directory.
            //string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            //foreach (string subdirectory in subdirectoryEntries)
            //    ProcessDirectory(subdirectory);
            return fileEntries;
        }
    }
    public static class PathExtension
    {
        public static string ProjectDirConcat(this string userAdd)
        {
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            return projectDirectory + userAdd;
        }
    }
}
