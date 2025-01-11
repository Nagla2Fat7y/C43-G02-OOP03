using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Employees
    {
		private int id;
		private string? name;
		private decimal salary;
		private Security security_level;
		private Gender gender;
		private Hiring_Date_Data hiring_Date;


        public Employees(int _id,string _name,decimal _salary, Security _SL, Gender _gender, Hiring_Date_Data _HD)
        {
            id = (_id <= 0) ? 1 : _id;
            name = _name;
            salary = (_salary <= 5000m) ? 5000m : _salary;
            security_level =(_SL != Security.Guest && _SL != Security.Developer &&
                             _SL != Security.Secretary && _SL != Security.DBA) ? Security.Guest : _SL;
            gender = (_gender != Gender.M && _gender != Gender.F) ? Gender.M : _gender;
            hiring_Date = _HD;
        }
        #region Properties
        public int Id
        {
            get { return id; }
            set { id = (value <= 0) ? 1 : value; }
        }
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = (value <= 5000m) ? 5000m : value; }
        }
        public Security Security_level
        {
            get { return security_level; }
            set
            {
                security_level = (value != Security.Guest && value != Security.Developer &&
                                    value != Security.Secretary && value != Security.DBA) ? Security.Guest : value;
            }
        }
        public Gender Gender
        {
            get { return gender; }
            set { gender = (value != Gender.M || value != Gender.F) ? Gender.M : value; }
        }
        public Hiring_Date_Data HiringDate
        {
            get { return hiring_Date; }
            set { hiring_Date = value; }
        }

        #endregion


        //Represent Employee data in a string Form (override ToString ())
        public override string ToString()
        {
            return $"ID: {id} \nName: {name} \nSalary: {salary.ToString("C", CultureInfo.CurrentCulture)} \nSecurity Level: {security_level} \nGender: {gender} \nHiring Date: {hiring_Date}";
        }
    }
}
