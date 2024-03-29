﻿namespace Netch.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportServersFromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProcessModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateRouteTableRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubscribeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageSubscribeLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateServersFromSubscribeLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowHideConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CleanDNSCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UninstallServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNetchFirewallRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.NewVersionLabel = new System.Windows.Forms.ToolStripLabel();
            this.VersionLabel = new System.Windows.Forms.ToolStripLabel();
            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.configLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.ModeComboBox = new System.Windows.Forms.ComboBox();
            this.ServerComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.ProfileNameText = new System.Windows.Forms.TextBox();
            this.EditServerPictureBox = new System.Windows.Forms.PictureBox();
            this.CopyLinkPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteServerPictureBox = new System.Windows.Forms.PictureBox();
            this.SpeedPictureBox = new System.Windows.Forms.PictureBox();
            this.EditModePictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteModePictureBox = new System.Windows.Forms.PictureBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UsedBandwidthLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DownloadSpeedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UploadSpeedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.blankToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NatTypeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NatTypeStatusLightLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ControlButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowMainFormToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ProfileGroupBox = new System.Windows.Forms.GroupBox();
            this.ProfileTable = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtomControlContainerControl = new System.Windows.Forms.ContainerControl();
            this.MenuStrip.SuspendLayout();
            this.ConfigurationGroupBox.SuspendLayout();
            this.configLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditServerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyLinkPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteServerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditModePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteModePictureBox)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.NotifyMenu.SuspendLayout();
            this.ProfileGroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.ButtomControlContainerControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(1110, 35);
            this.MenuStrip.TabIndex = 0;
            // 
            // ServerToolStripMenuItem
            // 
            this.ServerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 1);
            this.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem";
            this.ServerToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.ServerToolStripMenuItem.Text = "Server";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ImportServersFromClipboardToolStripMenuItem
            // 
            this.ImportServersFromClipboardToolStripMenuItem.Name = "ImportServersFromClipboardToolStripMenuItem";
            this.ImportServersFromClipboardToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.ImportServersFromClipboardToolStripMenuItem.Text = "Import Servers From Clipboard";
            this.ImportServersFromClipboardToolStripMenuItem.Click += new System.EventHandler(this.ImportServersFromClipboardToolStripMenuItem_Click);
            // 
            // ModeToolStripMenuItem
            // 
            this.ModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProcessModeToolStripMenuItem,
            this.CreateRouteTableRuleToolStripMenuItem});
            this.ModeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem";
            this.ModeToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.ModeToolStripMenuItem.Text = "Mode";
            // 
            // CreateProcessModeToolStripMenuItem
            // 
            this.CreateProcessModeToolStripMenuItem.Name = "CreateProcessModeToolStripMenuItem";
            this.CreateProcessModeToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.CreateProcessModeToolStripMenuItem.Text = "Create Process Mode";
            this.CreateProcessModeToolStripMenuItem.Click += new System.EventHandler(this.CreateProcessModeToolStripButton_Click);
            // 
            // CreateRouteTableRuleToolStripMenuItem
            // 
            this.CreateRouteTableRuleToolStripMenuItem.Name = "CreateRouteTableRuleToolStripMenuItem";
            this.CreateRouteTableRuleToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.CreateRouteTableRuleToolStripMenuItem.Text = "Create Route Table Rule";
            this.CreateRouteTableRuleToolStripMenuItem.Click += new System.EventHandler(this.createRouteTableModeToolStripMenuItem_Click);
            // 
            // SubscribeToolStripMenuItem
            // 
            this.SubscribeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageSubscribeLinksToolStripMenuItem,
            this.UpdateServersFromSubscribeLinksToolStripMenuItem});
            this.SubscribeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.SubscribeToolStripMenuItem.Name = "SubscribeToolStripMenuItem";
            this.SubscribeToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.SubscribeToolStripMenuItem.Text = "Subscribe";
            // 
            // ManageSubscribeLinksToolStripMenuItem
            // 
            this.ManageSubscribeLinksToolStripMenuItem.Name = "ManageSubscribeLinksToolStripMenuItem";
            this.ManageSubscribeLinksToolStripMenuItem.Size = new System.Drawing.Size(427, 34);
            this.ManageSubscribeLinksToolStripMenuItem.Text = "Manage Subscribe Links";
            this.ManageSubscribeLinksToolStripMenuItem.Click += new System.EventHandler(this.ManageSubscribeLinksToolStripMenuItem_Click);
            // 
            // UpdateServersFromSubscribeLinksToolStripMenuItem
            // 
            this.UpdateServersFromSubscribeLinksToolStripMenuItem.Name = "UpdateServersFromSubscribeLinksToolStripMenuItem";
            this.UpdateServersFromSubscribeLinksToolStripMenuItem.Size = new System.Drawing.Size(427, 34);
            this.UpdateServersFromSubscribeLinksToolStripMenuItem.Text = "Update Servers From Subscribe Links";
            this.UpdateServersFromSubscribeLinksToolStripMenuItem.Click += new System.EventHandler(this.UpdateServersFromSubscribeLinksToolStripMenuItem_Click);
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenDirectoryToolStripMenuItem,
            this.ShowHideConsoleToolStripMenuItem,
            this.CleanDNSCacheToolStripMenuItem,
            this.UninstallServiceToolStripMenuItem,
            this.removeNetchFirewallRulesToolStripMenuItem});
            this.OptionsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.OptionsToolStripMenuItem.Text = "Options";
            // 
            // OpenDirectoryToolStripMenuItem
            // 
            this.OpenDirectoryToolStripMenuItem.Name = "OpenDirectoryToolStripMenuItem";
            this.OpenDirectoryToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.OpenDirectoryToolStripMenuItem.Text = "Open Directory";
            this.OpenDirectoryToolStripMenuItem.Click += new System.EventHandler(this.OpenDirectoryToolStripMenuItem_Click);
            // 
            // ShowHideConsoleToolStripMenuItem
            // 
            this.ShowHideConsoleToolStripMenuItem.Name = "ShowHideConsoleToolStripMenuItem";
            this.ShowHideConsoleToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.ShowHideConsoleToolStripMenuItem.Text = "Show/Hide Console";
            this.ShowHideConsoleToolStripMenuItem.Click += new System.EventHandler(this.ShowHideConsoleToolStripMenuItem_Click);
            // 
            // CleanDNSCacheToolStripMenuItem
            // 
            this.CleanDNSCacheToolStripMenuItem.Name = "CleanDNSCacheToolStripMenuItem";
            this.CleanDNSCacheToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.CleanDNSCacheToolStripMenuItem.Text = "Clean DNS Cache";
            this.CleanDNSCacheToolStripMenuItem.Click += new System.EventHandler(this.CleanDNSCacheToolStripMenuItem_Click);
            // 
            // UninstallServiceToolStripMenuItem
            // 
            this.UninstallServiceToolStripMenuItem.Name = "UninstallServiceToolStripMenuItem";
            this.UninstallServiceToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.UninstallServiceToolStripMenuItem.Text = "Uninstall NF Service";
            this.UninstallServiceToolStripMenuItem.Click += new System.EventHandler(this.UninstallServiceToolStripMenuItem_Click);
            // 
            // removeNetchFirewallRulesToolStripMenuItem
            // 
            this.removeNetchFirewallRulesToolStripMenuItem.Name = "removeNetchFirewallRulesToolStripMenuItem";
            this.removeNetchFirewallRulesToolStripMenuItem.Size = new System.Drawing.Size(358, 34);
            this.removeNetchFirewallRulesToolStripMenuItem.Text = "Remove Netch Firewall Rules";
            this.removeNetchFirewallRulesToolStripMenuItem.Click += new System.EventHandler(this.RemoveNetchFirewallRulesToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckForUpdatesToolStripMenuItem,
            this.fAQToolStripMenuItem});
            this.HelpToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // CheckForUpdatesToolStripMenuItem
            // 
            this.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem";
            this.CheckForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.CheckForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.CheckForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.fAQToolStripMenuItem.Text = "FAQ";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // AboutToolStripButton
            // 
            this.AboutToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AboutToolStripButton.AutoToolTip = false;
            this.AboutToolStripButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.AboutToolStripButton.Name = "AboutToolStripButton";
            this.AboutToolStripButton.Size = new System.Drawing.Size(47, 21);
            this.AboutToolStripButton.Text = "About";
            this.AboutToolStripButton.Click += new System.EventHandler(this.AboutToolStripButton_Click);
            // 
            // NewVersionLabel
            // 
            this.NewVersionLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.NewVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewVersionLabel.ForeColor = System.Drawing.Color.Red;
            this.NewVersionLabel.IsLink = true;
            this.NewVersionLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.NewVersionLabel.LinkColor = System.Drawing.Color.Red;
            this.NewVersionLabel.Name = "NewVersionLabel";
            this.NewVersionLabel.Size = new System.Drawing.Size(135, 19);
            this.NewVersionLabel.Text = "New version available";
            this.NewVersionLabel.Visible = false;
            this.NewVersionLabel.Click += new System.EventHandler(this.NewVersionLabel_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.ForeColor = System.Drawing.Color.Red;
            this.VersionLabel.IsLink = true;
            this.VersionLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(26, 19);
            this.VersionLabel.Text = "xxx";
            this.VersionLabel.Click += new System.EventHandler(this.VersionLabel_Click);
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.Controls.Add(this.configLayoutPanel);
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(4, 4);
            this.ConfigurationGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(1064, 172);
            this.ConfigurationGroupBox.TabIndex = 1;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "当前服务器配置";
            // 
            // configLayoutPanel
            // 
            this.configLayoutPanel.AutoSize = true;
            this.configLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.configLayoutPanel.ColumnCount = 3;
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.configLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.configLayoutPanel.Controls.Add(this.ModeLabel, 0, 1);
            this.configLayoutPanel.Controls.Add(this.ServerLabel, 0, 0);
            this.configLayoutPanel.Controls.Add(this.ModeComboBox, 1, 1);
            this.configLayoutPanel.Controls.Add(this.ServerComboBox, 1, 0);
            this.configLayoutPanel.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.configLayoutPanel.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.configLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configLayoutPanel.Location = new System.Drawing.Point(4, 28);
            this.configLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.configLayoutPanel.Name = "configLayoutPanel";
            this.configLayoutPanel.RowCount = 3;
            this.configLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configLayoutPanel.Size = new System.Drawing.Size(1056, 140);
            this.configLayoutPanel.TabIndex = 15;
            // 
            // ModeLabel
            // 
            this.ModeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(4, 54);
            this.ModeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(61, 24);
            this.ModeLabel.TabIndex = 3;
            this.ModeLabel.Text = "Mode";
            // 
            // ServerLabel
            // 
            this.ServerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(4, 10);
            this.ServerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(63, 24);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Server";
            // 
            // ModeComboBox
            // 
            this.ModeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeComboBox.FormattingEnabled = true;
            this.ModeComboBox.IntegralHeight = false;
            this.ModeComboBox.Location = new System.Drawing.Point(75, 48);
            this.ModeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModeComboBox.Name = "ModeComboBox";
            this.ModeComboBox.Size = new System.Drawing.Size(817, 32);
            this.ModeComboBox.TabIndex = 2;
            this.ModeComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            this.ModeComboBox.SelectionChangeCommitted += new System.EventHandler(this.ModeComboBox_SelectionChangeCommitted);
            // 
            // ServerComboBox
            // 
            this.ServerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerComboBox.FormattingEnabled = true;
            this.ServerComboBox.IntegralHeight = false;
            this.ServerComboBox.Location = new System.Drawing.Point(75, 4);
            this.ServerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServerComboBox.MaxDropDownItems = 16;
            this.ServerComboBox.Name = "ServerComboBox";
            this.ServerComboBox.Size = new System.Drawing.Size(817, 32);
            this.ServerComboBox.TabIndex = 1;
            this.ServerComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            this.ServerComboBox.SelectionChangeCommitted += new System.EventHandler(this.ServerComboBox_SelectionChangeCommitted);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(900, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(141, 36);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(900, 48);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(141, 36);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Location = new System.Drawing.Point(3, 68);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(45, 17);
            this.ProfileLabel.TabIndex = 10;
            this.ProfileLabel.Text = "Profile";
            // 
            // ProfileNameText
            // 
            this.ProfileNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileNameText.Location = new System.Drawing.Point(54, 63);
            this.ProfileNameText.Name = "ProfileNameText";
            this.ProfileNameText.Size = new System.Drawing.Size(546, 30);
            this.ProfileNameText.TabIndex = 11;
            // 
            // EditServerPictureBox
            // 
            this.EditServerPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.EditServerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditServerPictureBox.Image = global::Netch.Properties.Resources.edit;
            this.EditServerPictureBox.Location = new System.Drawing.Point(3, 3);
            this.EditServerPictureBox.Name = "EditServerPictureBox";
            this.EditServerPictureBox.Size = new System.Drawing.Size(16, 16);
            this.EditServerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditServerPictureBox.TabIndex = 7;
            this.EditServerPictureBox.TabStop = false;
            this.EditServerPictureBox.Click += new System.EventHandler(this.EditServerPictureBox_Click);
            // 
            // CopyLinkPictureBox
            // 
            this.CopyLinkPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyLinkPictureBox.Image = global::Netch.Properties.Resources.CopyLink;
            this.CopyLinkPictureBox.Location = new System.Drawing.Point(72, 3);
            this.CopyLinkPictureBox.Name = "CopyLinkPictureBox";
            this.CopyLinkPictureBox.Size = new System.Drawing.Size(18, 18);
            this.CopyLinkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CopyLinkPictureBox.TabIndex = 14;
            this.CopyLinkPictureBox.TabStop = false;
            this.CopyLinkPictureBox.Click += new System.EventHandler(this.CopyLinkPictureBox_Click);
            // 
            // DeleteServerPictureBox
            // 
            this.DeleteServerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteServerPictureBox.Image = global::Netch.Properties.Resources.delete;
            this.DeleteServerPictureBox.Location = new System.Drawing.Point(26, 3);
            this.DeleteServerPictureBox.Name = "DeleteServerPictureBox";
            this.DeleteServerPictureBox.Size = new System.Drawing.Size(16, 16);
            this.DeleteServerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteServerPictureBox.TabIndex = 8;
            this.DeleteServerPictureBox.TabStop = false;
            this.DeleteServerPictureBox.Click += new System.EventHandler(this.DeleteServerPictureBox_Click);
            // 
            // SpeedPictureBox
            // 
            this.SpeedPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpeedPictureBox.Image = global::Netch.Properties.Resources.speed;
            this.SpeedPictureBox.Location = new System.Drawing.Point(49, 3);
            this.SpeedPictureBox.Name = "SpeedPictureBox";
            this.SpeedPictureBox.Size = new System.Drawing.Size(16, 16);
            this.SpeedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpeedPictureBox.TabIndex = 9;
            this.SpeedPictureBox.TabStop = false;
            this.SpeedPictureBox.Click += new System.EventHandler(this.SpeedPictureBox_Click);
            // 
            // EditModePictureBox
            // 
            this.EditModePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditModePictureBox.Image = global::Netch.Properties.Resources.edit;
            this.EditModePictureBox.Location = new System.Drawing.Point(3, 3);
            this.EditModePictureBox.Name = "EditModePictureBox";
            this.EditModePictureBox.Size = new System.Drawing.Size(16, 16);
            this.EditModePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditModePictureBox.TabIndex = 12;
            this.EditModePictureBox.TabStop = false;
            this.EditModePictureBox.Click += new System.EventHandler(this.EditModePictureBox_Click);
            // 
            // DeleteModePictureBox
            // 
            this.DeleteModePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteModePictureBox.Image = global::Netch.Properties.Resources.delete;
            this.DeleteModePictureBox.Location = new System.Drawing.Point(26, 3);
            this.DeleteModePictureBox.Name = "DeleteModePictureBox";
            this.DeleteModePictureBox.Size = new System.Drawing.Size(16, 16);
            this.DeleteModePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteModePictureBox.TabIndex = 13;
            this.DeleteModePictureBox.TabStop = false;
            this.DeleteModePictureBox.Click += new System.EventHandler(this.DeleteModePictureBox_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.UsedBandwidthLabel,
            this.DownloadSpeedLabel,
            this.UploadSpeedLabel,
            this.blankToolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 410);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.StatusStrip.Size = new System.Drawing.Size(1110, 31);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(261, 24);
            this.StatusLabel.Text = "Status: Waiting for command";
            // 
            // UsedBandwidthLabel
            // 
            this.UsedBandwidthLabel.Name = "UsedBandwidthLabel";
            this.UsedBandwidthLabel.Size = new System.Drawing.Size(100, 24);
            this.UsedBandwidthLabel.Text = "Used: 0 KB";
            this.UsedBandwidthLabel.Visible = false;
            // 
            // DownloadSpeedLabel
            // 
            this.DownloadSpeedLabel.Name = "DownloadSpeedLabel";
            this.DownloadSpeedLabel.Size = new System.Drawing.Size(82, 24);
            this.DownloadSpeedLabel.Text = "↓: 0 KB/s";
            this.DownloadSpeedLabel.Visible = false;
            // 
            // UploadSpeedLabel
            // 
            this.UploadSpeedLabel.Name = "UploadSpeedLabel";
            this.UploadSpeedLabel.Size = new System.Drawing.Size(82, 24);
            this.UploadSpeedLabel.Text = "↑: 0 KB/s";
            this.UploadSpeedLabel.Visible = false;
            // 
            // blankToolStripStatusLabel
            // 
            this.blankToolStripStatusLabel.Name = "blankToolStripStatusLabel";
            this.blankToolStripStatusLabel.Size = new System.Drawing.Size(826, 24);
            this.blankToolStripStatusLabel.Spring = true;
            // 
            // NatTypeStatusLabel
            // 
            this.NatTypeStatusLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.NatTypeStatusLabel.Name = "NatTypeStatusLabel";
            this.NatTypeStatusLabel.Size = new System.Drawing.Size(23, 23);
            // 
            // NatTypeStatusLightLabel
            // 
            this.NatTypeStatusLightLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.NatTypeStatusLightLabel.Name = "NatTypeStatusLightLabel";
            this.NatTypeStatusLightLabel.Size = new System.Drawing.Size(23, 23);
            // 
            // ControlButton
            // 
            this.ControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ControlButton.Location = new System.Drawing.Point(946, 4);
            this.ControlButton.Margin = new System.Windows.Forms.Padding(4);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(112, 40);
            this.ControlButton.TabIndex = 3;
            this.ControlButton.Text = "Start";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.NotifyMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Ostrich";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMainFormToolStripButton,
            this.ExitToolStripButton});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.ShowItemToolTips = false;
            this.NotifyMenu.Size = new System.Drawing.Size(127, 64);
            // 
            // ShowMainFormToolStripButton
            // 
            this.ShowMainFormToolStripButton.Name = "ShowMainFormToolStripButton";
            this.ShowMainFormToolStripButton.Size = new System.Drawing.Size(126, 30);
            this.ShowMainFormToolStripButton.Text = "Show";
            this.ShowMainFormToolStripButton.Click += new System.EventHandler(this.ShowMainFormToolStripButton_Click);
            // 
            // ExitToolStripButton
            // 
            this.ExitToolStripButton.Name = "ExitToolStripButton";
            this.ExitToolStripButton.Size = new System.Drawing.Size(126, 30);
            this.ExitToolStripButton.Text = "Exit";
            this.ExitToolStripButton.Click += new System.EventHandler(this.ExitToolStripButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(0, 0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 0;
            // 
            // ProfileGroupBox
            // 
            this.ProfileGroupBox.Controls.Add(this.ProfileTable);
            this.ProfileGroupBox.Location = new System.Drawing.Point(3, 124);
            this.ProfileGroupBox.Name = "ProfileGroupBox";
            this.ProfileGroupBox.Size = new System.Drawing.Size(709, 65);
            this.ProfileGroupBox.TabIndex = 13;
            this.ProfileGroupBox.TabStop = false;
            this.ProfileGroupBox.Text = "Profiles";
            // 
            // ProfileTable
            // 
            this.ProfileTable.AutoSize = true;
            this.ProfileTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProfileTable.ColumnCount = 2;
            this.ProfileTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProfileTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProfileTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileTable.Location = new System.Drawing.Point(3, 26);
            this.ProfileTable.Name = "ProfileTable";
            this.ProfileTable.RowCount = 1;
            this.ProfileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProfileTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProfileTable.Size = new System.Drawing.Size(703, 36);
            this.ProfileTable.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.ConfigurationGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.ButtomControlContainerControl);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 44);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1072, 275);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // ButtomControlContainerControl
            // 
            this.ButtomControlContainerControl.Controls.Add(this.ControlButton);
            this.ButtomControlContainerControl.Location = new System.Drawing.Point(4, 184);
            this.ButtomControlContainerControl.Margin = new System.Windows.Forms.Padding(4);
            this.ButtomControlContainerControl.Name = "ButtomControlContainerControl";
            this.ButtomControlContainerControl.Size = new System.Drawing.Size(1059, 87);
            this.ButtomControlContainerControl.TabIndex = 14;
            this.ButtomControlContainerControl.TabStop = false;
            this.ButtomControlContainerControl.Text = "groupBox1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1110, 441);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ostrich";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ConfigurationGroupBox.ResumeLayout(false);
            this.ConfigurationGroupBox.PerformLayout();
            this.configLayoutPanel.ResumeLayout(false);
            this.configLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditServerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopyLinkPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteServerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditModePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteModePictureBox)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.NotifyMenu.ResumeLayout(false);
            this.ProfileGroupBox.ResumeLayout(false);
            this.ProfileGroupBox.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ButtomControlContainerControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripMenuItem CreateRouteTableRuleToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem removeNetchFirewallRulesToolStripMenuItem;

        private System.Windows.Forms.ToolStripButton AboutToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem CleanDNSCacheToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel configLayoutPanel;
        private System.Windows.Forms.GroupBox ConfigurationGroupBox;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.PictureBox CopyLinkPictureBox;
        private System.Windows.Forms.ToolStripMenuItem CreateProcessModeToolStripMenuItem;
        private System.Windows.Forms.PictureBox DeleteModePictureBox;
        private System.Windows.Forms.PictureBox DeleteServerPictureBox;
        private System.Windows.Forms.ToolStripStatusLabel DownloadSpeedLabel;
        private System.Windows.Forms.PictureBox EditModePictureBox;
        private System.Windows.Forms.PictureBox EditServerPictureBox;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportServersFromClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageSubscribeLinksToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuStrip;
        public System.Windows.Forms.ComboBox ModeComboBox;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.ToolStripMenuItem ModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel NatTypeStatusLabel;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox ProfileGroupBox;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.TextBox ProfileNameText;
        private System.Windows.Forms.TableLayoutPanel ProfileTable;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ComboBox ServerComboBox;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.ToolStripMenuItem ServerToolStripMenuItem;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.ToolStripMenuItem ShowMainFormToolStripButton;
        private System.Windows.Forms.PictureBox SpeedPictureBox;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripMenuItem SubscribeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem UninstallServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateServersFromSubscribeLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel UploadSpeedLabel;
        private System.Windows.Forms.ToolStripStatusLabel UsedBandwidthLabel;
        private System.Windows.Forms.ToolStripLabel NewVersionLabel;
        private System.Windows.Forms.ToolStripLabel VersionLabel;
        private System.Windows.Forms.ToolStripStatusLabel NatTypeStatusLightLabel;
        private System.Windows.Forms.ToolStripStatusLabel blankToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContainerControl ButtomControlContainerControl;
        private System.Windows.Forms.ToolStripMenuItem ShowHideConsoleToolStripMenuItem;
    }
}