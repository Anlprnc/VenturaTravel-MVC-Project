using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using VenturaCore.Models;

namespace VenturaCore.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationModels;
        }

        public IActionResult StaticExcelReport()
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Page1");

            workSheet.Cells[1, 1].Value = "Destination";
            workSheet.Cells[1, 2].Value = "Guide";
            workSheet.Cells[1, 3].Value = "Capacity";

            workSheet.Cells[2, 1].Value = "Japan Osaka";
            workSheet.Cells[2, 2].Value = "Zhou";
            workSheet.Cells[2, 3].Value = "50";

            workSheet.Cells[3, 1].Value = "Serbia - Macedonia";
            workSheet.Cells[3, 2].Value = "Haruka";
            workSheet.Cells[3, 3].Value = "35";

            var bytes = excel.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "File2.xlsx");
        }

        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Destination List");
                workSheet.Cell(1, 1).Value = "City";
                workSheet.Cell(1, 2).Value = "Length of Stay";
                workSheet.Cell(1, 3).Value = "Price";
                workSheet.Cell(1, 4).Value = "Capacity";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.DayNight;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NewDestinationList.xlsx");
                }
            }
        }
    }
}