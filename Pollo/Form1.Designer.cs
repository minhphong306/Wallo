namespace Pollo {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbxToDo = new System.Windows.Forms.ListBox();
            this.contextOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextToDo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDoing = new System.Windows.Forms.ToolStripMenuItem();
            this.sẽLàmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đangLàmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đãLàmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bịLỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddToDo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAddDoing = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbxDoing = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAddDone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbxDone = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBlock = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbxBlock = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextOption.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxToDo
            // 
            this.lbxToDo.ContextMenuStrip = this.contextOption;
            this.lbxToDo.FormattingEnabled = true;
            this.lbxToDo.ItemHeight = 20;
            this.lbxToDo.Location = new System.Drawing.Point(6, 85);
            this.lbxToDo.Name = "lbxToDo";
            this.lbxToDo.Size = new System.Drawing.Size(240, 324);
            this.lbxToDo.TabIndex = 0;
            // 
            // contextOption
            // 
            this.contextOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextToDo,
            this.contextDoing,
            this.contextRemove});
            this.contextOption.Name = "contextMenuStrip1";
            this.contextOption.Size = new System.Drawing.Size(130, 70);
            // 
            // contextToDo
            // 
            this.contextToDo.Name = "contextToDo";
            this.contextToDo.Size = new System.Drawing.Size(129, 22);
            this.contextToDo.Text = "Thêm mới";
            // 
            // contextDoing
            // 
            this.contextDoing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sẽLàmToolStripMenuItem,
            this.đangLàmToolStripMenuItem,
            this.đãLàmToolStripMenuItem,
            this.bịLỡToolStripMenuItem});
            this.contextDoing.Name = "contextDoing";
            this.contextDoing.Size = new System.Drawing.Size(129, 22);
            this.contextDoing.Text = "Di chuyển";
            // 
            // sẽLàmToolStripMenuItem
            // 
            this.sẽLàmToolStripMenuItem.Name = "sẽLàmToolStripMenuItem";
            this.sẽLàmToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sẽLàmToolStripMenuItem.Text = "Sẽ làm";
            // 
            // đangLàmToolStripMenuItem
            // 
            this.đangLàmToolStripMenuItem.Name = "đangLàmToolStripMenuItem";
            this.đangLàmToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.đangLàmToolStripMenuItem.Text = "Đang làm";
            // 
            // đãLàmToolStripMenuItem
            // 
            this.đãLàmToolStripMenuItem.Name = "đãLàmToolStripMenuItem";
            this.đãLàmToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.đãLàmToolStripMenuItem.Text = "Đã làm";
            // 
            // bịLỡToolStripMenuItem
            // 
            this.bịLỡToolStripMenuItem.Name = "bịLỡToolStripMenuItem";
            this.bịLỡToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.bịLỡToolStripMenuItem.Text = "Bị lỡ";
            // 
            // contextRemove
            // 
            this.contextRemove.Name = "contextRemove";
            this.contextRemove.Size = new System.Drawing.Size(129, 22);
            this.contextRemove.Text = "Xóa";
            this.contextRemove.Click += new System.EventHandler(this.contextRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddToDo);
            this.groupBox1.Controls.Add(this.lbxToDo);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 417);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sẽ làm";
            // 
            // txtAddToDo
            // 
            this.txtAddToDo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAddToDo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddToDo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAddToDo.BorderThickness = 3;
            this.txtAddToDo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddToDo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddToDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddToDo.isPassword = false;
            this.txtAddToDo.Location = new System.Drawing.Point(7, 25);
            this.txtAddToDo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddToDo.Name = "txtAddToDo";
            this.txtAddToDo.Size = new System.Drawing.Size(239, 44);
            this.txtAddToDo.TabIndex = 1;
            this.txtAddToDo.Text = "Thêm việc sẽ làm";
            this.txtAddToDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddToDo.Enter += new System.EventHandler(this.txtAddToDo_Enter);
            this.txtAddToDo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddToDo_KeyDown);
            this.txtAddToDo.Leave += new System.EventHandler(this.txtAddToDo_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAddDoing);
            this.groupBox2.Controls.Add(this.lbxDoing);
            this.groupBox2.Location = new System.Drawing.Point(284, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 417);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đang làm";
            // 
            // txtAddDoing
            // 
            this.txtAddDoing.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAddDoing.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddDoing.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAddDoing.BorderThickness = 3;
            this.txtAddDoing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddDoing.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddDoing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddDoing.isPassword = false;
            this.txtAddDoing.Location = new System.Drawing.Point(7, 25);
            this.txtAddDoing.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddDoing.Name = "txtAddDoing";
            this.txtAddDoing.Size = new System.Drawing.Size(239, 44);
            this.txtAddDoing.TabIndex = 1;
            this.txtAddDoing.Text = "Thêm việc đang làm";
            this.txtAddDoing.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddDoing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddDoing_KeyDown);
            // 
            // lbxDoing
            // 
            this.lbxDoing.FormattingEnabled = true;
            this.lbxDoing.ItemHeight = 20;
            this.lbxDoing.Location = new System.Drawing.Point(6, 85);
            this.lbxDoing.Name = "lbxDoing";
            this.lbxDoing.Size = new System.Drawing.Size(240, 324);
            this.lbxDoing.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAddDone);
            this.groupBox3.Controls.Add(this.lbxDone);
            this.groupBox3.Location = new System.Drawing.Point(553, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 417);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đã làm";
            // 
            // txtAddDone
            // 
            this.txtAddDone.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAddDone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddDone.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAddDone.BorderThickness = 3;
            this.txtAddDone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddDone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddDone.isPassword = false;
            this.txtAddDone.Location = new System.Drawing.Point(5, 25);
            this.txtAddDone.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddDone.Name = "txtAddDone";
            this.txtAddDone.Size = new System.Drawing.Size(239, 44);
            this.txtAddDone.TabIndex = 1;
            this.txtAddDone.Text = "Thêm việc đã làm";
            this.txtAddDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbxDone
            // 
            this.lbxDone.FormattingEnabled = true;
            this.lbxDone.ItemHeight = 20;
            this.lbxDone.Location = new System.Drawing.Point(6, 85);
            this.lbxDone.Name = "lbxDone";
            this.lbxDone.Size = new System.Drawing.Size(240, 324);
            this.lbxDone.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBlock);
            this.groupBox4.Controls.Add(this.lbxBlock);
            this.groupBox4.Location = new System.Drawing.Point(817, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 378);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bị lỡ";
            // 
            // txtBlock
            // 
            this.txtBlock.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBlock.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBlock.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBlock.BorderThickness = 3;
            this.txtBlock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBlock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBlock.isPassword = false;
            this.txtBlock.Location = new System.Drawing.Point(7, 25);
            this.txtBlock.Margin = new System.Windows.Forms.Padding(4);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(239, 44);
            this.txtBlock.TabIndex = 1;
            this.txtBlock.Text = "Thêm việc bị lỡ";
            this.txtBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbxBlock
            // 
            this.lbxBlock.FormattingEnabled = true;
            this.lbxBlock.ItemHeight = 20;
            this.lbxBlock.Location = new System.Drawing.Point(6, 85);
            this.lbxBlock.Name = "lbxBlock";
            this.lbxBlock.Size = new System.Drawing.Size(240, 284);
            this.lbxBlock.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("TomFool", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(840, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "WALLO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Wallo";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1078, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextOption.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbxToDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxDoing;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxDone;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbxBlock;
        private System.Windows.Forms.ContextMenuStrip contextOption;
        private System.Windows.Forms.ToolStripMenuItem contextToDo;
        private System.Windows.Forms.ToolStripMenuItem contextDoing;
        private System.Windows.Forms.ToolStripMenuItem contextRemove;
        private System.Windows.Forms.ToolStripMenuItem sẽLàmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đangLàmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đãLàmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bịLỡToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAddToDo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAddDoing;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAddDone;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

