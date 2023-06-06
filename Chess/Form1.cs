using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void SinglePlayerButton_Click(object sender, EventArgs e)
        {
            this.menuPanel.Visible = false;
            this.chessBoard.Visible = true;
        }

        private void InitializeGrid()
        {
            string alphabet = "ABCDEFGH";
            int numberOfRows = 8;
            int numberOfColumns = 8;
            DataGridViewCell dataGridViewCell;


            foreach (char column in alphabet)
            {
                this.chessBoard.Columns.Add(column.ToString(), column.ToString());
            }

            this.chessBoard.Rows.Add(numberOfRows);
            for (int i = 0; i < numberOfRows; i++)
            {
                this.chessBoard.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

            for (int i = 0;i <numberOfColumns; i++)
            {
                for (int j = 0; j < numberOfRows; j++) 
                {
                    if ((i % 2 == 0 && j % 2 == 1) || (i % 2 == 1 && j % 2 == 0))
                    {
                        dataGridViewCell = this.chessBoard[i,j];
                        dataGridViewCell.Style.BackColor = Color.RosyBrown;
                    }
                }
            }

            this.chessBoard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.chessBoard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}