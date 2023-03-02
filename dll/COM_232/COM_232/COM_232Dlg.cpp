
// COM_232Dlg.cpp : ʵ���ļ�
//

#include "stdafx.h"
#include "COM_232.h"
#include "COM_232Dlg.h"
#include "afxdialogex.h"
#include "header.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

DWORD g_nNumber;
// CCOM_232Dlg �Ի���


CCOM_232Dlg::CCOM_232Dlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CCOM_232Dlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CCOM_232Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_COM_SELECT, m_nComName);
	DDX_Control(pDX, IDC_BDRATE_SELECT, m_nComRate);
	DDX_Control(pDX, IDC_LIST1, m_cListData);
	DDX_Control(pDX, IDC_CHK_AUTO, m_bAutoRun);
	DDX_Text(pDX, IDC_TIME_EDT, g_nCycleTime);
	DDX_Text(pDX, IDC_NUM_EDT, g_mPackNum);
}

BEGIN_MESSAGE_MAP(CCOM_232Dlg, CDialogEx)
	ON_WM_PAINT()
//	ON_MESSAGE(WM_SEE_START, &SendRcv)
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDCANCEL, &CCOM_232Dlg::OnBnClickedCancel)
	ON_BN_CLICKED(IDOK, &CCOM_232Dlg::OnBnClickedOk)
	ON_WM_TIMER()
	ON_BN_CLICKED(IDC_CHK_AUTO, &CCOM_232Dlg::OnBnClickedChkAuto)
	ON_EN_CHANGE(IDC_TIME_EDT, &CCOM_232Dlg::OnEnChangeEdit1)
	ON_EN_CHANGE(IDC_NUM_EDT, &CCOM_232Dlg::OnEnChangeNumEdt)
END_MESSAGE_MAP()


// CCOM_232Dlg ��Ϣ�������

BOOL CCOM_232Dlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// ���ô˶Ի����ͼ�ꡣ��Ӧ�ó��������ڲ��ǶԻ���ʱ����ܽ��Զ�
	//  ִ�д˲���
	SetIcon(m_hIcon, TRUE);			// ���ô�ͼ��
	SetIcon(m_hIcon, FALSE);		// ����Сͼ��

	// TODO: �ڴ���Ӷ���ĳ�ʼ������
	g_hWnd = m_hWnd;
	bOpenCom = FALSE;
	bSendFlag = FALSE; 
	iRow = 0;
	g_nCycleTime = 1;
	g_wTime = 1;
	g_mPackNum = 1;
	g_nNumber = 1;
	g_wPackNum = g_mPackNum;

	m_nComName.SetCurSel(0);
	m_nComRate.SetCurSel(4);
	
	m_cListData.InsertColumn(0,_T("����"),LVCFMT_CENTER,100,-1);
	m_cListData.InsertColumn(1,_T("���ݰ�"), LVCFMT_LEFT,300,-1);
	m_cListData.InsertColumn(2,_T("ͨ��ֵ(mV)"), LVCFMT_LEFT,110,-1);
	m_cListData.SetExtendedStyle(LVS_EX_FULLROWSELECT|LVS_EX_GRIDLINES);
	UpdateData(FALSE);

	return TRUE;  // ���ǽ��������õ��ؼ������򷵻� TRUE
}

// �����Ի��������С����ť������Ҫ����Ĵ���
//  �����Ƹ�ͼ�ꡣ����ʹ���ĵ�/��ͼģ�͵� MFC Ӧ�ó���
//  �⽫�ɿ���Զ���ɡ�

void CCOM_232Dlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // ���ڻ��Ƶ��豸������

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// ʹͼ���ڹ����������о���
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// ����ͼ��
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

//���û��϶���С������ʱϵͳ���ô˺���ȡ�ù��
//��ʾ��
HCURSOR CCOM_232Dlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



