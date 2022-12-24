using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Q02_StockTradingTime
{
    public partial class frmStockOpen : Form
    {
        public frmStockOpen()
        {
            InitializeComponent();
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            //先判斷是不是星期一到星期五，再判斷時間
            DateTime dt = Convert.ToDateTime(this.txtTime.Text);
            bool result = (IsWeekdays(dt) && IsBusinessHours(dt));
            string ShowText = (result) ? "在營業時間內。" : "不在營業時間。";
            MessageBox.Show(ShowText);
        }

        private static bool IsWeekdays(DateTime dt)
        {
            return (dt.DayOfWeek >= DayOfWeek.Monday && dt.DayOfWeek <= DayOfWeek.Friday);
        }

        private static bool IsBusinessHours(DateTime dt)
        {
            DateTime timeOpen = new DateTime(dt.Year, dt.Month, dt.Day, 9, 0, 0);
            DateTime timeClose = new DateTime(dt.Year, dt.Month, dt.Day, 13, 30, 0);
            return ((timeOpen <= dt) && (dt >= timeClose));
        }
    }
}