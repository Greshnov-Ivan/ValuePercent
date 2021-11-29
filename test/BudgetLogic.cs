using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class BudgetLogic: Budget
    {
        private double? total;

        /// <summary>
        /// Всего
        /// </summary>
        public override double? Total
        {
            get
            {
                return total;
            }

            protected set
            {
                total = value;
                Paid.UpdatePercent(Total);
                Cost.UpdatePercent(Total);
                RunRate.UpdatePercent(Total);
            }
        }

        public BudgetLogic()
        {
            Cost = new BaseInfoLogic();
            Paid = new BaseInfoLogic();
            RunRate = new BaseInfoLogic();
            Total = 0;

            Paid.UpdateValue += UpdateTotal;
            Cost.UpdateValue += UpdateTotal;
            RunRate.UpdateValue += UpdatePercent;
        }

        private void UpdateTotal(BaseInfoLogic obj)
        {
            Total = Paid.Value + Cost.Value;
            obj.UpdatePercent(Total);
        }

        private void UpdatePercent(BaseInfoLogic obj)
        {
            obj.UpdatePercent(Total);
        }
    }
}
