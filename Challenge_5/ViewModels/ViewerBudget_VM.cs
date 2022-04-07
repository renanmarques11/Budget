using Challenge_5.Commands;
using Challenge_5.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5.ViewModels
{
    public class ViewerBudget_VM : Base_VM
    {
        public event EventHandler OnSaved;
        public event EventHandler OnCanceled;

        public BudgetDto BudgetDto { get; set; }

        private ItemDto selectedItem;
        public ItemDto SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }
        //public ICommandDemo CloseCommand { get; set; }

        //public ViewerBudget_VM()
        //{
        //    CloseCommand = new Command((o) => CloseBudget(), (o) => true);
        //}

        //public bool ExecuteValidation()
        //    => SelectedItem != null;

        //public void CloseBudget()
        //{
            
        //}

    }
}
