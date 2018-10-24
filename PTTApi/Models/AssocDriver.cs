using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTTApi.Models
{
    public class AssocDriver
    {
        public string Code { get; set; }

        public string FullName { get; set; }

        public int TestTakerGroupId { get; set; }

        public int SubCompanyId { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var right = obj as AssocDriver;
            return this.Code == right.Code && this.FullName == right.FullName
                && this.TestTakerGroupId == right.TestTakerGroupId && this.SubCompanyId == right.SubCompanyId;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return this.Code.GetHashCode() + this.SubCompanyId.GetHashCode();
        }
    }
}
