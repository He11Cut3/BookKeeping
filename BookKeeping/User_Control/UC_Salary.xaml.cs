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
    /// Логика взаимодействия для UC_Salary.xaml
    /// </summary>
    public partial class UC_Salary : UserControl
    {
        BookKeepingEntities _context = new BookKeepingEntities();
        List<BookKeeping_Salary> _list = new List<BookKeeping_Salary>();

        public UC_Salary()
        {
            InitializeComponent();
            LV_Salary_.ItemsSource = _context.BookKeeping_Salary.OrderBy(A => A.BookKeeping_Salary_Id).ToList();
            Update_Salary();
        }

        public void Update_Salary()
        {
            _list = _context.BookKeeping_Salary.ToList();
            LV_Salary_.ItemsSource = _list;
        }

        private void New_Salary_Click(object sender, RoutedEventArgs e)
        {
            New_Salary new_Salary = new New_Salary(_context, this);
            new_Salary.ShowDialog();
        }

        private void Edit_del_Salary_Click(object sender, RoutedEventArgs e)
        {
            Edit_Del_Salary edit_Del_Salary = new Edit_Del_Salary(_context, sender, this);
            edit_Del_Salary.ShowDialog();
        }
    }
}
