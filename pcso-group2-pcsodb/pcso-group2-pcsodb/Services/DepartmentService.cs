using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using pcso_group2_pcsodb.Model;
using pcso_group2_pcsodb.Services;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;
using pcso_group2_pcsodb.View;
using System.Net.Http.Json;

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
        //public async Task<List<Department>> GetDepartments()
        //{
        //    if (officeList?.Count > 0)
        //        return officeList;
        //    string requestURL = "https://pcso-linfred-backend.azurewebsites.net/api/Offices";
        //    try
        //    {
        //        var response = await httpClient.GetAsync(requestURL);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            officeList = await response.Content.ReadFromJsonAsync<List<Office>>();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Debug.WriteLine(e.Message);
        //    }
        //    return officeList;
        //}
        public async Task<List<Department>> GetDepartmentsBySectorid(int sectorID)
        {
            //if (officeList?.Count > 0)
            //    return officeList;
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
