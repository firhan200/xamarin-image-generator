namespace AndroidDrawableGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hdpiCheckBox = new System.Windows.Forms.CheckBox();
            this.xhdpiCheckBox = new System.Windows.Forms.CheckBox();
            this.xxhdpiCheckBox = new System.Windows.Forms.CheckBox();
            this.xxxhdpiCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageWidthLabel = new System.Windows.Forms.Label();
            this.imageHeightLabel = new System.Windows.Forms.Label();
            this.generateImageButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.outputDirectoryLabel = new System.Windows.Forms.Label();
            this.filenameTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resizeOriginalImageCheckbox = new System.Windows.Forms.CheckBox();
            this.resizeWidthTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hdpiResultScaleLabel = new System.Windows.Forms.Label();
            this.xhdpiResultScaleLabel = new System.Windows.Forms.Label();
            this.xxhdpiResultScaleLabel = new System.Windows.Forms.Label();
            this.xxxhdpiResultScaleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputTextbox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.iOS2xcheckBox = new System.Windows.Forms.CheckBox();
            this.iOS3xcheckBox = new System.Windows.Forms.CheckBox();
            this.iOS2xScaleLabel = new System.Windows.Forms.Label();
            this.iOS3xScaleLabel = new System.Windows.Forms.Label();
            this.openOutputFolderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 93);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Image:";
            // 
            // hdpiCheckBox
            // 
            this.hdpiCheckBox.AutoSize = true;
            this.hdpiCheckBox.Location = new System.Drawing.Point(18, 24);
            this.hdpiCheckBox.Name = "hdpiCheckBox";
            this.hdpiCheckBox.Size = new System.Drawing.Size(46, 17);
            this.hdpiCheckBox.TabIndex = 3;
            this.hdpiCheckBox.Text = "hdpi";
            this.hdpiCheckBox.UseVisualStyleBackColor = true;
            // 
            // xhdpiCheckBox
            // 
            this.xhdpiCheckBox.AutoSize = true;
            this.xhdpiCheckBox.Location = new System.Drawing.Point(18, 69);
            this.xhdpiCheckBox.Name = "xhdpiCheckBox";
            this.xhdpiCheckBox.Size = new System.Drawing.Size(51, 17);
            this.xhdpiCheckBox.TabIndex = 4;
            this.xhdpiCheckBox.Text = "xhdpi";
            this.xhdpiCheckBox.UseVisualStyleBackColor = true;
            // 
            // xxhdpiCheckBox
            // 
            this.xxhdpiCheckBox.AutoSize = true;
            this.xxhdpiCheckBox.Location = new System.Drawing.Point(97, 24);
            this.xxhdpiCheckBox.Name = "xxhdpiCheckBox";
            this.xxhdpiCheckBox.Size = new System.Drawing.Size(56, 17);
            this.xxhdpiCheckBox.TabIndex = 5;
            this.xxhdpiCheckBox.Text = "xxhdpi";
            this.xxhdpiCheckBox.UseVisualStyleBackColor = true;
            // 
            // xxxhdpiCheckBox
            // 
            this.xxxhdpiCheckBox.AutoSize = true;
            this.xxxhdpiCheckBox.Location = new System.Drawing.Point(97, 69);
            this.xxxhdpiCheckBox.Name = "xxxhdpiCheckBox";
            this.xxxhdpiCheckBox.Size = new System.Drawing.Size(61, 17);
            this.xxxhdpiCheckBox.TabIndex = 6;
            this.xxxhdpiCheckBox.Text = "xxxhdpi";
            this.xxxhdpiCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height:";
            // 
            // imageWidthLabel
            // 
            this.imageWidthLabel.AutoSize = true;
            this.imageWidthLabel.Location = new System.Drawing.Point(18, 40);
            this.imageWidthLabel.Name = "imageWidthLabel";
            this.imageWidthLabel.Size = new System.Drawing.Size(13, 13);
            this.imageWidthLabel.TabIndex = 9;
            this.imageWidthLabel.Text = "0";
            // 
            // imageHeightLabel
            // 
            this.imageHeightLabel.AutoSize = true;
            this.imageHeightLabel.Location = new System.Drawing.Point(62, 40);
            this.imageHeightLabel.Name = "imageHeightLabel";
            this.imageHeightLabel.Size = new System.Drawing.Size(13, 13);
            this.imageHeightLabel.TabIndex = 10;
            this.imageHeightLabel.Text = "0";
            // 
            // generateImageButton
            // 
            this.generateImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.generateImageButton.Location = new System.Drawing.Point(12, 250);
            this.generateImageButton.Name = "generateImageButton";
            this.generateImageButton.Size = new System.Drawing.Size(269, 36);
            this.generateImageButton.TabIndex = 12;
            this.generateImageButton.Text = "Generate";
            this.generateImageButton.UseVisualStyleBackColor = true;
            this.generateImageButton.Click += new System.EventHandler(this.generateImageButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Output Directory:";
            // 
            // outputDirectoryLabel
            // 
            this.outputDirectoryLabel.AutoSize = true;
            this.outputDirectoryLabel.Location = new System.Drawing.Point(367, 185);
            this.outputDirectoryLabel.Name = "outputDirectoryLabel";
            this.outputDirectoryLabel.Size = new System.Drawing.Size(59, 13);
            this.outputDirectoryLabel.TabIndex = 14;
            this.outputDirectoryLabel.Text = "MyPictures";
            // 
            // filenameTextbox
            // 
            this.filenameTextbox.Location = new System.Drawing.Point(12, 215);
            this.filenameTextbox.Name = "filenameTextbox";
            this.filenameTextbox.Size = new System.Drawing.Size(269, 20);
            this.filenameTextbox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Filename:";
            // 
            // resizeOriginalImageCheckbox
            // 
            this.resizeOriginalImageCheckbox.AutoSize = true;
            this.resizeOriginalImageCheckbox.Location = new System.Drawing.Point(12, 168);
            this.resizeOriginalImageCheckbox.Name = "resizeOriginalImageCheckbox";
            this.resizeOriginalImageCheckbox.Size = new System.Drawing.Size(131, 17);
            this.resizeOriginalImageCheckbox.TabIndex = 17;
            this.resizeOriginalImageCheckbox.Text = "Resize Original Image:";
            this.resizeOriginalImageCheckbox.UseVisualStyleBackColor = true;
            // 
            // resizeWidthTextbox
            // 
            this.resizeWidthTextbox.Location = new System.Drawing.Point(147, 168);
            this.resizeWidthTextbox.Name = "resizeWidthTextbox";
            this.resizeWidthTextbox.Size = new System.Drawing.Size(100, 20);
            this.resizeWidthTextbox.TabIndex = 18;
            this.resizeWidthTextbox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "(based on width)";
            // 
            // hdpiResultScaleLabel
            // 
            this.hdpiResultScaleLabel.AutoSize = true;
            this.hdpiResultScaleLabel.Location = new System.Drawing.Point(34, 44);
            this.hdpiResultScaleLabel.Name = "hdpiResultScaleLabel";
            this.hdpiResultScaleLabel.Size = new System.Drawing.Size(30, 13);
            this.hdpiResultScaleLabel.TabIndex = 20;
            this.hdpiResultScaleLabel.Text = "(0x0)";
            // 
            // xhdpiResultScaleLabel
            // 
            this.xhdpiResultScaleLabel.AutoSize = true;
            this.xhdpiResultScaleLabel.Location = new System.Drawing.Point(34, 87);
            this.xhdpiResultScaleLabel.Name = "xhdpiResultScaleLabel";
            this.xhdpiResultScaleLabel.Size = new System.Drawing.Size(30, 13);
            this.xhdpiResultScaleLabel.TabIndex = 21;
            this.xhdpiResultScaleLabel.Text = "(0x0)";
            // 
            // xxhdpiResultScaleLabel
            // 
            this.xxhdpiResultScaleLabel.AutoSize = true;
            this.xxhdpiResultScaleLabel.Location = new System.Drawing.Point(111, 44);
            this.xxhdpiResultScaleLabel.Name = "xxhdpiResultScaleLabel";
            this.xxhdpiResultScaleLabel.Size = new System.Drawing.Size(30, 13);
            this.xxhdpiResultScaleLabel.TabIndex = 22;
            this.xxhdpiResultScaleLabel.Text = "(0x0)";
            // 
            // xxxhdpiResultScaleLabel
            // 
            this.xxxhdpiResultScaleLabel.AutoSize = true;
            this.xxxhdpiResultScaleLabel.Location = new System.Drawing.Point(111, 87);
            this.xxxhdpiResultScaleLabel.Name = "xxxhdpiResultScaleLabel";
            this.xxxhdpiResultScaleLabel.Size = new System.Drawing.Size(30, 13);
            this.xxxhdpiResultScaleLabel.TabIndex = 23;
            this.xxxhdpiResultScaleLabel.Text = "(0x0)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.imageWidthLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.imageHeightLabel);
            this.groupBox1.Location = new System.Drawing.Point(122, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 74);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hdpiCheckBox);
            this.groupBox2.Controls.Add(this.xxxhdpiResultScaleLabel);
            this.groupBox2.Controls.Add(this.xhdpiCheckBox);
            this.groupBox2.Controls.Add(this.xxhdpiResultScaleLabel);
            this.groupBox2.Controls.Add(this.xxhdpiCheckBox);
            this.groupBox2.Controls.Add(this.xhdpiResultScaleLabel);
            this.groupBox2.Controls.Add(this.xxxhdpiCheckBox);
            this.groupBox2.Controls.Add(this.hdpiResultScaleLabel);
            this.groupBox2.Location = new System.Drawing.Point(256, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 121);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Android:";
            // 
            // outputTextbox
            // 
            this.outputTextbox.Location = new System.Drawing.Point(12, 315);
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            this.outputTextbox.Size = new System.Drawing.Size(547, 126);
            this.outputTextbox.TabIndex = 26;
            this.outputTextbox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Output:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.iOS3xScaleLabel);
            this.groupBox3.Controls.Add(this.iOS2xScaleLabel);
            this.groupBox3.Controls.Add(this.iOS3xcheckBox);
            this.groupBox3.Controls.Add(this.iOS2xcheckBox);
            this.groupBox3.Location = new System.Drawing.Point(453, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 121);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "iOS";
            // 
            // iOS2xcheckBox
            // 
            this.iOS2xcheckBox.AutoSize = true;
            this.iOS2xcheckBox.Location = new System.Drawing.Point(16, 24);
            this.iOS2xcheckBox.Name = "iOS2xcheckBox";
            this.iOS2xcheckBox.Size = new System.Drawing.Size(37, 17);
            this.iOS2xcheckBox.TabIndex = 0;
            this.iOS2xcheckBox.Text = "2x";
            this.iOS2xcheckBox.UseVisualStyleBackColor = true;
            // 
            // iOS3xcheckBox
            // 
            this.iOS3xcheckBox.AutoSize = true;
            this.iOS3xcheckBox.Location = new System.Drawing.Point(16, 69);
            this.iOS3xcheckBox.Name = "iOS3xcheckBox";
            this.iOS3xcheckBox.Size = new System.Drawing.Size(37, 17);
            this.iOS3xcheckBox.TabIndex = 1;
            this.iOS3xcheckBox.Text = "3x";
            this.iOS3xcheckBox.UseVisualStyleBackColor = true;
            // 
            // iOS2xScaleLabel
            // 
            this.iOS2xScaleLabel.AutoSize = true;
            this.iOS2xScaleLabel.Location = new System.Drawing.Point(33, 44);
            this.iOS2xScaleLabel.Name = "iOS2xScaleLabel";
            this.iOS2xScaleLabel.Size = new System.Drawing.Size(30, 13);
            this.iOS2xScaleLabel.TabIndex = 2;
            this.iOS2xScaleLabel.Text = "(0x0)";
            // 
            // iOS3xScaleLabel
            // 
            this.iOS3xScaleLabel.AutoSize = true;
            this.iOS3xScaleLabel.Location = new System.Drawing.Point(33, 89);
            this.iOS3xScaleLabel.Name = "iOS3xScaleLabel";
            this.iOS3xScaleLabel.Size = new System.Drawing.Size(30, 13);
            this.iOS3xScaleLabel.TabIndex = 3;
            this.iOS3xScaleLabel.Text = "(0x0)";
            // 
            // openOutputFolderButton
            // 
            this.openOutputFolderButton.Location = new System.Drawing.Point(370, 201);
            this.openOutputFolderButton.Name = "openOutputFolderButton";
            this.openOutputFolderButton.Size = new System.Drawing.Size(127, 23);
            this.openOutputFolderButton.TabIndex = 29;
            this.openOutputFolderButton.Text = "Open Output Folder";
            this.openOutputFolderButton.UseVisualStyleBackColor = true;
            this.openOutputFolderButton.Click += new System.EventHandler(this.openOutputFolderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 453);
            this.Controls.Add(this.openOutputFolderButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resizeWidthTextbox);
            this.Controls.Add(this.resizeOriginalImageCheckbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filenameTextbox);
            this.Controls.Add(this.outputDirectoryLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.generateImageButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Xamarin Image Generator v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox hdpiCheckBox;
        private System.Windows.Forms.CheckBox xhdpiCheckBox;
        private System.Windows.Forms.CheckBox xxhdpiCheckBox;
        private System.Windows.Forms.CheckBox xxxhdpiCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label imageWidthLabel;
        private System.Windows.Forms.Label imageHeightLabel;
        private System.Windows.Forms.Button generateImageButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label outputDirectoryLabel;
        private System.Windows.Forms.TextBox filenameTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox resizeOriginalImageCheckbox;
        private System.Windows.Forms.TextBox resizeWidthTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label hdpiResultScaleLabel;
        private System.Windows.Forms.Label xhdpiResultScaleLabel;
        private System.Windows.Forms.Label xxhdpiResultScaleLabel;
        private System.Windows.Forms.Label xxxhdpiResultScaleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox outputTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox iOS3xcheckBox;
        private System.Windows.Forms.CheckBox iOS2xcheckBox;
        private System.Windows.Forms.Label iOS2xScaleLabel;
        private System.Windows.Forms.Label iOS3xScaleLabel;
        private System.Windows.Forms.Button openOutputFolderButton;
    }
}

