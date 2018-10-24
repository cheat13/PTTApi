using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        public string Code { get; set; }

        public string FullName { get; set; }

        public int TestTakerGroupId { get; set; }

        public string TestTakerGroupName { get; set; }

        public string QR { get; set; }

        public int SubCompanyId { get; set; }
       
    }
}
