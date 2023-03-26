using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagemetSystem.MVVM.ViewModel
{
	public class NormalUserWindowVM:ObservableObject
	{
		public UserDashboardVM U_Dashboard_VM { get; set; }
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



		//[RelayCommand]
		//public void HomeViewCommand()
		//{
		//	CurrentView = HomeVM;
		//}

		//[RelayCommand]
		//public void DiscoveryViewCommand()
		//{
		//	CurrentView = DiscoveryVM;
		//}

		//public RelayCommand HomeViewCommand { get; set; }
		//public RelayCommand DiscoveryViewCommand { get; set; }




		public NormalUserWindowVM()
		{
			//HomeVM = new HomeViewModel();
			//DiscoveryVM = new DiscoveryViewModel();


			U_Dashboard_VM = new UserDashboardVM();
			CurrentView = U_Dashboard_VM;


			//HomeViewCommand = new RelayCommand( o => {
			//	CurrentView = HomeVM;
			//});

			//DiscoveryViewCommand = new RelayCommand(o => {
			//	CurrentView = DiscoveryVM;
			//});
		}
		
	}
}
