#include "stdafx.h"
#include "Comm.h"
#include "header.h"

OVERLAPPED m_Write, m_Read;//�첽��д����ʱ�õ����ص��ṹ
HANDLE 	m_hComm;
int ndata;

int i_SendNum = 5;//ÿ��ָ����෢��5��
BOOL OpenComm(CString pPort, int nBaudRate, int nParity, int nByteSize, int nStopBits)
{
	memset(&m_Read,0,sizeof(OVERLAPPED));
	memset(&m_Write,0,sizeof(OVERLAPPED));
    m_Write.hEvent = CreateEvent(NULL, TRUE, FALSE, NULL); 
    m_Read.hEvent = CreateEvent(NULL, TRUE, FALSE, NULL); 

	DCB dcb;		// ���ڿ��ƿ�
	COMMTIMEOUTS timeouts = {	// ���ڳ�ʱ���Ʋ���
		30,				// ���ַ������ʱʱ��: 100 ms
		10,					// ������ʱÿ�ַ���ʱ��: 1 ms (n���ַ��ܹ�Ϊn ms)
		20,				// ������(�����)����ʱʱ��: 20000 ms
		1,					// д����ʱÿ�ַ���ʱ��: 1 ms (n���ַ��ܹ�Ϊn ms)
		10};				// ������(�����)д��ʱʱ��: 100 ms
	m_hComm  = CreateFile(pPort,	// �������ƻ��豸·��
			GENERIC_READ | GENERIC_WRITE,	// ��д��ʽ
			0,				// ����ʽ����ռ
			NULL,			// Ĭ�ϵİ�ȫ������
			OPEN_EXISTING,	// ������ʽ
			FILE_ATTRIBUTE_NORMAL|FILE_FLAG_OVERLAPPED, //�첽 I/O 
			NULL);			// �������ģ���ļ�
	int a = GetLastError();
	if(m_hComm == INVALID_HANDLE_VALUE)
	{		
		//AfxMessageBox(_T("Create Comm Error"));
		return FALSE;		// �򿪴���ʧ��
	}

	if(GetCommState(m_hComm, &dcb)==0)	// ȡDCB
	{
		//AfxMessageBox(_T("Get configuration port has problem"));
		return FALSE;		// �򿪴���ʧ��
	}
	dcb.BaudRate = nBaudRate;
	dcb.ByteSize = nByteSize;
	dcb.Parity = nParity;
	dcb.StopBits = nStopBits;

	if(SetCommState(m_hComm, &dcb)==0)	// ����DCB
	{
		//AfxMessageBox(_T("Set configuration port has problem"));
		return FALSE;		// �򿪴���ʧ��
	}

	SetupComm(m_hComm, 4096, 1024);	// �������������������С

	SetCommTimeouts(m_hComm, &timeouts);	// ���ó�ʱ

	return TRUE;
}

// �رմ���
BOOL CloseComm()
{
	return CloseHandle(m_hComm);
}

// д����
// ����: pData - ��д�����ݻ�����ָ��
//       nLength - ��д�����ݳ���
// ����: ʵ��д������ݳ���
BOOL WriteComm(void* pData, int nLength)
{
	if (m_hComm == INVALID_HANDLE_VALUE || m_hComm == NULL) //��鴮��״̬
    {      
		printf("Serial Port not OPEN or not present\n");
        return FALSE;
    }
	 
	DWORD nNumberOfBytesToWrite = nLength;				//��Ҫд�봮�ڳ��� 
    DWORD nNumberOfBytesWritten = 0;                    //ʵ��д�볤��
 
	COMSTAT Comstat;
	DWORD dwErrorFlags;
    ClearCommError(m_hComm,&dwErrorFlags,&Comstat);    

    // �򴮿�д�ַ��� 
    BOOL bResult = WriteFile(   m_hComm,				 //���ھ�� 
                                pData,			 // ��Ҫ���͵��ַ���
                                nNumberOfBytesToWrite,	 // ��Ҫ���͵��ַ����ĳ��� 
                                &nNumberOfBytesWritten,  // ʵ�ʷ��͵��ַ����ĳ��� 
								&m_Write);               // �첽��������Ҫ���ص��ṹ�� 

 	if(!bResult) 
	 {       //���д�벻�ɹ�
 		if(GetLastError()==ERROR_IO_PENDING)//���ɹ���ԭ��Ϊ���ʱ����ʾд������δ��ɾͷ���FALSE
	 	{
			 //�ȴ��ص����
            bResult = GetOverlappedResult(  m_hComm,
                                            &m_Write,
                                            &nNumberOfBytesWritten,//ʵ�ʷ��͵��ַ���
                                            TRUE);         // �������δ�����ȴ�
	 	}
 		else
	 		return FALSE;
	} 	 

	if ( nNumberOfBytesWritten != nNumberOfBytesToWrite ) 
    {
        return FALSE;
    }//���ʵ��д�������Ҫд����������������򷵻�ʧ�� 
    return TRUE;
}

// ������
// ����: pData - ���������ݻ�����ָ��
//       nLength - ������������ݳ���
// ����: ʵ�ʶ��������ݳ���
int ReadComm(void* pData, DWORD nLength)
{
	DWORD length = 0;
	COMSTAT ComStat;
	DWORD dwErrorFlags;
	DWORD nRealRead = 0;
	BOOL bReadStatus;            
	ClearCommError(m_hComm,&dwErrorFlags,&ComStat);//ȷ������ͨѶ״̬
//	length = min(nLength,ComStat.cbInQue);//����ʵ�ʽ��յ����ֽ�������Ҫ������ֽ���֮���Сֵ����ʾ�涨���ĸ������ܴ�����ʵ���յ��ġ�
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






