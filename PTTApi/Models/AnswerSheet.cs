using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class AnswerSheet
    {
        public string QR { get; set; }
        public ExamType ExamType { get; set; }

        public IEnumerable<Answer> AnswerList { get; set; }
        public IEnumerable<int> CommentIdList { get; set; }
    }

    /// <summary>
    /// ประเภทข้อสอบ
    /// </summary>
    public enum ExamType
    {
        A,
        B,
        C
    }
}
