using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsFormsApplication1
{
    public enum ReaderPortNum
    {
        SDT_COM1 = 1, SDT_COM2, SDT_COM3, SDT_COM4, SDT_COM5, SDT_COM6, SDT_COM7, SDT_COM8, SDT_COM9, SDT_COM10, SDT_COM11, SDT_COM12, SDT_COM13, SDT_COM14, SDT_COM15, SDT_COM16,
        SDT_USB1 = 1001, SDT_USB2, SDT_USB3, SDT_USB4, SDT_USB5, SDT_USB6, SDT_USB7, SDT_USB8, SDT_USB9, SDT_USB10, SDT_USB11, SDT_USB12, SDT_USB13, SDT_USB14, SDT_USB15, SDT_USB16,
        HID = 2401, RF200_COM1 = 2501, RF200_COM2, RF200_COM3, RF200_COM4, RF200_COM5, RF200_COM6
    };

    public enum ReaderSlotNum
    {
        TypeA = 1, TypeB, ISO15693, DN, Mifare1, SmartCard, PsamCard
    };

    class IDCardReader
    {
        #region 民族表
        static public string[] Nation = {"无",
        "汉族","蒙古族","回族","藏族","维吾尔族",
        "苗族","彝族","壮族","布依族","朝鲜族",
        "满族",
        "侗族",
        "瑶族",
        "白族",
        "土家族",
        "哈尼族",
        "哈萨克族",
        "傣族",
        "黎族",
        "傈僳族",
        "佤族",
        "畲族",
        "高山族",
        "拉祜族",
        "水族",
        "东乡族",
        "纳西族",
        "景颇族",
        "柯尔克孜族",
        "土族",
        "达斡尔族",
        "仫佬族",
        "羌族",
        "布朗族",
        "撒拉族",
        "毛难族",
        "仡佬族",
        "锡伯族",
        "阿昌族",
        "普米族",
        "塔吉克族",
        "怒族",
        "乌孜别克",
        "俄罗斯族",
        "鄂温克族",
        "崩龙族",
        "保安族",
        "裕固族",
        "京族",
        "塔塔尔族",
        "独龙族",
        "鄂伦春族",
        "赫哲族",
        "门巴族",
        "珞巴族",
        "其它",
        "外国血统"};
        #endregion

        #region 导入函数
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int Buzzer(byte beepTime, byte waitTime, byte beepCount);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int InitComm(ReaderPortNum port);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int CloseComm();

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int Authenticate();

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int Read_Content(int active);

        [DllImport("termb.dll", CharSet = CharSet.Ansi)]
        public static extern int Read_Content_Path(string path, int active);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int GetSAMID(ref byte id);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int TransApduCommand(ReaderSlotNum nReaderSlot, ref byte pSendDatas, int nSendLen, ref byte pRecvDatas, ref int nRecvLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int ActivateCard(ReaderSlotNum nReaderSlot, ref byte pRecvDatas, ref int nRecvLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int SetAntPower(int nPowerOn);

        #region ISO7816
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int ISO7816_CardInsert(ReaderSlotNum nSlot);
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int ISO7816_CardRemove(ReaderSlotNum nSlot);
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int ISO7816_TransApdu(ReaderSlotNum nReaderSlot, ref byte pSendDatas, int nSendLen, ref byte pRecvDatas, ref int nRecvLen);
        #endregion

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int ISO14443_TransApdu(ReaderSlotNum nReaderSlot, ref byte pSendDatas, int nSendLen, ref byte pRecvDatas, ref int nRecvLen);

        #region  ISO15693标签
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_ReadSingleBlock(bool readSecSta, int nBlkAddr, ref byte bufBlockDat, int nSize, ref int bytesBlkDatRead);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_WriteSingleBlock(int blkAddr, ref byte newBlkData, int bytesToWrite);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_ReadMultiBlocks(bool readSecSta, int nBlkAddr, int numOfBlksToRead, ref int numOfBlksRead, ref byte bufBlockDat, int nSize, ref int bytesBlkDatRead);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_WriteMultipleBlocks(int blkAddr, int numOfBlks, ref byte newBlkData, int bytesToWrite);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_GetBlockSecStatus(int blkAddr, int numOfBlks, ref byte bufBlkSecs, int nSize, ref int bytesSecRead);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_GetSystemInfo(ref byte uid, ref byte dsfid, ref byte afi, ref int blkSize, ref int numOfBloks, ref byte icRef);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_LockMultipleBlocks(int blkAddr, int numOfBlks);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_WriteAFI(byte afi);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_LockAFI();

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_WriteDSFID(byte dsfid);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_LockDSFID();

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern int ISO15693_Inventory(byte afi, ref byte[] bufUids, int nSize, ref int bytesUidNums);
        #endregion


        //---------------------------------------------------------------------------
        //MIFARE卡相关函数
        //---------------------------------------------------------------------------
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int MIFARE_Authentication(byte bSectorNo, byte[] pbKeyA, byte[] pbKeyB);
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int MIFARE_ReadData(byte bBlock, ref byte data, int nLen);
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int MIFARE_WrtieData(byte bBlock, byte[] data, int nLen);
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int MIFARE_IncrementValue(byte bBlock, int nValue);
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int MIFARE_DecrementValue(byte bBlock, int nValue);
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int MIFARE_ReadValue(byte bBlock, ref int pnValue);
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int MIFARE_InitValue(byte bBlock, int nValue);
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int MIFARE_WriteSectorTrailer(byte bBlock, byte[] pbKEYA, byte[] pbKEYB, byte[] pbAccessBits);

        #region 第二代居民身份证
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetName2(ref byte sName, ref int nLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetSex2(ref byte sBuf, ref int nLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetNation2(ref byte sBuf, ref int nLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetBornDate2(ref byte sBuf, ref int nLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetAddress2(ref byte sBuf, ref int nLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetIDNo2(ref byte sBuf, ref int nLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetSignGov2(ref byte sBuf, ref int nLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetStartDate2(ref byte sBuf, ref int nLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetEndDate2(ref byte sBuf, ref int nLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetNewAddress2(ref byte sBuf, ref int nLen);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFingerPrint(ref byte sBuf, ref int nLen);

        [DllImport("termb.dll", CharSet = CharSet.Ansi)]
        public static extern unsafe bool MakeIDCardImages(string sHead, string sIDCardImagePath);

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetPhoto(ref byte sBuf, ref int nLen);
        #endregion

        #region 外国人永久居住证
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int IsFPRIDCard();//是否是外国人居住证

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_ENName2(ref byte sBuf, ref int nLen);//英文名

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_SEX2(ref byte sBuf, ref int nLen);//性别

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_IDNo2(ref byte sBuf, ref int nLen);//身份证号

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_NationCode2(ref byte sBuf, ref int nLen);//国籍代码

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_Nation2(ref byte sBuf, ref int nLen);//国籍代码中文()

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_CHNName2(ref byte sBuf, ref int nLen);//中文姓名

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_ValidStartDate2(ref byte sBuf, ref int nLen);//证件签发时间

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_ValidEndDate2(ref byte sBuf, ref int nLen);//证件终止时间

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_Birthday2(ref byte sBuf, ref int nLen);//出生日期

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_IDVersion2(ref byte sBuf, ref int nLen);//证件版本号

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_IssuingAuthorityCode2(ref byte sBuf, ref int nLen);//当次申请受理机关代码

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetFPR_IDType2(ref byte sBuf, ref int nLen);//证件类型标识
        #endregion

        #region 港澳台居民居住证
        //---------------------------------------------------------------------------
        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe int IsGATIDCard();//是否港澳台居民居住证

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetGAT_Name2(ref byte sBuf, ref int nLen);//姓名

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetGAT_SEX2(ref byte sBuf, ref int nLen);//性别

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetGAT_SEXCode2(ref byte sBuf, ref int nLen);//性别代码

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetGAT_Address2(ref byte sBuf, ref int nLen);//详细地址

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetGAT_IDNo2(ref byte sBuf, ref int nLen);//公民身份证号码

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetGAT_IssuingAuthority2(ref byte sBuf, ref int nLen);//签发机关

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetGAT_ValidStartDate2(ref byte sBuf, ref int nLen);//有效起始日期

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetGAT_ValidEndDate2(ref byte sBuf, ref int nLen);//有效截至日期

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetGAT_PassportNo2(ref byte sBuf, ref int nLen);//通行证号码(

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetGAT_IssuanceCount2(ref byte sBuf, ref int nLen);//签发次数

        [DllImport("termb.dll", CharSet = CharSet.Auto)]
        public static extern unsafe bool GetGAT_IDType2(ref byte sBuf, ref int nLen);//证件类型标识(2B),大写字母J

        #endregion
        #endregion

        #region 调用测试
        public static string GetSAMNo()
        {
            byte[] bySAMID = new byte[100];
            int nRet = IDCardReader.GetSAMID(ref bySAMID[0]);
            if (nRet == 0)
                return System.Text.Encoding.GetEncoding("GB2312").GetString(bySAMID);
            return string.Empty;
        }

        public static bool TransCommand(ReaderSlotNum nReaderSlot, string sReq, out string sResp)
        {
            byte[] bySendData = StrToHexByte(sReq);
            byte[] byRecvData = new byte[270];
            int nLen = 0;
            int nRet = IDCardReader.TransApduCommand(nReaderSlot, ref bySendData[0], bySendData.Length, ref byRecvData[0], ref nLen);

            sResp = "";
            if (nRet != 0 || (byRecvData[0] != 0x00 && byRecvData[1] != 0x00))
            {
                sResp = HexByteToStr(byRecvData, nLen);//nRet.ToString();
                return false;
            }
            byte[] byRecvData2 = new byte[nLen - 2];
            Array.Copy(byRecvData, 2, byRecvData2, 0, nLen - 2);
            sResp = HexByteToStr(byRecvData2, nLen - 2);
            return true;
        }

        public static string GetFwVersion()
        {
            string sGetVersion = "31 14";
            byte[] bySendData;
            byte[] byRecvData = new byte[200];
            int nLen = 0;
            bySendData = StrToHexByte(sGetVersion);
            int nRet = IDCardReader.TransApduCommand(0, ref bySendData[0], bySendData.Length, ref byRecvData[0], ref nLen);
            if (nRet == 0)
            {
                int m = byRecvData[2];
                int n = byRecvData[3];
                int o = byRecvData[4];
                string sVersion = "Ver " + m + "." + n + "." + o;
                return sVersion;
            }
            return "";
        }

        public static bool TransApdu(ReaderSlotNum nReaderSlot, string sReq, out string sResp)
        {
            byte[] bySendData = StrToHexByte(sReq);
            byte[] byRecvData = new byte[270];
            int nLen = 0;
            int nRet = IDCardReader.ISO14443_TransApdu(nReaderSlot, ref bySendData[0], bySendData.Length, ref byRecvData[0], ref nLen);

            sResp = "";
            if (nRet != 0)
            {
                sResp = nRet.ToString();
                return false;
            }
            sResp = HexByteToStr(byRecvData, nLen);
            return true;
        }
        #endregion

        #region 工具函数
        public static byte[] StrToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        public static string HexByteToStr(byte[] hexbytes, int bytelen)
        {
            string formattext = "";
            for (int myi = 0; myi < bytelen; myi++)
            {
                formattext += string.Format("{0:X2}", hexbytes[myi]);
            }
            return formattext;
        }


        public static byte[] StrToByteArray(string str)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            return encoding.GetBytes(str);
        }

        public static string ByteArrayToStr(byte[] barr)
        {
            System.Text.UnicodeEncoding encoding = new UnicodeEncoding();
            return encoding.GetString(barr);
        }
        #endregion
    }
}
