using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject.ViewModels
{
    internal partial class MainViewModel
    {
        [RelayCommand]
        public async Task ListViewBtn()
        {
            await Shell.Current.GoToAsync("//ListView");
        }
    }
}
