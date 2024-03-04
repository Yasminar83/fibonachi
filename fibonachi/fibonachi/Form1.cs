namespace fibonachi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int x = 0, y = 1, z = 1;
            if (num == 1)
                MessageBox.Show(x.ToString());
            else if (num == 2)
                MessageBox.Show(y.ToString());
            else
            {
                for(int i=3;i<=num;i++)
                {
                    z = x + y;
                    x = y;
                    y = z;
                }
                MessageBox.Show(z.ToString());
            }
        }
    }
}
