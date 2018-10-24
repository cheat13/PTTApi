using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    /// <summary>
    /// ใช้ตอน upload คำตอบของ question c
    /// </summary>
    public class CompactQuestionCComment
    {
        public int QuestionId { get; set; }
        public int CommentId { get; set; }
    }
}
