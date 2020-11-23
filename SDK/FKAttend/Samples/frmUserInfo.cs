using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FKAttendDllCSSample
{
	/// <summary>
	/// Form6 的摘要说明。
	/// </summary>
	public class frmUserInfo : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Button cmdSetAllUserNews;
		public System.Windows.Forms.Button cmdDeleteCompanyName;
		public System.Windows.Forms.Button cmdSetCompanyName;
		public System.Windows.Forms.Button cmdDeleteNewsID;
		public System.Windows.Forms.Button cmdClearNewsID;
		public System.Windows.Forms.Button cmdClearNews;
		public System.Windows.Forms.TextBox txtMessageID;
		public System.Windows.Forms.Button cmdSetUserNews;
		public System.Windows.Forms.Button cmdGetUserNews;
		public System.Windows.Forms.Button cmdSetNewsMessage;
		public System.Windows.Forms.Button cmdGetNewsMessage;
		public System.Windows.Forms.TextBox txtUserMessage;
		public System.Windows.Forms.TextBox txtEnrollNumber;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.Button cmdGetUserName;
		public System.Windows.Forms.Button cmdSetUserName;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label lblMessage;
		public System.Windows.Forms.Label lblEnrollNum;
		public System.Windows.Forms.Label Label3;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmUserInfo()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.cmdSetAllUserNews = new System.Windows.Forms.Button();
            this.cmdDeleteCompanyName = new System.Windows.Forms.Button();
            this.cmdSetCompanyName = new System.Windows.Forms.Button();
            this.cmdDeleteNewsID = new System.Windows.Forms.Button();
            this.cmdClearNewsID = new System.Windows.Forms.Button();
            this.cmdClearNews = new System.Windows.Forms.Button();
            this.txtMessageID = new System.Windows.Forms.TextBox();
            this.cmdSetUserNews = new System.Windows.Forms.Button();
            this.cmdGetUserNews = new System.Windows.Forms.Button();
            this.cmdSetNewsMessage = new System.Windows.Forms.Button();
            this.cmdGetNewsMessage = new System.Windows.Forms.Button();
            this.txtUserMessage = new System.Windows.Forms.TextBox();
            this.txtEnrollNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmdGetUserName = new System.Windows.Forms.Button();
            this.cmdSetUserName = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblEnrollNum = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdSetAllUserNews
            // 
            this.cmdSetAllUserNews.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetAllUserNews.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetAllUserNews.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetAllUserNews.Location = new System.Drawing.Point(15, 254);
            this.cmdSetAllUserNews.Name = "cmdSetAllUserNews";
            this.cmdSetAllUserNews.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetAllUserNews.Size = new System.Drawing.Size(96, 25);
            this.cmdSetAllUserNews.TabIndex = 38;
            this.cmdSetAllUserNews.Text = "Set All News";
            this.cmdSetAllUserNews.UseVisualStyleBackColor = false;
            this.cmdSetAllUserNews.Click += new System.EventHandler(this.cmdSetAllUserNews_Click);
            // 
            // cmdDeleteCompanyName
            // 
            this.cmdDeleteCompanyName.BackColor = System.Drawing.SystemColors.Control;
            this.cmdDeleteCompanyName.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDeleteCompanyName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDeleteCompanyName.Location = new System.Drawing.Point(232, 294);
            this.cmdDeleteCompanyName.Name = "cmdDeleteCompanyName";
            this.cmdDeleteCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDeleteCompanyName.Size = new System.Drawing.Size(209, 25);
            this.cmdDeleteCompanyName.TabIndex = 32;
            this.cmdDeleteCompanyName.Text = "Delete Company Name";
            this.cmdDeleteCompanyName.UseVisualStyleBackColor = false;
            this.cmdDeleteCompanyName.Click += new System.EventHandler(this.cmdDeleteCompanyName_Click);
            // 
            // cmdSetCompanyName
            // 
            this.cmdSetCompanyName.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetCompanyName.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetCompanyName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetCompanyName.Location = new System.Drawing.Point(15, 294);
            this.cmdSetCompanyName.Name = "cmdSetCompanyName";
            this.cmdSetCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetCompanyName.Size = new System.Drawing.Size(209, 25);
            this.cmdSetCompanyName.TabIndex = 31;
            this.cmdSetCompanyName.Text = "Set Company Name";
            this.cmdSetCompanyName.UseVisualStyleBackColor = false;
            this.cmdSetCompanyName.Click += new System.EventHandler(this.cmdSetCompanyName_Click);
            // 
            // cmdDeleteNewsID
            // 
            this.cmdDeleteNewsID.BackColor = System.Drawing.SystemColors.Control;
            this.cmdDeleteNewsID.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdDeleteNewsID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDeleteNewsID.Location = new System.Drawing.Point(321, 254);
            this.cmdDeleteNewsID.Name = "cmdDeleteNewsID";
            this.cmdDeleteNewsID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdDeleteNewsID.Size = new System.Drawing.Size(120, 25);
            this.cmdDeleteNewsID.TabIndex = 30;
            this.cmdDeleteNewsID.Text = "Delete News ID";
            this.cmdDeleteNewsID.UseVisualStyleBackColor = false;
            this.cmdDeleteNewsID.Click += new System.EventHandler(this.cmdDeleteNewsID_Click);
            // 
            // cmdClearNewsID
            // 
            this.cmdClearNewsID.BackColor = System.Drawing.SystemColors.Control;
            this.cmdClearNewsID.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdClearNewsID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClearNewsID.Location = new System.Drawing.Point(207, 254);
            this.cmdClearNewsID.Name = "cmdClearNewsID";
            this.cmdClearNewsID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClearNewsID.Size = new System.Drawing.Size(114, 25);
            this.cmdClearNewsID.TabIndex = 28;
            this.cmdClearNewsID.Text = "Clear News ID";
            this.cmdClearNewsID.UseVisualStyleBackColor = false;
            this.cmdClearNewsID.Click += new System.EventHandler(this.cmdClearNewsID_Click);
            // 
            // cmdClearNews
            // 
            this.cmdClearNews.BackColor = System.Drawing.SystemColors.Control;
            this.cmdClearNews.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdClearNews.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClearNews.Location = new System.Drawing.Point(111, 254);
            this.cmdClearNews.Name = "cmdClearNews";
            this.cmdClearNews.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdClearNews.Size = new System.Drawing.Size(96, 25);
            this.cmdClearNews.TabIndex = 26;
            this.cmdClearNews.Text = "Clear News";
            this.cmdClearNews.UseVisualStyleBackColor = false;
            this.cmdClearNews.Click += new System.EventHandler(this.cmdClearNews_Click);
            // 
            // txtMessageID
            // 
            this.txtMessageID.AcceptsReturn = true;
            this.txtMessageID.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessageID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessageID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMessageID.Location = new System.Drawing.Point(119, 142);
            this.txtMessageID.MaxLength = 0;
            this.txtMessageID.Name = "txtMessageID";
            this.txtMessageID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMessageID.Size = new System.Drawing.Size(57, 25);
            this.txtMessageID.TabIndex = 35;
            // 
            // cmdSetUserNews
            // 
            this.cmdSetUserNews.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetUserNews.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetUserNews.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetUserNews.Location = new System.Drawing.Point(207, 214);
            this.cmdSetUserNews.Name = "cmdSetUserNews";
            this.cmdSetUserNews.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetUserNews.Size = new System.Drawing.Size(114, 25);
            this.cmdSetUserNews.TabIndex = 22;
            this.cmdSetUserNews.Text = "Set News ID";
            this.cmdSetUserNews.UseVisualStyleBackColor = false;
            this.cmdSetUserNews.Click += new System.EventHandler(this.cmdSetUserNews_Click);
            // 
            // cmdGetUserNews
            // 
            this.cmdGetUserNews.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetUserNews.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetUserNews.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetUserNews.Location = new System.Drawing.Point(321, 214);
            this.cmdGetUserNews.Name = "cmdGetUserNews";
            this.cmdGetUserNews.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetUserNews.Size = new System.Drawing.Size(120, 25);
            this.cmdGetUserNews.TabIndex = 25;
            this.cmdGetUserNews.Text = "Get  News ID ";
            this.cmdGetUserNews.UseVisualStyleBackColor = false;
            this.cmdGetUserNews.Click += new System.EventHandler(this.cmdGetUserNews_Click);
            // 
            // cmdSetNewsMessage
            // 
            this.cmdSetNewsMessage.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetNewsMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetNewsMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetNewsMessage.Location = new System.Drawing.Point(15, 214);
            this.cmdSetNewsMessage.Name = "cmdSetNewsMessage";
            this.cmdSetNewsMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetNewsMessage.Size = new System.Drawing.Size(96, 25);
            this.cmdSetNewsMessage.TabIndex = 19;
            this.cmdSetNewsMessage.Text = "Set News";
            this.cmdSetNewsMessage.UseVisualStyleBackColor = false;
            this.cmdSetNewsMessage.Click += new System.EventHandler(this.cmdSetNewsMessage_Click);
            // 
            // cmdGetNewsMessage
            // 
            this.cmdGetNewsMessage.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetNewsMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetNewsMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetNewsMessage.Location = new System.Drawing.Point(111, 214);
            this.cmdGetNewsMessage.Name = "cmdGetNewsMessage";
            this.cmdGetNewsMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetNewsMessage.Size = new System.Drawing.Size(96, 25);
            this.cmdGetNewsMessage.TabIndex = 20;
            this.cmdGetNewsMessage.Text = "Get News";
            this.cmdGetNewsMessage.UseVisualStyleBackColor = false;
            this.cmdGetNewsMessage.Click += new System.EventHandler(this.cmdGetNewsMessage_Click);
            // 
            // txtUserMessage
            // 
            this.txtUserMessage.AcceptsReturn = true;
            this.txtUserMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserMessage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserMessage.Location = new System.Drawing.Point(119, 174);
            this.txtUserMessage.MaxLength = 0;
            this.txtUserMessage.Name = "txtUserMessage";
            this.txtUserMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserMessage.Size = new System.Drawing.Size(320, 32);
            this.txtUserMessage.TabIndex = 29;
            // 
            // txtEnrollNumber
            // 
            this.txtEnrollNumber.AcceptsReturn = true;
            this.txtEnrollNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnrollNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrollNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnrollNumber.Location = new System.Drawing.Point(119, 102);
            this.txtEnrollNumber.MaxLength = 8;
            this.txtEnrollNumber.Name = "txtEnrollNumber";
            this.txtEnrollNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnrollNumber.Size = new System.Drawing.Size(96, 27);
            this.txtEnrollNumber.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(119, 62);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(97, 27);
            this.txtName.TabIndex = 33;
            // 
            // cmdGetUserName
            // 
            this.cmdGetUserName.BackColor = System.Drawing.SystemColors.Control;
            this.cmdGetUserName.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdGetUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdGetUserName.Location = new System.Drawing.Point(287, 94);
            this.cmdGetUserName.Name = "cmdGetUserName";
            this.cmdGetUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdGetUserName.Size = new System.Drawing.Size(137, 25);
            this.cmdGetUserName.TabIndex = 18;
            this.cmdGetUserName.Text = "Get User Name";
            this.cmdGetUserName.UseVisualStyleBackColor = false;
            this.cmdGetUserName.Click += new System.EventHandler(this.cmdGetUserName_Click);
            // 
            // cmdSetUserName
            // 
            this.cmdSetUserName.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetUserName.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetUserName.Location = new System.Drawing.Point(287, 62);
            this.cmdSetUserName.Name = "cmdSetUserName";
            this.cmdSetUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetUserName.Size = new System.Drawing.Size(137, 25);
            this.cmdSetUserName.TabIndex = 17;
            this.cmdSetUserName.Text = "Set User Name";
            this.cmdSetUserName.UseVisualStyleBackColor = false;
            this.cmdSetUserName.Click += new System.EventHandler(this.cmdSetUserName_Click);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(191, 142);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(257, 24);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "( 1-50 User message count )";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(9, 145);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(76, 19);
            this.Label2.TabIndex = 36;
            this.Label2.Text = "News  ID :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(9, 181);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(70, 19);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "Message :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Control;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessage.Location = new System.Drawing.Point(15, 14);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMessage.Size = new System.Drawing.Size(426, 33);
            this.lblMessage.TabIndex = 27;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnrollNum
            // 
            this.lblEnrollNum.AutoSize = true;
            this.lblEnrollNum.BackColor = System.Drawing.SystemColors.Control;
            this.lblEnrollNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEnrollNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnrollNum.Location = new System.Drawing.Point(9, 106);
            this.lblEnrollNum.Name = "lblEnrollNum";
            this.lblEnrollNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEnrollNum.Size = new System.Drawing.Size(105, 19);
            this.lblEnrollNum.TabIndex = 24;
            this.lblEnrollNum.Text = "Enroll Number :";
            this.lblEnrollNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(9, 70);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(53, 19);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "Name :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmUserInfo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
            this.ClientSize = new System.Drawing.Size(456, 333);
            this.Controls.Add(this.cmdSetAllUserNews);
            this.Controls.Add(this.cmdDeleteCompanyName);
            this.Controls.Add(this.cmdSetCompanyName);
            this.Controls.Add(this.cmdDeleteNewsID);
            this.Controls.Add(this.cmdClearNewsID);
            this.Controls.Add(this.cmdClearNews);
            this.Controls.Add(this.txtMessageID);
            this.Controls.Add(this.cmdSetUserNews);
            this.Controls.Add(this.cmdGetUserNews);
            this.Controls.Add(this.cmdSetNewsMessage);
            this.Controls.Add(this.cmdGetNewsMessage);
            this.Controls.Add(this.txtUserMessage);
            this.Controls.Add(this.txtEnrollNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmdGetUserName);
            this.Controls.Add(this.cmdSetUserName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblEnrollNum);
            this.Controls.Add(this.Label3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(2, 28);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		const short NAMESIZE = 400;
		private int[] glngUserName = new int[NAMESIZE];

		private void frmUserInfo_Load(object sender, System.EventArgs e)
		{
			txtEnrollNumber.Text = "1";
			txtMessageID.Text = "1";
			txtUserMessage.Text = "Thank you";
		}

		private void cmdClearNews_Click(object sender, System.EventArgs e)
		{
			int vnResultCode;

			cmdClearNews.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdClearNews.Enabled = true;;
				return;
			}

			vnResultCode = frmMain.FK_SetNewsMessage(frmMain.gnCommHandleIndex, 255, glngUserName[0].ToString());
			if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "Clear All News Message OK";
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);
			
	        frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
		    cmdClearNews.Enabled = true;;	
		}
		
		private void cmdClearNewsID_Click(object sender, System.EventArgs e)
		{
			int vEnrollNumber;
			int vMessageNumber;
			int vnResultCode;

			cmdClearNewsID.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdClearNewsID.Enabled = true;;
				return;
			}

			vEnrollNumber = 0;
			vMessageNumber = 255;
			vnResultCode = frmMain.FK_SetUserNewsID(frmMain.gnCommHandleIndex, vEnrollNumber, vMessageNumber);

			if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "Clear User NewsID OK";
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);
			
            frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
			cmdClearNewsID.Enabled = true;;	
		}
		private void cmdDeleteCompanyName_Click(object sender, System.EventArgs e)
		{
		    int vnResultCode;

			cmdDeleteCompanyName.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			if (vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdDeleteCompanyName.Enabled = true;
				return;
			}

			txtUserMessage.Text = "";
			vnResultCode = frmMain.FK_SetNewsMessage(frmMain.gnCommHandleIndex, 0, txtUserMessage.Text);
			if (vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "Delete Company Name OK";
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);
	
			frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
			cmdDeleteCompanyName.Enabled = true;
		}
		private void cmdDeleteNewsID_Click(object sender, System.EventArgs e)
		{
			int vEnrollNumber;
			int vMessageNumber;
			int vnResultCode;

			cmdDeleteNewsID.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdDeleteNewsID.Enabled = true;
				return;
			}

			vEnrollNumber = Convert.ToInt32(txtEnrollNumber.Text);
			vMessageNumber = 255;
			vnResultCode = frmMain.FK_SetUserNewsID(frmMain.gnCommHandleIndex, vEnrollNumber, vMessageNumber);
			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "Delete User NewsID OK";
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);

			frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
			cmdDeleteNewsID.Enabled = true;
		}

		private void cmdGetNewsMessage_Click(object sender, System.EventArgs e)
		{
			int vMessageNumber;
			string vNews;
			int vnResultCode;

			cmdGetNewsMessage.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdGetNewsMessage.Enabled = true;
				return;
			}

			vMessageNumber = Convert.ToInt32(txtMessageID.Text);
			vNews = new string((char)0x20, 256);
			vnResultCode = frmMain.FK_GetNewsMessage(frmMain.gnCommHandleIndex, vMessageNumber, ref vNews);
			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
			{
				txtUserMessage.Text = vNews;
				lblMessage.Text = "Get News Message OK";
			}
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);

			frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
			cmdGetNewsMessage.Enabled = true;	
		}
		private void cmdGetUserName_Click(object sender, System.EventArgs e)
		{
	        int vEnrollNumber;
			string vName;
			int vnResultCode;

			cmdGetUserName.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdGetUserName.Enabled = true;
				return;
			}

			vEnrollNumber = Convert.ToInt32(txtEnrollNumber.Text);
			vName = new string((char)0x20, 256);
			vnResultCode = frmMain.FK_GetUserName(frmMain.gnCommHandleIndex, vEnrollNumber, ref vName);
			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
			{
				txtName.Text = vName;
				lblMessage.Text = "GetUserName OK";
			}
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);
	
			frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
			cmdGetUserName.Enabled = true;	
		}

		private void cmdGetUserNews_Click(object sender, System.EventArgs e)
		{
			int vEnrollNumber;
			int vMessageNumber = 0;
			int vnResultCode;

			cmdGetUserNews.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdGetUserNews.Enabled = true;
				return;
			}

			vEnrollNumber = Convert.ToInt32(txtEnrollNumber.Text);
			vnResultCode = frmMain.FK_GetUserNewsID(frmMain.gnCommHandleIndex, vEnrollNumber, ref vMessageNumber);
			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
			{
				txtMessageID.Text = vMessageNumber.ToString();
				lblMessage.Text = "Get User News ID OK";
			}
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);

			frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
			cmdGetUserNews.Enabled = true;		
		}

		private void cmdSetCompanyName_Click(object sender, System.EventArgs e)
		{
			int vnResultCode;

			cmdSetCompanyName.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdSetCompanyName.Enabled = true;
				return;
			}

			vnResultCode = frmMain.FK_SetNewsMessage(frmMain.gnCommHandleIndex, 0, (txtUserMessage.Text).Trim());
			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "Set Company Name OK";
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);
			frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
			cmdSetCompanyName.Enabled = true;	
		}

		private void cmdSetNewsMessage_Click(object sender, System.EventArgs e)
		{
			int vMessageNumber;
			int vnResultCode;

			cmdSetNewsMessage.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdSetNewsMessage.Enabled = true;
				return;
			}

			vMessageNumber = Convert.ToInt32(txtMessageID.Text);
			vnResultCode = frmMain.FK_SetNewsMessage(frmMain.gnCommHandleIndex, vMessageNumber, (txtUserMessage.Text).Trim());
			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "Set New Message OK";
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);
			frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
			cmdSetNewsMessage.Enabled = true;
		}
		private void cmdSetUserName_Click(object sender, System.EventArgs e)
		{
			int vEnrollNumber;
			int vnResultCode;

			cmdSetUserName.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdSetUserName.Enabled = true;
				return;
			}

			vEnrollNumber = Convert.ToInt32(txtEnrollNumber.Text);
			vnResultCode = frmMain.FK_SetUserName(frmMain.gnCommHandleIndex, vEnrollNumber, (txtName.Text).Trim());
		  
			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "SetUserName OK";
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);
			frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
			cmdSetUserName.Enabled = true;	
		}

		private void cmdSetUserNews_Click(object sender, System.EventArgs e)
		{
			int vEnrollNumber;
			int vMessageNumber;
			int vnResultCode;

			cmdSetUserNews.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdSetUserNews.Enabled = true;
				return;
			}

			vEnrollNumber = Convert.ToInt32(txtEnrollNumber.Text);
			vMessageNumber = Convert.ToInt32(txtMessageID.Text);
			vnResultCode = frmMain.FK_SetUserNewsID(frmMain.gnCommHandleIndex, vEnrollNumber, vMessageNumber);

			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "Set User News  OK";
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);

			frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
			cmdSetUserNews.Enabled = true;	
		}

		private void cmdSetAllUserNews_Click(object sender, System.EventArgs e)
		{
			int vEnrollNumber;
			int vMessageNumber;
			int vnResultCode;

			cmdSetAllUserNews.Enabled = false;
			lblMessage.Text = "Working...";
			Application.DoEvents();

			vnResultCode = frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 0);
			if(vnResultCode != (int)enumErrorCode.RUN_SUCCESS)
			{
				lblMessage.Text = GlobalConstants.gstrNoDevice;
				cmdSetAllUserNews.Enabled = true;
				return;
			}
			vEnrollNumber = 0;
			vMessageNumber = Convert.ToInt32(txtMessageID.Text);
			vnResultCode = frmMain.FK_SetUserNewsID(frmMain.gnCommHandleIndex, vEnrollNumber, vMessageNumber);
			if(vnResultCode == (int)enumErrorCode.RUN_SUCCESS)
				lblMessage.Text = "Set All User News OK";
			else
				lblMessage.Text = frmMain.ReturnResultPrint(vnResultCode);

			frmMain.FK_EnableDevice(frmMain.gnCommHandleIndex, 1);
			cmdSetAllUserNews.Enabled = true;
		}
	}
}
