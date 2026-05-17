using Microsoft.EntityFrameworkCore;
using MultiClinicAPI.Models;

namespace MultiClinicAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(
        DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Medico> Medicos { get; set; }

    public DbSet<Paciente> Pacientes { get; set; }

    public DbSet<Especialidade> Especialidades { get; set; }

    public DbSet<Agendamento> Agendamentos { get; set; }

    public DbSet<Prontuario> Prontuarios { get; set; }
}