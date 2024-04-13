﻿using Wpf_MVVM_Tic_Tac_Toe_CSharp.View;
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
    internal class OdinWindowViewModel : BindingHelper
    {
        public BindableCommand back { get; set; }
        public void backk2()
        {
            MainWindow second_window = new MainWindow();
            second_window.Show();
            Application.Current.Windows[0].Close();
        }

        public OdinWindowViewModel()
        {

            back = new BindableCommand(_ => backk2());

        }

    }
}
