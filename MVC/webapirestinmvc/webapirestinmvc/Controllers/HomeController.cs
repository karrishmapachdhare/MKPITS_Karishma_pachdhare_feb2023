using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using webapirestinmvc.Models;

namespace webapirestinmvc.Controllers
{
    public class HomeController : Controller
    {

        //Hosted web API REST Service base url  
        string Baseurl = &quot; http://192.168.95.1:5555/&quot;;      
         public async Task&lt;ActionResult&gt; Index()
        {
            List & lt; Employee & gt; EmpInfo = new List& lt; Employee & gt; ();

            using (var client = new HttpClient()) {
                //Passing service base url                  client.BaseAddress = new Uri(Baseurl);     
                client.DefaultRequestHeaders.Clear();
                //Define request data format  

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(& quot; application / json & quot;));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient
                HttpResponseMessage Res = await client.GetAsync("api/Employee");

                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details received from web api
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response received from web api and storing into the Employee list
                    EmpInfo = JsonConvert.DeserializeObject<List<Employee>>(EmpResponse);
                }

                //returning the employee list to view
                return View(EmpInfo);

            }

        }
    }

}