void CCOM_232Dlg::OnBnClickedCancel()
{
	// TODO: �ڴ���ӿؼ�֪ͨ����������
	if(m_bAutoRun.GetCheck())
	{
		AfxMessageBox(_T("��ر��Զ����ͣ�"));
		return;
	}

	CloseComm();
	CDialogEx::OnCancel();
}

BOOL CCOM_232Dlg::OpenPort()
{
	CString ComName;
	int ComRate;

	if(TRUE == bOpenCom) CloseComm();

	ComName = GetComName(m_nComName.GetCurSel());
	ComRate = GetComRate(m_nComRate.GetCurSel());
	if (TRUE == OpenComm( ComName, ComRate))
	{
		bOpenCom = TRUE;
		return TRUE;
	}
	else
	{
		AfxMessageBox(_T("�򿪶˿�ʧ�ܣ�"));
		return FALSE;
	}
}

void CCOM_232Dlg::OnBnClickedOk()
{
	// TODO: �ڴ���ӿؼ�֪ͨ����������


	if (FALSE == OpenPort()) return;

	g_iCmd = 0x00;
	SendRcv(this);
	//PostMessage(WM_SEE_START, NULL,NULL);

	//CloseComm();
}


void CCOM_232Dlg::OnTimer(UINT_PTR nIDEvent)
{
	// TODO: �ڴ������Ϣ�����������/�����Ĭ��ֵ
	
	CDialogEx::OnTimer(nIDEvent);
}

BOOL SendRcv(LPVOID para)//WPARAM wParam, LPARAM IParam)
{
	int len,times = 3;

	memset(SendBuf, 0, sizeof(SendBuf));
	len = Pack(g_iCmd, SendBuf);

	DispList(para, SendBuf, SendBuf[3], 0);

	while( times-- > 0 )
	{
		if (FALSE == WriteComm(SendBuf, len)) continue;

		//Sleep(50);

		if (0 == ReadComm(RecvBuf, 100)) continue;
		else 
		{
			DispList(para, RecvBuf, RecvBuf[3], 1);
			g_nNumber++;
			return TRUE;
		}
	}

	//AfxMessageBox(_T("�˿ڷ���ʧ�ܣ�"));
	return FALSE;
}

void DispList(LPVOID para,unsigned char *str, int len, int flag)
{
	int xline;
	CString sptr, st;

	CCOM_232Dlg *dlg = (CCOM_232Dlg *) para;

	for(int i=0;i<len+1; i++)
	{
		sptr.Format(_T("%02x "), (unsigned char*)str[i]);
		st += sptr;	
	}

	if (iRow > 13) 
	{
		iRow = 0;
		dlg->m_cListData.DeleteAllItems();
	}
	if (flag == 0)
		sptr.Format(_T("Send:%ld"),g_nNumber);
	else
		sptr.Format(_T("Recv:%ld"),g_nNumber);

	xline = dlg->m_cListData.InsertItem(iRow, sptr);
	dlg->m_cListData.SetItemText(xline, 1, st); 

	if(g_iCmd == 0x11)
	{
		ULONG value1,value2;
		unsigned char buffer[25];			
		memcpy(buffer, str, 25);	

		if (0 == memcmp(buffer, "OK", 2))
		{
			value1 = buffer[4] * 0x00ffffff + buffer[5] * 0xffff + buffer[6] * 0xff + buffer[7];
			value2 = buffer[8] * 0x00ffffff + buffer[9] * 0xffff + buffer[10] * 0xff + buffer[11];
			sptr.Format(_T("%ld,%ld"), value1, value2);
			dlg->m_cListData.SetItemText(xline, 2, sptr); 
		}
	}
	iRow++;
}

void CCOM_232Dlg::OnBnClickedChkAuto()
{
	// TODO: �ڴ���ӿؼ�֪ͨ����������

	if(m_bAutoRun.GetCheck())
	{
		bSendFlag = TRUE;
		if ((bOpenCom == FALSE) &&(FALSE == OpenPort()))
		{
			m_bAutoRun.SetCheck(0);
			return;
		}	
		g_nNumber = 1;

		ButtonState(1);	
	}
	else
	{
		ButtonState(0);
		bSendFlag = FALSE;
		return;
	}

	AfxBeginThread((AFX_THREADPROC)ThreadProc,this);
}

