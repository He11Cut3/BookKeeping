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
    /// Логика взаимодействия для New_Order.xaml
    /// </summary>
    public partial class New_Order : Window
    {
        private BookKeepingEntities _context;
        private UC_Order _uc;

        public New_Order(BookKeepingEntities bookKeepingEntities, UC_Order uC_Order)
        {
            InitializeComponent();
            this._context = bookKeepingEntities;
            this._uc = uC_Order;
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.BookKeeping_Purchase.Add(new BookKeeping_Purchase()
                {
                    BookKeeping_Purchase_Article = P_Article.Text,
                    BookKeeping_Purchase_Date = P_Date.Text,
                    BookKeeping_Purchase_Stock = P_Stock.Text,
                    BookKeeping_Purchase_Total = P_Total.Text,
                });
                _context.SaveChanges();
                _uc.Update_Order();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
