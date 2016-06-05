using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvestmentTracker
{
    public partial class MutualFund
    {
        public string DisplayText
        {
            get
            {
                return String.Format("{0} ({1})", this.MutualFundDescription, this.MutualFundSymbol);
            }
        }
    }
}
