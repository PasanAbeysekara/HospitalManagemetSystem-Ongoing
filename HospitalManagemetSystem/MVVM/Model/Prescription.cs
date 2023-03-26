using HospitalManagemetSystem.MVVM.Model.InsidePrescription;
using HospitalManagemetSystem.MVVM.Model.InsidePrescription.insideDrug;
using HospitalManagemetSystem.MVVM.Model.InsidePrescription.insideTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagemetSystem.MVVM.Model
{
	public class Prescription
	{
		public List<Dosage> dosageList { get; set; }
		public List<medicalTest> medicalTestList { get; set; }
		public DateTime prescribedDate { get; set; }
	}
}
