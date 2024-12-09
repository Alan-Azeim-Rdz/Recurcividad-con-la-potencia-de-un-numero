namespace Recurcividad_con_la_potencia_de_un_numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32( TxtNumber.Text);
            int potencia = Convert.ToInt32(TxtNumberP.Text );
            LstViewData.Items.Clear();
            LstViewData.Items.Add(Convert.ToString( Potencia(number, potencia))).BackColor = Color.LightGreen;
        }
        private int Potencia(int baseNum, int exp)
        {
            if (exp == 0) return 1;

            int result= baseNum * Potencia(baseNum, exp - 1);
            LstViewData.Items.Add(Convert.ToString( result));
            return result;
        }
    }
}
