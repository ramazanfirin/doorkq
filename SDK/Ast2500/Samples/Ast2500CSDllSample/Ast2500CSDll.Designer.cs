namespace Ast2500CSDllSample
{
    partial class Ast2500CSDll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ast2500CSDll));
            this.StaticMSG = new System.Windows.Forms.Label();
            this.CompanyMarkImage = new System.Windows.Forms.PictureBox();
            this.DevicesTxt = new System.Windows.Forms.Label();
            this.ComboDevice = new System.Windows.Forms.ComboBox();
            this.InitBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.GetCountBtn = new System.Windows.Forms.Button();
            this.GetCheckedImageBtn = new System.Windows.Forms.Button();
            this.GetRawImageBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.EnrollBtn = new System.Windows.Forms.Button();
            this.IdentifyBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.VerifyBtn = new System.Windows.Forms.Button();
            this.EnrollTxt = new System.Windows.Forms.Label();
            this.IdentifiedTxt = new System.Windows.Forms.Label();
            this.IdentifyIDTxt = new System.Windows.Forms.TextBox();
            this.EnrollIDTxt = new System.Windows.Forms.NumericUpDown();
            this.nGetFpImageTimer = new System.Windows.Forms.Timer(this.components);
            this.nIdentifyTimer = new System.Windows.Forms.Timer(this.components);
            this.nEnrollTimer = new System.Windows.Forms.Timer(this.components);
            this.nVerifyTimer = new System.Windows.Forms.Timer(this.components);
            this.FpImagePanel = new System.Windows.Forms.Panel();
            this.fpImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyMarkImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollIDTxt)).BeginInit();
            this.FpImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpImage)).BeginInit();
            this.SuspendLayout();
            // 
            // StaticMSG
            // 
            this.StaticMSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StaticMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StaticMSG.Location = new System.Drawing.Point(56, 17);
            this.StaticMSG.Name = "StaticMSG";
            this.StaticMSG.Size = new System.Drawing.Size(603, 44);
            this.StaticMSG.TabIndex = 0;
            this.StaticMSG.Text = "Welcome";
            this.StaticMSG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompanyMarkImage
            // 
            this.CompanyMarkImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CompanyMarkImage.BackgroundImage")));
            this.CompanyMarkImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CompanyMarkImage.InitialImage = global::Ast2500CSDllSample.Properties.Resources.IDR_MAI;
            this.CompanyMarkImage.Location = new System.Drawing.Point(16, 16);
            this.CompanyMarkImage.Name = "CompanyMarkImage";
            this.CompanyMarkImage.Size = new System.Drawing.Size(32, 32);
            this.CompanyMarkImage.TabIndex = 1;
            this.CompanyMarkImage.TabStop = false;
            // 
            // DevicesTxt
            // 
            this.DevicesTxt.AutoSize = true;
            this.DevicesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevicesTxt.Location = new System.Drawing.Point(392, 88);
            this.DevicesTxt.Name = "DevicesTxt";
            this.DevicesTxt.Size = new System.Drawing.Size(114, 16);
            this.DevicesTxt.TabIndex = 3;
            this.DevicesTxt.Text = "Ast2500 Devices :";
            // 
            // ComboDevice
            // 
            this.ComboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDevice.FormattingEnabled = true;
            this.ComboDevice.Location = new System.Drawing.Point(512, 85);
            this.ComboDevice.Name = "ComboDevice";
            this.ComboDevice.Size = new System.Drawing.Size(137, 21);
            this.ComboDevice.TabIndex = 4;
            // 
            // InitBtn
            // 
            this.InitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.InitBtn.FlatAppearance.BorderSize = 10;
            this.InitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InitBtn.Location = new System.Drawing.Point(393, 121);
            this.InitBtn.Name = "InitBtn";
            this.InitBtn.Size = new System.Drawing.Size(121, 34);
            this.InitBtn.TabIndex = 5;
            this.InitBtn.Text = "Init";
            this.InitBtn.UseVisualStyleBackColor = false;
            this.InitBtn.Click += new System.EventHandler(this.InitBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.FlatAppearance.BorderSize = 10;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeleteBtn.Location = new System.Drawing.Point(520, 210);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(138, 34);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ClearBtn.FlatAppearance.BorderSize = 10;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClearBtn.Location = new System.Drawing.Point(520, 250);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(138, 34);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // GetCountBtn
            // 
            this.GetCountBtn.BackColor = System.Drawing.SystemColors.Control;
            this.GetCountBtn.FlatAppearance.BorderSize = 10;
            this.GetCountBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GetCountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GetCountBtn.Location = new System.Drawing.Point(520, 290);
            this.GetCountBtn.Name = "GetCountBtn";
            this.GetCountBtn.Size = new System.Drawing.Size(138, 34);
            this.GetCountBtn.TabIndex = 13;
            this.GetCountBtn.Text = "Get Count";
            this.GetCountBtn.UseVisualStyleBackColor = false;
            this.GetCountBtn.Click += new System.EventHandler(this.GetCountBtn_Click);
            // 
            // GetCheckedImageBtn
            // 
            this.GetCheckedImageBtn.BackColor = System.Drawing.SystemColors.Control;
            this.GetCheckedImageBtn.FlatAppearance.BorderSize = 10;
            this.GetCheckedImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GetCheckedImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GetCheckedImageBtn.Location = new System.Drawing.Point(306, 456);
            this.GetCheckedImageBtn.Name = "GetCheckedImageBtn";
            this.GetCheckedImageBtn.Size = new System.Drawing.Size(147, 34);
            this.GetCheckedImageBtn.TabIndex = 18;
            this.GetCheckedImageBtn.Text = "Get Checked Fp Image";
            this.GetCheckedImageBtn.UseVisualStyleBackColor = false;
            this.GetCheckedImageBtn.Click += new System.EventHandler(this.GetCheckedImageBtn_Click);
            // 
            // GetRawImageBtn
            // 
            this.GetRawImageBtn.BackColor = System.Drawing.SystemColors.Control;
            this.GetRawImageBtn.FlatAppearance.BorderSize = 10;
            this.GetRawImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GetRawImageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GetRawImageBtn.Location = new System.Drawing.Point(511, 456);
            this.GetRawImageBtn.Name = "GetRawImageBtn";
            this.GetRawImageBtn.Size = new System.Drawing.Size(147, 34);
            this.GetRawImageBtn.TabIndex = 19;
            this.GetRawImageBtn.Text = "Get Fp Image";
            this.GetRawImageBtn.UseVisualStyleBackColor = false;
            this.GetRawImageBtn.Click += new System.EventHandler(this.GetRawImageBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBtn.FlatAppearance.BorderSize = 10;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExitBtn.Location = new System.Drawing.Point(529, 121);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(121, 34);
            this.ExitBtn.TabIndex = 20;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // EnrollBtn
            // 
            this.EnrollBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EnrollBtn.FlatAppearance.BorderSize = 10;
            this.EnrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EnrollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnrollBtn.Location = new System.Drawing.Point(393, 210);
            this.EnrollBtn.Name = "EnrollBtn";
            this.EnrollBtn.Size = new System.Drawing.Size(121, 34);
            this.EnrollBtn.TabIndex = 21;
            this.EnrollBtn.Text = "Enroll";
            this.EnrollBtn.UseVisualStyleBackColor = false;
            this.EnrollBtn.Click += new System.EventHandler(this.EnrollBtn_Click);
            // 
            // IdentifyBtn
            // 
            this.IdentifyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.IdentifyBtn.FlatAppearance.BorderSize = 10;
            this.IdentifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.IdentifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IdentifyBtn.Location = new System.Drawing.Point(395, 290);
            this.IdentifyBtn.Name = "IdentifyBtn";
            this.IdentifyBtn.Size = new System.Drawing.Size(121, 34);
            this.IdentifyBtn.TabIndex = 22;
            this.IdentifyBtn.Text = "Identify (1 : N)";
            this.IdentifyBtn.UseVisualStyleBackColor = false;
            this.IdentifyBtn.Click += new System.EventHandler(this.IdentifyBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.SystemColors.Control;
            this.StopBtn.FlatAppearance.BorderSize = 10;
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopBtn.Location = new System.Drawing.Point(520, 406);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(138, 34);
            this.StopBtn.TabIndex = 23;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // VerifyBtn
            // 
            this.VerifyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.VerifyBtn.FlatAppearance.BorderSize = 10;
            this.VerifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.VerifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VerifyBtn.Location = new System.Drawing.Point(393, 403);
            this.VerifyBtn.Name = "VerifyBtn";
            this.VerifyBtn.Size = new System.Drawing.Size(121, 34);
            this.VerifyBtn.TabIndex = 24;
            this.VerifyBtn.Text = "Verify (1 : 1)";
            this.VerifyBtn.UseVisualStyleBackColor = false;
            this.VerifyBtn.Click += new System.EventHandler(this.VerifyBtn_Click);
            // 
            // EnrollTxt
            // 
            this.EnrollTxt.AutoSize = true;
            this.EnrollTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollTxt.Location = new System.Drawing.Point(392, 180);
            this.EnrollTxt.Name = "EnrollTxt";
            this.EnrollTxt.Size = new System.Drawing.Size(61, 16);
            this.EnrollTxt.TabIndex = 28;
            this.EnrollTxt.Text = "Enroll ID:";
            // 
            // IdentifiedTxt
            // 
            this.IdentifiedTxt.AutoSize = true;
            this.IdentifiedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentifiedTxt.Location = new System.Drawing.Point(390, 368);
            this.IdentifiedTxt.Name = "IdentifiedTxt";
            this.IdentifiedTxt.Size = new System.Drawing.Size(64, 16);
            this.IdentifiedTxt.TabIndex = 29;
            this.IdentifiedTxt.Text = "Verify ID :";
            // 
            // IdentifyIDTxt
            // 
            this.IdentifyIDTxt.Location = new System.Drawing.Point(472, 367);
            this.IdentifyIDTxt.Name = "IdentifyIDTxt";
            this.IdentifyIDTxt.Size = new System.Drawing.Size(70, 20);
            this.IdentifyIDTxt.TabIndex = 30;
            this.IdentifyIDTxt.Text = "0";
            // 
            // EnrollIDTxt
            // 
            this.EnrollIDTxt.Location = new System.Drawing.Point(457, 177);
            this.EnrollIDTxt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.EnrollIDTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EnrollIDTxt.Name = "EnrollIDTxt";
            this.EnrollIDTxt.Size = new System.Drawing.Size(85, 20);
            this.EnrollIDTxt.TabIndex = 36;
            this.EnrollIDTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nGetFpImageTimer
            // 
            this.nGetFpImageTimer.Interval = 30;
            this.nGetFpImageTimer.Tick += new System.EventHandler(this.nGetFpImageTimer_Tick);
            // 
            // nIdentifyTimer
            // 
            this.nIdentifyTimer.Interval = 30;
            this.nIdentifyTimer.Tick += new System.EventHandler(this.nIdentifyTimer_Tick);
            // 
            // nEnrollTimer
            // 
            this.nEnrollTimer.Interval = 30;
            this.nEnrollTimer.Tick += new System.EventHandler(this.nEnrollTimer_Tick);
            // 
            // nVerifyTimer
            // 
            this.nVerifyTimer.Interval = 30;
            this.nVerifyTimer.Tick += new System.EventHandler(this.nVerifyTimer_Tick);
            // 
            // FpImagePanel
            // 
            this.FpImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FpImagePanel.Controls.Add(this.fpImage);
            this.FpImagePanel.Location = new System.Drawing.Point(27, 85);
            this.FpImagePanel.Name = "FpImagePanel";
            this.FpImagePanel.Size = new System.Drawing.Size(357, 355);
            this.FpImagePanel.TabIndex = 37;
            // 
            // fpImage
            // 
            this.fpImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fpImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fpImage.Image = ((System.Drawing.Image)(resources.GetObject("fpImage.Image")));
            this.fpImage.Location = new System.Drawing.Point(4, 3);
            this.fpImage.Name = "fpImage";
            this.fpImage.Size = new System.Drawing.Size(348, 348);
            this.fpImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fpImage.TabIndex = 3;
            this.fpImage.TabStop = false;
            // 
            // Ast2500CSDll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 507);
            this.Controls.Add(this.FpImagePanel);
            this.Controls.Add(this.EnrollIDTxt);
            this.Controls.Add(this.IdentifyIDTxt);
            this.Controls.Add(this.IdentifiedTxt);
            this.Controls.Add(this.EnrollTxt);
            this.Controls.Add(this.VerifyBtn);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.IdentifyBtn);
            this.Controls.Add(this.EnrollBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.GetRawImageBtn);
            this.Controls.Add(this.GetCheckedImageBtn);
            this.Controls.Add(this.GetCountBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.InitBtn);
            this.Controls.Add(this.ComboDevice);
            this.Controls.Add(this.DevicesTxt);
            this.Controls.Add(this.CompanyMarkImage);
            this.Controls.Add(this.StaticMSG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ast2500CSDll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ast2500 C# Dll Sample (Version 1.0.0)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ast2500CSDll_FormClosed);
            this.Load += new System.EventHandler(this.Ast2500CSDll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyMarkImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrollIDTxt)).EndInit();
            this.FpImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaticMSG;
        private System.Windows.Forms.PictureBox CompanyMarkImage;
        private System.Windows.Forms.Label DevicesTxt;
        private System.Windows.Forms.ComboBox ComboDevice;
        private System.Windows.Forms.Button InitBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button GetCountBtn;
        private System.Windows.Forms.Button GetCheckedImageBtn;
        private System.Windows.Forms.Button GetRawImageBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button EnrollBtn;
        private System.Windows.Forms.Button IdentifyBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button VerifyBtn;
        private System.Windows.Forms.Label EnrollTxt;
        private System.Windows.Forms.Label IdentifiedTxt;
        private System.Windows.Forms.TextBox IdentifyIDTxt;
        private System.Windows.Forms.NumericUpDown EnrollIDTxt;
        internal System.Windows.Forms.Timer nGetFpImageTimer;
        internal System.Windows.Forms.Timer nIdentifyTimer;
        internal System.Windows.Forms.Timer nEnrollTimer;
        internal System.Windows.Forms.Timer nVerifyTimer;
        private System.Windows.Forms.Panel FpImagePanel;
        private System.Windows.Forms.PictureBox fpImage;
    }
}