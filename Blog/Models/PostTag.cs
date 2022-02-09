using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("PostTag")]
    public class PostTag
    {
        [Key]
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}
