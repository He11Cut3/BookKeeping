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
    /// Логика взаимодействия для New_Salary.xaml
    /// </summary>
    public partial class New_Salary : Window
    {
        private BookKeepingEntities _context;
        private UC_Salary _uc;

        public New_Salary(BookKeepingEntities bookKeepingEntities, UC_Salary uC_Salary)
        {
            InitializeComponent();
            this._context = bookKeepingEntities;
            this._uc = uC_Salary;
            Total.IsEnabled = false;
            Total.Text = "В ожидании расчёта";
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Salary_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите добавить информацию?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.BookKeeping_Salary.Add(new BookKeeping_Salary()
                {
                    BookKeeping_Salary_Name = Name.Text,
                    BookKeeping_Salary_Number = Number.Text,
                    BookKeeping_Salary_Patronymic = Patronymic.Text,
                    BookKeeping_Salary_Salary_Rate = Rate.Text,
                    BookKeeping_Salary_Surname = Surname.Text,
                    BookKeeping_Salary_Total = Total.Text,
                    BookKeeping_Salary_Work_Day = Day.Text,
                });
                _context.SaveChanges();
                _uc.Update_Salary();
                this.Close();
            }
        }
    }
}
