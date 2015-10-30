using ConfigStorage;
using Logger;
using Pingdom.ObjectModel;
using Pingdom.TechinalServices;
using Pingdom.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Pingdom.BussinessLogic
{
    public class Checker<T> where T : new()
    {
        private Credentials m_Credentials = AppConfigParser.Create<Credentials>();
        private WebServices m_WebServices;
        public Results UploadResults { get; set; }
        public List<T> Checks { get; set; }
        public Checker(WebServices i_WebService)
        {
            Checks = new List<T>();
            UploadResults = new Results();
            m_WebServices = i_WebService;

        }
        public void ImportExcel()
        {

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Excel Sheet(*.csv)|*.csv|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    convertExcelFileToList(fdlg.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Wrong excel template , exception: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                LogManager.Instance.WriteInfo("Couldnt get any excel file from user");
                throw new Exception("Please choose excel file!");

            }

        }
        public void Upload()
        {
            ImportExcel();
            int success = 0;
            int fails = 0;
            WaitForm waitform = new WaitForm();
            waitform.Show();
            int i = 0;
            foreach (T item in Checks)
            {
                try
                {
                    i++;
                    waitform.SetProgressBarMax(Checks.Count);
                    waitform.PerformStep();
                    waitform.Refresh();
                    m_WebServices.HTTPPostRequest(WebServicesHelper.BuildPostString(item)+ "&type="+this.GetType().Name);
                    Thread.Sleep(1000 * 1);
                    success++;
                }
                catch (Exception ex)
                {
                    fails++;
                    LogManager.Instance.WriteError("Error while trying to update repository:");
                    LogManager.Instance.WriteError("      Name: " + (item as Check).display_name);
                    LogManager.Instance.WriteError("      Type: " + (item as Check).type);
                    LogManager.Instance.WriteError("      Error: " + ex.Message + "");
                    LogManager.Instance.WriteError("      Data: " + WebServicesHelper.BuildPostString(item)  + "&use_legacy_notifications=false");
                    LogManager.Instance.WriteError("");
                }
            }
            waitform.Close();
            UploadResults.Success = success;
            UploadResults.Fails = fails;
        }
        private void convertExcelFileToList(string i_Path)
        {

            List<T> items = new List<T>();
            string[] excelAllLines = File.ReadAllLines(i_Path);
            string[] columnsNames = excelAllLines[0].Split(',');
            for (int i = 0; i < columnsNames.Length; i++)
            {
                string temp = string.Empty;
                string columnN = columnsNames[i];

                if (columnN.Contains("(Required)"))
                {
                    columnsNames[i] = columnN.Remove(columnN.IndexOf("(Required)"), 10); 
                }

            }
            string[] splitedRow;
            int columnNamesCounter = 0;
            for (int i = 1; i < excelAllLines.Length; i++)
            {
                splitedRow = excelAllLines[i].Split(',');
                T item = new T();
                for (int j = 0; j < splitedRow.Length; j++)
                {
                    ObjectHelper.InsertValueIntoObjectProp(item, columnsNames[columnNamesCounter], splitedRow[j]);
                    columnNamesCounter++;
                }
                columnNamesCounter = 0;
                items.Add(item);

            }
            Checks = items;
        }
        public class Results
        {
            public int Fails { get; set; }
            public int Success { get; set; }
        }
    }
}
