using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex_01
{
    public class Employee
    {
        public int _empId;
        public string _empName, _designation, _dName, _location;
        public double _salary;



        public Employee()
        {

        }

        public Employee(int _empId, string _empName, string _designation, string _dName, string _location, double _salary)
        {
            this._empId = _empId;
            this._empName = _empName;
            this._designation = _designation;
            this._dName = _dName;
            this._location = _location;
            this._salary = _salary;


        }
        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return _empId;
                else if (index == 2)
                    return _empName;
                else if (index == 3)
                    return _designation;
                else if (index == 4)
                    return _dName;
                else if (index == 5)
                    return _location;
                else if (index == 6)
                    return _salary;
                return null;
            }
            set
            {
                if (index == 1)
                    _empId = (int)value;
                else if (index == 2)
                    _empName = value.ToString();
                else if (index == 3)
                    _designation = value.ToString();
                else if (index == 4)
                    _dName = value.ToString();
                else if (index == 5)
                    _location = value.ToString();
                else if (index == 6)
                    _salary = (int)value;
            }
        }
    }
}
