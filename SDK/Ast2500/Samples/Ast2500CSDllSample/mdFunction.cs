using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

public class mdFunction
    {
    // ===============================================================================
    // Ast2500 Interface Functions
    // ===============================================================================

    [DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisEnumerateDevice(int devOrderNumber,
                                                byte[] devId,
                                                byte[] devName);
	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisCreateContext( ref int contextId);

	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisDestroyContext( int contextId);

	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisOpenDevice( int contextId, string devId);

	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisCloseDevice( int contextId);
	
	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisGetInfo(int contextId, byte[] engineInfo,
								 ref int imaWidth,  ref int imaHeight,  ref int imaRes,
								 ref int featureSize, ref int templateSize );
	
	// capture fp
	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisCapture( int contextID,  byte[] imaBuffer);
	
	// extract feature & template
	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisCheckFp( int contextID, 
								 byte[] imaBuffer,
								 int imaWidth,  int imaHeight,  int imaRes,
								 ref int isCheckFp,  ref int fpArea);

	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)] 
    public static extern int pisProcess( int contextID, 
								 byte[]imaBuffer,
								 int imaWidth,
								 int imaHeight,
								 int imaRes, 
								 byte[]featureData);

	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisProcessImport( int contextID, 
								 byte[]importedImaBuffer,
								 int imaWidth,
								 int imaHeight,
								 int imaRes,
								 byte[]featureData);

	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisCreateTemplate( int contextID, 
								 byte[]featureData1, 
								 byte[]featureData2,
								 byte[]featureData3,
								 byte[]templateData);
	
	// match
	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisSetMatchParameter( int contextID,
										 int rotationRange,
										 int threshold);	
	
	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisVerify( int contextID, 
							 byte[]queryFeatureData, 
							 byte[]enrollTemplateData,
							 byte[]updatedTemplateData, 
							 ref int updatedFlag);
	
	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisIdentify( int contextID,
							 byte[]queryFeatureData,
							 ref int identifiedTID,
							 byte[]updatedTemplateData,
							 ref int updatedFlag);	
	
	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisVerifyTpl( int contextID, 
								 byte[]queryTemplateData, 
								 byte[]enrollTemplateData);
	
	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)]
    public static extern int pisIdentifyTpl( int contextID,
								 byte[]queryTemplateData,
								 ref int identifiedTID);

	// template array management
	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)] 
    public static extern int pisGetCountTptArray( int contextID,  ref int totalCounts);
	
	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)] 
    public static extern int pisAddTptArray( int contextID, 
									 int templateID, 
									 byte[]templateData);

	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)] 
    public static extern int pisDeleteAtTptArray( int contextID,  int templateID);

	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)] 
    public static extern int pisGetAtTptArray( int contextID, 
									 int templateID, 
									 byte[]templateData);

	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)] 
    public static extern int pisSetAtTptArray( int contextID, 
									 int templateID,
									 byte[]templateData);

	[DllImport("AST2500.dll", CharSet = CharSet.Ansi)] 
    public static extern int pisClearTptArray( int contextID);

	

    public const int PISFP_OK = 0;
    public const int PISFP_FAIL = 1;
    public const int PISFP_ERR_INVALID_CONTEXT = -101;
    public const int PISFP_ERR_NOT_CONNECT_DEV = -102;
    public const int PISFP_ERR_FUNC_PARAMETER = -103;
    public const int PISFP_ERR_SYSTEM_MEMORY_ALLOC = -104;
    public const int PISFP_ERR_TEMPLATE_ARRAY_OVER = -105;
    public const int PISFP_ERR_CONTEXT_OVER = -106;
    public const int PISFP_ERR_UNKNOWN = -107;
    public const int PISFP_ERR_DEV_STOP = -201;
    public const int PISFP_ERR_DEV_BUSY = -202;
    public const int PISFP_ERR_DEV_CONTROL = -203;
    public const int PISFP_ERR_PRO_FUNC = -301;
    public const int PISFP_MAX_CONTEXT_COUNTS = 4;
    public const int PISFP_MAX_DEVICE_COUNTS = 4;
    public const int PISFP_ENROLL_TIMES = 3;
    public const int PISFP_MIN_THRESHOLD = 1;
    public const int PISFP_MAX_THRESHOLD = 100;
    public const int PISFP_DEFAULT_THRESHOLD = 44;
    public const int PISFP_MIN_ROTATION_RANGE = 45;
    public const int PISFP_MAX_ROTATION_RANGE = 180;
    public const int PISFP_DEFAULT_ROTATION_RANGE = 45;
    public const int PISFP_MAX_RAW_IMAGE_RESOLUTION = 1000;
    public const int PISFP_MIN_RAW_IMAGE_RESOLUTION = 125;

    public const string INIT_PROC = "Init";
    public const string EXIT_PROC = "Exit";
    public const string ENROLL_PROC = "Enroll";
    public const string VERIFY_PROC = "Verify";
    public const string VERIFY_FAST_PROC = "VerifyFast";
    public const string IDENTIFY_PROC = "Identify";
    public const string DELETE_DATA_PROC = "DeleteData";
    public const string CAP_FP_PROC = "CaptureFp";

    public const string ENUMERATE_DEVICE_FUNC = "pisEnumerateDevice";
    public const string CREATE_CONTEXT_FUNC = "pisCreateContext";
    public const string DESTROY_CONTEXT_FUNC = "pisDestroyContext";
    public const string OPEN_DEVICE_FUNC = "pisOpenDevice";
    public const string CLOSE_DEVICE_FUNC = "pisCloseDevice";
    public const string GET_INFO_FUNC = "pisGetInfo";
    public const string CAPTURE_FUNC = "pisCapture";
    public const string CHECK_FP_FUNC = "pisCheckFp";
    public const string PROCESS_FUNC = "pisProcess";
    public const string PROCESSIMPORT_FUNC = "pisProcessImport";
    public const string CREATE_TEMPLATE_FUNC = "pisCreateTemplate";
    public const string CONVERT_TEMPLATE_FUNC = "pisConvertTemplate";
    public const string VERIFY_FUNC = "pisVerify";
    public const string IDENTIFY_FUNC = "pisIdentify";
    public const string SET_MATCH_PARAMETER_FUNC = "pisSetMatchParameter";
    public const string GET_COUNT_TPT_ARRAY_FUNC = "pisGetCountTptArray";
    public const string ADD_TPT_ARRAY_FUNC = "pisAddTptArray";
    public const string DELETE_TPT_ARRAY_FUNC = "pisDeleteTptArray";
    public const string GET_TPT_ARRAY_FUNC = "pisGetAtTptArray";
    public const string SET_TPT_ARRAY_FUNC = "pisSetAtTptArray";
    public const string CLEAR_TPT_ARRAY_FUNC = "pisClearTptArray";

   


    public const int BI_RGB = 0;
    public const int BITMAP_SIZE = 391788;

    public static void StringToByteArrayUtf16(String aString, byte[] aByteArray)
    {
        byte[] bytRet;
        int nBytesToCopy;

        Array.Clear(aByteArray, 0, aByteArray.Length);
        bytRet = System.Text.Encoding.GetEncoding("utf-16").GetBytes(aString);
        nBytesToCopy = bytRet.Length;
        if (nBytesToCopy > aByteArray.Length - 2)
            nBytesToCopy = aByteArray.Length - 2;
        Array.Copy(bytRet, aByteArray, nBytesToCopy);
    }

    public static String ByteArrayUtf16ToString(byte[] aByteArray)
    {
        string strRet = "";
        try
        {
            strRet = System.Text.Encoding.GetEncoding("utf-16").GetString(aByteArray, 0, aByteArray.Length);
            strRet = strRet.TrimEnd('\0');
        }
        catch (System.Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return strRet;
    }

    public static String ByteArrayUtf8ToString(byte[] aByteArray)
    {
        string strRet = "";
        try
        {
            strRet = System.Text.Encoding.GetEncoding("utf-8").GetString(aByteArray, 0, aByteArray.Length);
            strRet = strRet.TrimEnd('\0');
        }
        catch (System.Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return strRet;
    }

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
    public static int GetInt(string asVal)
    {
        try
        {
            return Convert.ToInt32(asVal);
        }
        catch
        {
            return 0;
        }
    }
}