void ThreadProc(LPVOID para)
{
	unsigned int i;

	while(bSendFlag&bOpenCom)
	{
		for(i=0;i<g_wPackNum; i++)
		{
			if (bSendFlag==FALSE) return;

			g_iCmd = 0x11;
			SendRcv(para);
		}
		//for(i=0; i<1000; i++)
			Sleep(g_wTime);
	}
	_endthread();	// ����ʡ�ԣ���������á�
}


void CCOM_232Dlg::OnEnChangeEdit1()
{
	// TODO:  ����ÿؼ��� RICHEDIT �ؼ���������
	// ���ʹ�֪ͨ��������д CDialogEx::OnInitDialog()
	// ���������� CRichEditCtrl().SetEventMask()��
	// ͬʱ�� ENM_CHANGE ��־�������㵽�����С�

	// TODO:  �ڴ���ӿؼ�֪ͨ����������
	if(m_bAutoRun.GetCheck())
	{
		AfxMessageBox(_T("��ر��Զ����ͣ�"));
		return;
	}

	CString str;
	GetDlgItem(IDC_TIME_EDT)->GetWindowTextW(str);
	if (str == "") return;
	
	UpdateData(TRUE);
	DWORD Time = g_nCycleTime;
	if (Time <= 0 || Time >= 1000000)
	{
		AfxMessageBox(_T("������Ч��Χ�ǣ�1--1000000"));
		g_nCycleTime = g_wTime;
		UpdateData(FALSE);
		return ;
	}

	g_wTime = g_nCycleTime;
}


void CCOM_232Dlg::OnEnChangeNumEdt()
{
	// TODO:  ����ÿؼ��� RICHEDIT �ؼ���������
	// ���ʹ�֪ͨ��������д CDialogEx::OnInitDialog()
	// ���������� CRichEditCtrl().SetEventMask()��
	// ͬʱ�� ENM_CHANGE ��־�������㵽�����С�

	// TODO:  �ڴ���ӿؼ�֪ͨ����������
	if(m_bAutoRun.GetCheck())
	{
		AfxMessageBox(_T("��ر��Զ����ͣ�"));
		return;
	}

	CString str;	
	GetDlgItem(IDC_NUM_EDT)->GetWindowTextW(str);
	if (str == "") return;
	
	UpdateData(TRUE);
	DWORD PackNum = g_mPackNum;
	if (PackNum <=0 || PackNum >= 1000000)
	{
		AfxMessageBox(_T("������Ч��Χ�ǣ�1--1000000"));
		g_mPackNum = g_wPackNum;
		UpdateData(FALSE);
		return ;
	}

	g_wPackNum = g_mPackNum;
}

void CCOM_232Dlg::ButtonState(char flag)
{
	switch(flag)
	{
	case 0://
		GetDlgItem(IDOK)->EnableWindow(true);
		GetDlgItem(IDC_COM_SELECT)->EnableWindow(true);
		GetDlgItem(IDC_BDRATE_SELECT)->EnableWindow(true);
		GetDlgItem(IDC_NUM_EDT)->EnableWindow(true);
		GetDlgItem(IDC_TIME_EDT)->EnableWindow(true);
		break;
	case 1://�Զ�����״̬
		GetDlgItem(IDOK)->EnableWindow(false);
		GetDlgItem(IDC_COM_SELECT)->EnableWindow(false);
		GetDlgItem(IDC_BDRATE_SELECT)->EnableWindow(false);
		GetDlgItem(IDC_NUM_EDT)->EnableWindow(false);
		GetDlgItem(IDC_TIME_EDT)->EnableWindow(false);
		break;
	}
}
