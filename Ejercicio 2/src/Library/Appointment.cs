using System;

namespace Library
{
    public class Appointment
    {
        public string Name { get; }
        public string Id {get; }
        public string PhoneNumber {get; }
        public string AppointmentPlace { get; }
        public string DoctorName { get; }

        public Appointment(string name, string id, string phoneNumber, string appointmentPlace, string doctorName)
        {
            Name = name;
            Id = id;
            PhoneNumber = phoneNumber;
            AppointmentPlace = appointmentPlace;
            DoctorName = doctorName;
        }
    }
}