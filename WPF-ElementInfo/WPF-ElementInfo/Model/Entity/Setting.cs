using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using SingleData;

namespace Model.Entity
{
    public class Setting : NotifyClass // Kiểu dữ liệu cập nhật giá trị
    {
        private double concreteCover;
        public double ConcreteCover
        {
            get
            {
                if(concreteCover == 0)
                {
                    concreteCover = 30.0.Milimet2Feet();
                }
                return concreteCover;
            }
            set
            {
                concreteCover = value;
                
            }
        }
        private string concreteGrade;
        public string ConcreteGrade
        {
            get
            {
                if (concreteGrade == null) concreteGrade = "B20";
                return concreteGrade;
            }
            set
            {
                concreteGrade = value;
                OnPropertyChanged();
            }
        }
        private string steelGrade;
        public string SteelGrade
        {
            get
            {
                if (steelGrade == null) steelGrade = "CIII";
                return steelGrade;
            }
            set
            {
                steelGrade = value;
                OnPropertyChanged();
            }
        }
        private Model.Entity.Rebar rebar;

        public Model.Entity.Rebar Rebar
        {
            get
            {
                //if (rebar == null)
                //{
                //    rebar = ModelData.Instance.Rebars.Single(x => x.Name == "T18"); // Gán giá trị mặc định cho ComboBox
                //}
                return rebar;
            }
            set
            {
                rebar = value;
                OnPropertyChanged();
            }
        }
    }
}
