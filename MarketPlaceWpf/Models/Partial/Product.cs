﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlaceWpf.Models
{
    partial class Product
    {
        public  string FullInfo 
        {
            get
            {
                return Title;
            }
        }
            
    }
}