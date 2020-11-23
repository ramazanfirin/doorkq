/***************************************************************************
 * 
 * Project Name: C# Sample for Ast2500
 * purpose:      Using Ast2500 device, enroll and identify for one's figerprint
 * Company:      Pefis Electronic Technology (Beijing) Co,.Ltd
 * Date:         2015.09.26  
 * Author:       Newpub
 ***************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ast2500CSDllSample
{
    public partial class Ast2500CSDll : Form
    {
        private const int PIS_INIT = 0;
        private const int PIS_ACT = 1;
        private const int ColorTableEntries = 256;
        private const int IMAGE_SIZE = 65536;
        private const int TEMPLATE_SIZE = 720;
        private const int FEATURE_SIZE = 4816;
        private const int CapFp_Init = 0;
        private const int CapFp_WaitPressFinger = 1;
        private const int CapFp_GoodFpCaptured = 2;
        private const int CapFp_PromptTakeoffFinger = 3;
        private const int CapFp_Identify_OK = 4;
        private const int GoodEnrollFpArea = 46;  // do not modify
        private const int DEFAULT_FP_SIZE = 1680;

        private const string ALERT_TITLE = "Ast2500 C# dll Sample";
        Int32 m_nContextID;
        Int32 m_nImaWidth;
        Int32 m_nImaHeight;
        Int32 m_nImaRes;
        Int32 m_nFeatureSize;
        Int32 m_nTemplateSize;
        Int32 m_nUpdatedFlag;
        Boolean m_bStopFlag;
        Int32 m_nIsFpImg;
        Int32 m_nFpArea;
        Int32 m_nMaxFpArea;
        Int32 m_nContinuosFpPressCount;
        Int32 m_nFpExtractCount;
        Int32 m_nCapFpStatus;
        Int32 m_nID;
        Int32 m_nIdentifiedID;
        Boolean m_nDoubleCheckFlag;

        
        String[] m_pStrDevId = new String[mdFunction.PISFP_MAX_DEVICE_COUNTS];
        String[] m_pStrDevName = new String[mdFunction.PISFP_MAX_DEVICE_COUNTS];
        String m_nDevId;

        byte[] m_pMemImgBuffer = new byte[IMAGE_SIZE];

        byte[] m_pMemFeatureBuffer_1 = new byte[FEATURE_SIZE];
        byte[] m_pMemFeatureBuffer_2 = new byte[FEATURE_SIZE];
        byte[] m_pMemFeatureBuffer_3 = new byte[FEATURE_SIZE];
        byte[] m_pMemTemplateBuffer = new byte[TEMPLATE_SIZE];
        byte[] m_pMemTemplateUpdateBuffer = new byte[TEMPLATE_SIZE];
        byte[] m_pMemMaxAreaFpBuffer = new byte[IMAGE_SIZE];
        byte[] m_pBmpByteBuffer = new byte[mdFunction.BITMAP_SIZE];
        public Ast2500CSDll()
        {
            InitializeComponent();
        }

        private void Ast2500CSDll_Load(object sender, EventArgs e)
        {
            EnableButtons(PIS_INIT, false);
            InitBtn.Enabled = false;
            EnumAst2500Devices();

            nGetFpImageTimer.Enabled = false;
            nIdentifyTimer.Enabled = false;
            nEnrollTimer.Enabled = false;
            nVerifyTimer.Enabled = false;
            m_bStopFlag = false;
            
        }

        private void EnumAst2500Devices()
        {
            int vnRet;
            byte[] strDevId = new byte[255];
            byte[] strDevName = new byte[255];
            byte[] vbytTmpBuffer = new byte[255];
            for (int k = 0; k < mdFunction.PISFP_MAX_DEVICE_COUNTS; k++)
            {
                vnRet = mdFunction.pisEnumerateDevice(k, strDevId, strDevName);
                if (vnRet == mdFunction.PISFP_OK)
                {
                    Array.Copy(strDevId, vbytTmpBuffer, 255);
                    m_pStrDevId[k] = mdFunction.ByteArrayUtf8ToString(vbytTmpBuffer);
                    Array.Copy(strDevName, vbytTmpBuffer, 255);
                    m_pStrDevName[k] = mdFunction.ByteArrayUtf8ToString(vbytTmpBuffer);
                    ComboDevice.Items.Add(m_pStrDevName[k]);
                }
            }
            if (ComboDevice.Items.Count > 0)
            {
                ComboDevice.SelectedIndex = 0;
                InitBtn.Enabled = true;
            }
            else
            {
                InitBtn.Enabled = false;
            }
        }

        private void EnableButtons(int Kind, Boolean Flag)
        {
            if (Kind == PIS_INIT)
            {
                InitBtn.Enabled = !Flag;
                ExitBtn.Enabled = Flag;
                EnrollBtn.Enabled = Flag;
                DeleteBtn.Enabled = Flag;
                ClearBtn.Enabled = Flag;
                GetCountBtn.Enabled = Flag;
                IdentifyBtn.Enabled = Flag;
                VerifyBtn.Enabled = Flag;
                GetCheckedImageBtn.Enabled = Flag;
                GetRawImageBtn.Enabled = Flag;

            }
            else if (Kind == PIS_ACT)
            {

                ExitBtn.Enabled = true;
                EnrollBtn.Enabled = Flag;
                DeleteBtn.Enabled = Flag;
                ClearBtn.Enabled = Flag;
                GetCountBtn.Enabled = Flag;
                IdentifyBtn.Enabled = Flag;
                VerifyBtn.Enabled = Flag;
                GetCheckedImageBtn.Enabled = Flag;
                GetRawImageBtn.Enabled = Flag;
            }
        }


        private void InitBtn_Click(object sender, EventArgs e)
        {
            int vnRet = 0;
            byte[] vstrTmp = new byte[255];
            InitBtn.Enabled = false;
            vnRet = mdFunction.pisCreateContext(ref m_nContextID);
            if (vnRet != mdFunction.PISFP_OK)
            {
                ShowErrorMsg(vnRet, mdFunction.INIT_PROC, mdFunction.CREATE_CONTEXT_FUNC);
                InitBtn.Enabled = true;
                return;
            }
            ShowStatusMsg(" Opening the Device ... ");
            m_nDevId = m_pStrDevId[ComboDevice.SelectedIndex];
            vnRet = mdFunction.pisOpenDevice(m_nContextID, m_nDevId);
            if (vnRet != mdFunction.PISFP_OK)
            {
                mdFunction.pisDestroyContext(m_nContextID);
                ShowErrorMsg(vnRet, mdFunction.INIT_PROC, mdFunction.OPEN_DEVICE_FUNC);
                InitBtn.Enabled = true;
                return;
            }
            vnRet = mdFunction.pisGetInfo(m_nContextID, vstrTmp, ref  m_nImaWidth, ref  m_nImaHeight, ref m_nImaRes, ref m_nFeatureSize, ref  m_nTemplateSize);
            GetBitmapToByteArray();
            if (vnRet != mdFunction.PISFP_OK)
            {
                mdFunction.pisDestroyContext(m_nContextID);
                ShowErrorMsg(vnRet, mdFunction.INIT_PROC, mdFunction.GET_INFO_FUNC);
                InitBtn.Enabled = true;
                return;
            }

            vnRet = mdFunction.pisSetMatchParameter(m_nContextID, mdFunction.PISFP_MAX_ROTATION_RANGE, mdFunction.PISFP_DEFAULT_THRESHOLD);
            if (vnRet != mdFunction.PISFP_OK)
            {
                mdFunction.pisDestroyContext(m_nContextID);
                ShowErrorMsg(vnRet, mdFunction.INIT_PROC, mdFunction.GET_INFO_FUNC);
                InitBtn.Enabled = true;
                return;
            }

            ShowStatusMsg("OK! Open Ast2500 Device");
            LoadAllFpTemplate();
            // ClearFpImage();
            EnableButtons(PIS_INIT, true);

        }

        private void ShowErrorMsg(int anErrCode, string aProcDesc, string aFuncDesc)
        {
            string strMsg;

            strMsg = "Error! " + "ll";
            switch (anErrCode)
            {
                case mdFunction.PISFP_ERR_INVALID_CONTEXT: strMsg = aProcDesc + " Fail: ( " + aFuncDesc + ": <ContextID is not valid.>)"; break;
                case mdFunction.PISFP_ERR_NOT_CONNECT_DEV: strMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<Device is not connect or Device is busy>"; break;
                case mdFunction.PISFP_ERR_FUNC_PARAMETER: strMsg = aProcDesc + " Fail: ( " + aFuncDesc + ": <Function parameter is not valid.>)"; break;
                case mdFunction.PISFP_ERR_SYSTEM_MEMORY_ALLOC: strMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<System memory can not alloc.>)"; break;
                case mdFunction.PISFP_ERR_TEMPLATE_ARRAY_OVER: strMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<TptArray is over.>)"; break;
                case mdFunction.PISFP_ERR_DEV_STOP: strMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<Device is stop.>)"; break;
                case mdFunction.PISFP_ERR_DEV_BUSY: strMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<Device is busy.>)"; break;
                case mdFunction.PISFP_ERR_CONTEXT_OVER: strMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<Context is over.>)"; break;
                default: strMsg = aProcDesc + " Fail: ( " + aFuncDesc + ":<Fail.>  )"; break;
            }
            ShowStatusMsg(strMsg);

        }

        private void ShowStatusMsg(string astrMsg)
        {

            StaticMSG.Text = astrMsg;
        }

        private void DeleteFpTemplate(string astrDir, string astrFile)
        {
            string sFileName;
            sFileName = astrDir + "\\" + astrFile;
            File.Delete(sFileName);
        }

        private void SaveFpTemplate(int anTmplId, byte[] abytFpTmpl)
        {
            string strDir;
            string strF;
            byte[] bytFpTmpl = new byte[720];
            Array.Copy(abytFpTmpl, bytFpTmpl, 720);
            strDir = Directory.GetCurrentDirectory() + "\\templateDB";
            if (!Directory.Exists(strDir))
            {
                Directory.CreateDirectory(strDir);
            }

            strF = strDir + "\\" + Convert.ToString(anTmplId) + ".dat";

            FileStream vFileSream = File.OpenWrite(strF);
            vFileSream.Write(bytFpTmpl, 0, bytFpTmpl.Length);
            vFileSream.Close();
        }


        private void LoadAllFpTemplate()
        {
            string strDir;
            string strSearch;

            mdFunction.pisClearTptArray(m_nContextID);

            strDir = Directory.GetCurrentDirectory() + "\\templateDB\\";
            strSearch = "*.dat";
            try
            {
                string[] strSearchArray = Directory.GetFiles(strDir, strSearch); // <-- Case-insensitive

                // Display all files.

                foreach (string fileName in strSearchArray)
                {
                    //Console.WriteLine(fileName);
                    LoadFpTemplate(strDir, fileName);
                }
            }
            catch (Exception e)
            {
                
            }
        }

        private void LoadFpTemplate(string astrDir, string astrFile)
        {
            byte[] bytFpTmpl = new byte[720];
            int nRetVal;
            int nStartPos = 0;
            int nEndPos = 0;
            int nCnt = 0;
            string strTemp;
            int nTmplId;

            FileStream vFileSream = File.OpenRead(astrFile);
            vFileSream.Read(bytFpTmpl, 0, bytFpTmpl.Length);
            vFileSream.Close();
            nStartPos = astrFile.IndexOf("templateDB\\");
            nEndPos = astrFile.IndexOf(".dat");
            nCnt = nEndPos - nStartPos - 11;
            strTemp = astrFile.Substring(nStartPos + 11, nCnt);
            nTmplId = mdFunction.GetInt(strTemp);
            nRetVal = mdFunction.pisAddTptArray(m_nContextID, nTmplId, bytFpTmpl);

        }

        private void EnrollBtn_Click(object sender, EventArgs e)
        {
            int nRetVal;

            m_nID = mdFunction.GetInt(EnrollIDTxt.Text);
            if (m_nID < 1)
            {
                MessageBox.Show("Input Enroll ID correctly !", ALERT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            nRetVal = mdFunction.pisGetAtTptArray(m_nContextID, m_nID, m_pMemTemplateBuffer);
            if (nRetVal == mdFunction.PISFP_OK)
            {
                MessageBox.Show("Enroll ID (" + Convert.ToString(m_nID) + ") already used ! Try another number", ALERT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            EnableButtons(PIS_ACT, false);
            nEnrollTimer.Enabled = true;
            m_bStopFlag = false;
            m_nDoubleCheckFlag = true;
            m_nFpExtractCount = 0;
            m_nContinuosFpPressCount = 0;
            m_nFpExtractCount = 0;
            m_nCapFpStatus = 0;
            m_nMaxFpArea = 0;
        }

        private void nEnrollTimer_Tick(object sender, EventArgs e)
        {
            const int cnMaxContinuosFpPressCount = 5;
            int v_m_nIdentifiedID;
            int vnRet;
            byte[] bytFeatherBuffer = new byte[m_nFeatureSize];

            if (m_bStopFlag == true)
            {
                nEnrollTimer.Enabled = false;
                EnableButtons(PIS_ACT, true);
                if (m_nFpExtractCount == 3)
                {
                    vnRet = mdFunction.pisCreateTemplate(m_nContextID, m_pMemFeatureBuffer_1, m_pMemFeatureBuffer_2, m_pMemFeatureBuffer_3, m_pMemTemplateBuffer);
                    if (vnRet != mdFunction.PISFP_OK)
                    {
                        ShowErrorMsg(vnRet, mdFunction.ENROLL_PROC, mdFunction.CREATE_TEMPLATE_FUNC);
                        return;
                    }

                    ShowStatusMsg("Create template OK");
                    SaveFpTemplate(m_nID, m_pMemTemplateBuffer);
                    vnRet = mdFunction.pisAddTptArray(m_nContextID, m_nID, m_pMemTemplateBuffer);
                    if (vnRet != mdFunction.PISFP_OK)
                    {
                        ShowErrorMsg(vnRet, mdFunction.ENROLL_PROC, mdFunction.ADD_TPT_ARRAY_FUNC);
                        return;
                    }
                    ShowStatusMsg(Convert.ToString(m_nID) + " Enroll OK!");
                }
                return;
            }

            m_nIsFpImg = 0;

            vnRet = mdFunction.pisCapture(m_nContextID, m_pMemImgBuffer);

            if (vnRet != mdFunction.PISFP_OK)
            {
                ShowErrorMsg(vnRet, mdFunction.ENROLL_PROC, mdFunction.CAPTURE_FUNC);
                m_bStopFlag = true;
                return;
            }

            DrawFpImage(m_pMemImgBuffer, false);
            vnRet = mdFunction.pisCheckFp(m_nContextID, m_pMemImgBuffer, m_nImaWidth, m_nImaHeight, m_nImaRes, ref m_nIsFpImg, ref m_nFpArea);

            if (m_nCapFpStatus == CapFp_Init)
            {
                if (m_nIsFpImg != mdFunction.PISFP_OK)
                {
                    promptPressFinger(-1);
                    return;
                }
                else
                {
                    m_nCapFpStatus = CapFp_WaitPressFinger;
                    m_nContinuosFpPressCount = 0;
                }
            }



            if (m_nCapFpStatus == CapFp_WaitPressFinger)
            {
                if (m_nIsFpImg == mdFunction.PISFP_OK)
                {
                    promptPressFinger(m_nFpExtractCount + 1);
                    if (m_nContinuosFpPressCount < 2)
                    {
                        m_nContinuosFpPressCount = 0;
                        return;
                    }
                }

                if (m_nFpArea < GoodEnrollFpArea) m_nContinuosFpPressCount = 0;

                m_nContinuosFpPressCount = m_nContinuosFpPressCount + 1;

                if (m_nMaxFpArea < m_nFpArea)
                {
                    m_nMaxFpArea = m_nFpArea;
                    Array.Copy(m_pMemImgBuffer, m_pMemMaxAreaFpBuffer, IMAGE_SIZE);

                    if (m_nContinuosFpPressCount < cnMaxContinuosFpPressCount)
                        return;
                    else
                        m_nCapFpStatus = CapFp_GoodFpCaptured;

                }
                else if (3 * m_nMaxFpArea / 4 > m_nFpArea)
                {
                    if (m_nFpArea > GoodEnrollFpArea)
                        m_nCapFpStatus = CapFp_GoodFpCaptured;
                }
                else
                {
                    if (m_nContinuosFpPressCount < cnMaxContinuosFpPressCount)
                        return;
                    else
                        m_nCapFpStatus = CapFp_GoodFpCaptured;
                }


            }

            if (m_nCapFpStatus == CapFp_GoodFpCaptured)
            {
                vnRet = mdFunction.pisProcess(m_nContextID, m_pMemMaxAreaFpBuffer, m_nImaWidth, m_nImaHeight, m_nImaRes, bytFeatherBuffer);
                if (m_nFpExtractCount == 0)
                    Array.Copy(bytFeatherBuffer, m_pMemFeatureBuffer_1, m_nFeatureSize);
                else if (m_nFpExtractCount == 1)
                    Array.Copy(bytFeatherBuffer, m_pMemFeatureBuffer_2, m_nFeatureSize);
                else
                    Array.Copy(bytFeatherBuffer, m_pMemFeatureBuffer_3, m_nFeatureSize);


                if (vnRet != mdFunction.PISFP_OK)
                {
                    ShowErrorMsg(vnRet, mdFunction.ENROLL_PROC, mdFunction.PROCESS_FUNC);
                    m_bStopFlag = true;
                    return;
                }

                if (m_nDoubleCheckFlag == true)
                {
                    v_m_nIdentifiedID = 0;
                    vnRet = mdFunction.pisIdentify(m_nContextID, bytFeatherBuffer, ref v_m_nIdentifiedID, m_pMemTemplateUpdateBuffer, ref m_nUpdatedFlag);
                    if (vnRet == mdFunction.PISFP_OK)
                    {
                        ShowStatusMsg("This Fp is already enrolled with EnrollID:" + Convert.ToString(v_m_nIdentifiedID));
                        m_bStopFlag = true;
                        return;
                    }

                    m_nDoubleCheckFlag = false;
                }

                m_nFpExtractCount = m_nFpExtractCount + 1;
                m_nMaxFpArea = 0;
                m_nContinuosFpPressCount = 0;

                if (m_nFpExtractCount == 3)
                {
                    m_bStopFlag = true;
                    return;
                }
                else
                    m_nCapFpStatus = CapFp_PromptTakeoffFinger;

            }

            if (m_nCapFpStatus == CapFp_PromptTakeoffFinger)
            {
                if (m_nIsFpImg != mdFunction.PISFP_OK)
                {
                    promptPressFinger(-1);
                    return;
                }
                m_nCapFpStatus = CapFp_WaitPressFinger;
                return;
            }


        }

        private void ClearFpImage()
        {
            int anBkgGray = 240;
            fpImage.Image = Byte2Image(anBkgGray);

        }
        private void DrawFpImage(byte[] byteFpImage, Boolean IsSaved)
        {

            fpImage.Image = Byte2Image(byteFpImage);

        }


        private Image Byte2Image(int anBkgGray)
        {
            MemoryStream ImageStream;
            Image NewImage;
            int vFirstPosition = 54;
           
            for (int nIndex = 0; nIndex < 65536; nIndex++)
            {
                m_pBmpByteBuffer[vFirstPosition + nIndex * 3 + 0] = (Byte)anBkgGray;
                m_pBmpByteBuffer[vFirstPosition + nIndex * 3 + 1] = (Byte)anBkgGray;
                m_pBmpByteBuffer[vFirstPosition + nIndex * 3 + 2] = (Byte)anBkgGray;
            }


            ImageStream = new MemoryStream(m_pBmpByteBuffer);
            NewImage = Image.FromStream(ImageStream);
            return NewImage;


        }

        private Image Byte2Image(byte[] byteFpImage)
        {
            MemoryStream ImageStream;
            Image NewImage;
            int vFirstPosition = 54;
            
            for (int nIndex = 0; nIndex < byteFpImage.Length; nIndex++)
            {
                m_pBmpByteBuffer[vFirstPosition + nIndex * 3 + 0] = byteFpImage[byteFpImage.Length - nIndex - 1];
                m_pBmpByteBuffer[vFirstPosition + nIndex * 3 + 1] = byteFpImage[byteFpImage.Length - nIndex - 1];
                m_pBmpByteBuffer[vFirstPosition + nIndex * 3 + 2] = byteFpImage[byteFpImage.Length - nIndex - 1];
            }


            if (byteFpImage.GetUpperBound(0) > 0)
            {
                ImageStream = new MemoryStream(m_pBmpByteBuffer);
                NewImage = Image.FromStream(ImageStream);
            }
            else
                NewImage = null;
            return NewImage;
        }
        private void GetBitmapToByteArray()
        {
            //' 현단계에서는 바이트렬로 비트맵화상을 얻는 함수 부분인 우의 함수에서 메머리 침범오유가 나와서 할수없이 이렇게 하였다.
            try
            {
                String vBmpFilePath;
                vBmpFilePath = Directory.GetCurrentDirectory() + "\\1.bmp";
                Image myImage = Image.FromFile(vBmpFilePath);
                MemoryStream imgMemoryStream = new MemoryStream();
                byte[] imgByteArray;
                myImage.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                imgByteArray = imgMemoryStream.GetBuffer();
                Array.Copy(imgByteArray, m_pBmpByteBuffer, imgByteArray.Length);// mdFunction.BITMAP_SIZE);
            }
            catch (Exception e)
            {

            }
        }

        private void promptPressFinger(int fingerCount)
        {
            if (fingerCount == -2)
                ShowStatusMsg("FpArea is not enough,Please take off finger, and try again");
            else if (fingerCount == -1)
                ShowStatusMsg("Take off Finger");
            else if (fingerCount == 0)
                ShowStatusMsg("Press Finger");
            else
                ShowStatusMsg("Press Finger -" + Convert.ToString(fingerCount));

        }

       
        private void IdentifyBtn_Click(object sender, EventArgs e)
        {
            EnableButtons(PIS_ACT, false);
            nIdentifyTimer.Enabled = true;
            m_bStopFlag = false;
            m_nDoubleCheckFlag = true;
            m_nContinuosFpPressCount = 0;
            m_nCapFpStatus = 0;
            m_nMaxFpArea = 0;
        }

        private void nIdentifyTimer_Tick(object sender, EventArgs e)
        {
            const int cnMaxContinuosFpPressCount = 2;
            int vnRet;
            nIdentifyTimer.Interval = 10;

            if (m_bStopFlag == true)
            {
                nIdentifyTimer.Enabled = false;
                EnableButtons(PIS_ACT, true);
                if (m_nCapFpStatus == CapFp_Identify_OK)
                {
                    vnRet = mdFunction.pisIdentify(m_nContextID, m_pMemFeatureBuffer_1, ref m_nIdentifiedID, m_pMemTemplateUpdateBuffer, ref m_nUpdatedFlag);
                    if (vnRet != mdFunction.PISFP_OK)
                    {
                        ShowErrorMsg(vnRet, mdFunction.IDENTIFY_PROC, mdFunction.IDENTIFY_FUNC);
                        nIdentifyTimer.Interval = 1000;
                        nIdentifyTimer.Enabled = true;
                        EnableButtons(PIS_ACT, false);
                        m_nContinuosFpPressCount = 0;
                        m_nCapFpStatus = 0;
                        m_nMaxFpArea = 0;
                        m_bStopFlag = false;
                        return;
                    }
                    if (vnRet == mdFunction.PISFP_OK)
                    {
                        ShowStatusMsg("ID=" + Convert.ToString(m_nIdentifiedID) + " : Identify OK ");
                        EnableButtons(PIS_ACT, false);
                        nIdentifyTimer.Interval = 1000;
                        nIdentifyTimer.Enabled = true;

                        m_nContinuosFpPressCount = 0;
                        m_nCapFpStatus = 0;
                        m_nMaxFpArea = 0;
                        m_bStopFlag = false;
                        if (m_nUpdatedFlag == 1)
                        {
                            mdFunction.pisSetAtTptArray(m_nContextID, m_nIdentifiedID, m_pMemTemplateUpdateBuffer);
                            SaveFpTemplate(m_nIdentifiedID, m_pMemTemplateUpdateBuffer);
                        }
                    }
                }
                return;
            }
            m_nIsFpImg = 0;
            vnRet = mdFunction.pisCapture(m_nContextID, m_pMemImgBuffer);
            if (vnRet != mdFunction.PISFP_OK)
            {
                ShowErrorMsg(vnRet, mdFunction.IDENTIFY_PROC, mdFunction.CAPTURE_FUNC);
                m_bStopFlag = true;
                return;
            }

            DrawFpImage(m_pMemImgBuffer, false);

            vnRet = mdFunction.pisCheckFp(m_nContextID, m_pMemImgBuffer, m_nImaWidth, m_nImaHeight, m_nImaRes, ref m_nIsFpImg, ref m_nFpArea);

            if (m_nCapFpStatus == CapFp_Init)
            {
                if (m_nIsFpImg != mdFunction.PISFP_OK)
                {
                    promptPressFinger(-1);
                    return;
                }
                else
                {
                    m_nCapFpStatus = CapFp_WaitPressFinger;
                    m_nContinuosFpPressCount = 0;
                }
            }

            if (m_nCapFpStatus == CapFp_WaitPressFinger)
            {
                if (m_nIsFpImg == mdFunction.PISFP_OK)
                {
                    promptPressFinger(0);
                    if (m_nContinuosFpPressCount < 2)
                    {
                        m_nContinuosFpPressCount = 0;
                        return;
                    }
                }


                m_nContinuosFpPressCount = m_nContinuosFpPressCount + 1;
                if (m_nMaxFpArea < m_nFpArea)
                {
                    m_nMaxFpArea = m_nFpArea;
                    Array.Copy(m_pMemImgBuffer, m_pMemMaxAreaFpBuffer, IMAGE_SIZE);
                    if (m_nContinuosFpPressCount < cnMaxContinuosFpPressCount)
                    {
                        return;
                    }
                    else
                    {
                        m_nCapFpStatus = CapFp_GoodFpCaptured;
                    }
                }
                else if (3 * m_nMaxFpArea / 4 > m_nFpArea)
                {
                    m_nCapFpStatus = CapFp_GoodFpCaptured;
                }
                else
                {
                    if (m_nContinuosFpPressCount < cnMaxContinuosFpPressCount)
                        return;
                    else
                        m_nCapFpStatus = CapFp_GoodFpCaptured;

                }
            }

            if (m_nCapFpStatus == CapFp_GoodFpCaptured)
            {
                vnRet = mdFunction.pisProcess(m_nContextID, m_pMemMaxAreaFpBuffer, m_nImaWidth, m_nImaHeight, m_nImaRes, m_pMemFeatureBuffer_1);
                if (vnRet != mdFunction.PISFP_OK)
                {
                    ShowErrorMsg(vnRet, mdFunction.IDENTIFY_PROC, mdFunction.PROCESS_FUNC);
                    m_bStopFlag = true;
                    return;
                }

                DrawFpImage(m_pMemMaxAreaFpBuffer, false);
                m_nCapFpStatus = CapFp_Identify_OK;
                m_bStopFlag = true;
                return;
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            m_bStopFlag = true;
            ShowStatusMsg("Stoped!");
            EnableButtons(PIS_ACT, true);
        }

        private void GetCheckedImageBtn_Click(object sender, EventArgs e)
        {
            EnableButtons(PIS_ACT, false);
            nGetFpImageTimer.Enabled = true;
            m_bStopFlag = false;
            m_nContinuosFpPressCount = 0;
            m_nCapFpStatus = 0;
            m_nMaxFpArea = 0;
        }

        private void GetRawImageBtn_Click(object sender, EventArgs e)
        {
            int vnRet;
            byte[] pImgBuf = new byte[IMAGE_SIZE];

            vnRet = mdFunction.pisCapture(m_nContextID, pImgBuf);
            if (vnRet != mdFunction.PISFP_OK)
            {
                ShowStatusMsg("Error! Fail to capture image. Reopen the Ast2500 device");
                return;
            }
            DrawFpImage(pImgBuf, true);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int nEnrollId;
            int nRetVal;
            string strDir;
            string strF;
            nEnrollId = mdFunction.GetInt(EnrollIDTxt.Text);

            if (MessageBox.Show("Are you sure to delete Id :" + Convert.ToString(nEnrollId), ALERT_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (nEnrollId < 1)
            {
                MessageBox.Show("Delete Enroll ID correctly !", ALERT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            nRetVal = mdFunction.pisGetAtTptArray(m_nContextID, nEnrollId, m_pMemTemplateBuffer);
            if (nRetVal != mdFunction.PISFP_OK)
            {
                ShowStatusMsg("Not Exist (" + Convert.ToString(nEnrollId) + ");! Try another number");
                return;
            }

            nRetVal = mdFunction.pisDeleteAtTptArray(m_nContextID, nEnrollId);

            if (nRetVal != 0)
            {
                ShowStatusMsg("Error! Fail to delete one template from template array(ID=" + Convert.ToString(nEnrollId) + ")");
                return;
            }

            strDir = Directory.GetCurrentDirectory() + "\\templateDB";

            strF = Convert.ToString(nEnrollId) + ".dat";
            DeleteFpTemplate(strDir, strF);
            ShowStatusMsg("OK! Delete one template from template array(ID=" + Convert.ToString(nEnrollId) + ")");

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            string strDir;
            string strSearch;
            int vnRet;
            if (MessageBox.Show("Are you sure to delete all data?", ALERT_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            vnRet = mdFunction.pisClearTptArray(m_nContextID);
            if (vnRet != mdFunction.PISFP_OK)
            {
                ShowStatusMsg("Error! Fail to clear template array");
                return;
            }

            mdFunction.pisClearTptArray(m_nContextID);

            strDir = Directory.GetCurrentDirectory() + "\\templateDB\\";
            strSearch = "*.dat";
            try
            {
                string[] strSearchArray = Directory.GetFiles(strDir, strSearch); // <-- Case-insensitive

                // Display all files.

                foreach (string fileName in strSearchArray)
                {
                    File.Delete(fileName);
                }
            }
            catch (Exception ex)
            {
            }
            ShowStatusMsg("OK! Clear template array!");
        }

        private void GetCountBtn_Click(object sender, EventArgs e)
        {
            int nRetVal;
            int nCount;

            nCount = 0;
            nRetVal = mdFunction.pisGetCountTptArray(m_nContextID, ref nCount);
            if (nRetVal == mdFunction.PISFP_OK)
            {
                ShowStatusMsg("OK! template count =" + Convert.ToString(nCount));
            }
        }



        private void nGetFpImageTimer_Tick(object sender, EventArgs e)
        {
            const int cnMaxContinuosFpPressCount = 2;
            int vnRet;
            if (m_bStopFlag == true)
            {
                nGetFpImageTimer.Enabled = false;
                EnableButtons(PIS_ACT, true);
                m_nMaxFpArea = 0;
                return;
            }

            vnRet = mdFunction.pisCapture(m_nContextID, m_pMemImgBuffer);
            if (vnRet != mdFunction.PISFP_OK)
            {
                ShowErrorMsg(vnRet, mdFunction.CAP_FP_PROC, mdFunction.CAPTURE_FUNC);
                m_bStopFlag = true;
                m_nMaxFpArea = 0;
                return;
            }
            DrawFpImage(m_pMemImgBuffer, false);

            mdFunction.pisCheckFp(m_nContextID, m_pMemImgBuffer, m_nImaWidth, m_nImaHeight, m_nImaRes, ref m_nIsFpImg, ref m_nFpArea);

            if (m_nCapFpStatus == CapFp_Init)
            {
                if (m_nIsFpImg != mdFunction.PISFP_OK)
                {
                    promptPressFinger(-1);
                    return;
                }
                else
                {
                    m_nCapFpStatus = CapFp_WaitPressFinger;
                    m_nContinuosFpPressCount = 0;
                }
            }

            if (m_nCapFpStatus == CapFp_WaitPressFinger)
            {
                if (m_nIsFpImg == mdFunction.PISFP_OK)
                {
                    promptPressFinger(0);
                    if (m_nContinuosFpPressCount < 2)
                    {
                        m_nContinuosFpPressCount = 0;
                        return;
                    }
                }


                m_nContinuosFpPressCount = m_nContinuosFpPressCount + 1;
                if (m_nMaxFpArea < m_nFpArea)
                {
                    m_nMaxFpArea = m_nFpArea;
                    Array.Copy(m_pMemImgBuffer, m_pMemMaxAreaFpBuffer, IMAGE_SIZE);
                    if (m_nContinuosFpPressCount < cnMaxContinuosFpPressCount)
                        return;
                    else
                        m_nCapFpStatus = CapFp_GoodFpCaptured;
                }
                else if (3 * m_nMaxFpArea / 4 > m_nFpArea)
                {
                    m_nCapFpStatus = CapFp_GoodFpCaptured;
                }
                else
                {
                    if (m_nContinuosFpPressCount < cnMaxContinuosFpPressCount)
                        return;
                    else
                        m_nCapFpStatus = CapFp_GoodFpCaptured;

                }
            }

            if (m_nCapFpStatus == CapFp_GoodFpCaptured)
            {
                vnRet = mdFunction.pisProcess(m_nContextID, m_pMemMaxAreaFpBuffer, m_nImaWidth, m_nImaHeight, m_nImaRes, m_pMemFeatureBuffer_1);
                if (vnRet != mdFunction.PISFP_OK)
                {
                    ShowErrorMsg(vnRet, mdFunction.CAP_FP_PROC, mdFunction.PROCESS_FUNC);
                    m_bStopFlag = true;
                    return;
                }
                DrawFpImage(m_pMemMaxAreaFpBuffer, true);
                ShowStatusMsg("Sucess to get checked fp image! ");
                m_bStopFlag = true;
                return;
            }
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            int nRetVal;

            m_nIdentifiedID = mdFunction.GetInt(IdentifyIDTxt.Text);
            if (m_nIdentifiedID < 1)
            {
                MessageBox.Show("Input ID for verify ID !", ALERT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            nRetVal = mdFunction.pisGetAtTptArray(m_nContextID, m_nIdentifiedID, m_pMemTemplateBuffer);
            if (nRetVal != mdFunction.PISFP_OK)
            {
                MessageBox.Show("There is not exist ID (" + Convert.ToString(m_nIdentifiedID) + ")", ALERT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            EnableButtons(PIS_ACT, false);
            nVerifyTimer.Enabled = true;
            m_bStopFlag = false;
            m_nContinuosFpPressCount = 0;
            m_nCapFpStatus = 0;
            m_nMaxFpArea = 0;
        }

        private void nVerifyTimer_Tick(object sender, EventArgs e)
        {
            const int cnMaxContinuosFpPressCount = 2;
            int vnRet;
            nVerifyTimer.Interval = 30;
            if (m_bStopFlag == true)
            {
                nVerifyTimer.Enabled = false;
                EnableButtons(PIS_ACT, true);
                if (m_nCapFpStatus == CapFp_Identify_OK)
                {
                    vnRet = mdFunction.pisVerify(m_nContextID, m_pMemFeatureBuffer_1, m_pMemTemplateBuffer, m_pMemTemplateUpdateBuffer, ref m_nUpdatedFlag);
                    if (vnRet != mdFunction.PISFP_OK)
                    {
                        ShowErrorMsg(vnRet, mdFunction.VERIFY_PROC, mdFunction.VERIFY_FUNC);
                        return;
                    }
                    if (vnRet == mdFunction.PISFP_OK)
                    {
                        ShowStatusMsg("Verify OK ! (ID = " + Convert.ToString(m_nIdentifiedID) + ")");
                        m_nMaxFpArea = 0;
                        if (m_nUpdatedFlag == 1)
                        {
                            mdFunction.pisSetAtTptArray(m_nContextID, m_nIdentifiedID, m_pMemTemplateUpdateBuffer);
                            SaveFpTemplate(m_nIdentifiedID, m_pMemTemplateUpdateBuffer);
                        }
                    }
                }
                return;
            }

            vnRet = mdFunction.pisCapture(m_nContextID, m_pMemImgBuffer);
            if (vnRet != mdFunction.PISFP_OK)
            {
                ShowErrorMsg(vnRet, mdFunction.VERIFY_PROC, mdFunction.CAPTURE_FUNC);
                m_bStopFlag = true;
                return;
            }

            DrawFpImage(m_pMemImgBuffer, false);

            vnRet = mdFunction.pisCheckFp(m_nContextID, m_pMemImgBuffer, m_nImaWidth, m_nImaHeight, m_nImaRes, ref m_nIsFpImg, ref m_nFpArea);

            if (m_nCapFpStatus == CapFp_Init)
            {
                if (m_nIsFpImg != mdFunction.PISFP_OK)
                {
                    promptPressFinger(-1);
                    return;
                }
                else
                {
                    m_nCapFpStatus = CapFp_WaitPressFinger;
                    m_nContinuosFpPressCount = 0;
                }
            }

            if (m_nCapFpStatus == CapFp_WaitPressFinger)
            {
                if (m_nIsFpImg == mdFunction.PISFP_OK)
                {
                    promptPressFinger(0);
                    if (m_nContinuosFpPressCount < 2)
                    {
                        m_nContinuosFpPressCount = 0;
                        return;
                    }
                }


                m_nContinuosFpPressCount = m_nContinuosFpPressCount + 1;
                if (m_nMaxFpArea < m_nFpArea)
                {
                    m_nMaxFpArea = m_nFpArea;
                    Array.Copy(m_pMemImgBuffer, m_pMemMaxAreaFpBuffer, IMAGE_SIZE);
                    if (m_nContinuosFpPressCount < cnMaxContinuosFpPressCount)
                        return;
                    else
                        m_nCapFpStatus = CapFp_GoodFpCaptured;
                }
                else if (3 * m_nMaxFpArea / 4 > m_nFpArea)
                {
                    m_nCapFpStatus = CapFp_GoodFpCaptured;
                }
                else
                {
                    if (m_nContinuosFpPressCount < cnMaxContinuosFpPressCount)
                        return;
                    else
                        m_nCapFpStatus = CapFp_GoodFpCaptured;

                }
            }

            if (m_nCapFpStatus == CapFp_GoodFpCaptured)
            {
                vnRet = mdFunction.pisProcess(m_nContextID, m_pMemMaxAreaFpBuffer, m_nImaWidth, m_nImaHeight, m_nImaRes, m_pMemFeatureBuffer_1);
                if (vnRet != mdFunction.PISFP_OK)
                {
                    ShowErrorMsg(vnRet, mdFunction.VERIFY_PROC, mdFunction.PROCESS_FUNC);
                    m_bStopFlag = true;
                    return;
                }
                DrawFpImage(m_pMemMaxAreaFpBuffer, false);
                m_nCapFpStatus = CapFp_Identify_OK;
                m_bStopFlag = true;
                return;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            m_bStopFlag = true;
            EnableButtons(PIS_ACT, true);
            nGetFpImageTimer.Enabled = false;
            nIdentifyTimer.Enabled = false;
            nEnrollTimer.Enabled = false;
            nVerifyTimer.Enabled = false;
            if (mdFunction.pisCloseDevice(m_nContextID) != mdFunction.PISFP_OK) ShowStatusMsg("Error! pisCloseDevice failed!");
            if (mdFunction.pisDestroyContext(m_nContextID) != mdFunction.PISFP_OK) ShowStatusMsg("Error! pisDestroyContext failed!");

            EnableButtons(PIS_INIT, false);

            ShowStatusMsg("Exit OK! And Welcome!");
        }
       

        private void Ast2500CSDll_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitBtn_Click(sender, e);
        }

     
    }
      
}
