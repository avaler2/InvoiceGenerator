using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace FolderBrowser
{
    public partial class Form1 : Form
    {
        //public string folderPath = @"D:\Dropbox (Osobiste)\Rozliczenia projektu\Test oprogramowania";
        //public string folderPath = @"D:\Test oprogramowania\";
        //public string folderPath = @"C:\Dropbox (FREE)\!FREE\3.2 KdP (1 edycja)\Faktury\Faktury z opisami wg sprawozdañ\2 sprawozdanie";
        public string folderPath = @"C:\Dropbox (FREE)\!FREE\!Kontrola";


        public Form1()
        {
            InitializeComponent();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://www.free.org.pl");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstPliki.Items.Clear();

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.SelectedPath = folderPath;
      

            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
                folderPath = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

            displayFiles();
            lstPliki.Items.Add("Krok 1. Znaleziono pliki do przetworzenia...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numofPages = 0;
            //utwórz folder Opisy
            lstPliki.Items.Add("Rozpoczêto tworzenie opisów faktur. Proszê czekaæ....");

            if (!Directory.Exists(folderPath + "\\Opisy"))
            {
                Directory.CreateDirectory(folderPath + "\\Opisy");
            }

            //Display PDF files in the root folder - Opis.pdf
            FileInfo[] Files = getFiles("");
            foreach (FileInfo file in Files)
            {
                numofPages = InitPdf(file.FullName, "Opisy");
            }

            MessageBox.Show("Utworzono " + numofPages + " odrêbnych opisów faktur!", "Generacja opisów");
            lstPliki.Items.Add("Krok 2. Utworzono " + numofPages + " odrêbnych opisów faktur....");
        }

        private int InitPdf(string inputPDFpath, string outputFolder = "")
        {
            string pdfFilePath = inputPDFpath;
            string outputPath = folderPath + "\\" + outputFolder;
            int interval = 1;
            int pageNameSuffix = 0;

            // Intialize a new PdfReader instance with the contents of the source Pdf file:  
            PdfReader reader = new PdfReader(pdfFilePath);

            FileInfo file = new FileInfo(pdfFilePath);
            string pdfFileName = " - " + file.Name.Substring(0, file.Name.LastIndexOf("."));

            for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber += interval)
            {
                pageNameSuffix++;
                string newPdfFileName = string.Format("{0}" + pdfFileName, pageNameSuffix);
                SplitAndSaveInterval(pdfFilePath, outputPath, pageNumber, interval, newPdfFileName);
            }
            return reader.NumberOfPages;
        }

        private void SplitAndSaveInterval(string pdfFilePath, string outputPath, int startPage, int interval, string pdfFileName)
        {
            using (PdfReader reader = new PdfReader(pdfFilePath))
            {
                Document document = new Document();
                PdfCopy copy = new PdfCopy(document, new FileStream(outputPath + "\\" + pdfFileName + ".pdf", FileMode.Create));
                document.Open();

                for (int pagenumber = startPage; pagenumber < (startPage + interval); pagenumber++)
                {
                    if (reader.NumberOfPages >= pagenumber)
                    {
                        copy.AddPage(copy.GetImportedPage(reader, pagenumber));
                    }
                    else
                    {
                        break;
                    }

                }

                document.Close();
            }
        }

        internal void createDirectory(string folderPath, string catalogueName)
        {
            if (!Directory.Exists(folderPath + "\\" + catalogueName))
            {
                Directory.CreateDirectory(folderPath + "\\" + catalogueName);
            }
        }

        internal void displayFiles()
        {
            //Display PDF files

            FileInfo[] Files = getFiles("");
            foreach (FileInfo file in Files)
            {
                lstPliki.Items.Add(file.Name);
            }
        }

        private FileInfo[] getFiles(string Catalogue)
        {
            DirectoryInfo dinfo = new DirectoryInfo(textBox1.Text + "\\" + Catalogue);
            FileInfo[] Files = dinfo.GetFiles("*.pdf");
            return Files;
        }

        private int extractNumber(FileInfo file)
        {
            int invoiceNumber;
            //Pobierz nr pliku z ka¿dej faktury
            string pdfFileNumber = file.Name.Substring(0, file.Name.IndexOf(" "));

            if (Int32.TryParse(pdfFileNumber, out invoiceNumber))
                Console.WriteLine(invoiceNumber);
            else
                MessageBox.Show("Nazwa pliku nie zosta³a poprawnie nadana i przekonwertowana!");

            return invoiceNumber;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo[] Faktury = getFiles("Faktury");
            FileInfo[] OpisyFaktur = getFiles("Opisy");
            createDirectory(folderPath, "Faktury z opisami");
            string destDirectory = folderPath + "//Faktury z opisami";
      //      MessageBox.Show("Mamy: " + Faktury.Length + " faktur do po³¹czenia z " + OpisyFaktur.Length + " opisami.");
           lstPliki.Items.Add("Rozpoczêto przetwarzanie: " + Faktury.Length + " faktur do po³¹czenia z " + OpisyFaktur.Length + " opisami.");

            foreach (FileInfo faktura in Faktury)
            {
                int invoiceNumber = extractNumber(faktura);

                foreach (FileInfo opis in OpisyFaktur)
                {
                    int opisNumber = extractNumber(opis);
                    if (invoiceNumber == opisNumber)
                    {
                        mergePdfs(faktura.FullName, opis.FullName, destDirectory, invoiceNumber.ToString());
                    }
  
                }
                
            }
            MessageBox.Show("Zakoñczono ³¹czenie faktur z plikami opisów");
            lstPliki.Items.Add("Krok 3. Ukoñczono ³¹czenie plików opisów z fakturami...");
        }



        internal static void mergePdfs(string pdf1, string pdf2, string destinatonFolder, string invoiceNumber)
        {
            string newFile = destinatonFolder + "//faktura " + invoiceNumber + " - z opisem.pdf";
            using (FileStream outStream = new FileStream(newFile, FileMode.Create))
            using (Document document = new Document())
            using (PdfCopy copy = new PdfCopy(document, outStream))
            {
                document.Open();
                copy.AddDocument(new PdfReader(pdf1));
                copy.AddDocument(new PdfReader(pdf2));
                if (document != null)
                {
                    document.Close();
                }
            }
        }

        static void CreateMergedPDF(string targetPDF, string sourceDir)
        {
            using (FileStream stream = new FileStream(targetPDF, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4);
                PdfCopy pdf = new PdfCopy(pdfDoc, stream);
                pdfDoc.Open();
                var files = Directory.GetFiles(sourceDir);
                Console.WriteLine("Merging files count: " + files.Length);
                int i = 1;
                foreach (string file in files)
                {
                    Console.WriteLine(i + ". Adding: " + file);
                    pdf.AddDocument(new PdfReader(file));
                    i++;
                }

                if (pdfDoc != null)
                    pdfDoc.Close();

                Console.WriteLine("SpeedPASS PDF merge complete.");
            }
        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }

        private void lstPliki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
 }

