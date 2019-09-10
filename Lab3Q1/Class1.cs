using System;
using System.Collections.Generic;


namespace Lab3
{
    public class Participant
    {
        private int _empId;
        private string _name;
        private static string _companyName;
        private int _foundationMarks;
        private int _webBasicsMarks;
        private int _dotnetMarks;
        private int _totalMarks;

        public int EmpId { get => _empId; set => _empId = value; }
        
       
        public static string CompanyName { get => _companyName; set => _companyName = value; }
        public int FoundationMarks
        {
            set
            {
                if ((value <= 100) && (value >= 0))
                {
                    _foundationMarks = value;
                }
                else
                {
                    _foundationMarks = 0;
                }

            }
            get
            {
                return _foundationMarks;

            }
        }
        public int WebBasicsMarks
        {
            set
            {
                if ((value <= 100) && (value >= 0))
                {
                    _webBasicsMarks = value;
                }
                else
                {
                    _webBasicsMarks = 0;
                }

            }
            get
            {
                return _webBasicsMarks;

            }
        }
        public int DotnetMarks
        {
            set
            {
                if ((value <= 100) && (value >= 0))
                {
                    _dotnetMarks = value;
                }
                else
                {
                    _dotnetMarks = 0;
                }

            }
            get
            {
                return _webBasicsMarks;

            }
        }

        // public int WebBasicsMarks { get => _webBasicsMarks; set => _webBasicsMarks = value; }
        //public int DotnetMarks { get => _dotnetMarks; set => _dotnetMarks = value; }
        public int TotalMarks { get => _totalMarks; set => _totalMarks = value; }
        public string Name { get => _name; set => _name = value; }

        public  Participant()
        {
             TotalMarks = 300;
            
        }
        static Participant()
        {
             CompanyName = "Corporate University";
        }

        public int ObtMarks()
        {
            int obtMarks = FoundationMarks + WebBasicsMarks + DotnetMarks;
            return obtMarks;

        }
        public int Percentage()
        {
            int per = ((ObtMarks() / 3));
            return per;
        }
        public Participant(string EmpName, int FoundationMarks, int WebBasicsMarks, int DotnetMarks)
        {
            EmpName = null;
            FoundationMarks = 0;
            WebBasicsMarks = 0;
            DotnetMarks = 0;

        }

    }
}
