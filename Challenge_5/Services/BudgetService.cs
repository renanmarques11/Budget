using Challenge_5.Dtos;
using Challenge_5.Entities;
using Challenge_5.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5.Services
{
    internal class BudgetService
    {
        public IEnumerable<BudgetDto> GetBudgets()
        {
            var budgets = DatabaseRepository.ReadWithChildren<Budget>();
            return budgets.Select(o => o.ToDto()).ToList();
        }

        //public BudgetDto GetBudget(int id)
        //{
        //    var budget = DatabaseRepository.ReadById<Budget>(id);
        //    return budget.ToDto();
        //}

        public int AddBudget(BudgetDto budgetDto)
        {
            var savedBudget = DatabaseRepository.Insert(budgetDto.ToEntity());
            return savedBudget.Id;
        }

        public int DeleteBudget(BudgetDto budgetDto) 
        { 
            DatabaseRepository.Delete(budgetDto.ToEntity()); 
            return budgetDto.Id; 
        }

        public int DeleteItem(ItemDto itemDto)
        {
            DatabaseRepository.Delete(itemDto.ToEntity());
            return itemDto.Id;
        }


        public void AddItems(ItemDto itemDto) 
        {
            DatabaseRepository.Insert(itemDto.ToEntity());
        }

        public int UpdateBudget(BudgetDto budgetDto)
        {
            var savedBudget = DatabaseRepository.Update(budgetDto.ToEntity());
            return savedBudget.Id;
        }

        public void UpdateItems(ItemDto itemDto)
        {
            DatabaseRepository.Update(itemDto.ToEntity());
        }
    }
}
