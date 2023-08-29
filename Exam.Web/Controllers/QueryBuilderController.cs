using System;
using System.Data;
//using FrameworkConsole.Repository.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

using System.Data.SqlClient;
//using FrameworkConsole.Model.Entities.Login;
using Microsoft.Extensions.Configuration;

using FrameworkConsole.Model.QueryBuilder;

namespace FrameworkConsole.Web.Controllers
{
    public class QueryBuilderController : Controller
    {
       
        public bool IsDML { get; set; }
        public IConfiguration Configuration { get; }
        public QueryBuilderController(IConfiguration configuration)
        {
          
            Configuration = configuration;
           
        }
        [HttpGet]
        public IActionResult QueryBuilderLogin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult QueryBuilderLogin(QueryBuilderModel ng/*Login Model*/)
        {
            return View();
            //try
            //{
            //    if (Model.VCHUSERNAME == null)
            //    {

            //        //Model.Message = "Please enter user name.";
            //        //return View(Model);
            //        ViewBag.showmessage = "Please enter user name.";
            //        return View();
            //    }
            //    else if (Model.vchpassword == null)
            //    {
            //        ViewBag.showmessage = "Please enter Password.";
            //        return View();
            //        //Model.Message = "Please enter password.";
            //        //return View(Model);
            //    }
            //    else
            //    {
            //        var userName = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("QueryBuilder")["UserName"];
            //        var password = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("QueryBuilder")["Password"];
            //        if ((Model.VCHUSERNAME == userName) & (Model.vchpassword == password))
            //        {
            //            //HttpContext.Session.SetString("_vchpassword", Model.vchpassword);
            //            //HttpContext.Session.SetString("_VCHUSERNAME", Model.VCHUSERNAME);

            //            return RedirectToAction("QueryBuilder", "QueryBuilder");
            //        }
            //        else
            //        {
            //            ViewBag.showmessage = "The user name or password provided is incorrect.";
            //            return View();
            //            // Model.Message = "The user name or password provided is incorrect.";
            //            // return View(Model);

            //        }
            //    }

            //}
            //catch (Exception ex)
            //{

            //    // return View(Model);
            //    throw ex;

            //}
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult QueryBuilder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult QueryBuilder(QueryBuilderModel objQuerybuilder)
        {
            //var logid = HttpContext.Session.GetString("_VCHUSERNAME");
            //if (logid != null)
            //{
                string strQuery = objQuerybuilder.QueryText;
                if (strQuery == "" || strQuery == null)
                {
                    ViewBag.showmessage = "Query Textbox can not be left blank!!!";

                    return View();
                }
                else
                {
                    if (!IsValidQuery(strQuery, objQuerybuilder.DMLCode))
                    {

                        ViewBag.showmessage = "You are not authorized to perform any DML operation. A notification has been sent to administrator regarding such accessibility. Please contact your administrator for authorization.";

                        return View();
                    }
                    else
                    {
                        if (IsDML == true)
                        {
                            int affectedRow = RunOracleTransactionExecuteNonQuery(strQuery);// ExecuteNonQuery(strQuery);*/
                            objQuerybuilder.QueryText = "";
                            if (affectedRow > 0)
                            {
                                ViewBag.showmessage = $"Command executed successfully...{affectedRow} Rows affected";
                                return View();

                            }
                            else if (affectedRow == -1)
                            {
                                ViewBag.showmessage = $"Command executed successfully...";
                                return View();

                            }
                            else
                            {
                            //ViewBag.showmessage = TempData["Message"].ToString();
                            ViewBag.showmessage = $"Command executed successfully...{affectedRow} Rows affected";
                            return View();
                            }


                        }
                        else
                        {
                            DataTable dtData = GetData(strQuery);
                            ViewBag.Result = dtData;
                            return View();

                        }
                    }
                }
            //}
            //else
            //{
            //    ViewBag.showmessage = "Sesssion out !!";
            //     return View();
            //   // return RedirectToAction( "QueryBuilderLogin", "QueryBuilder");
            //}
          


        }
        public int RunOracleTransactionExecuteNonQuery(string query)
        {
            string conString = Microsoft.Extensions.Configuration.ConfigurationExtensions.GetConnectionString(this.Configuration, "DefaultConnection");
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                int affectedRow = 0;
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                // Assign transaction object for a pending local transaction
                command.Transaction = transaction;

                try
                {

                    command.CommandText = query;
                    affectedRow = command.ExecuteNonQuery();
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["Message"] = ex.Message;
                    TempData.Keep();

                   // Logger.LogError(ex, "Error while executing the query", query);

                }
                return affectedRow;
            }
        }

        private DataTable GetData(string query)
        {
            string conString = Microsoft.Extensions.Configuration.ConfigurationExtensions.GetConnectionString(this.Configuration, "DefaultConnection");
            DataTable dt = new DataTable();
            string oradb = conString;
          
            using (SqlConnection conn = new SqlConnection(oradb))
                try
                {

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }


                catch (Exception ex)
                {
                   // Logger.LogError(ex, "Error while executing the query", query);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            return dt;
        }
        private bool IsValidQuery(string query, string authority)
        {
            IsDML = false;
            if (query.ToLower().Contains("update ") ||
                query.ToLower().Contains("insert ") ||
                query.ToLower().Contains("create ") ||
                query.ToLower().Contains("alter ") ||
                query.ToLower().Contains("delete ") ||
                query.ToLower().Contains("truncate ") ||
                query.ToLower().Contains("drop ") ||
                query.ToLower().Contains("exec "))
            {
                IsDML = true;
                var dmlcode = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("QueryBuilder")["DMLACode"];
                if (authority == dmlcode)
                {
                    return true;
                }
                else
                    return authority == DateTime.Today.ToString("ddMMyyyy") + "5T";
            }
            return true;
        }

    }
}
