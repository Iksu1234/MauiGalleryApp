using CommunityToolkit.Mvvm.Input;
using MauiProject.Models;

namespace MauiProject.ViewModels
{
    internal partial class ListViewModel
    {
        public ImageView ImageView { get; set; }
        public ListViewModel()
        {
            ImageView imageView = new ImageView();
            imageView.Title = "Image 1";
            imageView.Path = "https://i.imgur.com/JHjgOi6.jpeg";
            ImageView = imageView;
        }

        [RelayCommand]
        public async Task BackBtn()
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
