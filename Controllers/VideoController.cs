using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MVCPlantilla.Utilerias;
using System.Data.SqlClient;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            ViewData["datavideo"] = BaseHelper.ejecutarConsulta("select * from video", CommandType.Text);
            return View();
        }
        public ActionResult Agregar()
        {
            return View();
        }
        //POST Procesa los datos ingresados al formulario
        [HttpPost]
        public ActionResult Create(int idvideo,
            string titulo,
            int repro,
            string url)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idvideo", idvideo));
            Parametros.Add(new SqlParameter("@titulo", titulo));
            Parametros.Add(new SqlParameter("@repro", repro));
            Parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("INSERT INTO video VALUES(@idvideo,@titulo,@repro,@url)", CommandType.Text, Parametros);


            return View();


        }
    }
}
