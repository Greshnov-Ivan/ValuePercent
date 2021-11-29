using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class BaseInfo
    {
        public virtual double? Value { get; set; }
        public virtual double? Percent { get; protected set; }
    }
}
