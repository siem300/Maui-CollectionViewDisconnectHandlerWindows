namespace CollectionViewSelectionMode;

public partial class TestPage : ContentPage
{
    private MainPage _mainPage;
    public TestPage(MainPage mainPage)
    {
        _mainPage = mainPage;
        InitializeComponent();
    }

    public void OnButtonClicked(object sender, EventArgs args)
    {
        _mainPage.ClearAndAddPages();
    }

    private async void NavigateModal(object sender, EventArgs e)
    {
        await _mainPage.Navigation.PushModalAsync(new NavigationPage(new CollectionViewTestPage(true)));
    }

    private async void Navigate(object sender, EventArgs e)
    {
        await _mainPage.CurrentPage.Navigation.PushAsync(new CollectionViewTestPage(false), true);
    }
}