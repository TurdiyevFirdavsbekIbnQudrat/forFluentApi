using System.ComponentModel.DataAnnotations.Schema;

namespace forFluentApi.Models
{
    public class UserCar
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        [ForeignKey("UserId")]
        public User users { get; set; }
        [ForeignKey("CarId")]
        public Car cars { get; set; }
    }
}
