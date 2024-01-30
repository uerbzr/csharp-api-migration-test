﻿using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.wwwapi.Models
{
    [Table("doctors")]
    public class Doctor
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("fullname")]
        public string FullName { get; set; }
    }
}
