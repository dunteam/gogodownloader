using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;

namespace GoGoDownloader
{
    public partial class downloader : Form
    {
        Thread downloading;
        public delegate void removeItemDelegate(int index, string name);
        public delegate void changeProgressBarDelegate(int value);
        public delegate void changeVisibilityDelegate(int value);
        public delegate void changeDownloadedDelegate(string value);
        public delegate void changeSpeedDelegate(string value);
        public delegate void changePercentageDelegate(string value);
        String nameKey = "Файлын нэр";
        String urlKey = "download.aspx";
        String savePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)+"\\Downloads";


        public downloader()
        {
            InitializeComponent();

            downloading = new Thread(download);
            downloading.Start();

            changeVisibility(0);

            if (!Directory.Exists(savePath))
                Directory.CreateDirectory(savePath);

            txtOutput.Text = savePath;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtURL.Text.Trim().Equals(""))
            {
                String[] allLines = txtURL.Lines;

                for(int i = 0; i < allLines.Length; i++)
                {
                    lstURLs.Items.Add(allLines[i].Trim());
                }

                txtURL.Clear();
            }
        }

        private void download()
        {
            bool isDownloading = false;
            WebClient Client = new WebClient();
            DateTime beforeDownload;
            String line, fileName = "", fileURL = "";
            int begin, end;
            String output = "";

            while(true)
            {
                if (lstURLs.Items.Count > 0 && !isDownloading)
                {
                    try
                    {

                        Stream strm = Client.OpenRead(this.lstURLs.Items[0].ToString());
                        StreamReader sr = new StreamReader(strm);

                        do
                        {
                            line = sr.ReadLine();
                            output = output + line;

                            if (line != null)
                            {
                                if (line.Contains(nameKey))
                                {
                                    line = sr.ReadLine();
                                    begin = line.IndexOf("<b>") + 3;
                                    end = line.IndexOf("</b>");
                                    fileName = line.Substring(begin, end - begin);
                                }

                                if (line.Contains(urlKey))
                                {
                                    begin = line.IndexOf("window.location") + 18;
                                    end = line.IndexOf("style") - 4;
                                    fileURL = line.Substring(begin, end - begin);
                                }
                            }


                        } while (line != null);

                        if (fileURL.Equals(""))
                        {
                            MessageBox.Show("Уг файл оршин байхгүй байна. Дараагийн файлыг татах гэж байна");
                        }

                        changeVisibility(1);

                        beforeDownload = DateTime.Now;

                        Client.DownloadProgressChanged += (s, e) =>
                        {
                            changeProgressBar(e.ProgressPercentage);
                            changeDownloaded((e.BytesReceived / 1048576.0).ToString("#0.00") + "MB/" + (e.TotalBytesToReceive / 1048576.0).ToString("#0.00") + "MB");
                            changeSpeed((e.BytesReceived / ((DateTime.Now - beforeDownload).TotalSeconds * 1024)).ToString("#0.00") + "kb/s");
                            changePercentage(e.ProgressPercentage.ToString() + "%");
                        };
                        Client.DownloadFileCompleted += (s, e) =>
                        {
                            changeVisibility(0);
                            isDownloading = false;
                        };


                        Client.DownloadFileAsync(new Uri(fileURL), txtOutput.Text + "\\" + fileName);
                        isDownloading = true;
                        removeItem(0, fileName);

                        strm.Close();
                    }
                    catch (WebException ex)
                    {
                        MessageBox.Show("Файлыг татахад алдаа гарлаа. Дараагын файлыг татах гэж байна.\nТатах URL эсвэл интернет холболтоо шалгана уу\nХэрэв интернэт холболт ба татах url тань зүгээр бол дараах алдааг имэйлээр мэдэгдэнэ үү\nИнгэсэн тохиолдолд дараагийн хувилбарт засагдах болно\n" + ex.Message);
                        removeItem(0, fileName);
                    }

                }

                Thread.Sleep(3000);
            }
        }

        private void downloader_FormClosing(object sender, FormClosingEventArgs e)
        {
            downloading.Abort();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstURLs.Items.Remove(lstURLs.SelectedItem);
        }

        private void removeItem(int index, string name)
        {
            if (this.lstURLs.InvokeRequired)
            {
                this.Invoke(new removeItemDelegate(removeItem), index, name);
            }
            else
            {
                this.lstURLs.Items.Remove(this.lstURLs.Items[index]);
                this.lblWaitlist.Text = "Татаж байна : " + name;
            }
        }

        private void changeProgressBar(int value)
        {
            if (this.prbDownload.InvokeRequired)
            {
                this.Invoke(new changeProgressBarDelegate(changeProgressBar), value);
            }
            else
            {
                this.prbDownload.Value = value;
            }
        }

        private void changeVisibility(int value)
        {
            if (this.prbDownload.InvokeRequired)
            {
                this.Invoke(new changeVisibilityDelegate(changeVisibility), value);
            }
            else
            {
                if (value == 0)
                {
                    this.prbDownload.Visible = false;
                    this.lblWaitlist.Visible = false;
                    this.lblTextDownloaded.Visible = false;
                    this.lblTextSpeed.Visible = false;
                    this.lblTextPercentage.Visible = false;
                }
                else
                {
                    this.prbDownload.Visible = true;
                    this.lblWaitlist.Visible = true;
                    this.lblTextDownloaded.Visible = true;
                    this.lblTextSpeed.Visible = true;
                    this.lblTextPercentage.Visible = true;
                }
            }
        }

        private void changeDownloaded(string value)
        {
            if (this.lblDownloaded.InvokeRequired)
            {
                this.Invoke(new changeDownloadedDelegate(changeDownloaded), value);
            }
            else
            {
                this.lblDownloaded.Text = value;
            }
        }

        private void changeSpeed(string value)
        {
            if (this.lblSpeed.InvokeRequired)
            {
                this.Invoke(new changeSpeedDelegate(changeSpeed), value);
            }
            else
            {
                this.lblSpeed.Text = value;
            }
        }

        private void changePercentage(string value)
        {
            if (this.lblPercentage.InvokeRequired)
            {
                this.Invoke(new changePercentageDelegate(changePercentage), value);
            }
            else
            {
                this.lblPercentage.Text = value;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            if (flbDownload.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = flbDownload.SelectedPath;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtOutput.Text);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.xopom.com");
        }


    }
}
