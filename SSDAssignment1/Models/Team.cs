using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Program :    Team.cs
/// Author  :    Mesut Baltaci
/// Date    :    September 23, 2021
/// Purpose :    This class represents a Team
/// </summary> 
namespace SSDAssignment1.Models
{
    public class Team
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Team Name")]
        [Required(ErrorMessage = "Team name field is required.")]
        public string TeamName { get; set; }

        [Display(Name = "Email")]
        [StringLength(50)]
        [Required(ErrorMessage = "The Email field is required.")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Established Date")]
        public DateTimeOffset? EstablishedDate { get; set; }
    }
}
