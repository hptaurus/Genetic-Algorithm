using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Genetic_Algorithm.Classes
{
    public class Chromosome
    {
        #region Fields
        private List<List<int>> _sudoku;
        private List<int> _genes, _parent1, _parent2;
        private int _fitness;
        public int Fitness
        {
            get { return this._fitness; }
        }
        public List<List<int>> Sudoku
        {
            get { return this._sudoku; }
        }
        public List<int> Genes
        {
            get { return this._genes; }
            set
            {
                this._genes = value;
                this._fitness = this.calculateFitness();
            }
        }
        #endregion

        #region Constructors
        public Chromosome(List<List<int>> sudoku, List<int> genes)
        {
            this._sudoku = sudoku;
            this.Genes = genes;
        }
        public Chromosome(List<List<int>> sudoku, List<int> genes, List<int> parent1, List<int> parent2)
        {
            this._sudoku = sudoku;
            this.Genes = genes;
            this._parent1 = parent1;
            this._parent2 = parent2;
        }
        #endregion

        #region Private Methods
        private int calculateFitness()
        {
            return 0;
        }
        #endregion

        #region Public Methods
        
        #endregion

        #region Events
        #endregion

    }
}
