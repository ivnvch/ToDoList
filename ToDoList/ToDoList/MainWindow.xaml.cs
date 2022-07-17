using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

namespace ToDoList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\todoList.json";
        private BindingList<List> _todoLists;
        private SaveData _saveData;
       
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _saveData = new SaveData(PATH);
            try
            {
                _todoLists = _saveData.LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.Message);
                Close();
            }
            dgAllNotes.ItemsSource = _todoLists;
            _todoLists.ListChanged += _todoLists_ListChanged;
           
        }

        private void _todoLists_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemChanged)
            {
                _saveData.Save(sender);
            }
        }

    }
}
