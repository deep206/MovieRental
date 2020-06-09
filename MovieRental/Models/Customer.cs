

namespace MovieRental.Models
{
    public class Customer
    {
        public int id { get; set; }
        public int Id { get; internal set; }
        public string Name { get; set; }
    }
}