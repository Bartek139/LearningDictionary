using System;
using System.Collections.Generic;

namespace LearningDictionary
{
    public class WordsPageViewModel
    {
        public List<WordModel> WordsList { get; set; } = new List<WordModel>();

        public string NewWordToLearn { get; set; }
        public string NewTranslation { get; set; }

        private void AddNewWord()
        {
            var newWord = new WordModel
            {
                WordToLearn = NewWordToLearn,
                Translation = NewTranslation,
                CreatedDate = DateTime.Now
            };

            WordsList.Add(newWord);
        }
    }
}
