using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class ExamA
    {
        public string[] ChoiceHeader { get; set; }

        public int TestTakerGroupId { get; set; }

        public IEnumerable<Sheet1Question> Questions { get; set; }

        public class Sheet1Question
        {
            public int QuestionNo { get; set; }
            public string Question { get; set; }
            public string Answer { get; set; }
            public int CategoryID { get; set; }
            public bool NoRandom { get; set; }
            public IEnumerable<Choice> ChoiceContents { get; set; }

            public IEnumerable<Media> MediasContents { get; set; }

            public class Choice
            {
                public string Content { get; set; }

                public bool IsCorrect { get; set; }
            }

            public class Media
            {
                public MediaType MediaType { get; set; }

                public string MediaUrl { get; set; }
            }

        }

      
    }
}
