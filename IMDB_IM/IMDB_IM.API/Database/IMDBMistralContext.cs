using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace IMDB_IM.API.Database
{
    public partial class IMDBMistralContext : DbContext
    {
        public IMDBMistralContext()
        {
        }

        public IMDBMistralContext(DbContextOptions<IMDBMistralContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MoviesActor> MoviesActors { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\;Database=IMDBMistral;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_BIN");

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.LastName).HasMaxLength(80);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MoviesActor>(entity =>
            {
                entity.HasKey(e => e.MovieActorId)
                    .HasName("PK__MoviesAc__0F76A5E3F721A6F3");

                entity.Property(e => e.FkActorId).HasColumnName("FK_ActorId");

                entity.Property(e => e.FkMovieId).HasColumnName("FK_MovieId");

                entity.HasOne(d => d.FkActor)
                    .WithMany(p => p.MoviesActors)
                    .HasForeignKey(d => d.FkActorId)
                    .HasConstraintName("FK__MoviesAct__FK_Ac__3C69FB99");

                entity.HasOne(d => d.FkMovie)
                    .WithMany(p => p.MoviesActors)
                    .HasForeignKey(d => d.FkMovieId)
                    .HasConstraintName("FK__MoviesAct__FK_Mo__3B75D760");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.Property(e => e.FkMovieId).HasColumnName("FK_MovieId");

                entity.HasOne(d => d.FkMovie)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.FkMovieId)
                    .HasConstraintName("FK__Ratings__FK_Movi__3F466844");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
