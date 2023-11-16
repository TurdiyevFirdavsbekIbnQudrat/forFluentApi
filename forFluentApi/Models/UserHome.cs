using System.ComponentModel.DataAnnotations.Schema;

namespace forFluentApi.Models
{
    public class UserHome
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public int HomeId { get; set; }

        [ForeignKey("UserId")]
        public User users { get; set; }
        [ForeignKey("HomeId")]
        public Home homes { get; set; }
    }
}
