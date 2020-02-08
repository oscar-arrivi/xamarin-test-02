using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Linq;
using XamarinTest.Core.Services;

namespace XamarinTest.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
       
        public ObservableCollection<SelectableWordViewModel> Words { get; set; } = new ObservableCollection<SelectableWordViewModel>();

        public string NewWord
        {
            get => _newWord;
            set
            {
                SetProperty(ref _newWord, value);
                RaisePropertyChanged(nameof(HasNewWord));
            }
        }

        public bool HasNewWord => !string.IsNullOrWhiteSpace(NewWord);

        public override Task Initialize()
        {
//#if DEBUG
//            // Initialize with some words for debug
//            Words.Add(new SelectableWordViewModel { Word = "Uno" });
//            Words.Add(new SelectableWordViewModel { Word = "Dos" });
//#endif

            return base.Initialize();
        }


        private MvxCommand<SelectableWordViewModel> _itemClickCommand;
        public MvxCommand<SelectableWordViewModel> ItemClickCommand => _itemClickCommand =
        _itemClickCommand ?? new MvxCommand<SelectableWordViewModel>(OnItemClickCommand);


        private MvxCommand _addNewWordClickCommand;
        private string _newWord;
        private IPlatformAction _platformAction;

        public MvxCommand AddNewWordClickCommand => _addNewWordClickCommand =
         _addNewWordClickCommand ?? new MvxCommand(OnAddNewWordClickCommand);

        public MainViewModel(IPlatformAction platformAction)
        {
            _platformAction = platformAction;
        }


        private void OnItemClickCommand(SelectableWordViewModel selectable)
        {
            var wasSelected = selectable.IsSelected;
            if (!wasSelected)
            {
                // New selection we need to uncheck the current word if any.
                var previouslySelected = Words?.FirstOrDefault(s => s.IsSelected);
                if (previouslySelected != null)
                {
                    previouslySelected.IsSelected = false;
                }
            }
            // Mark new state
            selectable.IsSelected = !wasSelected;
        }

        private void OnAddNewWordClickCommand()
        {
            // Check if a new word is available
            if (HasNewWord)
            {
                // Add new word
                Words.Add(new SelectableWordViewModel
                {
                    Word = NewWord
                });
                // Clean
                NewWord = null;
                _platformAction.DismissKeyboard();
            }

        }



    }
}
