namespace Assignment1_in_OOP
{
    public partial class Form1 : Form
    {
        public double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public double AreaOfTriangle(double baseLength, double height, bool Tri)
        {
            if (Tri)
                return 0.5 * baseLength * height;
            else
            {
                return baseLength * height;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(textBox1.Text);
            double width = Convert.ToDouble(textBox2.Text);
            double area = AreaOfRectangle(length, width);

            listBox1.Items.Add($"Rectangle Area: {area}");
            textBox6.Text = area.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(textBox3.Text);
            double area = AreaOfCircle(radius);

            listBox1.Items.Add($"Circle Area: {area}");
            textBox6.Text = area.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            double baselegnth = Convert.ToDouble(textBox4.Text);
            double height = Convert.ToDouble(textBox5.Text);
            double area = AreaOfTriangle(baselegnth, height, true);

            listBox1.Items.Add($"Triangle Area: {area}");
            textBox6.Text = area.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
