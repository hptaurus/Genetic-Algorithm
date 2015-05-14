using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Genetic_Algorithm.Classes;

namespace Genetic_Algorithm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            while (this.dgvSudoku.Rows.Count < 9)
                this.dgvSudoku.Rows.Add();
            for (int i = 0; i < 9; i++)
            {
                this.dgvSudoku.Rows[i].Height = this.dgvSudoku.Columns[i].Width = 30;
                if(i%3 == 2)
                    this.dgvSudoku.Rows[i].DividerHeight = this.dgvSudoku.Columns[i].DividerWidth = 1;
                ((DataGridViewTextBoxColumn)this.dgvSudoku.Columns[i]).MaxInputLength = 1;
            }
            this.dgvSudoku.Height = this.dgvSudoku.Width = this.dgvSudoku.Rows[0].Height * this.dgvSudoku.Rows.Count + 3;
        }

        private void dgvSudoku_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

    }
}
