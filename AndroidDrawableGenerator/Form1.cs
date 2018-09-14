using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidDrawableGenerator
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string myPicturesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        Bitmap imageBitmap;

        private string androidDir = "/android";
        private string iOSDir = "/iOS";

        private string parentDir = "/AndroidDrawableGenerator";
        private string hdpiDir = "/hdpi";
        private string xhdpiDir = "/xhdpi";
        private string xxhdpiDir = "/xxhdpi";
        private string xxxhdpiDir = "/xxxhdpi";

        private string iOS2xDir = "/2x";
        private string iOS3xDir = "/3x";

        //PATH
        string androidDirPath;
        string iOSDirPath;

        string hdpiFullPath;
        string xhdpiFullPath;
        string xxhdpiFullPath;
        string xxxhdpiFullPath;

        string iOS2xFullPath;
        string iOS3xFullPath;

        private double hdpiScale = 1.5;
        private double xhdpiScale = 2;
        private double xxhdpiScale = 3;
        private double xxxhdpiScale = 4;

        private double iOS2xScale = 2;
        private double iOS3xScale = 3;

        public Form1()
        {
            InitializeComponent();

            resizeWidthTextbox.TextChanged += ResizeWidthTextbox_TextChanged;
        }

        private void ResizeWidthTextbox_TextChanged(object sender, EventArgs e)
        {
            if (resizeOriginalImageCheckbox.Checked)
            {
                int newWidth = 0;
                int newHeight = 0;
                imageWidthLabel.Text = resizeWidthTextbox.Text.Equals("") ? "0" : resizeWidthTextbox.Text;
                Int32.TryParse(imageWidthLabel.Text, out newWidth);
                newHeight = ((newWidth * imageBitmap.Height) / imageBitmap.Width);
                imageHeightLabel.Text = newHeight.ToString();

                GetResultScale(newWidth, newHeight);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaultChecklist();
            SetDirectoryPath();
            SetOutputDirectory(myPicturesPath);
        }

        private void SetDirectoryPath()
        {
            androidDirPath = myPicturesPath + parentDir + androidDir;
            iOSDirPath = myPicturesPath + parentDir + iOSDir;

            hdpiFullPath = androidDirPath + hdpiDir;
            xhdpiFullPath = androidDirPath + xhdpiDir;
            xxhdpiFullPath = androidDirPath + xxhdpiDir;
            xxxhdpiFullPath = androidDirPath + xxxhdpiDir;

            iOS2xFullPath = iOSDirPath + iOS2xDir;
            iOS3xFullPath = iOSDirPath + iOS3xDir;
        }

        private void SetDefaultChecklist()
        {
            hdpiCheckBox.Checked = true;
            xhdpiCheckBox.Checked = true;
            xxhdpiCheckBox.Checked = true;
            xxxhdpiCheckBox.Checked = true;

            //ios
            iOS2xcheckBox.Checked = true;
            iOS3xcheckBox.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //init open file dialog
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            int size = -1;
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(file);
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                imageBitmap = new Bitmap(openFileDialog.FileName);

                //set preview
                SetImageToPreview(imageBitmap);

                //set filename
                SetFileName(openFileDialog.FileName);

                //get image detail
                GetImageHeightAndWidth(new Bitmap(openFileDialog.FileName));
            }
        }

        private void SetImageToPreview(Bitmap originalBitmap)
        {
            //get width
            int resizeWidth = pictureBox1.Width;

            //calculate height
            int resizeHeight = (resizeWidth * originalBitmap.Height) / originalBitmap.Width;

            AddOutputLog("Resizing Image to:" + resizeWidth + " x " + resizeHeight);

            Bitmap resizedBitmap = new Bitmap(originalBitmap, new Size(resizeWidth, resizeHeight));

            pictureBox1.Image = resizedBitmap;
        }

        private void SetFileName(string path)
        {
            string filename = Path.GetFileName(path);
            filenameTextbox.Text = filename;
        }

        private void CreateDirectory()
        {
            string parentDirPath = myPicturesPath + parentDir;

            AddOutputLog("Checking directory:"+ parentDirPath);

            bool exists = System.IO.Directory.Exists(parentDirPath);
            if (!exists)
            {
                //create directory
                System.IO.Directory.CreateDirectory(parentDirPath);
                AddOutputLog(parentDirPath + " Created");
            }

            //check android dir
            bool androidExists = System.IO.Directory.Exists(androidDirPath);
            if (!exists)
            {
                //create directory
                System.IO.Directory.CreateDirectory(androidDirPath);
                AddOutputLog(androidDirPath + " Created");
            }

            //check iOS dir
            bool iOSExists = System.IO.Directory.Exists(iOSDirPath);
            if (!exists)
            {
                //create directory
                System.IO.Directory.CreateDirectory(iOSDirPath);
                AddOutputLog(iOSDirPath + " Created");
            }

            //check if child directory exist
            bool hdpiExists = System.IO.Directory.Exists(hdpiFullPath);
            AddOutputLog("Checking directory:" + hdpiFullPath);
            if (!hdpiExists)
            {
                //create directory
                System.IO.Directory.CreateDirectory(hdpiFullPath);
                AddOutputLog(hdpiFullPath + " Created");
            }

            bool xhdpiExists = System.IO.Directory.Exists(xhdpiFullPath);
            AddOutputLog("Checking directory:" + xhdpiFullPath);
            if (!xhdpiExists)
            {
                //create directory
                System.IO.Directory.CreateDirectory(xhdpiFullPath);
                AddOutputLog(xhdpiFullPath + " Created");
            }

            bool xxhdpiExists = System.IO.Directory.Exists(parentDirPath + xxhdpiFullPath);
            AddOutputLog("Checking directory:" + xxhdpiFullPath);
            if (!xxhdpiExists)
            {
                //create directory
                System.IO.Directory.CreateDirectory(xxhdpiFullPath);
                AddOutputLog(xxhdpiFullPath + " Created");
            }

            bool xxxhdpiExists = System.IO.Directory.Exists(parentDirPath + xxxhdpiFullPath);
            AddOutputLog("Checking directory:" + xxxhdpiFullPath);
            if (!xxxhdpiExists)
            {
                //create directory
                System.IO.Directory.CreateDirectory(xxxhdpiFullPath);
                AddOutputLog(xxxhdpiFullPath + " Created");
            }

            bool iOS2xExists = System.IO.Directory.Exists(iOS2xFullPath);
            AddOutputLog("Checking directory:" + iOS2xFullPath);
            if (!xxxhdpiExists)
            {
                //create directory
                System.IO.Directory.CreateDirectory(iOS2xFullPath);
                AddOutputLog(iOS2xFullPath + " Created");
            }

            bool iOS3xExists = System.IO.Directory.Exists(iOS3xFullPath);
            AddOutputLog("Checking directory:" + iOS3xFullPath);
            if (!xxxhdpiExists)
            {
                //create directory
                System.IO.Directory.CreateDirectory(iOS3xFullPath);
                AddOutputLog(iOS3xFullPath + " Created");
            }
        }

        private void SetOutputDirectory(string path)
        {
            outputDirectoryLabel.Text = path;
        }

        private void GetResultScale(int originalWidth, int originalHeight)
        {
            int hdpiWidth = (int)Math.Ceiling(originalWidth * hdpiScale);
            int hdpiHeight = (int)Math.Ceiling(originalHeight * hdpiScale);

            int xhdpiWidth = (int)Math.Ceiling(originalWidth * xhdpiScale);
            int xhdpiHeight = (int)Math.Ceiling(originalHeight * xhdpiScale);

            int xxhdpiWidth = (int)Math.Ceiling(originalWidth * xxhdpiScale);
            int xxhdpiHeight = (int)Math.Ceiling(originalHeight * xxhdpiScale);

            int xxxhdpiWidth = (int)Math.Ceiling(originalWidth * xxxhdpiScale);
            int xxxhdpiHeight = (int)Math.Ceiling(originalHeight * xxxhdpiScale);

            hdpiResultScaleLabel.Text = "("+ hdpiWidth + " x " + hdpiHeight + ")";
            xhdpiResultScaleLabel.Text = "("+ xhdpiWidth + " x " + xhdpiHeight + ")";
            xxhdpiResultScaleLabel.Text = "("+ xxhdpiWidth + " x " + xxhdpiHeight + ")";
            xxxhdpiResultScaleLabel.Text = "("+ xxxhdpiWidth + " x " + xxxhdpiHeight + ")";

            //iOS
            int iOS2xWidth = (int)Math.Ceiling(originalWidth * iOS2xScale);
            int iOS2xHeight = (int)Math.Ceiling(originalHeight * iOS2xScale);

            int iOS3xWidth = (int)Math.Ceiling(originalWidth * iOS3xScale);
            int iOS3xHeight = (int)Math.Ceiling(originalHeight * iOS3xScale);

            iOS2xScaleLabel.Text = "(" + iOS2xWidth + " x " + iOS2xHeight + ")";
            iOS3xScaleLabel.Text = "(" + iOS3xWidth + " x " + iOS3xHeight + ")";
        }

        private void GetImageHeightAndWidth(Bitmap bitmap)
        {
            var imageHeight = bitmap.Height;
            var imageWidth = bitmap.Width;
            imageWidthLabel.Text = imageWidth.ToString();
            imageHeightLabel.Text = imageHeight.ToString();

            //get scale result
            GetResultScale(imageWidth, imageHeight);
        }

        private void SaveImage(double scale, string path)
        {
            string fileName = filenameTextbox.Text;
            
            //calculate new width & height
            int newWidth = (int)Math.Ceiling(imageBitmap.Width * scale);
            int newHeight = (int)Math.Ceiling(imageBitmap.Height * scale);

            System.Diagnostics.Debug.WriteLine(fileName+", width:"+newWidth+" & height:"+newHeight);

            Bitmap resizedBitmap = new Bitmap(imageBitmap, new Size(newWidth, newHeight));
            resizedBitmap.Save(path + "/" +fileName);
        }

        private void ResizeOriginalImage()
        { 
            //get width
            int resizeWidth = imageBitmap.Width;
            Int32.TryParse(resizeWidthTextbox.Text, out resizeWidth);

            //calculate height
            int resizeHeight = (resizeWidth * imageBitmap.Height) / imageBitmap.Width;

            AddOutputLog("Resizing Image to:"+ resizeWidth +" x " +resizeHeight);

            Bitmap resizedBitmap = new Bitmap(imageBitmap, new Size(resizeWidth, resizeHeight));
            imageBitmap = resizedBitmap;
        }

        private async Task<bool> GenerateDrawable()
        {
            bool isSuccess = false;

            try
            {
                CreateDirectory();

                //check if should resize
                if (resizeOriginalImageCheckbox.Checked)
                {
                    ResizeOriginalImage();
                }

                

                if (hdpiCheckBox.Checked)
                {
                    AddOutputLog("Saving hdpi Image");
                    SaveImage(hdpiScale, hdpiFullPath);
                }
                if (xhdpiCheckBox.Checked)
                {
                    AddOutputLog("Saving xhdpi Image");
                    SaveImage(xhdpiScale, xhdpiFullPath);
                }
                if (xxhdpiCheckBox.Checked)
                {
                    AddOutputLog("Saving xxhdpi Image");
                    SaveImage(xxhdpiScale, xxhdpiFullPath);
                }
                if (xxxhdpiCheckBox.Checked)
                {
                    AddOutputLog("Saving xxxhdpi Image");
                    SaveImage(xxxhdpiScale, xxxhdpiFullPath);
                }

                //iOS
                if (iOS2xcheckBox.Checked)
                {
                    AddOutputLog("Saving iOS 2x Image");
                    SaveImage(iOS2xScale, iOS2xFullPath);
                }
                if (iOS3xcheckBox.Checked)
                {
                    AddOutputLog("Saving iOS 3x Image");
                    SaveImage(iOS3xScale, iOS3xFullPath);
                }

                isSuccess = false;

                AddOutputLog("GENERATE SUCCESS");
                AddOutputLog("Finish!");
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            return isSuccess;
        }

        private async void generateImageButton_Click(object sender, EventArgs e)
        {
            if (imageBitmap == null)
            {
                MessageBox.Show("Image cannot be empty!");
            }
            else
            {
                if (filenameTextbox.Text.Equals(""))
                {
                    MessageBox.Show("Image name cannot be empty!");
                }
                else
                {
                    generateImageButton.Enabled = false;
                    generateImageButton.Text = "Please wait..";

                    await GenerateDrawable();

                    generateImageButton.Text = "Generate";
                    generateImageButton.Enabled = true;
                }
            }          
        }

        private void AddOutputLog(string message)
        {
            if (outputTextbox.Text.Equals(""))
            {
                outputTextbox.Text += message;
            }
            else
            {
                outputTextbox.Text += Environment.NewLine + message;
            }
            outputTextbox.SelectionStart = outputTextbox.Text.Length;
            outputTextbox.ScrollToCaret();
        }

        private void openOutputFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start(@""+myPicturesPath + parentDir);
        }
    }
}
