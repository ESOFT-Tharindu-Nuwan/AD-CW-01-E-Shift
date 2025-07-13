using EShift.Business.Interface;
using EShift.Models; // Assuming Job, Customer, etc. are here
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel; // For Excel
using PdfSharp.Drawing; // For PDF
using PdfSharp.Pdf;   // For PDF
using MigraDoc.DocumentObjectModel; // For PDF
using MigraDoc.DocumentObjectModel.Tables; // For PDF
using MigraDoc.Rendering; // For PDF

namespace EShift.Business.Service
{
    public class ReportService : IReportService
    {
        private readonly IJobService _jobService;
        private readonly ICustomerService _customerService;
        // Add other services if you need their data for reports

        // Constructor to inject necessary data services
        public ReportService(IJobService jobService, ICustomerService customerService)
        {
            _jobService = jobService;
            _customerService = customerService;
        }

        // --- EXCEL REPORT GENERATION ---
        public async Task<MemoryStream> GenerateJobsExcelReportAsync()
        {
            var jobs = await Task.Run(() => _jobService.GetAllJobs()); // Run on background thread
            var stream = new MemoryStream();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Jobs Report");

                // Headers
                worksheet.Cell("A1").Value = "Job ID";
                worksheet.Cell("B1").Value = "Job Number";
                worksheet.Cell("C1").Value = "Status";
                worksheet.Cell("D1").Value = "Customer";
                worksheet.Cell("E1").Value = "Origin";
                worksheet.Cell("F1").Value = "Destination";
                worksheet.Cell("G1").Value = "Status";
                worksheet.Cell("H1").Value = "Created Date";
                worksheet.Cell("I1").Value = "Due Date";
                worksheet.Cell("J1").Value = "Total Cost";

                // Data rows
                int currentRow = 2;
                foreach (var job in jobs)
                {
                    worksheet.Cell(currentRow, 1).Value = job.JobID;
                    worksheet.Cell(currentRow, 2).Value = job.JobNumber;
                    worksheet.Cell(currentRow, 3).Value = job.JobStatus;

                    // Get customer name if CustomerID is available
                    string customerName = "";
                    if (job.CustomerID.HasValue)
                    {
                        var customer = await Task.Run(() => _customerService.GetCustomerById(job.CustomerID.Value));
                        customerName = customer != null ? $"{customer.FirstName} {customer.LastName}" : "N/A";
                    }
                    worksheet.Cell(currentRow, 4).Value = customerName;

                    worksheet.Cell(currentRow, 5).Value = job.PickupLocation;
                    worksheet.Cell(currentRow, 6).Value = job.DeliveryLocation;
                    worksheet.Cell(currentRow, 7).Value = job.JobStatus;
                    worksheet.Cell(currentRow, 8).Value = job.RequestedDate.ToString("yyyy-MM-dd");
                    worksheet.Cell(currentRow, 9).Value = job.ActualDeliveryDate?.ToString("yyyy-MM-dd") ?? "N/A";
                    worksheet.Cell(currentRow, 10).Value = job.FinalPrice.HasValue ? job.FinalPrice.Value.ToString("C") : "N/A";

                    currentRow++;
                }

                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(stream);
            }
            stream.Position = 0; // Reset stream position to the beginning
            return stream;
        }

