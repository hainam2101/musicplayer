﻿namespace lyrics_viewer
{
    partial class Lyrical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lyrical));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.forward = new System.Windows.Forms.Button();
            this.Choosepath = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Azure;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 12);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(170, 199);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.Location = new System.Drawing.Point(87, 265);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 30);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Azure;
            this.richTextBox1.Location = new System.Drawing.Point(182, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(170, 199);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // forward
            // 
            this.forward.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.forward.BackgroundImage = global::lyrics_viewer.Properties.Resources.next_button;
            this.forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forward.Location = new System.Drawing.Point(258, 333);
            this.forward.Margin = new System.Windows.Forms.Padding(2);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(44, 44);
            this.forward.TabIndex = 3;
            this.forward.UseVisualStyleBackColor = false;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // Choosepath
            // 
            this.Choosepath.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Choosepath.BackgroundImage = global::lyrics_viewer.Properties.Resources.list_of_files;
            this.Choosepath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Choosepath.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choosepath.Location = new System.Drawing.Point(52, 265);
            this.Choosepath.Margin = new System.Windows.Forms.Padding(2);
            this.Choosepath.Name = "Choosepath";
            this.Choosepath.Size = new System.Drawing.Size(30, 30);
            this.Choosepath.TabIndex = 8;
            this.Choosepath.UseVisualStyleBackColor = false;
            this.Choosepath.Click += new System.EventHandler(this.button2_Click);
            // 
            // play
            // 
            this.play.AccessibleName = "play";
            this.play.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.play.BackgroundImage = global::lyrics_viewer.Properties.Resources.play_button__2_;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(117, 322);
            this.play.Margin = new System.Windows.Forms.Padding(2);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(54, 55);
            this.play.TabIndex = 6;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.button1_Click);
            // 
            // pause
            // 
            this.pause.AccessibleName = "pause";
            this.pause.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pause.BackgroundImage = global::lyrics_viewer.Properties.Resources.rounded_pause_button;
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pause.Location = new System.Drawing.Point(186, 322);
            this.pause.Margin = new System.Windows.Forms.Padding(2);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(54, 55);
            this.pause.TabIndex = 2;
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_play_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.back.BackgroundImage = global::lyrics_viewer.Properties.Resources.back_button1;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.Location = new System.Drawing.Point(52, 333);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(44, 44);
            this.back.TabIndex = 1;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Lyrical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(356, 419);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.Choosepath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lyrical";
            this.Text = "Lyrical";
            this.Load += new System.EventHandler(this.Lyrical_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button Choosepath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

