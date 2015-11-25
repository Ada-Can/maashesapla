using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication1
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Double gunsayisi = Convert.ToInt16(gun.Text);
            Double gelmedigigunsayisi = Convert.ToInt16(gelmedigigun.Text);
            Double gelinengunsayisi = gunsayisi - gelmedigigunsayisi;
            Double brutmaas = gelinengunsayisi * 53;
            burt.Text =Convert.ToString(brutmaas);
            Double vergikesintisi= ((brutmaas/100)*28);
            kesinti.Text = Convert.ToString((brutmaas - (brutmaas - vergikesintisi)));
            maas.Text = Convert.ToString(brutmaas - vergikesintisi);
            
        }
    }
}
