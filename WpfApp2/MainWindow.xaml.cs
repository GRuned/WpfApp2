using System;
using System.Collections;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   ArrayList arryList ;
        
        public MainWindow()
        {
            arryList = new ArrayList();
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            arryList.Add(input.Text);
            input.Text = " ";

        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            arryList.Remove(input.Text);
            input.Text = " ";
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            foreach (string data in arryList)

                MessageBox.Show(data);
            

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
