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

namespace DateCalculator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtBegin.Text = "2013-04-09 19:22:00";
            txtEnd.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Calculate();
        }

        private void Calculate()
        {
            try
            {
                var beginDate = DateTime.Parse(txtBegin.Text);
                var endDate = DateTime.Parse(txtEnd.Text);
                var result = endDate.Subtract(beginDate);
                var resultStr = string.Format("{0}天{1}小时{2}分钟", result.Days, result.Hours, result.Minutes);
                lblResult.Content = resultStr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }
    }
}
