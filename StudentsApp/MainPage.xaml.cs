namespace StudentsApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        StudentsList.ItemsSource = App.Database.GetItems();
        base.OnAppearing();
    }
    // обработка нажатия элемента в списке
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Students selectedFriend = (Students)e.SelectedItem;
        StudentPage friendPage = new StudentPage();
        friendPage.BindingContext = selectedFriend;
        await Navigation.PushAsync(friendPage);
    }
    // обработка нажатия кнопки добавления
    private async void CreateFriend(object sender, EventArgs e)
    {
        Students friend = new Students();
        StudentPage friendPage = new StudentPage();
        friendPage.BindingContext = friend;
        await Navigation.PushAsync(friendPage);
    }
}

