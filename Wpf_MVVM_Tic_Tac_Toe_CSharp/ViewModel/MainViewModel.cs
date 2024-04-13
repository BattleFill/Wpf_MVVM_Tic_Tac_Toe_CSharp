using Wpf_MVVM_Tic_Tac_Toe_CSharp.View;
using Wpf_MVVM_Tic_Tac_Toe_CSharp.ViewModel.Helpers;
using Wpf_MVVM_Tic_Tac_Toe_CSharp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_MVVM_Tic_Tac_Toe_CSharp.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        public BindableCommand Odin { get; set; }
        public BindableCommand Mnogo { get; set; }
        public BindableCommand Nul { get; set; }


        public void Odinn()
        {
            OdinWindow second_window = new OdinWindow();
            second_window.Show();
            Application.Current.MainWindow.Close();

        }
        public void Mnogoo()
        {
            MnogoWindow second_window = new MnogoWindow();
            second_window.Show();
            Application.Current.MainWindow.Close();

        }
        public void Nulll()
        {

            Application.Current.MainWindow.Close();

        }
        public MainViewModel()
        {

            Odin = new BindableCommand(_ => Odinn());
            Mnogo = new BindableCommand(_ => Mnogoo());
            Nul = new BindableCommand(_ => Nulll());

        }
        

    }
}
