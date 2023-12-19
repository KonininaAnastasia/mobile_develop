using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfTemplateData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<MyTask> listTask;
        MyTask newTask = new();

        public MainWindow()
        {
            InitializeComponent();

            List<string> listPhones = new() {"iPhone 12", "HTC", "Samsung Galaxy 22"};
            listBoxPhones.ItemsSource = listPhones;

            listTask = new()
            {
                new MyTask() { Name="Помыть руки", Description="с мылом", Priority=1},
                new MyTask() { Name="Купить еды", Description="в кафе", Priority=2},
                new MyTask() { Name="Выбрать столик", Priority=3}
            };
            listBoxTasks.ItemsSource = listTask;

            stackPanelAdd.DataContext = newTask;
            buAdd.Click += BuAdd_Click;
        }

        private void BuAdd_Click(object sender, RoutedEventArgs e)
        {
            listTask.Add(new MyTask() { Name = newTask.Name, Description = newTask.Description, Priority = newTask.Priority });
        }
    }

    internal class MyTask : IDataErrorInfo
    {

        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Priority { get; set; }

        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;
                switch (columnName)
                {
                    case nameof(Name):
                        break;
                    case nameof(Priority):
                        if ((this.Priority < 0) || (this.Priority > 10))
                            error = "Приоритет должен быть больше 0 и меньше 10";
                        break;
                }
                return error;
            }
        }

        public string Error => throw new NotImplementedException();
    }
}