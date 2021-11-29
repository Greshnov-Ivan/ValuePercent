using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class BaseInfoLogic: BaseInfo
    {
        private double? _value;
        private double? _percent;

        public delegate void ValueHandler(BaseInfoLogic obj);
        public event ValueHandler UpdateValue;

        public override double? Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = Round(value);
                UpdateValue?.Invoke(this);
            }
        }
        public override double? Percent
        {
            get
            {
                return _percent;
            }
            protected set
            {
                _percent = Round(value);
            }
        }

        public void UpdatePercent(double? total)
        {
            if (total > 0)
                Percent = ((Value ?? 0) / total) * 100;
            else
                Percent = 0;
        }
        private double Round(double? value)
        {
            if (value == null)
                return 0;
            else
                return Math.Round((double)value, MidpointRounding.ToEven);
        }
    }
}
