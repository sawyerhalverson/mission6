using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission6.Models
{
    public class MovieResponse
    {
        [Required]
        [Key]
        public int MovieId { get; set; }




        //title **required
        [Required]

        public string Title { get; set; }


        //year **required
        [Required]

        public int Year { get; set; }


        //director **required
        [Required]

        public string Director { get; set; }


        //rating (drop down, G, PG, PG-13, R)  **required
        [Required]

        public string Rating { get; set; }

        //edited (yes/no, true/false option)  **optional
        public bool Edited { get; set; }


        //lent to  **optional
        public string LentTo { get; set; }


        //notes  (limited to 25 characters) **optional
        [StringLength(25)]


        public string Notes { get; set; }




        //build foreign key  relationship
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
