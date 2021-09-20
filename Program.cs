using Aspose.Pdf;
Console.WriteLine("Hello, World!");

new License().SetLicense("Aspose.PDF.NET.lic"); //This call crashes on net6.0

using var doc = new Document("sample.pdf");
Console.WriteLine($"This pdf has {doc.Pages.Count} pages");