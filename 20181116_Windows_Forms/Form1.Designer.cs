namespace _20181116_Windows_Forms
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
            this.button_SendMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_choose_folder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_togglemonitor = new System.Windows.Forms.Button();
            this.listBox_Logs = new System.Windows.Forms.ListBox();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_SendMail
            // 
            this.button_SendMail.Location = new System.Drawing.Point(35, 359);
            this.button_SendMail.Name = "button_SendMail";
            this.button_SendMail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_SendMail.Size = new System.Drawing.Size(140, 42);
            this.button_SendMail.TabIndex = 0;
            this.button_SendMail.Text = "Wyslij mail";
            this.button_SendMail.UseVisualStyleBackColor = true;
            this.button_SendMail.Click += new System.EventHandler(this.button1_Click);
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
            this.button_togglemonitor.Text = "Monitoring";
            this.button_togglemonitor.UseVisualStyleBackColor = true;
            this.button_togglemonitor.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_Logs
            // 
            this.listBox_Logs.FormattingEnabled = true;
            this.listBox_Logs.ItemHeight = 16;
            this.listBox_Logs.Location = new System.Drawing.Point(369, 102);
            this.listBox_Logs.Name = "listBox_Logs";
            this.listBox_Logs.Size = new System.Drawing.Size(331, 244);
            this.listBox_Logs.TabIndex = 7;
            // 
            // textBox_Path
            // 
            this.textBox_Path.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::_20181116_Windows_Forms.Properties.Settings.Default, "FolderPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Path.Location = new System.Drawing.Point(75, 23);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(468, 22);
            this.textBox_Path.TabIndex = 4;
            this.textBox_Path.Text = global::_20181116_Windows_Forms.Properties.Settings.Default.FolderPath;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_Logs);
            this.Controls.Add(this.button_togglemonitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.button_choose_folder);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_SendMail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SendMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_choose_folder;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_togglemonitor;
        private System.Windows.Forms.ListBox listBox_Logs;
    }
}

