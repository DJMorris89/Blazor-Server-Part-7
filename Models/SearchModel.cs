﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class SearchModel
    {
        [Required]
        public string SearchTerm { get; set; }
    }
}
