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

namespace wishlist
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.Parse(รายรับ.Text);
            int.Parse(รายจ่าย.Text);
            int.Parse(ราคาของ.Text);
            if (int.Parse(รายรับ.Text) > int.Parse(รายจ่าย.Text))
            { วัน.Content = int.Parse(ราคาของ.Text) / (int.Parse(รายรับ.Text) - int.Parse(รายจ่าย.Text)); }
            else if (int.Parse(รายรับ.Text) < int.Parse(รายจ่าย.Text))
            {
                MessageBox.Show("คุณมีรายได้ น้อยกว่า รายจ่าย คุณกำลังเป็นหนี้นะ");

            }
            else if (int.Parse(รายรับ.Text) == int.Parse(รายจ่าย.Text))
            {
                MessageBox.Show("คุณมีรายได้ = รายจ่าย คุณไม่เหลือเก็บออมเลย");

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            รายรับ.Text = ("");
            รายจ่าย.Text = ("");
            ราคาของ.Text = ("");
            วัน.Content = ("");
        }
    }
}
