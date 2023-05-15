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

    public partial class UC_Order : UserControl
    {
        BookKeepingEntities _context = new BookKeepingEntities();
        List<BookKeeping_Purchase> _list = new List<BookKeeping_Purchase>();
        public UC_Order()
        {
            InitializeComponent();
            LV_Order_.ItemsSource = _context.BookKeeping_Purchase.OrderBy(A => A.BookKeeping_Purchase_Id).ToList();
            Update_Order();
        }

        public void Update_Order()
        {
            _list = _context.BookKeeping_Purchase.ToList();
            LV_Order_.ItemsSource = _list;
        }

        private void New_Order_Click(object sender, RoutedEventArgs e)
        {
            New_Order new_Order = new New_Order(_context, this);
            new_Order.ShowDialog();
        }

        private void Edit_del_Order_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Order edit_Del_Order = new Edit_Del_Order(_context, sender, this);
            edit_Del_Order.ShowDialog();
        }
    }
}
