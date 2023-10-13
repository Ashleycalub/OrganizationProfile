using System.Text.RegularExpressions;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {

        private string _FullName = " ";
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;


        public frmRegistration()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            StudentInformationClass studInfo = new StudentInformationClass();
            studInfo.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            studInfo.SetStudentNo = StudentNumber (txtStudentNo.Text);
            studInfo.SetProgram = cbProgram.Text;
            studInfo.SetGender = cbGender.Text; 
            studInfo.SetContactNo = ContactNo(txtContactNo.Text);
           
            
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information System",
                "BS in Accoutancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }
        }

        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }
    }
}