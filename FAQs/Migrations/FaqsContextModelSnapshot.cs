﻿// <auto-generated />
using FAQs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAQs.Migrations
{
    [DbContext(typeof(FaqsContext))]
    partial class FaqsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAQs.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "gen",
                            Name = "General"
                        },
                        new
                        {
                            CategoryId = "hist",
                            Name = "History"
                        });
                });

            modelBuilder.Entity("FAQs.Models.FAQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TopicId");

                    b.ToTable("FAQs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "A general purpose object oriented language that uses a concise, Java-like syntax",
                            CategoryId = "gen",
                            Question = "What is c#?",
                            TopicId = "cs"
                        },
                        new
                        {
                            Id = 2,
                            Answer = "In 2002",
                            CategoryId = "hist",
                            Question = "When was C# first released?",
                            TopicId = "cs"
                        },
                        new
                        {
                            Id = 3,
                            Answer = "A general purpose scripting language that executes in a web browser.",
                            CategoryId = "gen",
                            Question = "What is JavaScript?",
                            TopicId = "js"
                        },
                        new
                        {
                            Id = 4,
                            Answer = "In 1995.",
                            CategoryId = "hist",
                            Question = "When was JavaScript first released?",
                            TopicId = "js"
                        },
                        new
                        {
                            Id = 5,
                            Answer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                            CategoryId = "gen",
                            Question = "What is Bootstrap?",
                            TopicId = "boot"
                        },
                        new
                        {
                            Id = 6,
                            Answer = "In 2011.",
                            CategoryId = "hist",
                            Question = "When was Bootstrap first released?",
                            TopicId = "boot"
                        });
                });

            modelBuilder.Entity("FAQs.Models.Topic", b =>
                {
                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicId = "cs",
                            Name = "C#"
                        },
                        new
                        {
                            TopicId = "js",
                            Name = "JavaScript"
                        },
                        new
                        {
                            TopicId = "boot",
                            Name = "Bootstrap"
                        });
                });

            modelBuilder.Entity("FAQs.Models.FAQ", b =>
                {
                    b.HasOne("FAQs.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("FAQs.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId");
                });
#pragma warning restore 612, 618
        }
    }
}
