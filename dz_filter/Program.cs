using dz_filter;
internal class Program
{
    static void Main(string[] args)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            var i1 = new Item { Name = "i1", Price = 125, Rating = 4.3 };
            var i2 = new Item { Name = "i2", Price = 175, Rating = 4.5 };
            var i3 = new Item { Name = "i3", Price = 225, Rating = 4.7 };
            var i4 = new Item { Name = "i4", Price = 275, Rating = 4.87 };
            var i5 = new Item { Name = "i5", Price = 325, Rating = 4.93 };
            db.Items.AddRange(i1, i2, i3, i4, i5);
            db.SaveChanges();
            var items1 = db.Items.Where(x => x.Name != "i2");
            var items2 = db.Items.Where(x => x.Rating >= 4.7);
            var items3 = db.Items.Where(x => x.Price < 225);
            foreach(Item item in items1)
                Console.WriteLine($"{item.Id} -> {item.Name} {item.Price} {item.Rating}");
            Console.WriteLine("*");
            foreach (Item item in items2)
                Console.WriteLine($"{item.Id} -> {item.Name} {item.Price} {item.Rating}");
            Console.WriteLine("*");
            foreach (Item item in items3)
                Console.WriteLine($"{item.Id} -> {item.Name} {item.Price} {item.Rating}");
        }
    }
}