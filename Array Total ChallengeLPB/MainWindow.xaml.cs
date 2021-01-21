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


        string[] tempArray = new string[5];

        
        private void GetGrades()
        { 
            string[] grades = new string[5] {  textBox1.Text , textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text };

            tempArray = grades;

        }

       public void Grades()
        {
           
            int grade1 = int.Parse(tempArray[0]);
            int grade2 = int.Parse(tempArray[1]);
            int grade3 = int.Parse(tempArray[2]);
            int grade4 = int.Parse(tempArray[3]);
            int grade5 = int.Parse(tempArray[4]);

            classAverage = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;

            classTotal = grade1 + grade2 + grade3 + grade4 + grade5;




        }

        public int classAverage;
        public int classTotal;

        private void figureButton_Click(object sender, RoutedEventArgs e)
        {

            GetGrades();

            Grades();



            resultLabel.Content = "The class total is " + classTotal + ". The class average is " + classAverage;



        }

        
    }
}
