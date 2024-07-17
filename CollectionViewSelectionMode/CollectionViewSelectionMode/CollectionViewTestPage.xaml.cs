namespace CollectionViewSelectionMode;

public partial class CollectionViewTestPage : ContentPage
{
    private bool _isModal;
    public CollectionViewTestPage(bool isModal)
    {
        _isModal = isModal;
        InitializeComponent();
        BindingContext = this;
        Unloaded += ModalTestPage_Unloaded;
    }

    private void ModalTestPage_Unloaded(object? sender, EventArgs e)
    {
        if ((CollectionView as VisualElement)?.Handler is IViewHandler handler)
        {
            handler?.DisconnectHandler();
        }
    }

    public List<string> _strings = new List<string>() { "Test", "Test", "Test", "Test", "Test", };
    public List<string> Strings
    {
        get => _strings;
        set
        {
            _strings = value;
            OnPropertyChanged(nameof(Strings));
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (_isModal)
        {
            Navigation.PopModalAsync();
        }
        else
        {
            Navigation.PopAsync();
        }
    }
}