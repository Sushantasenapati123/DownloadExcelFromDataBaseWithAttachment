﻿using ClosedXML.Excel;
using Exam.Domain.Email;
using Exam.Domain.Sports;
using Exam.Irepository.ISport;
using Exam.IRepository.Email;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Web.Controllers
{//Sport_Registration
   
    public class SportController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly SpotInterface log;
        private readonly IMailService mailService;


        public SportController(SpotInterface _log, IWebHostEnvironment environment, IMailService mailServicee)
        {
            _environment = environment;
            log = _log;
            mailService = mailServicee;
        }
        [HttpPost]
        public async Task<JsonResult> SendEmailAsyncFromAPath(MailRequest email)
        {
            string imagepath=  log.GetById(22).Result.image_path.ToString();//prodimage/png1 (5).png
            string attachmentPath = @"C:\Users\sushanta.senapati\Desktop\CSM All Exam\SecondMonthExam With Attachment\DownloadExcelFromDataBase\Exam.Web\wwwroot\"+ imagepath;
            if (System.IO.File.Exists(attachmentPath))
            {
                using (var memoryStream = new MemoryStream())
                using (var fileStream = new FileStream(attachmentPath, FileMode.Open, FileAccess.Read))
                {
                    await fileStream.CopyToAsync(memoryStream);

                    memoryStream.Position = 0; // Reset the position to the beginning

                    // Create a byte array from the memory stream
                    byte[] attachmentBytes = memoryStream.ToArray();

                    // Attach the byte array to the email
                    email.AttachmentBytes = attachmentBytes;
                }

                await mailService.SendEmailAsyncFromAPath(email);

                return Json(1);
            }

            return Json(1);

        }
        public async Task<JsonResult> SendSucessEmail(MailRequest email)
        {
            if (email.Attachment != null && email.Attachment.Length > 0)
            {
                // You can handle the attachment here, e.g., save it to a directory or process it
                // Example: string fileName = Path.GetFileName(email.Attachment.FileName);
                //          string filePath = Path.Combine(Server.MapPath("~/Attachments"), fileName);
                //          email.Attachment.SaveAs(filePath);
            }



            await mailService.SendEmailAsync(email);
            if (true)
            {
                return Json(1);
            }


        }
        public async Task<IActionResult> Sport_Registration()
        {
            try
            {
                Log.Information("Sport_Registration Started");
                List<Spot> pc1 = new List<Spot>();
                // DesignationName ds = new DesignationName();//////for search
                pc1 = await log.BindClub();
                pc1.Insert(0, new Spot { club_id = 0, club_name = "Select" });
                ViewBag.UnitName = pc1;
                ViewBag.Result = await log.GetAll(new Spot());
                Log.Information("Sport_Registration");
                return View();
               
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message + "\n" + ex.StackTrace);
                return Json(0);
            }

        }
        public async Task<IActionResult> View_SportRegistration()
        {

            ViewBag.Result = await log.GetAll(new Spot());
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Add(Spot entity)
        {

            string[] files = entity.image_path.Split('\\');
            entity.image_path = "prodimage/" + files[files.Length - 1];

            int retMsg = await log.insert(entity);

                if (retMsg == 1)
                {
                    return Json("Record Saved Successfully");
                }
                else if (retMsg == 2)
                {
                    return Json("Record Updated Successfully");
                }
                else if (retMsg == 5)
                {
                    return Json("Age must Be Greater Than 13");
                }
               else
                {
                    return Json("Record Already Exist");
                }

            
          
        }
        [HttpPost]
        public IActionResult UploadImage(IFormFile MyUploader)
        {
            if (MyUploader != null)
            {
                string uploadsFolder = Path.Combine(_environment.WebRootPath, "prodimage");
                string filePath = Path.Combine(uploadsFolder, MyUploader.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    MyUploader.CopyTo(fileStream);
                }
                return new ObjectResult(new { status = "success" });
            }
            return new ObjectResult(new { status = "fail" });

        }

        [HttpGet]
        public async Task<IActionResult> GetSubCatByCId(int clubid)
        {
            //List<Spot> pc4 = new List<Spot>();
            //pc4 = await log.BindSportByClubId(clubid);
            //pc4.Insert(0, new Spot { sport_Id = 0, sprot_name = "Select" });
            //ViewBag.Catagory = pc4;

            var Slots = log.BindSportByClubId(clubid).Result;
            return Ok(JsonConvert.SerializeObject(Slots));
        }


        [HttpGet]
        public IActionResult MedicineGetById(int id)
        {
            var Doctors = log.GetById(Convert.ToInt32(id)).Result;



            return Ok(JsonConvert.SerializeObject(Doctors));
        }


        public void deathreportexcell(/*List<Registration_Details> data*/)
        {
            using (var workbook = new XLWorkbook())
            {
                int count = 0;
                var worksheet = workbook.Worksheets.Add("Report");
                var currentRow = 1;

                worksheet.Cell(currentRow, 1).Value = "Sl. NO";
                worksheet.Cell(currentRow, 2).Value = "NAME";
                worksheet.Cell(currentRow, 3).Value = "Email";
                worksheet.Cell(currentRow, 4).Value = "MOBILE NO";
                worksheet.Cell(currentRow, 5).Value = "IMAGE";
                worksheet.Cell(currentRow, 6).Value = "CLUB NAME";
                worksheet.Cell(currentRow, 7).Value = "SPORTS NAME";
              

                List<Spot> data = log.GetAllExcelData(new Spot());


                foreach (var val in data)
                {
                    {

                        count = ++count;
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = count;
                        worksheet.Cell(currentRow, 2).Value = val.Applicant_name;
                        worksheet.Cell(currentRow, 3).Value = val.Email;
                        worksheet.Cell(currentRow, 4).Value = val.Mobile_no;

                        worksheet.Cell(currentRow, 5).Value = val.image_path;
                        worksheet.Cell(currentRow, 6).Value = val.club_name;
                        worksheet.Cell(currentRow, 7).Value = val.sprot_name;
                      

                    }
                }
                var stream = new MemoryStream();
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                Response.Clear();
                Response.Headers.Add("content-disposition", "attachment;filename=Report.xls");
                Response.ContentType = "application/xls";
                Response.Body.WriteAsync(content);
                Response.Body.Flush();
            }
        }

       

    }
}
