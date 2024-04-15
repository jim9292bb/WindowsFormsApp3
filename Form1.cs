using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public enum OPERATOR
    {
        PLUS,
        MINUS,
        MULT,
        DIVIDE,
        NULL
    }

    public partial class Form1 : Form
    {
        private Operator operator_factor(OPERATOR oper)
        {
            switch (oper) {
                case OPERATOR.PLUS:
                    return new Plus();
                case OPERATOR.MINUS:
                    return new Minus();
                case OPERATOR.MULT:
                    return new Mult();
                case OPERATOR.DIVIDE:
                    return new Divide();
                default:
                    return new Null();
            }
        }
        double firstNumber, secondNumber;
        OPERATOR operator_kind = OPERATOR.NULL;
        private void add_digit(string digit)
        {
            if (txtNumber.Text == "0")
            {
                txtNumber.Text = "";
            }
            txtNumber.Text += digit;
        }

        private void select_operator(OPERATOR _operator)
        {
            firstNumber = Convert.ToDouble(txtNumber.Text);
            txtNumber.Text = "0";
            operator_kind = _operator;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            add_digit("0");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            add_digit("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            add_digit("2");      
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            add_digit("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            add_digit("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            add_digit("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            add_digit("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            add_digit("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            add_digit("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            add_digit("9");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            select_operator(OPERATOR.DIVIDE);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            select_operator(OPERATOR.MULT);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            select_operator(OPERATOR.MINUS);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            select_operator(OPERATOR.PLUS);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operator_kind = OPERATOR.NULL;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.IndexOf(".") == -1)
            {
                txtNumber.Text = txtNumber.Text + ".";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double results = 0f;
            secondNumber = Convert.ToDouble(txtNumber.Text);
            Operator oper = operator_factor(operator_kind);
            txtNumber.Text = string.Format("{0:0.##########}", oper.eval(this.firstNumber, this.secondNumber));
            this.firstNumber = 0.0f;
            this.secondNumber = 0.0f;
            this.operator_kind = OPERATOR.NULL;
        }
    }
}
