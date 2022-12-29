using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleData;
using Utility;

namespace Model.ViewModel
{
    public class RebarView : NotifyClass
    {
        public Model.Entity.Rebar Rebar { get; set; }
        private double diameterMM;
        public double DiameterMM
        {
            get
            {
                return diameterMM;
            }
            set
            {
                diameterMM = value;
                OnPropertyChanged();

                Rebar.Diameter = diameterMM.Milimet2Feet();
            }
        }
        public List<Model.Entity.RebarShape> RebarShapes
        {
            get
            {
                return ModelData.Instance.RebarShapes;
            }
        }
    }
}
