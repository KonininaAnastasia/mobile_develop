﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
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

namespace wpfBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding binding = new();
            //binding.ElementName = "edCaption";
            //binding.Path = new("Text");
            binding.ElementName = nameof(edCaption);
            binding.Path = new(nameof(edCaption.Text));
            txtCaption.SetBinding(TextBlock.TextProperty, binding);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HerroEx herro = (HerroEx)this.Resources["myHerroAbu"];
            herro.Description = "qweqewqweqweq";
        }
    }

    class Herro
    {
        public string? Name { get; set; }
        public string? Clan { get; set; }
        public string? Description { get; set; }
        public int HP { get; set; } = 100;
    }

    class HerroEx : INotifyPropertyChanged
    {
        private string? name;
        private string? clan;
        private string? description;
        private int hP = 100;

        public string? Name
        {
            get => name; set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string? Clan
        {
            get => clan; set
            {
                clan = value;
                OnPropertyChanged(nameof(Clan));
            }
        }
        public string? Description
        {
            get => description; set
            {
                description = value;
                //(1)
                //OnPropertyChanged(nameof(Description));
                //(2)
                OnPropertyChanged();
            }
        }
        public int HP
        {
            get => hP; set
            {
                hP = value;
                OnPropertyChanged(nameof(HP));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        //public void OnPropertyChanged(string propertyName) =>
        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}