        public async Task<MemoryStream> GenerateCustomersExcelReportAsync()
        {
            var customers = await Task.Run(() => _customerService.GetAllCustomers());
            var stream = new MemoryStream();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Customers Report");

                // Headers
                worksheet.Cell("A1").Value = "Customer ID";
                worksheet.Cell("B1").Value = "Customer Number";
                worksheet.Cell("C1").Value = "First Name";
                worksheet.Cell("D1").Value = "Last Name";
                worksheet.Cell("E1").Value = "Email";
                worksheet.Cell("F1").Value = "Phone";
                worksheet.Cell("G1").Value = "Address";
                worksheet.Cell("H1").Value = "City";
                worksheet.Cell("I1").Value = "Province";
                worksheet.Cell("J1").Value = "Postal Code";

                // Data rows
                int currentRow = 2;
                foreach (var customer in customers)
                {
                    worksheet.Cell(currentRow, 1).Value = customer.CustomerID;
                    worksheet.Cell(currentRow, 2).Value = customer.CustomerNumber;
                    worksheet.Cell(currentRow, 3).Value = customer.FirstName;
                    worksheet.Cell(currentRow, 4).Value = customer.LastName;
                    worksheet.Cell(currentRow, 5).Value = customer.Email;
                    worksheet.Cell(currentRow, 6).Value = customer.PhoneNumber;
                    worksheet.Cell(currentRow, 7).Value = $"{customer.AddressLine1}, {customer.AddressLine2}";
                    worksheet.Cell(currentRow, 8).Value = customer.City;
                    worksheet.Cell(currentRow, 9).Value = customer.Province;
                    worksheet.Cell(currentRow, 10).Value = customer.PostalCode;
                    currentRow++;
                }

                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(stream);
            }
            stream.Position = 0;
            return stream;
        }


        // --- PDF REPORT GENERATION (using MigraDoc/PdfSharp) ---
        public async Task<MemoryStream> GenerateJobsPdfReportAsync()
        {
            var jobs = await Task.Run(() => _jobService.GetAllJobs());
            var document = new Document();
            document.Info.Title = "Job Report";
            document.Info.Subject = "List of all jobs";

            var section = document.AddSection();
            section.AddParagraph("Jobs Report").AddFormattedText("Jobs Report", TextFormat.Bold);
            section.AddParagraph("Generated on: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            section.AddParagraph("");

            // Create a table for jobs
            var table = section.AddTable();
            table.Borders.Width = 0.75; // All borders
            table.Format.SpaceAfter = "1cm";

            // Define columns
            table.AddColumn("2cm").Format.Alignment = ParagraphAlignment.Center; // Job ID
            table.AddColumn("3cm"); // Job Number
            table.AddColumn("4cm"); // Description
            table.AddColumn("3cm"); // Customer
            table.AddColumn("3cm"); // Status
            table.AddColumn("3cm"); // Created Date

            // Add header row
            var headerRow = table.AddRow();
            headerRow.Shading.Color = MigraDoc.DocumentObjectModel.Colors.LightGray;
            headerRow.Cells[0].AddParagraph("ID").AddFormattedText("ID", TextFormat.Bold);
            headerRow.Cells[1].AddParagraph("Job No.").AddFormattedText("Job No.", TextFormat.Bold);
            headerRow.Cells[2].AddParagraph("Description").AddFormattedText("Description", TextFormat.Bold);
            headerRow.Cells[3].AddParagraph("Customer").AddFormattedText("Customer", TextFormat.Bold);
            headerRow.Cells[4].AddParagraph("Status").AddFormattedText("Status", TextFormat.Bold);
            headerRow.Cells[5].AddParagraph("Created").AddFormattedText("Created", TextFormat.Bold);

            // Add data rows
            foreach (var job in jobs)
            {
                var row = table.AddRow();
                row.Cells[0].AddParagraph(job.JobID.ToString());
                row.Cells[1].AddParagraph(job.JobNumber);
                row.Cells[2].AddParagraph(job.JobStatus);

                string customerName = "N/A";
                if (job.CustomerID.HasValue)
                {
                    var customer = await Task.Run(() => _customerService.GetCustomerById(job.CustomerID.Value));
                    customerName = customer != null ? $"{customer.FirstName} {customer.LastName}" : "N/A";
                }
                row.Cells[3].AddParagraph(customerName);

                row.Cells[4].AddParagraph(job.JobStatus);
                row.Cells[5].AddParagraph(job.RequestedDate.ToString("yyyy-MM-dd"));
            }

            // Render the document to a PDF stream
            var renderer = new PdfDocumentRenderer(true);
            renderer.Document = document;
            renderer.RenderDocument();

            var stream = new MemoryStream();
            renderer.PdfDocument.Save(stream, false); // false to close stream after saving
            stream.Position = 0; // Reset stream position to the beginning
            return stream;
        }

        public async Task<MemoryStream> GenerateCustomersPdfReportAsync()
        {
            var customers = await Task.Run(() => _customerService.GetAllCustomers());
            var document = new Document();
            document.Info.Title = "Customer Report";
            document.Info.Subject = "List of all customers";

            var section = document.AddSection();
            section.AddParagraph("Customers Report").AddFormattedText("Customers Report", TextFormat.Bold);
            section.AddParagraph("Generated on: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            section.AddParagraph("");

            var table = section.AddTable();
            table.Borders.Width = 0.75;
            table.Format.SpaceAfter = "1cm";

            table.AddColumn("2cm").Format.Alignment = ParagraphAlignment.Center;
            table.AddColumn("3cm");
            table.AddColumn("4cm");
            table.AddColumn("3cm");
            table.AddColumn("4cm");

            var headerRow = table.AddRow();
            headerRow.Shading.Color = MigraDoc.DocumentObjectModel.Colors.LightGray;
            headerRow.Cells[0].AddParagraph("ID").AddFormattedText("ID", TextFormat.Bold);
            headerRow.Cells[1].AddParagraph("Customer No.").AddFormattedText("Customer No.", TextFormat.Bold);
            headerRow.Cells[2].AddParagraph("Name").AddFormattedText("Name", TextFormat.Bold);
            headerRow.Cells[3].AddParagraph("Phone").AddFormattedText("Phone", TextFormat.Bold);
            headerRow.Cells[4].AddParagraph("Email").AddFormattedText("Email", TextFormat.Bold);

            foreach (var customer in customers)
            {
                var row = table.AddRow();
                row.Cells[0].AddParagraph(customer.CustomerID.ToString());
                row.Cells[1].AddParagraph(customer.CustomerNumber);
                row.Cells[2].AddParagraph($"{customer.FirstName} {customer.LastName}");
                row.Cells[3].AddParagraph(customer.PhoneNumber);
                row.Cells[4].AddParagraph(customer.Email);
            }

            var renderer = new PdfDocumentRenderer(true);
            renderer.Document = document;
            renderer.RenderDocument();

            var stream = new MemoryStream();
            renderer.PdfDocument.Save(stream, false);
            stream.Position = 0;
            return stream;
        }
    }
}
