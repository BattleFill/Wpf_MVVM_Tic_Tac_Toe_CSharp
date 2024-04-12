using System;
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

namespace Wpf_MVVM_Tic_Tac_Toe_CSharp.View
{
    public partial class MainWindow : Window
    {
        Random random = new Random();
        private Button[] buttons;
        string z;
        string c;

        public MainWindow()
        {
            InitializeComponent();
            Buttons(false);
            Start.IsEnabled = false;
        }
        private void Buttons(bool x)
        {
            buttons = new Button[] { b1, b2, b3, b4, b5, b6, b7, b8, b9 };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].IsEnabled = x;
                buttons[i].Content = null;
            }
        }
        private void WhoWin()
        {
            buttons = new Button[] { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i * 3].Content != null && buttons[i * 3].Content == buttons[i * 3 + 1].Content && buttons[i * 3].Content == buttons[i * 3 + 2].Content)
                {
                    if (buttons[i * 3].Content == "x")
                    {
                        MessageBox.Show("Крестики WIN");
                    }
                    else
                    {
                        MessageBox.Show("Нолики WIN");
                    }
                    Buttons(false);
                }
                if (buttons[i].Content != null && buttons[i].Content == buttons[i + 3].Content && buttons[i].Content == buttons[i + 6].Content)
                {
                    if (buttons[i].Content == "x")
                    {
                        MessageBox.Show("Крестики WIN");
                    }
                    else
                    {
                        MessageBox.Show("Нолики WIN");
                    }
                    Buttons(false);
                }
            }
            if (buttons[0].Content != null && buttons[0].Content == buttons[4].Content && buttons[0].Content == buttons[8].Content)
            {
                if (buttons[0].Content == "x")
                {
                    MessageBox.Show("Крестики WIN");
                }
                else
                {
                    MessageBox.Show("Нолики WIN");
                }
                Buttons(false);
            }
            if (buttons[2].Content != null && buttons[2].Content == buttons[4].Content && buttons[2].Content == buttons[6].Content)
            {
                if (buttons[2].Content == "x")
                {
                    MessageBox.Show("Крестики WIN");
                }
                else
                {
                    MessageBox.Show("Нолики WIN");
                }
                Buttons(false);
            }
        }
        public int Chek()
        {
            buttons = new Button[] { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            int s = 0;
            for (int i = 0; i < 9; i++)
            {
                if (buttons[i].IsEnabled == false)
                {
                    s++;
                }
            }
            return s;
        }
        private void Buttonclick(object sender, RoutedEventArgs e)
        {
            buttons = new Button[] { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            if (r1.IsChecked == false)
            {
                c = "o";
                z = "x";
            }
            else
            {
                c = "x";
                z = "o";
            }
            if (Chek() != 9)
            {
                (sender as Button).Content = c;
                (sender as Button).IsEnabled = false;
                WhoWin();
            }
            if (Chek() != 9)
            {
                for (int i = 0; ; i++)
                {
                    int rand = random.Next(buttons.Length);
                    if (buttons[rand].IsEnabled == true)
                    {
                        buttons[rand].Content = z;
                        buttons[rand].IsEnabled = false;
                        WhoWin();
                        break;
                    }
                }
            }
        }

        private void r_Checked(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = true;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            buttons = new Button[] { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
            Start.Content = "Начать заново";
            Buttons(true);
            if (r1.IsChecked == false)
            {
                int rand = random.Next(buttons.Length);
                buttons[rand].Content = "x";
                buttons[rand].IsEnabled = false;
            }

        }
    }
}