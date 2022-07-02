namespace ImcPet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmbRaca = new System.Windows.Forms.ComboBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.MaskedTextBox();
            this.CmbGenero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CmbRaca
            // 
            this.CmbRaca.FormattingEnabled = true;
            this.CmbRaca.Items.AddRange(new object[] {
            "Akita",
            "Basset hound",
            "Bichon frisé",
            "Boiadeiro australiano",
            "Border collie",
            "Boston terrier",
            "Boxer",
            "Buldogue francês",
            "Budogue inglês",
            "Bull terrier",
            "Cane corso",
            "Cavalier king",
            "Chihuahua",
            "Chow chow",
            "cocker spaniel inglês",
            "Dachshund",
            "Dálmata",
            "Doberman",
            "Dogo argentino",
            "Dogue alemão",
            "Fila brasileiro",
            "Golden retriver",
            "Husky siberiano",
            "Jack russell",
            "Labrador retriver",
            "Lhasa apso",
            "Lulu da pomerânia",
            "Maltes",
            "Maltês",
            "Mastiff inglês",
            "Mastim tibetano",
            "Pastor alemão",
            "Pastor australiano",
            "Pastor de shetland",
            "Pequinês",
            "Pinscher",
            "Pit bull",
            "Poodle",
            "Pug",
            "Rottweiler",
            "Schnauzer",
            "Shar-pei",
            "Shiba",
            "Shih tzu",
            "Staffordshire bull",
            "Weimaraner",
            "Yorkshire"});
            this.CmbRaca.Location = new System.Drawing.Point(286, 126);
            this.CmbRaca.Name = "CmbRaca";
            this.CmbRaca.Size = new System.Drawing.Size(121, 31);
            this.CmbRaca.TabIndex = 1;
            this.CmbRaca.SelectedIndexChanged += new System.EventHandler(this.CmbRaca_SelectedIndexChanged);
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(456, 226);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(189, 73);
            this.TxtDescricao.TabIndex = 2;
            this.TxtDescricao.TextChanged += new System.EventHandler(this.TxtDescricao_TextChanged);
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "Gato",
            "Cachorro"});
            this.CmbTipo.Location = new System.Drawing.Point(286, 50);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(121, 31);
            this.CmbTipo.TabIndex = 3;
            this.CmbTipo.SelectedIndexChanged += new System.EventHandler(this.CmbTipo_SelectedIndexChanged);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCalcular.Location = new System.Drawing.Point(589, 115);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(104, 32);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(456, 87);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(100, 31);
            this.TxtAltura.TabIndex = 5;
            this.TxtAltura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(456, 147);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(100, 31);
            this.TxtPeso.TabIndex = 6;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(52, 126);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(165, 31);
            this.TxtName.TabIndex = 7;
            this.TxtName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // CmbGenero
            // 
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.CmbGenero.Location = new System.Drawing.Point(286, 195);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(121, 31);
            this.CmbGenero.TabIndex = 8;
            this.CmbGenero.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(52, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome do Pet:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(286, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Raça:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(286, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(286, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(456, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Altura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(456, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Peso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(456, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descrição:";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLimpar.Location = new System.Drawing.Point(589, 61);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(104, 32);
            this.BtnLimpar.TabIndex = 16;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 447);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbGenero);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.CmbRaca);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Calculadora IMC Pet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ComboBox CmbRaca;
        private TextBox TxtDescricao;
        private ComboBox CmbTipo;
        private Button BtnCalcular;
        private TextBox TxtAltura;
        private TextBox TxtPeso;
        private MaskedTextBox TxtName;
        private ComboBox CmbGenero;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button BtnLimpar;
    }
}