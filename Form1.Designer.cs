namespace Brendan_support
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            separator = new Label();
            remoteBox = new GroupBox();
            rdpConnectBtn = new Button();
            exploreConnectBtn = new Button();
            vncConnectBtn = new Button();
            deviceSelectCombo = new ListBox();
            selectDevicesLbl = new Label();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            restartLbl = new GroupBox();
            restartNewposBtn = new Button();
            stopNewposBtn = new Button();
            forceRebootBtn = new Button();
            rebootBtn = new Button();
            failoverBtn = new Button();
            primaryBtn = new Button();
            remoteBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            restartLbl.SuspendLayout();
            SuspendLayout();
            // 
            // separator
            // 
            separator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            separator.BackColor = Color.FromArgb(245, 187, 21);
            separator.Location = new Point(392, 22);
            separator.Name = "separator";
            separator.Size = new Size(6, 915);
            separator.TabIndex = 0;
            // 
            // remoteBox
            // 
            remoteBox.Controls.Add(rdpConnectBtn);
            remoteBox.Controls.Add(exploreConnectBtn);
            remoteBox.Controls.Add(vncConnectBtn);
            remoteBox.FlatStyle = FlatStyle.Flat;
            remoteBox.Font = new Font("Speedee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            remoteBox.Location = new Point(436, 101);
            remoteBox.Margin = new Padding(6);
            remoteBox.Name = "remoteBox";
            remoteBox.Padding = new Padding(6);
            remoteBox.Size = new Size(336, 336);
            remoteBox.TabIndex = 0;
            remoteBox.TabStop = false;
            remoteBox.Text = "Remote Connect";
            // 
            // rdpConnectBtn
            // 
            rdpConnectBtn.Anchor = AnchorStyles.None;
            rdpConnectBtn.BackgroundImage = supporttools.Properties.Resources.rdpIcon;
            rdpConnectBtn.BackgroundImageLayout = ImageLayout.Stretch;
            rdpConnectBtn.Location = new Point(104, 185);
            rdpConnectBtn.Margin = new Padding(6);
            rdpConnectBtn.Name = "rdpConnectBtn";
            rdpConnectBtn.Size = new Size(128, 128);
            rdpConnectBtn.TabIndex = 3;
            rdpConnectBtn.UseVisualStyleBackColor = true;
            // 
            // exploreConnectBtn
            // 
            exploreConnectBtn.Anchor = AnchorStyles.None;
            exploreConnectBtn.BackColor = Color.Transparent;
            exploreConnectBtn.BackgroundImage = supporttools.Properties.Resources.explorerIcon;
            exploreConnectBtn.BackgroundImageLayout = ImageLayout.Stretch;
            exploreConnectBtn.Location = new Point(183, 45);
            exploreConnectBtn.Margin = new Padding(6);
            exploreConnectBtn.Name = "exploreConnectBtn";
            exploreConnectBtn.Size = new Size(128, 128);
            exploreConnectBtn.TabIndex = 2;
            exploreConnectBtn.UseVisualStyleBackColor = false;
            exploreConnectBtn.Click += exploreConnectBtn_Click;
            // 
            // vncConnectBtn
            // 
            vncConnectBtn.BackgroundImage = supporttools.Properties.Resources.vncIcon;
            vncConnectBtn.BackgroundImageLayout = ImageLayout.Stretch;
            vncConnectBtn.Location = new Point(22, 44);
            vncConnectBtn.Margin = new Padding(6);
            vncConnectBtn.Name = "vncConnectBtn";
            vncConnectBtn.Size = new Size(128, 128);
            vncConnectBtn.TabIndex = 1;
            vncConnectBtn.UseVisualStyleBackColor = false;
            vncConnectBtn.Click += vncConnectBtn_Click;
            // 
            // deviceSelectCombo
            // 
            deviceSelectCombo.BorderStyle = BorderStyle.FixedSingle;
            deviceSelectCombo.Font = new Font("Speedee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            deviceSelectCombo.FormattingEnabled = true;
            deviceSelectCombo.ItemHeight = 32;
            deviceSelectCombo.Location = new Point(47, 101);
            deviceSelectCombo.Name = "deviceSelectCombo";
            deviceSelectCombo.SelectionMode = SelectionMode.MultiExtended;
            deviceSelectCombo.Size = new Size(320, 802);
            deviceSelectCombo.TabIndex = 1;
            // 
            // selectDevicesLbl
            // 
            selectDevicesLbl.Font = new Font("Speedee", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point);
            selectDevicesLbl.Location = new Point(47, 43);
            selectDevicesLbl.Name = "selectDevicesLbl";
            selectDevicesLbl.Size = new Size(320, 49);
            selectDevicesLbl.TabIndex = 2;
            selectDevicesLbl.Text = "Select Device(s)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Speedee", 13.8749981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(753, 46);
            label2.Name = "label2";
            label2.Size = new Size(330, 49);
            label2.TabIndex = 3;
            label2.Text = "Perform an Action";
            // 
            // restartLbl
            // 
            restartLbl.Controls.Add(restartNewposBtn);
            restartLbl.Controls.Add(stopNewposBtn);
            restartLbl.Controls.Add(forceRebootBtn);
            restartLbl.Controls.Add(rebootBtn);
            restartLbl.Font = new Font("Speedee", 9F, FontStyle.Regular, GraphicsUnit.Point);
            restartLbl.Location = new Point(436, 464);
            restartLbl.Name = "restartLbl";
            restartLbl.Size = new Size(336, 336);
            restartLbl.TabIndex = 4;
            restartLbl.TabStop = false;
            restartLbl.Text = "Restart";
            // 
            // restartNewposBtn
            // 
            restartNewposBtn.BackgroundImage = supporttools.Properties.Resources.restartnewpos;
            restartNewposBtn.Location = new Point(185, 192);
            restartNewposBtn.Name = "restartNewposBtn";
            restartNewposBtn.Size = new Size(128, 128);
            restartNewposBtn.TabIndex = 3;
            restartNewposBtn.UseVisualStyleBackColor = true;
            restartNewposBtn.Click += restartNewposBtn_Click;
            // 
            // stopNewposBtn
            // 
            stopNewposBtn.BackgroundImage = supporttools.Properties.Resources.stopnewpos;
            stopNewposBtn.Location = new Point(19, 192);
            stopNewposBtn.Name = "stopNewposBtn";
            stopNewposBtn.Size = new Size(128, 128);
            stopNewposBtn.TabIndex = 2;
            stopNewposBtn.UseVisualStyleBackColor = true;
            stopNewposBtn.Click += stopNewposBtn_Click;
            // 
            // forceRebootBtn
            // 
            forceRebootBtn.BackgroundImage = supporttools.Properties.Resources.forcereboot;
            forceRebootBtn.BackgroundImageLayout = ImageLayout.Stretch;
            forceRebootBtn.FlatAppearance.BorderColor = Color.Gold;
            forceRebootBtn.FlatAppearance.BorderSize = 4;
            forceRebootBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 42, 32);
            forceRebootBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 224, 168);
            forceRebootBtn.Font = new Font("Speedee", 9F, FontStyle.Bold, GraphicsUnit.Point);
            forceRebootBtn.Location = new Point(185, 38);
            forceRebootBtn.Name = "forceRebootBtn";
            forceRebootBtn.Size = new Size(128, 128);
            forceRebootBtn.TabIndex = 1;
            forceRebootBtn.Text = "Force Reboot";
            forceRebootBtn.UseVisualStyleBackColor = true;
            forceRebootBtn.Click += forceRebootBtn_Click;
            // 
            // rebootBtn
            // 
            rebootBtn.BackgroundImage = supporttools.Properties.Resources.reboot;
            rebootBtn.BackgroundImageLayout = ImageLayout.Stretch;
            rebootBtn.FlatAppearance.BorderColor = Color.Gold;
            rebootBtn.Font = new Font("Speedee", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rebootBtn.Location = new Point(19, 38);
            rebootBtn.Name = "rebootBtn";
            rebootBtn.Size = new Size(128, 128);
            rebootBtn.TabIndex = 0;
            rebootBtn.Text = "Reboot";
            rebootBtn.UseVisualStyleBackColor = true;
            rebootBtn.Click += rebootBtn_Click;
            // 
            // failoverBtn
            // 
            failoverBtn.BackgroundImage = supporttools.Properties.Resources.failover;
            failoverBtn.BackgroundImageLayout = ImageLayout.Stretch;
            failoverBtn.FlatAppearance.BorderColor = Color.FromArgb(201, 42, 32);
            failoverBtn.FlatAppearance.BorderSize = 6;
            failoverBtn.FlatStyle = FlatStyle.Flat;
            failoverBtn.Font = new Font("Speedee", 9F, FontStyle.Bold, GraphicsUnit.Point);
            failoverBtn.ForeColor = Color.FromArgb(201, 42, 32);
            failoverBtn.ImageAlign = ContentAlignment.MiddleLeft;
            failoverBtn.Location = new Point(436, 826);
            failoverBtn.Name = "failoverBtn";
            failoverBtn.Size = new Size(336, 111);
            failoverBtn.TabIndex = 5;
            failoverBtn.Text = "Promote to Failover  ";
            failoverBtn.TextAlign = ContentAlignment.MiddleRight;
            failoverBtn.UseVisualStyleBackColor = true;
            failoverBtn.Click += failoverBtn_Click;
            // 
            // primaryBtn
            // 
            primaryBtn.BackgroundImage = supporttools.Properties.Resources.primary;
            primaryBtn.BackgroundImageLayout = ImageLayout.Stretch;
            primaryBtn.Font = new Font("Speedee", 9F, FontStyle.Bold, GraphicsUnit.Point);
            primaryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            primaryBtn.Location = new Point(824, 826);
            primaryBtn.Name = "primaryBtn";
            primaryBtn.Size = new Size(336, 111);
            primaryBtn.TabIndex = 6;
            primaryBtn.Text = "Promote to Primary";
            primaryBtn.TextAlign = ContentAlignment.MiddleRight;
            primaryBtn.UseVisualStyleBackColor = true;
            primaryBtn.Click += primaryBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1486, 960);
            Controls.Add(primaryBtn);
            Controls.Add(failoverBtn);
            Controls.Add(restartLbl);
            Controls.Add(label2);
            Controls.Add(separator);
            Controls.Add(selectDevicesLbl);
            Controls.Add(deviceSelectCombo);
            Controls.Add(remoteBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "Form1";
            Text = "OTP Support Suite";
            Load += Form1_Load;
            remoteBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            restartLbl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox remoteBox;
        private Button rdpConnectBtn;
        private Button exploreConnectBtn;
        private Button vncConnectBtn;
        private ListBox deviceSelectCombo;
        private Label selectDevicesLbl;
        private BindingSource bindingSource1;
        private Label separator;
        private Label label2;
        private GroupBox restartLbl;
        private Button restartNewposBtn;
        private Button stopNewposBtn;
        private Button rebootBtn;
        private Button failoverBtn;
        private Button forceRebootBtn;
        private Button primaryBtn;
    }
}