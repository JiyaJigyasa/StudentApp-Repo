using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppStudent1.Models
{
    public class Student
    {
        public int SId { get; set; }
        public string SName { get; set; }
        public DateTime SDob { get; set; }
        public long SContact { get; set; }
    }
}