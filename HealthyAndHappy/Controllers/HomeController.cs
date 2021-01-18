using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HealthyAndHappy.Models;
using System.Data.SqlClient;

namespace HealthyAndHappy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn() {
            return View("Views/Home/SignIn.cshtml");
        }

        public IActionResult SignUp() {
           return View("Views/Home/SignUp.cshtml");
        }

        [HttpPost]
        public IActionResult SignUp(RegisterModel reg) {

            string log = reg.Login;
            string mail = reg.Email;
            string pass = reg.Password;

            using(SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")) 
{
                connection.Open();

                SqlCommand getLastIndex = new SqlCommand($"SELECT TOP 1 Id FROM dbo.AspNetUsers ORDER BY Id DESC", connection);

                int index = (int) Convert.ToInt32(getLastIndex.ExecuteScalar())+1;

                SqlCommand command = new SqlCommand($"INSERT INTO dbo.AspNetUsers (Id, IsAdmin, UserName, Email, EmailConfirmed, PasswordHash, PhoneNumberConfirmed, TwoFactorEnabled, LockOutEnabled, AccessFailedCount) VALUES (@index, 0, @log, @mail, 0, @pass, 0, 0, 0, 0)", connection);

                command.Parameters.Add(new SqlParameter("@index", index));
                command.Parameters.Add(new SqlParameter("@log", log ));
                command.Parameters.Add(new SqlParameter("@mail", mail ));
                command.Parameters.Add(new SqlParameter("@pass", pass ));

                command.ExecuteNonQuery();
            }

            return View("Views/Home/SignIn.cshtml");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
