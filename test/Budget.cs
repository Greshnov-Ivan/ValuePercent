using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Budget
    {
        /// <summary>
        /// Всего
        /// </summary>
        public virtual double? Total { get; protected set; }

        /// <summary>
        /// Расходы
        /// </summary>
        public BaseInfoLogic Paid { get; set; }

        /// <summary>
        /// Остаток
        /// </summary>
        public BaseInfoLogic Cost { get; set; }

        /// <summary>
        /// RunRate
        /// </summary>
        public BaseInfoLogic RunRate { get; set; }
    }
}
