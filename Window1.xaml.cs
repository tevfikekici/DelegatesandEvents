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

namespace DelegatesandEvents
{
    
    public partial class Window1 : Window
    {
        // creating the delegate will represent an event
        public delegate void CatchText(string data);

        //  Provides delegate related event or method to be accessed by other classes by referencing its name on ram. 
        public event CatchText CatchEvent;


        public Window1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Every time the value of the textbox changes, the string data in it is transferred into the event named CatchEvent.
            if (CatchEvent!=null)
            {
                CatchEvent(textBox1.Text);
            }
            
        }
    }
}
