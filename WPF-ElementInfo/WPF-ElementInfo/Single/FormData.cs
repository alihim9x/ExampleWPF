using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace SingleData
{
    public class FormData : NotifyClass // Kiểu dữ liệu dùng để cập nhật giá trị lên Form
    {
        public static FormData Instance { get { return Singleton.Instance.FormData; } }
        private Model.Form.InputForm inputForm;
        public Model.Form.InputForm InputForm
        {
            get
            {
                if(inputForm == null)
                {
                    inputForm = new Model.Form.InputForm
                    {
                        DataContext = this
                    };
                }
                return inputForm;
            }
        }

        private Model.ViewModel.ElementView elementView;
        public Model.ViewModel.ElementView ElementView
        {
            get
            {
                return elementView;
            }
            set
            {
                elementView = value;
                OnPropertyChanged(); // Phương thức cập nhật giá trị lên Form
            }
        }
        private Model.ViewModel.SettingView settingView;
        public Model.ViewModel.SettingView SettingView
        {
            get
            {
                if (settingView == null)
                {
                    settingView = new Model.ViewModel.SettingView()
                    {
                        Setting = ModelData.Instance.Setting
                    };
                } 
                return settingView;
            }
            
        }
        private ObservableCollection<Model.ViewModel.ElementView> elementViews; // WPF thi phai dung ObservableCollection thay cho List
        public ObservableCollection<Model.ViewModel.ElementView> ElementViews
        {
            get
            {
                return elementViews;
            }
            set
            {
                elementViews = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Model.ViewModel.RebarView> rebarViews;
        public ObservableCollection<Model.ViewModel.RebarView> RebarViews
        {
            get
            {
                if(rebarViews == null)
                {
                    rebarViews = new ObservableCollection<Model.ViewModel.RebarView>();
                }
                return rebarViews;
            }
            set
            {
                rebarViews = value;
                OnPropertyChanged();
            }
        }

    }
}
