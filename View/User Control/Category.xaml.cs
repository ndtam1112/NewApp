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

namespace View.User_Control
{
    /// <summary>
    /// Interaction logic for Category.xaml
    /// </summary>
    public partial class Category : UserControl
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Jacket_Click(object sender, RoutedEventArgs e)
        {
            CategoryLayout.Children.Clear();
            CategoryLayout.Children.Add(new List_Product("Jacket"));
        }

        private void TShirt_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            tShirt.Opacity = 1;
        }

        private void TShirt_MouseLeave(object sender, MouseEventArgs e)
        {
            tShirt.Opacity = 0;

        }

        private void Jacket_MouseLeave(object sender, MouseEventArgs e)
        {
            jacket.Opacity = 0;
        }

        private void Jacket_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            jacket.Opacity = 1;
        }

        private void Sweater_MouseLeave(object sender, MouseEventArgs e)
        {
            sweater.Opacity = 0;
        }

        private void Sweater_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            sweater.Opacity = 1;
        }

        private void Pants_MouseLeave(object sender, MouseEventArgs e)
        {
            pants.Opacity = 0;
        }

        private void Pants_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            pants.Opacity = 1;
        }

        private void Short_MouseLeave(object sender, MouseEventArgs e)
        {
            @short.Opacity = 0;
        }

        private void Short_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            @short.Opacity = 1;
        }

        private void Bags_MouseLeave(object sender, MouseEventArgs e)
        {
            bag.Opacity = 0;
        }

        private void Bags_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            bag.Opacity = 1;
        }

        private void TShirt_Click(object sender, RoutedEventArgs e)
        {
            CategoryLayout.Children.Clear();
            CategoryLayout.Children.Add(new List_Product("T_Shirt"));
        }

        private void Sweater_Click(object sender, RoutedEventArgs e)
        {
            CategoryLayout.Children.Clear();
            CategoryLayout.Children.Add(new List_Product("Sweater"));
        }

        private void Pants_Click(object sender, RoutedEventArgs e)
        {
            CategoryLayout.Children.Clear();
            CategoryLayout.Children.Add(new List_Product("Jean"));
        }

        private void Short_Click(object sender, RoutedEventArgs e)
        {
            CategoryLayout.Children.Clear();
            CategoryLayout.Children.Add(new List_Product("Shirt"));
        }

        private void Bags_Click(object sender, RoutedEventArgs e)
        {
            CategoryLayout.Children.Clear();
            CategoryLayout.Children.Add(new List_Product("Bag"));
        }
    }
}
