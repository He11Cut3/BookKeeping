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

namespace BookKeeping.Add_Inf
{
    /// <summary>
    /// Логика взаимодействия для New_Sale.xaml
    /// </summary>
    public partial class New_Sale : Window
    {
        private BookKeepingEntities _context;
        private UC_Sale _uc;

        public New_Sale(BookKeepingEntities bookKeepingEntities, UC_Sale uC_Sale)
        {
            InitializeComponent();
            this._context = bookKeepingEntities;
            this._uc = uC_Sale;
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {

            if ((MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.BookKeeping_Sale.Add(new BookKeeping_Sale()
                {
                    BookKeeping_Sale_Article = S_Article.Text,
                    BookKeeping_Sale_Date = S_Date.Text,
                    BookKeeping_Sale_Stock = S_Stock.Text,
                    BookKeeping_Sale_Total = S_Total.Text,
                });
                _context.SaveChanges();
                _uc.Update_Sale();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
