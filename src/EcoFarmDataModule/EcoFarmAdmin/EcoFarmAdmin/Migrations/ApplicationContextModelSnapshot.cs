﻿// <auto-generated />
using EcoFarmAdmin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcoFarmAdmin.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("EcoFarmAdmin.Domain.DevObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DevObjects", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.DevObjectOnLevelStartup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DevObjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LevelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DevObjectId");

                    b.HasIndex("LevelId");

                    b.ToTable("DevObjectsOnLevelsStartup", (string)null);
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DevObjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LevelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DevObjectId");

                    b.HasIndex("LevelId");

                    b.ToTable("Goals", (string)null);
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.InputProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FactoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("InputProducts", (string)null);
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Commentary")
                        .HasColumnType("TEXT");

                    b.Property<float>("Order")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Levels", (string)null);
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.OutputProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FactoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("OutputProducts", (string)null);
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Resources", (string)null);
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Building", b =>
                {
                    b.HasBaseType("EcoFarmAdmin.Domain.DevObject");

                    b.Property<int>("Coefficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResourceId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("ResourceId");

                    b.ToTable("Buildings", (string)null);
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Product", b =>
                {
                    b.HasBaseType("EcoFarmAdmin.Domain.DevObject");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Tree", b =>
                {
                    b.HasBaseType("EcoFarmAdmin.Domain.DevObject");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("ProductId");

                    b.ToTable("Trees", (string)null);
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Factory", b =>
                {
                    b.HasBaseType("EcoFarmAdmin.Domain.Building");

                    b.ToTable("Factories", (string)null);
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Generator", b =>
                {
                    b.HasBaseType("EcoFarmAdmin.Domain.Building");

                    b.ToTable("Generators", (string)null);
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.DevObjectOnLevelStartup", b =>
                {
                    b.HasOne("EcoFarmAdmin.Domain.DevObject", "DevObject")
                        .WithMany()
                        .HasForeignKey("DevObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcoFarmAdmin.Domain.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DevObject");

                    b.Navigation("Level");
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Goal", b =>
                {
                    b.HasOne("EcoFarmAdmin.Domain.DevObject", "DevObject")
                        .WithMany()
                        .HasForeignKey("DevObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcoFarmAdmin.Domain.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DevObject");

                    b.Navigation("Level");
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.InputProducts", b =>
                {
                    b.HasOne("EcoFarmAdmin.Domain.Factory", "Factory")
                        .WithMany()
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcoFarmAdmin.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factory");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.OutputProducts", b =>
                {
                    b.HasOne("EcoFarmAdmin.Domain.Factory", "Factory")
                        .WithMany()
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcoFarmAdmin.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factory");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Building", b =>
                {
                    b.HasOne("EcoFarmAdmin.Domain.DevObject", null)
                        .WithOne()
                        .HasForeignKey("EcoFarmAdmin.Domain.Building", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcoFarmAdmin.Domain.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Product", b =>
                {
                    b.HasOne("EcoFarmAdmin.Domain.DevObject", null)
                        .WithOne()
                        .HasForeignKey("EcoFarmAdmin.Domain.Product", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Tree", b =>
                {
                    b.HasOne("EcoFarmAdmin.Domain.DevObject", null)
                        .WithOne()
                        .HasForeignKey("EcoFarmAdmin.Domain.Tree", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcoFarmAdmin.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Factory", b =>
                {
                    b.HasOne("EcoFarmAdmin.Domain.Building", null)
                        .WithOne()
                        .HasForeignKey("EcoFarmAdmin.Domain.Factory", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EcoFarmAdmin.Domain.Generator", b =>
                {
                    b.HasOne("EcoFarmAdmin.Domain.Building", null)
                        .WithOne()
                        .HasForeignKey("EcoFarmAdmin.Domain.Generator", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
