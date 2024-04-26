﻿// <auto-generated />
using KMNVetetable.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KMNVetetable.Persistence.Migrations
{
    [DbContext(typeof(KmnContext))]
    [Migration("20240425234717_mig_update_testimonial")]
    partial class mig_update_testimonial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KMNVegetable.Domain.Entities.BestSeller", b =>
                {
                    b.Property<int>("BestSellerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BestSellerID"));

                    b.Property<string>("BestSellerProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BestSellerID");

                    b.HasIndex("ProductID");

                    b.ToTable("BestSellers");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Billing", b =>
                {
                    b.Property<int>("BillingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillingID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Annotation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BillingID");

                    b.ToTable("Billings");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentID");

                    b.HasIndex("ProductID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Discount", b =>
                {
                    b.Property<int>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscountID"));

                    b.Property<string>("DiscoundProductAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiscoundProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("DiscountID");

                    b.HasIndex("ProductID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Footer", b =>
                {
                    b.Property<int>("FooterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FooterID"));

                    b.Property<string>("FooterNote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FooterSubtitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FooterSubtitleDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FooterTitle1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FooterTitle2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FooterID");

                    b.ToTable("Footers");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.FooterContact", b =>
                {
                    b.Property<int>("FooterContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FooterContactID"));

                    b.Property<string>("FooterContactAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FooterContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FooterContactPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FooterContactID");

                    b.ToTable("FooterContacts");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.MainSlider", b =>
                {
                    b.Property<int>("MainSliderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MainSliderID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderImageUrl1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderImageUrl2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MainSliderID");

                    b.ToTable("MainSliders");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.NavBarContact", b =>
                {
                    b.Property<int>("NavBarContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NavBarContactID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NavBarContactID");

                    b.ToTable("NavBarContacts");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.ProductDetail", b =>
                {
                    b.Property<int>("ProductDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductDetailID"));

                    b.Property<string>("ProductCheck")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDetailName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("ProductMinWeight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductQuality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductRating")
                        .HasColumnType("int");

                    b.Property<string>("ProductWeight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductDetailID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductsDetails");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Promotion", b =>
                {
                    b.Property<int>("PromotionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PromotionID"));

                    b.Property<string>("PromotionDescripiton")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PromotionImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PromotionPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PromotionTitle1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PromotionTitle2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PromotionID");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Reward", b =>
                {
                    b.Property<int>("RewardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RewardID"));

                    b.Property<string>("RewardRate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RewardTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RewardID");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceID"));

                    b.Property<string>("ServiceDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.SocialMedia", b =>
                {
                    b.Property<int>("SocialMediaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocialMediaID"));

                    b.Property<string>("SocialMediaIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialMedyaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocialMediaID");

                    b.ToTable("SocialMedias");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Testimonial", b =>
                {
                    b.Property<int>("TestimonialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestimonialID"));

                    b.Property<string>("TestimonialDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialRating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestimonialID");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.BestSeller", b =>
                {
                    b.HasOne("KMNVegetable.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Comment", b =>
                {
                    b.HasOne("KMNVegetable.Domain.Entities.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Discount", b =>
                {
                    b.HasOne("KMNVegetable.Domain.Entities.Product", "Product")
                        .WithMany("Discounts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Product", b =>
                {
                    b.HasOne("KMNVegetable.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.ProductDetail", b =>
                {
                    b.HasOne("KMNVegetable.Domain.Entities.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("KMNVegetable.Domain.Entities.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Discounts");

                    b.Navigation("ProductDetails");
                });
#pragma warning restore 612, 618
        }
    }
}