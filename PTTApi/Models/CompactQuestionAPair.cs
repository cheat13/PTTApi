using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    /// <summary>
    /// เอาไว้ให้ Upload Answers (A) ตรวจสอบความถูกต้องของคำถาม-คำตอบ
    /// </summary>
    public class CompactQuestionAPair
    {
        public int QuestionId { get; set; }
        public int ChoiceId { get; set; }
    }
}
