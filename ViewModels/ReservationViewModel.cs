using Resevoom.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resevoom.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;
        public string RoomId => _reservation.RoomId?.ToString();
        public string UserName => _reservation.Username;

        public DateTime StartTime => _reservation.StartTime;
        public DateTime EndTime => _reservation.EndTime;    

        public ReservationViewModel(Reservation reservation)
        {
                _reservation = reservation;
        }

    }
}
