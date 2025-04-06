namespace ConsoleApp1
{
        public class Phone
        {
            public string Name { get; set; }
            public string Manufact { get; set; }
            public decimal Price { get; set; }
            public DateTime RealsDat { get; set; }
        }

        class Program
        {
            static void Main()
            {
                Phone[] phones = new Phone[]
                {
            new Phone { Name = "Galaxy S21", Manufact = "Samsung", Price = 800, RealsDat = new DateTime(2021, 1, 14) },
            new Phone { Name = "iPhone 13", Manufact = "Apple", Price = 999, RealsDat = new DateTime(2021, 9, 24) },
            new Phone { Name = "Pixel 6", Manufact = "Google", Price = 599, RealsDat = new DateTime(2021, 10, 28) },
            new Phone { Name = "Xiaomi Mi 11", Manufact = "Xiaomi", Price = 749, RealsDat = new DateTime(2020, 12, 28) },
            new Phone { Name = "OnePlus 9", Manufact = "OnePlus", Price = 729, RealsDat = new DateTime(2021, 3, 23) }
                };

                int totalPhones = phones.Count();
                Console.WriteLine($"Общее количество телефонов: {totalPhones}");

                int countOver100 = phones.Count(p => p.Price > 100);
                Console.WriteLine($"Телефонов дороже 100: {countOver100}");

                int count400to700 = phones.Count(p => p.Price >= 400 && p.Price <= 700);
                Console.WriteLine($"Телефонов от 400 до 700: {count400to700}");

                string manufacturer = "Apple";
                int manufact = phones.Count(p => p.Manufact == manufacturer);
                Console.WriteLine($"{manufacturer} телефонов: {manufact}");

                Phone minPricePhone = phones.OrderBy(p => p.Price).FirstOrDefault();
                Console.WriteLine($"Самый дешевый: {minPricePhone?.Name} ({minPricePhone?.Price})");

                Phone maxPricePhone = phones.OrderByDescending(p => p.Price).FirstOrDefault();
                Console.WriteLine($"Самый дорогой: {maxPricePhone?.Name} ({maxPricePhone?.Price})");

                Phone oldestPhone = phones.OrderBy(p => p.RealsDat).FirstOrDefault();
                Console.WriteLine($"Самый старый: {oldestPhone?.Name} ({oldestPhone?.RealsDat:yyyy-MM-dd})");

                Phone newestPhone = phones.OrderByDescending(p => p.RealsDat).FirstOrDefault();
                Console.WriteLine($"Самый новый: {newestPhone?.Name} ({newestPhone?.RealsDat:yyyy-MM-dd})");

                decimal averagePrice = phones.Average(p => p.Price);
                Console.WriteLine($"Средняя цена: {averagePrice:F2}");

                var top5 = phones.OrderByDescending(p => p.Price).Take(5);
                Console.WriteLine("\nТоп-5 дорогих:");
                foreach (var phone in top5)
                    Console.WriteLine($"{phone.Name} - {phone.Price}");

                var top5Cheap = phones.OrderBy(p => p.Price).Take(5);
                Console.WriteLine("\nТоп-5 дешевых:");
                foreach (var phone in top5Cheap)
                    Console.WriteLine($"{phone.Name} - {phone.Price}");

                var threeOldest = phones.OrderBy(p => p.RealsDat).Take(3);
                Console.WriteLine("\nТоп-3 старых:");
                foreach (var phone in threeOldest)
                    Console.WriteLine($"{phone.Name} - {phone.RealsDat:yyyy-MM-dd}");

                var threeNew = phones.OrderByDescending(p => p.RealsDat).Take(3);
                Console.WriteLine("\nТоп-3 новых:");
                foreach (var phone in threeNew)
                    Console.WriteLine($"{phone.Name} - {phone.RealsDat:yyyy-MM-dd}");
            }
        }
    }
