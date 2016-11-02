﻿using System;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
   public class Homework
    {
        public int Id { get; set; }

        [MaxLength(500)]
        public string Content { get; set; }

        public DateTime? TimeSent { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }
    }
}
