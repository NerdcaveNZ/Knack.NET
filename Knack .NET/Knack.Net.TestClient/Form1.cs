using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Knack.NET;
namespace Knack.Net.TestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var api = new KnackAPI("a4d04280-c9e0-11e9-9ece-97cb0df12ad3", "5d66f3952129d600104ec604");

            var fetchtest = api.SendGetRequest("/v1/objects/object_1/records");

            foreach (Contact test in fetchtest.Records)
            {
                MessageBox.Show(test.Field_1);
            }


        }
    }
}
