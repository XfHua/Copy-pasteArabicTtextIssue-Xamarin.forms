using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App194
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Editor_OnCompleted(object sender, EventArgs e)
        {
            //The text that is copied is on https://r12a.github.io/scripts/tutorial/summaries/arabic under sample(arabic).
            Label.Text = Editor.Text;
        }
    }
}
