using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pass_Data_Another_Page
{
    public partial class MainPage : ContentPage
    {
        ModelEmployerList objEmpList = new ModelEmployerList();
        public MainPage(ModelEmployerList emp)
        {
            InitializeComponent();
            if(emp != null && emp.EmpName != null && emp.EmpName != "")
            {
                txtData.Text = emp.EmpName.ToString();
            }
            
        }

        private void btnPage1_Clicked(object sender, EventArgs e)
        {
            objEmpList.EmpName = txtData.Text;
            Navigation.PushAsync(new Page1(objEmpList));
        }

        private void btnPage2_Clicked(object sender, EventArgs e)
        {
            objEmpList.EmpName = txtData.Text;
            Navigation.PushAsync(new Page2(objEmpList));
        }
    }
}
