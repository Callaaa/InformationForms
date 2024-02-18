using System.Windows.Forms.VisualStyles;

namespace ZadachaOtMessageBoxPrezentaciq
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }       
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string name = txtBname.Text;
            string lastName = txtBnameL.Text;
            string salary = txtBSalary.Text;
            string gender;

            if (chBox.Checked)
            {
                gender = chBox.Text;
            }
            else
            {
                gender = "Woman";
            }

            bool isAllEntered = true;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is not entered","Attention");
                isAllEntered = false;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last name is not entered", "Attention");
                isAllEntered = false;

            }
            if (string.IsNullOrEmpty(salary))
            {
                MessageBox.Show("Salary is not entered", "Attention");
                isAllEntered = false;

            }
            if (cmb.SelectedItem == null)
            {
                MessageBox.Show("Job is not entered", "Attention");
                isAllEntered = false;

            }
            if (isAllEntered == true)
            {
                DialogResult result = MessageBox.Show
                    ("Потвърждаваш ли въвеждането?",
                    "Въвеждане", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DialogResult result2 = MessageBox.Show("", "Информация"
                        , MessageBoxButtons.OK);
                    if (result2 == DialogResult.OK)
                    {
                        MessageBox.Show($"Name: {name} {lastName}" +
                    $"\nGender: {gender}" +
                    $"\nSalary: {salary} lv" +
                    $"\nPosition: {cmb.Text}","Information");

                    }
                }
                else
                {
                    MessageBox.Show("Данните изчезват!!!",
                        "ЗАГУБА на данни"
                        , MessageBoxButtons.OK);
                    cmb.SelectedItem = null;
                    txtBname.Clear();
                    txtBnameL.Clear();
                    txtBSalary.Clear();
                    chBox.Checked = false;
                }
            }
        }
    }
}
