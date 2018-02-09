using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TreeViewWPF
{
    public class Model
    {
        public string Name { get; set; }
        public long CallCount { get; set; }

        public ObservableCollection<Model> Items { get; set; }

        public Model()
        {
            Items = new ObservableCollection<Model>();
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model root = new Model();

        public MainWindow()
        {
            InitializeComponent();

            root.Name = "Root";
            root.CallCount = 0;
            Model m1 = new Model { Name = "Nested Once", CallCount = 0 };
            root.Items.Add(m1);
            Model m2 = new Model { Name = "Nested again", CallCount = 0 };
            m1.Items.Add(m2);
            Model m3 = new Model { Name = "Nested Once", CallCount = 0 };
            root.Items.Add(m3);
            Model m4 = new Model { Name = "Nested Once", CallCount = 0 };
            root.Items.Add(m4);
            m2.Items.Add(new Model { Name = "Nested again", CallCount = 0 });
            m3.Items.Add(new Model { Name = "Nested again", CallCount = 0 });

            treeView.Items.Add(root);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Model m1 = new Model { Name = "Nested Once", CallCount = 0 };
            root.Items.Add(m1);
            Model m2 = new Model { Name = "Nested again", CallCount = 0 };
            m1.Items.Add(m2);
            Model m3 = new Model { Name = "Nested Once", CallCount = 0 };
            root.Items.Add(m3);
            Model m4 = new Model { Name = "Nested Once", CallCount = 0 };
            root.Items.Add(m4);
            m2.Items.Add(new Model { Name = "Nested again", CallCount = 0 });
            m3.Items.Add(new Model { Name = "Nested again", CallCount = 0 });
        }
    }
}
