using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleData;
using Utility;

namespace Utility
{
    public static class InputFormUtil
    {
        private static RevitData revitData
        {
            get
            {
                return RevitData.Instance;
            }
        }
        private static FormData formData
        {
            get
            {
                return FormData.Instance;
            }
        }
        private static ModelData modelData
        {
            get
            {
                return ModelData.Instance;
            }
        }
        public static void PickElement()
        {
            var form = formData.InputForm;
            form.Hide();
            var sel = revitData.Selection;
            try
            {
                formData.ElementView = sel.PickObject(Autodesk.Revit.UI.Selection.ObjectType.Element)
                                .GetElement().GetEntityElement().GetElementView();
                
            }
            catch(Autodesk.Revit.Exceptions.OperationCanceledException)
            {

            }
            
            form.ShowDialog();
        }
        public static void PickElements()
        {
            var form = formData.InputForm;
            form.Hide();
            var sel = revitData.Selection;
            try
            {
                modelData.Elements = sel.PickElementsByRectangle().Select(x => x.GetEntityElement()).ToList();
                //formData.ElementViews = new System.Collections.ObjectModel.ObservableCollection<Model.ViewModel.ElementView>
                //    ( modelData.Elements.Select(x => x.GetElementView()).ToList());
                formData.ElementViews = modelData.Elements.Select(x => x.GetElementView()).ToObservableCollection();

            }
            catch (Autodesk.Revit.Exceptions.OperationCanceledException)
            {

            }

            form.ShowDialog();
        }
        public static void AddElements()
        {
            var form = formData.InputForm;
            form.Hide();
            var sel = revitData.Selection;
            try
            {
                var elem = sel.PickObject(Autodesk.Revit.UI.Selection.ObjectType.Element).GetElement().GetEntityElement();
                modelData.Elements.Add(elem);
                formData.ElementViews.Add(elem.GetElementView());

            }
            catch (Autodesk.Revit.Exceptions.OperationCanceledException)
            {

            }

            form.ShowDialog();
        }
        public static void AddRebars()
        {
            var rebar = new Model.Entity.Rebar();
            var rebarView = new Model.ViewModel.RebarView { Rebar = rebar};
            modelData.Rebars.Add(rebar);
            formData.RebarViews.Add(rebarView);
        }
        public static void DeleteRebars(Model.ViewModel.RebarView rebarView)
        {
            formData.RebarViews.Remove(rebarView); // Xóa trong form
            modelData.Rebars.Remove(rebarView.Rebar); // Xóa trong model
        }
    }
}
