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
            RegistrationForm newForm = new RegistrationForm(); // —оздаем экземпл€р Form2
            newForm.Show(); // ќткрываем Form2
            this.Hide(); // —крываем Form1 (чтобы можно было вернутьс€)
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm newForm = new LoginForm(); // —оздаем экземпл€р Form2 
            newForm.Show(); // ќткрываем Form2
            this.Hide(); // —крываем Form1 (чтобы можно было вернутьс€)
        }
    }
}