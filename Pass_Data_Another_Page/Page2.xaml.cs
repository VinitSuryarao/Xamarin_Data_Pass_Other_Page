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
    public partial class Page2 : ContentPage
    {
        ModelEmployerList objEmpList = new ModelEmployerList();
        public Page2(ModelEmployerList emp)
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

        private void btnPage1_Clicked_1(object sender, EventArgs e)
        {
            objEmpList.EmpName = txtData.Text;
            Navigation.PushAsync(new Page1(objEmpList));
        }
    }
}