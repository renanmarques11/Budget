using Challenge_5.Commands;
using Challenge_5.Dtos;
using Challenge_5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Challenge_5.ViewModels
{
    public class NewBudget_VM : Base_VM
    {
        private readonly BudgetService _service = new BudgetService();
        public event EventHandler OnSaved;

        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                SaveInsertCommand.RaiseCanExecuteChanged();
                OnPropertyChanged(nameof(Name));
            }
        }

        //public string Name { get; set; }
        public double Amount { get; set; }
        public ItemType Type { get; set; }
        public ICommandDemo SaveInsertCommand { get; set; }

        public NewBudget_VM()
        {
            SaveInsertCommand = new Command((o) => SaveInsert(), (o) => ExecuteValidation());
        }
        public void SaveInsert()
        {
            try
            {
                BudgetDto newSavedBudget = new BudgetDto()
                {
                    Name = Name,
                    Amount = Amount,
                    Type = Type

                };
                var budgetId = _service.AddBudget(newSavedBudget);

                this.OnSaved?.Invoke(this, new EventArgs());
                MessageBox.Show("The budget was successfully saved", "Hey!");
                
            }
            catch (Exception)
            {
                MessageBox.Show("You have already saved this budget", "Hmmm...", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public bool ExecuteValidation()
        {
            if (Name != null)
            {
                return true;
            }
            return false;
        }


    }
}
