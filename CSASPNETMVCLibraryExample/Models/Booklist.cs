using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CSASPNETMVCLibraryExample.Models
{
    public class Booklist
    {
        [Display (Name = "Name")]
        public string Bookname { get; set; }
        [Display(Name = "Description")]
        public string Bookdescription { get; set; }
        [Display(Name = "Author")]
        public string Bookauthor { get; set; }
        [Display(Name = "Released")]
        public int Bookreleasedate { get; set; }
    }
}