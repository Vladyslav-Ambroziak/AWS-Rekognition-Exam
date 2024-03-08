using Amazon.Rekognition;
using Amazon.Rekognition.Model;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWSProject
{
    public partial class Form1 : Form
    {
        private BasicAWSCredentials credentials = new BasicAWSCredentials("AKIAVRUVSXSXAOEHM7MN", "D3ocx6IRXCnnFOHoKBD5Q9jp6yHld/s26gcpdD4N");
        private AmazonRekognitionClient rekognitionClient;
        private int index = 0;
        private int pointY = 0;
        public Form1()
        {
            InitializeComponent();
            rekognitionClient = new AmazonRekognitionClient(credentials, Amazon.RegionEndpoint.USEast1);
        }

        private void analyzeURL_button_Click(object sender, EventArgs e)
        {
            while (index != 0)
                this.listEmotionPanel.Controls.RemoveByKey($"emotion_{index--}");
            this.pictureBox.ImageLocation = this.URLImg_textBox.Text;
            pointY = 0;
            byte[] image = new WebClient().DownloadData(this.URLImg_textBox.Text);
            AnalyzeFace(image);
        }

        private void analyzeLocal_button_Click(object sender, EventArgs e)
        {
            while (index != 0)
                this.listEmotionPanel.Controls.RemoveByKey($"emotion_{index--}");
            this.pictureBox.ImageLocation = this.localImg_label.Text;
            byte[] image;
            pointY = 0;
            using (FileStream fs = new FileStream(this.localImg_label.Text, FileMode.Open, FileAccess.Read))
            {
                image = new byte[fs.Length];
                fs.Read(image, 0, (int)fs.Length);
            }
            AnalyzeFace(image);
        }

        private void selectFile_button_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PNG file (*.png)|*.png|JPG file (*.jpg)|*.jpg|JPEG file (*.jpeg)|*.jpeg";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                { 
                    this.localImg_label.Text = openFileDialog.FileName;
                }
            }
        }

        private void AnalyzeFace(byte[] image)
        {
            DetectFacesRequest detectFacesRequest = new DetectFacesRequest()
            {
                Image = new Amazon.Rekognition.Model.Image() { Bytes = new MemoryStream(image) },
                Attributes = new List<string> { "ALL" }
            };
            DetectFacesResponse detectFacesResponse = rekognitionClient.DetectFaces(detectFacesRequest);
            foreach (FaceDetail face in detectFacesResponse.FaceDetails)
            {
                foreach (Emotion emotion in face.Emotions)
                {
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                    label.Text = $"{emotion.Type} - {emotion.Confidence}%";
                    label.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    label.ForeColor = Color.FromArgb(255, 255, 255);
                    label.Width = 300;
                    label.Name = $"emotion_{++index}";
                    label.Location = new System.Drawing.Point(label.Location.X + 15, label.Location.Y + pointY);
                    pointY += 50;
                    this.listEmotionPanel.Controls.Add(label);
                }
            }
        }
    }
}
