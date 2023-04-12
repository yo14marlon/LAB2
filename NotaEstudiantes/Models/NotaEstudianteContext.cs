using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NotaEstudiantes.Models;

public partial class NotaEstudianteContext : DbContext
{
    public NotaEstudianteContext()
    {
    }

    public NotaEstudianteContext(DbContextOptions<NotaEstudianteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Notum> Nota { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-QT06L4V\\SQLEXPRESS ;Database= NotaEstudiante;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Notum>(entity =>
        {
            entity.HasKey(e => e.IdNotas).HasName("PK__Nota__7C2D49F0A8EF1D36");

            entity.Property(e => e.IdNotas).HasColumnName("idNotas");
            entity.Property(e => e.Lab1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Lab2).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Lab3).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NombreEstudiante)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Par1).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Par2).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Par3).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Resultado).HasColumnType("decimal(18, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
