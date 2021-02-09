using System;
using System.ComponentModel.DataAnnotations;

namespace IS403Assignment4.Models
{
    public class DefaultListEntry
    {
        public DefaultListEntry(int rank, string linky)
        {
            Rank = rank;
            if(linky != null) {
                WebLink = linky;
            }
            else
            {
                WebLink = "Coming Soon!";
            };
           
        }

        [Required(ErrorMessage = "You need to enter a rank.")]
        public int Rank { get;}
        [Required(ErrorMessage = "You need to enter a restauraunt name.")]
        public string RestaurauntName { get; set; }
        [Required(ErrorMessage = "You need to enter a favorite dish.")]
        public string FavoriteDish { get; set; } 
        public string Adress { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage = "Bad Phone Format")]
        public string PhoneNumber { get; set; }
        public string WebLink { get; } = "Coming Soon.";

        public static DefaultListEntry[] GetPlaces()
        {
            DefaultListEntry dle1 = new DefaultListEntry(1,null)
            {
                RestaurauntName = "Mi Lindo Guadalajara",
                FavoriteDish = "Plato de Carne Asada",
                Adress = "3434 North St.",
                PhoneNumber = "2335556767",
                

            };

            DefaultListEntry dle2 = new DefaultListEntry(2, null)
            {
                RestaurauntName = "Hruskas Kolaches",
                FavoriteDish = "Bacon Cheese Egg Kolache",
                Adress = "3434 South St.",
                PhoneNumber = "2302846767",
              

            };

            DefaultListEntry dle3 = new DefaultListEntry(3, "https://aubergineandcompany.com/")
            {
                RestaurauntName = "Aubergine",
                FavoriteDish = null,
                Adress = "3434 West St.",
                PhoneNumber = "2338402857",
              

            };

            DefaultListEntry dle4 = new DefaultListEntry(4,null)
            {
                RestaurauntName = "Dirty Bird",
                FavoriteDish = "Spicy Bird",
                Adress = "3434 East St.",
                PhoneNumber = "2331052964",
                

            };

            DefaultListEntry dle5 = new DefaultListEntry(5,null)
            {
                RestaurauntName = "Don Joaquins",
                FavoriteDish = null,
                Adress = "3434 Center St.",
                PhoneNumber = "2336591023",

            };

            return new DefaultListEntry[] { dle1,dle2,dle3,dle4,dle5 };


        }
    }
}
