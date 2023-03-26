using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagemetSystem.MVVM.Model
{
	public class Appointment
	{
		public DateTime appointedDate { get; set; }
		public Doctor doctor { get; set; }
	}
}
