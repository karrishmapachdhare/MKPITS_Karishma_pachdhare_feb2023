using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace webapirestinmvc.Controllers
{
    public class HomeController : Controller
    {
        
        //Hosted web API REST Service base url  
      string Baseurl = &quot; http://192.168.95.1:5555/&quot;;      
         public async Task&lt;ActionResult&gt; Index()
         {               List&lt;Employee&gt; EmpInfo = new List&lt;Employee&gt;();  
             
             using (var client = new HttpClient())               {  
                 //Passing service base url                  client.BaseAddress = new Uri(Baseurl);     
25.                 client.DefaultRequestHeaders.Clear();  
26.                 //Define request data format  
27.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(&quot; appli
cation/json&quot;));  
28.                   
29.
                //Sending request to find web api REST service resource GetAllEmployees using Http
Client  
30.                 HttpResponseMessage Res = await client.GetAsync(&quot; api/Employee&quot;);  
31.   
32.                 //Checking the response is successful or not which is sent using HttpClient  
33.                 if (Res.IsSuccessStatusCode)  
34.                 {  
35.                     //Storing the response details recieved from web api   
36.                     var EmpResponse = Res.Content.ReadAsStringAsync().Result;  
37.   
38.
                    //Deserializing the response recieved from web api and storing into the Employ
ee list  
39.                     EmpInfo = JsonConvert.DeserializeObject&lt;List&lt;Employee&gt;&gt;(EmpResponse);  
40.   
41.                 }  
42.                 //returning the employee list to view  
43.                 return View(EmpInfo);
}
}