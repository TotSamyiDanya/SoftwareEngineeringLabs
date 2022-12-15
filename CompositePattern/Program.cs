using CompositePattern.Core;
using System.ComponentModel;
Console.WriteLine("Composite Pattern!");
#region init
Box box = new() { Name = "Химия - коробка" };

Box box1 = new() { Name = "Химия - хозяйственная" };
Item item1 = new() { Name = "Хозяйственное Мыло", Price = 23.00 };
Item item2 = new() { Name = "Чистящее средство", Price = 133.54 };

Box box2 = new() { Name = "Химия - гигиеническая" };
Item item3 = new() { Name = "Шампунь", Price = 324.21 };
Item item4 = new() { Name = "Гель для душа", Price = 223.00 };
Item item5 = new() { Name = "Пена для бритья", Price = 73.00 };
Item item6 = new() { Name = "Станки для бритья", Price = 216.23 };
Item item7 = new() { Name = "Зубная паста Дракоша:)", Price = 100.23 };

#endregion
#region add
box1.Add(item1, item2);
box2.Add(item3, item4, item5);
box.Add(item6, item7, box1, box2);
Console.WriteLine(box.ToString());
#endregion
#region remove
Console.WriteLine("Посмотрим на коробку после удаления");
box.Remove(item4);
Console.WriteLine(box.ToString());
#endregion