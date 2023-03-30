
using Exam.Domain.Sports;
using Exam.Irepository.ISport;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Web.Controllers
{
    public class PatientController : Controller
    {

        private readonly SpotInterface log;

        public PatientController(SpotInterface _log)
        {
            log = _log;
        }

        public async Task<IActionResult> Patient_Registration()
        {
            List<Spot> pc1 = new List<Spot>();
            // DesignationName ds = new DesignationName();//////for search
            pc1 = await log.BindClub();
            pc1.Insert(0, new Spot { club_id = 0, club_name = "Select" });
            ViewBag.UnitName = pc1;

            return View();
        }
        public async Task<IActionResult> GetAllPatient()
        {
            
            //ViewBag.Result = await log.GetAllPatient(new Patient());
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Add(Spot entity)
        {
            try
            {
                int retMsg = await log.insert(entity);

                if (entity.Registration_Id == 0)
                {
                    return Json("Record Saved Successfully");
                }
                else if (entity.sport_Id!= 0)
                {
                    return Json("Record Updated Successfully");
                }
                else
                {
                    return Json("Record Already Exist");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        [HttpGet]
        public IActionResult UserGetById(int id)
        {
            var Doctors = log.GetById(Convert.ToInt32(id)).Result;

            return Ok(JsonConvert.SerializeObject(Doctors));
        }



    }
}

