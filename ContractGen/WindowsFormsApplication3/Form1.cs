using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Word;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form

    {
        string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;

        string prop = "";
        string owner = "";
        string propAddress = "";
        string propCity = "";
        string vendor = "";
        string vendorAddress = "";

        public Form1()
        {
            InitializeComponent();
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'newTestDataSet.MasterPropList' table. You can move, or remove it, as needed.
            this.masterPropListTableAdapter.Fill(this.newTestDataSet.MasterPropList);
            // TODO: This line of code loads data into the 'newTestDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.newTestDataSet.Vendors);
            // TODO: This line of code loads data into the 'newTestDataSet.Properties' table. You can move, or remove it, as needed.
            this.propertiesTableAdapter.Fill(this.newTestDataSet.Properties);

        }
        //Find & Replace Start
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findText,
                        ref matchCase, ref matchWholeWord,
                        ref matchWildCards, ref matchSoundLike,
                        ref nmatchAllForms, ref forward,
                        ref wrap, ref format, ref replaceWithText,
                        ref replace, ref matchKashida,
                        ref matchDiactitics, ref matchAlefHamza,
                        ref matchControl);
        }
        //Find & Replace end
        string pathImage = null;
        // Actual searching & creation
        private void CreateWordDocument(object filename, object savaAs, object image)
        {
            List<int> processesbeforegen = getRunningProcesses();
            object missing = Missing.Value;
            string tempPath = null;

            Word.Application wordApp = new Word.Application();

            Word.Document aDoc = null;

            if (File.Exists((string)filename))
            {
                DateTime today = DateTime.Now;

                object readOnly = false; //default
                object isVisible = false;

                wordApp.Visible = false;

                aDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);

                aDoc.Activate();
                
                //Find and replace:
                this.FindAndReplace(wordApp, "$$propName$$", prop);
                
                this.FindAndReplace(wordApp, "$$propAddress$$", propAddress);
                this.FindAndReplace(wordApp, "$$propCity$$", propCity);
                this.FindAndReplace(wordApp, "$$owner$$", owner);
                this.FindAndReplace(wordApp, "$$vendor$$", vendor);
                this.FindAndReplace(wordApp, "$$vendorAddress$$", vendorAddress);
                this.FindAndReplace(wordApp, "$$contractDate$$", textContractDate.Text);
                this.FindAndReplace(wordApp, "$$workBegin$$", textWorkBegin.Text);
                this.FindAndReplace(wordApp, "$$endDate$$", textEndDate.Text);
                this.FindAndReplace(wordApp, "$$summary$$", textSummary.Text);
                this.FindAndReplace(wordApp, "$$Dollars$$", textDollars.Text);
                this.FindAndReplace(wordApp, "$$DollarWords$$", textDollarWords.Text);
                //this.FindAndReplace(wordApp, "$$Date$$", DateTime.Now.ToShortDateString());




                #region Print Document :
                /*object copies = "1";
                object pages = "1";
                object range = Word.WdPrintOutRange.wdPrintCurrentPage;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                object oTrue = true;
                object oFalse = false;

                Word.Document document = aDoc;
                object nullobj = Missing.Value;
                int dialogResult = wordApp.Dialogs[Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrint].Show(ref nullobj);
                wordApp.Visible = false;
                if (dialogResult == 1)
                {
                    document.PrintOut(
                    ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                    ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                    ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
                }
                */
                #endregion

            }
            else
            {
                MessageBox.Show("file dose not exist.");
                return;
            }

            //Save as: filename
            aDoc.SaveAs2(ref savaAs, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

            //Close Document:
            //aDoc.Close(ref missing, ref missing, ref missing);

            // File.Delete(tempPath);
            MessageBox.Show("File created.");
            List<int> processesaftergen = getRunningProcesses();
            killProcesses(processesbeforegen, processesaftergen);
        }

        //Actual searchign & creation END

        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }

        private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView test = comboBox1.SelectedItem as DataRowView;
            
            
            if (test != null)
            {
                prop = test.Row["Property Name"] as string;
                owner = test.Row["Ownership Name"] as string;
                propAddress = test.Row["Street Address"] as string;
                propCity = test.Row["City, St Zip"] as string;

            }
             
        }
        private void tEnabled(bool state)
        {
            /*
            Testing things here
            */
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (LoadDoc.ShowDialog() == DialogResult.OK)
            {
                tFilename.Text = LoadDoc.FileName;
                tEnabled(true);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (SaveDoc.ShowDialog() == DialogResult.OK)
            {
                CreateWordDocument(tFilename.Text, SaveDoc.FileName, pathImage);
                tEnabled(false);
                //printDocument1.DocumentName = SaveDoc.FileName;
            }
        }

        private void comboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView test2 = comboVendor.SelectedItem as DataRowView;


            if (test2 != null)
            {
                vendor = test2.Row["Vendor Name"] as string;
                vendorAddress = test2.Row["Vendor Address"] as string;

            }
        }


    }
}
