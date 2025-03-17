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
        

        private void Continue_Click_1(object sender, EventArgs e) 
        {
            Form2 newForm = new Form2(); // —оздаем экземпл€р Form2
            newForm.Show(); // ќткрываем Form2
            this.Hide(); // —крываем Form1 (чтобы можно было вернутьс€)
        }
    }
}