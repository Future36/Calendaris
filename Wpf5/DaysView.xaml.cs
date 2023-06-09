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
    /// <summary>
    /// Логика взаимодействия для DaysView.xaml
    /// </summary>
    public partial class DaysView : UserControl
    {
        public DaysView(int Number, string PathImg)
        {
            InitializeComponent();
            var list = Json.Deserialize();
            LabelNumber.Content = Number;
            if (PathImg != null)
            {
                Uri uri = new Uri(PathImg);
                Image.Source = new BitmapImage(uri);
            }
        }
    }
}
