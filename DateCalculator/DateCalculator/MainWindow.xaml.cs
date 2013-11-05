using System;
using System.Windows;

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
        /// <summary>
        /// 计算逻辑
        /// </summary>
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
