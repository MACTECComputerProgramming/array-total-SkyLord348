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

namespace Array_Total_ChallengeLPB
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








        //make array

        string[] grades;  
        





        private void figureButton_Click(object sender, RoutedEventArgs e)
        {
            //Instatiate Variables

            






            //Get grades
            grades = new string[5];

            grades[0] = textBox1.Text;
            grades[1] = textBox2.Text;
            grades[2] = textBox3.Text;
            grades[3] = textBox4.Text;
            grades[4] = textBox5.Text;



            //Figure Grades and average
             int.Parse(grades[0]);
            









        }
    }
}
