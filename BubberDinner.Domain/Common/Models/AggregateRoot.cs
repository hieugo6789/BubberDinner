﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubberDinner.Domain.Common.Models
{
    public abstract class AggregateRoot<TId> : Entity<TId>
        where TId : notnull
    {
        protected AggregateRoot(TId id) : base(id) 
        {
        }
    }
}
