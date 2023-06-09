using System;
using System.Collections.Generic;
using System.Data;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalendarProgram
{
    /// <summary>
    /// Логика взаимодействия для Pagee.xaml
    /// </summary>
    public partial class CalendarPage : Page
    {
        private Frame navigationFrame;

        public CalendarPage()
        {
            InitializeComponent();
            navigationFrame = new Frame();
        }

        public CalendarPage(string selectedDate, Frame frame)
        {
            InitializeComponent();
            DatePicker.Text = selectedDate;
            this.navigationFrame = frame;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            DatePicker.Text = MyDate.NextDate(DatePicker.Text);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            DatePicker.Text = MyDate.BackDate(DatePicker.Text);
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDaysPanel();
        }

        private void DaysPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DaysPanel.SelectedItem is DaysView selectedDayView)
            {
                if (int.TryParse(selectedDayView.LabelNumber.Content.ToString(), out int dayLabelNumber))
                {
                    navigationFrame.Content = new ActivityPage(MyDate.SetDays(DatePicker.Text, dayLabelNumber), navigationFrame, selectedDayView);
                }
            }
        }

        private void UpdateDaysPanel()
        {
            string[] splittedDate = MyDate.SplitDate(DatePicker.Text);

            var jsonList = Json.Deserialize();
            List<DaysView> daysList = new List<DaysView>();

            for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt32(splittedDate[2]), Convert.ToInt32(splittedDate[1])); i++)
            {
                string imagePath = null;
                foreach (var jsonElement in jsonList)
                {
                    if (jsonElement.date == MyDate.SetDays(MyDate.UnsplitDate(splittedDate), i))
                    {
                        imagePath = jsonElement.pathToImg;
                    }
                }
                daysList.Add(new DaysView(i, imagePath));
            }

            DaysPanel.ItemsSource = daysList;
        }
    }
}
