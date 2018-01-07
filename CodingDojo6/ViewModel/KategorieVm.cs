using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace CodingDojo6.ViewModel
{
    public class KategorieVm : ViewModelBase

    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private BitmapImage image;

        public BitmapImage Image
        {
            get { return image; }
            set { image = value; }
        }

        private ObservableCollection<GamesVm> gameList;

        public ObservableCollection<GamesVm> GameList
        {
            get { return gameList; }
            set { gameList = value; }
        }

        public KategorieVm(string name, BitmapImage image, ObservableCollection<GamesVm> games)
        {
            this.name = name;
            this.image = image;
            gameList = games;
        }
    }
}