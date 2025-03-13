namespace RadioButtonlaTecrübeSiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTecrubeGoster_Click(object sender, EventArgs e)
        {
            string ad=txtAdi.Text; 
            string soyad = txtSoyadi.Text;
            
            if(rdbtnTecrubeli.Checked)
            {
                MessageBox.Show("Tecrübesiz " + ad + " " + soyad);

            }
            else if(rdbtnTecrubeli.Checked)
            {
                MessageBox.Show("Tebrübeli " + ad + " " + soyad);
            }
        }
    }
}
