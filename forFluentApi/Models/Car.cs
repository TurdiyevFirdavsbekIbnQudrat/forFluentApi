namespace forFluentApi.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserCar> UserCars { get; set; }
    }
}
