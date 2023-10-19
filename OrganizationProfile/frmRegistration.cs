using System.Text.RegularExpressions;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {

        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;


        public frmRegistration()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cbProgram.Text;
            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = Age(txtAge.Text);
            StudentInformationClass.SetBirthDay = datePickerBirthday.Value.ToString("yyyyMM-dd");



            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();


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
            string[] ListOfGender = new string[]
                              {
                "Female", "Male"
            };
            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(ListOfGender[i].ToString());
            }
        }

        public long StudentNumber(string studNum)
        {
            try
            {
                _StudentNo = long.Parse(studNum);
            }
            catch (FormatException)
            {
                MessageBox.Show("The input was invalid!" + "\nTry to enter again your existing student number.");
            }
            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            try
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{11,12}$"))
                {
                    _ContactNo = long.Parse(Contact);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("The input was invalid! " + "\nTry to enter again your existing contact number.");
            }
            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            try
            {
                if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                {
                    _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
                }

                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The input was invalid! " + "\nTry to enter again your valid name. ");
            }
            return _FullName;
        }

        public int Age(string age)
        {
            try
            {
                if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    _Age = Int32.Parse(age);
                }
                else
                {
                    throw new OverflowException();
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("The input was invalid! " + "\nYour input should be 3 digits. \n ");
            }
            return _Age;
        }
    }
}