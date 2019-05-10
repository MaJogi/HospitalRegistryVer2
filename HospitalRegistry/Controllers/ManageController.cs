using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Open.HospitalRegistry;

namespace Open.HospitalRegistry.Controllers
{
    //public class ManageController : Controller
    //{
    //    private readonly UserManager<ApplicationUser> _userManager;
    //    private readonly SignInManager<ApplicationUser> _signInManager;
    //    private readonly IEmailSender _emailSender;
    //    private readonly ISmsSender _smsSender; //Kas nüüdseks on see kadunud?
    //    private readonly ILogger _logger;

    //    public ManageController(
    //        UserManager<ApplicationUser> userManager,
    //        SignInManager<ApplicationUser> signInManager,
    //        IEmailSender emailSender,
    //        ISmsSender smsSender,
    //        ILoggerFactory loggerFactory)
    //    {
    //        _userManager = userManager;
    //        _signInManager = signInManager;
    //        _emailSender = emailSender;
    //        ISmsSender = smsSender;
    //        _logger = loggerFactory;
    //    }
    //}
}