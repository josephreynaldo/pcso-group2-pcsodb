using pcso_group2_pcsodb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace pcso_group2_pcsodb.Services
{
    public class DepartmentService
    {
        HttpClient httpClient;
        List<Department> departmentList = new();
        public DepartmentService()
        {
            httpClient = new HttpClient();
        }
        public async Task<List<Department>> GetDepartments()
        {
            if (departmentList?.Count > 0)
                return departmentList;
            string requestURL = "https://pcso-jcr-backend.azurewebsites.net/api/Departments";
            try
            {
                var response = await httpClient.GetAsync(requestURL);
                if (response.IsSuccessStatusCode)
                {
                    departmentList = await response.Content.ReadFromJsonAsync<List<Department>>();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return departmentList;
        }
        public async Task<List<Department>> GetDepartmentsBysectorID(int sectorID)
        {
            if (departmentList?.Count > 0)
                return departmentList;
            string requestURL = "https://pcso-jcr-backend.azurewebsites.net/api/Departments/Department/" + sectorID;
            try
            {
                var response = await httpClient.GetAsync(requestURL);
                if (response.IsSuccessStatusCode)
                {
                    departmentList = await response.Content.ReadFromJsonAsync<List<Department>>();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return departmentList;
            //return officeList.Where(s=>s.officeId==officeID).ToList();
        }
    }
}