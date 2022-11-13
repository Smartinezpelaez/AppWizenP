using AppWizen.BLL.DTOs;
using AppWizen.BLL.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AppWizen.Web.Controllers
{
    public class AppUserController : Controller
    {
        // GET: AppUser

        /// <summary>
        /// Metodo para listar a los usuarios
        /// </summary>
        /// <param name="appUser"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Index(AppUserService appUser)
        {
            return View(appUser.GetAppServices().ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            BLL.Services.AppUserRoleService appUserRoleService = new AppUserRoleService();
            BLL.Services.ContactServices contactServices = new ContactServices();
            BLL.Services.AppUserService appUser = new BLL.Services.AppUserService();

          //  ViewBag.ListGetAppUserService = appUser.GetAppServices();
            ViewBag.ListGetContacServices = contactServices.GetContacServices();
            ViewBag.ListGetAppUserRoleServices = appUserRoleService.GetAppUserRoleServices();

            return View();
        }

        /// <summary>
        /// Metodo para Crear un usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Create(string id)
        {
            BLL.Services.AppUserRoleService appUserRoleService = new AppUserRoleService();
            BLL.Services.ContactServices contactServices = new ContactServices();
            BLL.Services.AppUserService appUser = new BLL.Services.AppUserService();

         //   ViewBag.ListGetAppUserService = appUser.GetAppServices();
            ViewBag.ListGetContacServices = contactServices.GetContacServices();
            ViewBag.ListGetAppUserRoleServices = appUserRoleService.GetAppUserRoleServices();

            if (ModelState.IsValid) 
            {
                var username = Request.Form["Username"];
                var password = Request.Form["Password"];
                var changePasswordDate = Convert.ToDateTime(Request.Form["ChangePasswordDate"]);
                var active = Convert.ToBoolean(Request.Form["Active"]);
                var roleId = Convert.ToInt32(Request.Form["RoleId"]);
                var contactId = Convert.ToInt32(Request.Form["ContactId"]);
                var resultMessage = Request.Form["resultMessage"];

                //Crea el App User
                appUser.CreateAppUsers(username,
                    password,
                    changePasswordDate,
                    active,
                    roleId,
                    contactId,
                  resultMessage);
                return RedirectToAction("Index");
            }
           
            return View();
        }

        /// <summary>
        /// Metodo para editar a los usuarios
        /// </summary>
        /// <returns></returns>       

        [HttpGet]
        public async Task<ActionResult> Edit()
        {
            BLL.Services.AppUserRoleService appUserRoleService = new AppUserRoleService();
            BLL.Services.ContactServices contactServices = new ContactServices();
            BLL.Services.AppUserService appUser = new BLL.Services.AppUserService();

            ViewBag.ListGetAppUserService = appUser.GetAppServices();
            ViewBag.ListGetContacServices = contactServices.GetContacServices();
            ViewBag.ListGetAppUserRoleServices = appUserRoleService.GetAppUserRoleServices();

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int? id)
        {
            BLL.Services.AppUserRoleService appUserRoleService = new AppUserRoleService();
            BLL.Services.ContactServices contactServices = new ContactServices();
            BLL.Services.AppUserService appUser = new BLL.Services.AppUserService();

            ViewBag.ListGetAppUserService = appUser.GetAppServices();
            ViewBag.ListGetContacServices = contactServices.GetContacServices();
            ViewBag.ListGetAppUserRoleServices = appUserRoleService.GetAppUserRoleServices();
            
            if (ModelState.IsValid)
            {
                var userId = Convert.ToInt32(Request.Form["userId"]);
                var changePasswordDate = Convert.ToDateTime(Request.Form["ChangePasswordDate"]);
                var active = Convert.ToBoolean(Request.Form["Active"]);
                var roleId = Convert.ToInt32(Request.Form["RoleId"]);
                var contactId = Convert.ToInt32(Request.Form["ContactId"]);


                //Edita el AppUser
                appUser.UpdateAppUsers(userId,
                    changePasswordDate.Date,
                    active,
                    roleId,
                    contactId

                );

                return RedirectToAction("Index");
            }
           
            return View();
        }

        /// <summary>
        /// Metodo para eliminar un usuario
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Delete()
        {
            BLL.Services.AppUserRoleService appUserRoleService = new AppUserRoleService();
            BLL.Services.ContactServices contactServices = new ContactServices();
            BLL.Services.AppUserService appUser = new BLL.Services.AppUserService();

            ViewBag.ListGetAppUserService = appUser.GetAppServices();
            ViewBag.ListGetContacServices = contactServices.GetContacServices();
            ViewBag.ListGetAppUserRoleServices = appUserRoleService.GetAppUserRoleServices();

           


            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {

            BLL.Services.AppUserRoleService appUserRoleService = new AppUserRoleService();
            BLL.Services.ContactServices contactServices = new ContactServices();
            BLL.Services.AppUserService appUser = new BLL.Services.AppUserService();

            ViewBag.ListGetAppUserService = appUser.GetAppServices();
            ViewBag.ListGetContacServices = contactServices.GetContacServices();
            ViewBag.ListGetAppUserRoleServices = appUserRoleService.GetAppUserRoleServices();



            appUser.DeleteAppUsers(id);


            return RedirectToAction("Index");
        }
    }
}