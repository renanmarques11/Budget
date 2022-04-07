using Challenge_5.Commands;
using Challenge_5.Dtos;
using Challenge_5.Entities;
using Challenge_5.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Challenge_5.ViewModels
{
    public class UpdateBudget_VM : Base_VM
    {
        private readonly BudgetService _service = new BudgetService();
        public event EventHandler OnSaved;
        public event EventHandler OnCanceled;

        public BudgetDto BudgetDto { get; set; }
        //public ObservableCollection<ItemDto> ItemDto { get; set; }


        private ItemDto selectedItem;
        public ItemDto SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                DeleteItemCommand.RaiseCanExecuteChanged();
                OnPropertyChanged(nameof(SelectedItem));
            }
        }
        public ICommandDemo SaveUpdateCommand { get; set; }
        public ICommandDemo DeleteItemCommand { get; set; }

        public UpdateBudget_VM()
        {
            SaveUpdateCommand = new Command((o) => SaveUpdateBudget(), (o) => true);
            DeleteItemCommand = new Command((o) => DeleteItem(), (o) => ExecuteValidation());
        }

        public bool ExecuteValidation()
            => SelectedItem != null;

        public void DeleteItem()
        {
            //DatabaseRepository.Delete(SelectedItem);
            var deleteItem = _service.DeleteItem(SelectedItem);
            SaveUpdateBudget();
        }


        public void SaveUpdateBudget()
        {
            _service.UpdateBudget(BudgetDto);

            foreach (var item in BudgetDto.Items)
            {
                item.IdBudget = BudgetDto.Id;

                if (item.Id == 0)
                {
                    _service.AddItems(item);
                }
                else
                {
                    _service.UpdateItems(item);
                }
            }

            MessageBox.Show("The budget was successfully updated", "Hey!");
            this.OnSaved?.Invoke(this, new EventArgs());

           
        }
    }
}

