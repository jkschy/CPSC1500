using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofConceptFinalProj
{
    public class SubClsTxtFileIO: ClsTxtFileIO
    {
        public void PopulateEmployees(ClsEmployee[] empArray)
        {
            /*
             * Programmer: Chuck Koontz
             * Date Last Modified: 4/22/2020
             * 
             * Overview:
             * This method reads space delimited data from a text file and "splits" the fields of each record
             * so that the fields can be assigned as property values for objects in the array parameter.
             * 
             * A "while" loop is set up to read until end of file condition (null value is read) and assumes the file will
             * not contain more than 200 records
            */

            int i = 0;
            string inRec;
            string[] empRec;

            this.OpenForRead();//calls method in base class

            inRec = this.ReadRecord();//calls method in base class to do initial read outside loop
            while (inRec != null)
            {
                //splits string (in the input variable) using space delimeter and stores 
                //each field as an element in the un-dimensioned array (see online documentation concerning "Split")

                empRec = inRec.Split(' ');

                //assign each non string component to a separate property in the array of objects
                empArray[i].EmployeeFName = (empRec[0]);
                empArray[i].EmployeeLName = (empRec[1]);
                empArray[i].Department = (empRec[2]);
                empArray[i].PhoneNumber = (empRec[3]);
                empArray[i].AnnualSalary = (empRec[4]);
                empArray[i].VacationDaysEarned = (empRec[5]);
                i++;
                inRec = this.ReadRecord(); //calls method in base class to read second and all subsequent records
            }

            this.CloseForRead(); //calls method in base class
        }

    }
}
