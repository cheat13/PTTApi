using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? LunchDateTime { get; set; }
        public DateTime? CloseDateTime { get; set; }
        public string Prefix { get; set; }
        public DateTime? LastUpdateDriverDateTime { get; set; }
        public DateTime? LastUpdateExamADateTime { get; set; }
        public DateTime? LastUpdateExamBDateTime { get; set; }
        public DateTime? LastUpdateExamCDateTime { get; set; }
        public string DownloadExcelDriverPath { get; set; }
        public string DownloadExcelExamAPath { get; set; }
        public string DownloadExcelExamBPath { get; set; }
        public string DownloadExcelExamCPath { get; set; }
    }
}
