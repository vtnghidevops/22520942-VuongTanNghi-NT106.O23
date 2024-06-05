using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4.BAI7
{
    public partial class BAI7_Delete : Form
    {

        HttpClient httpClient;
        public BAI7_Delete(HttpClient httpClient)
        {
            InitializeComponent();
            this.httpClient = httpClient;
        }


        private async void btnDeleteDish_Click(object sender, EventArgs e)
        {
            if(tbDishId.Text=="")
            {
                MessageBox.Show("Please Type Dish ID!", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            DialogResult result = MessageBox.Show("Are you sure you want to delete Dish ID " + tbDishId.Text + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
               
                using HttpResponseMessage response = await httpClient.DeleteAsync($"api/v1/monan/{tbDishId.Text}");

               
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Delete " + tbDishId.Text + " Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(jsonResponse);
                    string detail = (string)data["detail"];
                    MessageBox.Show(detail, "Fail", MessageBoxButtons.OK);
                }
            }
        }

    }
}
