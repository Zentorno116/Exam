namespace Dopka
{
    public partial class Form1 : Form
    {
        string[,] people = new string[50, 4];
        int people_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText("Candidats.txt");
            string text2 = File.ReadAllText("Positions.txt");
            string[] rows = text.Split("\n");
            string[] rows2 = text2.Split("\n");
            foreach (string row in rows)
            {
                string[] values = row.Split(';');
                dataGridView1.Rows.Add(values[1]);
                people[people_count, 0] = values[0];
                people[people_count, 1] = values[1];
                people[people_count, 2] = rows2[people_count].Split(";")[1];
                people[people_count, 3] = values[3];
                people_count++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cell_clicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= people.Length)
            {
                return;
            }

            int index = e.RowIndex;
            dataGridView1.Rows[index].Selected = true;

            label5.Text = people[index, 0];
            label6.Text = people[index, 1];
            label7.Text = people[index, 2];
            richTextBox1.Text = people[index, 3];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
