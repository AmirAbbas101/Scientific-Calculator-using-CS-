namespace Calc
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void calculator_Load(object sender, EventArgs e)
        {
            this.Width = 344; //688 is orignal width.
            txtOutput.Width = 306;
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtOutput.Text == "0")
                txtOutput.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtOutput.Text.Contains("."))
                        txtOutput.Text += num.Text;
                }
                else
                {
                    txtOutput.Text += num.Text;
                }
            }
        }

        private void numberOperators(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstValue = Convert.ToDouble(txtOutput.Text);
            op = num.Text;
            txtOutput.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtOutput.Text);

            switch (op)
            {
                case "+":
                    txtOutput.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;
                case "−":
                    txtOutput.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;

                case "×":
                    txtOutput.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;

                case "÷":
                    txtOutput.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;

                case "mod":
                    txtOutput.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;

                case "exp":
                    double i = Convert.ToDouble(txtOutput.Text);
                    double j = Convert.ToDouble(txtOutput.Text);
                    j = enterSecondValue;
                    txtOutput.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;

                default:

                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            String f, s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);
            f = " ";
            s = " ";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = Convert.ToString(-1 * q);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 0)
            {
                txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.Length - 1, 1);
            }

            if (txtOutput.Text == "")
            {
                txtOutput.Text = "0";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 344; //688 is orignal width.
            txtOutput.Width = 306;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 688; //344 is default width.
            txtOutput.Width = 646;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to exit", "Scientific Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtOutput.Text);
            logg = Math.Log10(logg);
            txtOutput.Text = Convert.ToString(logg);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtOutput.Text);
            sq = Math.Sqrt(sq);
            txtOutput.Text = Convert.ToString(sq);
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtOutput.Text) * Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = Convert.ToString(x);
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            double x;
            x = ((Convert.ToDouble(txtOutput.Text) * Convert.ToDouble(txtOutput.Text)) * Convert.ToDouble(txtOutput.Text));
            txtOutput.Text = Convert.ToString(x);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtOutput.Text);
            sh = Math.Sinh(sh);
            txtOutput.Text = Convert.ToString(sh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(txtOutput.Text);
            s = Math.Sin(s);
            txtOutput.Text = Convert.ToString(s);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double ch = Convert.ToDouble(txtOutput.Text);
            ch = Math.Cosh(ch);
            txtOutput.Text = Convert.ToString(ch);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(txtOutput.Text);
            c = Math.Cos(c);
            txtOutput.Text = Convert.ToString(c);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double th = Convert.ToDouble(txtOutput.Text);
            th = Math.Tanh(th);
            txtOutput.Text = Convert.ToString(th);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(txtOutput.Text);
            t = Math.Tan(t);
            txtOutput.Text = Convert.ToString(t);
        }

        private void btn1X_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtOutput.Text));
            txtOutput.Text = Convert.ToString(a);
        }

        private void btnLnx_Click(object sender, EventArgs e)
        {
            double lx = Convert.ToDouble(txtOutput.Text);
            lx = Math.Log(lx);
            txtOutput.Text = Convert.ToString(lx);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtOutput.Text) / Convert.ToDouble(100);
            txtOutput.Text = Convert.ToString(a);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtOutput.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtOutput.Text = Convert.ToString(i2);

        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtOutput.Text);
            txtOutput.Text = Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtOutput.Text);
            txtOutput.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtOutput.Text);
            txtOutput.Text = Convert.ToString(a, 8);
        }
    }
}