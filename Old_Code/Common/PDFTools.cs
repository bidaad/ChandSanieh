using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp;
using System.IO;
using System.Collections;
using iTextSharp.text.pdf.draw;

namespace IONS.Old_App_Code.Common
{
    public class PDFTools
    {
        public void SaveToPDF(string iCreatePDFdir, string iCreatePDFTest, string txtContent, string NPPersianDate, string NewsPaperNo, string PageNumber, string SabtNumber, string SabtDate, string RefernceNumber, string LogoFile, string IndikatorNumber, string strNewsDate, string CompanySabtNumber, string CompanyNationalID)
        {
            Document pdfDocCreatePDF = new Document();
            FileStream myFileStream = new FileStream(iCreatePDFTest, FileMode.Create);
            StreamReader FinalStream = new StreamReader(myFileStream, Encoding.UTF8);
            PdfWriter.GetInstance(pdfDocCreatePDF, FinalStream.BaseStream);
            pdfDocCreatePDF.Open();
            //pdfDocCreatePDF.Add(new Paragraph(richTextBox1.Text)); 

            //FileStream myFileStream = new FileStream(iCreatePDFTest, FileMode.Create);
            pdfDocCreatePDF.Open();
            BaseFont fntBase = BaseFont.CreateFont("c:\\windows\\fonts\\bNazanin.ttf", BaseFont.IDENTITY_H, true);
            iTextSharp.text.Font fntWrite = new iTextSharp.text.Font(fntBase, 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
            iTextSharp.text.Font fntWriteSmall = new iTextSharp.text.Font(fntBase, 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);

            
            PdfPTable table = new PdfPTable(6);
            table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            table.DefaultCell.BorderWidth = 0;
            table.DefaultCell.BorderColor = iTextSharp.text.BaseColor.WHITE;
            table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            
            PdfPCell cell11 = new PdfPCell(new Phrase(2, "تاریخ انتشار: " , fntWriteSmall));
            cell11.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cell11.Padding = 2;
            cell11.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.AddCell(cell11);


            PdfPCell cellSabtDateVal = new PdfPCell(new Phrase(10,  strNewsDate, fntWriteSmall));
            cellSabtDateVal.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cellSabtDateVal.Padding = 4;
            cellSabtDateVal.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            cellSabtDateVal.HorizontalAlignment = Element.ALIGN_LEFT;
            cellSabtDateVal.Colspan = 5;
            table.AddCell(cellSabtDateVal);

            if (!string.IsNullOrEmpty(LogoFile))
            {
                iTextSharp.text.Image imageLogo = iTextSharp.text.Image.GetInstance(@"D:\IONS\WebApp\Files\News\Logos\" + LogoFile);
                imageLogo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                imageLogo.ScalePercent(50);
                PdfPCell cellLogo = new PdfPCell(imageLogo);
                cellLogo.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cellLogo.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cellLogo.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cellLogo.Colspan = 6;
                cellLogo.Padding = 10;
                table.AddCell(cellLogo);
            }

            
            PdfPCell cellText = new PdfPCell(new Phrase(10, txtContent, fntWrite));
            cellText.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cellText.Padding = 10;
            cellText.Colspan = 6;
            table.AddCell(cellText);



            pdfDocCreatePDF.Add(table);

            //PdfWriter PDFWriter = PdfWriter.GetInstance(pdfDocCreatePDF, myFileStream);
            //PDFWriter.ViewerPreferences = PdfWriter.PageModeUseOutlines; 
            //// Our custom Header and Footer is done using Event Handler
            //TwoColumnHeaderFooter PageEventHandler = new TwoColumnHeaderFooter();
            //PDFWriter.PageEvent = PageEventHandler;

            //// Define the page header
            //PageEventHandler.Title = "Test Title";
            //PageEventHandler.HeaderFont = FontFactory.GetFont(BaseFont.COURIER_BOLD, 10, Font.BOLD);
            //PageEventHandler.HeaderLeft = "Group";
            //PageEventHandler.HeaderRight = "1"; 


            pdfDocCreatePDF.Close();

            

        }

        internal void SaveNewsToPDF(string iCreatePDFdir, string iCreatePDFTest, int Code, string Title, string NewsBody, string NewsNo, DateTime NewsDate)
        {
            Document pdfDocCreatePDF = new Document();
            FileStream myFileStream = new FileStream(iCreatePDFTest, FileMode.Create);
            StreamReader FinalStream = new StreamReader(myFileStream, Encoding.UTF8);
            PdfWriter.GetInstance(pdfDocCreatePDF, FinalStream.BaseStream);
            pdfDocCreatePDF.Open();

            //FileStream myFileStream = new FileStream(iCreatePDFTest, FileMode.Create);
            pdfDocCreatePDF.Open();
            BaseFont fntBase = BaseFont.CreateFont("c:\\windows\\fonts\\bNazanin.ttf", BaseFont.IDENTITY_H, true);
            iTextSharp.text.Font fntWrite = new iTextSharp.text.Font(fntBase, 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
            iTextSharp.text.Font fntWriteBold = new iTextSharp.text.Font(fntBase, 10, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);
            iTextSharp.text.Font fntWriteLarge = new iTextSharp.text.Font(fntBase, 14, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);


            PdfPTable table = new PdfPTable(2);
            table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            table.DefaultCell.BorderWidth = 0;
            table.DefaultCell.BorderColor = iTextSharp.text.BaseColor.WHITE;
            table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            string LogoPath = "~/images/Site/PrintLogo.jpg";
            iTextSharp.text.Image imageLogo = iTextSharp.text.Image.GetInstance(HttpContext.Current.Request.MapPath(LogoPath));
            imageLogo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
            imageLogo.ScalePercent(50);
            PdfPCell cellLogo = new PdfPCell(imageLogo);
            cellLogo.Border = iTextSharp.text.Rectangle.NO_BORDER;
            //cellLogo.CellEvent = 150;
            cellLogo.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cellLogo.VerticalAlignment = PdfPCell.ALIGN_CENTER;
            cellLogo.Padding = 2;
            table.AddCell(cellLogo);

            PdfPCell cellShata = new PdfPCell(new Phrase(10, "چند ثانیه", fntWriteLarge));
            cellShata.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cellShata.Padding = 2;
            cellShata.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.AddCell(cellShata);

            PdfPCell cellLine = new PdfPCell();
            Chunk linebreak = new Chunk(new LineSeparator(1f, 100f, BaseColor.GRAY, Element.ALIGN_CENTER, -1));
            cellLine.AddElement(linebreak);
            cellLine.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cellLine.Padding = 0;
            cellLine.Colspan = 2;
            table.AddCell(cellLine);

            PdfPCell cellTitle = new PdfPCell(new Phrase(10, Title, fntWriteBold));
            cellTitle.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cellTitle.Padding = 2;
            cellTitle.Colspan = 2;
            cellTitle.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.AddCell(cellTitle);

            PdfPCell cellBody = new PdfPCell(new Phrase(0, NewsBody, fntWrite));
            cellBody.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cellBody.Padding = 2;
            cellBody.Colspan = 2;
            cellBody.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.AddCell(cellBody);

            table.AddCell(cellLine);

            PdfPCell cellNewsNo = new PdfPCell(new Phrase(10, "کد خبر: " + NewsNo, fntWrite));
            cellNewsNo.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cellNewsNo.Padding = 2;
            cellNewsNo.Colspan = 2;
            cellNewsNo.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.AddCell(cellNewsNo);

            DateTimeMethods dtm = new DateTimeMethods();

            PdfPCell cellNewsDate = new PdfPCell(new Phrase(10, dtm.GetPersianDate(NewsDate) + "تاریخ خبر: " , fntWrite));
            cellNewsDate.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cellNewsDate.Padding = 2;
            cellNewsDate.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            cellNewsDate.Colspan = 2;
            table.AddCell(cellNewsDate);

            //PdfPCell cellNewsDateVal = new PdfPCell(new Phrase(10, dtm.GetPersianDate(NewsDate), fntWrite));
            //cellNewsDateVal.Border = iTextSharp.text.Rectangle.NO_BORDER;
            //cellNewsDateVal.Padding = 2;
            //cellNewsDateVal.HorizontalAlignment = Element.ALIGN_RIGHT;
            //cellNewsDateVal.RunDirection = PdfWriter.RUN_DIRECTION_LTR;
            //table.AddCell(cellNewsDateVal);



            pdfDocCreatePDF.Add(table);
            pdfDocCreatePDF.Close();
        }
    }

    //public class TwoColumnHeaderFooter : PdfPageEventHelper
    //{
    //    // This is the contentbyte object of the writer
    //    PdfContentByte cb;

    //    // we will put the final number of pages in a template
    //    PdfTemplate template;

    //    // this is the BaseFont we are going to use for the header / footer
    //    BaseFont bf = null;

    //    // This keeps track of the creation time
    //    DateTime PrintTime = DateTime.Now;

    //    #region Properties
    //    private string _Title;
    //    public string Title
    //    {
    //        get { return _Title; }
    //        set { _Title = value; }
    //    }

    //    private string _HeaderLeft;
    //    public string HeaderLeft
    //    {
    //        get { return _HeaderLeft; }
    //        set { _HeaderLeft = value; }
    //    }

    //    private string _HeaderRight;
    //    public string HeaderRight
    //    {
    //        get { return _HeaderRight; }
    //        set { _HeaderRight = value; }
    //    }

    //    private Font _HeaderFont;
    //    public Font HeaderFont
    //    {
    //        get { return _HeaderFont; }
    //        set { _HeaderFont = value; }
    //    }

    //    private Font _FooterFont;
    //    public Font FooterFont
    //    {
    //        get { return _FooterFont; }
    //        set { _FooterFont = value; }
    //    }
    //    #endregion

    //    // we override the onOpenDocument method
    //    public override void OnOpenDocument(PdfWriter writer, Document document)
    //    {
    //        try
    //        {
    //            PrintTime = DateTime.Now;
    //            bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
    //            cb = writer.DirectContent;
    //            template = cb.CreateTemplate(50, 50);
    //        }
    //        catch (DocumentException de)
    //        {
    //        }
    //        catch (System.IO.IOException ioe)
    //        {
    //        }
    //    }

    //    public override void OnStartPage(PdfWriter writer, Document document)
    //    {
    //        base.OnStartPage(writer, document);

    //        Rectangle pageSize = document.PageSize;

    //        if (Title != string.Empty)
    //        {
    //            cb.BeginText();
    //            cb.SetFontAndSize(bf, 15);
    //            cb.SetRGBColorFill(50, 50, 200);
    //            cb.SetTextMatrix(pageSize.GetLeft(40), pageSize.GetTop(40));
    //            cb.ShowText(Title);
    //            cb.EndText();
    //        }

    //        if (HeaderLeft + HeaderRight != string.Empty)
    //        {
    //            PdfPTable HeaderTable = new PdfPTable(2);
    //            HeaderTable.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
    //            HeaderTable.TotalWidth = pageSize.Width - 80;
    //            HeaderTable.SetWidthPercentage(new float[] { 45, 45 }, pageSize);

    //            PdfPCell HeaderLeftCell = new PdfPCell(new Phrase(8, HeaderLeft, HeaderFont));
    //            HeaderLeftCell.Padding = 5;
    //            HeaderLeftCell.PaddingBottom = 8;
    //            HeaderLeftCell.BorderWidthRight = 0;
    //            HeaderTable.AddCell(HeaderLeftCell);

    //            PdfPCell HeaderRightCell = new PdfPCell(new Phrase(8, HeaderRight, HeaderFont));
    //            HeaderRightCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
    //            HeaderRightCell.Padding = 5;
    //            HeaderRightCell.PaddingBottom = 8;
    //            HeaderRightCell.BorderWidthLeft = 0;
    //            HeaderTable.AddCell(HeaderRightCell);

    //            cb.SetRGBColorFill(0, 0, 0);
    //            HeaderTable.WriteSelectedRows(0, -1, pageSize.GetLeft(40), pageSize.GetTop(50), cb);
    //        }
    //    }

    //    public override void OnEndPage(PdfWriter writer, Document document)
    //    {
    //        base.OnEndPage(writer, document);

    //        int pageN = writer.PageNumber;
    //        String text = "Page " + pageN + " of ";
    //        float len = bf.GetWidthPoint(text, 8);

    //        Rectangle pageSize = document.PageSize;

    //        cb.SetRGBColorFill(100, 100, 100);

    //        cb.BeginText();
    //        cb.SetFontAndSize(bf, 8);
    //        cb.SetTextMatrix(pageSize.GetLeft(40), pageSize.GetBottom(30));
    //        cb.ShowText(text);
    //        cb.EndText();

    //        cb.AddTemplate(template, pageSize.GetLeft(40) + len, pageSize.GetBottom(30));

    //        cb.BeginText();
    //        cb.SetFontAndSize(bf, 8);
    //        cb.ShowTextAligned(PdfContentByte.ALIGN_RIGHT,
    //            "Printed On " + PrintTime.ToString(),
    //            pageSize.GetRight(40),
    //            pageSize.GetBottom(30), 0);
    //        cb.EndText();
    //    }

    //    public override void OnCloseDocument(PdfWriter writer, Document document)
    //    {
    //        base.OnCloseDocument(writer, document);

    //        template.BeginText();
    //        template.SetFontAndSize(bf, 8);
    //        template.SetTextMatrix(0, 0);
    //        template.ShowText("" + (writer.PageNumber - 1));
    //        template.EndText();
    //    }

    //}
}