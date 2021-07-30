
namespace Working_with_flash_drives
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Search_for_disks = new System.Windows.Forms.Button();
            this.Selecting_a_disk = new System.Windows.Forms.ComboBox();
            this.Activate_Text = new System.Windows.Forms.Button();
            this.Entering_the_type = new System.Windows.Forms.TextBox();
            this.Type_of_Files = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Search_Directory = new System.Windows.Forms.Button();
            this.Start_Download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search_for_disks
            // 
            this.Search_for_disks.Location = new System.Drawing.Point(12, 35);
            this.Search_for_disks.Name = "Search_for_disks";
            this.Search_for_disks.Size = new System.Drawing.Size(178, 28);
            this.Search_for_disks.TabIndex = 0;
            this.Search_for_disks.Text = "Поиск внешних дисков";
            this.Search_for_disks.UseVisualStyleBackColor = true;
            this.Search_for_disks.Click += new System.EventHandler(this.Search_for_disks_Click);
            // 
            // Selecting_a_disk
            // 
            this.Selecting_a_disk.FormattingEnabled = true;
            this.Selecting_a_disk.Location = new System.Drawing.Point(12, 80);
            this.Selecting_a_disk.Name = "Selecting_a_disk";
            this.Selecting_a_disk.Size = new System.Drawing.Size(178, 28);
            this.Selecting_a_disk.TabIndex = 1;
            // 
            // Activate_Text
            // 
            this.Activate_Text.Location = new System.Drawing.Point(196, 81);
            this.Activate_Text.Name = "Activate_Text";
            this.Activate_Text.Size = new System.Drawing.Size(70, 28);
            this.Activate_Text.TabIndex = 3;
            this.Activate_Text.Text = "Выбор";
            this.Activate_Text.UseVisualStyleBackColor = true;
            this.Activate_Text.Click += new System.EventHandler(this.Activate_Text_Click);
            // 
            // Entering_the_type
            // 
            this.Entering_the_type.Location = new System.Drawing.Point(293, 81);
            this.Entering_the_type.Name = "Entering_the_type";
            this.Entering_the_type.Size = new System.Drawing.Size(149, 27);
            this.Entering_the_type.TabIndex = 4;
            // 
            // Type_of_Files
            // 
            this.Type_of_Files.Location = new System.Drawing.Point(448, 81);
            this.Type_of_Files.Name = "Type_of_Files";
            this.Type_of_Files.Size = new System.Drawing.Size(102, 27);
            this.Type_of_Files.TabIndex = 5;
            this.Type_of_Files.Text = "Выбор типа";
            this.Type_of_Files.UseVisualStyleBackColor = true;
            this.Type_of_Files.Click += new System.EventHandler(this.Type_of_Files_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выбор типа для переноса файла";
            // 
            // Search_Directory
            // 
            this.Search_Directory.Location = new System.Drawing.Point(293, 135);
            this.Search_Directory.Name = "Search_Directory";
            this.Search_Directory.Size = new System.Drawing.Size(257, 29);
            this.Search_Directory.TabIndex = 7;
            this.Search_Directory.Text = "Выбор папки для перемещения ";
            this.Search_Directory.UseVisualStyleBackColor = true;
            this.Search_Directory.Click += new System.EventHandler(this.Search_Directory_Click);
            // 
            // Start_Download
            // 
            this.Start_Download.Location = new System.Drawing.Point(157, 241);
            this.Start_Download.Name = "Start_Download";
            this.Start_Download.Size = new System.Drawing.Size(227, 29);
            this.Start_Download.TabIndex = 0;
            this.Start_Download.Text = "Начало перевода картинок";
            this.Start_Download.Click += new System.EventHandler(this.Start_Download_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 327);
            this.Controls.Add(this.Start_Download);
            this.Controls.Add(this.Search_Directory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Type_of_Files);
            this.Controls.Add(this.Entering_the_type);
            this.Controls.Add(this.Activate_Text);
            this.Controls.Add(this.Selecting_a_disk);
            this.Controls.Add(this.Search_for_disks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash drives";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_for_disks;
        private System.Windows.Forms.ComboBox Selecting_a_disk;
        private System.Windows.Forms.Button Activate_Text;
        private System.Windows.Forms.TextBox Entering_the_type;
        private System.Windows.Forms.Button Type_of_Files;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Search_Directory;
        private System.Windows.Forms.Button Start_Download;
    }
}

