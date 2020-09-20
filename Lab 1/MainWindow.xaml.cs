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

/// Week 3		Lab 1
/// File Name: MainWindow.xaml.cs
/// @author: Antonio Monteiro
/// Date:  September 14th 2020

namespace Lab_1
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

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

            //decalare variables
            string firstName = fnTextBox.Text;
            string lastName = lnTextBox.Text;

            printPigLatinName(firstName, lastName);

        }

        static void printPigLatinName(string first, string last)
        {

            //declare string variables
            string pigLatin = "ay";
            string firstLetter;
            string fullName;

            //set both to lowercase
            first = first.ToLower();
            last = last.ToLower();

            //fix first name
            //start with getting firstletter
            firstLetter = first.Substring(0, 1);

            //remove first letter from name and add it to the end
            first = first.Substring(1);
            first = first + firstLetter + pigLatin;

            //capitalize it
            first = first.Substring(0, 1).ToUpper() + first.Substring(1);

            //do the same for last name
            //start with getting firstletter
            firstLetter = last.Substring(0, 1);

            //remove first letter from name and add it to the end
            last = last.Substring(1);
            last = last + firstLetter + pigLatin;

            //capitalize it
            last = last.Substring(0, 1).ToUpper() + last.Substring(1);

            //combine both names
            fullName = first + " " + last;
            MessageBox.Show(fullName);

        }

    }
}
