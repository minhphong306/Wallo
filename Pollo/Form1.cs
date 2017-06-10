using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pollo {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Set up how the form should be displayed.
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Text = "Notify Icon Example";

            // Create the NotifyIcon.
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);

            // The Icon property sets the icon that will appear
            // in the systray for this application.
            notifyIcon1.Icon = new Icon("appicon.ico");

            // The ContextMenu property sets the menu that will

            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon.
            notifyIcon1.Text = "Form1 (NotifyIcon example)";
            notifyIcon1.Visible = true;

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
            if (index == -1)
            {
                return;
            }
            lbxToDo.Items.RemoveAt(index);
        }

        private void button1_Click(object sender, EventArgs e) {
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("D:\\WALLO\\ToDo.dat");
            foreach (var item in lbxToDo.Items) {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
            MessageBox.Show("Success");
            
        }
    }
}
