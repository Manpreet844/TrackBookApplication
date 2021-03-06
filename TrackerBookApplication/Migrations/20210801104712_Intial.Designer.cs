// <auto-generated />
using TrackerBookApplication.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TrackerBookApplication.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20210801104712_Intial")]
    partial class Intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("TrackerBookApplication.Data.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ISBN");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("TrackerBookApplication.Data.Category", b =>
                {
                    b.Property<string>("NameToken")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("BookISBN")
                        .HasColumnType("TEXT");

                    b.Property<string>("Decription")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("NameToken");

                    b.HasIndex("BookISBN");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("TrackerBookApplication.Data.CategoryType", b =>
                {
                    b.Property<string>("Type")
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryNameToken")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Type");

                    b.HasIndex("CategoryNameToken");

                    b.ToTable("CategoryType");
                });

            modelBuilder.Entity("TrackerBookApplication.Data.Category", b =>
                {
                    b.HasOne("TrackerBookApplication.Data.Book", null)
                        .WithMany("Category")
                        .HasForeignKey("BookISBN");
                });

            modelBuilder.Entity("TrackerBookApplication.Data.CategoryType", b =>
                {
                    b.HasOne("TrackerBookApplication.Data.Category", null)
                        .WithMany("CategoryType")
                        .HasForeignKey("CategoryNameToken");
                });

            modelBuilder.Entity("TrackerBookApplication.Data.Book", b =>
                {
                    b.Navigation("Category");
                });

            modelBuilder.Entity("TrackerBookApplication.Data.Category", b =>
                {
                    b.Navigation("CategoryType");
                });
#pragma warning restore 612, 618
        }
    }
}
