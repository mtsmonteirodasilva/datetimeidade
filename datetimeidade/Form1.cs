using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetimeidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_resultado.Text = "";
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            DateTime dataN = dtp_nascimento.Value;
            DateTime dataHj = new DateTime(2023, 08, 01);
            TimeSpan dias = dataHj - dataN;
            double idade = dias.Days/365.2425;
            double idade2 = (int)Math.Truncate(idade);
           
            lb_resultado.Text = ($"Sua idade é de: {idade2.ToString()} anos");
            
        }

        private void lb_resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
