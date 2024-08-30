namespace PostmanCloneUI;

public partial class TestAPI : Form
{
    public TestAPI()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        try
        {
            systemStatus.Text = "Calling API...";

            // Sample code - replace whith the actual API call.
            await Task.Delay(2000);
            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            this.resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }


    }

}
