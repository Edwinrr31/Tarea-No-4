using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Tarea_4.Models;

namespace Tarea_4.Controllers
{
    public class ExcelController : Controller
    {
        // GET: Excel
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Import(HttpPostedFileBase excelfile)
        {
            if (excelfile == null || excelfile.ContentLength == 0)
            {
                ViewBag.Error = "Seleccione un archivo excel<br>";
                return View("Index");
            }
            else
            {
                if (excelfile.FileName.EndsWith("xls") || excelfile.FileName.EndsWith("xlsx"))
                {
                    string path = Server.MapPath("~/Uploads/" + excelfile.FileName);
                    if (System.IO.File.Exists(path))
                        System.IO.File.Delete(path);
                    excelfile.SaveAs(path);

                    //Leer datos del archivo excel
                    Excel.Application application = new Excel.Application();
                    Excel.Workbook workbook = application.Workbooks.Open(path);
                    Excel.Worksheet worksheet = workbook.ActiveSheet;
                    Excel.Range range = worksheet.UsedRange;
                    List<ExcelModel> listaDatos = new List<ExcelModel>();
                    for (int row = 2; row <= range.Rows.Count; row++)
                    {
                        ExcelModel e = new ExcelModel();
                        e.Id = ((Excel.Range)range.Cells[row, 1]).Text;
                        e.Nombre = ((Excel.Range)range.Cells[row, 2]).Text;
                        e.Precio = decimal.Parse(((Excel.Range)range.Cells[row, 3]).Text);
                        e.Cantidad = int.Parse(((Excel.Range)range.Cells[row, 4]).Text);

                        listaDatos.Add(e);
                    }

                    ViewBag.ListaDatos = listaDatos;

                    return View("Success");
                }
                else
                {
                    ViewBag.Error = "Tipo de archivo es incorrecto<br>";
                    return View("Index");
                }

            }
        }
    }
}