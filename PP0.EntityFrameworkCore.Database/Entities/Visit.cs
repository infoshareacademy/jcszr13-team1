﻿using PP0.EntityFrameworkCore.Database.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PP0.EntityFrameworkCore.Database.Entities
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public VisitType Type { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public string Description { get; set; }
        public string Recomendations { get; set; }
        public string Referrals { get; set; }
        public string Prescriptions { get; set; }

        public Visit()
        {

        }

        public Visit(int id, DateTime date, VisitType type, string doctorName, string patientName, string description, string recomendations, string referrals, string prescriptions)
        {
            Id = id;
            Date = date;
            Type = type;
            DoctorName = doctorName;
            PatientName = patientName;
            Description = description;
            Recomendations = recomendations;
            Referrals = referrals;
            Prescriptions = prescriptions;
        }

        public void DisplayVisit()
        {
            Console.WriteLine("Visit Details : ");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Type : {Type}");
            Console.WriteLine($"Doctor name: {DoctorName}");
            Console.WriteLine($"Patient name: {PatientName}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Recomendations: {Recomendations}");
            Console.WriteLine($"Referrals: {Referrals}");
            Console.WriteLine($"Prescriptions: {Prescriptions}");
        }
    }


}
