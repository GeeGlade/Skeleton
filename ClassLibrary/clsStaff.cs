using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        private Boolean mEmployed;
        public bool Employed
        {
            get
            {
                return mEmployed;
            }
            set
            {
                mEmployed = value;
            }
        }
        private String mFirstName;
        public String FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        private String mLastName;
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        private Int32 mStaffID;
        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        private float mSalary;
        public float Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }

        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StaffId to search for 
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {

                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mEmployed = Convert.ToBoolean(DB.DataTable.Rows[0]["Employed"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["Salary"]);

                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string FirstName, string LastName, string DateAdded, string Salary)
        {



            //create a string varuable to store the error 

            String Error = "";

            DateTime DateTemp;
             
            Int32 SalaryTemp;

            //if the FirstName is blank

            if (FirstName.Length == 0)

            {

                //record the error 

                Error = Error + "The Last Name may not be blank ";



            }

            if (FirstName.Length > 30)

            {

                //record the error 

                Error = Error + "The Last Name may not be more than 30 characters: ";



            }

            if (LastName.Length == 0)

            {

                //record the error 

                Error = Error + "The Last Name may not be blank ";



            }

            if (LastName.Length > 30)

            {

                //record the error 

                Error = Error + "The Last Name may not be more than 30 characters: ";



            }




            try

            {



                //copy the DOB value to the DateTemp variable 

                SalaryTemp = Convert.ToInt32(Salary);

                if (SalaryTemp < 0)

                {

                    //record the error 

                    Error = Error + "Salary Cannot be Below 0";



                }



            }

            catch

            {



                //record  the error 

                Error = Error + "The salary was not a valid number:";

            }



            try

            {

                DateTemp = Convert.ToDateTime(DateAdded);



                if (DateTemp < DateTime.Now.Date)

                {

                    //record the error 

                    Error = Error + "The date cannot be in the past: ";



                }



                //check to see if the date is greater than today's date

                if (DateTemp > DateTime.Now.Date)

                {

                    //record the error

                    Error = Error + "The date cannot be in the future : ";

                }



            }

            catch

            {



                //record  the error 

                Error = Error + "The date was not a valid date:";

            }



            // returns any error messages 

            return Error;
        }
    }
}