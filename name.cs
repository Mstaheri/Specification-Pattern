using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification_Pattern
{
    public class name : ISpecification<user>
    {
        public bool IsSatisfiedBy(user item)
        {
            if (item.Name == "علی")
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
