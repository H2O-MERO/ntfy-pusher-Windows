
namespace ntfysh_client
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            subscribeNewTopic = new System.Windows.Forms.Button();
            removeSelectedTopics = new System.Windows.Forms.Button();
            无订阅的主题 = new System.Windows.Forms.ListBox();
            notifyIcon = new System.Windows.Forms.NotifyIcon(components);
            trayContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            showControlWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ntfyshWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            trayContextMenu.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // subscribeNewTopic
            // 
            resources.ApplyResources(subscribeNewTopic, "subscribeNewTopic");
            subscribeNewTopic.Name = "subscribeNewTopic";
            subscribeNewTopic.UseVisualStyleBackColor = true;
            subscribeNewTopic.Click += subscribeNewTopic_Click;
            // 
            // removeSelectedTopics
            // 
            resources.ApplyResources(removeSelectedTopics, "removeSelectedTopics");
            removeSelectedTopics.Name = "removeSelectedTopics";
            removeSelectedTopics.UseVisualStyleBackColor = true;
            removeSelectedTopics.Click += removeSelectedTopics_Click;
            // 
            // 无订阅的主题
            // 
            resources.ApplyResources(无订阅的主题, "无订阅的主题");
            无订阅的主题.FormattingEnabled = true;
            无订阅的主题.Name = "无订阅的主题";
            无订阅的主题.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            无订阅的主题.Click += notificationTopics_Click;
            无订阅的主题.SelectedIndexChanged += notificationTopics_SelectedIndexChanged;
            无订阅的主题.SelectedValueChanged += notificationTopics_SelectedValueChanged;
            // 
            // notifyIcon
            // 
            resources.ApplyResources(notifyIcon, "notifyIcon");
            notifyIcon.ContextMenuStrip = trayContextMenu;
            notifyIcon.Click += notifyIcon_Click;
            // 
            // trayContextMenu
            // 
            resources.ApplyResources(trayContextMenu, "trayContextMenu");
            trayContextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { showControlWindowToolStripMenuItem, exitToolStripMenuItem });
            trayContextMenu.Name = "trayContextMenu";
            // 
            // showControlWindowToolStripMenuItem
            // 
            resources.ApplyResources(showControlWindowToolStripMenuItem, "showControlWindowToolStripMenuItem");
            showControlWindowToolStripMenuItem.Name = "showControlWindowToolStripMenuItem";
            showControlWindowToolStripMenuItem.Click += showControlWindowToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.BackColor = System.Drawing.Color.White;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exitToolStripMenuItem1, settingsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            resources.ApplyResources(exitToolStripMenuItem1, "exitToolStripMenuItem1");
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(settingsToolStripMenuItem, "settingsToolStripMenuItem");
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ntfyshWebsiteToolStripMenuItem, toolStripMenuItem1, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // ntfyshWebsiteToolStripMenuItem
            // 
            resources.ApplyResources(ntfyshWebsiteToolStripMenuItem, "ntfyshWebsiteToolStripMenuItem");
            ntfyshWebsiteToolStripMenuItem.Name = "ntfyshWebsiteToolStripMenuItem";
            ntfyshWebsiteToolStripMenuItem.Click += ntfyshWebsiteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(menuStrip1);
            Controls.Add(无订阅的主题);
            Controls.Add(removeSelectedTopics);
            Controls.Add(subscribeNewTopic);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            FormClosing += MainForm_FormClosing;
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            trayContextMenu.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button subscribeNewTopic;
        private System.Windows.Forms.Button removeSelectedTopics;
        private System.Windows.Forms.ListBox 无订阅的主题;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showControlWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ntfyshWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

