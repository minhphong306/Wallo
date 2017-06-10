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

namespace Pollo {
    public partial class Form1 : Form {
        private int MODE;
        private const int TODO = 1, DOING = 2, DONE = 3, BLOCK = 4;
        string FILE_HEADER = "D:\\WALLO\\";
        string FILE_TRAILER = ".dat";

        public Form1() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void readFile(string filePath, int mode) {
            //"D:\\WALLO\\ToDo.dat"
            if (!File.Exists(filePath)) {
                File.Create(filePath).Dispose();
            }
            using (System.IO.StreamReader r = new System.IO.StreamReader(filePath)) {
                string line;
                while ((line = r.ReadLine()) != null) {
                    switch (mode) {
                        case TODO:
                            lbxToDo.Items.Add(line);
                            break;
                        case DOING:
                            lbxDoing.Items.Add(line);
                            break;
                        case DONE:
                            lbxDone.Items.Add(line);
                            break;
                        case BLOCK:
                            lbxBlock.Items.Add(line);
                            break;
                    }

                }
            }
        }

        private void writeFile(string filePath, int mode) {
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(filePath);
            switch (mode) {
                case TODO:
                    foreach (var item in lbxToDo.Items) {
                        SaveFile.WriteLine(item.ToString());
                    }
                    break;
                case DOING:
                    foreach (var item in lbxDoing.Items) {
                        SaveFile.WriteLine(item.ToString());
                    }
                    break;
                case DONE:
                    foreach (var item in lbxDone.Items) {
                        SaveFile.WriteLine(item.ToString());
                    }
                    break;
                case BLOCK:
                    foreach (var item in lbxBlock.Items) {
                        SaveFile.WriteLine(item.ToString());
                    }
                    break;
            }

            SaveFile.Close();
        }

        private void panel1_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var file in files) {
                MessageBox.Show(file);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.All;
        }

        private void txtAddToDo_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter) {
                String item = txtAddToDo.Text;
                if ("".Equals(item)) {
                    return;
                }
                lbxToDo.Items.Add(item);
                txtAddToDo.Text = "";
            }
        }

        private void txtAddToDo_Leave(object sender, EventArgs e) {
            string text = txtAddToDo.Text;
            if ("".Equals(text)) {
                txtAddToDo.Text = "Thêm việc đang làm";
            }

        }

        private void txtAddToDo_Enter(object sender, EventArgs e) {
            txtAddToDo.Text = "";
        }

        private void contextRemove_Click(object sender, EventArgs e) {
            int index = lbxToDo.SelectedIndex;
            if (index == -1) {
                return;
            }
            lbxToDo.Items.RemoveAt(index);
        }

        private void txtAddDoing_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                String item = txtAddDoing.Text;
                if ("".Equals(item)) {
                    return;
                }
                lbxDoing.Items.Add(item);
                txtAddDoing.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e) {
            notifyIcon1.ShowBalloonTip(1000, "Thông báo", "Chương trình Wallo đã được khởi động", ToolTipIcon.Info);

            readFile(FILE_HEADER + "ToDo" + FILE_TRAILER, TODO);
            readFile(FILE_HEADER + "Doing" + FILE_TRAILER, DOING);
            readFile(FILE_HEADER + "Done" + FILE_TRAILER, DONE);
            readFile(FILE_HEADER + "Block" + FILE_TRAILER, BLOCK);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            writeFile(FILE_HEADER + "ToDo" + FILE_TRAILER, TODO);
            writeFile(FILE_HEADER + "Doing" + FILE_TRAILER, DOING);
            writeFile(FILE_HEADER + "Done" + FILE_TRAILER, DONE);
            writeFile(FILE_HEADER + "Block" + FILE_TRAILER, BLOCK);
        }
    }
}
