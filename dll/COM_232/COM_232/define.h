#ifndef DEFINE_H
#define DEFINE_H

extern HWND g_hWnd;
extern BOOL bOpenCom;
extern int iRow;
extern int g_iCmd;
extern DWORD g_wTime;
extern DWORD g_wPackNum;
extern BOOL bSendFlag;
extern unsigned char SendBuf[255];
extern unsigned char RecvBuf[255];

int GetComRate(int NoId);
CString GetComName(int NoId);

int Pack(int Cmd, unsigned char *str);

#endif