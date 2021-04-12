using NPOI.XWPF.UserModel;
using System;
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

        private static CreateTableWord (string pFfName)
        {

        }

    }
}
