using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp12 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //Database connection variables
        MySqlConnection conn;
        string myConnectionString;

        //Image variables
        string pickedImage = "";
        string location = @"D:\\Images\\Test Image\\";
        string fileName = "";

        private void uploadBtn_Click(object sender, EventArgs e) {
            // This is a comment
            openFileDialog1.Title = "Insert an Image";
            openFileDialog1.InitialDirectory = location;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp|TIFF Images|*.tif|PNG Images|*.png|All Files|*.*";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel) {
                fileName = openFileDialog1.SafeFileName;
                pickedImage = openFileDialog1.FileName;
                if (File.Exists(pickedImage)) {
                    if (!File.Exists(location + fileName))
                        File.Copy(pickedImage, location + fileName);
                }
                pictureBox1.Image = Image.FromFile(pickedImage);
            }
        }
    }
}
