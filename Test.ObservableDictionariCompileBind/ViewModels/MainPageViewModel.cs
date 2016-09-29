using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Test.ObservableDictionariCompileBind.Models;

namespace Test.ObservableDictionariCompileBind.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private MainPageModel _model;
        private DelegateCommand _validateCommand;

        public MainPageViewModel()
        {
            Model = new MainPageModel();
        }

        public MainPageModel Model
        {
            get { return _model; }
            private set { Set(ref _model, value); }
        }

        public DelegateCommand ValidateCommand => _validateCommand ?? (_validateCommand = new DelegateCommand(() =>
        {
            Model.IsValid();
        }));
    }
}
