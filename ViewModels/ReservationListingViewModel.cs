using Resevoom.Commands;
using Resevoom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Resevoom.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public ICommand MakeReservationCommand { get; }
 
        public ReservationListingViewModel()
        {
                _reservations = new ObservableCollection<ReservationViewModel>();

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "MrUser", DateTime.Now, DateTime.Now.AddDays(5))));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 3), "MrUser1", DateTime.Now, DateTime.Now.AddDays(5))));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 4), "MrUser2", DateTime.Now, DateTime.Now.AddDays(5))));

            MakeReservationCommand = new NavigateCommand();
        }

        public IEnumerable<ReservationViewModel> Reservations => _reservations;
    }
}
