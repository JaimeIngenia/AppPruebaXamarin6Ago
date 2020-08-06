using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace AppInternet
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void BtnCallWS_Click(object sender, EventArgs e)
        {
            WSClient client = new WSClient();
            var result = await client.Get<WSResult>("https://jsonplaceholder.typicode.com/posts/1");
            if (result != null)
            {
                lblId.Text = $"{result.id}";
                lblTitle.Text = result.title;
                lblBody.Text = result.body;
            }
        }
    }
}
