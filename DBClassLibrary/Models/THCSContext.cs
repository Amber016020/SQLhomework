using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBClassLibrary.Models
{
    public partial class THCSContext : DbContext
    {
        public THCSContext()
        {
        }

        public THCSContext(DbContextOptions<THCSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adopt> Adopt { get; set; }
        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<AnimalDetal> AnimalDetal { get; set; }
        public virtual DbSet<AnimalHeathe> AnimalHeathe { get; set; }
        public virtual DbSet<AnimalPlace> AnimalPlace { get; set; }
        public virtual DbSet<AnimalTime> AnimalTime { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Cat> Cat { get; set; }
        public virtual DbSet<CatKind> CatKind { get; set; }
        public virtual DbSet<Dog> Dog { get; set; }
        public virtual DbSet<DogKind> DogKind { get; set; }
        public virtual DbSet<Dognew> Dognew { get; set; }
        public virtual DbSet<Elseanimal> Elseanimal { get; set; }
        public virtual DbSet<ElseanimalKind> ElseanimalKind { get; set; }
        public virtual DbSet<Loss> Loss { get; set; }
        public virtual DbSet<MouceKind> MouceKind { get; set; }
        public virtual DbSet<Mouse> Mouse { get; set; }
        public virtual DbSet<Robbit> Robbit { get; set; }
        public virtual DbSet<RobbitKind> RobbitKind { get; set; }
        public virtual DbSet<Shelter> Shelter { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<User0> User0 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adopt>(entity =>
            {
                entity.HasKey(e => e.AnimalId);

                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Animal>(entity =>
            {
                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlbumFile)
                    .HasColumnName("album_file")
                    .HasMaxLength(100);

                entity.Property(e => e.AnimalFoundplace)
                    .HasColumnName("animal_foundplace")
                    .HasMaxLength(50);

                entity.Property(e => e.AnimalKind)
                    .HasColumnName("animal_kind")
                    .HasMaxLength(50);

                entity.Property(e => e.AnimalShelterPkid).HasColumnName("animal_shelter_pkid");

                entity.Property(e => e.AnimalStatus)
                    .HasColumnName("animal_status")
                    .HasMaxLength(50);

                entity.Property(e => e.AnimalSubid)
                    .IsRequired()
                    .HasColumnName("animal_subid")
                    .HasMaxLength(50);

                entity.Property(e => e.AnimalUpdate).HasColumnName("animal_update");
            });

            modelBuilder.Entity<AnimalDetal>(entity =>
            {
                entity.HasKey(e => e.AnimalId);

                entity.ToTable("Animal_detal");

                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnimalAge)
                    .HasColumnName("animal_age")
                    .HasMaxLength(50);

                entity.Property(e => e.AnimalBodytype)
                    .HasColumnName("animal_bodytype")
                    .HasMaxLength(50);

                entity.Property(e => e.AnimalColour)
                    .HasColumnName("animal_colour")
                    .HasMaxLength(50);

                entity.Property(e => e.AnimalSex)
                    .HasColumnName("animal_sex")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AnimalHeathe>(entity =>
            {
                entity.HasKey(e => e.AnimalId);

                entity.ToTable("Animal_heathe");

                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnimalBacterin)
                    .IsRequired()
                    .HasColumnName("animal_bacterin")
                    .HasMaxLength(50);

                entity.Property(e => e.AnimalCaption)
                    .HasColumnName("animal_caption")
                    .HasMaxLength(250);

                entity.Property(e => e.AnimalRemark)
                    .HasColumnName("animal_remark")
                    .HasMaxLength(250);

                entity.Property(e => e.AnimalSterilization)
                    .IsRequired()
                    .HasColumnName("animal_sterilization")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AnimalPlace>(entity =>
            {
                entity.HasKey(e => e.AnimalId);

                entity.ToTable("Animal_place");

                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShelterId).HasColumnName("shelter_id");
            });

            modelBuilder.Entity<AnimalTime>(entity =>
            {
                entity.HasKey(e => e.AnimalId);

                entity.ToTable("Animal_time");

                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnimalCloseddate).HasColumnName("animal_closeddate");

                entity.Property(e => e.AnimalCreatetime).HasColumnName("animal_createtime");

                entity.Property(e => e.AnimalOpendate)
                    .HasColumnName("animal_opendate")
                    .HasMaxLength(50);

                entity.Property(e => e.AnimalUpdate).HasColumnName("animal_update");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.AreaPkid);

                entity.Property(e => e.AreaPkid)
                    .HasColumnName("area_pkid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasColumnName("area_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Cat>(entity =>
            {
                entity.ToTable("cat");

                entity.Property(e => e.CatId)
                    .HasColumnName("cat_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CatFeature)
                    .IsRequired()
                    .HasColumnName("cat_feature")
                    .HasMaxLength(200);

                entity.Property(e => e.CatFocus)
                    .IsRequired()
                    .HasColumnName("cat_focus")
                    .HasMaxLength(50);

                entity.Property(e => e.CatFocusIssues)
                    .IsRequired()
                    .HasColumnName("cat_focus_issues")
                    .HasMaxLength(250);

                entity.Property(e => e.CatHair)
                    .IsRequired()
                    .HasColumnName("cat_hair")
                    .HasMaxLength(50);

                entity.Property(e => e.CatKind)
                    .IsRequired()
                    .HasColumnName("cat_kind")
                    .HasMaxLength(50);

                entity.Property(e => e.CatPersonality)
                    .IsRequired()
                    .HasColumnName("cat_personality")
                    .HasMaxLength(200);

                entity.Property(e => e.CatPicture)
                    .IsRequired()
                    .HasColumnName("cat_picture")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<CatKind>(entity =>
            {
                entity.HasKey(e => e.AnimalId);

                entity.ToTable("Cat_kind");

                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CatId).HasColumnName("cat_id");
            });

            modelBuilder.Entity<Dog>(entity =>
            {
                entity.ToTable("dog");

                entity.Property(e => e.DogId)
                    .HasColumnName("dog_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DogFeature)
                    .HasColumnName("dog_feature")
                    .HasMaxLength(200);

                entity.Property(e => e.DogFeature1)
                    .IsRequired()
                    .HasColumnName("dog_feature1")
                    .HasMaxLength(50);

                entity.Property(e => e.DogFeed)
                    .IsRequired()
                    .HasColumnName("dog_feed")
                    .HasMaxLength(350);

                entity.Property(e => e.DogKind)
                    .IsRequired()
                    .HasColumnName("dog_kind")
                    .HasMaxLength(50);

                entity.Property(e => e.DogPersonality)
                    .IsRequired()
                    .HasColumnName("dog_personality")
                    .HasMaxLength(100);

                entity.Property(e => e.DogPicture)
                    .IsRequired()
                    .HasColumnName("dog_picture")
                    .HasMaxLength(50);

                entity.Property(e => e.DogType)
                    .IsRequired()
                    .HasColumnName("dog_type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DogKind>(entity =>
            {
                entity.HasKey(e => e.AnimalId);

                entity.ToTable("Dog_kind");

                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DogId).HasColumnName("dog_id");
            });

            modelBuilder.Entity<Dognew>(entity =>
            {
                entity.HasKey(e => e.DogId);

                entity.ToTable("dognew");

                entity.Property(e => e.DogId)
                    .HasColumnName("dog_id")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DogFeature)
                    .HasColumnName("dog_feature")
                    .HasMaxLength(200);

                entity.Property(e => e.DogFeature1)
                    .IsRequired()
                    .HasColumnName("dog_feature1")
                    .HasMaxLength(50);

                entity.Property(e => e.DogFeed)
                    .IsRequired()
                    .HasColumnName("dog_feed")
                    .HasMaxLength(350);

                entity.Property(e => e.DogKind)
                    .IsRequired()
                    .HasColumnName("dog_kind")
                    .HasMaxLength(50);

                entity.Property(e => e.DogPersonality)
                    .IsRequired()
                    .HasColumnName("dog_personality")
                    .HasMaxLength(100);

                entity.Property(e => e.DogPicture)
                    .IsRequired()
                    .HasColumnName("dog_picture")
                    .HasMaxLength(50);

                entity.Property(e => e.DogType)
                    .IsRequired()
                    .HasColumnName("dog_type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Elseanimal>(entity =>
            {
                entity.Property(e => e.ElseanimalId)
                    .HasColumnName("elseanimal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ElseanimalKind)
                    .IsRequired()
                    .HasColumnName("elseanimal_kind")
                    .HasMaxLength(50);

                entity.Property(e => e.ElseanimalName)
                    .IsRequired()
                    .HasColumnName("elseanimal_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ElseanimalKind>(entity =>
            {
                entity.HasKey(e => e.AnimalId);

                entity.ToTable("Elseanimal_kind");

                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ElseId).HasColumnName("else_id");
            });

            modelBuilder.Entity<Loss>(entity =>
            {
                entity.HasKey(e => e.KeyNo);

                entity.Property(e => e.KeyNo).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50);

                entity.Property(e => e.品種)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.外觀)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.寵物別)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.寵物名).HasMaxLength(50);

                entity.Property(e => e.性別)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.晶片號碼)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.毛色).HasMaxLength(50);

                entity.Property(e => e.特徵).HasMaxLength(50);

                entity.Property(e => e.連絡電話)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.遺失地點).HasMaxLength(100);

                entity.Property(e => e.飼主姓名)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MouceKind>(entity =>
            {
                entity.HasKey(e => e.AnimalId);

                entity.ToTable("Mouce_kind");

                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MouceId).HasColumnName("mouce_id");
            });

            modelBuilder.Entity<Mouse>(entity =>
            {
                entity.ToTable("mouse");

                entity.Property(e => e.MouseId)
                    .HasColumnName("mouse_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MouseName)
                    .IsRequired()
                    .HasColumnName("mouse_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Robbit>(entity =>
            {
                entity.HasKey(e => e.RobitId);

                entity.Property(e => e.RobitId)
                    .HasColumnName("robit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RobbitBodytype)
                    .HasColumnName("robbit_bodytype")
                    .HasMaxLength(200);

                entity.Property(e => e.RobbitDegree)
                    .HasColumnName("robbit_degree")
                    .HasMaxLength(50);

                entity.Property(e => e.RobbitFeed)
                    .HasColumnName("robbit_feed")
                    .HasMaxLength(100);

                entity.Property(e => e.RobbitFeedplace)
                    .HasColumnName("robbit_feedplace")
                    .HasMaxLength(150);

                entity.Property(e => e.RobbitName)
                    .IsRequired()
                    .HasColumnName("robbit_name")
                    .HasMaxLength(50);

                entity.Property(e => e.RobbitPersonality)
                    .HasColumnName("robbit_personality")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<RobbitKind>(entity =>
            {
                entity.HasKey(e => e.AnimalId);

                entity.ToTable("Robbit_kind");

                entity.Property(e => e.AnimalId)
                    .HasColumnName("animal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RobbitId).HasColumnName("robbit_id");
            });

            modelBuilder.Entity<Shelter>(entity =>
            {
                entity.HasKey(e => e.ShelterPkid);

                entity.Property(e => e.ShelterPkid)
                    .HasColumnName("shelter_pkid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaPkid).HasColumnName("area_pkid");

                entity.Property(e => e.ShelterAddress)
                    .IsRequired()
                    .HasColumnName("shelter_address")
                    .HasMaxLength(50);

                entity.Property(e => e.ShelterPlace)
                    .IsRequired()
                    .HasColumnName("shelter_place")
                    .HasMaxLength(50);

                entity.Property(e => e.ShelterTel)
                    .IsRequired()
                    .HasColumnName("shelter_tel")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserAddress)
                    .IsRequired()
                    .HasColumnName("user_address")
                    .HasMaxLength(100);

                entity.Property(e => e.UserBirthday).HasColumnName("user_birthday");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("user_email")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("user_password")
                    .HasMaxLength(20);

                entity.Property(e => e.UserSex)
                    .IsRequired()
                    .HasColumnName("user_sex")
                    .HasMaxLength(50);

                entity.Property(e => e.UserTel)
                    .IsRequired()
                    .HasColumnName("user_tel")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<User0>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserAddress)
                    .HasColumnName("user_address")
                    .HasMaxLength(50);

                entity.Property(e => e.UserBirthday)
                    .HasColumnName("user_birthday")
                    .HasColumnType("date");

                entity.Property(e => e.UserEmail)
                    .HasColumnName("user_email")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("user_password")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSex)
                    .HasColumnName("user_sex")
                    .HasMaxLength(50);

                entity.Property(e => e.UserTel)
                    .HasColumnName("user_tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
