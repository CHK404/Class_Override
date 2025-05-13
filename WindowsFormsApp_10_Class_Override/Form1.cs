using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_10_Class_Override
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Console.WriteLine("=====오버로드 예시=====");
            Beverage basic = new Beverage();
            basic.Order();
            basic.Order("Cold Brew");
            basic.Order("Cold Brew", "Tall");
        }
    }
}
