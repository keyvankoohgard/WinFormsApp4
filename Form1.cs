namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(box.Text);
            double hajm = Math.PI * (Math.Pow(c,3)) * 4 / 3;
            double area = Math.PI *Math.Pow(c,2) * 4;

            if (c < 0)
            {
                MessageBox.Show("please don't enter wrong number");
            }
            else if (box.Text == "")
            {
                MessageBox.Show("please enter a number");
            }
            else
            {
                MessageBox.Show(hajm.ToString() + " " + area.ToString() + " ");
            }
        }   
    }
}