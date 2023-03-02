
// COM_232Dlg.h : 头文件
//

#pragma once
#include "afxwin.h"
#include "afxcmn.h"
#include "Public.h"

void  ThreadProc(LPVOID para);
BOOL SendRcv(LPVOID para);
void DispList(LPVOID para,unsigned char *str, int len, int flag);

// CCOM_232Dlg 对话框
class CCOM_232Dlg : public CDialogEx
{
// 构造
public:
	CCOM_232Dlg(CWnd* pParent = NULL);	// 标准构造函数

// 对话框数据
	enum { IDD = IDD_COM_232_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 支持


// 实现
protected:
	HICON m_hIcon;

	// 生成的消息映射函数
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	//afx_msg LRESULT SendRcv(WPARAM wParam, LPARAM IParam);	
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedCancel();
	afx_msg void OnBnClickedOk();
	CComboBox m_nComName;
	CComboBox m_nComRate;
	CListCtrl m_cListData;
	afx_msg void OnTimer(UINT_PTR nIDEvent);

	CPublic cpub;
	CButton m_bAutoRun;
	afx_msg void OnBnClickedChkAuto();

	BOOL OpenPort();
	

	DWORD g_nCycleTime;
	afx_msg void OnEnChangeEdit1();
	DWORD g_mPackNum;
	afx_msg void OnEnChangeNumEdt();
	void ButtonState(char flag);
};
