using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HospitalManagemetSystem.MVVM.ViewModel
{
	public class NormalUserWindowVM : ObservableObject
	{
		public UserDashboardVM U_Dashboard_VM { get; set; }
		public UserDashboardVM U_Appointments_VM { get; set; }
		public UserDashboardVM U_Billing_VM { get; set; }
		public UserDashboardVM U_Patients_VM { get; set; }
		public UserDashboardVM U_Prescriptions_VM { get; set; }
		//public DiscoveryViewModel DiscoveryVM { get; set; }

		// temp setter for maintainting current state
		private object _currentView;

		public object CurrentView
		{
			get { return _currentView; }
			set
			{
				_currentView = value;
				OnPropertyChanged();
			}
		}


		[RelayCommand]
		public void UserDashboardView()
		{
			CurrentView = U_Appointments_VM;
		}
		[RelayCommand]
		public void UserAppointmentsView()
		{
			CurrentView = U_Appointments_VM;
		}
		[RelayCommand]
		public void UserBillingView()
		{
			CurrentView = U_Appointments_VM;
		}
		[RelayCommand]
		public void UserPatientsView()
		{
			CurrentView = U_Appointments_VM;
		}
		
		[RelayCommand]
		public void UserPrescriptionsView()
		{
			CurrentView = U_Prescriptions_VM;
		}

		//[RelayCommand]
		//public void DiscoveryViewCommand()
		//{
		//	CurrentView = DiscoveryVM;
		//}

		//public RelayCommand HomeViewCommand { get; set; }
		//public RelayCommand DiscoveryViewCommand { get; set; }




		public NormalUserWindowVM()
		{

			U_Dashboard_VM = new UserDashboardVM();
			CurrentView = U_Dashboard_VM;

		}

		
	}
}
