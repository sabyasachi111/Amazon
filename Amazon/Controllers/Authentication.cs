using Amazon.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using DataLayer.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
   
    public class Authentication : Controller
    {
        private readonly AmazonDbContext dbContext;
        private readonly ILogger _log;
        private readonly INotyfService _Notify;
        public Authentication(AmazonDbContext DbContext,ILogger<Authentication> logger, INotyfService notyf):base()
        {
            dbContext = DbContext;
            _log = logger;
            _Notify = notyf;
        }

       [HttpGet]
       public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn([FromForm]UserModel user)
        {
            if (user == null)
            {
                return RedirectToAction("SignOn");
            }
            if(ModelState.IsValid)
            {
                _log.LogInformation("Model is valid");
                dbContext.Add(user);
                _log.LogTrace("User added");
                dbContext.SaveChanges();
               

            }
            else
            {
                return BadRequest();
            }
            return RedirectToAction("Index","Home");
        }


        [HttpGet]
        public IActionResult LogIn() {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn([FromForm] UserModel user) {
            _log.LogInformation("Login attempt started" + DateTime.Now.ToString() );

            if( user.Email==null || user.Password == null) {
                _log.LogWarning("Wrong Information Passed");
                return BadRequest();
            }
            else
            {
                var email=user.Email;
                var ValidPassword = dbContext.StoreUsers.First(U => U.Email==email);

                if(ValidPassword.Password!=null) {
                    if(ValidPassword.Password==user.Password)
                    {
                        _Notify.Success("Login Successful");
                        _log.LogInformation("Logged In succesfully");
                    }
                    else
                    {
                        _Notify.Error("Login Failed");
                        _log.LogWarning("Wrong Password or Email Address");
                    }
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
