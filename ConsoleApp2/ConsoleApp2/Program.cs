namespace ConsoleApp2
{
    public class Cstm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<OrderLine> Lines { get; set; }
    }
    public class OrderLine
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public override string ToString() => $"{ItemName}: {Price:C}";
    }

    class Program
    {
        static void Main()
        {   
            var customers = new List<Cstm>
        {
            new Cstm
            {
                Id = 1, Name = "Alice",
                Orders = new List<Order>
                {
                    new Order
                    {
                        Id = 1, Date = DateTime.Now,
                        Lines = new List<OrderLine>
                        {
                            new OrderLine { Id = 1, ItemName = "Laptop", Price = 1200 },
                            new OrderLine { Id = 2, ItemName = "Mouse", Price = 20 }
                        }
                    }
                }
            },
            new Cstm
            {
                Id = 2, Name = "Bob",
                Orders = new List<Order>
                {
                    new Order
                    {
                        Id = 2, Date = DateTime.Now,
                        Lines = new List<OrderLine>
                        {
                            new OrderLine { Id = 3, ItemName = "Keyboard", Price = 40 },
                            new OrderLine { Id = 4, ItemName = "Monitor", Price = 200 }
                        }
                    }
                }
            }
        };    
            var allOrderLines = customers
                .SelectMany(c => c.Orders)
                .SelectMany(o => o.Lines)
                .OrderBy(line => line.Price);

            Console.WriteLine("отсортированные по цене:");
            foreach (var line in allOrderLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
