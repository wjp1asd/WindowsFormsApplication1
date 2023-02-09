#include "stdafx.h"
#include "header.h"

HWND g_hWnd;
BOOL bOpenCom;
int iRow;
int g_iCmd;
DWORD g_wTime;
DWORD g_wPackNum;
BOOL bSendFlag;

unsigned char SendBuf[255];
unsigned char RecvBuf[255];

int GetComRate(int NoId)
{
	int ComRate = 0;

	switch(NoId)
	{
	case 0:
		ComRate = 9600;
		break;
	case 1:
		ComRate = 19200;
		break;
	case 2:
		ComRate = 38400;
		break;
	case 3:
		ComRate = 57600;
		break;
	case 4:
		ComRate = 115200;
		break;
	}
	return ComRate;
}

CString GetComName(int NoId)
{
	CString str = _T("");

	switch(NoId)
	{
	case 0:
		str = _T("COM1");
		break;
	case 1:
		str = _T("COM2");
		break;
	case 2:
		str = _T("COM3");
		break;
	case 3:
		str = _T("COM4");
		break;
	case 4:
		str = _T("COM5");
		break;
	case 5:
		str = _T("COM6");
		break;
	}
	return str;
}

unsigned char GetLrc(unsigned char *str, unsigned int Len)
{
	unsigned int i = 0;
	unsigned char Lrc = 0;

	for(i=0; i<Len; i++)
		Lrc ^= *(str+i);
	return Lrc;
}

int Pack(int Cmd, unsigned char *str)
{
	unsigned char lrc,buffer[25];

	str[0] = 0x02;
	str[1] = Cmd;
	str[2] = 0x00;

	switch(Cmd)
	{
	case 0x00:
		str[3] = 0x04;
		break;
	case 0x11:
		str[3] = 0x06;
		str[4] = 0x01;
		str[5] = 0x01;
		break;
	}

	memcpy(buffer, str, str[3]);
	lrc = GetLrc(str, str[3]);
	str[str[3]] = lrc;
	return (str[3]+1);
}





