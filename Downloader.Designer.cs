namespace GoGoDownloader
{
    partial class downloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(downloader));
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstURLs = new System.Windows.Forms.ListBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblFileURL = new System.Windows.Forms.Label();
            this.lblWaitlist = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.flbDownload = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.prbDownload = new System.Windows.Forms.ProgressBar();
            this.txtURL = new System.Windows.Forms.RichTextBox();
            this.lblTextDownloaded = new System.Windows.Forms.Label();
            this.lblTextPercentage = new System.Windows.Forms.Label();
            this.lblTextSpeed = new System.Windows.Forms.Label();
            this.lblDownloaded = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(303, 61);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "нэмэх";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstURLs
            // 
            this.lstURLs.FormattingEnabled = true;
            this.lstURLs.HorizontalScrollbar = true;
            this.lstURLs.Location = new System.Drawing.Point(12, 188);
            this.lstURLs.Name = "lstURLs";
            this.lstURLs.Size = new System.Drawing.Size(368, 147);
            this.lstURLs.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(11, 23);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(289, 21);
            this.txtOutput.TabIndex = 4;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(303, 19);
            this.btnChange.Margin = new System.Windows.Forms.Padding(0);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(77, 26);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "солих";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblFileURL
            // 
            this.lblFileURL.AutoSize = true;
            this.lblFileURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileURL.ForeColor = System.Drawing.Color.White;
            this.lblFileURL.Location = new System.Drawing.Point(10, 44);
            this.lblFileURL.Name = "lblFileURL";
            this.lblFileURL.Size = new System.Drawing.Size(251, 13);
            this.lblFileURL.TabIndex = 6;
            this.lblFileURL.Tag = "";
            this.lblFileURL.Text = "Татах URL - ууд (мөр мөрөөр оруулна уу)";
            // 
            // lblWaitlist
            // 
            this.lblWaitlist.AutoSize = true;
            this.lblWaitlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitlist.ForeColor = System.Drawing.Color.White;
            this.lblWaitlist.Location = new System.Drawing.Point(10, 105);
            this.lblWaitlist.Name = "lblWaitlist";
            this.lblWaitlist.Size = new System.Drawing.Size(83, 13);
            this.lblWaitlist.TabIndex = 7;
            this.lblWaitlist.Tag = "";
            this.lblWaitlist.Text = "Татаж байна";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(10, 8);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(80, 13);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "Хааш хуулах";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 342);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 26);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "устгах";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(309, 342);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 26);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "тухай";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 11;
            this.label1.Tag = "";
            this.label1.Text = "Хүлээж буй таталтууд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(2, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Татах URL-ийг нэмсний дараа таталт өөрөө эхлэх болно. Таталт эхэлтэл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "30сек хүртэл хугацаа үргэлжилж магадгүй";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "share.gogo дээр файл оршин байхгүй тохиолдолд шууд алгасан";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(3, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "дараагийн таталтыг хийнэ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 74);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сануулга";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(182, 342);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(124, 26);
            this.btnOpen.TabIndex = 17;
            this.btnOpen.Text = "файлуудаа харах";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // prbDownload
            // 
            this.prbDownload.Location = new System.Drawing.Point(10, 121);
            this.prbDownload.Name = "prbDownload";
            this.prbDownload.Size = new System.Drawing.Size(370, 23);
            this.prbDownload.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(11, 61);
            this.txtURL.Name = "txtURL";
            this.txtURL.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtURL.Size = new System.Drawing.Size(289, 41);
            this.txtURL.TabIndex = 18;
            this.txtURL.Text = "";
            this.txtURL.WordWrap = false;
            // 
            // lblTextDownloaded
            // 
            this.lblTextDownloaded.AutoSize = true;
            this.lblTextDownloaded.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextDownloaded.ForeColor = System.Drawing.Color.White;
            this.lblTextDownloaded.Location = new System.Drawing.Point(10, 147);
            this.lblTextDownloaded.Name = "lblTextDownloaded";
            this.lblTextDownloaded.Size = new System.Drawing.Size(51, 13);
            this.lblTextDownloaded.TabIndex = 19;
            this.lblTextDownloaded.Tag = "";
            this.lblTextDownloaded.Text = "Татсан:";
            // 
            // lblTextPercentage
            // 
            this.lblTextPercentage.AutoSize = true;
            this.lblTextPercentage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextPercentage.ForeColor = System.Drawing.Color.White;
            this.lblTextPercentage.Location = new System.Drawing.Point(301, 147);
            this.lblTextPercentage.Name = "lblTextPercentage";
            this.lblTextPercentage.Size = new System.Drawing.Size(41, 13);
            this.lblTextPercentage.TabIndex = 20;
            this.lblTextPercentage.Tag = "";
            this.lblTextPercentage.Text = "Хувь:";
            // 
            // lblTextSpeed
            // 
            this.lblTextSpeed.AutoSize = true;
            this.lblTextSpeed.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextSpeed.ForeColor = System.Drawing.Color.White;
            this.lblTextSpeed.Location = new System.Drawing.Point(179, 147);
            this.lblTextSpeed.Name = "lblTextSpeed";
            this.lblTextSpeed.Size = new System.Drawing.Size(42, 13);
            this.lblTextSpeed.TabIndex = 21;
            this.lblTextSpeed.Tag = "";
            this.lblTextSpeed.Text = "Хурд:";
            // 
            // lblDownloaded
            // 
            this.lblDownloaded.AutoSize = true;
            this.lblDownloaded.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloaded.ForeColor = System.Drawing.Color.White;
            this.lblDownloaded.Location = new System.Drawing.Point(60, 147);
            this.lblDownloaded.Name = "lblDownloaded";
            this.lblDownloaded.Size = new System.Drawing.Size(0, 13);
            this.lblDownloaded.TabIndex = 22;
            this.lblDownloaded.Tag = "";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(221, 147);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(0, 13);
            this.lblSpeed.TabIndex = 23;
            this.lblSpeed.Tag = "";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.White;
            this.lblPercentage.Location = new System.Drawing.Point(348, 147);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(0, 13);
            this.lblPercentage.TabIndex = 25;
            this.lblPercentage.Tag = "";
            // 
            // downloader
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(393, 464);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblDownloaded);
            this.Controls.Add(this.lblTextSpeed);
            this.Controls.Add(this.lblTextPercentage);
            this.Controls.Add(this.lblTextDownloaded);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblWaitlist);
            this.Controls.Add(this.lblFileURL);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lstURLs);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.prbDownload);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(409, 502);
            this.MinimumSize = new System.Drawing.Size(409, 502);
            this.Name = "downloader";
            this.Text = "GOGO татагч";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.downloader_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstURLs;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblFileURL;
        private System.Windows.Forms.Label lblWaitlist;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.FolderBrowserDialog flbDownload;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ProgressBar prbDownload;
        private System.Windows.Forms.RichTextBox txtURL;
        private System.Windows.Forms.Label lblTextDownloaded;
        private System.Windows.Forms.Label lblTextPercentage;
        private System.Windows.Forms.Label lblTextSpeed;
        private System.Windows.Forms.Label lblDownloaded;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblPercentage;
    }
}

