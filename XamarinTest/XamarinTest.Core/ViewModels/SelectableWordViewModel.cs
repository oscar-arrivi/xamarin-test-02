using System;
using MvvmCross.ViewModels;

namespace XamarinTest.Core.ViewModels
{
    public class SelectableWordViewModel : MvxViewModel
    {
        private bool _isSelected;
        private string _word;

        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }


        public string Word
        {
            get => _word;
            set
            {
                SetProperty(ref _word, value);
                RaisePropertyChanged(nameof(First));
            }
        }

        public string First => string.IsNullOrEmpty(Word)
                               ? null
                               : Word.Substring(0,1);
    }
}
