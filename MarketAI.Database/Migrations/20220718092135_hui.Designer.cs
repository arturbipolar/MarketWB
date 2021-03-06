// <auto-generated />
using System;
using MarketAI.API.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarketAI.Database.Migrations
{
    [DbContext(typeof(APIDBContext))]
    [Migration("20220718092135_hui")]
    partial class hui
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.16");


            //modelBuilder.Entity("MarketAI.API.Models.UserModel", b =>
            //    {
            //        b.Property<int>("Id")
            //            .ValueGeneratedOnAdd()
            //            .HasColumnType("int");

            //        b.Property<string>("ActivatedPromocode")
            //            .HasColumnType("longtext");

            //        b.Property<string>("Activity")
            //            .HasColumnType("longtext");

            //        b.Property<string>("AvatarPath")
            //            .HasColumnType("longtext");

            //        b.Property<string>("Email")
            //            .HasColumnType("longtext");

            //        b.Property<bool>("IsOnline")
            //            .HasColumnType("tinyint(1)");

            //        b.Property<string>("Name")
            //            .HasColumnType("longtext");

            //        b.Property<string>("Password")
            //            .HasColumnType("longtext");

            //        b.Property<string>("Phone")
            //            .HasColumnType("longtext");

            //        b.Property<decimal>("ReferralBalance")
            //            .HasColumnType("decimal(65,30)");

            //        b.Property<string>("ReferralCode")
            //            .HasColumnType("longtext");

            //        b.Property<DateTime>("SubscriptionBefore")
            //            .HasColumnType("datetime(6)");

            //        b.Property<string>("Surname")
            //            .HasColumnType("longtext");

            //        b.Property<int?>("UserDataId")
            //            .HasColumnType("int");

            //        b.Property<int>("UserRole")
            //            .HasColumnType("int");

            //        b.Property<bool>("WasPromocodeActivated")
            //            .HasColumnType("tinyint(1)");

            //        b.Property<bool>("WasTrialActivated")
            //            .HasColumnType("tinyint(1)");

            //        b.HasKey("Id");

            //        b.HasIndex("UserDataId");

            //        b.ToTable("Users");
            //    });


            modelBuilder.Entity("MarketAI.Database.Models.WithdrawRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("WithdrawRequests");
                });

      

            modelBuilder.Entity("MarketAI.Database.Models.WithdrawRequest", b =>
                {
                    b.HasOne("MarketAI.API.Models.UserModel", "User")
                        .WithMany("WithdrawRequests")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

          

            modelBuilder.Entity("MarketAI.API.Models.UserModel", b =>
                {

                    b.Navigation("WithdrawRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
