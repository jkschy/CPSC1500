using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProofConceptFinalProj
{
    public class ClsEmployee
    {

        //member variables:
        private string mEmployeeFName;
        private string mEmployeeLName;
        private string mDepartment;
        private string mPhoneNumber;
        private string mVacationDaysEarned;
        private string mAnnualSalary;
        private bool mDeleteRecord;

        //public properties

        public string EmployeeFName
        {
            get
            {
                return mEmployeeFName;
            }
            set
            {
                mEmployeeFName = value;
            }
        }

        public string EmployeeLName
        {
            get
            {
                return mEmployeeLName;
            }
            set
            {
                mEmployeeLName = value;
            }
        }


        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }


        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        public string VacationDaysEarned
        {
            get
            {
                return mVacationDaysEarned;
            } 
            set
            {
                mVacationDaysEarned = value;
            }
        }

        public string AnnualSalary
        {
            get
            {
                return mAnnualSalary;
            } 
            set
            {
                mAnnualSalary = value;
            }
        }

        public bool DeleteRecord
        {
            get
            {
                return mDeleteRecord;
            }
            set
            {
                mDeleteRecord = value;
            }
        }

        public double CalculateVacationValue()
        {
            double VacVal = (Convert.ToDouble(VacationDaysEarned) * (Convert.ToDouble(AnnualSalary) / 365.0));
            return VacVal;
        }

        //overloaded constructor
        public ClsEmployee(string pFName,string pLName, string pDept, string pPhoneNumber)
        {
            this.mEmployeeFName = pFName;
            this.mEmployeeLName = pLName;
            this.Department = pDept;
            this.PhoneNumber = pPhoneNumber;
        }


        //overloaded constructor
        public ClsEmployee()
        {
            mDeleteRecord = false;
            mAnnualSalary = "0";
            mVacationDaysEarned = "0";
            mEmployeeFName = "";
            mEmployeeLName = "";
            mDepartment = "";
            mPhoneNumber = "";
            
        }
    }


}