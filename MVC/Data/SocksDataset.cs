using MVC.Models;

namespace MVC.Data
{
    public class SocksDataset
    {
        static string[] brands = ["icebreaker", "addidas", "rebook", "nike"];
        public static IEnumerable<Socks> GetSocks()
        {
            return Enumerable.Range(1, 5).Select(index =>
                new Socks()
                {
                    Id = index,
                    Brand = brands[Random.Shared.Next(brands.Length)],
                    Size = (SockSize)Random.Shared.Next(4),
                    Price = Random.Shared.Next(50, 500),
                    InStock = Random.Shared.Next(0, 20)
                }).ToArray();

        }
    }
}
