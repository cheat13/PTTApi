using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class TestTaker
    {
        [Key]
        public int Id { get; set; }

        public string QR { get; set; }

        public int TestTakerGroupId { get; set; }

        public int? DriverId { get; set; }

        public string DriverCode { get; set; }
    }
}
