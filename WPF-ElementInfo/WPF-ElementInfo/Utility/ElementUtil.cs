using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleData;

namespace Utility
{
    public static class ElementUtil
    {
        private static RevitData revitData
        {
            get
            {
                return RevitData.Instance;
            }
        }
        private static ModelData modelData
        {
            get
            {
                return ModelData.Instance;
            }
        }
        public static Autodesk.Revit.DB.Element GetElement(this Autodesk.Revit.DB.ElementId elemId)
        {
            return revitData.Document.GetElement(elemId);
        }
        public static Autodesk.Revit.DB.Element GetElement(this Autodesk.Revit.DB.Reference elemRf)
        {
            return revitData.Document.GetElement(elemRf);
        }
        public static Model.Entity.Element GetEntityElement(this Autodesk.Revit.DB.Element elem)
        {
            
                var entElem = new Model.Entity.Element
                {
                    RevitElement = elem
                };
            return entElem;
        }
        public static Model.Entity.ElementType GetElementType (this Model.Entity.Element elem)
        {
            var revitElem = elem.RevitElement;
            var cate = revitElem.Category;
            if (revitElem is Autodesk.Revit.DB.Floor)
                return Model.Entity.ElementType.Floor;
            if (revitElem is Autodesk.Revit.DB.Wall)
                return Model.Entity.ElementType.Wall;
            if (cate.Id.IntegerValue == (int)Autodesk.Revit.DB.BuiltInCategory.OST_StructuralColumns)
                return Model.Entity.ElementType.Column;
            if (cate.Id.IntegerValue == (int)Autodesk.Revit.DB.BuiltInCategory.OST_StructuralFraming)
                return Model.Entity.ElementType.Framing;
            return Model.Entity.ElementType.Undefined;

        }
    }
}
