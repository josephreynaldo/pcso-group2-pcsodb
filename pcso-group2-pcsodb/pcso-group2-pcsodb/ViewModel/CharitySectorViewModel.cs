namespace pcso_group2_pcsodb.ViewModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using Org.Apache.Http.Client;
using System.Windows.Input;
using System.Windows.Input;


public partial class CharitySectorViewModel : BaseViewModel
{
    [ObservableProperty]
    private string username;

    private HttpClient _httpClient;
    private const string BaseUrl = "https://pcsocorewebapi.azurewebsites.net";

    //public ICommand GetSectorsCommand => _getGetSectorsCommand ??= new AsyncCommand(GetSectorsAsync);

    public CharitySectorViewModel()
    {
        _httpClient = GetHttpClient();

        OnInitializedAsync();
    }

    protected async Task OnInitializedAsync()
    {
        var sectorsUrl = $"{BaseUrl}/WeatherForecast";


        try
        {

            var response = await _httpClient.GetAsync(sectorsUrl);

            if (response.IsSuccessStatusCode)
            {
                var str = await response.Content.ReadAsStringAsync();
                var temp = JsonConvert.DeserializeObject(str);
            }
            else
            {
                var test = 1;
            }
        }         
        catch (HttpRequestException httpRequestException)
        {
            throw new HttpRequestException(httpRequestException.Message, httpRequestException);
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message, exception);
        }


    }


    private HttpClient GetHttpClient() => new(GetHttpClientHandler());


    [ICommand]
    private async Task GetSectorsAsync()
    {
        var sectorsUrl = $"{BaseUrl}/api/Sectors";

        

        var response = await _httpClient.GetAsync(sectorsUrl);

        if (response.IsSuccessStatusCode)
        {
           
        }
        else
        {
            
        }
    }

    private HttpClientHandler GetHttpClientHandler()
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // EXCEPTION : Javax.Net.Ssl.SSLHandshakeException: 'java.security.cert.CertPathValidatorException: Trust anchor for certification path not found.'
        // SOLUTION :
        var httpClientHandler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
        return httpClientHandler;
    }


    [ICommand]
    public void GoToHome()
    {
        Shell.Current.GoToAsync("//Home");
    }


    


}