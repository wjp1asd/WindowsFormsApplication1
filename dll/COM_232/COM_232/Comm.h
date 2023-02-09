// Comm.h: interface for the CComm class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(COMM_H__)
#define COMM_H__

BOOL OpenComm(CString pPort, int nBaudRate=9600, int nParity=EVENPARITY, int nByteSize=8, int nStopBits=ONESTOPBIT);
BOOL CloseComm();
BOOL ReadComm(void* pData, DWORD nLength);
BOOL WriteComm(void* pData, int nLength);
BOOL ClearComm();
char CheckLRC(char *buf, int BufLen);
void __cdecl ThreadProc(void *para);

#endif // !defined(COMM_H__)

