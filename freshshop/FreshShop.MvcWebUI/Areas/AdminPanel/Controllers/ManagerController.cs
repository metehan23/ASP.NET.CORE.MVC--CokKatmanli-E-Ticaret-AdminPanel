﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreshShop.Business.Abstract;
using FreshShop.Model.Entity;
using FreshShop.Model.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using FreshShop.MvcWebUI.Helpers;
using FreshShop.MvcWebUI.Extensions;
using System.IO;

namespace FreshShop.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ManagerController : Controller
    {
        private readonly IManagerBs _managerBs;
        public ManagerController(IManagerBs managerBs)
        {
            _managerBs = managerBs;
        }
        
       [HttpGet]
        public IActionResult LogIn()
        {
            string cookie_UN = Request.Cookies["ActiveManagerUN_CK"];
            string cookie_PW = Request.Cookies["ActiveManagerPW_CK"];

            if (!string.IsNullOrEmpty(cookie_UN) && !string.IsNullOrEmpty(cookie_PW))
            {
                ViewData["cookie_UN"] = cookie_UN;
                ViewData["cookie_PW"] = cookie_PW;
                ViewData["chIsChecked"] = true;
            }
            else
                ViewData["chIsChecked"] = false;

            return View();
        }
        [HttpPost]
        public IActionResult LogIn(ManagerLogInVm vm)
        {
            if (!ModelState.IsValid)
            {
                var errorMessages = "";
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errorMessages += error.ErrorMessage + "<br />";
                    }
                }
                return Json(new { IsOk = false,Message=errorMessages });
            }


           Manager manager= _managerBs.LogIn(vm.UserName, vm.Password);

            if (manager!=null)
            {
                if (vm.RememberMe)
                {
                    CookieOptions options = new CookieOptions();
                    options.Expires = DateTime.Now.AddDays(20);

                    //cookie de saklanan değer HASHlenecek
                    Response.Cookies.Append("ActiveManagerUN_CK", vm.UserName, options);
                    Response.Cookies.Append("ActiveManagerPW_CK", vm.Password, options);
                }
                else
                {
                    Response.Cookies.Delete("ActiveManagerUN_CK");
                    Response.Cookies.Delete("ActiveManagerPW_CK");
                }


                HttpContext.Session.SetObject("ActiveManager", manager);

                return Json(new { IsOk = true });
            }
                


            return Json(new {IsOk=false,Message="Kullanıcı Bulunamadı" });

            
        }


        [HttpPost]
        public IActionResult  ForgotPassword(ManagerForgotPasswordVm vm)
        {
           Manager manager= _managerBs.GetByEmail(vm.Email);

            if (manager != null)
            {
                //bu yöneticinin şifresi belirtilen email hesabına gönderilecek
                string message = $"Sayın {manager.FullName}. Şifreniz : <b>{manager.Password}</b>";
                MailHelper.SendMail(vm.Email, "Şifreniz", message);

                return Json(new { isOk = true, Message = "Şifreniz email hesabınıza gönderilmiştir." });
            }
            else
                return Json(new { isOk = false,Message="Bu email hesabı ile kayıtlı bir yönetici bulunamadı" });
        }

        public IActionResult Index()
        {
            List<Manager> managers= _managerBs.GetAll();

            return View(managers);
        }
        [HttpGet]
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(Manager vm)
        {
            _managerBs.Insert(vm);
            return Json(new {isOk=true,Message="Yönetici Başarıyla Kaydedildi" });
        }

        [HttpPost]
        public IActionResult PhotoUpload()
        {
            IFormFileCollection files = Request.Form.Files;
            if (files.Count > 0)
            {
                var fileName = files[0].FileName;
                var contentType = files[0].ContentType; //MIME Types
                var lenght = files[0].Length;

                if (!contentType.StartsWith("image/"))
                    return Json(new { isOk = false, Message = "Lütfen Resim Dosyası Seçiniz" });

                var randomFileName = RandomValueGenerator.GenerateFileName(Path.GetExtension(fileName));


                string uploadPath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/AdminPanelContent/images/ManagerPhotos",randomFileName);

                using (var stream = new FileStream(uploadPath,FileMode.Create))
                {
                    files[0].CopyTo(stream);
                }

                return Json(new { isOk = true,PhotoPath= "/AdminPanelContent/images/ManagerPhotos/"+randomFileName });

            }
            else
            {
                return Json(new { isOk = false, Message="Lütfen Fotoğraf Seçiniz"});
            }
        }
    } 
}