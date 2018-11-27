using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using UserInterface.Models;

namespace UserInterface.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Writeline("main vindow has been loaded");
            WebClient client = new WebClient();
            string result = await client.DownloadStringTaskAsync("https://jsonplaceholder.typicode.com/posts");
            List<Post> post = JsonConvert.DeserializeObject<List<Post>>(result);
            listbox1.DataSource = post;
            listbox1.DisplayMember = nameof(Post.Title);
        }
    }
}
