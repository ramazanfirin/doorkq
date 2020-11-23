using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Net;

namespace FKAttendDllCSSample
{
	/// <summary>
	/// frmMain ��ժҪ˵����
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Button cmdNetInfo;
		public System.Windows.Forms.Button cmdSetAdjustInfo;
		public System.Windows.Forms.Button cmdBellInfo;
		public System.Windows.Forms.RadioButton optSerialDevice;
		public System.Windows.Forms.RadioButton optNetworkDevice;
		public System.Windows.Forms.Button cmdCloseComm;
		public System.Windows.Forms.Button cmdProuctData;
		public System.Windows.Forms.Button cmdLogData;
		public System.Windows.Forms.GroupBox Frame3;
		internal System.Windows.Forms.Label lblComTimeOutT;
		internal System.Windows.Forms.TextBox txtComTimeOut;
		internal System.Windows.Forms.Label lblComTimeOut;
		public System.Windows.Forms.TextBox txtTelNumber;
		public System.Windows.Forms.TextBox txtWaitDialTime;
		public System.Windows.Forms.CheckBox chkUsingModem;
		public System.Windows.Forms.Label lblTelphon;
		public System.Windows.Forms.Label lblWaitTime;
		public System.Windows.Forms.Label lblS;
		public System.Windows.Forms.ComboBox cmbCommBaudRate;
		public System.Windows.Forms.ComboBox cmbComPort;
		public System.Windows.Forms.Label lblComBaudRate;
		public System.Windows.Forms.Label lblComPort;
		public System.Windows.Forms.TextBox txtMachineNumber;
		public System.Windows.Forms.GroupBox Frame2;
		internal System.Windows.Forms.Button cmdGetIP;
		public System.Windows.Forms.TextBox txtDeviceName;
		public System.Windows.Forms.Label lblDeviceName;
		internal System.Windows.Forms.CheckBox chkUDPFlag;
		public System.Windows.Forms.Label lblTimeOutT;
		public System.Windows.Forms.TextBox txtTimeOut;
		public System.Windows.Forms.Label lblTimeOut;
		public System.Windows.Forms.TextBox txtPassword;
		public System.Windows.Forms.TextBox txtPortNo;
		public System.Windows.Forms.TextBox txtIPAddress;
		public System.Windows.Forms.Label lblPassword;
		public System.Windows.Forms.Label lblPortNo;
		public System.Windows.Forms.Label lblIPAddress;
		public System.Windows.Forms.Label lblComLicense;
		public System.Windows.Forms.RadioButton optUSBDevice;
		public System.Windows.Forms.Button cmdSetPassTime;
		public System.Windows.Forms.Button cmdEnrollData;
		public System.Windows.Forms.Button cmdSystemInfo;
		public System.Windows.Forms.Button cmdOpenComm;
		public System.Windows.Forms.Button cmdUserInfo;
		public System.Windows.Forms.TextBox txtLicense;
		public System.Windows.Forms.Label lblMachineNumber;
		public System.Windows.Forms.Label lblVer;
		public System.Windows.Forms.Label lbSubject;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmdNetInfo = new System.Windows.Forms.Button();
            this.cmdSetAdjustInfo = new System.Windows.Forms.Button();
            this.cmdBellInfo = new System.Windows.Forms.Button();
            this.optSerialDevice = new System.Windows.Forms.RadioButton();
            this.optNetworkDevice = new System.Windows.Forms.RadioButton();
            this.cmdCloseComm = new System.Windows.Forms.Button();
            this.cmdProuctData = new System.Windows.Forms.Button();
            this.cmdLogData = new System.Windows.Forms.Button();
            this.Frame3 = new System.Windows.Forms.GroupBox();
            this.lblComTimeOutT = new System.Windows.Forms.Label();
            this.txtComTimeOut = new System.Windows.Forms.TextBox();
            this.lblComTimeOut = new System.Windows.Forms.Label();
            this.txtTelNumber = new System.Windows.Forms.TextBox();
            this.txtWaitDialTime = new System.Windows.Forms.TextBox();
            this.chkUsingModem = new System.Windows.Forms.CheckBox();
            this.lblTelphon = new System.Windows.Forms.Label();
            this.lblWaitTime = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.cmbCommBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.lblComBaudRate = new System.Windows.Forms.Label();
            this.lblComPort = new System.Windows.Forms.Label();
            this.txtMachineNumber = new System.Windows.Forms.TextBox();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.cmdGetIP = new System.Windows.Forms.Button();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.chkUDPFlag = new System.Windows.Forms.CheckBox();
            this.lblTimeOutT = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPortNo = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPortNo = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblComLicense = new System.Windows.Forms.Label();
            this.optUSBDevice = new System.Windows.Forms.RadioButton();
            this.cmdSetPassTime = new System.Windows.Forms.Button();
            this.cmdEnrollData = new System.Windows.Forms.Button();
            this.cmdSystemInfo = new System.Windows.Forms.Button();
            this.cmdOpenComm = new System.Windows.Forms.Button();
            this.cmdUserInfo = new System.Windows.Forms.Button();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.lblMachineNumber = new System.Windows.Forms.Label();
            this.lblVer = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.Frame3.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdNetInfo
            // 
            this.cmdNetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdNetInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdNetInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNetInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdNetInfo.Location = new System.Drawing.Point(341, 643);
            this.cmdNetInfo.Name = "cmdNetInfo";
            this.cmdNetInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdNetInfo.Size = new System.Drawing.Size(273, 40);
            this.cmdNetInfo.TabIndex = 90;
            this.cmdNetInfo.Text = "Set Net Info";
            this.cmdNetInfo.UseVisualStyleBackColor = false;
            this.cmdNetInfo.Click += new System.EventHandler(this.cmdNetInfo_Click);
            // 
            // cmdSetAdjustInfo
            // 
            this.cmdSetAdjustInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetAdjustInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetAdjustInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetAdjustInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetAdjustInfo.Location = new System.Drawing.Point(341, 587);
            this.cmdSetAdjustInfo.Name = "cmdSetAdjustInfo";
            this.cmdSetAdjustInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetAdjustInfo.Size = new System.Drawing.Size(273, 41);
            this.cmdSetAdjustInfo.TabIndex = 89;
            this.cmdSetAdjustInfo.Text = "Set AdjustInfo";
            this.cmdSetAdjustInfo.UseVisualStyleBackColor = false;
            this.cmdSetAdjustInfo.Click += new System.EventHandler(this.cmdSetAdjustInfo_Click);
            // 
            // cmdBellInfo
            // 
            this.cmdBellInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdBellInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdBellInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBellInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdBellInfo.Location = new System.Drawing.Point(341, 422);
            this.cmdBellInfo.Name = "cmdBellInfo";
            this.cmdBellInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdBellInfo.Size = new System.Drawing.Size(273, 41);
            this.cmdBellInfo.TabIndex = 79;
            this.cmdBellInfo.Text = "Bell Time";
            this.cmdBellInfo.UseVisualStyleBackColor = false;
            this.cmdBellInfo.Click += new System.EventHandler(this.cmdBellInfo_Click);
            // 
            // optSerialDevice
            // 
            this.optSerialDevice.BackColor = System.Drawing.Color.Transparent;
            this.optSerialDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.optSerialDevice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSerialDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optSerialDevice.Location = new System.Drawing.Point(34, 184);
            this.optSerialDevice.Name = "optSerialDevice";
            this.optSerialDevice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optSerialDevice.Size = new System.Drawing.Size(177, 21);
            this.optSerialDevice.TabIndex = 85;
            this.optSerialDevice.TabStop = true;
            this.optSerialDevice.Text = "Serial Device";
            this.optSerialDevice.UseVisualStyleBackColor = false;
            this.optSerialDevice.CheckedChanged += new System.EventHandler(this.optSerialDevice_CheckedChanged);
            // 
            // optNetworkDevice
            // 
            this.optNetworkDevice.BackColor = System.Drawing.Color.Transparent;
            this.optNetworkDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.optNetworkDevice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNetworkDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optNetworkDevice.Location = new System.Drawing.Point(12, -6);
            this.optNetworkDevice.Name = "optNetworkDevice";
            this.optNetworkDevice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optNetworkDevice.Size = new System.Drawing.Size(178, 24);
            this.optNetworkDevice.TabIndex = 83;
            this.optNetworkDevice.TabStop = true;
            this.optNetworkDevice.Text = "Network Device";
            this.optNetworkDevice.UseVisualStyleBackColor = false;
            this.optNetworkDevice.CheckedChanged += new System.EventHandler(this.optNetworkDevice_CheckedChanged);
            // 
            // cmdCloseComm
            // 
            this.cmdCloseComm.BackColor = System.Drawing.SystemColors.Control;
            this.cmdCloseComm.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdCloseComm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCloseComm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdCloseComm.Location = new System.Drawing.Point(482, 149);
            this.cmdCloseComm.Name = "cmdCloseComm";
            this.cmdCloseComm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdCloseComm.Size = new System.Drawing.Size(132, 39);
            this.cmdCloseComm.TabIndex = 82;
            this.cmdCloseComm.Text = "Close Comm";
            this.cmdCloseComm.UseVisualStyleBackColor = false;
            this.cmdCloseComm.Click += new System.EventHandler(this.cmdCloseComm_Click);
            // 
            // cmdProuctData
            // 
            this.cmdProuctData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdProuctData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdProuctData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProuctData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdProuctData.Location = new System.Drawing.Point(341, 368);
            this.cmdProuctData.Name = "cmdProuctData";
            this.cmdProuctData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdProuctData.Size = new System.Drawing.Size(273, 39);
            this.cmdProuctData.TabIndex = 78;
            this.cmdProuctData.Text = "Get Product Data";
            this.cmdProuctData.UseVisualStyleBackColor = false;
            this.cmdProuctData.Click += new System.EventHandler(this.cmdProuctData_Click);
            // 
            // cmdLogData
            // 
            this.cmdLogData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdLogData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdLogData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdLogData.Location = new System.Drawing.Point(341, 258);
            this.cmdLogData.Name = "cmdLogData";
            this.cmdLogData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdLogData.Size = new System.Drawing.Size(273, 40);
            this.cmdLogData.TabIndex = 76;
            this.cmdLogData.Text = "Log Data Management";
            this.cmdLogData.UseVisualStyleBackColor = false;
            this.cmdLogData.Click += new System.EventHandler(this.cmdLogData_Click);
            // 
            // Frame3
            // 
            this.Frame3.BackColor = System.Drawing.Color.Transparent;
            this.Frame3.Controls.Add(this.lblComTimeOutT);
            this.Frame3.Controls.Add(this.txtComTimeOut);
            this.Frame3.Controls.Add(this.lblComTimeOut);
            this.Frame3.Controls.Add(this.txtTelNumber);
            this.Frame3.Controls.Add(this.txtWaitDialTime);
            this.Frame3.Controls.Add(this.chkUsingModem);
            this.Frame3.Controls.Add(this.lblTelphon);
            this.Frame3.Controls.Add(this.lblWaitTime);
            this.Frame3.Controls.Add(this.lblS);
            this.Frame3.Controls.Add(this.cmbCommBaudRate);
            this.Frame3.Controls.Add(this.cmbComPort);
            this.Frame3.Controls.Add(this.lblComBaudRate);
            this.Frame3.Controls.Add(this.lblComPort);
            this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame3.Location = new System.Drawing.Point(22, 184);
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame3.Size = new System.Drawing.Size(312, 225);
            this.Frame3.TabIndex = 86;
            this.Frame3.TabStop = false;
            // 
            // lblComTimeOutT
            // 
            this.lblComTimeOutT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComTimeOutT.Location = new System.Drawing.Point(221, 95);
            this.lblComTimeOutT.Name = "lblComTimeOutT";
            this.lblComTimeOutT.Size = new System.Drawing.Size(48, 26);
            this.lblComTimeOutT.TabIndex = 49;
            this.lblComTimeOutT.Text = "(ms)";
            this.lblComTimeOutT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtComTimeOut
            // 
            this.txtComTimeOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComTimeOut.Location = new System.Drawing.Point(140, 95);
            this.txtComTimeOut.Name = "txtComTimeOut";
            this.txtComTimeOut.Size = new System.Drawing.Size(71, 26);
            this.txtComTimeOut.TabIndex = 48;
            this.txtComTimeOut.Text = "3000";
            // 
            // lblComTimeOut
            // 
            this.lblComTimeOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComTimeOut.Location = new System.Drawing.Point(25, 95);
            this.lblComTimeOut.Name = "lblComTimeOut";
            this.lblComTimeOut.Size = new System.Drawing.Size(106, 26);
            this.lblComTimeOut.TabIndex = 47;
            this.lblComTimeOut.Text = "TimeOut :";
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.AcceptsReturn = true;
            this.txtTelNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTelNumber.Location = new System.Drawing.Point(216, 152);
            this.txtTelNumber.MaxLength = 0;
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelNumber.Size = new System.Drawing.Size(74, 26);
            this.txtTelNumber.TabIndex = 45;
            this.txtTelNumber.Text = "801";
            // 
            // txtWaitDialTime
            // 
            this.txtWaitDialTime.AcceptsReturn = true;
            this.txtWaitDialTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtWaitDialTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWaitDialTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaitDialTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWaitDialTime.Location = new System.Drawing.Point(216, 186);
            this.txtWaitDialTime.MaxLength = 0;
            this.txtWaitDialTime.Name = "txtWaitDialTime";
            this.txtWaitDialTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWaitDialTime.Size = new System.Drawing.Size(49, 26);
            this.txtWaitDialTime.TabIndex = 42;
            this.txtWaitDialTime.Text = "20";
            // 
            // chkUsingModem
            // 
            this.chkUsingModem.BackColor = System.Drawing.Color.Transparent;
            this.chkUsingModem.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUsingModem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsingModem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUsingModem.Location = new System.Drawing.Point(12, 129);
            this.chkUsingModem.Name = "chkUsingModem";
            this.chkUsingModem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUsingModem.Size = new System.Drawing.Size(151, 26);
            this.chkUsingModem.TabIndex = 41;
            this.chkUsingModem.Text = "Using Modem";
            this.chkUsingModem.UseVisualStyleBackColor = false;
            this.chkUsingModem.CheckedChanged += new System.EventHandler(this.chkUsingModem_CheckedChanged);
            // 
            // lblTelphon
            // 
            this.lblTelphon.BackColor = System.Drawing.Color.Transparent;
            this.lblTelphon.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTelphon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelphon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelphon.Location = new System.Drawing.Point(133, 155);
            this.lblTelphon.Name = "lblTelphon";
            this.lblTelphon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTelphon.Size = new System.Drawing.Size(76, 22);
            this.lblTelphon.TabIndex = 46;
            this.lblTelphon.Text = "Tel No :";
            // 
            // lblWaitTime
            // 
            this.lblWaitTime.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWaitTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWaitTime.Location = new System.Drawing.Point(0, 187);
            this.lblWaitTime.Name = "lblWaitTime";
            this.lblWaitTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWaitTime.Size = new System.Drawing.Size(212, 42);
            this.lblWaitTime.TabIndex = 44;
            this.lblWaitTime.Text = "Wait Time For Dialing :";
            // 
            // lblS
            // 
            this.lblS.BackColor = System.Drawing.Color.Transparent;
            this.lblS.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblS.Location = new System.Drawing.Point(272, 190);
            this.lblS.Name = "lblS";
            this.lblS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblS.Size = new System.Drawing.Size(33, 21);
            this.lblS.TabIndex = 43;
            this.lblS.Text = "(s)";
            // 
            // cmbCommBaudRate
            // 
            this.cmbCommBaudRate.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCommBaudRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbCommBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommBaudRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCommBaudRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCommBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbCommBaudRate.Location = new System.Drawing.Point(139, 60);
            this.cmbCommBaudRate.Name = "cmbCommBaudRate";
            this.cmbCommBaudRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCommBaudRate.Size = new System.Drawing.Size(126, 27);
            this.cmbCommBaudRate.TabIndex = 24;
            // 
            // cmbComPort
            // 
            this.cmbComPort.BackColor = System.Drawing.SystemColors.Window;
            this.cmbComPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbComPort.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbComPort.Location = new System.Drawing.Point(139, 26);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbComPort.Size = new System.Drawing.Size(126, 27);
            this.cmbComPort.TabIndex = 22;
            // 
            // lblComBaudRate
            // 
            this.lblComBaudRate.AutoSize = true;
            this.lblComBaudRate.BackColor = System.Drawing.Color.Transparent;
            this.lblComBaudRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblComBaudRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComBaudRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComBaudRate.Location = new System.Drawing.Point(24, 65);
            this.lblComBaudRate.Name = "lblComBaudRate";
            this.lblComBaudRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblComBaudRate.Size = new System.Drawing.Size(84, 19);
            this.lblComBaudRate.TabIndex = 25;
            this.lblComBaudRate.Text = "Baudrate : ";
            this.lblComBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.BackColor = System.Drawing.Color.Transparent;
            this.lblComPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblComPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComPort.Location = new System.Drawing.Point(24, 30);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblComPort.Size = new System.Drawing.Size(81, 19);
            this.lblComPort.TabIndex = 23;
            this.lblComPort.Text = "ComPort : ";
            this.lblComPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMachineNumber
            // 
            this.txtMachineNumber.AcceptsReturn = true;
            this.txtMachineNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtMachineNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMachineNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMachineNumber.Location = new System.Drawing.Point(248, 106);
            this.txtMachineNumber.MaxLength = 0;
            this.txtMachineNumber.Name = "txtMachineNumber";
            this.txtMachineNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMachineNumber.Size = new System.Drawing.Size(51, 26);
            this.txtMachineNumber.TabIndex = 72;
            this.txtMachineNumber.Text = "1";
            this.txtMachineNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.Color.Transparent;
            this.Frame2.Controls.Add(this.cmdGetIP);
            this.Frame2.Controls.Add(this.txtDeviceName);
            this.Frame2.Controls.Add(this.lblDeviceName);
            this.Frame2.Controls.Add(this.chkUDPFlag);
            this.Frame2.Controls.Add(this.optNetworkDevice);
            this.Frame2.Controls.Add(this.lblTimeOutT);
            this.Frame2.Controls.Add(this.txtTimeOut);
            this.Frame2.Controls.Add(this.lblTimeOut);
            this.Frame2.Controls.Add(this.txtPassword);
            this.Frame2.Controls.Add(this.txtPortNo);
            this.Frame2.Controls.Add(this.txtIPAddress);
            this.Frame2.Controls.Add(this.lblPassword);
            this.Frame2.Controls.Add(this.lblPortNo);
            this.Frame2.Controls.Add(this.lblIPAddress);
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(22, 434);
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(312, 249);
            this.Frame2.TabIndex = 84;
            this.Frame2.TabStop = false;
            // 
            // cmdGetIP
            // 
            this.cmdGetIP.Location = new System.Drawing.Point(252, 95);
            this.cmdGetIP.Name = "cmdGetIP";
            this.cmdGetIP.Size = new System.Drawing.Size(40, 25);
            this.cmdGetIP.TabIndex = 27;
            this.cmdGetIP.Text = "...";
            this.cmdGetIP.Click += new System.EventHandler(this.cmdGetIP_Click);
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.AcceptsReturn = true;
            this.txtDeviceName.BackColor = System.Drawing.SystemColors.Window;
            this.txtDeviceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeviceName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDeviceName.Location = new System.Drawing.Point(144, 65);
            this.txtDeviceName.MaxLength = 0;
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDeviceName.Size = new System.Drawing.Size(146, 26);
            this.txtDeviceName.TabIndex = 25;
            this.txtDeviceName.Text = "FingerKeeper";
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDeviceName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeviceName.Location = new System.Drawing.Point(12, 73);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDeviceName.Size = new System.Drawing.Size(132, 21);
            this.lblDeviceName.TabIndex = 26;
            this.lblDeviceName.Text = "Device Name :";
            this.lblDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkUDPFlag
            // 
            this.chkUDPFlag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUDPFlag.Location = new System.Drawing.Point(144, 218);
            this.chkUDPFlag.Name = "chkUDPFlag";
            this.chkUDPFlag.Size = new System.Drawing.Size(77, 23);
            this.chkUDPFlag.TabIndex = 24;
            this.chkUDPFlag.Text = "UDP";
            // 
            // lblTimeOutT
            // 
            this.lblTimeOutT.AutoSize = true;
            this.lblTimeOutT.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeOutT.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTimeOutT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOutT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTimeOutT.Location = new System.Drawing.Point(221, 185);
            this.lblTimeOutT.Name = "lblTimeOutT";
            this.lblTimeOutT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimeOutT.Size = new System.Drawing.Size(38, 19);
            this.lblTimeOutT.TabIndex = 23;
            this.lblTimeOutT.Text = "(ms)";
            this.lblTimeOutT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.AcceptsReturn = true;
            this.txtTimeOut.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimeOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeOut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimeOut.Location = new System.Drawing.Point(144, 185);
            this.txtTimeOut.MaxLength = 0;
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTimeOut.Size = new System.Drawing.Size(68, 26);
            this.txtTimeOut.TabIndex = 22;
            this.txtTimeOut.Text = "5000";
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTimeOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTimeOut.Location = new System.Drawing.Point(12, 193);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimeOut.Size = new System.Drawing.Size(132, 21);
            this.lblTimeOut.TabIndex = 21;
            this.lblTimeOut.Text = "TimeOut :";
            this.lblTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(144, 145);
            this.txtPassword.MaxLength = 0;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(68, 26);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.Text = "0";
            // 
            // txtPortNo
            // 
            this.txtPortNo.AcceptsReturn = true;
            this.txtPortNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtPortNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPortNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPortNo.Location = new System.Drawing.Point(144, 106);
            this.txtPortNo.MaxLength = 0;
            this.txtPortNo.Name = "txtPortNo";
            this.txtPortNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPortNo.Size = new System.Drawing.Size(68, 26);
            this.txtPortNo.TabIndex = 13;
            this.txtPortNo.Text = "5005";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.AcceptsReturn = true;
            this.txtIPAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtIPAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIPAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIPAddress.Location = new System.Drawing.Point(144, 29);
            this.txtIPAddress.MaxLength = 0;
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIPAddress.Size = new System.Drawing.Size(146, 26);
            this.txtIPAddress.TabIndex = 12;
            this.txtIPAddress.Text = "192.168.0.25";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(12, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPassword.Size = new System.Drawing.Size(132, 20);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Password :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPortNo
            // 
            this.lblPortNo.BackColor = System.Drawing.Color.Transparent;
            this.lblPortNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPortNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPortNo.Location = new System.Drawing.Point(12, 113);
            this.lblPortNo.Name = "lblPortNo";
            this.lblPortNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPortNo.Size = new System.Drawing.Size(132, 21);
            this.lblPortNo.TabIndex = 15;
            this.lblPortNo.Text = "Port Number :";
            this.lblPortNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblIPAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIPAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIPAddress.Location = new System.Drawing.Point(12, 33);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIPAddress.Size = new System.Drawing.Size(132, 21);
            this.lblIPAddress.TabIndex = 14;
            this.lblIPAddress.Text = "IP Address :";
            this.lblIPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComLicense
            // 
            this.lblComLicense.AutoSize = true;
            this.lblComLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblComLicense.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblComLicense.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComLicense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComLicense.Location = new System.Drawing.Point(379, 109);
            this.lblComLicense.Name = "lblComLicense";
            this.lblComLicense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblComLicense.Size = new System.Drawing.Size(62, 19);
            this.lblComLicense.TabIndex = 73;
            this.lblComLicense.Text = "License :";
            // 
            // optUSBDevice
            // 
            this.optUSBDevice.BackColor = System.Drawing.Color.Transparent;
            this.optUSBDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.optUSBDevice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optUSBDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optUSBDevice.Location = new System.Drawing.Point(34, 149);
            this.optUSBDevice.Name = "optUSBDevice";
            this.optUSBDevice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optUSBDevice.Size = new System.Drawing.Size(177, 21);
            this.optUSBDevice.TabIndex = 88;
            this.optUSBDevice.TabStop = true;
            this.optUSBDevice.Text = "USB Device";
            this.optUSBDevice.UseVisualStyleBackColor = false;
            this.optUSBDevice.CheckedChanged += new System.EventHandler(this.optUSBDevice_CheckedChanged);
            // 
            // cmdSetPassTime
            // 
            this.cmdSetPassTime.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSetPassTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSetPassTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetPassTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSetPassTime.Location = new System.Drawing.Point(341, 532);
            this.cmdSetPassTime.Name = "cmdSetPassTime";
            this.cmdSetPassTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSetPassTime.Size = new System.Drawing.Size(273, 40);
            this.cmdSetPassTime.TabIndex = 87;
            this.cmdSetPassTime.Text = "Set PassTime";
            this.cmdSetPassTime.UseVisualStyleBackColor = false;
            this.cmdSetPassTime.Click += new System.EventHandler(this.cmdSetPassTime_Click);
            // 
            // cmdEnrollData
            // 
            this.cmdEnrollData.BackColor = System.Drawing.SystemColors.Control;
            this.cmdEnrollData.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdEnrollData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnrollData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdEnrollData.Location = new System.Drawing.Point(341, 204);
            this.cmdEnrollData.Name = "cmdEnrollData";
            this.cmdEnrollData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdEnrollData.Size = new System.Drawing.Size(273, 39);
            this.cmdEnrollData.TabIndex = 75;
            this.cmdEnrollData.Text = "Enroll Data Management";
            this.cmdEnrollData.UseVisualStyleBackColor = false;
            this.cmdEnrollData.Click += new System.EventHandler(this.cmdEnrollData_Click);
            // 
            // cmdSystemInfo
            // 
            this.cmdSystemInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdSystemInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdSystemInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSystemInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSystemInfo.Location = new System.Drawing.Point(341, 313);
            this.cmdSystemInfo.Name = "cmdSystemInfo";
            this.cmdSystemInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdSystemInfo.Size = new System.Drawing.Size(273, 40);
            this.cmdSystemInfo.TabIndex = 77;
            this.cmdSystemInfo.Text = "System Info Management";
            this.cmdSystemInfo.UseVisualStyleBackColor = false;
            this.cmdSystemInfo.Click += new System.EventHandler(this.cmdSystemInfo_Click);
            // 
            // cmdOpenComm
            // 
            this.cmdOpenComm.BackColor = System.Drawing.SystemColors.Control;
            this.cmdOpenComm.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdOpenComm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpenComm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdOpenComm.Location = new System.Drawing.Point(341, 149);
            this.cmdOpenComm.Name = "cmdOpenComm";
            this.cmdOpenComm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdOpenComm.Size = new System.Drawing.Size(132, 39);
            this.cmdOpenComm.TabIndex = 81;
            this.cmdOpenComm.Text = "Open Comm";
            this.cmdOpenComm.UseVisualStyleBackColor = false;
            this.cmdOpenComm.Click += new System.EventHandler(this.cmdOpenComm_Click);
            // 
            // cmdUserInfo
            // 
            this.cmdUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.cmdUserInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmdUserInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUserInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUserInfo.Location = new System.Drawing.Point(341, 478);
            this.cmdUserInfo.Name = "cmdUserInfo";
            this.cmdUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdUserInfo.Size = new System.Drawing.Size(273, 39);
            this.cmdUserInfo.TabIndex = 80;
            this.cmdUserInfo.Text = "Set UserInfo";
            this.cmdUserInfo.UseVisualStyleBackColor = false;
            this.cmdUserInfo.Click += new System.EventHandler(this.cmdUserInfo_Click);
            // 
            // txtLicense
            // 
            this.txtLicense.AcceptsReturn = true;
            this.txtLicense.BackColor = System.Drawing.SystemColors.Window;
            this.txtLicense.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicense.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicense.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLicense.Location = new System.Drawing.Point(460, 106);
            this.txtLicense.MaxLength = 0;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLicense.Size = new System.Drawing.Size(64, 26);
            this.txtLicense.TabIndex = 74;
            this.txtLicense.Text = "1263";
            this.txtLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMachineNumber
            // 
            this.lblMachineNumber.AutoSize = true;
            this.lblMachineNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblMachineNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMachineNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMachineNumber.Location = new System.Drawing.Point(85, 109);
            this.lblMachineNumber.Name = "lblMachineNumber";
            this.lblMachineNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMachineNumber.Size = new System.Drawing.Size(122, 19);
            this.lblMachineNumber.TabIndex = 71;
            this.lblMachineNumber.Text = "Machine Number :";
            // 
            // lblVer
            // 
            this.lblVer.BackColor = System.Drawing.Color.Transparent;
            this.lblVer.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVer.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblVer.Location = new System.Drawing.Point(-1, 61);
            this.lblVer.Name = "lblVer";
            this.lblVer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVer.Size = new System.Drawing.Size(643, 24);
            this.lblVer.TabIndex = 70;
            this.lblVer.Text = "FKAttend.dll (v2.8.12.6)";
            this.lblVer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSubject
            // 
            this.lbSubject.BackColor = System.Drawing.Color.Transparent;
            this.lbSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbSubject.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject.ForeColor = System.Drawing.Color.Red;
            this.lbSubject.Location = new System.Drawing.Point(-1, 16);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSubject.Size = new System.Drawing.Size(643, 34);
            this.lbSubject.TabIndex = 69;
            this.lbSubject.Text = "FKAttend.DLL C# Sample  (v2.3.5.3)";
            this.lbSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(638, 698);
            this.Controls.Add(this.cmdNetInfo);
            this.Controls.Add(this.cmdSetAdjustInfo);
            this.Controls.Add(this.cmdBellInfo);
            this.Controls.Add(this.optSerialDevice);
            this.Controls.Add(this.cmdCloseComm);
            this.Controls.Add(this.cmdProuctData);
            this.Controls.Add(this.cmdLogData);
            this.Controls.Add(this.Frame3);
            this.Controls.Add(this.txtMachineNumber);
            this.Controls.Add(this.lblComLicense);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.lblMachineNumber);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.optUSBDevice);
            this.Controls.Add(this.cmdSetPassTime);
            this.Controls.Add(this.cmdEnrollData);
            this.Controls.Add(this.cmdSystemInfo);
            this.Controls.Add(this.cmdOpenComm);
            this.Controls.Add(this.cmdUserInfo);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.lbSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu(C#.NET Sample)";
            this.Closed += new System.EventHandler(this.frmMain_Closed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Frame3.ResumeLayout(false);
            this.Frame3.PerformLayout();
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
            Application.Run(new frmMain());
		}

		public  bool gbOpenFlag;
		public  static int gnCommHandleIndex;
		public  static frmMain gfrmMain;

        
        /////////////////////////////////////////////////////////////////////
        // FKAttend dll APIs
        /////////////////////////////////////////////////////////////////////

        //{ Connection
        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_ConnectComm(
            int anMachineNo, 
            int anComPort, 
            int anBaudRate, 
			string astrTelNumber, 
            int anWaitDialTime, 
            int anLicense, 
            int anComTimeOut);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_ConnectNet(
            int anMachineNo, 
            string astrIpAddress, 
            int anNetPort, 
			int anTimeOut, 
            int anProtocolType, 
            int anNetPassword, 
            int anLicense);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_ConnectUSB(
            int anMachineNo, 
            int anLicense);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern void FK_DisConnect(int anHandleIndex);
        //} Connection

        //{ Error processing
        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetLastError(int anHandleIndex);
        //} Error processing

        //{ Device Setting
        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_EnableDevice(int anHandleIndex, byte anEnableFlag);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern void FK_PowerOnAllDevice(int anHandleIndex);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_PowerOffDevice(int anHandleIndex);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetDeviceStatus(
            int anHandleIndex, 
            int anStatusIndex, 
            ref int apnValue);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetDeviceTime(
            int anHandleIndex, 
            ref DateTime apnDateTime);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetDeviceTime(
            int anHandleIndex, 
            DateTime anDateTime);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetDeviceInfo(
            int anHandleIndex, 
            int anInfoIndex, 
            ref int apnValue);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetDeviceInfo(
            int anHandleIndex, 
            int anInfoIndex, 
            int anValue);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetProductData(
            int anHandleIndex, 
            int anDataIndex, 
            [MarshalAs(UnmanagedType.LPStr)] ref string apstrValue);
        //} Device Setting

        //{ Log Data
        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_LoadSuperLogData(int anHandleIndex, int anReadMark);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBLoadSuperLogDataFromFile(
            int anHandleIndex, 
            string astrFilePath);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetSuperLogData(
            int anHandleIndex, 
            ref int apnSEnrollNumber, 
            ref int apnGEnrollNumber,
            ref int apnMachinePrivilege, 
            ref int apnBackupNumber, 
            ref DateTime apnDateTime);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_EmptySuperLogData(int anHandleIndex);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_LoadGeneralLogData(int anHandleIndex, int anReadMark);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBLoadGeneralLogDataFromFile(
            int anHandleIndex, 
            string astrFilePath);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetGeneralLogData(
            int anHandleIndex, 
            ref int apnEnrollNumber, 
            ref int apnVerifyMode, 
			ref int apnInOutMode, 
            ref DateTime apnDateTime);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_EmptyGeneralLogData(int anHandleIndex);
        //} Log Data

        //{ Enroll Data, User Name, Message
        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_EnableUser(
            int anHandleIndex,
            int anEnrollNumber,
            int anBackupNumber,
            int anEnableFlag);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_ModifyPrivilege(
            int anHandleIndex,
            int anEnrollNumber,
            int anBackupNumber,
            int anMachinePrivilege);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_BenumbAllManager(int anHandleIndex);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_ReadAllUserID(int anHandleIndex);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetAllUserID(
            int anHandleIndex,
            ref int apnEnrollNumber,
            ref int apnBackupNumber,
            ref int apnMachinePrivilege,
            ref int apnEnable);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetEnrollData(
            int anHandleIndex,
            int anEnrollNumber,
            int anBackupNumber,
            ref int apnMachinePrivilege,
            byte [] apnEnrollData,
            ref int apnPassword);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_PutEnrollData(
            int anHandleIndex,
            int anEnrollNumber,
            int anBackupNumber,
            int anMachinePrivilege,
            byte [] apnEnrollData,
            int anPassword);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SaveEnrollData(int anHandleIndex);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_DeleteEnrollData(
            int anHandleIndex, 
            int anEnrollNumber, 
            int anBackupNumber);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_EmptyEnrollData(int anHandleIndex);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_ClearKeeperData(int anHandleIndex);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBReadAllEnrollDataFromFile(
            int anHandleIndex, 
            string astrFilePath);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetUSBModel(
            int anHandleIndex,
            int anModel);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetUDiskFileFKModel(
            int anHandleIndex,
            string strFKModel);


        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBReadAllEnrollDataCount(
            int anHandleIndex, int apnValue);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBGetOneEnrollData(
            int anHandleIndex,
            ref int apnEnrollNumber,
            ref int apnBackupNumber,
            ref int apnMachinePrivilege,
            byte [] apnEnrollData,
            ref int apnPassword,
            ref int apnEnableFlag,
            [MarshalAs(UnmanagedType.LPStr)] ref string apstrEnrollName);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBSetOneEnrollData(
            int anHandleIndex,
            int anEnrollNumber,
            int anBackupNumber,
            int anMachinePrivilege,
            byte[] apnEnrollData,
            int anPassword,
            int anEnableFlag,
            string astrEnrollName);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBWriteAllEnrollDataToFile(
            int anHandleIndex,
            string astrFilePath);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBReadAllEnrollDataFromFile_Color(
            int anHandleIndex,
            string astrFilePath);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBWriteAllEnrollDataToFile_Color(
            int anHandleIndex,
            string astrFilePath,
            long anNewsKind);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBGetOneEnrollData_Color(
            int anHandleIndex,
            ref int apnEnrollNumber,
            ref int apnBackupNumber,
            ref int apnMachinePrivilege,
            byte[] apnEnrollData,
            ref int apnPassWord,
            ref int apnEnableFlag,
            [MarshalAs(UnmanagedType.LPStr)] ref string apstrEnrollName,
            int anNewsKind);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBSetOneEnrollData_Color(
            int anHandleIndex,
            int anEnrollNumber,
            int anBackupNumber,
            int anMachinePrivilege,
            byte [] apnEnrollData,
            int anPassWord,
            int anEnableFlag,
            string astrEnrollName,
            int anNewsKind);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetUserName(
            int anHandleIndex, 
            int anEnrollNumber,
            [MarshalAs(UnmanagedType.LPStr)] ref string apstrUserName);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetUserName(
            int anHandleIndex, 
            int anEnrollNumber, 
            string astrUserName);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetNewsMessage(
            int anHandleIndex, 
            int anNewsId,
            [MarshalAs(UnmanagedType.LPStr)] ref string apstrNews);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetNewsMessage(
            int anHandleIndex, 
            int anNewsId, 
            string astrNews);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetUserNewsID(
            int anHandleIndex, 
            int anEnrollNumber, 
            ref int apnNewsId);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetUserNewsID(
            int anHandleIndex, 
            int anEnrollNumber, 
            int anNewsId);
        //} Enroll Data, User Name, Message

        //{ BELL setting
        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetBellTime(
            int anHandleIndex,
            ref int apnBellCount,
            byte [] apnBellInfo);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetBellTime(
            int anHandleIndex,
            int anBellCount,
            byte[] apnBellInfo);
        //} BELL setting

        //{ Access Control
        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetDoorStatus(int anHandleIndex, ref int apnStatusVal);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetDoorStatus(int anHandleIndex, int anStatusVal);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetPassTime(
            int anHandleIndex,
            int anPassTimeID,
            byte [] apnPassTime,
            int anPassTimeSize);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetPassTime(
            int anHandleIndex,
            int anPassTimeID,
            byte [] apnPassTime,
            int anPassTimeSize);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetUserPassTime(
            int anHandleIndex,
            int anEnrollNumber,
            ref int apnGroupID,
            byte [] apnUserPassTimeInfo,
            int anUserPassTimeInfoSize);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetUserPassTime(
            int anHandleIndex,
            int anEnrollNumber,
            int anGroupID,
            byte[] apnUserPassTimeInfo,
            int anUserPassTimeInfoSize);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetGroupPassTime(
            int anHandleIndex,
            int anGroupID,
            byte [] apnGroupPassTimeInfo,
            int anGroupPassTimeInfoSize);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetGroupPassTime(
            int anHandleIndex,
            int anGroupID,
            byte[] apnGroupPassTimeInfo,
            int anGroupPassTimeInfoSize);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetGroupMatch(
            int nHandleIndex,
            byte [] apnGroupMatchInfo,
            int anGroupMatchInfoSize);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetGroupMatch(
            int nHandleIndex,
            byte[] apnGroupMatchInfo,
            int anGroupMatchInfoSize);
        //} Access Control

        //{ Etc Functions
        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)] 
        public static extern int FK_GetAdjustInfo(
            int nHandleIndex, 
            ref int apnAdjustedState,
            ref int apnAdjustedMonth,
            ref int apnAdjustedDay,
            ref int apnAdjustedHour,
            ref int apnAdjustedMinute,
            ref int apnRestoredState,
            ref int apnRestoredMonth,
            ref int apnRestoredDay,
            ref int apnRestoredHour,
            ref int apnRestoredMinte);

		[DllImport("FKAttend.dll", CharSet = CharSet.Ansi)] 
        public static extern int FK_SetAdjustInfo(
            int anHandleIndex, 
            int anAdjustedState,
            int anAdjustedMonth,
            int anAdjustedDay,
            int anAdjustedHour,
            int anAdjustedMinute,
            int anRestoredState,
            int anRestoredMonth,
            int anRestoredDay,
            int anRestoredHour,
            int anRestoredMinte);
        
		[DllImport("FKAttend.dll", CharSet = CharSet.Ansi)] 
        public static extern int FK_GetAccessTime(
            int nHandleIndex, 
            int anEnrollNumber, 
            ref int apnAccessTime);

		[DllImport("FKAttend.dll", CharSet = CharSet.Ansi)] 
        public static extern int FK_SetAccessTime(
            int nHandleIndex, 
            int anEnrollNumber, 
            int anAccessTime);

		[DllImport("FKAttend.dll", CharSet = CharSet.Ansi)] 
        public static extern int FK_SetFontName(
            int nHandleIndex, 
            string aStrFontName, 
            int anFontType);

		[DllImport("FKAttend.dll", CharSet = CharSet.Ansi)] 
        public static extern int FK_GetRealTimeInfo(
            int anHandleIndex, 
            byte [] apnRealTimeInfo);

		[DllImport("FKAttend.dll", CharSet = CharSet.Ansi)] 
        public static extern int FK_SetRealTimeInfo(
            int anHandleIndex,
            byte [] apnRealTimeInfo);

		[DllImport("FKAttend.dll", CharSet = CharSet.Ansi)] 
        public static extern int FK_GetServerNetInfo(
            int anHandleIndex,
            [MarshalAs(UnmanagedType.LPStr)] ref string apstrServerIPAddress, 
			ref int apnServerPort, 
            ref int apnServerRequest);

		[DllImport("FKAttend.dll", CharSet = CharSet.Ansi)] 
        public static extern int FK_SetServerNetInfo(
            int nHandleIndex, 
            string astrServerIPAddress, 
            int anServerPort, 
			int anServerRequest);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_USBConvertDataFromBSToSDK(
            int anHandleIndex,
            int anBackupNumber,
            string apstrEnrollData,
            int anstrEnrollSize,
            byte[] apnEnrollData,
            long anBufferSize);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_GetEnrollPhoto(
            int anHandleIndex,
            int apEnrollNumber,
            byte[] apPhotoImage, 
            ref int apnPhotoLength);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_SetEnrollPhoto(
            int anHandleIndex,
            int apEnrollNumber,
            byte[] apPhotoImage, 
            int apnPhotoLength);

        [DllImport("FKAttend.dll", CharSet = CharSet.Ansi)]
        public static extern int FK_DeleteEnrollPhoto(
            int anHandleIndex,
            int apEnrollNumber);
        //} Etc Functions

		public static bool IsNumeric(string str)
		{
			try
			{
				Convert.ToInt32(str);
			}
			catch
			{
				return false;
			}
			return true;
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			
			gfrmMain = this;
			gnCommHandleIndex = 0;
			optSerialDevice.Checked = false;
            optNetworkDevice.Checked = false;
            optUSBDevice.Checked = true;
			optNetworkDevice_CheckedChanged(optNetworkDevice, e);
			enableButtons(false);
			gbOpenFlag = false;
			txtMachineNumber.Text = "1";
			cmbComPort.SelectedIndex = 0;
			cmbCommBaudRate.SelectedIndex = 2;
		}

		private void frmMain_Closed(object sender, System.EventArgs e)
		{
			cmdCloseComm_Click(cmdCloseComm, new System.EventArgs());
		}
		
        private void cmdOpenComm_Click(object sender, System.EventArgs e)
		{
			int vnMachineNumber;
			int vnCommPort;
			int vnCommBaudrate;
			string vstrTelNumber = "";
			int vnWaitDialTime = 3000;
			int vnLicense;
			string vpszIPAddress;
			int vpszNetPort;
			int vpszNetPassword;
			int vnTimeOut;
			int vnProtocolType;
			long vnResultCode = (long)enumErrorCode.RUNERR_UNKNOWNERROR;
			
			cmdOpenComm.Enabled = false;
			vnMachineNumber = Convert.ToInt32(txtMachineNumber.Text);
			vnLicense = Convert.ToInt32(txtLicense.Text);

			if (optSerialDevice.Checked == true)
			{
				if (chkUsingModem.Checked == true)
				{
					vstrTelNumber = (txtTelNumber.Text).Trim();
					vnWaitDialTime =  Convert.ToInt32((txtWaitDialTime.Text).Trim());
					if (vnWaitDialTime < 10 && vnWaitDialTime > 60)
					{
						vnWaitDialTime = 10;
						txtWaitDialTime.Text = "10";
					}
					else
					{
						vstrTelNumber = "";
						vnWaitDialTime = 0;
					}
				}
                    
				vnCommPort =  Convert.ToInt32((cmbComPort.Text).Trim());
				vnCommBaudrate =  Convert.ToInt32((cmbCommBaudRate.Text).Trim());
				vnTimeOut =  Convert.ToInt32((txtComTimeOut.Text).Trim());
				gnCommHandleIndex = FK_ConnectComm(vnMachineNumber, vnCommPort, vnCommBaudrate, vstrTelNumber, vnWaitDialTime, vnLicense, vnTimeOut);
			}
			else if (optNetworkDevice.Checked == true)
			{
				vpszIPAddress = (txtIPAddress.Text).Trim();
				vpszNetPort =  Convert.ToInt32(txtPortNo.Text);
                    
				vpszNetPassword =  Convert.ToInt32(txtPassword.Text);
				vnTimeOut =  Convert.ToInt32(txtTimeOut.Text);
				if (chkUDPFlag.Checked == false)
					vnProtocolType = (int)enumProtocolType.PROTOCOL_TCPIP;
				else
					vnProtocolType = (int)enumProtocolType.PROTOCOL_UDP;
					
				gnCommHandleIndex = FK_ConnectNet(vnMachineNumber, vpszIPAddress, vpszNetPort, vnTimeOut, vnProtocolType, vpszNetPassword, vnLicense);
			}
			else if (optUSBDevice.Checked == true)
			{
				gnCommHandleIndex = FK_ConnectUSB(vnMachineNumber, vnLicense);
			}

			if (gnCommHandleIndex >0)
			{
				gbOpenFlag = true;
				enableButtons(true);
			}
			else
			{
				vnResultCode = gnCommHandleIndex;
				MessageBox.Show(ReturnResultPrint(vnResultCode), "error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				cmdOpenComm.Enabled = true;
			}
		}

		private void cmdCloseComm_Click(object sender, System.EventArgs e)
		{
			if(gbOpenFlag == true)
			{
				FK_DisConnect(gnCommHandleIndex);
				gbOpenFlag = false;
				enableButtons(false);
			}
		}

		private void cmdEnrollData_Click(object sender, System.EventArgs e)
		{
			showChildForm(new frmEnroll());
		}

		private void cmdLogData_Click(object sender, System.EventArgs e)
		{
			showChildForm(new frmLog());
		}

		private void cmdSystemInfo_Click(object sender, System.EventArgs e)
		{
			showChildForm(new frmSystemInfo());
		}

		private void cmdProuctData_Click(object sender, System.EventArgs e)
		{
			showChildForm(new frmProductData());
		}

		private void cmdBellInfo_Click(object sender, System.EventArgs e)
		{
			showChildForm(new frmBellInfo());
		}

		private void cmdUserInfo_Click(object sender, System.EventArgs e)
		{
			showChildForm(new frmUserInfo());
		}

		private void cmdSetPassTime_Click(object sender, System.EventArgs e)
		{
			showChildForm(new frmPasstimeInfo());
		}

		private void cmdSetAdjustInfo_Click(object sender, System.EventArgs e)
		{
			showChildForm(new frmAdjust());
		}

		private void cmdNetInfo_Click(object sender, System.EventArgs e)
		{
			showChildForm(new frmNetInfo());	
		}

		private void showChildForm(Form afrmChild)
		{
			if(afrmChild != null)
			{
				this.Hide();
				afrmChild.Owner = this;
				afrmChild.ShowDialog();
				afrmChild.Dispose();
				this.Show();
			}
		}
		
		private void enableButtons(bool abEnableFlag)
		{
			cmdOpenComm.Enabled = !abEnableFlag;
			cmdCloseComm.Enabled = abEnableFlag;
			cmdSystemInfo.Enabled = abEnableFlag;
			cmdProuctData.Enabled = abEnableFlag;
			cmdBellInfo.Enabled = abEnableFlag;
			cmdUserInfo.Enabled = abEnableFlag;
			cmdSetPassTime.Enabled = abEnableFlag;
			cmdSetAdjustInfo.Enabled = abEnableFlag;
			cmdNetInfo.Enabled = abEnableFlag;
			optSerialDevice.Enabled = !abEnableFlag;
			optNetworkDevice.Enabled = !abEnableFlag;
			optUSBDevice.Enabled = !abEnableFlag;
		}
		
        private void enableControls(long anEnableFlag)
		{
			lblComPort.Enabled = false;
			cmbComPort.Enabled = false;
			lblComBaudRate.Enabled = false;
			cmbCommBaudRate.Enabled = false;
			chkUsingModem.Enabled = false;
			lblTelphon.Enabled = false;
			txtTelNumber.Enabled = false;
			lblWaitTime.Enabled = false;
			txtWaitDialTime.Enabled = false;
			lblS.Enabled = false;
			txtComTimeOut.Enabled = false;
			lblComTimeOut.Enabled = false;
			lblComTimeOutT.Enabled = false;

			lblIPAddress.Enabled = false;
			txtIPAddress.Enabled = false;
			lblDeviceName.Enabled = false;
			txtDeviceName.Enabled = false;
			lblPortNo.Enabled = false;
			txtPortNo.Enabled = false;
			lblPassword.Enabled = false;
			txtPassword.Enabled = false;
			lblTimeOut.Enabled = false;
			txtTimeOut.Enabled = false;
			lblTimeOutT.Enabled = false;																																																																																															   
			chkUDPFlag.Enabled = false;

			switch (anEnableFlag)
			{
				case 1:
				{
					lblComPort.Enabled = true;
					cmbComPort.Enabled = true;
					lblComBaudRate.Enabled = true;
					cmbCommBaudRate.Enabled = true;
					txtComTimeOut.Enabled = true;
					lblComTimeOut.Enabled = true;
					lblComTimeOutT.Enabled = true;
					chkUsingModem.Enabled = true;
					if( chkUsingModem.Checked)
					{
						lblTelphon.Enabled = true;
						txtTelNumber.Enabled = true;
						lblWaitTime.Enabled = true;
						txtWaitDialTime.Enabled = true;
						lblS.Enabled = true;
					}
				}
				break;		
				case 2:
				{
					lblIPAddress.Enabled = true;
					txtIPAddress.Enabled = true;
					lblDeviceName.Enabled = true;
					txtDeviceName.Enabled = true;
					lblPortNo.Enabled = true;
					txtPortNo.Enabled = true;
					lblPassword.Enabled = true;
					txtPassword.Enabled = true;
					lblTimeOut.Enabled = true;
					txtTimeOut.Enabled = true;
					lblTimeOutT.Enabled = true;
					chkUDPFlag.Enabled = true;
				}
				break;		
			}			
		}

		private void optNetworkDevice_CheckedChanged(object sender, System.EventArgs e)
		{
            if (optNetworkDevice.Checked)
            {
                optSerialDevice.Checked = false;
                optUSBDevice.Checked = false;
                enableControls(2);
            }
		}

		private void optUSBDevice_CheckedChanged(object sender, System.EventArgs e)
		{
            if (optUSBDevice.Checked)
            {
                optSerialDevice.Checked = false;
                optNetworkDevice.Checked = false;
                enableControls(3);
            }
		}

		private void chkUsingModem_CheckedChanged(object sender, System.EventArgs e)
		{
			if(optSerialDevice.Checked)
				enableControls(1);
		}

		private void optSerialDevice_CheckedChanged(object sender, System.EventArgs e)
		{
            if (optSerialDevice.Checked)
            {
                optUSBDevice.Checked = false;
                optNetworkDevice.Checked = false;
                enableControls(1);
            }
		}
		
        public static string ReturnResultPrint(long anResultCode)
		{
			switch(anResultCode)
			{
				case  (long)enumErrorCode.RUN_SUCCESS:
					return "Successful!";
				case  (long)enumErrorCode.RUNERR_NOSUPPORT:
					return "No support";
				case  (long)enumErrorCode.RUNERR_UNKNOWNERROR:
					return "Unknown error";
				case  (long)enumErrorCode.RUNERR_NO_OPEN_COMM:
					return "No Open Comm";
				case  (long)enumErrorCode.RUNERR_WRITE_FAIL:
					return "Write Error";
				case  (long)enumErrorCode.RUNERR_READ_FAIL:
					return "Read Error";
				case  (long)enumErrorCode.RUNERR_INVALID_PARAM:
					return "Parameter Error";
				case  (long)enumErrorCode.RUNERR_NON_CARRYOUT:
					return "execution of command failed";
				case  (long)enumErrorCode.RUNERR_DATAARRAY_END:
					return "End of data";
				case  (long)enumErrorCode.RUNERR_DATAARRAY_NONE:
					return "Nonexistence data";
				case  (long)enumErrorCode.RUNERR_MEMORY:
					return "Memory Allocating Error";
				case  (long)enumErrorCode.RUNERR_MIS_PASSWORD:
					return "License Error";
				case  (long)enumErrorCode.RUNERR_MEMORYOVER:
					return "full enrolldata & can`t put enrolldata";
				case  (long)enumErrorCode.RUNERR_DATADOUBLE:
					return "this ID is already  existed.";
				case  (long)enumErrorCode.RUNERR_MANAGEROVER:
					return "full manager & can`t put manager.";
				case  (long)enumErrorCode.RUNERR_FPDATAVERSION:
					return "mistake fp data version.";
				default:
					return "Unknown error";
			}
		}

        public static object ConvertByteArrayToStructure(byte [] aByteArray, System.Type aType)
        {
            object vObject;
            IntPtr vptr;
            try
            {
                int vnSize = Marshal.SizeOf(aType);
                if (aByteArray.Length < vnSize)
                    return null;
                vptr = Marshal.AllocHGlobal(vnSize);
                Marshal.Copy(aByteArray, 0, vptr, vnSize);
                vObject = Marshal.PtrToStructure(vptr, aType);    
                Marshal.FreeHGlobal(vptr);
                return vObject;
            }
            catch (System.Exception)
            {
                MessageBox.Show(
                        "Fail to convert byte array to structure",
                        "FKAttendDLLCSSample",
                        MessageBoxButtons.OK);
                return null;
            }
        }

        public static void ConvertStructureToByteArray(object aStruct, byte[] aByteArray)
        {
            try
            {
                IntPtr vptr = IntPtr.Zero;
			    int vnSize = Marshal.SizeOf(aStruct);
                if (aByteArray.Length < vnSize)
                    return;
                vptr = Marshal.AllocHGlobal(vnSize);
                Marshal.StructureToPtr(aStruct, vptr, false);
                Marshal.Copy(vptr, aByteArray, 0, vnSize);
                Marshal.FreeHGlobal(vptr);
                return;
            }
            catch (System.Exception)
            {
            	MessageBox.Show(
                        "Fail to convert structure to byte array",
                        "FKAttendDLLCSSample",
                        MessageBoxButtons.OK);
                return;
            }
        }

        private void cmdGetIP_Click(object sender, EventArgs e)
        {
            try
            {
                // Host Name resolution to IP
                IPHostEntry host = Dns.GetHostEntry(txtDeviceName.Text.Trim());
                IPAddress[] ipaddr = host.AddressList;
                                
                txtIPAddress.Text = ipaddr[0].ToString();                
            }
            // Catch unknown host names
            catch (System.Net.Sockets.SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static String GetStringVerifyMode(Int32 nVerifyMode)
        {
            String vRet = "";
            int vByteCount = 4;
            byte[] vbyteKind = new byte[vByteCount];
            int vFirstKind, vSecondKind;
            vbyteKind = BitConverter.GetBytes(nVerifyMode);
            for (int nIndex = vByteCount - 1; nIndex >= 0; nIndex--)
            {
                vFirstKind = vSecondKind = vbyteKind[nIndex];
                vFirstKind = vFirstKind & 0xF0;
                vSecondKind = vSecondKind & 0x0F;
                vFirstKind = vFirstKind >> 4;
                if (vFirstKind == 0) break;
                if (nIndex < vByteCount - 1)
                    vRet += "+";
                switch (vFirstKind)
                {
                    case (int)enumVerifyKind.VK_FP: vRet += "FP"; break;
                    case (int)enumVerifyKind.VK_PASS: vRet += "PASS"; break;
                    case (int)enumVerifyKind.VK_CARD: vRet += "CARD"; break;
                    case (int)enumVerifyKind.VK_FACE: vRet += "FACE"; break;
                    case (int)enumVerifyKind.VK_FINGERVEIN: vRet += "FINGER VEIN"; break;
                    case (int)enumVerifyKind.VK_IRIS: vRet += "IRIS"; break;
                    case (int)enumVerifyKind.VK_VOICE: vRet += "VOICE"; break;
                    case (int)enumVerifyKind.VK_PALMVEIN: vRet += "PALM VEIN"; break;
                    case (int)enumVerifyKind.VK_VFACE: vRet += "VFACE"; break;
                }
                if (vSecondKind == 0) break;
                vRet += "+";
                switch (vSecondKind)
                {
                    case (int)enumVerifyKind.VK_FP: vRet += "FP"; break;
                    case (int)enumVerifyKind.VK_PASS: vRet += "PASS"; break;
                    case (int)enumVerifyKind.VK_CARD: vRet += "CARD"; break;
                    case (int)enumVerifyKind.VK_FACE: vRet += "FACE"; break;
                    case (int)enumVerifyKind.VK_FINGERVEIN: vRet += "FINGER VEIN"; break;
                    case (int)enumVerifyKind.VK_VOICE: vRet += "VOICE"; break;
                    case (int)enumVerifyKind.VK_PALMVEIN: vRet += "PALM VEIN"; break;
                    case (int)enumVerifyKind.VK_VFACE: vRet += "VFACE"; break;
                }
            }
            //nVerifyMode.
            if (vRet == "") vRet = "--";
            return vRet;
        }

        public static void GetIoModeAndDoorMode(Int32 nIoMode, ref int vIoMode, ref int vDoorMode)
        {
            int vByteCount = 4;
            byte[] vbyteKind = new byte[vByteCount];
            byte[] vbyteDoorMode = new byte[vByteCount];
            vbyteKind = BitConverter.GetBytes(nIoMode);
            vIoMode = vbyteKind[0];
            for (int nIndex = 0; nIndex < 3; nIndex++)
            {
                vbyteDoorMode[nIndex] = vbyteKind[nIndex + 1];
            }
            vbyteDoorMode[3] = 0;
            vDoorMode = BitConverter.ToInt32(vbyteDoorMode, 0);


        }

	}
}
