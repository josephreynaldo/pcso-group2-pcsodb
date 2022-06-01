namespace pcso_group2_pcsodb.ViewModel;

using pcso_group2_pcsodb.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Net.Http.Headers;
using Newtonsoft.Json;

public partial class AdministrativeSectorViewModel : BaseViewModel
{
    [ObservableProperty]
    private string username;

    [ICommand]
    public void GoToHome()
    {
         Shell.Current.GoToAsync("//Home");
         RunAsyncBlogs();
    }


    static async Task RunAsyncBlogs()
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://pcsocorewebapi.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // HTTP GET
            try
            {
                HttpResponseMessage response = await client.GetAsync("api/Sectors");
                if (response.IsSuccessStatusCode)
                {
                    var userJson = response.Content.ReadAsStringAsync().Result;


                    // var rootObject = JsonConvert.DeserializeObject<Sector>(userJson);
                    var rootObject = JsonConvert.DeserializeObject<List<Sector>>(userJson);

                    //var cnt = thisBlogList.Count();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine( e.Message);

            }
            

        }
    }

}