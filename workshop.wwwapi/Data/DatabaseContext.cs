using Microsoft.EntityFrameworkCore;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Data
{
    public class DatabaseContext : DbContext
    {
        private string _connectionString;

        public DatabaseContext()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            this.Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .HasKey(c => new { c.PatientId, c.DoctorId});

            Patient p = new Patient() { Id=1, FullName = "Nigel" };
            Doctor d = new Doctor() { Id=1,FullName = "Carlo" };
            Appointment a = new Appointment() { Booking = DateTime.UtcNow, DoctorId = 1, PatientId = 1 };
            modelBuilder.Entity<Patient>().HasData(p);
            modelBuilder.Entity<Doctor>().HasData(d);
            modelBuilder.Entity<Appointment>().HasData(a);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase(databaseName: "Database");
            optionsBuilder.UseNpgsql(_connectionString);
        }


        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
