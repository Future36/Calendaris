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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalendarProgram
{
    public partial class ActivityPage : Page
    {
        private Frame Frame;
        private string pathToImg;

        public ActivityPage(string date, Frame frame, DaysView day)
        {
            InitializeComponent();
            Frame = frame;
            Label.Content = date;

            SetRadioButtonChecked(day.Image.Source.ToString());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new CalendarPage((string)Label.Content, Frame);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            pathToImg = ((sender as RadioButton)?.Content as Image)?.Source?.ToString();
            SaveButton.IsEnabled = true;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var list = Json.Deserialize();
            var entity = list.FirstOrDefault(element => element.date == Label.Content.ToString());

            if (entity == null)
            {
                list.Add(new ModelDay
                {
                    date = (string)Label.Content,
                    pathToImg = pathToImg
                });
            }
            else
            {
                list.Remove(entity);
                entity.pathToImg = pathToImg;
                list.Add(entity);
            }

            Json.Serialize(list);
            BackButton_Click(null, null);
        }

        private void SetRadioButtonChecked(string imagePath)
        {
            if (imagePath == "Books.png")
            {
                first.IsChecked = true;
            }
            else if (imagePath == "Film.png")
            {
                second.IsChecked = true;
            }
            else if (imagePath == "Games.png")
            {
                third.IsChecked = true;
            }
            else if (imagePath == "Sport.png")
            {
                fourth.IsChecked = true;
            }
        }
    }
}
