using CommunityToolkit.Mvvm.Input;
using MauiProject.Models;
using System.Collections.ObjectModel;


namespace MauiProject.ViewModels
{
    internal partial class ListViewModel 
    {
        public ObservableCollection<ImageView> Collection { get; set; }

        public ListViewModel()
        {
            Collection = new ObservableCollection<ImageView>();

            for (int i = 0; i < 6; i++)
            {
                ImageView view = new ImageView();
                view.Title = "Image"+i;
                view.Path = "https://i.imgur.com/JHjgOi6.jpeg";
                Collection.Add(view);
            }
        }


        [RelayCommand]
        public async Task BackBtn()
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
