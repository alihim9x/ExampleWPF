using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Model.Entity
{
    public class Rebar : NotifyClass
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public double Diameter { get; set; }

        public string FullName { get { return $"Rebar:{Name}"; } }
        private RebarShape rebarShape;
        public RebarShape RebarShape
        {
            get
            {
                return rebarShape;
            }
            set
            {
                rebarShape = value;
                OnPropertyChanged();
            }
        }
    }
}
