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
        private List<int> _genes, _parent1, _parent2;
        private int _fitness;
        public int Fitness
        {
            get { return this._fitness; }
        }
        public List<int> Genes
        {
            get { return this._genes; }
        }
        #endregion

        #region Constructors
        public Chromosome(List<List<int>> sudoku, List<int> genes)
        {
            this._genes = genes;
            this._fitness = this.calculateFitness(sudoku);
        }
        public Chromosome(List<List<int>> sudoku, List<int> genes, List<int> parent1, List<int> parent2)
        {
            this._genes = genes;
            this._parent1 = parent1;
            this._parent2 = parent2;
            this._fitness = this.calculateFitness(sudoku);
        }
        #endregion

        #region Private Methods
        private int calculateFitness(List<List<int>> sudoku)
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
