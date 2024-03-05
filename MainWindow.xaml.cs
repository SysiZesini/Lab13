using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


namespace lab13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ToDo> strList = new List<ToDo>();
        public MainWindow()
        {
            InitializeComponent();
            dateToDo.SelectedDate = new DateTime(2024, 01, 10);
            descriptionToDo.Text = "Описания нет";
        }

        private void button_Add_Click(object sender, RoutedEventArgs e)
        {            
            if (dateToDo.SelectedDate == null){MessageBox.Show("No date selected"); return;}
            mainListBox.ItemsSource = null;
            strList.Add(new ToDo(titleToDo.Text, dateToDo.SelectedDate.Value.ToShortDateString(), descriptionToDo.Text));
            mainListBox.ItemsSource = strList;
            titleToDo.Text = null;
            descriptionToDo.Text = null;
            dateToDo.SelectedDate = null;
        }
        private void Button_delete_Click(object sender, RoutedEventArgs e)
        {
            strList.Remove(strList[mainListBox.SelectedIndex]);
            mainListBox.ItemsSource = null;
            mainListBox.ItemsSource = strList;
        }
    }
}
