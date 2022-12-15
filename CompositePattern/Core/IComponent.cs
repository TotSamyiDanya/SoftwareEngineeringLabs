using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Core
{
    internal interface IComponent
    {
        public string? Name { get; }
        public double? Price { get; }
    }
}
