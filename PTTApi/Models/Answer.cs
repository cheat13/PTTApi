using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class Answer
    {
        /// <summary>
        /// ในกรณีข้อสอบ A ส่งมาเฉยๆ ก็ได้
        /// แต่ในกรณีข้อสอบ B และ C ต้องส่งมา เพราะคำตอบของ B, C ไม่ได้ผูกกับคำภามโดยตรง
        /// </summary>
        public int QuestionId { get; set; }

        /// <summary>
        /// ถ้าเป็นข้อสอบ A หมายถึง QuestionChoiceId
        /// ถ้าเป็นข้อสอบ B หรือ C หมายถึง ScoreScaleId
        /// </summary>
        public int AnswerId { get; set; }
    }
}
