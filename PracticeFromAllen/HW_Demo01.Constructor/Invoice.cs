using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Constructor
{
	internal class Invoice

	{
		public int Price { get; set; } //未稅金額
		public int Tax { get;} //營業稅
		public int InclusivePrice { get; }//含稅金額(未稅金額+營業稅)

		public Invoice(int price, double taxRate=0.05)
		{
			Price = price;
			Tax = (int)Math.Round(((double)Price * taxRate), MidpointRounding.AwayFromZero); ;
			InclusivePrice = Price + Tax;
		}
	}
}
