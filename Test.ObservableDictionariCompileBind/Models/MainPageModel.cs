using Template10.Common;
using System.Linq;
using Template10.Mvvm;

namespace Test.ObservableDictionariCompileBind.Models
{
    public class MainPageModel : BindableBase
    {
        #region Private Fields

        private ObservableDictionary<string, string> _errors;

        private string _validatedProp1;
        private string _validatedProp2;

        #endregion

        public MainPageModel()
        {
            Errors = new ObservableDictionary<string, string>
            {
                {nameof(ValidatedProp1), null },
                {nameof(ValidatedProp2), null }
            };
        }

        #region Public Properties

        public ObservableDictionary<string, string> Errors
        {
            get { return _errors; }
            private set { Set(ref _errors, value); }
        }

        public string ValidatedProp1
        {
            get { return _validatedProp1; }
            set { Set(ref _validatedProp1, value); }
        }

        public string ValidatedProp2
        {
            get { return _validatedProp2; }
            set { Set(ref _validatedProp2, value); }
        }

        public bool IsValid()
        {
            _errors[nameof(ValidatedProp1)] = string.IsNullOrWhiteSpace(ValidatedProp1) ? "Must not be empty" : null;
            _errors[nameof(ValidatedProp2)] = string.IsNullOrWhiteSpace(ValidatedProp2) ? "Must not be empty" : null;

            return _errors.All(kv => kv.Value != null);
        }

        #endregion
    }
}