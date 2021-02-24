using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSite.Data;

namespace BlogSite.Web.Models
{
    public class HomePageViewModel
    {
        public List<BlogPost> Posts { get; set; }
        public int? NextPage { get; set; }
        public int? PreviousPage { get; set; }
    }
}
