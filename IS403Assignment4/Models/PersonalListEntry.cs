using System;
using System.ComponentModel.DataAnnotations;
namespace IS403Assignment4.Models
{
    public class PersonalListEntry
    {
        public PersonalListEntry()
        {
        }
        [Required(ErrorMessage ="Name Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Restauraunt Name Required")]
        public string RestaurauntName { get; set; }
        [Required(ErrorMessage = "Fav Dish Required")]
        public string FavoriteDish { get; set; }
        // makes the phone number the correct phone number format
        [Required(ErrorMessage = "Phone Required")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Bad Phone Format")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string RestaurauntPhone { get; set; }

      
    }
}
