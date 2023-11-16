namespace forFluentApi.Models
{
    public class Home
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public ICollection<UserHome> UserHomes { get; set; }
    }
}
