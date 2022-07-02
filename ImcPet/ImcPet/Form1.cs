namespace ImcPet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string[] Pesado = new string[]
        {
            "Akita","Boxer","Buldogue francês","Cane corso","Doberman","Dogo argentino", "Dogue alemão",
            "Fila brasileiro","Mastiff inglês", "Mastim tibetano","Pastor alemão","Rottweiler",

        };
        string[] Medio = new string[] 
        {
            "Boiadeiro australiano","Border collie","Bull terrier","Chow chow","Dálmata", "Golden retriver", 
            "Husky siberiano","Labrador retriver", "Pastor australiano", "Pit bull","Poodle","Shar - pei","Staffordshire bull", "Weimaraner"
        };
        string[] Baixo = new string[] 
        {
            "Basset hound","Bichon frisé","Boston terrier","Cavalier king","Chihuahua","cocker spaniel inglês",
            "Dachshund","Jack russell","Lhasa apso", "Lulu da pomerânia","Maltes", "Pastor de shetland", "Pequinês",
            "Pinscher", "Pug","Schnauzer", "Shiba", "Shih tzu", "Yorkshire"
        };

        private void button1_Click(object sender, EventArgs e)
        {

            double Altura;
            double Peso;
            double IMC;

            Altura = double.Parse(TxtAltura.Text);
            Peso = double.Parse(TxtPeso.Text);

            string raca = CmbRaca.Text;
            string nome = TxtName.Text;
            string tipo = CmbTipo.Text;

            if (CmbTipo.Text == "Gato")
            {
                if (CmbGenero.Text == "Feminino")
                {
                    IMC = (Peso / (Altura * Altura));
                    MessageBox.Show($"Seu {tipo} {nome} esta com o IMC de {IMC}");
                }
                else if (CmbGenero.Text == "Masculino")
                {
                    IMC = (Peso / (Altura * Altura));
                    MessageBox.Show($"Seu {tipo} {nome} esta com o IMC de {IMC}");
                }
            }
            if (CmbTipo.Text == "Cachorro")
            {
                if (CmbGenero.Text == "Feminino")
                {
                    IMC = (Peso / (Altura * Altura));
                    MessageBox.Show($"Seu {tipo} {nome} esta com o IMC de {IMC}");
                }
                else if (CmbGenero.Text == "Masculino")
                {
                    IMC = (Peso / (Altura * Altura));
                    MessageBox.Show($"Seu {tipo} {nome} esta com o IMC de {IMC}");
                }
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtPeso.Clear();
            TxtAltura.Clear();
            TxtDescricao.Clear();
            CmbGenero.Text = "";
            CmbRaca.Text = "";
            CmbTipo.Text = "";
        }

        private void TxtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbRaca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}     