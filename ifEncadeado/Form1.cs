namespace ifEncadeado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public  void btnChecar_Click(object sender, EventArgs e)
        {
            byte idade;
            string mensagem;

            MessageBoxIcon teste;

            idade = byte.Parse(txtIdade.Text);

            if (idade < 16)
            {
                mensagem = "Você não pode votar e nem embarcar!";
                teste = MessageBoxIcon.Error;

            }
            else if (idade < 18)
            {
               mensagem = "Voto facultativo.Embarcaque permitido!";
                 teste =  MessageBoxIcon.Warning;
            }
            else
            {
                mensagem = " O voto é obrigatório.Embarcaque permitido!";
                teste =  MessageBoxIcon.Information;
            }
            MessageBox.Show(mensagem,"ONG",MessageBoxButtons.OK,teste);
        }
    }
}