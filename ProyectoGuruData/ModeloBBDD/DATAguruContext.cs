using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGuruData.ModeloBBDD
{
    public partial class DATAguruContext : DbContext
    {
        public DATAguruContext()
        {
        }

        public DATAguruContext(DbContextOptions<DATAguruContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Reservas> Reservas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database= DATAguru;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actividades>(entity =>
            {
                entity.HasKey(e => e.IdActividad)
                    .HasName("PK__Activida__327F9BED3D4899AC");

                entity.Property(e => e.IdActividad)
                    .HasColumnName("idActividad")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.diaSemana)
                    .HasColumnName("diaSemana")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hora).HasColumnName("hora");

                entity.Property(e => e.Plazas).HasColumnName("plazas");

                entity.Property(e => e.tipoActividad)
                    .HasColumnName("tipoActividad")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Nif)
                    .HasName("PK__Clientes__DF97D0F378764720");

                entity.Property(e => e.Nif)
                    .HasColumnName("nif")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<Reservas>(entity =>
            {
                entity.HasKey(e => e.IdReserva)
                    .HasName("PK__Reservas__94D104C85F139555");

                entity.Property(e => e.IdReserva)
                    .HasColumnName("idReserva")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActividadFk)
                    .HasColumnName("actividad_fk")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteFk)
                    .HasColumnName("cliente_fk")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoReserva)
                    .HasColumnName("estadoReserva")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraReserva)
                    .HasColumnName("fecha_hora_reserva")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReservaXcliente).HasColumnName("reservaXcliente");

                entity.HasOne(d => d.ActividadFkNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.ActividadFk)
                    .HasConstraintName("FK__Reservas__activi__60A75C0F");

                entity.HasOne(d => d.ClienteFkNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.ClienteFk)
                    .HasConstraintName("FK__Reservas__client__5FB337D6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
