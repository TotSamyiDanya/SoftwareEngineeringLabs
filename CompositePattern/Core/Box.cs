using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Core
{
    internal class Box : IComponent
    {
        public string? Name { get; set; }
        public double? Price { get { return _components.Select(c => c.Price).Sum(); }}
        private List<IComponent> _components;
        public Box() { _components = new List<IComponent>(); }
        public void Add(params IComponent[] comps) => _components.AddRange(comps);
        public void Remove(params IComponent[] comps)
        {
            foreach (IComponent comp in comps)
            {
                IComponent? result = Find(this, comp, 1);
                if (result == null)
                    Console.WriteLine($"{comp.Name} нет в указанном месте");
                else
                    Console.WriteLine($"{comp.Name} удален");
            }
        }
        public override string ToString()
        {
            string result = $"Коробка - {Name}. Общая стоимость: {Price} руб.\n";
            result += "\tСодержимое коробки:\n";
            return result += string.Join('\n', _components.Select(x => $"{(x is Box ? "\t" : "\t\t")}{x.ToString()}"));
        }
        public override bool Equals(object? obj)
        {
            if (obj is IComponent component)
                if (Name == component.Name && Price == component.Price)
                    return true;
            return false;
        }
        private IComponent? Find(Box box, IComponent comp, int s = 0)
        {
            IComponent? result = null; int command = s;
            if (box._components.Exists(c => c.Equals(comp)))
                switch (command)
                {
                    case 0:
                        return comp;
                    case 1:
                        box._components.Remove(comp);
                        return comp;
                }
            else
                foreach (IComponent component in box._components)
                    if (component is Box boxChild)
                        result = Find(boxChild, comp, command);
            return result;
        }
    }
}
