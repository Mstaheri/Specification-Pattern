using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification_Pattern
{
    public class OrSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _first;
        private readonly ISpecification<T> _second;
        public OrSpecification(ISpecification<T> first , ISpecification<T> second)
        {
            _first = first;
            _second = second;
        }
        public bool IsSatisfiedBy(T item)
        {
            if (_first.IsSatisfiedBy(item) || _second.IsSatisfiedBy(item))
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
