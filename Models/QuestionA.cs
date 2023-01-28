using System;
namespace WindowsFormsApplication1
{
   public class QuestionA
    {
      
        String question1;
        String answer1;   
        String optionA1;
        String optionB1;
        String optionC1;
        String optionD1;
        String type;
      
        public string question { get => question1; set => question1 = value; }
        public string answer { get => answer1; set => answer1 = value; }
        public string optionA { get => optionA1; set => optionA1 = value; }
        public string optionB { get => optionB1; set => optionB1 = value; }
        public string optionC { get => optionC1; set => optionC1 = value; }
        public string optionD { get => optionD1; set => optionD1 = value; }
        public string Type { get => type; set => type = value; }
    }
}
