using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

namespace Prog_122_W23_Lecture_3
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
        private void btnAddText_Click(object sender, RoutedEventArgs e)
        {
            // I need to grab the value from the text box
            string word = txtWord.Text;

            // I want to append to the text
            rtbDisplay.Text += word;
        }

        private void btnChangeText_Click(object sender, RoutedEventArgs e)
        {
            string word = txtWord.Text;

            rtbDisplay.Text = word;
        }

        private void btnCountToTen_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                rtbDisplay.Text += i.ToString();
            }
        }

        private void btnCountToUsersNumber_Click(object sender, RoutedEventArgs e)
        {
            // I want to display from 0 to users number
            // Step 1 - Grab the text
            string userNumber = txtWord.Text;

            // Step 2 - Turn it into a number
            int number = int.Parse(userNumber);

            // Step 3
            for (int i = 0; i < number; i++)
            {
                // Step 4 - Display to rtb
                rtbDisplay.Text += i + "\n";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            string name = "";

            rtbDisplay.Text = name;
        }

        private void btnRtbToText_Click(object sender, RoutedEventArgs e)
        {
            string word = rtbDisplay.Text;

            txtWord.Text = word;
        }

        private void btnLayoutExample_Click(object sender, RoutedEventArgs e)
        {
            Layout_InClass layout = new Layout_InClass();
            layout.Show();
            
        }





        // Todays Discussions
        // Rich Text Box
        // - Questions
        // - What are they good for
        // - How to you append
        // - How do you clear
        // - How do you replace
        // - WHAT TAG DO YOU NAME?

        // Layouts

        // Canvas
        //        What positioning does it use?
        // Grid
        //        What positioning does grid use?
        //        How do you Define rows and columns?
        //        How do you position a control?
        // StackPanel
        //        How do you organize controls in a stack panel?
        //        What are the two orientations of stack panel?
        // Nesting Layouts


    }
}
