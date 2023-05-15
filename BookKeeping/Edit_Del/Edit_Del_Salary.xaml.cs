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
    /// Логика взаимодействия для Edit_Del_Salary.xaml
    /// </summary>
    public partial class Edit_Del_Salary : Window
    {
        private BookKeepingEntities _context;
        private UC_Salary _Main;
        private BookKeeping_Salary _Salary;

        public Edit_Del_Salary(BookKeepingEntities bookKeepingEntities, object o, UC_Salary uC_Salary)
        {
            InitializeComponent();
            _context = bookKeepingEntities;
            _Salary = (o as Button).DataContext as BookKeeping_Salary;
            _Main = uC_Salary;
            Number.Text = _Salary.BookKeeping_Salary_Number;
            Surname.Text = _Salary.BookKeeping_Salary_Surname;
            Name.Text = _Salary.BookKeeping_Salary_Name;
            Patronymic.Text = _Salary.BookKeeping_Salary_Patronymic;
            Rate.Text = _Salary.BookKeeping_Salary_Salary_Rate;
            Day.Text = _Salary.BookKeeping_Salary_Work_Day;
            Total.Text = _Salary.BookKeeping_Salary_Total;
            Total.IsEnabled = false;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Salary_Total_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите произвести расчёт?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                double F1, F2, F3, F4, ZP, NDFL, Result;
                F1 = Convert.ToDouble(Rate.Text);
                F2 = Convert.ToInt32(Day.Text);
                ZP = F1 * F2 / 21;
                NDFL = ZP * 0.13;
                Result = ZP - NDFL;
                Total.Text = Result.ToString("#.##");
                _Salary.BookKeeping_Salary_Total = Total.Text;
                string time_day = DateTime.Now.AddDays(30).ToString("dd.MM.yyyy");
                _context.BookKeeping_Date.Add(new BookKeeping_Date()
                {
                    BookKeeping_Date_Number = Number.Text,
                    BookKeeping_Date_Salary = time_day,
                    BookKeeping_Date_Total = Total.Text,
                });

                _context.SaveChanges();
                _Main.Update_Salary();
                this.Close();
            }
        }

        private void Edit_Salary_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _Salary.BookKeeping_Salary_Number = Number.Text;
                _Salary.BookKeeping_Salary_Surname = Surname.Text;
                _Salary.BookKeeping_Salary_Name = Name.Text;
                _Salary.BookKeeping_Salary_Patronymic = Patronymic.Text;
                _Salary.BookKeeping_Salary_Salary_Rate = Rate.Text;
                _Salary.BookKeeping_Salary_Work_Day = Day.Text;
                _Salary.BookKeeping_Salary_Total = Total.Text;
                _context.SaveChanges();
                _Main.Update_Salary();
                this.Close();
            }
        }

        private void Del_Salary_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите удалить информацию?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                var recordsToUpdate = _context.BookKeeping_Date.Where(x => x.BookKeeping_Date_Number == Number.Text).ToList();

                foreach (var duplicate in recordsToUpdate)
                {
                    _context.BookKeeping_Date.Remove(duplicate);
                }

                _context.BookKeeping_Salary.Remove(_Salary);
                _context.SaveChanges();
                _Main.Update_Salary();
                this.Close();

                
            }
        }
    }
}
