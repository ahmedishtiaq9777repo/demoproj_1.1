using System;
using System.Collections.Generic;

namespace demoproj_1._1.Models
{
    public partial class ImageStore
    {
        public int Id { get; set; }
        public string Imagebase64string { get; set; }
        public DateTime? Date { get; set; }
    }
}
