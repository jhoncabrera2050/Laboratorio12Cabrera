using Laboratorio12.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio12.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculator : ContentPage
    {

        private CalculatorViewModel viewModel;

        public Calculator()
        {
            InitializeComponent();
            viewModel = new CalculatorViewModel();
            BindingContext = viewModel;
        }

        void OnSelectNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;
            viewModel.OnSelectNumber(pressed);
        }

        void OnSelectOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;
            viewModel.OnSelectOperator(pressed);
        }

        void OnClear(object sender, EventArgs e)
        {
            viewModel.OnClear();
        }

        void OnCalculate(object sender, EventArgs e)
        {
            viewModel.OnCalculate();
        }

    }
}