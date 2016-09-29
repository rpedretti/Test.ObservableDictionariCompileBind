# Test.ObservableDictionariCompileBind
As described in https://msdn.microsoft.com/en-us/windows/uwp/xaml-platform/x-bind-markup-extension an implementation of IObservableMap should work with x:Bind, but dont :(

Calling Bindings.Update() works just fine. On MainPage.xaml.cs just comment this call to see the bind don't get updated.
