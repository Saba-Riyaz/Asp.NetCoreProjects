using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TravelAgencySystem.Controllers;

namespace TravelAgencySystem.Models
{
    public class TravelAgencyDBContext : DbContext
    {
        
    
        public TravelAgencyDBContext(DbContextOptions<TravelAgencyDBContext> options) : base(options)
        {
        }

        public DbSet<CustomerEntity> tblCustomer { get; set; }

        public DbSet<CabsEntity> tblCabs  { get; set; }

        public DbSet<FlightBookingEntity > tblFlightBooking  { get; set; }

        public DbSet< PaymentsEntity > tblPayments  { get; set; }

        public DbSet<HotelBookingEntity > tblHotelBooking  { get; set; }

        public DbSet<TourGuideEntity> tblTourGuide { get; set; }

        public DbSet<PakagesEntity> tblPakages { get; set; }

        public DbSet<ReservationEntity> tblReservation { get; set; }
    }
}

