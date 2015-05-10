using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            while (dgvSudoku.Rows.Count < 9)
                dgvSudoku.Rows.Add();
            dgvSudoku.Height = dgvSudoku.Rows[0].Height * dgvSudoku.Rows.Count + 3;
            for (int i = 0; i < 9; i++)
            {
                dgvSudoku.Rows[i].Height = dgvSudoku.Columns[i].Width = 30;
                if(i%3 == 2)
                    dgvSudoku.Rows[i].DividerHeight = dgvSudoku.Columns[i].DividerWidth = 1;
                for (int j = 0; j < 9; j++)
                {
                    
                }
            }
            dgvSudoku.Height = dgvSudoku.Width = dgvSudoku.Rows[0].Height * dgvSudoku.Rows.Count + 3;

        }
    }
}
