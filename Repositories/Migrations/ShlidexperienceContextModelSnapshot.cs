﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.Data;

namespace Repositories.Migrations
{
    [DbContext(typeof(ShlidexperienceContext))]
    partial class ShlidexperienceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repositories.Data.CycleEmployeeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CycleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CycleId");

                    b.HasIndex("UserId");

                    b.ToTable("CycleEmployees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f1b9e3e6-c632-45b0-8afd-08574acff7a7"),
                            CycleId = new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"),
                            UserId = new Guid("42054507-aa28-4355-bd34-3864bba4dcc5")
                        },
                        new
                        {
                            Id = new Guid("81807042-fb9f-4189-9a08-9c09c907607c"),
                            CycleId = new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"),
                            UserId = new Guid("ae70e283-d0d4-4469-a5b4-d558970a2824")
                        },
                        new
                        {
                            Id = new Guid("784ed426-44b7-4491-a4c2-3c1a2d7e282c"),
                            CycleId = new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"),
                            UserId = new Guid("6e872f74-a484-4612-9834-449c10a41465")
                        },
                        new
                        {
                            Id = new Guid("b99ca52a-f8e8-426f-a1b6-cbcc7b49c4c2"),
                            CycleId = new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"),
                            UserId = new Guid("cccb1389-d66c-48b6-99b5-d2c13a4ae38f")
                        },
                        new
                        {
                            Id = new Guid("dd76dfb1-727a-44a9-bd89-407dd9613fb9"),
                            CycleId = new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"),
                            UserId = new Guid("e7570a77-53e5-461b-b7ab-cf2b74ae66fd")
                        },
                        new
                        {
                            Id = new Guid("6d4bac0c-e63e-479c-ac0f-901d0db9343d"),
                            CycleId = new Guid("f0e4f1ad-bd88-4612-9ede-2b605c18b18b"),
                            UserId = new Guid("258df23e-4b47-4947-bc67-6a618d99de5c")
                        },
                        new
                        {
                            Id = new Guid("7273f6f3-b800-422c-a9a2-bd016740d076"),
                            CycleId = new Guid("f0e4f1ad-bd88-4612-9ede-2b605c18b18b"),
                            UserId = new Guid("87ef3eb0-b52b-4e03-af21-14cd8bf7c90e")
                        },
                        new
                        {
                            Id = new Guid("24695590-d278-4920-a5fa-3c51ae992d87"),
                            CycleId = new Guid("f0e4f1ad-bd88-4612-9ede-2b605c18b18b"),
                            UserId = new Guid("ae70e283-d0d4-4469-a5b4-d558970a2824")
                        },
                        new
                        {
                            Id = new Guid("f8ec40a6-715a-435c-b792-e7329cab4e39"),
                            CycleId = new Guid("b902950e-1690-4f89-919d-898670c64780"),
                            UserId = new Guid("6e872f74-a484-4612-9834-449c10a41465")
                        },
                        new
                        {
                            Id = new Guid("ca997a5f-f1b4-40f5-940a-7f748446d2d8"),
                            CycleId = new Guid("b902950e-1690-4f89-919d-898670c64780"),
                            UserId = new Guid("258df23e-4b47-4947-bc67-6a618d99de5c")
                        },
                        new
                        {
                            Id = new Guid("3722d0fc-df76-494e-8327-13a35e4677ff"),
                            CycleId = new Guid("b902950e-1690-4f89-919d-898670c64780"),
                            UserId = new Guid("e7570a77-53e5-461b-b7ab-cf2b74ae66fd")
                        });
                });

            modelBuilder.Entity("Repositories.Data.CycleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Cycle");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f980fbda-2d7e-43c2-84cd-5ae162a63912"),
                            Name = "name-0"
                        },
                        new
                        {
                            Id = new Guid("f0e4f1ad-bd88-4612-9ede-2b605c18b18b"),
                            Name = "name-1"
                        },
                        new
                        {
                            Id = new Guid("b902950e-1690-4f89-919d-898670c64780"),
                            Name = "name-2"
                        },
                        new
                        {
                            Id = new Guid("1fb7db84-0dcf-4b3a-90db-509db3a17c7b"),
                            Name = "name-3"
                        },
                        new
                        {
                            Id = new Guid("37767d47-f4f2-4c9d-9435-4604a23295c2"),
                            Name = "name-4"
                        },
                        new
                        {
                            Id = new Guid("dbfb5b3c-ff5c-4fc8-a3e7-1ba2a68a80a7"),
                            Name = "name-5"
                        },
                        new
                        {
                            Id = new Guid("ea1b0584-ab9e-448e-84b9-58448833d489"),
                            Name = "name-6"
                        },
                        new
                        {
                            Id = new Guid("8bbd2fc8-dd50-4642-b276-7c7ba044011b"),
                            Name = "name-7"
                        },
                        new
                        {
                            Id = new Guid("5b1a103c-e83a-4337-ab98-b7929a30462d"),
                            Name = "name-8"
                        },
                        new
                        {
                            Id = new Guid("1549b876-e789-4de9-be1d-6315a716a018"),
                            Name = "name-9"
                        });
                });

            modelBuilder.Entity("Repositories.Data.CycleReviewerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CycleEmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CycleEmployeeId");

                    b.HasIndex("UserId");

                    b.ToTable("CycleReviewer");

                    b.HasData(
                        new
                        {
                            Id = new Guid("197e04c6-bd0d-407e-aa5c-bf0ec86a6e1b"),
                            CycleEmployeeId = new Guid("f1b9e3e6-c632-45b0-8afd-08574acff7a7"),
                            UserId = new Guid("42054507-aa28-4355-bd34-3864bba4dcc5")
                        });
                });

            modelBuilder.Entity("Repositories.Data.UserEntity", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("42054507-aa28-4355-bd34-3864bba4dcc5"),
                            Email = "0@gmail.com",
                            IsDeleted = true
                        },
                        new
                        {
                            UserId = new Guid("ae70e283-d0d4-4469-a5b4-d558970a2824"),
                            Email = "1@gmail.com",
                            IsDeleted = false
                        },
                        new
                        {
                            UserId = new Guid("6e872f74-a484-4612-9834-449c10a41465"),
                            Email = "2@gmail.com",
                            IsDeleted = true
                        },
                        new
                        {
                            UserId = new Guid("cccb1389-d66c-48b6-99b5-d2c13a4ae38f"),
                            Email = "3@gmail.com",
                            IsDeleted = false
                        },
                        new
                        {
                            UserId = new Guid("e7570a77-53e5-461b-b7ab-cf2b74ae66fd"),
                            Email = "4@gmail.com",
                            IsDeleted = true
                        },
                        new
                        {
                            UserId = new Guid("48e76bb4-faef-45ec-af10-d2504c849d10"),
                            Email = "5@gmail.com",
                            IsDeleted = false
                        },
                        new
                        {
                            UserId = new Guid("258df23e-4b47-4947-bc67-6a618d99de5c"),
                            Email = "6@gmail.com",
                            IsDeleted = true
                        },
                        new
                        {
                            UserId = new Guid("87ef3eb0-b52b-4e03-af21-14cd8bf7c90e"),
                            Email = "7@gmail.com",
                            IsDeleted = false
                        },
                        new
                        {
                            UserId = new Guid("d04da23c-4a4c-4228-952a-93f4088597d1"),
                            Email = "8@gmail.com",
                            IsDeleted = true
                        },
                        new
                        {
                            UserId = new Guid("ce9de159-d7e4-4464-89d7-af37a6feb827"),
                            Email = "9@gmail.com",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Repositories.Data.CycleEmployeeEntity", b =>
                {
                    b.HasOne("Repositories.Data.CycleEntity", "Cycle")
                        .WithMany("Employees")
                        .HasForeignKey("CycleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositories.Data.UserEntity", "User")
                        .WithMany("CycleEmployees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Repositories.Data.CycleReviewerEntity", b =>
                {
                    b.HasOne("Repositories.Data.CycleEmployeeEntity", "CycleEmployee")
                        .WithMany()
                        .HasForeignKey("CycleEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repositories.Data.UserEntity", "User")
                        .WithMany("CycleReviewers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
