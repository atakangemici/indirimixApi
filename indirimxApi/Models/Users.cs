﻿using indirimxApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace indirimxApi.Models
{
    public class Users : BaseEntity
    {
        public string user_name { get; set; }
        public string user_sure_name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string image { get; set; }
        public string role { get; set; }
     
    }
}