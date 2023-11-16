namespace forFluentApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<UserCar> UserCars { get; set; }
        public ICollection<UserHome> UserHomes { get; set; }
    }
}
