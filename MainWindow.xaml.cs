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

namespace DelegatesandEvents
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.CatchEvent += W_CatchEvent;
            w.Show();
        }

        private void W_CatchEvent(string data)
        {
            /* bu methodda window1 den her tetiklemede evente aktarılan veri texboxun içine yazılıyor */
            textBox1.Text = data;
        }
    }
}
