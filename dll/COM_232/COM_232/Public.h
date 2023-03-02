#pragma once


#define WM_SEE_START (WM_USER+1)

// CPublic

class CPublic : public CWnd
{
	DECLARE_DYNAMIC(CPublic)

public:
	CPublic();
	virtual ~CPublic();



protected:
	DECLARE_MESSAGE_MAP()
};


