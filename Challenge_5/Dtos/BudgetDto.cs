using Challenge_5.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5.Dtos
{
    public class BudgetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public ItemType Type { get; set; }
        public ObservableCollection<ItemDto> Items { get; set; } = new ObservableCollection<ItemDto>();
        public double Spent => Items.Sum(x => x.Amount);

        public double Balance => Amount - Spent;


        public BudgetDto Clone2()
        {
            BudgetDto budgetDtoClone = new BudgetDto();

            budgetDtoClone.Id = Id;
            budgetDtoClone.Name = Name;
            budgetDtoClone.Amount = Amount;
            budgetDtoClone.Type = Type;

            budgetDtoClone.Items = CollectionExtension.CloneObservableCollection(Items);

            return budgetDtoClone;
        }
    }

    public enum ItemType
    {
        Revenue,
        Expense,
    }
}