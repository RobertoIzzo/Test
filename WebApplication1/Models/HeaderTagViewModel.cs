using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class HeaderTagViewModel
    {
        public HeaderTagViewModel()
        {
            itemTagConfigList = new List<ItemTagConfigViewModel>();
        }

        public string ItemTagID { get; set; }
        public List<ItemTagConfigViewModel> itemTagConfigList { get; set; }

    }
    public class ItemTagConfigViewModel
    {
        public IEnumerable<SelectListItem> Genders { get; set; }
        public string Selectedgender { get; set; }
      
    }
}