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
        private int _count, _fitness;
        private List<int> _genes;

        public int Count
        {
            get { return this._count; }
        }
        public int Fitness
        {
            get { return this._fitness; }
        }
        public List<int> Genes
        {
            get { return this._genes; }
            set { this._genes = value; }
        }
        #endregion

        #region Constructors
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion

        #region Events
        #endregion

    }
}
