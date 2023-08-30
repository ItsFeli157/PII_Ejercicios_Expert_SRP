using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Appointment appointment1 = new Appointment("Steven Jhonson", "986782342", "5555-555-555", "Wall Street", "Armand");
            string appointmentResult = AppointmentScheduler.ScheduleAppointment(appointment1);
            Console.WriteLine(appointmentResult);

            Appointment appointment2 = new Appointment("Ralf Manson", "", "5555-555-555", "Queen Street", "");
            string appointmentResult2 = AppointmentScheduler.ScheduleAppointment(appointment2);
            Console.WriteLine(appointmentResult2);
        }
    }
}
