﻿namespace _20181116_Windows_Forms
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_choose_folder = new System.Windows.Forms.Button();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_togglemonitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wyslij mail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(75, 67);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(273, 22);
            this.textBox_Name.TabIndex = 2;
            // 
            // button_choose_folder
            // 
            this.button_choose_folder.Location = new System.Drawing.Point(566, 21);
            this.button_choose_folder.Name = "button_choose_folder";
            this.button_choose_folder.Size = new System.Drawing.Size(134, 63);
            this.button_choose_folder.TabIndex = 3;
            this.button_choose_folder.Text = "Przeglądaj";
            this.button_choose_folder.UseVisualStyleBackColor = true;
            this.button_choose_folder.Click += new System.EventHandler(this.button_choose_folder_Click);
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(75, 23);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(468, 22);
            this.textBox_Path.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Folder";
            // 
            // button_togglemonitor
            // 
            this.button_togglemonitor.Location = new System.Drawing.Point(35, 121);
            this.button_togglemonitor.Name = "button_togglemonitor";
            this.button_togglemonitor.Size = new System.Drawing.Size(197, 42);
            this.button_togglemonitor.TabIndex = 6;
            this.button_togglemonitor.Text = "Start";
            this.button_togglemonitor.UseVisualStyleBackColor = true;
            this.button_togglemonitor.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_togglemonitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.button_choose_folder);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_choose_folder;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_togglemonitor;
    }
}

