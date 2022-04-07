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
    /// Interaction logic for UpdateBudget_View.xaml
    /// </summary>
    public partial class UpdateBudget_View : Window
    {
        public UpdateBudget_View(UpdateBudget_VM VM)
        {
            DataContext = VM;
            Owner = Application.Current.MainWindow;
            InitializeComponent();
            VM.OnSaved += (s, e) => { this.Close(); };
        }
    }
}
