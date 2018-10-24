using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class ZipExamA
    {
        public File Excel { get; set; }
        public IEnumerable<File> Images { get; set; }
        public IEnumerable<File> Videos { get; set; }       

        public class File
        {
            public string FullName { get; set; }
            public string Name { get; set; }           
        }
    }
}
