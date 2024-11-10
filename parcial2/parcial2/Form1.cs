using Comerciolib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Comercio c = new Comercio();

        #region Archivos

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("datos.bin", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                c = bf.Deserialize(fs) as Comercio;

            }
            catch { }
            finally
            {
                if (fs != null) { fs.Close(); }

            }
            if (fs == null)
            {

                c = new Comercio();
                Cliente carlitos = new Cliente("45312756");
                c.CrearCuentaC(40735264, carlitos);
                Cliente juan = new Cliente("35122536");
                c.CrearCuentaC(14626861, juan);
                Cliente maria = new Cliente("33666336");
                c.CrearCuentaC(38381819, maria);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            FileStream fs = null;
            try
            {

                fs = new FileStream("datos.Bin", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, c);
            }
            catch { }
            finally { if (fs != null) { fs.Close(); } }









        }

        private void btnImpo_Click(object sender, EventArgs e)
        {
            if (controlOpenF.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    string path = controlOpenF.FileName;

                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                    sr = new StreamReader(fs);

                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();

                        string[] columnas = linea.Split(';');

                        int NroCuenta = Convert.ToInt32(columnas[0]);
                        string dni = columnas[1];
                        double saldo = Convert.ToDouble(columnas[2]);

                        CuentaCorriente cuentaC = null;
                        cuentaC = c.pedirCuenta(NroCuenta);
                        if (cuentaC == null)
                        {
                            //Acá agregué un método que cree CuentasCorrientes --Vir
                            Cliente nuevo = new Cliente(dni);
                            c.CrearCuentaC(NroCuenta, nuevo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DNI inválido");
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
        }

        private void btnExpo_Click(object sender, EventArgs e)
        {
            ControlguardarDOC.Title = "Boton Exportar";
            if (ControlguardarDOC.ShowDialog() == DialogResult.OK)
            {
                string path = ControlguardarDOC.FileName;
                FileStream fs = null;
                StreamWriter sw = null;

                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                    sw = new StreamWriter(fs);

                    string linea = "Tipo:Pago;numero;dni;ctacorriente";
                    sw.WriteLine(linea);
                    linea = "Tipo:Cliente;numero;dni;ctacorriente";
                    sw.WriteLine(linea);

                    foreach (Ticket ticket in c.ticketes)
                    {
                        linea = ticket.ToString();
                        sw.WriteLine(linea);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRRRRORRRRRRR");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();















                }
            }

            #endregion






        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (checkBox1.Checked)
            {
                int nrocuenta = Convert.ToInt32(tbCuentacte.Text);
                CuentaCorriente cuentac = c.pedirCuenta(nrocuenta);
                Ticket paga = new Pago(cuentac);
                c.AgregarTicket(paga);
                listBox1.Items.Add(paga);
            }
            else if (!checkBox1.Checked)
            {
                string dni = tbDni.Text;
                Ticket client = new Cliente(dni);
                c.AgregarTicket(client);
                listBox1.Items.Add(client);
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (rbCompras.Checked)
            {
                int n = 0;
                c.AtenderTicket(n);
            }
            if (rbpagos.Checked)
            {
                int n = 1;
                c.AtenderTicket(n);
            }

            List<Ticket> ticks = c.VerTickets();
            int idx = ticks.Count;

            listBox1.Items.Add(ticks[idx]);
        }
    }
}




