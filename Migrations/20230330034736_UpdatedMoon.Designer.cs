﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using planetnineserver.Data;

#nullable disable

namespace planetnineserver.Migrations
{
    [DbContext(typeof(planetnineservercontext))]
    [Migration("20230330034736_UpdatedMoon")]
    partial class UpdatedMoon
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("planetnineserver.Models.ArtificialIntelligence", b =>
                {
                    b.Property<int>("ArtificialIntelligenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArtificialIntelligenceId");

                    b.HasIndex("UserId");

                    b.ToTable("ArtificialIntelligences");
                });

            modelBuilder.Entity("planetnineserver.Models.Chat", b =>
                {
                    b.Property<int>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ArtificialIntelligenceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChatId");

                    b.HasIndex("ArtificialIntelligenceId");

                    b.HasIndex("UserId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("planetnineserver.Models.ChatComment", b =>
                {
                    b.Property<int>("ChatCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ArtificialIntelligenceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChatId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChatValue")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("MediaLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("ChatCommentId");

                    b.HasIndex("ArtificialIntelligenceId");

                    b.HasIndex("ChatId");

                    b.ToTable("ChatComments");
                });

            modelBuilder.Entity("planetnineserver.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("MediaLink")
                        .HasColumnType("TEXT");

                    b.Property<int>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("planetnineserver.Models.Favorite", b =>
                {
                    b.Property<int>("FavoriteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CommentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MessageCommentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MoonId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PlanetId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PostId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FavoriteId");

                    b.HasIndex("CommentId");

                    b.HasIndex("MessageCommentId");

                    b.HasIndex("MoonId");

                    b.HasIndex("PlanetId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorite");
                });

            modelBuilder.Entity("planetnineserver.Models.Follower", b =>
                {
                    b.Property<int>("FollowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<int>("FollowerUser")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FollowerId");

                    b.HasIndex("UserId");

                    b.ToTable("Follower");
                });

            modelBuilder.Entity("planetnineserver.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("MessageValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("planetnineserver.Models.MessageComment", b =>
                {
                    b.Property<int>("MessageCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("MediaLink")
                        .HasColumnType("TEXT");

                    b.Property<int>("MessageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MessageValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MessageCommentId");

                    b.HasIndex("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("MessageComment");
                });

            modelBuilder.Entity("planetnineserver.Models.Moon", b =>
                {
                    b.Property<int>("MoonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Aphelion")
                        .HasColumnType("REAL");

                    b.Property<float>("Gravity")
                        .HasColumnType("REAL");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("MoonMass")
                        .HasColumnType("REAL");

                    b.Property<string>("MoonName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Perihelion")
                        .HasColumnType("REAL");

                    b.Property<int>("PlanetId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Temperature")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MoonId");

                    b.HasIndex("PlanetId");

                    b.ToTable("Moon");
                });

            modelBuilder.Entity("planetnineserver.Models.Planet", b =>
                {
                    b.Property<int>("PlanetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Aphelion")
                        .HasColumnType("REAL");

                    b.Property<float>("Gravity")
                        .HasColumnType("REAL");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Perihelion")
                        .HasColumnType("REAL");

                    b.Property<float>("PlanetMass")
                        .HasColumnType("REAL");

                    b.Property<string>("PlanetName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Temperature")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlanetId");

                    b.HasIndex("UserId");

                    b.ToTable("Planet");
                });

            modelBuilder.Entity("planetnineserver.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("MediaLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("planetnineserver.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("About")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("planetnineserver.Models.ArtificialIntelligence", b =>
                {
                    b.HasOne("planetnineserver.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("planetnineserver.Models.Chat", b =>
                {
                    b.HasOne("planetnineserver.Models.ArtificialIntelligence", null)
                        .WithMany("Chats")
                        .HasForeignKey("ArtificialIntelligenceId");

                    b.HasOne("planetnineserver.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("planetnineserver.Models.ChatComment", b =>
                {
                    b.HasOne("planetnineserver.Models.ArtificialIntelligence", null)
                        .WithMany("ChatComments")
                        .HasForeignKey("ArtificialIntelligenceId");

                    b.HasOne("planetnineserver.Models.Chat", "Chat")
                        .WithMany("ChatComments")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("planetnineserver.Models.Comment", b =>
                {
                    b.HasOne("planetnineserver.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("planetnineserver.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("planetnineserver.Models.Favorite", b =>
                {
                    b.HasOne("planetnineserver.Models.Comment", null)
                        .WithMany("Favorites")
                        .HasForeignKey("CommentId");

                    b.HasOne("planetnineserver.Models.MessageComment", null)
                        .WithMany("Favorites")
                        .HasForeignKey("MessageCommentId");

                    b.HasOne("planetnineserver.Models.Moon", null)
                        .WithMany("Favorites")
                        .HasForeignKey("MoonId");

                    b.HasOne("planetnineserver.Models.Planet", null)
                        .WithMany("Favorites")
                        .HasForeignKey("PlanetId");

                    b.HasOne("planetnineserver.Models.Post", null)
                        .WithMany("Favorites")
                        .HasForeignKey("PostId");

                    b.HasOne("planetnineserver.Models.User", null)
                        .WithMany("Favorites")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("planetnineserver.Models.Follower", b =>
                {
                    b.HasOne("planetnineserver.Models.User", "User")
                        .WithMany("Followers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("planetnineserver.Models.Message", b =>
                {
                    b.HasOne("planetnineserver.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("planetnineserver.Models.MessageComment", b =>
                {
                    b.HasOne("planetnineserver.Models.Message", "Message")
                        .WithMany("MessageComments")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("planetnineserver.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("User");
                });

            modelBuilder.Entity("planetnineserver.Models.Moon", b =>
                {
                    b.HasOne("planetnineserver.Models.Planet", "Planet")
                        .WithMany("Moons")
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planet");
                });

            modelBuilder.Entity("planetnineserver.Models.Planet", b =>
                {
                    b.HasOne("planetnineserver.Models.User", null)
                        .WithMany("Planets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("planetnineserver.Models.Post", b =>
                {
                    b.HasOne("planetnineserver.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("planetnineserver.Models.ArtificialIntelligence", b =>
                {
                    b.Navigation("ChatComments");

                    b.Navigation("Chats");
                });

            modelBuilder.Entity("planetnineserver.Models.Chat", b =>
                {
                    b.Navigation("ChatComments");
                });

            modelBuilder.Entity("planetnineserver.Models.Comment", b =>
                {
                    b.Navigation("Favorites");
                });

            modelBuilder.Entity("planetnineserver.Models.Message", b =>
                {
                    b.Navigation("MessageComments");
                });

            modelBuilder.Entity("planetnineserver.Models.MessageComment", b =>
                {
                    b.Navigation("Favorites");
                });

            modelBuilder.Entity("planetnineserver.Models.Moon", b =>
                {
                    b.Navigation("Favorites");
                });

            modelBuilder.Entity("planetnineserver.Models.Planet", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Moons");
                });

            modelBuilder.Entity("planetnineserver.Models.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Favorites");
                });

            modelBuilder.Entity("planetnineserver.Models.User", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Followers");

                    b.Navigation("Planets");
                });
#pragma warning restore 612, 618
        }
    }
}
