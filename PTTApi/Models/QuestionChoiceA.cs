using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class QuestionChoiceA
    {
        public int Id { get; set; }
        public int QuestionAId { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }
    }
}
