namespace ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void yeþilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void hakkýmýzdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bir ContextMenuStrip denemesidir.", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }
    }
}