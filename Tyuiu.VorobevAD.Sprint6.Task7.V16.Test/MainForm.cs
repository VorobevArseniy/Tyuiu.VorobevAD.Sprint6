using Tyuiu.VorobevAD.Sprint6.Task0.V6.Lib;

namespace Tyuiu.VorobevAD.Sprint6.Task0.V6
{
    public partial class MainForm : Form
    {

        private int x = 0;
        private double answ = 0;
        private DataService service = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(goida_box.Text);
            answ = service.Calculate(x);
            goida_box2.Text = Convert.ToString(answ);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
