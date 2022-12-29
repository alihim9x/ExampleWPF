using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleData;

namespace Utility
{
    public static class RebarUtil
    {
        public static ModelData modelData
        {
            get
            {
                return ModelData.Instance;
            }
        }
        public static List<Model.Entity.RebarShape> GetRebarShapes()
        {
            return new List<Model.Entity.RebarShape> { Model.Entity.RebarShape.I_Shape, Model.Entity.RebarShape.L_Shape };
        }
    }
}
