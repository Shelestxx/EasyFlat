namespace EasyFlat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void btnRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm newForm = new RegistrationForm(); // ������� ��������� Form2
            newForm.Show(); // ��������� Form2
            this.Hide(); // �������� Form1 (����� ����� ���� ���������)
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm(); // ������� ��������� Form2 
            newForm.Show(); // ��������� Form2
            this.Hide(); // �������� Form1 (����� ����� ���� ���������)
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            AdminUserManagementForm userForm = new AdminUserManagementForm();
            userForm.ShowDialog();

        }
    }
}