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

namespace Wpf_poe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        List<library> AppList = new List <library>();
        private void btn_CLEAR_Click(object sender, RoutedEventArgs e)
        {

            txtCode.Text = " ";
            txtName.Text = " ";
            txtnumber_of_credits.Text = null;
            txtnumber_of_hours.Text = null;
            txthours_per_week.Text = null;
            txtnumber_of_weeks.Text = null;
            txt_datePicker.Text = null;

        }

        private void btn_ADD_Click(object sender, RoutedEventArgs e)
        {

            string module_code, module_name;
            int number_of_credits, hours_per_week, number_of_weeks, number_of_hours,self_study_hours_per_week,self_study_hours_left; DateTime start_date;


            module_code= txtCode.Text;
            module_name=txtName.Text;
            number_of_credits = Convert.ToInt32(txtnumber_of_credits.Text);
            number_of_hours = Convert.ToInt32(txtnumber_of_hours.Text);
            number_of_weeks = Convert.ToInt32(txtnumber_of_weeks.Text);
            hours_per_week = Convert.ToInt32(txthours_per_week.Text);
            start_date = Convert.ToDateTime(txt_datePicker.Text);

            self_study_hours_per_week = ((number_of_credits * 10) / number_of_weeks) - hours_per_week;

            self_study_hours_left = (self_study_hours_per_week - number_of_hours);

            library lb = new library(module_code, module_name, number_of_hours, number_of_credits, number_of_weeks, hours_per_week, self_study_hours_left, self_study_hours_per_week, start_date);

            


                AppList.Add(lb);

        }

        private void btn_DISPLAY_Click(object sender, RoutedEventArgs e)
        {
            var library = from k in AppList select k;

            foreach (library i in AppList)
            {
                list_Box.Items.Add(i.studentReport());
            }
        }

        private void list_Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
