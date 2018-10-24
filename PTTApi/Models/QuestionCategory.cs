using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class QuestionCategory
    {
        public int id { get; set; }   

        public int ProjectId { get; set; }

        public ExamType ExamType { get; set; }

        public string Name { get; set; }
       
    }
}
