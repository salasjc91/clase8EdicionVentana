namespace clase8EdicionVentana
{
    public partial class Form1 : Form
    {
        ListaParticipantes lista;
        public Form1()
        {
            InitializeComponent();
            lista = new ListaParticipantes();
            lista.Lista.Add("Cesar");
            lista.Lista.Add("Scarleth");
            lista.Lista.Add("Kimberly");
            lista.Lista.Add("Alejandro");
            lista.Lista.Add("Flor");
            lista.Lista.Add("Juan ");
            lista.Lista.Add("Jeseenia");
            lista.Lista.Add("Neymar");
            lista.Lista.Add("Chase");



        }

        void refrescarpantalla()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(lista.Lista.ToArray());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btcancelar.Enabled = false;
            bteditar.Enabled = false;
            btguardar.Enabled = false;
            txbombre.Enabled = false;
            refrescarpantalla();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                txbombre.Text = lista.Lista[listBox1.SelectedIndex];
                bteditar.Enabled = true;
                btguardar.Enabled = false;
                btcancelar.Enabled = false;
                txbombre.Enabled = false;


            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            txbombre.Enabled = true;
            btguardar.Enabled = true;
            btcancelar.Enabled = true;
            bteditar.Enabled = false;
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            txbombre.Enabled = false;
            btguardar.Enabled = false;
            btcancelar.Enabled = false;
            bteditar.Enabled = true;
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                lista.Lista[listBox1.SelectedIndex] = txbombre.Text;


                txbombre.Enabled = true;
                btguardar.Enabled = true;
                btcancelar.Enabled = true;
                bteditar.Enabled = false;
                refrescarpantalla();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbombre_KeyUp(object sender, KeyEventArgs e)
        {
            if(txbombre.Enabled)
            {
                if(txbombre.Text.Trim().Length ==0)
                {
                    lberror.Text = "no puede dejar el espacio vacio";
                    btguardar.Enabled = false;
                }
                else
                {
                    lberror.Text = "";
                    btguardar.Enabled = true;
                }
            }
        }
    }
}
