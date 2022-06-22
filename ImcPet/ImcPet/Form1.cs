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
            "",
        };
        string[] Medio = new string[] 
        { 
            "",
        };
        string[] Baixo = new string[] 
        {
            "", 
        };

        private void button1_Click(object sender, EventArgs e)
        {
            double Altura = 0;
            double Peso = 0;
            Altura = double.Parse(TxtAltura.Text);
            Peso = double.Parse(TxtPeso.Text);

            if(CmbGenero == "Feminino")
            {

                //faz um calculo aqui 

                if (CmbRaca == "Pesado") 
                {
                    // faz um calculo para a raça pesado
                    
                }
                if (CmbRaca == "Medio")
                {
                    // faz o calculo para a raça de proporção media

                }else if(CmbRaca == "Baixo"){ 
                    // aqui faz o calculo para a raça de menor porte

                }
            }
            else if(CmbGenero.Text == "Masculino")
            {
                if (CmbRaca == "Pesado")
                {
                    // faz um calculo para a raça pesado

                }
                if (CmbRaca == "Medio")
                {
                    // faz o calculo para a raça de proporção media

                }
                else
                {
                    // aqui faz o calculo para a raça de menor porte

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
            Akita
            Basset hound
            Bichon frisé
            Boiadeiro australiano
            Border collie
            Boston terrier
            Boxer
            Buldogue francês
            Budogue inglês
            Bull terrier
            Cane corso
            Cavalier king
            Chihuahua
            Chow chow
            cocker spaniel inglês
            Dachshund
            Dálmata
            Doberman
            Dogo argentino
            Dogue alemão
            Fila brasileiro
            Golden retriver
            Husky siberiano
            Jack russell
            Labrador retriver
            Lhasa apso
            Lulu da pomerânia
            Maltes
            Maltês
            Mastiff inglês
            Mastim tibetano
            Pastor alemão
            Pastor australiano
            Pastor de shetland
            Pequinês
            Pinscher
            Pit bull
            Poodle
            Pug
            Rottweiler
            Schnauzer
            Shar - pei
            Shiba
            Shih tzu
            Staffordshire bull
            Weimaraner
            Yorkshire
            
            Cats
            Persa
            Maine Coon
            Gato de pelo
            Gato de bengala
            Siamês
            Sphynx
            Ragdoll
            Munchi
            Scottish fold
            Noruegues da floresta
            Siberiano
            Savannah
            Gato de pelo curto
            Exótico
            Angorá
            Himalaio
            Azul russo
            Gato comum
            Sagrado da birmânia
            Chartreux
            Abissio
            Bombaim
            Kinkalow
            Birmanês
            Oriental
            Ragamuffin
            Somalli
            Singapura
            Curt americano
            British Longhair
            Toyger
            Van turco
            Manês
            Donskoy
            Oriental havana
            Ocicat
            Balinês
            Laperm
            Cymric
            Cornish rex
            Bobtail americano
            Nebelung
            Thai
            Korat
            Tonquinês
            Lykoi
            Peterbald
            Burmillia
            American wirehair
            Oriental longhair

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