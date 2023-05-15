using BookKeeping.User_Control;
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

namespace BookKeeping.Edit_Del
{
    /// <summary>
    /// Логика взаимодействия для Edit_Del_Order.xaml
    /// </summary>
    public partial class Edit_Del_Order : Window
    {
        private BookKeepingEntities _context;
        private UC_Order _Main;
        private BookKeeping_Purchase _order;

        public Edit_Del_Order(BookKeepingEntities bookKeepingEntities, object o, UC_Order uC_Order)
        {
            InitializeComponent();
            _context = bookKeepingEntities;
            _order = (o as Button).DataContext as BookKeeping_Purchase;
            _Main = uC_Order;
            P_Article.Text = _order.BookKeeping_Purchase_Article;
            P_Date.Text = _order.BookKeeping_Purchase_Date;
            P_Stock.Text = _order.BookKeeping_Purchase_Stock;
            P_Total.Text = _order.BookKeeping_Purchase_Total;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Edit_Order_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _order.BookKeeping_Purchase_Article = P_Article.Text;
                _order.BookKeeping_Purchase_Date = P_Date.Text;
                _order.BookKeeping_Purchase_Stock = P_Stock.Text;
                _order.BookKeeping_Purchase_Total = P_Total.Text;
                _context.SaveChanges();
                _Main.Update_Order();
                this.Close();
            }
        }

        private void Del_Order_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите удалить информацию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.BookKeeping_Purchase.Remove(_order);
                _context.SaveChanges();
                _Main.Update_Order();
                this.Close();
            }
        }
    }
}
