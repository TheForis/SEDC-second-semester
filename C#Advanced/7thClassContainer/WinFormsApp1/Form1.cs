namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox1.Text, out int num1)){
                label4.Show();
                return;
            }
            if (!int.TryParse(textBox2.Text, out int num2))
            {
                label4.ForeColor = Color.Green;
                label4.Text = "GOOD INPUT!";
                label5.Show();
                return;
            }
            
            label5.ForeColor = Color.Green;
            label5.Text = "GOOD INPUT!";
            int result = num1 + num2;
            textBox3.Text = result.ToString();
            
        }
    }
}
