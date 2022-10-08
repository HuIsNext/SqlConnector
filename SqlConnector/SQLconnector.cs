namespace SqlConnector
{
    public partial class SQLconnector : Form
    {
        public SQLconnector()
        {
            InitializeComponent();
        }

        private void 加入連線設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddConnection AC = new AddConnection();
            AC.Show();
            AC.StartPosition = FormStartPosition.CenterScreen;

        }
    }
}