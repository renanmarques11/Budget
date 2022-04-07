using Challenge_5.Commands;
using Challenge_5.Dtos;
using Challenge_5.Extensions;
using Challenge_5.Services;
using Challenge_5.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5.ViewModels
{
    public class BudgetMain_VM : Base_VM
    {
        public ObservableCollection<BudgetDto> Items { get; set; }
        private readonly BudgetService _service = new BudgetService();

        private BudgetDto selectedBudget;
        public BudgetDto SelectedBudget
        {
            get { return selectedBudget; }
            set
            {
                selectedBudget = value;
                DeleteBudgetCommand.RaiseCanExecuteChanged();
                OpenUpdateBudgetCommand.RaiseCanExecuteChanged();
                OpenBudgetCommand.RaiseCanExecuteChanged();
                OnPropertyChanged(nameof(SelectedBudget));
            }
        }

        public double GeneralAmount { get; set; }
        public double GeneralSpent { get; set; }


        public void GetProjected(ObservableCollection<BudgetDto> Items)
        {
            double amountRevenue =  
                (
                from item in Items
                where item.Type == ItemType.Revenue
                select item.Amount
                ).Sum();

            double amountExpense = 
                (
                from item in Items
                where item.Type == ItemType.Expense
                select item.Amount
                ).Sum();

            GeneralAmount = amountRevenue - amountExpense;
        }

        public void GetExecuted(ObservableCollection<BudgetDto> Items)
        {
            double spentRevenue = 
                (
                from item in Items
                where item.Type == ItemType.Revenue
                select item.Spent
                ).Sum();

            double spentExpense = 
                (
                from item in Items
                where item.Type == ItemType.Expense
                select item.Spent
                ).Sum();

            GeneralSpent = spentRevenue - spentExpense;
        }


        public ICommandDemo DeleteBudgetCommand { get; set; }
        public ICommandDemo OpenUpdateBudgetCommand { get; set; }
        public ICommandDemo OpenBudgetCommand { get; set; }
        public ICommandDemo OpenNewBudgetCommand { get; set; }

        public BudgetMain_VM()
        {
            Items = new ObservableCollection<BudgetDto>();

            DeleteBudgetCommand = new Command((o) => DeleteBudget(), (o) => ExecuteValidation());
            OpenUpdateBudgetCommand = new Command((o) => OpenUpdateBudget(), (o) => ExecuteValidation());
            OpenBudgetCommand = new Command((o) => OpenBudget(), (o) => ExecuteValidation());
            OpenNewBudgetCommand = new Command((o) => OpenNewBudget(), (o) => true);
        }
        public void GetButgeds()
        {
            var budgets = _service.GetBudgets();
            Items = budgets.ToObservableCollection();
            GetProjected(Items);
            GetExecuted(Items);
        }

        public void DeleteBudget()
        {
            var deleteBudget = _service.DeleteBudget(SelectedBudget);

            //DatabaseRepository.Delete(SelectedBudget);
            GetButgeds();
        }

        public void OnBudgetUpdated(object sender, EventArgs args)
        {
            GetButgeds();
        }


        public void OpenUpdateBudget()
        {
            UpdateBudget_VM vm = new UpdateBudget_VM
            {
                BudgetDto = SelectedBudget.Clone2() as BudgetDto,

            };

            vm.OnSaved += OnBudgetUpdated;

            UpdateBudget_View updateBudget_view = new UpdateBudget_View(vm);

            updateBudget_view.Show();
        }

        public void OpenBudget()
        {
            ViewerBudget_VM vm = new ViewerBudget_VM
            {
                BudgetDto = SelectedBudget
            };
            ViewerBudget_View viewerBudget_View = new ViewerBudget_View(vm);
            viewerBudget_View.Show();
        }

        public void OpenNewBudget()
        {
            NewBudget_VM vm = new NewBudget_VM();
            NewBudget_View newBudgetView = new NewBudget_View(vm);

            vm.OnSaved += OnBudgetUpdated;
            newBudgetView.Show();
        }


        public bool ExecuteValidation()
        {
            if (SelectedBudget != null)
            {
                return true;
            }
            return false;
        }
    }
}
