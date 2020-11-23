public class Ast2500CSDll : Form
{
    // Fields
    private const string ALERT_TITLE = "Ast2500 C# dll Sample";
    private const int CapFp_GoodFpCaptured = 2;
    private const int CapFp_Identify_OK = 4;
    private const int CapFp_Init = 0;
    private const int CapFp_PromptTakeoffFinger = 3;
    private const int CapFp_WaitPressFinger = 1;
    private Button ClearBtn;
    private const int ColorTableEntries = 0x100;
    private ComboBox ComboDevice;
    private PictureBox CompanyMarkImage;
    private IContainer components;
    private const int DEFAULT_FP_SIZE = 0x690;
    private Button DeleteBtn;
    private Label DevicesTxt;
    private Button EnrollBtn;
    private NumericUpDown EnrollIDTxt;
    private Label EnrollTxt;
    private Button ExitBtn;
    private const int FEATURE_SIZE = 0x12d0;
    private PictureBox fpImage;
    private Panel FpImagePanel;
    private Button GetCheckedImageBtn;
    private Button GetCountBtn;
    private Button GetRawImageBtn;
    private const int GoodEnrollFpArea = 0x2e;
    private Label IdentifiedTxt;
    private Button IdentifyBtn;
    private TextBox IdentifyIDTxt;
    private const int IMAGE_SIZE = 0x10000;
    private Button InitBtn;
    private bool m_bStopFlag;
    private int m_nCapFpStatus;
    private int m_nContextID;
    private int m_nContinuosFpPressCount;
    private string m_nDevId;
    private bool m_nDoubleCheckFlag;
    private int m_nFeatureSize;
    private int m_nFpArea;
    private int m_nFpExtractCount;
    private int m_nID;
    private int m_nIdentifiedID;
    private int m_nImaHeight;
    private int m_nImaRes;
    private int m_nImaWidth;
    private int m_nIsFpImg;
    private int m_nMaxFpArea;
    private int m_nTemplateSize;
    private int m_nUpdatedFlag;
    private byte[] m_pBmpByteBuffer = new byte[0x5fa6c];
    private byte[] m_pMemFeatureBuffer_1 = new byte[0x12d0];
    private byte[] m_pMemFeatureBuffer_2 = new byte[0x12d0];
    private byte[] m_pMemFeatureBuffer_3 = new byte[0x12d0];
    private byte[] m_pMemImgBuffer = new byte[0x10000];
    private byte[] m_pMemMaxAreaFpBuffer = new byte[0x10000];
    private byte[] m_pMemTemplateBuffer = new byte[720];
    private byte[] m_pMemTemplateUpdateBuffer = new byte[720];
    private string[] m_pStrDevId = new string[4];
    private string[] m_pStrDevName = new string[4];
    internal Timer nEnrollTimer;
    internal Timer nGetFpImageTimer;
    internal Timer nIdentifyTimer;
    internal Timer nVerifyTimer;
    private const int PIS_ACT = 1;
    private const int PIS_INIT = 0;
    private Label StaticMSG;
    private Button StopBtn;
    private const int TEMPLATE_SIZE = 720;
    private Button VerifyBtn;

    // Methods
    public Ast2500CSDll()
    {
        this.InitializeComponent();
    }

    private void Ast2500CSDll_FormClosed(object sender, FormClosedEventArgs e)
    {
        this.ExitBtn_Click(sender, e);
    }

    private void Ast2500CSDll_Load(object sender, EventArgs e)
    {
        this.EnableButtons(0, false);
        this.InitBtn.Enabled = false;
        this.EnumAst2500Devices();
        this.nGetFpImageTimer.Enabled = false;
        this.nIdentifyTimer.Enabled = false;
        this.nEnrollTimer.Enabled = false;
        this.nVerifyTimer.Enabled = false;
        this.m_bStopFlag = false;
    }

    private Image Byte2Image(int anBkgGray)
    {
        int num = 0x36;
        for (int i = 0; i < 0x10000; i++)
        {
            this.m_pBmpByteBuffer[num + (i * 3)] = (byte) anBkgGray;
            this.m_pBmpByteBuffer[(num + (i * 3)) + 1] = (byte) anBkgGray;
            this.m_pBmpByteBuffer[(num + (i * 3)) + 2] = (byte) anBkgGray;
        }
        MemoryStream stream = new MemoryStream(this.m_pBmpByteBuffer);
        return Image.FromStream(stream);
    }

    private Image Byte2Image(byte[] byteFpImage)
    {
        int num = 0x36;
        for (int i = 0; i < byteFpImage.Length; i++)
        {
            this.m_pBmpByteBuffer[num + (i * 3)] = byteFpImage[(byteFpImage.Length - i) - 1];
            this.m_pBmpByteBuffer[(num + (i * 3)) + 1] = byteFpImage[(byteFpImage.Length - i) - 1];
            this.m_pBmpByteBuffer[(num + (i * 3)) + 2] = byteFpImage[(byteFpImage.Length - i) - 1];
        }
        if (byteFpImage.GetUpperBound(0) > 0)
        {
            MemoryStream stream = new MemoryStream(this.m_pBmpByteBuffer);
            return Image.FromStream(stream);
        }
        return null;
    }

    private void ClearBtn_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure to delete all data?", "Ast2500 C# dll Sample", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
        {
            if (mdFunction.pisClearTptArray(this.m_nContextID) != 0)
            {
                this.ShowStatusMsg("Error! Fail to clear template array");
            }
            else
            {
                mdFunction.pisClearTptArray(this.m_nContextID);
                string path = Directory.GetCurrentDirectory() + @"\templateDB\";
                string searchPattern = "*.dat";
                try
                {
                    foreach (string str3 in Directory.GetFiles(path, searchPattern))
                    {
                        File.Delete(str3);
                    }
                }
                catch (Exception)
                {
                }
                this.ShowStatusMsg("OK! Clear template array!");
            }
        }
    }

    private void ClearFpImage()
    {
        int anBkgGray = 240;
        this.fpImage.Image = this.Byte2Image(anBkgGray);
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        int @int = mdFunction.GetInt(this.EnrollIDTxt.Text);
        if (MessageBox.Show("Are you sure to delete Id :" + Convert.ToString(@int), "Ast2500 C# dll Sample", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
        {
            if (@int < 1)
            {
                MessageBox.Show("Delete Enroll ID correctly !", "Ast2500 C# dll Sample", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (mdFunction.pisGetAtTptArray(this.m_nContextID, @int, this.m_pMemTemplateBuffer) != 0)
            {
                this.ShowStatusMsg("Not Exist (" + Convert.ToString(@int) + ");! Try another number");
            }
            else if (mdFunction.pisDeleteAtTptArray(this.m_nContextID, @int) != 0)
            {
                this.ShowStatusMsg("Error! Fail to delete one template from template array(ID=" + Convert.ToString(@int) + ")");
            }
            else
            {
                string astrDir = Directory.GetCurrentDirectory() + @"\templateDB";
                string astrFile = Convert.ToString(@int) + ".dat";
                this.DeleteFpTemplate(astrDir, astrFile);
                this.ShowStatusMsg("OK! Delete one template from template array(ID=" + Convert.ToString(@int) + ")");
            }
        }
    }

    private void DeleteFpTemplate(string astrDir, string astrFile)
    {
        File.Delete(astrDir + @"\" + astrFile);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void DrawFpImage(byte[] byteFpImage, bool IsSaved)
    {
        this.fpImage.Image = this.Byte2Image(byteFpImage);
    }

    private void EnableButtons(int Kind, bool Flag)
    {
        if (Kind == 0)
        {
            this.InitBtn.Enabled = !Flag;
            this.ExitBtn.Enabled = Flag;
            this.EnrollBtn.Enabled = Flag;
            this.DeleteBtn.Enabled = Flag;
            this.ClearBtn.Enabled = Flag;
            this.GetCountBtn.Enabled = Flag;
            this.IdentifyBtn.Enabled = Flag;
            this.VerifyBtn.Enabled = Flag;
            this.GetCheckedImageBtn.Enabled = Flag;
            this.GetRawImageBtn.Enabled = Flag;
        }
        else if (Kind == 1)
        {
            this.ExitBtn.Enabled = true;
            this.EnrollBtn.Enabled = Flag;
            this.DeleteBtn.Enabled = Flag;
            this.ClearBtn.Enabled = Flag;
            this.GetCountBtn.Enabled = Flag;
            this.IdentifyBtn.Enabled = Flag;
            this.VerifyBtn.Enabled = Flag;
            this.GetCheckedImageBtn.Enabled = Flag;
            this.GetRawImageBtn.Enabled = Flag;
        }
    }

    private void EnrollBtn_Click(object sender, EventArgs e)
    {
        this.m_nID = mdFunction.GetInt(this.EnrollIDTxt.Text);
        if (this.m_nID < 1)
        {
            MessageBox.Show("Input Enroll ID correctly !", "Ast2500 C# dll Sample", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (mdFunction.pisGetAtTptArray(this.m_nContextID, this.m_nID, this.m_pMemTemplateBuffer) == 0)
        {
            MessageBox.Show("Enroll ID (" + Convert.ToString(this.m_nID) + ") already used ! Try another number", "Ast2500 C# dll Sample", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
            this.EnableButtons(1, false);
            this.nEnrollTimer.Enabled = true;
            this.m_bStopFlag = false;
            this.m_nDoubleCheckFlag = true;
            this.m_nFpExtractCount = 0;
            this.m_nContinuosFpPressCount = 0;
            this.m_nFpExtractCount = 0;
            this.m_nCapFpStatus = 0;
            this.m_nMaxFpArea = 0;
        }
    }

    private void EnumAst2500Devices()
    {
        byte[] devId = new byte[0xff];
        byte[] devName = new byte[0xff];
        byte[] destinationArray = new byte[0xff];
        for (int i = 0; i < 4; i++)
        {
            if (mdFunction.pisEnumerateDevice(i, devId, devName) == 0)
            {
                Array.Copy(devId, destinationArray, 0xff);
                this.m_pStrDevId[i] = mdFunction.ByteArrayUtf8ToString(destinationArray);
                Array.Copy(devName, destinationArray, 0xff);
                this.m_pStrDevName[i] = mdFunction.ByteArrayUtf8ToString(destinationArray);
                this.ComboDevice.Items.Add(this.m_pStrDevName[i]);
            }
        }
        if (this.ComboDevice.Items.Count > 0)
        {
            this.ComboDevice.SelectedIndex = 0;
            this.InitBtn.Enabled = true;
        }
        else
        {
            this.InitBtn.Enabled = false;
        }
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        this.m_bStopFlag = true;
        this.EnableButtons(1, true);
        this.nGetFpImageTimer.Enabled = false;
        this.nIdentifyTimer.Enabled = false;
        this.nEnrollTimer.Enabled = false;
        this.nVerifyTimer.Enabled = false;
        if (mdFunction.pisCloseDevice(this.m_nContextID) != 0)
        {
            this.ShowStatusMsg("Error! pisCloseDevice failed!");
        }
        if (mdFunction.pisDestroyContext(this.m_nContextID) != 0)
        {
            this.ShowStatusMsg("Error! pisDestroyContext failed!");
        }
        this.EnableButtons(0, false);
        this.ShowStatusMsg("Exit OK! And Welcome!");
    }

    private void GetBitmapToByteArray()
    {
        try
        {
            Image image = Image.FromFile(Directory.GetCurrentDirectory() + @"\1.bmp");
            MemoryStream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Bmp);
            byte[] sourceArray = stream.GetBuffer();
            Array.Copy(sourceArray, this.m_pBmpByteBuffer, sourceArray.Length);
        }
        catch (Exception)
        {
        }
    }

    private void GetCheckedImageBtn_Click(object sender, EventArgs e)
    {
        this.EnableButtons(1, false);
        this.nGetFpImageTimer.Enabled = true;
        this.m_bStopFlag = false;
        this.m_nContinuosFpPressCount = 0;
        this.m_nCapFpStatus = 0;
        this.m_nMaxFpArea = 0;
    }

    private void GetCountBtn_Click(object sender, EventArgs e)
    {
        int totalCounts = 0;
        if (mdFunction.pisGetCountTptArray(this.m_nContextID, ref totalCounts) == 0)
        {
            this.ShowStatusMsg("OK! template count =" + Convert.ToString(totalCounts));
        }
    }

    private void GetRawImageBtn_Click(object sender, EventArgs e)
    {
        byte[] imaBuffer = new byte[0x10000];
        if (mdFunction.pisCapture(this.m_nContextID, imaBuffer) != 0)
        {
            this.ShowStatusMsg("Error! Fail to capture image. Reopen the Ast2500 device");
        }
        else
        {
            this.DrawFpImage(imaBuffer, true);
        }
    }

    private void IdentifyBtn_Click(object sender, EventArgs e)
    {
        this.EnableButtons(1, false);
        this.nIdentifyTimer.Enabled = true;
        this.m_bStopFlag = false;
        this.m_nDoubleCheckFlag = true;
        this.m_nContinuosFpPressCount = 0;
        this.m_nCapFpStatus = 0;
        this.m_nMaxFpArea = 0;
    }

    private void InitBtn_Click(object sender, EventArgs e)
    {
        int anErrCode = 0;
        byte[] engineInfo = new byte[0xff];
        this.InitBtn.Enabled = false;
        anErrCode = mdFunction.pisCreateContext(ref this.m_nContextID);
        if (anErrCode != 0)
        {
            this.ShowErrorMsg(anErrCode, "Init", "pisCreateContext");
            this.InitBtn.Enabled = true;
        }
        else
        {
            this.ShowStatusMsg(" Opening the Device ... ");
            this.m_nDevId = this.m_pStrDevId[this.ComboDevice.SelectedIndex];
            anErrCode = mdFunction.pisOpenDevice(this.m_nContextID, this.m_nDevId);
            if (anErrCode != 0)
            {
                mdFunction.pisDestroyContext(this.m_nContextID);
                this.ShowErrorMsg(anErrCode, "Init", "pisOpenDevice");
                this.InitBtn.Enabled = true;
            }
            else
            {
                anErrCode = mdFunction.pisGetInfo(this.m_nContextID, engineInfo, ref this.m_nImaWidth, ref this.m_nImaHeight, ref this.m_nImaRes, ref this.m_nFeatureSize, ref this.m_nTemplateSize);
                this.GetBitmapToByteArray();
                if (anErrCode != 0)
                {
                    mdFunction.pisDestroyContext(this.m_nContextID);
                    this.ShowErrorMsg(anErrCode, "Init", "pisGetInfo");
                    this.InitBtn.Enabled = true;
                }
                else
                {
                    anErrCode = mdFunction.pisSetMatchParameter(this.m_nContextID, 180, 0x2c);
                    if (anErrCode != 0)
                    {
                        mdFunction.pisDestroyContext(this.m_nContextID);
                        this.ShowErrorMsg(anErrCode, "Init", "pisGetInfo");
                        this.InitBtn.Enabled = true;
                    }
                    else
                    {
                        this.ShowStatusMsg("OK! Open Ast2500 Device");
                        this.LoadAllFpTemplate();
                        this.EnableButtons(0, true);
                    }
                }
            }
        }
    }

    private void InitializeComponent()
    {
        this.components = new Container();
        ComponentResourceManager manager = new ComponentResourceManager(typeof(Ast2500CSDll));
        this.StaticMSG = new Label();
        this.CompanyMarkImage = new PictureBox();
        this.DevicesTxt = new Label();
        this.ComboDevice = new ComboBox();
        this.InitBtn = new Button();
        this.DeleteBtn = new Button();
        this.ClearBtn = new Button();
        this.GetCountBtn = new Button();
        this.GetCheckedImageBtn = new Button();
        this.GetRawImageBtn = new Button();
        this.ExitBtn = new Button();
        this.EnrollBtn = new Button();
        this.IdentifyBtn = new Button();
        this.StopBtn = new Button();
        this.VerifyBtn = new Button();
        this.EnrollTxt = new Label();
        this.IdentifiedTxt = new Label();
        this.IdentifyIDTxt = new TextBox();
        this.EnrollIDTxt = new NumericUpDown();
        this.nGetFpImageTimer = new Timer(this.components);
        this.nIdentifyTimer = new Timer(this.components);
        this.nEnrollTimer = new Timer(this.components);
        this.nVerifyTimer = new Timer(this.components);
        this.FpImagePanel = new Panel();
        this.fpImage = new PictureBox();
        ((ISupportInitialize) this.CompanyMarkImage).BeginInit();
        this.EnrollIDTxt.BeginInit();
        this.FpImagePanel.SuspendLayout();
        ((ISupportInitialize) this.fpImage).BeginInit();
        base.SuspendLayout();
        this.StaticMSG.BorderStyle = BorderStyle.Fixed3D;
        this.StaticMSG.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.StaticMSG.Location = new Point(0x38, 0x11);
        this.StaticMSG.Name = "StaticMSG";
        this.StaticMSG.Size = new Size(0x25b, 0x2c);
        this.StaticMSG.TabIndex = 0;
        this.StaticMSG.Text = "Welcome";
        this.StaticMSG.TextAlign = ContentAlignment.TopCenter;
        this.CompanyMarkImage.BackgroundImage = (Image) manager.GetObject("CompanyMarkImage.BackgroundImage");
        this.CompanyMarkImage.BackgroundImageLayout = ImageLayout.Stretch;
        this.CompanyMarkImage.InitialImage = Resources.IDR_MAI;
        this.CompanyMarkImage.Location = new Point(0x10, 0x10);
        this.CompanyMarkImage.Name = "CompanyMarkImage";
        this.CompanyMarkImage.Size = new Size(0x20, 0x20);
        this.CompanyMarkImage.TabIndex = 1;
        this.CompanyMarkImage.TabStop = false;
        this.DevicesTxt.AutoSize = true;
        this.DevicesTxt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.DevicesTxt.Location = new Point(0x188, 0x58);
        this.DevicesTxt.Name = "DevicesTxt";
        this.DevicesTxt.Size = new Size(0x72, 0x10);
        this.DevicesTxt.TabIndex = 3;
        this.DevicesTxt.Text = "Ast2500 Devices :";
        this.ComboDevice.DropDownStyle = ComboBoxStyle.DropDownList;
        this.ComboDevice.FormattingEnabled = true;
        this.ComboDevice.Location = new Point(0x200, 0x55);
        this.ComboDevice.Name = "ComboDevice";
        this.ComboDevice.Size = new Size(0x89, 0x15);
        this.ComboDevice.TabIndex = 4;
        this.InitBtn.BackColor = SystemColors.Control;
        this.InitBtn.FlatAppearance.BorderSize = 10;
        this.InitBtn.FlatStyle = FlatStyle.System;
        this.InitBtn.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.InitBtn.Location = new Point(0x189, 0x79);
        this.InitBtn.Name = "InitBtn";
        this.InitBtn.Size = new Size(0x79, 0x22);
        this.InitBtn.TabIndex = 5;
        this.InitBtn.Text = "Init";
        this.InitBtn.UseVisualStyleBackColor = false;
        this.InitBtn.Click += new EventHandler(this.InitBtn_Click);
        this.DeleteBtn.BackColor = SystemColors.Control;
        this.DeleteBtn.FlatAppearance.BorderSize = 10;
        this.DeleteBtn.FlatStyle = FlatStyle.System;
        this.DeleteBtn.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.DeleteBtn.Location = new Point(520, 210);
        this.DeleteBtn.Name = "DeleteBtn";
        this.DeleteBtn.Size = new Size(0x8a, 0x22);
        this.DeleteBtn.TabIndex = 11;
        this.DeleteBtn.Text = "Delete";
        this.DeleteBtn.UseVisualStyleBackColor = false;
        this.DeleteBtn.Click += new EventHandler(this.DeleteBtn_Click);
        this.ClearBtn.BackColor = SystemColors.Control;
        this.ClearBtn.FlatAppearance.BorderSize = 10;
        this.ClearBtn.FlatStyle = FlatStyle.System;
        this.ClearBtn.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.ClearBtn.Location = new Point(520, 250);
        this.ClearBtn.Name = "ClearBtn";
        this.ClearBtn.Size = new Size(0x8a, 0x22);
        this.ClearBtn.TabIndex = 12;
        this.ClearBtn.Text = "Clear";
        this.ClearBtn.UseVisualStyleBackColor = false;
        this.ClearBtn.Click += new EventHandler(this.ClearBtn_Click);
        this.GetCountBtn.BackColor = SystemColors.Control;
        this.GetCountBtn.FlatAppearance.BorderSize = 10;
        this.GetCountBtn.FlatStyle = FlatStyle.System;
        this.GetCountBtn.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.GetCountBtn.Location = new Point(520, 290);
        this.GetCountBtn.Name = "GetCountBtn";
        this.GetCountBtn.Size = new Size(0x8a, 0x22);
        this.GetCountBtn.TabIndex = 13;
        this.GetCountBtn.Text = "Get Count";
        this.GetCountBtn.UseVisualStyleBackColor = false;
        this.GetCountBtn.Click += new EventHandler(this.GetCountBtn_Click);
        this.GetCheckedImageBtn.BackColor = SystemColors.Control;
        this.GetCheckedImageBtn.FlatAppearance.BorderSize = 10;
        this.GetCheckedImageBtn.FlatStyle = FlatStyle.System;
        this.GetCheckedImageBtn.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.GetCheckedImageBtn.Location = new Point(0x132, 0x1c8);
        this.GetCheckedImageBtn.Name = "GetCheckedImageBtn";
        this.GetCheckedImageBtn.Size = new Size(0x93, 0x22);
        this.GetCheckedImageBtn.TabIndex = 0x12;
        this.GetCheckedImageBtn.Text = "Get Checked Fp Image";
        this.GetCheckedImageBtn.UseVisualStyleBackColor = false;
        this.GetCheckedImageBtn.Click += new EventHandler(this.GetCheckedImageBtn_Click);
        this.GetRawImageBtn.BackColor = SystemColors.Control;
        this.GetRawImageBtn.FlatAppearance.BorderSize = 10;
        this.GetRawImageBtn.FlatStyle = FlatStyle.System;
        this.GetRawImageBtn.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.GetRawImageBtn.Location = new Point(0x1ff, 0x1c8);
        this.GetRawImageBtn.Name = "GetRawImageBtn";
        this.GetRawImageBtn.Size = new Size(0x93, 0x22);
        this.GetRawImageBtn.TabIndex = 0x13;
        this.GetRawImageBtn.Text = "Get Fp Image";
        this.GetRawImageBtn.UseVisualStyleBackColor = false;
        this.GetRawImageBtn.Click += new EventHandler(this.GetRawImageBtn_Click);
        this.ExitBtn.BackColor = SystemColors.Control;
        this.ExitBtn.FlatAppearance.BorderSize = 10;
        this.ExitBtn.FlatStyle = FlatStyle.System;
        this.ExitBtn.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.ExitBtn.Location = new Point(0x211, 0x79);
        this.ExitBtn.Name = "ExitBtn";
        this.ExitBtn.Size = new Size(0x79, 0x22);
        this.ExitBtn.TabIndex = 20;
        this.ExitBtn.Text = "Exit";
        this.ExitBtn.UseVisualStyleBackColor = false;
        this.ExitBtn.Click += new EventHandler(this.ExitBtn_Click);
        this.EnrollBtn.BackColor = SystemColors.Control;
        this.EnrollBtn.FlatAppearance.BorderSize = 10;
        this.EnrollBtn.FlatStyle = FlatStyle.System;
        this.EnrollBtn.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.EnrollBtn.Location = new Point(0x189, 210);
        this.EnrollBtn.Name = "EnrollBtn";
        this.EnrollBtn.Size = new Size(0x79, 0x22);
        this.EnrollBtn.TabIndex = 0x15;
        this.EnrollBtn.Text = "Enroll";
        this.EnrollBtn.UseVisualStyleBackColor = false;
        this.EnrollBtn.Click += new EventHandler(this.EnrollBtn_Click);
        this.IdentifyBtn.BackColor = SystemColors.Control;
        this.IdentifyBtn.FlatAppearance.BorderSize = 10;
        this.IdentifyBtn.FlatStyle = FlatStyle.System;
        this.IdentifyBtn.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.IdentifyBtn.Location = new Point(0x18b, 290);
        this.IdentifyBtn.Name = "IdentifyBtn";
        this.IdentifyBtn.Size = new Size(0x79, 0x22);
        this.IdentifyBtn.TabIndex = 0x16;
        this.IdentifyBtn.Text = "Identify (1 : N)";
        this.IdentifyBtn.UseVisualStyleBackColor = false;
        this.IdentifyBtn.Click += new EventHandler(this.IdentifyBtn_Click);
        this.StopBtn.BackColor = SystemColors.Control;
        this.StopBtn.FlatAppearance.BorderSize = 10;
        this.StopBtn.FlatStyle = FlatStyle.System;
        this.StopBtn.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.StopBtn.Location = new Point(520, 0x196);
        this.StopBtn.Name = "StopBtn";
        this.StopBtn.Size = new Size(0x8a, 0x22);
        this.StopBtn.TabIndex = 0x17;
        this.StopBtn.Text = "Stop";
        this.StopBtn.UseVisualStyleBackColor = false;
        this.StopBtn.Click += new EventHandler(this.StopBtn_Click);
        this.VerifyBtn.BackColor = SystemColors.Control;
        this.VerifyBtn.FlatAppearance.BorderSize = 10;
        this.VerifyBtn.FlatStyle = FlatStyle.System;
        this.VerifyBtn.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x81);
        this.VerifyBtn.Location = new Point(0x189, 0x193);
        this.VerifyBtn.Name = "VerifyBtn";
        this.VerifyBtn.Size = new Size(0x79, 0x22);
        this.VerifyBtn.TabIndex = 0x18;
        this.VerifyBtn.Text = "Verify (1 : 1)";
        this.VerifyBtn.UseVisualStyleBackColor = false;
        this.VerifyBtn.Click += new EventHandler(this.VerifyBtn_Click);
        this.EnrollTxt.AutoSize = true;
        this.EnrollTxt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.EnrollTxt.Location = new Point(0x188, 180);
        this.EnrollTxt.Name = "EnrollTxt";
        this.EnrollTxt.Size = new Size(0x3d, 0x10);
        this.EnrollTxt.TabIndex = 0x1c;
        this.EnrollTxt.Text = "Enroll ID:";
        this.IdentifiedTxt.AutoSize = true;
        this.IdentifiedTxt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.IdentifiedTxt.Location = new Point(390, 0x170);
        this.IdentifiedTxt.Name = "IdentifiedTxt";
        this.IdentifiedTxt.Size = new Size(0x40, 0x10);
        this.IdentifiedTxt.TabIndex = 0x1d;
        this.IdentifiedTxt.Text = "Verify ID :";
        this.IdentifyIDTxt.Location = new Point(0x1d8, 0x16f);
        this.IdentifyIDTxt.Name = "IdentifyIDTxt";
        this.IdentifyIDTxt.Size = new Size(70, 20);
        this.IdentifyIDTxt.TabIndex = 30;
        this.IdentifyIDTxt.Text = "0";
        this.EnrollIDTxt.Location = new Point(0x1c9, 0xb1);
        int[] bits = new int[4];
        bits[0] = 0x186a0;
        this.EnrollIDTxt.Maximum = new decimal(bits);
        int[] numArray2 = new int[4];
        numArray2[0] = 1;
        this.EnrollIDTxt.Minimum = new decimal(numArray2);
        this.EnrollIDTxt.Name = "EnrollIDTxt";
        this.EnrollIDTxt.Size = new Size(0x55, 20);
        this.EnrollIDTxt.TabIndex = 0x24;
        int[] numArray3 = new int[4];
        numArray3[0] = 1;
        this.EnrollIDTxt.Value = new decimal(numArray3);
        this.nGetFpImageTimer.Interval = 30;
        this.nGetFpImageTimer.Tick += new EventHandler(this.nGetFpImageTimer_Tick);
        this.nIdentifyTimer.Interval = 30;
        this.nIdentifyTimer.Tick += new EventHandler(this.nIdentifyTimer_Tick);
        this.nEnrollTimer.Interval = 30;
        this.nEnrollTimer.Tick += new EventHandler(this.nEnrollTimer_Tick);
        this.nVerifyTimer.Interval = 30;
        this.nVerifyTimer.Tick += new EventHandler(this.nVerifyTimer_Tick);
        this.FpImagePanel.BorderStyle = BorderStyle.FixedSingle;
        this.FpImagePanel.Controls.Add(this.fpImage);
        this.FpImagePanel.Location = new Point(0x1b, 0x55);
        this.FpImagePanel.Name = "FpImagePanel";
        this.FpImagePanel.Size = new Size(0x165, 0x163);
        this.FpImagePanel.TabIndex = 0x25;
        this.fpImage.BackColor = SystemColors.ButtonFace;
        this.fpImage.BackgroundImageLayout = ImageLayout.None;
        this.fpImage.Image = (Image) manager.GetObject("fpImage.Image");
        this.fpImage.Location = new Point(4, 3);
        this.fpImage.Name = "fpImage";
        this.fpImage.Size = new Size(0x15c, 0x15c);
        this.fpImage.SizeMode = PictureBoxSizeMode.StretchImage;
        this.fpImage.TabIndex = 3;
        this.fpImage.TabStop = false;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.ClientSize = new Size(0x2a5, 0x1fb);
        base.Controls.Add(this.FpImagePanel);
        base.Controls.Add(this.EnrollIDTxt);
        base.Controls.Add(this.IdentifyIDTxt);
        base.Controls.Add(this.IdentifiedTxt);
        base.Controls.Add(this.EnrollTxt);
        base.Controls.Add(this.VerifyBtn);
        base.Controls.Add(this.StopBtn);
        base.Controls.Add(this.IdentifyBtn);
        base.Controls.Add(this.EnrollBtn);
        base.Controls.Add(this.ExitBtn);
        base.Controls.Add(this.GetRawImageBtn);
        base.Controls.Add(this.GetCheckedImageBtn);
        base.Controls.Add(this.GetCountBtn);
        base.Controls.Add(this.ClearBtn);
        base.Controls.Add(this.DeleteBtn);
        base.Controls.Add(this.InitBtn);
        base.Controls.Add(this.ComboDevice);
        base.Controls.Add(this.DevicesTxt);
        base.Controls.Add(this.CompanyMarkImage);
        base.Controls.Add(this.StaticMSG);
        base.FormBorderStyle = FormBorderStyle.FixedSingle;
        base.MaximizeBox = false;
        base.MinimizeBox = false;
        base.Name = "Ast2500CSDll";
        base.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Ast2500 C# Dll Sample (Version 1.0.0)";
        base.FormClosed += new FormClosedEventHandler(this.Ast2500CSDll_FormClosed);
        base.Load += new EventHandler(this.Ast2500CSDll_Load);
        ((ISupportInitialize) this.CompanyMarkImage).EndInit();
        this.EnrollIDTxt.EndInit();
        this.FpImagePanel.ResumeLayout(false);
        ((ISupportInitialize) this.fpImage).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }

    private void LoadAllFpTemplate()
    {
        mdFunction.pisClearTptArray(this.m_nContextID);
        string path = Directory.GetCurrentDirectory() + @"\templateDB\";
        string searchPattern = "*.dat";
        try
        {
            foreach (string str3 in Directory.GetFiles(path, searchPattern))
            {
                this.LoadFpTemplate(path, str3);
            }
        }
        catch (Exception)
        {
        }
    }

    private void LoadFpTemplate(string astrDir, string astrFile)
    {
        byte[] buffer = new byte[720];
        int index = 0;
        int length = 0;
        FileStream stream = File.OpenRead(astrFile);
        stream.Read(buffer, 0, buffer.Length);
        stream.Close();
        index = astrFile.IndexOf(@"templateDB\");
        length = (astrFile.IndexOf(".dat") - index) - 11;
        int @int = mdFunction.GetInt(astrFile.Substring(index + 11, length));
        mdFunction.pisAddTptArray(this.m_nContextID, @int, buffer);
    }

    private void nEnrollTimer_Tick(object sender, EventArgs e)
    {
        int num2;
        byte[] featureData = new byte[this.m_nFeatureSize];
        if (this.m_bStopFlag)
        {
            this.nEnrollTimer.Enabled = false;
            this.EnableButtons(1, true);
            if (this.m_nFpExtractCount == 3)
            {
                num2 = mdFunction.pisCreateTemplate(this.m_nContextID, this.m_pMemFeatureBuffer_1, this.m_pMemFeatureBuffer_2, this.m_pMemFeatureBuffer_3, this.m_pMemTemplateBuffer);
                if (num2 != 0)
                {
                    this.ShowErrorMsg(num2, "Enroll", "pisCreateTemplate");
                }
                else
                {
                    this.ShowStatusMsg("Create template OK");
                    this.SaveFpTemplate(this.m_nID, this.m_pMemTemplateBuffer);
                    num2 = mdFunction.pisAddTptArray(this.m_nContextID, this.m_nID, this.m_pMemTemplateBuffer);
                    if (num2 != 0)
                    {
                        this.ShowErrorMsg(num2, "Enroll", "pisAddTptArray");
                    }
                    else
                    {
                        this.ShowStatusMsg(Convert.ToString(this.m_nID) + " Enroll OK!");
                    }
                }
            }
        }
        else
        {
            this.m_nIsFpImg = 0;
            num2 = mdFunction.pisCapture(this.m_nContextID, this.m_pMemImgBuffer);
            if (num2 != 0)
            {
                this.ShowErrorMsg(num2, "Enroll", "pisCapture");
                this.m_bStopFlag = true;
            }
            else
            {
                this.DrawFpImage(this.m_pMemImgBuffer, false);
                num2 = mdFunction.pisCheckFp(this.m_nContextID, this.m_pMemImgBuffer, this.m_nImaWidth, this.m_nImaHeight, this.m_nImaRes, ref this.m_nIsFpImg, ref this.m_nFpArea);
                if (this.m_nCapFpStatus == 0)
                {
                    if (this.m_nIsFpImg != 0)
                    {
                        this.promptPressFinger(-1);
                        return;
                    }
                    this.m_nCapFpStatus = 1;
                    this.m_nContinuosFpPressCount = 0;
                }
                if (this.m_nCapFpStatus == 1)
                {
                    if (this.m_nIsFpImg == 0)
                    {
                        this.promptPressFinger(this.m_nFpExtractCount + 1);
                        if (this.m_nContinuosFpPressCount < 2)
                        {
                            this.m_nContinuosFpPressCount = 0;
                            return;
                        }
                    }
                    if (this.m_nFpArea < 0x2e)
                    {
                        this.m_nContinuosFpPressCount = 0;
                    }
                    this.m_nContinuosFpPressCount++;
                    if (this.m_nMaxFpArea < this.m_nFpArea)
                    {
                        this.m_nMaxFpArea = this.m_nFpArea;
                        Array.Copy(this.m_pMemImgBuffer, this.m_pMemMaxAreaFpBuffer, 0x10000);
                        if (this.m_nContinuosFpPressCount < 5)
                        {
                            return;
                        }
                        this.m_nCapFpStatus = 2;
                    }
                    else if (((3 * this.m_nMaxFpArea) / 4) > this.m_nFpArea)
                    {
                        if (this.m_nFpArea > 0x2e)
                        {
                            this.m_nCapFpStatus = 2;
                        }
                    }
                    else
                    {
                        if (this.m_nContinuosFpPressCount < 5)
                        {
                            return;
                        }
                        this.m_nCapFpStatus = 2;
                    }
                }
                if (this.m_nCapFpStatus == 2)
                {
                    num2 = mdFunction.pisProcess(this.m_nContextID, this.m_pMemMaxAreaFpBuffer, this.m_nImaWidth, this.m_nImaHeight, this.m_nImaRes, featureData);
                    if (this.m_nFpExtractCount == 0)
                    {
                        Array.Copy(featureData, this.m_pMemFeatureBuffer_1, this.m_nFeatureSize);
                    }
                    else if (this.m_nFpExtractCount == 1)
                    {
                        Array.Copy(featureData, this.m_pMemFeatureBuffer_2, this.m_nFeatureSize);
                    }
                    else
                    {
                        Array.Copy(featureData, this.m_pMemFeatureBuffer_3, this.m_nFeatureSize);
                    }
                    if (num2 != 0)
                    {
                        this.ShowErrorMsg(num2, "Enroll", "pisProcess");
                        this.m_bStopFlag = true;
                        return;
                    }
                    if (this.m_nDoubleCheckFlag)
                    {
                        int identifiedTID = 0;
                        if (mdFunction.pisIdentify(this.m_nContextID, featureData, ref identifiedTID, this.m_pMemTemplateUpdateBuffer, ref this.m_nUpdatedFlag) == 0)
                        {
                            this.ShowStatusMsg("This Fp is already enrolled with EnrollID:" + Convert.ToString(identifiedTID));
                            this.m_bStopFlag = true;
                            return;
                        }
                        this.m_nDoubleCheckFlag = false;
                    }
                    this.m_nFpExtractCount++;
                    this.m_nMaxFpArea = 0;
                    this.m_nContinuosFpPressCount = 0;
                    if (this.m_nFpExtractCount == 3)
                    {
                        this.m_bStopFlag = true;
                        return;
                    }
                    this.m_nCapFpStatus = 3;
                }
                if (this.m_nCapFpStatus == 3)
                {
                    if (this.m_nIsFpImg != 0)
                    {
                        this.promptPressFinger(-1);
                    }
                    else
                    {
                        this.m_nCapFpStatus = 1;
                    }
                }
            }
        }
    }

    private void nGetFpImageTimer_Tick(object sender, EventArgs e)
    {
        if (this.m_bStopFlag)
        {
            this.nGetFpImageTimer.Enabled = false;
            this.EnableButtons(1, true);
            this.m_nMaxFpArea = 0;
        }
        else
        {
            int anErrCode = mdFunction.pisCapture(this.m_nContextID, this.m_pMemImgBuffer);
            if (anErrCode != 0)
            {
                this.ShowErrorMsg(anErrCode, "CaptureFp", "pisCapture");
                this.m_bStopFlag = true;
                this.m_nMaxFpArea = 0;
            }
            else
            {
                this.DrawFpImage(this.m_pMemImgBuffer, false);
                mdFunction.pisCheckFp(this.m_nContextID, this.m_pMemImgBuffer, this.m_nImaWidth, this.m_nImaHeight, this.m_nImaRes, ref this.m_nIsFpImg, ref this.m_nFpArea);
                if (this.m_nCapFpStatus == 0)
                {
                    if (this.m_nIsFpImg != 0)
                    {
                        this.promptPressFinger(-1);
                        return;
                    }
                    this.m_nCapFpStatus = 1;
                    this.m_nContinuosFpPressCount = 0;
                }
                if (this.m_nCapFpStatus == 1)
                {
                    if (this.m_nIsFpImg == 0)
                    {
                        this.promptPressFinger(0);
                        if (this.m_nContinuosFpPressCount < 2)
                        {
                            this.m_nContinuosFpPressCount = 0;
                            return;
                        }
                    }
                    this.m_nContinuosFpPressCount++;
                    if (this.m_nMaxFpArea < this.m_nFpArea)
                    {
                        this.m_nMaxFpArea = this.m_nFpArea;
                        Array.Copy(this.m_pMemImgBuffer, this.m_pMemMaxAreaFpBuffer, 0x10000);
                        if (this.m_nContinuosFpPressCount < 2)
                        {
                            return;
                        }
                        this.m_nCapFpStatus = 2;
                    }
                    else if (((3 * this.m_nMaxFpArea) / 4) > this.m_nFpArea)
                    {
                        this.m_nCapFpStatus = 2;
                    }
                    else
                    {
                        if (this.m_nContinuosFpPressCount < 2)
                        {
                            return;
                        }
                        this.m_nCapFpStatus = 2;
                    }
                }
                if (this.m_nCapFpStatus == 2)
                {
                    anErrCode = mdFunction.pisProcess(this.m_nContextID, this.m_pMemMaxAreaFpBuffer, this.m_nImaWidth, this.m_nImaHeight, this.m_nImaRes, this.m_pMemFeatureBuffer_1);
                    if (anErrCode != 0)
                    {
                        this.ShowErrorMsg(anErrCode, "CaptureFp", "pisProcess");
                        this.m_bStopFlag = true;
                    }
                    else
                    {
                        this.DrawFpImage(this.m_pMemMaxAreaFpBuffer, true);
                        this.ShowStatusMsg("Sucess to get checked fp image! ");
                        this.m_bStopFlag = true;
                    }
                }
            }
        }
    }

    private void nIdentifyTimer_Tick(object sender, EventArgs e)
    {
        int num;
        this.nIdentifyTimer.Interval = 10;
        if (this.m_bStopFlag)
        {
            this.nIdentifyTimer.Enabled = false;
            this.EnableButtons(1, true);
            if (this.m_nCapFpStatus == 4)
            {
                num = mdFunction.pisIdentify(this.m_nContextID, this.m_pMemFeatureBuffer_1, ref this.m_nIdentifiedID, this.m_pMemTemplateUpdateBuffer, ref this.m_nUpdatedFlag);
                if (num != 0)
                {
                    this.ShowErrorMsg(num, "Identify", "pisIdentify");
                    this.nIdentifyTimer.Interval = 0x3e8;
                    this.nIdentifyTimer.Enabled = true;
                    this.EnableButtons(1, false);
                    this.m_nContinuosFpPressCount = 0;
                    this.m_nCapFpStatus = 0;
                    this.m_nMaxFpArea = 0;
                    this.m_bStopFlag = false;
                }
                else if (num == 0)
                {
                    this.ShowStatusMsg("ID=" + Convert.ToString(this.m_nIdentifiedID) + " : Identify OK ");
                    this.EnableButtons(1, false);
                    this.nIdentifyTimer.Interval = 0x3e8;
                    this.nIdentifyTimer.Enabled = true;
                    this.m_nContinuosFpPressCount = 0;
                    this.m_nCapFpStatus = 0;
                    this.m_nMaxFpArea = 0;
                    this.m_bStopFlag = false;
                    if (this.m_nUpdatedFlag == 1)
                    {
                        mdFunction.pisSetAtTptArray(this.m_nContextID, this.m_nIdentifiedID, this.m_pMemTemplateUpdateBuffer);
                        this.SaveFpTemplate(this.m_nIdentifiedID, this.m_pMemTemplateUpdateBuffer);
                    }
                }
            }
        }
        else
        {
            this.m_nIsFpImg = 0;
            num = mdFunction.pisCapture(this.m_nContextID, this.m_pMemImgBuffer);
            if (num != 0)
            {
                this.ShowErrorMsg(num, "Identify", "pisCapture");
                this.m_bStopFlag = true;
            }
            else
            {
                this.DrawFpImage(this.m_pMemImgBuffer, false);
                num = mdFunction.pisCheckFp(this.m_nContextID, this.m_pMemImgBuffer, this.m_nImaWidth, this.m_nImaHeight, this.m_nImaRes, ref this.m_nIsFpImg, ref this.m_nFpArea);
                if (this.m_nCapFpStatus == 0)
                {
                    if (this.m_nIsFpImg != 0)
                    {
                        this.promptPressFinger(-1);
                        return;
                    }
                    this.m_nCapFpStatus = 1;
                    this.m_nContinuosFpPressCount = 0;
                }
                if (this.m_nCapFpStatus == 1)
                {
                    if (this.m_nIsFpImg == 0)
                    {
                        this.promptPressFinger(0);
                        if (this.m_nContinuosFpPressCount < 2)
                        {
                            this.m_nContinuosFpPressCount = 0;
                            return;
                        }
                    }
                    this.m_nContinuosFpPressCount++;
                    if (this.m_nMaxFpArea < this.m_nFpArea)
                    {
                        this.m_nMaxFpArea = this.m_nFpArea;
                        Array.Copy(this.m_pMemImgBuffer, this.m_pMemMaxAreaFpBuffer, 0x10000);
                        if (this.m_nContinuosFpPressCount < 2)
                        {
                            return;
                        }
                        this.m_nCapFpStatus = 2;
                    }
                    else if (((3 * this.m_nMaxFpArea) / 4) > this.m_nFpArea)
                    {
                        this.m_nCapFpStatus = 2;
                    }
                    else
                    {
                        if (this.m_nContinuosFpPressCount < 2)
                        {
                            return;
                        }
                        this.m_nCapFpStatus = 2;
                    }
                }
                if (this.m_nCapFpStatus == 2)
                {
                    num = mdFunction.pisProcess(this.m_nContextID, this.m_pMemMaxAreaFpBuffer, this.m_nImaWidth, this.m_nImaHeight, this.m_nImaRes, this.m_pMemFeatureBuffer_1);
                    if (num != 0)
                    {
                        this.ShowErrorMsg(num, "Identify", "pisProcess");
                        this.m_bStopFlag = true;
                    }
                    else
                    {
                        this.DrawFpImage(this.m_pMemMaxAreaFpBuffer, false);
                        this.m_nCapFpStatus = 4;
                        this.m_bStopFlag = true;
                    }
                }
            }
        }
    }

    private void nVerifyTimer_Tick(object sender, EventArgs e)
    {
        int num;
        this.nVerifyTimer.Interval = 30;
        if (this.m_bStopFlag)
        {
            this.nVerifyTimer.Enabled = false;
            this.EnableButtons(1, true);
            if (this.m_nCapFpStatus == 4)
            {
                num = mdFunction.pisVerify(this.m_nContextID, this.m_pMemFeatureBuffer_1, this.m_pMemTemplateBuffer, this.m_pMemTemplateUpdateBuffer, ref this.m_nUpdatedFlag);
                if (num != 0)
                {
                    this.ShowErrorMsg(num, "Verify", "pisVerify");
                }
                else if (num == 0)
                {
                    this.ShowStatusMsg("Verify OK ! (ID = " + Convert.ToString(this.m_nIdentifiedID) + ")");
                    this.m_nMaxFpArea = 0;
                    if (this.m_nUpdatedFlag == 1)
                    {
                        mdFunction.pisSetAtTptArray(this.m_nContextID, this.m_nIdentifiedID, this.m_pMemTemplateUpdateBuffer);
                        this.SaveFpTemplate(this.m_nIdentifiedID, this.m_pMemTemplateUpdateBuffer);
                    }
                }
            }
        }
        else
        {
            num = mdFunction.pisCapture(this.m_nContextID, this.m_pMemImgBuffer);
            if (num != 0)
            {
                this.ShowErrorMsg(num, "Verify", "pisCapture");
                this.m_bStopFlag = true;
            }
            else
            {
                this.DrawFpImage(this.m_pMemImgBuffer, false);
                num = mdFunction.pisCheckFp(this.m_nContextID, this.m_pMemImgBuffer, this.m_nImaWidth, this.m_nImaHeight, this.m_nImaRes, ref this.m_nIsFpImg, ref this.m_nFpArea);
                if (this.m_nCapFpStatus == 0)
                {
                    if (this.m_nIsFpImg != 0)
                    {
                        this.promptPressFinger(-1);
                        return;
                    }
                    this.m_nCapFpStatus = 1;
                    this.m_nContinuosFpPressCount = 0;
                }
                if (this.m_nCapFpStatus == 1)
                {
                    if (this.m_nIsFpImg == 0)
                    {
                        this.promptPressFinger(0);
                        if (this.m_nContinuosFpPressCount < 2)
                        {
                            this.m_nContinuosFpPressCount = 0;
                            return;
                        }
                    }
                    this.m_nContinuosFpPressCount++;
                    if (this.m_nMaxFpArea < this.m_nFpArea)
                    {
                        this.m_nMaxFpArea = this.m_nFpArea;
                        Array.Copy(this.m_pMemImgBuffer, this.m_pMemMaxAreaFpBuffer, 0x10000);
                        if (this.m_nContinuosFpPressCount < 2)
                        {
                            return;
                        }
                        this.m_nCapFpStatus = 2;
                    }
                    else if (((3 * this.m_nMaxFpArea) / 4) > this.m_nFpArea)
                    {
                        this.m_nCapFpStatus = 2;
                    }
                    else
                    {
                        if (this.m_nContinuosFpPressCount < 2)
                        {
                            return;
                        }
                        this.m_nCapFpStatus = 2;
                    }
                }
                if (this.m_nCapFpStatus == 2)
                {
                    num = mdFunction.pisProcess(this.m_nContextID, this.m_pMemMaxAreaFpBuffer, this.m_nImaWidth, this.m_nImaHeight, this.m_nImaRes, this.m_pMemFeatureBuffer_1);
                    if (num != 0)
                    {
                        this.ShowErrorMsg(num, "Verify", "pisProcess");
                        this.m_bStopFlag = true;
                    }
                    else
                    {
                        this.DrawFpImage(this.m_pMemMaxAreaFpBuffer, false);
                        this.m_nCapFpStatus = 4;
                        this.m_bStopFlag = true;
                    }
                }
            }
        }
    }

    private void promptPressFinger(int fingerCount)
    {
        if (fingerCount == -2)
        {
            this.ShowStatusMsg("FpArea is not enough,Please take off finger, and try again");
        }
        else if (fingerCount == -1)
        {
            this.ShowStatusMsg("Take off Finger");
        }
        else if (fingerCount == 0)
        {
            this.ShowStatusMsg("Press Finger");
        }
        else
        {
            this.ShowStatusMsg("Press Finger -" + Convert.ToString(fingerCount));
        }
    }

    private void SaveFpTemplate(int anTmplId, byte[] abytFpTmpl)
    {
        byte[] destinationArray = new byte[720];
        Array.Copy(abytFpTmpl, destinationArray, 720);
        string path = Directory.GetCurrentDirectory() + @"\templateDB";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        FileStream stream = File.OpenWrite(path + @"\" + Convert.ToString(anTmplId) + ".dat");
        stream.Write(destinationArray, 0, destinationArray.Length);
        stream.Close();
    }

    private void ShowErrorMsg(int anErrCode, string aProcDesc, string aFuncDesc)
    {
        string astrMsg = "Error! ll";
        switch (anErrCode)
        {
            case -202:
                astrMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<Device is busy.>)";
                break;

            case -201:
                astrMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<Device is stop.>)";
                break;

            case -106:
                astrMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<Context is over.>)";
                break;

            case -105:
                astrMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<TptArray is over.>)";
                break;

            case -104:
                astrMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<System memory can not alloc.>)";
                break;

            case -103:
                astrMsg = aProcDesc + " Fail: ( " + aFuncDesc + ": <Function parameter is not valid.>)";
                break;

            case -102:
                astrMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<Device is not connect or Device is busy>";
                break;

            case -101:
                astrMsg = aProcDesc + " Fail: ( " + aFuncDesc + ": <ContextID is not valid.>)";
                break;

            default:
                astrMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<Fail.>  )";
                break;
        }
        this.ShowStatusMsg(astrMsg);
    }

    private void ShowStatusMsg(string astrMsg)
    {
        this.StaticMSG.Text = astrMsg;
    }

    private void StopBtn_Click(object sender, EventArgs e)
    {
        this.m_bStopFlag = true;
        this.ShowStatusMsg("Stoped!");
        this.EnableButtons(1, true);
    }

    private void VerifyBtn_Click(object sender, EventArgs e)
    {
        this.m_nIdentifiedID = mdFunction.GetInt(this.IdentifyIDTxt.Text);
        if (this.m_nIdentifiedID < 1)
        {
            MessageBox.Show("Input ID for verify ID !", "Ast2500 C# dll Sample", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (mdFunction.pisGetAtTptArray(this.m_nContextID, this.m_nIdentifiedID, this.m_pMemTemplateBuffer) != 0)
        {
            MessageBox.Show("There is not exist ID (" + Convert.ToString(this.m_nIdentifiedID) + ")", "Ast2500 C# dll Sample", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
            this.EnableButtons(1, false);
            this.nVerifyTimer.Enabled = true;
            this.m_bStopFlag = false;
            this.m_nContinuosFpPressCount = 0;
            this.m_nCapFpStatus = 0;
            this.m_nMaxFpArea = 0;
        }
    }
}

 
Collapse Methods
 
