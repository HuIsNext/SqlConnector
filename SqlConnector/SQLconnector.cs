namespace SqlConnector
{
    public partial class SQLconnector : Form
    {
        public SQLconnector()
        {
            InitializeComponent();
        }

        private void �[�J�s�u�]�wToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddConnection AC = new AddConnection();
            AC.Show();
            AC.StartPosition = FormStartPosition.CenterScreen;

        }
    }
}