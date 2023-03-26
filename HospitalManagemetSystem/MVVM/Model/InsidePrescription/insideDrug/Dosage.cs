using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagemetSystem.MVVM.Model.InsidePrescription.insideDrug
{
	public class Dosage
	{
		public Drug drug { get; set; }
		public string drugType { get; set; }
		public double dose { get; set; }
		public double duration { get; set; }
		public string comments { get; set; }
	}
}
