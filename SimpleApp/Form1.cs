namespace SimpleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Last Name";
            label2.Text = "Full Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello {textBox1.Text} {textBox2.Text}");
            //textBox2 .Text = $"{textBox1.Text} {textBox2.Text}";
            //progressBar1.Value += 10;

            Form1 frmn= new Form1();
            frmn.Show();
        }
    }
} 