using System;

namespace Library
{
    public class AppointmentValidator
    {
        public static bool ValidateAppointmentData(Appointment appointment)
        {
            return !string.IsNullOrEmpty(appointment.Name) &&
                   !string.IsNullOrEmpty(appointment.Id) &&
                   !string.IsNullOrEmpty(appointment.PhoneNumber) &&
                   !string.IsNullOrEmpty(appointment.AppointmentPlace) &&
                   !string.IsNullOrEmpty(appointment.DoctorName);
        }
    }
}

