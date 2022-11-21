namespace WFHW5_3
{
    partial class Form2
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
            this.tBWriterFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbWrite = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBWriterFile
            // 
            this.tBWriterFile.Location = new System.Drawing.Point(0, 0);
            this.tBWriterFile.Name = "tBWriterFile";
            this.tBWriterFile.Size = new System.Drawing.Size(75, 23);
            this.tBWriterFile.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(0, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(266, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbWrite
            // 
            this.tbWrite.Location = new System.Drawing.Point(0, -1);
            this.tbWrite.Multiline = true;
            this.tbWrite.Name = "tbWrite";
            this.tbWrite.Size = new System.Drawing.Size(550, 250);
            this.tbWrite.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(266, 42);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbWrite);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBWriterFile);
            this.Name = "Form2";
            this.Text = "Редактировать файл";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tBWriterFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbWrite;
        private System.Windows.Forms.Button btnCancel;
    }
}