using System;

namespace Library
{
    public class AppointmentScheduler
    {
        public static string ScheduleAppointment(Appointment appointment)
        {
            if (!AppointmentValidator.ValidateAppointmentData(appointment))
            {
                return "No se puede programar la cita. Porfavor proporcione todos los datos requeridos";
            }

            return "Cita programada exitosamente";
        }
    }
}