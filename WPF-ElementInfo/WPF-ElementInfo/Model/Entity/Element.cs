using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Model.Entity
{
    public class Element
    {
        public Autodesk.Revit.DB.Element RevitElement { get; set; } // Design Pattern Decorator - Kiểu dữ liệu gốc không đủ thông tin, nên mình tạo ra để thêm những thông  tin khác vào đối tượng gốc
        private Identify identify;       
        public Identify Identify
        {
            get
            {
                if(identify == null)
                {
                    identify = this.GetIdentify();
                }
                return identify;
            }
        }
        public Geometry Geometry { get; set; }
        private ElementType? elementType; // Vì ElementTYpe là enum nên giá trị mặc định là giá trị đầu tiên, đặt dấu chấm hỏi thì giá trị mặc định là null
        public ElementType? ElementType
            {
                get
                {
                    if(elementType == null)
                    {
                    elementType = this.GetElementType();
                    }
                return elementType;
                }
            }
    }
}
