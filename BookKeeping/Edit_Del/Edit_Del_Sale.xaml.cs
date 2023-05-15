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
    /// Логика взаимодействия для Edit_Del_Sale.xaml
    /// </summary>
    public partial class Edit_Del_Sale : Window
    {
        private BookKeepingEntities _context;
        private UC_Sale _Main;
        private BookKeeping_Sale _Sale;

        public Edit_Del_Sale(BookKeepingEntities bookKeepingEntities, object o, UC_Sale uC_Sale)
        {
            InitializeComponent();
            _context = bookKeepingEntities;
            _Sale = (o as Button).DataContext as BookKeeping_Sale;
            _Main = uC_Sale;
            S_Article.Text = _Sale.BookKeeping_Sale_Article;
            S_Date.Text = _Sale.BookKeeping_Sale_Date;
            S_Stock.Text = _Sale.BookKeeping_Sale_Stock;
            S_Total.Text = _Sale.BookKeeping_Sale_Total;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Edit_Sale_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _Sale.BookKeeping_Sale_Article = S_Article.Text;
                _Sale.BookKeeping_Sale_Date = S_Date.Text;
                _Sale.BookKeeping_Sale_Stock = S_Stock.Text;
                _Sale.BookKeeping_Sale_Total = S_Total.Text;
                _context.SaveChanges();
                _Main.Update_Sale();
                this.Close();
            }
        }

        private void Del_Sale_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите удалить информацию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.BookKeeping_Sale.Remove(_Sale);
                _context.SaveChanges();
                _Main.Update_Sale();
                this.Close();
            }
        }
    }
}
