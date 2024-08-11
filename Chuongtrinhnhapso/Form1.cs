using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuongtrinhnhapso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ktra snt
        bool isPrime (int n)
        {
            if(n<=1) return false;
            if(n==2) return true;
            if(n%2==0) return false;
            for(int i =3; i<= Math.Sqrt(n); i += 2)
            {
                if(n%i==0) return false;    
            }
            return true;
        }
        bool isPerfect(int num)
        {
            double sqrt_num = Math.Sqrt(num);
            return(sqrt_num*sqrt_num==num);
        }
        bool isPerfectNumber(int num)
        {
            if (num < 2) return false;
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    if (i == num / i)
                        sum += i;
                    else
                        sum += i + num / i;
                }
            }
            return (sum == num);
        }
            private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            string kq = "";
            string kq1 = "";
            string kq2 = "";
            for(int i=2; i<n; i++ )
            {
                if (isPrime(i))
                {
                    kq += i + " ";
                }
            }
            label5.Text = kq.Trim();
            for (int i = 1; i < n; i++)
            {
                if (isPerfect(i))
                {
                    {
                        kq1 += i + " ";
                    }
                }
            }
            label6.Text = kq1.Trim();
            for (int i = 1; i < n; i++)
            {
                if (isPerfectNumber(i))
                {
                    kq2 += i + " ";
                }
            }
            label7.Text = kq2.Trim();
        }
    }
}
