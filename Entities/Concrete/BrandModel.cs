﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BrandModel : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Model { get; set; }
        public string BrandDescription { get; set; }
    }
}
