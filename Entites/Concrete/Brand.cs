﻿using Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
	public class Brand:IEntity
	{
        public int BrandId { get; set; }
		public string BrandName { get; set; }
    }
}
