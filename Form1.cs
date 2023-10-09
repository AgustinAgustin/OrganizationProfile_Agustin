using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace OrganizationProfile_Agustin
{
    public partial class Form1 : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public Form1()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            StudentInformationClass.SetFullname = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNum = StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cbProgram.Text;
            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNum = ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = Age(txtAge.Text);
            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy - MM - dd");

            FrmConfirmation confirmation = new FrmConfirmation();
            confirmation.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
             "BS Information Technology",
             "BS Computer Science",
             "BS Information Systems",
             "BS in Accountancy",
             "BS in Hospitality Management",
             "BS in Tourism Management"
             };
            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }

            string[] Genders = new string[]
            {
                "Male",
                "Female"
            };
            for (int y = 0; y < 2; y++)
            {
                cbGender.Items.Add(Genders[y].ToString());
            }
        }
    }
}