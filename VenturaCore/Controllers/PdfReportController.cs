using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "file1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Ventura Pdf Report");

            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/file1.pdf", "application/pdf", "file1.pdf");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "file2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);

            pdfPTable.AddCell("Guest Name");
            pdfPTable.AddCell("Guest Surname");
            pdfPTable.AddCell("Guest Identity");

            pdfPTable.AddCell("Roxana");
            pdfPTable.AddCell("Muntain");
            pdfPTable.AddCell("11111111110");

            pdfPTable.AddCell("Dave");
            pdfPTable.AddCell("Mustaine");
            pdfPTable.AddCell("22222222222");

            pdfPTable.AddCell("Jason");
            pdfPTable.AddCell("Backer");
            pdfPTable.AddCell("44444444445");

            document.Add(pdfPTable);

            document.Close();
            return File("/pdfreports/file2.pdf", "application/pdf", "file2.pdf");
        }
    }
}