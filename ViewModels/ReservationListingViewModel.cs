using Resevoom.Commands;
using Resevoom.Models;
using Resevoom.Stores;
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
        private readonly Hotel _hotel;

        public ICommand MakeReservationCommand { get; }
 
        public ReservationListingViewModel(Hotel hotel, Services.NavigationService makeReservationNavigationService)
        {
            _hotel = hotel;
            _reservations = new ObservableCollection<ReservationViewModel>();

            //_reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "MrUser", DateTime.Now, DateTime.Now.AddDays(5))));
            //_reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 3), "MrUser1", DateTime.Now, DateTime.Now.AddDays(5))));
            //_reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 4), "MrUser2", DateTime.Now, DateTime.Now.AddDays(5))));

            MakeReservationCommand = new NavigateCommand(makeReservationNavigationService);
            UpdateReservations();
        }
        private void UpdateReservations()
        {
            _reservations.Clear();
            foreach(var reservation in _hotel.GetReservations())
            {
                var reservationViewModel = new ReservationViewModel(reservation); 
                _reservations.Add(reservationViewModel);
            }
        }

        public IEnumerable<ReservationViewModel> Reservations => _reservations;
    }
}//https://www.youtube.com/watch?v=bBoYHl3pLEo&t=613s
