namespace FileReadWriteExample
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
            this.txtBoxWrite = new System.Windows.Forms.TextBox();
            this.btnWriteRead = new System.Windows.Forms.Button();
            this.lblReadFile = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxWrite
            // 
            this.txtBoxWrite.Location = new System.Drawing.Point(260, 59);
            this.txtBoxWrite.Name = "txtBoxWrite";
            this.txtBoxWrite.Size = new System.Drawing.Size(145, 22);
            this.txtBoxWrite.TabIndex = 0;
            this.txtBoxWrite.Text = "Write this text into a File";
            // 
            // btnWriteRead
            // 
            this.btnWriteRead.Location = new System.Drawing.Point(271, 132);
            this.btnWriteRead.Name = "btnWriteRead";
            this.btnWriteRead.Size = new System.Drawing.Size(121, 43);
            this.btnWriteRead.TabIndex = 1;
            this.btnWriteRead.Text = "Write To and Read From File";
            this.btnWriteRead.UseVisualStyleBackColor = true;
            this.btnWriteRead.Click += new System.EventHandler(this.btnWriteRead_Click);
            // 
            // lblReadFile
            // 
            this.lblReadFile.AutoSize = true;
            this.lblReadFile.Location = new System.Drawing.Point(288, 229);
            this.lblReadFile.Name = "lblReadFile";
            this.lblReadFile.Size = new System.Drawing.Size(64, 17);
            this.lblReadFile.TabIndex = 2;
            this.lblReadFile.Text = "ReadFile";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(277, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Logs";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblReadFile);
            this.Controls.Add(this.btnWriteRead);
            this.Controls.Add(this.txtBoxWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxWrite;
        private System.Windows.Forms.Button btnWriteRead;
        private System.Windows.Forms.Label lblReadFile;
        private System.Windows.Forms.Button btnDelete;
    }
}

