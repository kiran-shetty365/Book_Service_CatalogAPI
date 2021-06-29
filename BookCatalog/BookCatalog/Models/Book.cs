using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Models
{
    public class Book
    {
        [Key]
        public int BID { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Length Exceeds")]
        public string BName { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        [Required]
        [Range(1,4, ErrorMessage ="Provide a valid category between 1 to 4. 1(Thriller), 2(History),3(Drama),4(Biography)")]
        public int Category { get; set; }
        public string Description { get; set; }
    }
}
