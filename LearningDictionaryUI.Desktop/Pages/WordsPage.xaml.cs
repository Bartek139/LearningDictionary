using LearningDictionary;
using System.Windows.Controls;

namespace LearningDictionaryUI.Desktop
{
    /// <summary>
    /// Interaction logic for WordsPage.xaml
    /// </summary>
    public partial class WordsPage : Page
    {
        public WordsPage()
        {
            InitializeComponent();

            DataContext = new WordsPageViewModel();
        }
    }
}
