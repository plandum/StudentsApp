namespace StudentsApp;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
	}

    private void SaveFriend(object sender, EventArgs e)
    {
        var friend = (Students)BindingContext;
        if (!String.IsNullOrEmpty(friend.FIO))
        {
            App.Database.SaveItem(friend);
        }
        this.Navigation.PopAsync();
    }
    private void DeleteFriend(object sender, EventArgs e)
    {
        var friend = (Students)BindingContext;
        App.Database.DeleteItem(friend.Id);
        this.Navigation.PopAsync();
    }
    private void Cancel(object sender, EventArgs e)
    {
        this.Navigation.PopAsync();
    }

    private void GroupPicker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}