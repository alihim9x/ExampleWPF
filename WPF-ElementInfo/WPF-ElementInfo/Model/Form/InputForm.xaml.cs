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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SingleData;
using Utility;

namespace Model.Form
{
    /// <summary>
    /// Interaction logic for InputForm.xaml
    /// </summary>
    public partial class InputForm : Window
    {
        public InputForm()
        {
            InitializeComponent();
           
        }

        private void PickElement_Click(object sender, RoutedEventArgs e)
        {
            InputFormUtil.PickElement();
        }

        private void PickElements_Click(object sender, RoutedEventArgs e)
        {
            InputFormUtil.PickElements();

        }

        private void AddElements_Click(object sender, RoutedEventArgs e)
        {
            InputFormUtil.AddElements();

        }

        private void AddRebars_Click(object sender, RoutedEventArgs e)
        {
            InputFormUtil.AddRebars();

        }
        private void DeleteRebars_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as System.Windows.Controls.Button;
            var rebarView = button.DataContext as Model.ViewModel.RebarView;
            InputFormUtil.DeleteRebars(rebarView);

        }
    }
    
}
