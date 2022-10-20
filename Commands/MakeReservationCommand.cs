using Resevoom.Models;
using Resevoom.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resevoom.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly Hotel _hotel;
        private readonly MakeReservationViewModel _makeReservationViewModel;
        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel,Hotel hotel)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_makeReservationViewModel.UserName))
            {
                OnCanExecutedChanged();
            }
             
        }

        public override void Execute(object? parameter)
        {
            var reservation = new Reservation(
                new RoomID(_makeReservationViewModel.RoomNumber,_makeReservationViewModel.FloorNumber),
                _makeReservationViewModel.UserName,_makeReservationViewModel.StartDate, _makeReservationViewModel.EndDate);
            _hotel.MakeReservation(reservation);
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.UserName) && base.CanExecute(parameter);
        }
    }
}
