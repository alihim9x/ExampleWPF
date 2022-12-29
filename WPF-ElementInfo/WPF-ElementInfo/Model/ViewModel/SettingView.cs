using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using SingleData;

namespace Model.ViewModel
{
    public class SettingView : NotifyClass
    {
     
        public Model.Entity.Setting Setting { get; set; }
        private double concreteCoverMM;
        public double ConcreteCoverMM
        {
            get
            {
                if (concreteCoverMM == 0)
                {
                    concreteCoverMM = Setting.ConcreteCover.Feet2Milimeter();
                }
                return concreteCoverMM;
            }
            set
            {
                concreteCoverMM = value;
                OnPropertyChanged();
                Setting.ConcreteCover = concreteCoverMM.Milimet2Feet();
            }
        }
        public List<Model.Entity.Rebar> Rebars
        {
            get
            {
                return ModelData.Instance.Rebars;
            }
        }
    }
}
