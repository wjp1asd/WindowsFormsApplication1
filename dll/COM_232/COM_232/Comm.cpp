#include "stdafx.h"
#include "Comm.h"
#include "header.h"

OVERLAPPED m_Write, m_Read;//异步读写串口时用到的重叠结构
HANDLE 	m_hComm;
int ndata;

int i_SendNum = 5;//每条指令最多发送5次
BOOL OpenComm(CString pPort, int nBaudRate, int nParity, int nByteSize, int nStopBits)
{
	memset(&m_Read,0,sizeof(OVERLAPPED));
	memset(&m_Write,0,sizeof(OVERLAPPED));
    m_Write.hEvent = CreateEvent(NULL, TRUE, FALSE, NULL); 
    m_Read.hEvent = CreateEvent(NULL, TRUE, FALSE, NULL); 

	DCB dcb;		// 串口控制块
	COMMTIMEOUTS timeouts = {	// 串口超时控制参数
		30,				// 读字符间隔超时时间: 100 ms
		10,					// 读操作时每字符的时间: 1 ms (n个字符总共为n ms)
		20,				// 基本的(额外的)读超时时间: 20000 ms
		1,					// 写操作时每字符的时间: 1 ms (n个字符总共为n ms)
		10};				// 基本的(额外的)写超时时间: 100 ms
	m_hComm  = CreateFile(pPort,	// 串口名称或设备路径
			GENERIC_READ | GENERIC_WRITE,	// 读写方式
			0,				// 共享方式：独占
			NULL,			// 默认的安全描述符
			OPEN_EXISTING,	// 创建方式
			FILE_ATTRIBUTE_NORMAL|FILE_FLAG_OVERLAPPED, //异步 I/O 
			NULL);			// 不需参照模板文件
	int a = GetLastError();
	if(m_hComm == INVALID_HANDLE_VALUE)
	{		
		//AfxMessageBox(_T("Create Comm Error"));
		return FALSE;		// 打开串口失败
	}

	if(GetCommState(m_hComm, &dcb)==0)	// 取DCB
	{
		//AfxMessageBox(_T("Get configuration port has problem"));
		return FALSE;		// 打开串口失败
	}
	dcb.BaudRate = nBaudRate;
	dcb.ByteSize = nByteSize;
	dcb.Parity = nParity;
	dcb.StopBits = nStopBits;

	if(SetCommState(m_hComm, &dcb)==0)	// 设置DCB
	{
		//AfxMessageBox(_T("Set configuration port has problem"));
		return FALSE;		// 打开串口失败
	}

	SetupComm(m_hComm, 4096, 1024);	// 设置输入输出缓冲区大小

	SetCommTimeouts(m_hComm, &timeouts);	// 设置超时

	return TRUE;
}

// 关闭串口
BOOL CloseComm()
{
	return CloseHandle(m_hComm);
}

// 写串口
// 输入: pData - 待写的数据缓冲区指针
//       nLength - 待写的数据长度
// 返回: 实际写入的数据长度
BOOL WriteComm(void* pData, int nLength)
{
	if (m_hComm == INVALID_HANDLE_VALUE || m_hComm == NULL) //检查串口状态
    {      
		printf("Serial Port not OPEN or not present\n");
        return FALSE;
    }
	 
	DWORD nNumberOfBytesToWrite = nLength;				//将要写入串口长度 
    DWORD nNumberOfBytesWritten = 0;                    //实际写入长度
 
	COMSTAT Comstat;
	DWORD dwErrorFlags;
    ClearCommError(m_hComm,&dwErrorFlags,&Comstat);    

    // 向串口写字符串 
    BOOL bResult = WriteFile(   m_hComm,				 //串口句柄 
                                pData,			 // 想要发送的字符串
                                nNumberOfBytesToWrite,	 // 想要发送的字符串的长度 
                                &nNumberOfBytesWritten,  // 实际发送的字符串的长度 
								&m_Write);               // 异步发送所需要的重叠结构体 

 	if(!bResult) 
	 {       //如果写入不成功
 		if(GetLastError()==ERROR_IO_PENDING)//不成功的原因为这个时，表示写操作还未完成就返回FALSE
	 	{
			 //等待重叠结果
            bResult = GetOverlappedResult(  m_hComm,
                                            &m_Write,
                                            &nNumberOfBytesWritten,//实际发送的字符数
                                            TRUE);         // 如果操作未完成则等待
	 	}
 		else
	 		return FALSE;
	} 	 

	if ( nNumberOfBytesWritten != nNumberOfBytesToWrite ) 
    {
        return FALSE;
    }//如果实际写入的与需要写入的数据数不符，则返回失败 
    return TRUE;
}

// 读串口
// 输入: pData - 待读的数据缓冲区指针
//       nLength - 待读的最大数据长度
// 返回: 实际读出的数据长度
int ReadComm(void* pData, DWORD nLength)
{
	DWORD length = 0;
	COMSTAT ComStat;
	DWORD dwErrorFlags;
	DWORD nRealRead = 0;
	BOOL bReadStatus;            
	ClearCommError(m_hComm,&dwErrorFlags,&ComStat);//确定串口通讯状态
//	length = min(nLength,ComStat.cbInQue);//串口实际接收到的字节数与需要读入的字节数之间的小值。表示规定读的个数不能大于真实接收到的。
	length = 100;
	bReadStatus = ReadFile(m_hComm, (LPVOID)pData,nLength,&nLength,&m_Read);
	if(!bReadStatus)
	{
		if(GetLastError()==ERROR_IO_PENDING)
		{
			GetOverlappedResult(m_hComm, &m_Read, &nRealRead,TRUE);
			nLength = nRealRead;
		}
	}
	return nLength;
}






