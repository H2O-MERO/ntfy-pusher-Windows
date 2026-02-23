
namespace ntfysh_client
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            aboutPage = new System.Windows.Forms.TabPage();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            licensePage = new System.Windows.Forms.TabPage();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            tabControl1.SuspendLayout();
            aboutPage.SuspendLayout();
            licensePage.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(820, 389);
            button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(138, 43);
            button1.TabIndex = 0;
            button1.Text = "关闭";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(19, 14);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(320, 45);
            label2.TabIndex = 2;
            label2.Text = "ntfy pusher Windows";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(aboutPage);
            tabControl1.Controls.Add(licensePage);
            tabControl1.Location = new System.Drawing.Point(19, 69);
            tabControl1.Margin = new System.Windows.Forms.Padding(5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(940, 310);
            tabControl1.TabIndex = 3;
            // 
            // aboutPage
            // 
            aboutPage.Controls.Add(richTextBox2);
            aboutPage.Location = new System.Drawing.Point(4, 33);
            aboutPage.Margin = new System.Windows.Forms.Padding(5);
            aboutPage.Name = "aboutPage";
            aboutPage.Padding = new System.Windows.Forms.Padding(5);
            aboutPage.Size = new System.Drawing.Size(932, 273);
            aboutPage.TabIndex = 0;
            aboutPage.Text = "关于";
            aboutPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox2.Location = new System.Drawing.Point(9, 10);
            richTextBox2.Margin = new System.Windows.Forms.Padding(5);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new System.Drawing.Size(908, 246);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // licensePage
            // 
            licensePage.Controls.Add(richTextBox1);
            licensePage.Location = new System.Drawing.Point(4, 33);
            licensePage.Margin = new System.Windows.Forms.Padding(5);
            licensePage.Name = "licensePage";
            licensePage.Padding = new System.Windows.Forms.Padding(5);
            licensePage.Size = new System.Drawing.Size(932, 273);
            licensePage.TabIndex = 1;
            licensePage.Text = "MIT License\n\n";
            licensePage.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBox1.Location = new System.Drawing.Point(9, 10);
            richTextBox1.Margin = new System.Windows.Forms.Padding(5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(908, 246);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // AboutBox
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(977, 440);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "关于";
            Load += AboutBox_Load;
            tabControl1.ResumeLayout(false);
            aboutPage.ResumeLayout(false);
            licensePage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.TabPage licensePage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}