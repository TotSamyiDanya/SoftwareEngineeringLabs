using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CompositePattern.Core
{
    internal class Item : IComponent
    {
        public string? Name { get; set; }
        public double? Price { get; set; }
        public override string ToString() => $"Название: {Name} " + $"Цена: {Price} руб.";
    }
}
