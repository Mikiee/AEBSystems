﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AEBSystems.Core.Models
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTimeOffset DateCreated { get; set; }

        public BaseEntity()
        {
            this.Id = Guid.NewGuid().ToString();
            this.DateCreated = DateTime.Now;
        }
    }
}