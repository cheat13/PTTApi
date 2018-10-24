using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    /// <summary>
    /// Use for derived uploaded driver data from Excel
    /// </summary>
    public class UploadDriver
    {
        public string Code { get; set; }

        public string FullName { get; set; }

        public string DriverTypeCode { get; set; }

        public string CompanyCode { get; set; }

        public string SubCompanyCode { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var r = obj as UploadDriver;
            return this.Code == r.Code && this.FullName == r.FullName && this.DriverTypeCode == r.DriverTypeCode
                && this.CompanyCode == r.CompanyCode && this.SubCompanyCode == r.SubCompanyCode;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return this.Code.GetHashCode() + this.SubCompanyCode.GetHashCode();
        }
    }
}
