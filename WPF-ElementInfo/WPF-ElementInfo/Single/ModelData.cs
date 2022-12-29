using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace SingleData
{
    public class ModelData
    {
        public static ModelData Instance { get { return Singleton.Instance.ModelData; } }
        
        private Model.Entity.Setting setting;
        public Model.Entity.Setting Setting
        {
            get
            {
                if (setting == null)
                  setting = new Model.Entity.Setting();
                return setting;
            }
        }

        private List<Model.Entity.Element> elements;
        public List<Model.Entity.Element> Elements
        {
            get
            {
                return elements;
            }
            set
            {
                elements = value;
            }
        }
        private List<Model.Entity.Rebar> rebars;
        public List<Model.Entity.Rebar> Rebars
        {
            get
            {
                if(rebars == null)
                {
                    rebars = new List<Model.Entity.Rebar>();
                }
                return rebars;
               
            }
            set
            {
                rebars = value;
            }
        }
        private List<Model.Entity.RebarShape> rebarShapes;
        public List<Model.Entity.RebarShape> RebarShapes
        {
            get
            {
                if(rebarShapes == null)
                {
                    rebarShapes = RebarUtil.GetRebarShapes();
                }
                return rebarShapes;

            }
        }
    }
}
