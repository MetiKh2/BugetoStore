﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Domain.Entities.Commons
{
   public abstract class BaseEntity<TKey>
    {
        public TKey ID { get; set; }
        public DateTime InsertTime { get; set; }=DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public bool IsRemoved { get; set; } = false;
        public DateTime? RemovedTime { get; set; }

    }

   public abstract class BaseEntity : BaseEntity<long>
   {

   }

   public abstract class BaseEntityNotID
   {
        public DateTime InsertTime { get; set; } = DateTime.Now;
       public DateTime? UpdateTime { get; set; }
       public bool IsRemoved { get; set; } = false;
       public DateTime? RemovedTime { get; set; }
    }
}
