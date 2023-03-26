using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagemetSystem.MVVM.Model
{
	public class Bill
	{
		public double billAmount { get; set; }
		public string paymentMode { get; set; }
		public bool status { get; set; }
		public DateTime paymentDate { get; set; }
	}
}
