using BookKeeping.Add_Inf;
using BookKeeping.Edit_Del;
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

namespace BookKeeping.User_Control
{
    /// <summary>
    /// Логика взаимодействия для UC_Sale.xaml
    /// </summary>
    public partial class UC_Sale : UserControl
    {
        BookKeepingEntities _context = new BookKeepingEntities();
        List<BookKeeping_Sale> _list = new List<BookKeeping_Sale>();

        public UC_Sale()
        {
            InitializeComponent();
            Update_Sale();
        }

        public void Update_Sale()
        {
            _list = _context.BookKeeping_Sale.ToList();
            LV_Sale_.ItemsSource = _list;
        }

        private void New_Sale_Click(object sender, RoutedEventArgs e)
        {
            New_Sale new_Sale = new New_Sale(_context, this);
            new_Sale.ShowDialog();
        }

        private void Edit_del_Sale_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Sale edit_Del_Sale = new Edit_Del_Sale(_context, sender, this);
            edit_Del_Sale.ShowDialog();
        }
    }
}
