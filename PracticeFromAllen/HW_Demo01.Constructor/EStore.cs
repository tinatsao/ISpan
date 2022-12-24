using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Constructor
{
	internal class EStore
	{/// <summary>
	 /// 算含稅價
	 /// </summary>
	 /// <param name="price">定價</param>
	 /// <returns></returns>
		public static int CalcInclusivePrice(int price)//計算含稅價
		{
			return (int)Math.Round((double)price * (price / 20.0), MidpointRounding.AwayFromZero);
		}
		/// <summary>
		/// 建立EStore時先傳入營業稅率)
		/// </summary>
		/// <param name="taxRate"></param>
		public EStore(double taxRate)
		{
			_taxRate = taxRate;
		}
		private double _taxRate { get; }


		/// <summary>
		/// 計算營業稅
		/// </summary>
		/// <param name="price"></param>
		/// <returns></returns>
		private int CalcTax(int price)//計算營業稅
		{
			return (int)Math.Round((double)price * _taxRate,MidpointRounding.AwayFromZero);
		}
		/// <summary>
		/// 開立發票
		/// </summary>
		/// <param name="price"></param>
		/// <returns></returns>
		public Invoice IssueInvoice(int price)//開立發票，傳回Invoice型別物件(這裡我有點懵...)
		{
			return new Invoice(price); 
		}
	}

}
