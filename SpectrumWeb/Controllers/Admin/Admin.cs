using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SpectrumWeb.Models;
using SpectrumWeb.Controllers.ControllerCommon;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Utilities;

namespace SpectrumWeb.Controllers.Admin
{
    public class AdminController : Controller
    {

        private readonly ArmsSpectrumDevelopmentContext context;


        public AdminController(ArmsSpectrumDevelopmentContext context)
        {
            this.context = context;
        }

        public IActionResult Admin()
        {
            return View("~/Views/Admin/Admin.cshtml");
        }

        [HttpPost]
        public string SignIn(string userId, string password)
        {
            if (String.IsNullOrEmpty(userId) || String.IsNullOrEmpty(password))
            {
                return "FAILURE";
            }

            var sqlCon = new SqlConnection("Server=.\\SQLExpress;Database=ArmsSpectrumDevelopment;Trusted_Connection=Yes;TrustServerCertificate=True");

            sqlCon.Open();

            string query = "select * from [admin].[user] where convert(varchar,user_id)='" + userId + "' and convert(varchar,password)='" + password + "'";
            
            var sqlCmd = new SqlCommand(query, sqlCon);
            
            var rslt = sqlCmd.ExecuteReader();

            if (rslt.HasRows)
            {
                var session = HttpContext.Session;

                session.Set("HasSignedIn", new byte[1] { 1 });

                return "SUCCESS";
            }

            else
            {
                return "FAILURE";
            }
        }

    }
}
