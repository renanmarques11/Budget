using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5.Dtos
{
    public class ItemDto : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public int IdBudget { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}