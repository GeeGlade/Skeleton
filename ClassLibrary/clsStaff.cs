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
        private String mDOB;
        public string DOB
        {
            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
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

        public bool Find(string firstName)
        {
            mStaffID = 1;
            mFirstName = "Jimmy";
            mLastName = "Smith";
            mDOB = "01/05/2000";
            mSalary = 30000;
            mEmployed = true;
            return true;
        }
    }
}