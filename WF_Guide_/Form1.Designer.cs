namespace WF_Guide_
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.backContextToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToglToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.colElementToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.col2ElementToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.docToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(268, 303);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.ListBox1_Click);
            this.listBox1.DoubleClick += new System.EventHandler(this.ListBox1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripItem,
            this.toolStripSeparator1,
            this.backContextToolStripItem,
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 101);
            // 
            // openToolStripItem
            // 
            this.openToolStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem,
            this.docToolStripMenuItem,
            this.exeToolStripMenuItem});
            this.openToolStripItem.Name = "openToolStripItem";
            this.openToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripItem.Text = "Открыть";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // backContextToolStripItem
            // 
            this.backContextToolStripItem.Name = "backContextToolStripItem";
            this.backContextToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.backContextToolStripItem.Size = new System.Drawing.Size(164, 22);
            this.backContextToolStripItem.Text = "Назад";
            // 
            // listBox2
            // 
            this.listBox2.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(274, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(368, 303);
            this.listBox2.TabIndex = 1;
            this.listBox2.Click += new System.EventHandler(this.ListBox2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.pathToolStripTextBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Проводник";
            this.menuStrip1.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Checked = true;
            this.backToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.backToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(12, 23);
            this.backToolStripMenuItem.Text = "назад";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.backToglToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.menuToolStripMenuItem.Text = "Главная";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            // 
            // backToglToolStripMenuItem
            // 
            this.backToglToolStripMenuItem.Name = "backToglToolStripMenuItem";
            this.backToglToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.backToglToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.backToglToolStripMenuItem.Text = "Назад";
            // 
            // pathToolStripTextBox
            // 
            this.pathToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pathToolStripTextBox.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pathToolStripTextBox.Name = "pathToolStripTextBox";
            this.pathToolStripTextBox.ReadOnly = true;
            this.pathToolStripTextBox.Size = new System.Drawing.Size(400, 23);
            this.pathToolStripTextBox.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colElementToolStripLabel,
            this.col2ElementToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 347);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(642, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // colElementToolStripLabel
            // 
            this.colElementToolStripLabel.Name = "colElementToolStripLabel";
            this.colElementToolStripLabel.Size = new System.Drawing.Size(79, 22);
            this.colElementToolStripLabel.Text = "Элементов: 0";
            // 
            // col2ElementToolStripLabel
            // 
            this.col2ElementToolStripLabel.Margin = new System.Windows.Forms.Padding(187, 1, 0, 2);
            this.col2ElementToolStripLabel.Name = "col2ElementToolStripLabel";
            this.col2ElementToolStripLabel.Size = new System.Drawing.Size(79, 22);
            this.col2ElementToolStripLabel.Text = "Элементов: 0";
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.txtToolStripMenuItem.Text = "txt";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // docToolStripMenuItem
            // 
            this.docToolStripMenuItem.Name = "docToolStripMenuItem";
            this.docToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.docToolStripMenuItem.Text = "doc";
            // 
            // exeToolStripMenuItem
            // 
            this.exeToolStripMenuItem.Name = "exeToolStripMenuItem";
            this.exeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exeToolStripMenuItem.Text = "exe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 372);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проводник";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox pathToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel colElementToolStripLabel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backContextToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem backToglToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel col2ElementToolStripLabel;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem docToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exeToolStripMenuItem;
    }
}

