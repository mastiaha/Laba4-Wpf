using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba4_Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvr = Convert.ToDouble(rateEvro.Text);
            double sumEvr = Convert.ToDouble(sumEvro.Text);
            double resDouble2 = rateEvr * sumEvr;
            resSumEvro.Text = resDouble2.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateG = Convert.ToDouble(rateGr.Text);
            double sumG = Convert.ToDouble(sumGr.Text);
            double resDouble3 = rateG * sumG;
            resSumGr.Text = resDouble3.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateD = Convert.ToDouble(rateDr.Text);
            double sumD = Convert.ToDouble(sumDr.Text);
            double resDouble4 = rateD * sumD;
            resSumDr.Text = resDouble4.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double kolDujm = Convert.ToDouble(dujm.Text);
            double result1 = 0.0254 * kolDujm;
            resDujm.Text = result1.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double kolFut = Convert.ToDouble(fut.Text);
            double result2 = 0.3048 * kolFut;
            resFut.Text = result2.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double kolMili = Convert.ToDouble(mili.Text);
            double result3 = 1609.344 * kolMili;
            resMili.Text = result3.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double kolVerst = Convert.ToDouble(verst.Text);
            double result4 = 1066.8 * kolVerst;
            resVerst.Text = result4.ToString();
        }
    }

}
