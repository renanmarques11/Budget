using Challenge_5.Dtos;
using Challenge_5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5.Extensions
{
    public static class ConverterExtension
    {
        public static BudgetDto ToDto(this Budget budget)
        {
            return new BudgetDto
            {
                Name = budget.Name,
                Id = budget.Id,
                Amount = budget.Amount,
                Type = (Dtos.ItemType)budget.Type,
                Items = budget.Items.Select(q => new ItemDto
                {
                    Name = q.Name,
                    Id = q.Id,
                    Amount = q.Amount,
                    IdBudget = q.IdBudget
                }).ToObservableCollection()
            };
        }

        public static Budget ToEntity(this BudgetDto budgetDto)
        {
            return new Budget
            {
                Name = budgetDto.Name,
                Id = budgetDto.Id,
                Amount = budgetDto.Amount,
                Type = (Entities.ItemType)budgetDto.Type
                
            };
        }


        public static Item ToEntity(this ItemDto itemDto)
        {
            return new Item
            {
                Name = itemDto.Name,
                Id = itemDto.Id,
                Amount = itemDto.Amount,
                IdBudget = itemDto.IdBudget
            };
        }

    }
}
