using System;

namespace LearningDictionary
{
    public class WordModel
    {
        public string WordToLearn { get; set; }
        public string Translation { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsSelected { get; set; }

    }
}
