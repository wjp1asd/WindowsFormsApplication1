
// COM_232.h : PROJECT_NAME Ӧ�ó������ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�ڰ������ļ�֮ǰ������stdafx.h�������� PCH �ļ�"
#endif

#include "resource.h"		// ������


// CCOM_232App:
// �йش����ʵ�֣������ COM_232.cpp
//

class CCOM_232App : public CWinApp
{
public:
	CCOM_232App();

// ��д
public:
	virtual BOOL InitInstance();

// ʵ��

	DECLARE_MESSAGE_MAP()
};

extern CCOM_232App theApp;