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

namespace Prog_122_W23_Lecture_3
{
    /// <summary>
    /// Interaction logic for Lecture_Example.xaml
    /// </summary>
    public partial class Lecture_Example : Window
    {
        public Lecture_Example()
        {
            InitializeComponent();
        }

        // Appends the first name to rtbDisplay
        private void btnFName_Click(object sender, RoutedEventArgs e)
        {
            rtbDisplay.Text += txtFName.Text;
        }

        private void btnLastName_Click(object sender, RoutedEventArgs e)
        {
            rtbDisplay.Text += txtLName.Text;
        }

        private void btnAddFields_Click(object sender, RoutedEventArgs e)
        {
            rtbDisplay.Text += txtFName.Text + " " + txtLName.Text;

        }

        private void btnDisplayFLName_Click(object sender, RoutedEventArgs e)
        {
            rtbDisplay.Text = txtFName.Text + " " + txtLName.Text;

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            rtbDisplay.Text = "";
        }

        private void btnNewLine_Click(object sender, RoutedEventArgs e)
        {
            rtbDisplay.Text += "\n";
        }
    }
}
