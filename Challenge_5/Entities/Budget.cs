using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5.Entities
{
    public class Budget
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public ItemType Type { get; set; }
        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Item> Items { get; set; }
       
    }

    public enum ItemType
    {
        Revenue,
        Expense,
    }
}
