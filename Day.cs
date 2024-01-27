using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification_Pattern
{
    public class Day : ISpecification<user>
    {
        public bool IsSatisfiedBy(user item)
        {
            if (item.day >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
