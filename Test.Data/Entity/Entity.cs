using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Data.Entity
{
    public abstract class Enity: Entity<int>
    {

    }
    public abstract class Entity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}
