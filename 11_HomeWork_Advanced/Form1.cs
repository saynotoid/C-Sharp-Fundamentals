namespace _11_HomeWork_Advanced
{
    public partial class Form1 : Form
    {
        public delegate double CalcFigure(double r);
        public Form1()
        {
            InitializeComponent();
        }

        public static double GetLength(double r)
        {
            return 2 * 3.1415 * r;
        }

        public static double GetArea(double r)
        {
            return 3.1415 * r * r;
        }

        public static double GetVolume(double r)
        {
            return 4.0 / 3 * 3.1415 * r;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBoxRadius.Text);
            CalcFigure CF = GetLength;
            labelLength.Text += string.Format($" = {CF(r):f2}");
            CF = GetArea;
            labelArea.Text += string.Format($" = {CF(r):f2}");
            CF = GetVolume;
            labelVolume.Text += string.Format($" = {CF(r):f2}");
        }
    }
}
