using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Person
    {
        [Required]
        [StringLength(255)]
        [DataType(DataType.Text)]
        public string firstName
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        [DataType(DataType.Text)]
        public string lastName
        {
            get;
            set;
        }
        [Required]
        public int age
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string emailAddress
        {
            get;
            set;
        }
        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        [BindProperty(Name = "pass")]
        public string passWord
        {
            get;
            set;
        }
        [StringLength(500)]
        public string personDiscription
        {
            get;
            set;
        }

    }
}
