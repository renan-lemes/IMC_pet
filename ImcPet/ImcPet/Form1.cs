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
            "Akita","Boxer","Buldogue franc�s","Cane corso","Doberman","Dogo argentino", "Dogue alem�o",
            "Fila brasileiro","Mastiff ingl�s", "Mastim tibetano","Pastor alem�o","Rottweiler",

        };
        string[] Medio = new string[] 
        {
            "Boiadeiro australiano","Border collie","Bull terrier","Chow chow","D�lmata", "Golden retriver", 
            "Husky siberiano","Labrador retriver", "Pastor australiano", "Pit bull","Poodle","Shar - pei","Staffordshire bull", "Weimaraner"
        };
        string[] Baixo = new string[] 
        {
            "Basset hound","Bichon fris�","Boston terrier","Cavalier king","Chihuahua","cocker spaniel ingl�s",
            "Dachshund","Jack russell","Lhasa apso", "Lulu da pomer�nia","Maltes", "Pastor de shetland", "Pequin�s",
            "Pinscher", "Pug","Schnauzer", "Shiba", "Shih tzu", "Yorkshire"
        };

        private void button1_Click(object sender, EventArgs e)
        {
            double Altura = 0;
            double Peso = 0;
            Altura = double.Parse(TxtAltura.Text);
            Peso = double.Parse(TxtPeso.Text);

            if (CmbTipo.Text == "Gato")
            {
                if (CmbGenero.Text == "Feminino")
                {

                }else if(CmbGenero.Text == "Masculino")
                {

                }
            }
            if(CmbGenero.Text == "Feminino")
            {

                //faz um calculo aqui 

                if (CmbRaca.Text == "Pesado") 
                {
                    // faz um calculo para a ra�a pesado
                    
                }
                if (CmbRaca.Text == "Medio")
                {
                    // faz o calculo para a ra�a de propor��o media

                }else if(CmbRaca.Text == "Baixo"){ 
                    // aqui faz o calculo para a ra�a de menor porte

                }
            }
            else if(CmbGenero.Text == "Masculino")
            {
                if (CmbRaca.Text == "Pesado")
                {
                    // faz um calculo para a ra�a pesado

                }
                if (CmbRaca.Text == "Medio")
                {
                    // faz o calculo para a ra�a de propor��o media

                }
                else
                {
                    // aqui faz o calculo para a ra�a de menor porte

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
            /*
            Dogs
   
            
            
            
            
            
            
            
            
            
            
            
           
           */

        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbRaca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}     