using NPOI.XWPF.UserModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGenDocWord
{
    public partial class FrmPrincTestDocWord : Form
    {
        public FrmPrincTestDocWord()
        {
            InitializeComponent();
        }

        private void ButDo_Click(object sender, EventArgs e)
        {
            SaveFileDialog svFileDlg = new SaveFileDialog();
            svFileDlg.InitialDirectory = ConfigurationManager.AppSettings["defPath"];
            svFileDlg.FileName = ConfigurationManager.AppSettings["defFanme"];
            svFileDlg.Title = "Save text Files";
            svFileDlg.CheckFileExists = false;
            svFileDlg.CheckPathExists = true;
            svFileDlg.DefaultExt = "docx";
            svFileDlg.Filter = "Text files (*.docx)|*.docx|All files (*.*)|*.*";
            svFileDlg.FilterIndex = 2;
            svFileDlg.RestoreDirectory = true;
            if (svFileDlg.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(svFileDlg.FileName);
                SaveWordDoc(svFileDlg.FileName);
            }
        }

        private static void SaveWordDoc(string pFfName)
        {
            try
            {
                XWPFDocument doc = new XWPFDocument();
                XWPFParagraph para = doc.CreateParagraph();
                XWPFRun r0 = para.CreateRun();
                r0.SetText("FileFormat");
                para.FillBackgroundColor = "EEEEEE";
                para.FillPattern = NPOI.OpenXmlFormats.Wordprocessing.ST_Shd.diagStripe;

                XWPFTable table = doc.CreateTable(3, 3);

                table.GetRow(1).GetCell(1).SetText("File Format Developer Guide");

                XWPFTableCell c1 = table.GetRow(0).GetCell(0);
                XWPFParagraph p1 = c1.AddParagraph();
                XWPFRun r1 = p1.CreateRun();
                r1.SetText("NPOI - DOCX");
                r1.IsBold = true;

                r1.FontFamily = "Courier";
                r1.SetUnderline(UnderlinePatterns.DotDotDash);
                r1.SetTextPosition(100);
                c1.SetColor("FF0000");

                table.GetRow(2).GetCell(2).SetText("only text");

                FileStream out1 = new FileStream(pFfName, FileMode.Create);
                doc.Write(out1);
                out1.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private static Hashtable CreateLexemes()
        {
            Hashtable res = null;
            try
            {
                res = new Hashtable() {
                    {"${fecha}", "" },
                    {"${name}", "" },
                    {"${total}", "" }
                };
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }


        private static void CreateDocWordSubstitution(string pTempWordDoc)
        {
            try
            {
                Hashtable lexemes = CreateLexemes();
                lexemes["${fecha}"] = DateTime.Now.ToString("dd/MM/yyyy");
                lexemes["${name}"] = "Juan Perez";
                string montoStr = String.Format("{0:0.00;minus 0.00;zero}", 123.4567);
                lexemes["${total}"] = montoStr;
                string outputPath = Path.GetDirectoryName(pTempWordDoc);
                string parrafo = string.Empty;
                using (FileStream stream = File.OpenRead(pTempWordDoc))
                {
                    XWPFDocument doc = new XWPFDocument(stream);
                    foreach (XWPFParagraph paragraph in doc.Paragraphs)
                    {

                        string textParrafo = paragraph.Text;
                        if (textParrafo.Length > 0)
                        {
                            while (textParrafo.IndexOf("${fecha}", 0) >= 0)
                            {
                                string lex = (string)lexemes["${fecha}"];
                                paragraph.ReplaceText("${fecha}", lex);
                                textParrafo = paragraph.Text;
                            }
                        }

                        /*
                        foreach (XWPFRun run in paragraph.Runs)
                        {
                            parrafo = run.GetText(0);
                            parrafo = parrafo.Replace("${fecha}", lexemes["${fecha}"]);
                            parrafo = parrafo.Replace("${name}", "John");
                            string montoStr = String.Format("{0:0.00;minus 0.00;zero}", 123.4567);
                            parrafo = parrafo.Replace("${total}", montoStr);
                            run.SetText(parrafo);
                        }
                        */
                    }
                    string ffname = Path.Combine(outputPath, "output.docx");
                    FileStream newFile = new FileStream(ffname, FileMode.Create);
                    doc.Write(newFile);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void genFromTemplateBut_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDlg = new OpenFileDialog();
                openFileDlg.Title = "Load Ms Word Files";
                openFileDlg.CheckFileExists = false;
                openFileDlg.CheckPathExists = true;
                openFileDlg.DefaultExt = "docx";
                openFileDlg.Filter = "Text files (*.docx)|*.docx|All files (*.*)|*.*";
                openFileDlg.FilterIndex = 2;
                openFileDlg.RestoreDirectory = true;
                if (openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine(openFileDlg.FileName);
                    CreateDocWordSubstitution(openFileDlg.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
