using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication35
{
    public class Person
    {
        // Fields...
        private int _ID;
        private string _LastName;
        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public override string ToString()
        {
            return String.Format("{0} {1} ID № {2}", FirstName, LastName, ID);
        }
    }
}
