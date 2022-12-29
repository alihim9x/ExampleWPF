using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;
using SingleData;
using Utility;
using Autodesk.Revit.UI.Selection;


namespace ElementInfo
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            #region Initial
            var revitData = RevitData.Instance;
            var formData = FormData.Instance;
            revitData.UIApplication = commandData.Application;
            var sel = revitData.Selection;
            var modelData = ModelData.Instance;





            #endregion
            //var elem = sel.PickObject(ObjectType.Element).GetElement().GetEntityElement();
            //formData.ElementView = elem.GetElementView();
            //formData.SettingView = new Model.ViewModel.SettingView { Setting = new Model.Entity.Setting()}; 
            //SettingView chưa có nên phải khởi tạo,sau khi khởi tạo sẽ có các giá trị mặc định đã tạo sẵn

            // Đã tự gán SettingView nên ko cần formData.SettingView 

            //modelData.Elements = sel.PickElementsByRectangle().Select(x => x.GetEntityElement()).ToList();
            //formData.ElementViews = modelData.Elements.Select(x => x.GetElementView()).ToList();

            var form = formData.InputForm;
            form.ShowDialog();

            //var setting = modelData.Setting;
            //TaskDialog.Show("Revit", $"Concrete Cover: {setting.ConcreteCover}, Concrete Grade: {setting.ConcreteGrade}, " +
            //    $"Steel Grade: {setting.SteelGrade}, Rebar: {setting.Rebar.Name}");



            




            return Result.Succeeded;
        }
    }
}
