﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        [StringLength(500)]
        public string AboutDetails1 { get; set; }
        [StringLength(500)]
        public string AboutDetails2 { get; set; }
        [StringLength(100)]
        public string AboutImage1 { get; set; }
        [StringLength(100)]
        public string AboutImage2 { get; set; }

    }
}
