namespace CollectionViewSelectionMode
{
    public partial class MainPage : TabbedPage
    {
        public Page _persistedTestPage;

        public MainPage()
        {
            _persistedTestPage = new NavigationPage(new TestPage(this)) { Title = "Test"};
            Children.Add(_persistedTestPage);
            Children.Add(new NavigationPage(new TestPage(this)) { Title = "Test" });
            Children.Add(new NavigationPage(new TestPage(this)) { Title = "Test" });
            Children.Add(new NavigationPage(new TestPage(this)) { Title = "Test" });
            Children.Add(new NavigationPage(new TestPage(this)) { Title = "Test" });
        }

        public async void ClearAndAddPages()
        {
            await Task.Delay(100);
            Children.Clear();
            await Task.Delay(100);

            Children.Add(_persistedTestPage);
            Children.Add(new NavigationPage(new TestPage(this)) { Title = "Test" });
            Children.Add(new NavigationPage(new TestPage(this)) { Title = "Test" });
            Children.Add(new NavigationPage(new TestPage(this)) { Title = "Test" });
            Children.Add(new NavigationPage(new TestPage(this)) { Title = "Test" });
        }
    }

}
