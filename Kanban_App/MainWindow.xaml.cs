using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Kanban_App.Commands;

namespace Kanban_App
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


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Projects_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHome_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }

    public class KanbanColumn
    {
       public string ColumnName { get; set; }
       public ObservableCollection<KanbanItem> Items { get; set; }
    }

    public class KanbanBoardViewModel
    {
        public ObservableCollection<KanbanColumn> Columns { get; set; }
        public ICommand AddColumnCommand { get; set; }

        public KanbanBoardViewModel()
        {
            Columns = new ObservableCollection<KanbanColumn>();
            AddColumnCommand = new RelayCommand(AddColumn);
        }

        private void AddColumn()
        {
            // Logic to add a new column
            var newColumn = new KanbanColumn { ColumnName = "New Column", Items = new ObservableCollection<KanbanItem>() };
            Columns.Add(newColumn);
        }
    }


}

