﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }



        public int Add()
        {

            //adds a new record the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@Employed", mThisStaff.Employed);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");


        }

        public void Update()

        {
            //adds a new record the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffID);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Salary", mThisStaff.Salary);
            DB.AddParameter("@Employed", mThisStaff.Employed);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByFirstName(string FirstName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", FirstName);
            DB.Execute("sproc_tblstaff_FilterByFirstName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount = 0;
            //get the count of the records
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            //while there are records to process 
            while (Index < RecordCount)
            {
                //create a blank address 
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record

                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStaff.Employed = Convert.ToBoolean(DB.DataTable.Rows[Index]["Employed"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.Salary = Convert.ToInt32(DB.DataTable.Rows[Index]["Salary"]);

                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }
        }
    }
}