using Challenge_5.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Challenge_5.Views
{
    /// <summary>
    /// Interaction logic for BudgetMain_View.xaml
    /// </summary>
    public partial class BudgetMain_View : Window
    {
        private BudgetMain_VM VM = new BudgetMain_VM();
        public BudgetMain_View()
        {
            DataContext = VM;
            InitializeComponent();

            VM.GetButgeds();
        }
    }
}
