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

namespace GUI_code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gender.Items.Add("Male");
            Gender.Items.Add("female");
        }

        private void button_2_Click(object sender, RoutedEventArgs e)



        {
            float input1 = float.Parse(Height.Text);
            float input2 = float.Parse(Weight.Text);
            int input3 = Convert.ToInt32(Age.Text);

            if (Gender.Items.Contains("Male"))
            {
                gag.Text = Convert.ToString((10 * input2) + (6.25 * input1) - (5 * input3) + 5);
            }
            else
            {
                gag.Text = Convert.ToString((input2 * 10) + (6.25 * input1) - (5 * input3) - 161);

            }        
        }
    }
}
