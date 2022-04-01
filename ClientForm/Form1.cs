namespace ClientForm
{
    public partial class ClientForm : Form
    {
        String name;
        String port;
        String ip;

        public ClientForm(String name, String port, String ip)
        {
            this.name = name;
            this.port = port;
            this.ip = ip;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}