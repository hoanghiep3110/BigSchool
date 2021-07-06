namespace BigSchool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string LectureId { get; set; }

        [Required(ErrorMessage = "The Place is Required")]
        [StringLength(255)]
        public string Place { get; set; }

        [Required(ErrorMessage = "The DateTime is not correct format")]
        public DateTime DateTime { get; set; }

        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The Category is Required")]
        public List<Category> ListCategory = new List<Category>();

        public virtual Category Category { get; set; }
        public string Name;
    }
}
