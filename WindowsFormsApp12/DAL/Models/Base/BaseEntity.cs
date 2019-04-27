using System;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp12.DAL.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime? CreateionDateTime { get; set; } = DateTime.Now;
    }
}
