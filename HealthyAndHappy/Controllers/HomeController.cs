using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HealthyAndHappy.Models;
using Microsoft.AspNetCore.Identity;
using HealthyAndHappy.Services.Interfaces;
using HealthyAndHappy.Models.ModelsDTO;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Text.Json;

namespace HealthyAndHappy.Controllers
{


    public static class SessionExtensions {
        public static void Set<T>(this ISession session, string key, T value) {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T Get<T>(this ISession session, string key) {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }
    }

    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;


        public const string SessionKeyMail = "_Mail";
        public const string SessionKeyPassword = "_PAssword";
        const string SessionKeyTime = "_Time";

        public string SessionInfo_Mail { get; private set; }
        public string SessionInfo_Password { get; private set; }
        public string SessionInfo_CurrentTime { get; private set; }
        public string SessionInfo_SessionTime { get; private set; }
        public string SessionInfo_MiddlewareValue { get; private set; }

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn() {
            return View("Views/Home/SignIn.cshtml");
        }



        [HttpPost]
        public IActionResult SignIn(LoginModel reg) {

            string mail = reg.Email;
            string pass = reg.Password;

            using(SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")) {
                connection.Open();

                SqlCommand command = new SqlCommand(($"SELECT PasswordHash FROM dbo.AspNetUsers WHERE Email = '{mail}'"), connection);

                var output = command.ExecuteScalar();

                if(output is null) {
                    TempData["Message"] = "Niepoprawne dane logowania.";
                    return RedirectToAction("SignIn", "Home");
                }

                if(output.ToString() == pass) {


                    if(string.IsNullOrEmpty(HttpContext.Session.GetString(SessionKeyMail))) {
                        HttpContext.Session.SetString(SessionKeyMail, mail);
                        HttpContext.Session.SetString(SessionKeyPassword, pass);
                    }

                    var email = HttpContext.Session.GetString(SessionKeyMail);
                    var password = HttpContext.Session.GetString(SessionKeyPassword);


                    if(HttpContext.Session.Get<DateTime>(SessionKeyTime) == default) {
                        HttpContext.Session.Set<DateTime>(SessionKeyTime, DateTime.Now);
                    }

                    if(HttpContext.Session.IsAvailable) {
                        return RedirectToAction("Larder", "Home");
                    }
                    else {
                        TempData["Message"] = "Błąd sesji.";
                        return RedirectToAction("SignIn", "Home");
                    }


                }
                else {
                    TempData["Message"] = "Niepoprawne dane logowania.";
                    return RedirectToAction("SignIn", "Home");
                }

                
            }
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

        public IActionResult Larder() {

            string mail = HttpContext.Session.GetString(SessionKeyMail);
            string pass = HttpContext.Session.GetString(SessionKeyPassword);

            if((string.IsNullOrEmpty(mail)) || (string.IsNullOrEmpty(pass))) { 
                TempData["Message"] = "Błąd sesji.";
                return RedirectToAction("SignIn", "Home");
            }


            return View("Views/Home/Larder.cshtml");




        }


        public IActionResult LarderSave() {

            string mail = HttpContext.Session.GetString(SessionKeyMail);
            string pass = HttpContext.Session.GetString(SessionKeyPassword);

            if((string.IsNullOrEmpty(mail)) || (string.IsNullOrEmpty(pass))) {
                TempData["Message"] = "Błąd sesji.";
                return RedirectToAction("SignIn", "Home");
            }


            return View("Views/Home/Larder.cshtml");
        }



        public IActionResult Logout() {

            HttpContext.Session.Clear();

            HttpContext.Session.Remove(SessionKeyMail);
            HttpContext.Session.Remove(SessionKeyPassword);

            string mail = HttpContext.Session.GetString(SessionKeyMail);
            string pass = HttpContext.Session.GetString(SessionKeyPassword);


            return RedirectToAction("Index", "Home");

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
