using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicPlayerAcrylicUI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        songList.ItemsSource = new[]

        {

            new Song { ImageUrl = "3", SongName = "Electricity", ArtistName = "3:50"},
            new Song { ImageUrl = "4", SongName = "Ocean Drive", ArtistName = "3:45"},
            new Song { ImageUrl = "5", SongName = "Shadows", ArtistName = "4:00"},
            new Song { ImageUrl = "6", SongName = "Infinity", ArtistName = "4:30"},
            new Song { ImageUrl = "7", SongName = "Neon Lights", ArtistName = "4:05"},
            new Song { ImageUrl = "8", SongName = "Gravity", ArtistName = "4:20"},
            new Song { ImageUrl = "9", SongName = "Eclipse", ArtistName = "3:55"},
            new Song { ImageUrl = "10", SongName = "Starlight", ArtistName = "4:10"},
            new Song { ImageUrl = "11", SongName = "Aurora", ArtistName = "4:25"},
            new Song { ImageUrl = "12", SongName = "Thunder", ArtistName = "4:00"},
            new Song { ImageUrl = "13", SongName = "Blaze", ArtistName = "4:15"}



        };

    }
}


public class Song

{

    public string ImageUrl { get; set; }

    
    public string SongName { get; set; }

    public string ArtistName { get; set; }

}