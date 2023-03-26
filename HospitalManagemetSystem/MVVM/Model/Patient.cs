using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagemetSystem.MVVM.Model
{
	public class Patient
	{
		public string fullName { get; set; }
		public string email { get; set; }
		public DateTime birthDay { get; set; }
		public string phone { get; set; }
		public char gender { get; set; }
		public string bloodGroup { get; set; }
		public string address { get; set; }
		public double weight { get; set; }
		public double height { get; set; }
		public List<Prescription> prescriptionList { get; set; }
		public List<Appointment> appointmentList { get; set; }
		public Bill bill { get; set; }
		public DateTime admittedDate { get; set; }
	}
}
