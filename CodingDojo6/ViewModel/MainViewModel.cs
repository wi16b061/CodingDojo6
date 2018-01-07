using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace CodingDojo6.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private KategorieVm selectedKategorie;

        public KategorieVm SelectedKategorie
        {
            get { return selectedKategorie; }
            set { selectedKategorie = value; RaisePropertyChanged(); }
        }


        private ObservableCollection<KategorieVm> kategorieList;

        public ObservableCollection<KategorieVm> KategorieList
        {
            get { return kategorieList; }
            set { kategorieList = value; }
        }

        private ObservableCollection<GamesVm> cartList;

        public ObservableCollection<GamesVm> CartList
        {
            get { return cartList; }
            set { cartList = value; RaisePropertyChanged(); }
        }

        private RelayCommand<GamesVm> buyBtnClickedCmd;

        public RelayCommand<GamesVm> BuyBtnClickedCmd
        {
            get
            {
                return buyBtnClickedCmd;
            }

            set
            {
                buyBtnClickedCmd = value; RaisePropertyChanged();
            }
        }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            kategorieList = new ObservableCollection<KategorieVm>();
            CartList = new ObservableCollection<GamesVm>();
            BuyBtnClickedCmd = new RelayCommand<GamesVm>((p) =>
            {
                CartList.Add(p);
            }, (p) => { return true; });
            LoadData();
        }

        private void LoadData()
        {
            ObservableCollection<GamesVm> legoGameList = new ObservableCollection<GamesVm>();
            legoGameList.Add(new GamesVm("Lego HP Hogwarts", "8+", new BitmapImage(new Uri("https://images-na.ssl-images-amazon.com/images/I/91vfoLYExgL._SL1500_.jpg", UriKind.Absolute))));
            legoGameList.Add(new GamesVm("Lego City", "5-12", new BitmapImage(new Uri("https://cdn.toysrus.com.au/www/732/files/157333_1_tn.jpg", UriKind.Absolute))));
            legoGameList.Add(new GamesVm("Lego Women of Nasa", "10+", new BitmapImage(new Uri("https://cdn.vox-cdn.com/thumbor/Bg0jHJlVgcYLM6sAaXdm284EnpA=/800x0/filters:no_upscale()/cdn.vox-cdn.com/uploads/chorus_asset/file/9485705/21312_Box2_v29.jpg", UriKind.Absolute))));
            legoGameList.Add(new GamesVm("Lego Creator", "9-12", new BitmapImage(new Uri("https://www.dreamworld.com.au/-/media/images/dreamworld/things_to_do/lego/image%20slider%20gallery/whats%20hot/31070_track%20racer.png", UriKind.Absolute))));
            legoGameList.Add(new GamesVm("Lego Star Wars", "9-14", new BitmapImage(new Uri("http://cdn-static.denofgeek.com/sites/denofgeek/files/styles/article_width/public/2017/02/falcon.jpg?itok=Q9gjBE-_", UriKind.Absolute))));
            legoGameList.Add(new GamesVm("Lego Scooby-Doo!", "8+", new BitmapImage(new Uri("http://www.bricktoynews.com/wp-content/uploads/2016/05/LEGO-Scooby-Doo-Mystery-Mansion-75904-Box-e1464664006710.jpg", UriKind.Absolute))));


            ObservableCollection<GamesVm> playmobilGameList = new ObservableCollection<GamesVm>();
            playmobilGameList.Add(new GamesVm("Playmobil City Life", "4-10", new BitmapImage(new Uri("https://media.cdn.galeria-kaufhof.de/media/227090-1-1502767881224/zoom", UriKind.Absolute))));
            playmobilGameList.Add(new GamesVm("Playmobil Summer Fun", "4-10", new BitmapImage(new Uri("https://fractus-855d.kxcdn.com/wp-content/uploads/2016/08/Playmobil-Camping-Trip-Playset-1024x896.jpg", UriKind.Absolute))));
            playmobilGameList.Add(new GamesVm("Playmobil Ghostbusters", "6+", new BitmapImage(new Uri("https://image.smythstoys.com/original/desktop/160098.jpg", UriKind.Absolute))));
            playmobilGameList.Add(new GamesVm("Playmobil Sheriff's Office", "4+", new BitmapImage(new Uri("https://i.pinimg.com/736x/95/c8/42/95c842220a2e905b8a8bf48e05c6d15f--playmobil-western-the-pirate.jpg", UriKind.Absolute))));
            playmobilGameList.Add(new GamesVm("Playmobil Country", "5-12", new BitmapImage(new Uri("https://mytoys.scene7.com/is/image/myToys/ext/5467542-02.jpg?wid=400&hei=400&fmt=jpeg&qlt=25,1&resMode=trilin&op_usm=0.9,1,5,1", UriKind.Absolute))));
            playmobilGameList.Add(new GamesVm("Playmobil Toragents", "6-12", new BitmapImage(new Uri("https://mytoys.scene7.com/is/image/myToys/ext/5467556-02.jpg?wid=400&hei=400&fmt=jpeg&qlt=25,1&resMode=trilin&op_usm=0.9,1,5,1", UriKind.Absolute))));

            kategorieList.Add(new KategorieVm("My Lego", new BitmapImage(new Uri("https://s-media-cache-ak0.pinimg.com/originals/cc/a7/b6/cca7b6e0beb5777df640bc35eeea6e71.jpg", UriKind.Absolute)), legoGameList));
            kategorieList.Add(new KategorieVm("My Playmobil", new BitmapImage(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Playmobil_logo.svg/1200px-Playmobil_logo.svg.png", UriKind.Absolute)), playmobilGameList));

            selectedKategorie = kategorieList[0];

            cartList.Add(new GamesVm("Lego HP Hogwarts", "8+", new BitmapImage(new Uri("https://images-na.ssl-images-amazon.com/images/I/91vfoLYExgL._SL1500_.jpg", UriKind.Absolute))));
        }
    }
}