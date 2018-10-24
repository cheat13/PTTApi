using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class QuestionAMedia
    {
        public int Id { get; set; }

        public int QuestionAId { get; set; }

        public string MediaType { get; set; }

        public string MediaUrl { get; set; }
    }

    public enum MediaType
    {
        Img,
        Vdo
    }
}
