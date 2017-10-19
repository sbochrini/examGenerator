using System;
using System.Data;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace ExamKernel
{
    public class ExcelData
    {
        private string fileName;
        public DataView Data;

        public ExcelData(string fileName)
        {
            this.fileName = fileName;
            ProgressDialog dlg2 = new ProgressDialog();
            dlg2.Owner = null;
            for (int index = 0; index < App.Current.Windows.Count; index++)
            {
                if (App.Current.Windows[index].Title == "ΕΥΕ Sampling")
                {
                    dlg2.Owner = App.Current.Windows[index];
                    break;
                }
            }
            dlg2.DialogText = "Εισαγωγή Δεδομένων από αρχείο";
            int startValue = 0;
            dlg2.RunWorkerThread(startValue, GetData);


        }
    }
}