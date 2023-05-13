using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
   public class Grade
    {
        string name;
        string idcard;
        string testid;
        // 离线题目
        string lxquestions;
        // 离线回答
        string lxanswer;
        // 离线正确性
        string lxcorrect;
        string score1;
        // 在线题
        string zxquestions;
        string zxanswer;
        string zxcorrect;
        string score2; 
        //校验题
        string jyquestions;
        string jyanswer;
        string jycorrect;
        string score3;
        //型号题
        string xhquestions;
        string xhanswer;
        string xhcorrect;
        string score4;
        //零配件
        string lpjquestions;
        string lpjanswer;
        string lpjcorrect;
        string score5;
        //研磨膏
        string ymgquestions;
        string ymganswer;
        string ymgcorrect;
        string score6;
        //密封面
        string path;
        string score7;

    }
}
