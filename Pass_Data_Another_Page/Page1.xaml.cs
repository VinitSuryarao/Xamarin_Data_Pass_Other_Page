using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pass_Data_Another_Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        ModelEmployerList objEmpList = new ModelEmployerList();
        public Page1(ModelEmployerList emp)
        {
            InitializeComponent();
            if (emp != null && emp.EmpName != null && emp.EmpName != "")
            {
                txtData.Text = emp.EmpName.ToString();
            }
        }

        private void btnMainPage_Clicked(object sender, EventArgs e)
        {
            objEmpList.EmpName = txtData.Text;
            Navigation.PushAsync(new MainPage(objEmpList));
        }

        private void btnPage2_Clicked_1(object sender, EventArgs e)
        {
            objEmpList.EmpName = txtData.Text;
            Navigation.PushAsync(new Page2(objEmpList));
        }
    }
}