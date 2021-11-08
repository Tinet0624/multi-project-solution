using ChuckNorrisAPI;
using Newtonsoft.Json;
using System.Net;

namespace ChuckFormRetry
{
    public partial class ChuckForm : Form
    {
        private static readonly HttpClient client;

        public ChuckForm()
        {
            InitializeComponent();
        }
        
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChuckForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private async void btnGenerateJoke_Click(object sender, EventArgs e)
        {
                var joke = await ChuckNorrisClient.GetRandomJoke();

                lbJokeOutput.Text = joke.JokeText;
        }

        private async void LoadComboBox()
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var cat in categories)
            {
                cbCategories.Items.Add(cat);
            }
        }

    }
}