
namespace ntfysh_client
{
    partial class SubscribeDialog
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
            panel1 = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            topicId = new System.Windows.Forms.TextBox();
            serverUrl = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            username = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            password = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            connectionType = new System.Windows.Forms.ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 276);
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(346, 58);
            panel1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button2.Location = new System.Drawing.Point(153, 15);
            button2.Margin = new System.Windows.Forms.Padding(12, 13, 4, 13);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(88, 30);
            button2.TabIndex = 7;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(247, 15);
            button1.Margin = new System.Windows.Forms.Padding(4, 13, 12, 13);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 30);
            button1.TabIndex = 6;
            button1.Text = "订阅";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 11);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 17);
            label1.TabIndex = 1;
            label1.Text = "主题ID(Topic ID)";
            // 
            // topicId
            // 
            topicId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            topicId.Location = new System.Drawing.Point(14, 33);
            topicId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            topicId.Name = "topicId";
            topicId.Size = new System.Drawing.Size(318, 23);
            topicId.TabIndex = 1;
            topicId.KeyDown += topicId_KeyDown;
            // 
            // serverUrl
            // 
            serverUrl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            serverUrl.Location = new System.Drawing.Point(14, 84);
            serverUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            serverUrl.Name = "serverUrl";
            serverUrl.Size = new System.Drawing.Size(318, 23);
            serverUrl.TabIndex = 2;
            serverUrl.Text = "wss://ntfy.sh";
            serverUrl.KeyDown += serverUrl_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 62);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 17);
            label2.TabIndex = 3;
            label2.Text = "服务器地址:";
            // 
            // username
            // 
            username.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            username.Location = new System.Drawing.Point(14, 135);
            username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            username.Name = "username";
            username.Size = new System.Drawing.Size(318, 23);
            username.TabIndex = 3;
            username.TextChanged += username_TextChanged;
            username.KeyDown += username_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 113);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 17);
            label3.TabIndex = 5;
            label3.Text = "用户名:";
            // 
            // password
            // 
            password.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            password.Location = new System.Drawing.Point(14, 186);
            password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            password.Name = "password";
            password.Size = new System.Drawing.Size(318, 23);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            password.KeyDown += password_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 164);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 17);
            label4.TabIndex = 7;
            label4.Text = "密码:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 215);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 17);
            label5.TabIndex = 9;
            label5.Text = "连接方式:";
            // 
            // connectionType
            // 
            connectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            connectionType.FormattingEnabled = true;
            connectionType.Items.AddRange(new object[] { "Websockets (Recommended)", "Long HTTP JSON (Robust)" });
            connectionType.Location = new System.Drawing.Point(14, 236);
            connectionType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            connectionType.Name = "connectionType";
            connectionType.Size = new System.Drawing.Size(318, 25);
            connectionType.TabIndex = 5;
            connectionType.SelectedIndexChanged += connectionType_SelectedIndexChanged;
            connectionType.TextChanged += connectionType_TextChanged;
            // 
            // SubscribeDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(346, 334);
            Controls.Add(connectionType);
            Controls.Add(label5);
            Controls.Add(password);
            Controls.Add(label4);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(serverUrl);
            Controls.Add(label2);
            Controls.Add(topicId);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SubscribeDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "订阅新话题(Topic)";
            Load += SubscribeDialog_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.TextBox serverUrl;
        private System.Windows.Forms.Label label2;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox topicId;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox connectionType;
    }
}