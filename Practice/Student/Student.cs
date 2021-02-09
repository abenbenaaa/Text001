using System;
using System.ComponentModel.DataAnnotations;

namespace Student
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
