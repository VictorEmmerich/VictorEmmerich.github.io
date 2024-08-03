using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form_II
{
    public partial class Form1 : Form
    {
        string lista;
        string nl = System.Environment.NewLine;
        public Form1()
        {
            InitializeComponent();
            rdb_efetivo.Checked = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            lista = txt_nome.Text;
            if(rdb_estagio.Checked)
            {
                lista += ", estagiário";
            }
            else
            {
                lista += ", efetivo";
            }

            lista += ". Experiências: ";
            if (chk_cs.Checked) lista += chk_cs.Text+", "; 
            if (chk_java.Checked) lista += chk_java.Text+", "; 
            if (chk_php.Checked) lista += chk_php.Text+", "; 
            if (chk_sql.Checked) lista += chk_sql.Text+", "; 
            if (chk_ts.Checked) lista += chk_ts.Text+", "; 
            if (chk_python.Checked) lista += chk_python.Text+", "; 

            txt_registro.Text += lista+nl;
        }

        private void rdb_estagio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_eletivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lista = "";
            foreach (Control x in Form1.ActiveForm.Controls)
            {
                if (x is TextBox)((TextBox)x).Clear();
                if (x is CheckBox) ((CheckBox)x).Checked = false;
            }
            foreach (Control x in groupBox1.Controls)
            {
                if (x is RadioButton) ((RadioButton)x).Checked = false;
            }
            foreach (Control x in groupBox2.Controls)
            {
                if (x is CheckBox) ((CheckBox)x).Checked = false;
            }
        }
    }
}
