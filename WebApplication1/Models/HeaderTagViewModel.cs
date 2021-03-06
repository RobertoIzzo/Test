﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class HeaderTagViewModel
    {
        public IEnumerable<SelectListItem> Antani { get; set; }
        public string AntaniSelected { get; set; }
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

    public class CustomKeyValue<T, T1>
    {
        public T Text { get; set; }
        public T1 Value { get; set; }
    }


}