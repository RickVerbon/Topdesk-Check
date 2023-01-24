using System.Diagnostics;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Topdesk_Api
{
    public partial class Form1 : Form
    {
        string username = ""; // Enter API key of user here
        string password = ""; // Enter user password here
        string lastNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_connect_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value * 1000;
            
            // Create a new HttpClient object
            using (var client = new HttpClient())
            {
                // Set the basic authentication header
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}")));

                string url = $"https://uvt.topdesk.net/tas/api/incidents/";
                // Make the GET request
                var response = await client.GetAsync(url);
                // Check the status code of the response
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content
                    string content = await response.Content.ReadAsStringAsync();

                    // Parse the JSON response
                    var json = JsonConvert.DeserializeObject<dynamic>(content);
                    string number = json[0].number;
                    string desc = json[0].briefDescription;
                    string user = json[0].caller.dynamicName;
                    string operatorName = json[0].@operator.name;
                    string status = json[0].processingStatus.name;
                    Debug.WriteLine(number);
                    if(number != lastNumber && operatorName == "LIS: IT Support" && status == "Aangemeld")
                    {
                        lastNumber = number;
                        lbl_last.Text = DateTime.Now.ToString("HH:mm:ss");
                        DialogResult choice = MessageBox.Show("Er is een nieuwe melding binnen gekomen:\n" +
                            $"Aanmelder: {user}\n" +
                            $"Omschrijving: {desc}\n\n" +
                            "Wil je deze melding op je naam zetten?", number, MessageBoxButtons.YesNo);

                        if(choice == DialogResult.Yes)
                        {
                            // Post request
                            AssignToName(number);
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void AssignToName(string number)
        {
            using (var client = new HttpClient())
            {
                // Set the basic authentication header
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}")));


                // Set the request's content type to JSON
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Create the request content in JSON format
                var requestContent = new StringContent(JsonConvert.SerializeObject(new
                { 
                    @operator = new { id = "274c610d-5e86-4db6-82aa-0384a69471f7" },
                    operatorGroup = new { id = "b79741a2-12ac-5b82-82ba-0e0d12a5d750" },
                    processingStatus = new { name = "Toegekend" }
                }), Encoding.UTF8, "application/json");

                // Make the POST request
                var response = await client.PutAsync($"https://uvt.topdesk.net/tas/api/incidents/number/{number}", requestContent);
                Debug.WriteLine(response.StatusCode);
                // Check the status code of the response
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content
                    string content = await response.Content.ReadAsStringAsync();

                    // Parse the JSON response
                    var json = JsonConvert.DeserializeObject<dynamic>(content);
                    MessageBox.Show("Melding op naam gezet", "Success");
                }
            }
        }
    }
}