﻿// <auto-generated />
using System;
using MarketAI.API.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarketAI.Database.Migrations
{
    [DbContext(typeof(APIDBContext))]
    partial class APIDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("MarketAI.API.Models.PostModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Caption")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImgURL")
                        .HasColumnType("longtext");

                    b.Property<bool>("PublishAfter")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("PublishAfterDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Tags")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("MarketAI.API.Models.PromocodeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<double>("Percent")
                        .HasColumnType("double");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Promocodes");
                });

            modelBuilder.Entity("MarketAI.API.Models.SMSCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SMSCodes");
                });

            modelBuilder.Entity("MarketAI.API.Models.SelfCostModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("DeliveryToWbStockCost")
                        .HasColumnType("double");

                    b.Property<double>("DeliveryToYourStockCost")
                        .HasColumnType("double");

                    b.Property<double>("FFServicesCost")
                        .HasColumnType("double");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<double>("PackagingCost")
                        .HasColumnType("double");

                    b.Property<double>("PhotographCost")
                        .HasColumnType("double");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<double>("PurchaseCost")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("SelfCosts");
                });

            modelBuilder.Entity("MarketAI.API.Models.Stats.AuthStatsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AuthStatsModels");
                });

            modelBuilder.Entity("MarketAI.API.Models.Stats.PaymentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<double>("Sum")
                        .HasColumnType("double");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PaymentModels");
                });

            modelBuilder.Entity("MarketAI.API.Models.SubscriptionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<bool>("IsTrial")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("MarketAI.API.Models.TagModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MarketAI.API.Models.TicketMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AttachmentPath")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int?>("SentById")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("SentById");

                    b.ToTable("TicketMessages");
                });

            modelBuilder.Entity("MarketAI.API.Models.TicketModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AttachmentPath")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("OpenedById")
                        .HasColumnType("int");

                    b.Property<string>("Topic")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("OpenedById");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("MarketAI.API.Models.UserData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("SelectedPeriodFrom")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("SelectedPeriodTo")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SelectedWBBrand")
                        .HasColumnType("longtext");

                    b.Property<string>("SelectedWBCategory")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UserDatas");
                });

            modelBuilder.Entity("MarketAI.API.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ActivatedPromocode")
                        .HasColumnType("longtext");

                    b.Property<string>("Activity")
                        .HasColumnType("longtext");

                    b.Property<string>("AvatarPath")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<decimal>("ReferralBalance")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ReferralCode")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SubscriptionBefore")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Surname")
                        .HasColumnType("longtext");

                    b.Property<int?>("UserDataId")
                        .HasColumnType("int");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.Property<bool>("WasPromocodeActivated")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("WasTrialActivated")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("UserDataId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MarketAI.API.Models.WB.AvailableWBBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("APIKey")
                        .HasColumnType("longtext");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AvailableWBBrands");
                });

            modelBuilder.Entity("MarketAI.API.Models.WB.AvailableWBCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("APIKey")
                        .HasColumnType("longtext");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AvailableWBCategories");
                });

            modelBuilder.Entity("MarketAI.API.Models.WB.ExtraExpenseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<string>("ClearingCentre")
                        .HasColumnType("longtext");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PaymentDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("PaymentReceiver")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Period")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Sum")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("ExtraExpenses");
                });

            modelBuilder.Entity("MarketAI.API.Models.WBAPITokenModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("APIKey")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("CreatedFirstTime")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsSelected")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int?>("UserDataId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("UserDataId");

                    b.ToTable("WBAPITokens");
                });

            modelBuilder.Entity("MarketAI.Database.Models.GlobalSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MinimalWithdrawSum")
                        .HasColumnType("int");

                    b.Property<int>("NewRefDaysGift")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GlobalSettings");
                });

            modelBuilder.Entity("MarketAI.Database.Models.ReferralModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HisRefId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HisRefId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Referrals");
                });

            modelBuilder.Entity("MarketAI.Database.Models.SubscriptionDescriptionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Sign")
                        .HasColumnType("int");

                    b.Property<int?>("SubscriptionModelId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionModelId");

                    b.ToTable("SubscriptionDescriptionItems");
                });

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

            modelBuilder.Entity("WildberriesAPI.Models.DetailByPeriodModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("APIKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Barcode")
                        .HasColumnType("longtext");

                    b.Property<string>("BrandName")
                        .HasColumnType("longtext");

                    b.Property<double?>("CommissionPercent")
                        .HasColumnType("double");

                    b.Property<string>("DeclarationNumber")
                        .HasColumnType("longtext");

                    b.Property<long?>("DeliveryAmount")
                        .HasColumnType("bigint");

                    b.Property<double?>("DeliveryRub")
                        .HasColumnType("double");

                    b.Property<string>("DocTypeName")
                        .HasColumnType("longtext");

                    b.Property<string>("GiBoxTypeName")
                        .HasColumnType("longtext");

                    b.Property<long?>("GiId")
                        .HasColumnType("bigint");

                    b.Property<long?>("NmId")
                        .HasColumnType("bigint");

                    b.Property<string>("OfficeName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("OrderDt")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("ProductDiscountForReport")
                        .HasColumnType("double");

                    b.Property<long?>("Quantity")
                        .HasColumnType("bigint");

                    b.Property<long?>("RealizationReportId")
                        .HasColumnType("bigint");

                    b.Property<double?>("RetailAmount")
                        .HasColumnType("double");

                    b.Property<double?>("RetailPrice")
                        .HasColumnType("double");

                    b.Property<double?>("RetailPriceWithdiscRub")
                        .HasColumnType("double");

                    b.Property<long?>("ReturnAmount")
                        .HasColumnType("bigint");

                    b.Property<long?>("Rid")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("RrDt")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("RrdId")
                        .HasColumnType("bigint");

                    b.Property<string>("SaName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SaleDt")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("SalePercent")
                        .HasColumnType("double");

                    b.Property<long?>("ShkId")
                        .HasColumnType("bigint");

                    b.Property<long?>("StickerId")
                        .HasColumnType("bigint");

                    b.Property<string>("SubjectName")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplierContractCode")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplierOperName")
                        .HasColumnType("longtext");

                    b.Property<double?>("SupplierPromo")
                        .HasColumnType("double");

                    b.Property<string>("TsName")
                        .HasColumnType("longtext");

                    b.Property<double?>("ppvz_for_pay")
                        .HasColumnType("double");

                    b.Property<double?>("ppvz_kvw_prc")
                        .HasColumnType("double");

                    b.Property<double?>("ppvz_kvw_prc_base")
                        .HasColumnType("double");

                    b.Property<double?>("ppvz_office_id")
                        .HasColumnType("double");

                    b.Property<string>("ppvz_office_name")
                        .HasColumnType("longtext");

                    b.Property<double?>("ppvz_reward")
                        .HasColumnType("double");

                    b.Property<double?>("ppvz_sales_commission")
                        .HasColumnType("double");

                    b.Property<double?>("ppvz_spp_prc")
                        .HasColumnType("double");

                    b.Property<long?>("ppvz_supplier_id")
                        .HasColumnType("bigint");

                    b.Property<double?>("ppvz_vw")
                        .HasColumnType("double");

                    b.Property<double?>("ppvz_vw_nds")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("APIKey");

                    b.ToTable("DetailByPeriodModels");
                });

            modelBuilder.Entity("WildberriesAPI.Models.WBIncomeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("APIKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Barcode")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateClose")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("IncomeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("NmId")
                        .HasColumnType("bigint");

                    b.Property<string>("Number")
                        .HasColumnType("longtext");

                    b.Property<long?>("Quantity")
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplierArticle")
                        .HasColumnType("longtext");

                    b.Property<string>("TechSize")
                        .HasColumnType("longtext");

                    b.Property<double?>("TotalPrice")
                        .HasColumnType("double");

                    b.Property<string>("WarehouseName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("APIKey");

                    b.ToTable("WBIncomes");
                });

            modelBuilder.Entity("WildberriesAPI.Models.WBOrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("APIKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Barcode")
                        .HasColumnType("longtext");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CancelDT")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("DiscountPercent")
                        .HasColumnType("double");

                    b.Property<string>("GNumber")
                        .HasColumnType("longtext");

                    b.Property<long?>("IncomeID")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsCancel")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsSelfBuy")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("NmId")
                        .HasColumnType("bigint");

                    b.Property<long?>("Number")
                        .HasColumnType("bigint");

                    b.Property<string>("Oblast")
                        .HasColumnType("longtext");

                    b.Property<long?>("Odid")
                        .HasColumnType("bigint");

                    b.Property<long?>("Quantity")
                        .HasColumnType("bigint");

                    b.Property<string>("Sticker")
                        .HasColumnType("longtext");

                    b.Property<string>("Subject")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplierArticle")
                        .HasColumnType("longtext");

                    b.Property<string>("TechSize")
                        .HasColumnType("longtext");

                    b.Property<double?>("TotalPrice")
                        .HasColumnType("double");

                    b.Property<string>("WarehouseName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("APIKey");

                    b.ToTable("WBOrders");
                });

            modelBuilder.Entity("WildberriesAPI.Models.WBSaleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("APIKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Barcode")
                        .HasColumnType("longtext");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<string>("CountryName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("DiscountPercent")
                        .HasColumnType("double");

                    b.Property<double?>("FinishedPrice")
                        .HasColumnType("double");

                    b.Property<double?>("ForPay")
                        .HasColumnType("double");

                    b.Property<string>("GNumber")
                        .HasColumnType("longtext");

                    b.Property<long?>("IncomeID")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsRealization")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsSelfBuy")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("IsStorno")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsSupply")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("NmId")
                        .HasColumnType("bigint");

                    b.Property<string>("Number")
                        .HasColumnType("longtext");

                    b.Property<string>("OblastOkrugName")
                        .HasColumnType("longtext");

                    b.Property<long?>("Odid")
                        .HasColumnType("bigint");

                    b.Property<long?>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<double?>("PriceWithDisc")
                        .HasColumnType("double");

                    b.Property<double>("PromoCodeDiscount")
                        .HasColumnType("double");

                    b.Property<long?>("Quantity")
                        .HasColumnType("bigint");

                    b.Property<string>("RegionName")
                        .HasColumnType("longtext");

                    b.Property<string>("SaleID")
                        .HasColumnType("longtext");

                    b.Property<double?>("Spp")
                        .HasColumnType("double");

                    b.Property<string>("Sticker")
                        .HasColumnType("longtext");

                    b.Property<string>("Subject")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplierArticle")
                        .HasColumnType("longtext");

                    b.Property<string>("TechSize")
                        .HasColumnType("longtext");

                    b.Property<double?>("TotalPrice")
                        .HasColumnType("double");

                    b.Property<string>("WarehouseName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("APIKey");

                    b.ToTable("WBSales");
                });

            modelBuilder.Entity("WildberriesAPI.Models.WBStockModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("APIKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Barcode")
                        .HasColumnType("longtext");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<long?>("DaysOnSite")
                        .HasColumnType("bigint");

                    b.Property<double?>("Discount")
                        .HasColumnType("double");

                    b.Property<long?>("InWayFromClient")
                        .HasColumnType("bigint");

                    b.Property<long?>("InWayToClient")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsRealization")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsSupply")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("NmId")
                        .HasColumnType("bigint");

                    b.Property<double?>("Price")
                        .HasColumnType("double");

                    b.Property<long?>("Quantity")
                        .HasColumnType("bigint");

                    b.Property<long?>("QuantityFull")
                        .HasColumnType("bigint");

                    b.Property<long?>("QuantityNotInOrders")
                        .HasColumnType("bigint");

                    b.Property<string>("SCCode")
                        .HasColumnType("longtext");

                    b.Property<string>("Subject")
                        .HasColumnType("longtext");

                    b.Property<string>("SupplierArticle")
                        .HasColumnType("longtext");

                    b.Property<string>("TechSize")
                        .HasColumnType("longtext");

                    b.Property<long?>("Warehouse")
                        .HasColumnType("bigint");

                    b.Property<string>("WarehouseName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("APIKey");

                    b.ToTable("WBStocks");
                });

            modelBuilder.Entity("MarketAI.API.Models.SelfCostModel", b =>
                {
                    b.HasOne("MarketAI.API.Models.UserModel", "Owner")
                        .WithMany("SelfCosts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MarketAI.API.Models.Stats.AuthStatsModel", b =>
                {
                    b.HasOne("MarketAI.API.Models.UserModel", "User")
                        .WithMany("Auths")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MarketAI.API.Models.Stats.PaymentModel", b =>
                {
                    b.HasOne("MarketAI.API.Models.UserModel", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MarketAI.API.Models.TicketMessage", b =>
                {
                    b.HasOne("MarketAI.API.Models.TicketModel", "Owner")
                        .WithMany("Messages")
                        .HasForeignKey("OwnerId");

                    b.HasOne("MarketAI.API.Models.UserModel", "SentBy")
                        .WithMany()
                        .HasForeignKey("SentById");

                    b.Navigation("Owner");

                    b.Navigation("SentBy");
                });

            modelBuilder.Entity("MarketAI.API.Models.TicketModel", b =>
                {
                    b.HasOne("MarketAI.API.Models.UserModel", "OpenedBy")
                        .WithMany("Tickets")
                        .HasForeignKey("OpenedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OpenedBy");
                });

            modelBuilder.Entity("MarketAI.API.Models.UserModel", b =>
                {
                    b.HasOne("MarketAI.API.Models.UserData", "UserData")
                        .WithMany()
                        .HasForeignKey("UserDataId");

                    b.Navigation("UserData");
                });

            modelBuilder.Entity("MarketAI.API.Models.WB.ExtraExpenseModel", b =>
                {
                    b.HasOne("MarketAI.API.Models.UserModel", "Owner")
                        .WithMany("ExtraExpenses")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MarketAI.API.Models.WBAPITokenModel", b =>
                {
                    b.HasOne("MarketAI.API.Models.UserModel", "Owner")
                        .WithMany("WBAPIKeys")
                        .HasForeignKey("OwnerId");

                    b.HasOne("MarketAI.API.Models.UserData", null)
                        .WithMany("SelectedWBAPITokens")
                        .HasForeignKey("UserDataId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MarketAI.Database.Models.ReferralModel", b =>
                {
                    b.HasOne("MarketAI.API.Models.UserModel", "HisRef")
                        .WithMany()
                        .HasForeignKey("HisRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketAI.API.Models.UserModel", "Owner")
                        .WithMany("Referrals")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HisRef");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("MarketAI.Database.Models.SubscriptionDescriptionItem", b =>
                {
                    b.HasOne("MarketAI.API.Models.SubscriptionModel", null)
                        .WithMany("Descriptions")
                        .HasForeignKey("SubscriptionModelId");
                });

            modelBuilder.Entity("MarketAI.Database.Models.WithdrawRequest", b =>
                {
                    b.HasOne("MarketAI.API.Models.UserModel", "User")
                        .WithMany("WithdrawRequests")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MarketAI.API.Models.SubscriptionModel", b =>
                {
                    b.Navigation("Descriptions");
                });

            modelBuilder.Entity("MarketAI.API.Models.TicketModel", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("MarketAI.API.Models.UserData", b =>
                {
                    b.Navigation("SelectedWBAPITokens");
                });

            modelBuilder.Entity("MarketAI.API.Models.UserModel", b =>
                {
                    b.Navigation("Auths");

                    b.Navigation("ExtraExpenses");

                    b.Navigation("Payments");

                    b.Navigation("Referrals");

                    b.Navigation("SelfCosts");

                    b.Navigation("Tickets");

                    b.Navigation("WBAPIKeys");

                    b.Navigation("WithdrawRequests");
                });
#pragma warning restore 612, 618
        }
    }
}