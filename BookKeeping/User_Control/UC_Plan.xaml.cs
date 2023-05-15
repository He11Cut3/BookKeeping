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
    /// Логика взаимодействия для UC_Plan.xaml
    /// </summary>
    public partial class UC_Plan : UserControl
    {
        BookKeepingEntities _context = new BookKeepingEntities();
        List<BookKeeping_Date> _list = new List<BookKeeping_Date>();
        private BookKeeping_Date _Date;


        public UC_Plan()
        {
            InitializeComponent();
            LV_Plan_.ItemsSource = _context.BookKeeping_Date.OrderBy(A => A.BookKeeping_Date_Id).ToList();
            Update_Date();
        }

        public void Update_Date()
        {
            string time_now = DateTime.Now.ToString("dd.MM.yyyy");
            string time_day = DateTime.Now.AddDays(30).ToString("dd.MM.yyyy");
            var recordsToUpdate = _context.BookKeeping_Date.Where(x => x.BookKeeping_Date_Salary == time_now).ToList();

            foreach (var duplicate in recordsToUpdate)
            {
                duplicate.BookKeeping_Date_Salary = time_day;
            }
            _context.SaveChanges();
            _list = _context.BookKeeping_Date.ToList();
            LV_Plan_.ItemsSource = _list;
        }

        private void New_Date_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_del_Date_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
