using System.Windows.Media.Imaging;

namespace CodingDojo6.ViewModel
{
    public class GamesVm
    {

        private string gameName;

        public string GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }

        private string age;

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        private BitmapImage image;

        public BitmapImage Image
        {
            get { return image; }
            set { image = value; }
        }

        public GamesVm(string gameName, string age, BitmapImage image)
        {
            this.gameName = gameName;
            this.age = age;
            this.image = image;
        }

    }
}