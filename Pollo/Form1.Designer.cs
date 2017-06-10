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
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbxDoing = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbxDone = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bunifuMetroTextbox3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
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
            this.lbxToDo.Items.AddRange(new object[] {
            "Đọc Conan",
            "Fix bug connection string"});
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
            this.groupBox2.Controls.Add(this.bunifuMetroTextbox1);
            this.groupBox2.Controls.Add(this.lbxDoing);
            this.groupBox2.Location = new System.Drawing.Point(284, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 417);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đang làm";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(7, 25);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(239, 44);
            this.bunifuMetroTextbox1.TabIndex = 1;
            this.bunifuMetroTextbox1.Text = "Thêm việc đang làm";
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox1.Enter += new System.EventHandler(this.txtAddToDo_Enter);
            this.bunifuMetroTextbox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddToDo_KeyDown);
            this.bunifuMetroTextbox1.Leave += new System.EventHandler(this.txtAddToDo_Leave);
            // 
            // lbxDoing
            // 
            this.lbxDoing.FormattingEnabled = true;
            this.lbxDoing.ItemHeight = 20;
            this.lbxDoing.Items.AddRange(new object[] {
            "Ứng dụng destop WALLO"});
            this.lbxDoing.Location = new System.Drawing.Point(6, 85);
            this.lbxDoing.Name = "lbxDoing";
            this.lbxDoing.Size = new System.Drawing.Size(240, 324);
            this.lbxDoing.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bunifuMetroTextbox2);
            this.groupBox3.Controls.Add(this.lbxDone);
            this.groupBox3.Location = new System.Drawing.Point(553, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 417);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đã làm";
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderThickness = 3;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(5, 25);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(239, 44);
            this.bunifuMetroTextbox2.TabIndex = 1;
            this.bunifuMetroTextbox2.Text = "Thêm việc đã làm";
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox2.Enter += new System.EventHandler(this.txtAddToDo_Enter);
            this.bunifuMetroTextbox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddToDo_KeyDown);
            this.bunifuMetroTextbox2.Leave += new System.EventHandler(this.txtAddToDo_Leave);
            // 
            // lbxDone
            // 
            this.lbxDone.FormattingEnabled = true;
            this.lbxDone.ItemHeight = 20;
            this.lbxDone.Items.AddRange(new object[] {
            "Crawl dữ liệu",
            "Đọc \"Code dạo kí sự\""});
            this.lbxDone.Location = new System.Drawing.Point(6, 85);
            this.lbxDone.Name = "lbxDone";
            this.lbxDone.Size = new System.Drawing.Size(240, 324);
            this.lbxDone.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bunifuMetroTextbox3);
            this.groupBox4.Controls.Add(this.lbxBlock);
            this.groupBox4.Location = new System.Drawing.Point(817, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 378);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bị lỡ";
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox3.BorderThickness = 3;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.isPassword = false;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(7, 25);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(239, 44);
            this.bunifuMetroTextbox3.TabIndex = 1;
            this.bunifuMetroTextbox3.Text = "Thêm việc bị lỡ";
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox3.Enter += new System.EventHandler(this.txtAddToDo_Enter);
            this.bunifuMetroTextbox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddToDo_KeyDown);
            this.bunifuMetroTextbox3.Leave += new System.EventHandler(this.txtAddToDo_Leave);
            // 
            // lbxBlock
            // 
            this.lbxBlock.FormattingEnabled = true;
            this.lbxBlock.ItemHeight = 20;
            this.lbxBlock.Items.AddRange(new object[] {
            "Chat realtime firebase"});
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
            this.notifyIcon1.Text = "notifyIcon1";
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
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

