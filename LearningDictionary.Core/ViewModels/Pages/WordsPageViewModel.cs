using LearningDictionary.Core;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace LearningDictionary
{
    public class WordsPageViewModel : BaseViewModel
    {
        public ObservableCollection<WordModel> WordsList { get; set; } = new ObservableCollection<WordModel>();

        public string NewWordToLearn { get; set; }
        public string NewTranslation { get; set; }

        public ICommand AddNewWordCommand { get; set; }
        public ICommand DeleteSelectedWordsCommand { get; set; }

        public WordsPageViewModel()
        {
            AddNewWordCommand = new RelayCommand(AddNewWord);
            DeleteSelectedWordsCommand = new RelayCommand(DeleteSelectedWords);
        }

        private void AddNewWord()
        {
            var newWord = new WordModel
            {
                WordToLearn = NewWordToLearn,
                Translation = NewTranslation
            };

            WordsList.Add(newWord);

            NewWordToLearn = string.Empty;
            NewTranslation = string.Empty;

            OnPropertyChanged(nameof(NewWordToLearn));
            OnPropertyChanged(nameof(NewTranslation));
        }
        private void DeleteSelectedWords()
        {
            var selectedWords = WordsList.Where(x => x.IsSelected == true).ToList();

            foreach (var word in selectedWords)
            {
                WordsList.Remove(word);
            }
        }
    }
}
