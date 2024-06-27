using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tax
{
    public enum VatNumberStatus
    {
        Unknown = 0,
        Empty = 10,
        Valid = 20,
        Invalid = 30
    }
}