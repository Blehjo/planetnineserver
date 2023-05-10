using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Planetnineserver.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    About = table.Column<string>(type: "TEXT", nullable: true),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ArtificialIntelligences",
                columns: table => new
                {
                    ArtificialIntelligenceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Role = table.Column<string>(type: "TEXT", nullable: true),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtificialIntelligences", x => x.ArtificialIntelligenceId);
                    table.ForeignKey(
                        name: "FK_ArtificialIntelligences_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Follower",
                columns: table => new
                {
                    FollowerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FollowerUser = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follower", x => x.FollowerId);
                    table.ForeignKey(
                        name: "FK_Follower_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MessageValue = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Message_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Planet",
                columns: table => new
                {
                    PlanetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlanetName = table.Column<string>(type: "TEXT", nullable: true),
                    PlanetMass = table.Column<string>(type: "TEXT", nullable: true),
                    Perihelion = table.Column<string>(type: "TEXT", nullable: true),
                    Aphelion = table.Column<string>(type: "TEXT", nullable: true),
                    Gravity = table.Column<string>(type: "TEXT", nullable: true),
                    Temperature = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planet", x => x.PlanetId);
                    table.ForeignKey(
                        name: "FK_Planet_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostValue = table.Column<string>(type: "TEXT", nullable: true),
                    MediaLink = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Post_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    ChatId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ArtificialId = table.Column<int>(type: "INTEGER", nullable: false),
                    ArtificialIntelligenceId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.ChatId);
                    table.ForeignKey(
                        name: "FK_Chats_ArtificialIntelligences_ArtificialIntelligenceId",
                        column: x => x.ArtificialIntelligenceId,
                        principalTable: "ArtificialIntelligences",
                        principalColumn: "ArtificialIntelligenceId");
                    table.ForeignKey(
                        name: "FK_Chats_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MessageComment",
                columns: table => new
                {
                    MessageCommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MessageValue = table.Column<string>(type: "TEXT", nullable: false),
                    MediaLink = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MessageId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageComment", x => x.MessageCommentId);
                    table.ForeignKey(
                        name: "FK_MessageComment_Message_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Message",
                        principalColumn: "MessageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessageComment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moon",
                columns: table => new
                {
                    MoonId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MoonName = table.Column<string>(type: "TEXT", nullable: false),
                    MoonMass = table.Column<string>(type: "TEXT", nullable: false),
                    Perihelion = table.Column<string>(type: "TEXT", nullable: false),
                    Aphelion = table.Column<string>(type: "TEXT", nullable: false),
                    Gravity = table.Column<string>(type: "TEXT", nullable: false),
                    Temperature = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: false),
                    PlanetId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moon", x => x.MoonId);
                    table.ForeignKey(
                        name: "FK_Moon_Planet_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Moon_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanetComment",
                columns: table => new
                {
                    PlanetCommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentValue = table.Column<string>(type: "TEXT", nullable: false),
                    MediaLink = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlanetId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanetComment", x => x.PlanetCommentId);
                    table.ForeignKey(
                        name: "FK_PlanetComment_Planet_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanetComment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChatComments",
                columns: table => new
                {
                    ChatCommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChatValue = table.Column<string>(type: "TEXT", nullable: true),
                    MediaLink = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChatId = table.Column<int>(type: "INTEGER", nullable: false),
                    ArtificialIntelligenceId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatComments", x => x.ChatCommentId);
                    table.ForeignKey(
                        name: "FK_ChatComments_ArtificialIntelligences_ArtificialIntelligenceId",
                        column: x => x.ArtificialIntelligenceId,
                        principalTable: "ArtificialIntelligences",
                        principalColumn: "ArtificialIntelligenceId");
                    table.ForeignKey(
                        name: "FK_ChatComments_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "ChatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentValue = table.Column<string>(type: "TEXT", nullable: false),
                    MediaLink = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    PostId = table.Column<int>(type: "INTEGER", nullable: false),
                    ChatId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "ChatId");
                    table.ForeignKey(
                        name: "FK_Comment_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoonComment",
                columns: table => new
                {
                    MoonCommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentValue = table.Column<string>(type: "TEXT", nullable: false),
                    MediaLink = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    MoonId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoonComment", x => x.MoonCommentId);
                    table.ForeignKey(
                        name: "FK_MoonComment_Moon_MoonId",
                        column: x => x.MoonId,
                        principalTable: "Moon",
                        principalColumn: "MoonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoonComment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorite",
                columns: table => new
                {
                    FavoriteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContentId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ContentType = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChatCommentId = table.Column<int>(type: "INTEGER", nullable: true),
                    ChatId = table.Column<int>(type: "INTEGER", nullable: true),
                    CommentId = table.Column<int>(type: "INTEGER", nullable: true),
                    MessageCommentId = table.Column<int>(type: "INTEGER", nullable: true),
                    MoonCommentId = table.Column<int>(type: "INTEGER", nullable: true),
                    MoonId = table.Column<int>(type: "INTEGER", nullable: true),
                    PlanetCommentId = table.Column<int>(type: "INTEGER", nullable: true),
                    PlanetId = table.Column<int>(type: "INTEGER", nullable: true),
                    PostId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorite", x => x.FavoriteId);
                    table.ForeignKey(
                        name: "FK_Favorite_ChatComments_ChatCommentId",
                        column: x => x.ChatCommentId,
                        principalTable: "ChatComments",
                        principalColumn: "ChatCommentId");
                    table.ForeignKey(
                        name: "FK_Favorite_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "ChatId");
                    table.ForeignKey(
                        name: "FK_Favorite_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "CommentId");
                    table.ForeignKey(
                        name: "FK_Favorite_MessageComment_MessageCommentId",
                        column: x => x.MessageCommentId,
                        principalTable: "MessageComment",
                        principalColumn: "MessageCommentId");
                    table.ForeignKey(
                        name: "FK_Favorite_MoonComment_MoonCommentId",
                        column: x => x.MoonCommentId,
                        principalTable: "MoonComment",
                        principalColumn: "MoonCommentId");
                    table.ForeignKey(
                        name: "FK_Favorite_Moon_MoonId",
                        column: x => x.MoonId,
                        principalTable: "Moon",
                        principalColumn: "MoonId");
                    table.ForeignKey(
                        name: "FK_Favorite_PlanetComment_PlanetCommentId",
                        column: x => x.PlanetCommentId,
                        principalTable: "PlanetComment",
                        principalColumn: "PlanetCommentId");
                    table.ForeignKey(
                        name: "FK_Favorite_Planet_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planet",
                        principalColumn: "PlanetId");
                    table.ForeignKey(
                        name: "FK_Favorite_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "PostId");
                    table.ForeignKey(
                        name: "FK_Favorite_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "About", "DateCreated", "DateOfBirth", "EmailAddress", "FirstName", "ImageLink", "LastName", "Password", "Username" },
                values: new object[] { 1, "cyberpunk", new DateTime(2023, 5, 10, 14, 50, 49, 292, DateTimeKind.Utc).AddTicks(1220), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "spacemarauder@email.com", "malorian", null, "major", "Password1", "spacemarauder" });

            migrationBuilder.InsertData(
                table: "Planet",
                columns: new[] { "PlanetId", "Aphelion", "Gravity", "ImageLink", "Perihelion", "PlanetMass", "PlanetName", "Temperature", "Type", "UserId" },
                values: new object[,]
                {
                    { 2, "69816900", "3.7", "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBc0VRIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--b43e79a5b43d2063c4866ccff66bede5faff17b8/mercury_th.jpg", "46001200", "3.30114", "Mercury", "5.4291", "planet", 1 },
                    { 3, "108939000", "8.87", "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBajl5IiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1771be6bd46710c30aa93cd6c3ababe23ad52681/480x320_venus.png?disposition=inline", "107477000", "4.86747", "Venus", "5.243", "planet", 1 },
                    { 4, "152100000", "9.8", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Earth_from_Space.jpg/2048px-Earth_from_Space.jpg", "147095000", "5.97237", "Earth", "5.5136", "planet", 1 },
                    { 5, "249200000", "3.7", "https://solarsystem.nasa.gov/system/stellar_items/image_files/6_mars.jpg", "206700000", "3.71", "Mars", "3.9341", "planet", 1 },
                    { 6, "816620000", "24.79", "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdGxyIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--229ba26c079b7122001319d5dcffec49c8d4e0cb/STSCI-H-p1936a-f-640.jpg?disposition=attachment", "740379835", "1.89819", "Jupiter", "1.3262", "planet", 1 },
                    { 7, "1503509229", "10.44", "https://solarsystem.nasa.gov/system/stellar_items/image_files/38_saturn_1600x900.jpg", "1349823615", "5.68336", "Saturn", "0.6871", "planet", 1 },
                    { 8, "3006318143", "8.87", "https://images.english.elpais.com/resizer/BH_KvY_lAzwSrpp8v7D55nGax8A=/1960x1470/filters:focal(2464x2210:2474x2220)/cloudfront-eu-central-1.images.arcpublishing.com/prisa/WQ773ELGFRDOHJ46MOLRXKJ7AY.jpg", "2734998229", "8.68127", "Uranus", "1.27", "planet", 1 },
                    { 9, "4537039826", "11.15", "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBbkp5IiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--cb7cb2868fd8b4892788893961c20975baffeb52/neptune_480x320.jpg?disposition=inline", "4459753056", "1.02413", "Neptune", "1.638", "planet", 1 }
                });

            migrationBuilder.InsertData(
                table: "Moon",
                columns: new[] { "MoonId", "Aphelion", "Gravity", "ImageLink", "MoonMass", "MoonName", "Perihelion", "PlanetId", "Temperature", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, "405500", "1.62", "", "7.346", "Moon", "363300", 4, "3.344", "moon", 1 },
                    { 2, "9518", "0.0057", "", "1.06", "Phobos", "9234", 5, "1.9", "moon", 1 },
                    { 3, "23471", "0.003", "", "1.4762", "Deimos", "23456", 5, "1.75", "moon", 1 },
                    { 4, "423529", "1.79", "", "8.932", "Io", "420071", 6, "3.53", "moon", 1 },
                    { 5, "0", "1.31", "", "4.8", "Europa", "0", 6, "3.01", "moon", 1 },
                    { 6, "0", "1.428", "", "1.4819", "Ganymede", "0", 6, "1.94", "moon", 1 },
                    { 7, "0", "1.235", "", "1.0759", "Callisto", "0", 6, "1.83", "moon", 1 },
                    { 8, "182840", "0.02", "", "7.5", "Amalthea", "181150", 6, "3.1", "moon", 1 },
                    { 9, "13082000", "0.062", "", "9.5", "Himalia", "9782900", 6, "1", "moon", 1 },
                    { 10, "0", "0.031", "", "8", "Elara", "0", 6, "1", "moon", 1 },
                    { 11, "0", "0.022", "", "3", "Pasiphae", "0", 6, "1", "moon", 1 },
                    { 12, "0", "0.014", "", "8", "Sinope", "0", 6, "1", "moon", 1 },
                    { 13, "0", "0.013", "", "8", "Lysithea", "0", 6, "1", "moon", 1 },
                    { 14, "0", "0.017", "", "1", "Carme", "0", 6, "1", "moon", 1 },
                    { 15, "0", "0.01", "", "4", "Ananke", "0", 6, "1", "moon", 1 },
                    { 16, "0", "0.0073", "", "6", "Leda", "0", 6, "1", "moon", 1 },
                    { 17, "226000", "0.02", "", "8", "Thebe", "218000", 6, "1", "moon", 1 },
                    { 18, "0", "0.002", "", "2", "Adrastea", "0", 6, "1", "moon", 1 },
                    { 19, "128026", "0.005", "", "1", "Metis", "127974", 6, "1", "moon", 1 },
                    { 20, "0", "0.0031", "", "8.7", "Callirrhoe", "0", 6, "1", "moon", 1 },
                    { 21, "8874300", "0.0029", "", "6.9", "Themisto", "5909000", 6, "1", "moon", 1 },
                    { 22, "0", "0", "", "2.1", "Megaclite", "0", 6, "1", "moon", 1 },
                    { 23, "0", "0", "", "1.6", "Taygete", "0", 6, "1", "moon", 1 },
                    { 24, "0", "0", "", "7.5", "Chaldene", "0", 6, "1", "moon", 1 },
                    { 25, "0", "0", "", "1.2", "Harpalyke", "0", 6, "1", "moon", 1 },
                    { 26, "0", "0", "", "1.9", "Kalyke", "0", 6, "1", "moon", 1 },
                    { 27, "0", "0", "", "1.9", "Iocaste", "0", 6, "1", "moon", 1 },
                    { 28, "0", "0", "", "4.5", "Erinome", "0", 6, "1", "moon", 1 },
                    { 29, "0", "0", "", "7.5", "Isonoe", "0", 6, "1", "moon", 1 },
                    { 30, "0", "0", "", "4.3", "Praxidike", "0", 6, "1", "moon", 1 },
                    { 31, "0", "0.0015", "", "9", "Autonoe", "0", 6, "1", "moon", 1 },
                    { 32, "0", "0.0015", "", "9", "Thyone", "0", 6, "1", "moon", 1 },
                    { 33, "0", "0.0015", "", "9", "Hermippe", "0", 6, "1", "moon", 1 },
                    { 34, "0", "0.0012", "", "4.5", "Aitne", "0", 6, "1", "moon", 1 },
                    { 35, "0", "0.0012", "", "4.5", "Eurydome", "0", 6, "1", "moon", 1 },
                    { 36, "0", "0.0012", "", "4.5", "Euanthe", "0", 6, "1", "moon", 1 },
                    { 37, "0", "0", "", "1.5", "Euporie", "0", 6, "1", "moon", 1 },
                    { 38, "0", "0.00081", "", "1.5", "Orthosie", "0", 6, "1", "moon", 1 },
                    { 39, "0", "0.00081", "", "1.5", "Sponde", "0", 6, "1", "moon", 1 },
                    { 40, "0", "0.00081", "", "1.5", "Kale", "0", 6, "1", "moon", 1 },
                    { 41, "0", "0.00081", "", "1.5", "Pasithee", "0", 6, "1", "moon", 1 },
                    { 42, "0", "0", "", "4.5", "Hegemone", "0", 6, "1", "moon", 1 },
                    { 43, "0", "0", "", "1.5", "Mneme", "0", 6, "1", "moon", 1 },
                    { 44, "0", "0", "", "9", "Aoede", "0", 6, "1", "moon", 1 },
                    { 45, "0", "0", "", "1.5", "Thelxinoe", "0", 6, "1", "moon", 1 },
                    { 46, "0", "0.0012", "", "4.15", "Arche", "0", 6, "1", "moon", 1 },
                    { 47, "0", "0", "", "1.5", "Kallichore", "0", 6, "1", "moon", 1 },
                    { 48, "0", "0", "", "9", "Helike", "0", 6, "1", "moon", 1 },
                    { 49, "0", "0", "", "4.5", "Carpo", "0", 6, "1", "moon", 1 },
                    { 50, "0", "0", "", "9", "Eukelade", "0", 6, "1", "moon", 1 },
                    { 51, "0", "0", "", "1.5", "Cyllene", "0", 6, "1", "moon", 1 },
                    { 52, "0", "0", "", "1.5", "Kore", "0", 6, "1", "moon", 1 },
                    { 53, "0", "0", "", "1.5", "Herse", "0", 6, "1", "moon", 1 },
                    { 54, "0", "0", "", "1.5", "S/2003 J 2", "0", 6, "1", "moon", 1 },
                    { 55, "0", "0", "", "1.5", "Eupheme", "0", 6, "1", "moon", 1 },
                    { 56, "0", "0", "", "1.5", "S/2003 J 4", "0", 6, "1", "moon", 1 },
                    { 57, "0", "0", "", "9", "Eirene", "0", 6, "1", "moon", 1 },
                    { 58, "0", "0", "", "1.5", "S/2003 J 9", "0", 6, "1", "moon", 1 },
                    { 59, "0", "0", "", "1.5", "S/2003 J 10", "0", 6, "1", "moon", 1 },
                    { 60, "0", "0", "", "1", "S/2003 J 12", "0", 6, "1", "moon", 1 },
                    { 61, "0", "0", "", "1.5", "Philophrosyne", "0", 6, "1", "moon", 1 },
                    { 62, "0", "0", "", "1.5", "S/2003 J 16", "0", 6, "1", "moon", 1 },
                    { 63, "0", "0", "", "1.5", "S/2003 J 18", "0", 6, "1", "moon", 1 },
                    { 64, "0", "0", "", "1.5", "S/2003 J 19", "0", 6, "1", "moon", 1 },
                    { 65, "0", "0.00081", "", "1.5", "S/2003 J 23", "0", 6, "1", "moon", 1 },
                    { 66, "189270", "0", "", "3.79", "Mimas", "181770", 7, "1.15", "moon", 1 },
                    { 67, "239066", "0", "", "1.08", "Enceladus", "236830", 7, "1.61", "moon", 1 },
                    { 68, "294648", "0", "", "6.18", "Tethys", "294589", 7, "0.985", "moon", 1 },
                    { 69, "378260", "0", "", "1.095", "Dione", "376580", 7, "1.48", "moon", 1 },
                    { 70, "527597", "0", "", "2.3", "Rhea", "526543", 7, "1.24", "moon", 1 },
                    { 71, "1257060", "0", "", "1.3452", "Titan", "1186680", 7, "1.88", "moon", 1 },
                    { 72, "1535756", "0", "", "5.6", "Hyperion", "1466112", 7, "0.55", "moon", 1 },
                    { 73, "3661612", "0", "", "1.805", "Iapetus", "3460068", 7, "1.09", "moon", 1 },
                    { 74, "0", "0", "", "8.292", "Phoebe", "0", 7, "1.64", "moon", 1 },
                    { 75, "0", "0", "", "1.9", "Janus", "0", 7, "0.63", "moon", 1 },
                    { 76, "0", "0", "", "5.3", "Epimetheus", "0", 7, "0.64", "moon", 1 },
                    { 77, "0", "0", "", "null", "Helene", "0", 7, "1.3", "moon", 1 },
                    { 78, "0", "0", "", "1", "Telesto", "0", 7, "1", "moon", 1 },
                    { 79, "0", "0", "", "6.5", "Calypso", "0", 7, "1", "moon", 1 },
                    { 80, "0", "0", "", "7", "Atlas", "0", 7, "0.5", "moon", 1 },
                    { 81, "0", "0", "", "1.6", "Prometheus", "0", 7, "0.48", "moon", 1 },
                    { 82, "0", "0", "", "1.4", "Pandora", "0", 7, "0.49", "moon", 1 },
                    { 83, "0", "0", "", "4.95", "Pan", "0", 7, "0.42", "moon", 1 },
                    { 84, "0", "0", "", "3.97", "Ymir", "0", 7, "1", "moon", 1 },
                    { 85, "23139965", "0", "", "7.25", "Paaliaq", "6908035", 7, "1", "moon", 1 },
                    { 86, "0", "0", "", "2.3", "Tarvos", "0", 7, "1", "moon", 1 },
                    { 87, "0", "0", "", "1.18", "Ijiraq", "0", 7, "1", "moon", 1 },
                    { 88, "0", "0", "", "2.3", "Suttungr", "0", 7, "1", "moon", 1 },
                    { 89, "0", "0", "", "2.79", "Kiviuq", "0", 7, "1", "moon", 1 },
                    { 90, "0", "0", "", "2.3", "Mundilfari", "0", 7, "1", "moon", 1 },
                    { 91, "0", "0", "", "2.23", "Albiorix", "0", 7, "1", "moon", 1 },
                    { 92, "0", "0", "", "3.5", "Skathi", "0", 7, "1", "moon", 1 },
                    { 93, "0", "0", "", "6.8", "Erriapus", "0", 7, "1", "moon", 1 },
                    { 94, "0", "0", "", "4.35", "Siarnaq", "0", 7, "1", "moon", 1 },
                    { 95, "0", "0", "", "2.3", "Thrymr", "0", 7, "1", "moon", 1 },
                    { 96, "0", "0", "", "2.3", "Narvi", "0", 7, "1", "moon", 1 },
                    { 97, "194459", "0", "", "2", "Methone", "194421", 7, "1", "moon", 1 },
                    { 98, "0", "0", "", "6", "Pallene", "0", 7, "1", "moon", 1 },
                    { 99, "0", "0", "", "1", "Polydeuces", "0", 7, "1", "moon", 1 },
                    { 100, "0", "0", "", "1", "Daphnis", "0", 7, "0.34", "moon", 1 },
                    { 101, "0", "0", "", "1.5", "Aegir", "0", 7, "1", "moon", 1 },
                    { 102, "0", "0", "", "1.5", "Bebhionn", "0", 7, "1", "moon", 1 },
                    { 103, "0", "0", "", "1.5", "Bergelmir", "0", 7, "1", "moon", 1 },
                    { 104, "0", "0", "", "2.3", "Bestla", "0", 7, "1", "moon", 1 },
                    { 105, "0", "0", "", "9", "Farbauti", "0", 7, "1", "moon", 1 },
                    { 106, "0", "0", "", "5", "Fenrir", "0", 7, "1", "moon", 1 },
                    { 107, "0", "0", "", "1.5", "Fornjot", "0", 7, "1", "moon", 1 },
                    { 108, "0", "0", "", "1.5", "Hati", "0", 7, "1", "moon", 1 },
                    { 109, "0", "0", "", "3.5", "Hyrrokkin", "0", 7, "1", "moon", 1 },
                    { 110, "0", "0", "", "2.3", "Kari", "0", 7, "1", "moon", 1 },
                    { 111, "0", "0", "", "1.5", "Loge", "0", 7, "1", "moon", 1 },
                    { 112, "0", "0", "", "1.5", "Skoll", "0", 7, "1", "moon", 1 },
                    { 113, "0", "0", "", "1.5", "Surtur", "0", 7, "1", "moon", 1 },
                    { 114, "0", "0", "", "5", "Anthe", "0", 7, "1", "moon", 1 },
                    { 115, "0", "0", "", "1", "Jarnsaxa", "0", 7, "1", "moon", 1 },
                    { 116, "0", "0", "", "1.5", "Greip", "0", 7, "1", "moon", 1 },
                    { 117, "0", "0", "", "2.3", "Tarqeq", "0", 7, "1", "moon", 1 },
                    { 118, "0", "0", "", "1", "Aegaeon", "0", 7, "1", "moon", 1 },
                    { 119, "0", "0", "", "1.5", "S/2004 S 7", "0", 7, "1", "moon", 1 },
                    { 120, "0", "0", "", "9", "S/2004 S 12", "0", 7, "1", "moon", 1 },
                    { 121, "0", "0", "", "1.5", "S/2004 S 13", "0", 7, "1", "moon", 1 },
                    { 122, "0", "0", "", "5", "S/2004 S 17", "0", 7, "1", "moon", 1 },
                    { 123, "0", "0", "", "1", "S/2006 S 1", "0", 7, "1", "moon", 1 },
                    { 124, "0", "0", "", "1.5", "S/2006 S 3", "0", 7, "1", "moon", 1 },
                    { 125, "0", "0", "", "1.5", "S/2007 S 2", "0", 7, "1", "moon", 1 },
                    { 126, "0", "0", "", "1.5", "S/2007 S 3", "0", 7, "1", "moon", 1 },
                    { 127, "0", "0", "", "1", "S/2009 S 1", "0", 7, "1", "moon", 1 },
                    { 128, "191130", "0", "", "12.9", "Ariel", "190670", 8, "1.59", "moon", 1 },
                    { 129, "267500", "0", "", "12.2", "Umbriel", "265100", 8, "1.46", "moon", 1 },
                    { 130, "436800", "0", "", "34.2", "Titania", "435800", 8, "1.66", "moon", 1 },
                    { 131, "584336", "0", "", "28.8", "Oberon", "582702", 8, "1.56", "moon", 1 },
                    { 132, "130041", "0", "", "6.6", "Miranda", "129703", 8, "1.2", "moon", 1 },
                    { 133, "0", "0", "", "4.5", "Cordelia", "0", 8, "1", "moon", 1 },
                    { 134, "0", "0", "", "5.4", "Ophelia", "0", 8, "1", "moon", 1 },
                    { 135, "0", "0", "", "9.2", "Bianca", "0", 8, "1", "moon", 1 },
                    { 136, "0", "0", "", "3.4", "Cressida", "0", 8, "1", "moon", 1 },
                    { 137, "0", "0", "", "1.8", "Desdemona", "0", 8, "1", "moon", 1 },
                    { 138, "0", "0", "", "5.6", "Juliet", "0", 8, "1", "moon", 1 },
                    { 139, "0", "0", "", "1.7", "Portia", "0", 8, "1", "moon", 1 },
                    { 140, "0", "0", "", "0.25", "Rosalind", "0", 8, "1", "moon", 1 },
                    { 141, "0", "0", "", "4.9", "Belinda", "0", 8, "1", "moon", 1 },
                    { 142, "0", "0", "", "2.9", "Puck", "0", 8, "1", "moon", 1 },
                    { 143, "0", "0", "", "2.5", "Caliban", "0", 8, "1", "moon", 1 },
                    { 144, "0", "0", "", "2.3", "Sycorax", "0", 8, "1", "moon", 1 },
                    { 145, "0", "0", "", "8.5", "Prospero", "0", 8, "1", "moon", 1 },
                    { 146, "0", "0", "", "7.5", "Setebos", "0", 8, "1", "moon", 1 },
                    { 147, "0", "0", "", "2.2", "Stephano", "0", 8, "1", "moon", 1 },
                    { 148, "0", "0", "", "3.9", "Trinculo", "0", 8, "1", "moon", 1 },
                    { 149, "0", "0", "", "7.2", "Francisco", "0", 8, "1", "moon", 1 },
                    { 150, "0", "0", "", "5.4", "Margaret", "0", 8, "1", "moon", 1 },
                    { 151, "0", "0", "", "5.4", "Ferdinand", "0", 8, "1", "moon", 1 },
                    { 152, "0", "0", "", "1.8", "Perdita", "0", 8, "1", "moon", 1 },
                    { 153, "0", "0", "", "1", "Mab", "0", 8, "1", "moon", 1 },
                    { 154, "0", "0", "", "3.8", "Cupid", "0", 8, "1", "moon", 1 },
                    { 155, "354765", "0.78", "", "2.14", "Triton", "354753", 9, "2.05", "moon", 1 },
                    { 156, "9655000", "0.071", "", "3", "Nereid", "1372000", 9, "1", "moon", 1 },
                    { 157, "0", "0.01", "", "2", "Naiad", "0", 9, "1", "moon", 1 },
                    { 158, "0", "0.013", "", "4", "Thalassa", "0", 9, "1", "moon", 1 },
                    { 159, "0", "0.023", "", "2", "Despina", "0", 9, "1", "moon", 1 },
                    { 160, "0", "0.03", "", "2", "Galatea", "0", 9, "1", "moon", 1 },
                    { 161, "0", "0.034", "", "5", "Larissa", "0", 9, "1", "moon", 1 },
                    { 162, "0", "0.075", "", "5", "Proteus", "0", 9, "1", "moon", 1 },
                    { 163, "0", "0.01", "", "2", "Halimede", "0", 9, "1", "moon", 1 },
                    { 164, "0", "0", "", "2", "Psamathe", "0", 9, "1", "moon", 1 },
                    { 165, "0", "0.01", "", "1", "Sao", "0", 9, "1", "moon", 1 },
                    { 166, "0", "0.01", "", "1", "Laomedeia", "0", 9, "1", "moon", 1 },
                    { 167, "0", "0", "", "1", "Neso", "0", 9, "1", "moon", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtificialIntelligences_UserId",
                table: "ArtificialIntelligences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatComments_ArtificialIntelligenceId",
                table: "ChatComments",
                column: "ArtificialIntelligenceId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatComments_ChatId",
                table: "ChatComments",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ArtificialIntelligenceId",
                table: "Chats",
                column: "ArtificialIntelligenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_UserId",
                table: "Chats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ChatId",
                table: "Comment",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_ChatCommentId",
                table: "Favorite",
                column: "ChatCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_ChatId",
                table: "Favorite",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_CommentId",
                table: "Favorite",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_MessageCommentId",
                table: "Favorite",
                column: "MessageCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_MoonCommentId",
                table: "Favorite",
                column: "MoonCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_MoonId",
                table: "Favorite",
                column: "MoonId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_PlanetCommentId",
                table: "Favorite",
                column: "PlanetCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_PlanetId",
                table: "Favorite",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_PostId",
                table: "Favorite",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_UserId",
                table: "Favorite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Follower_UserId",
                table: "Follower",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserId",
                table: "Message",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageComment_MessageId",
                table: "MessageComment",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageComment_UserId",
                table: "MessageComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Moon_PlanetId",
                table: "Moon",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_Moon_UserId",
                table: "Moon",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MoonComment_MoonId",
                table: "MoonComment",
                column: "MoonId");

            migrationBuilder.CreateIndex(
                name: "IX_MoonComment_UserId",
                table: "MoonComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Planet_UserId",
                table: "Planet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanetComment_PlanetId",
                table: "PlanetComment",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanetComment_UserId",
                table: "PlanetComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId",
                table: "Post",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorite");

            migrationBuilder.DropTable(
                name: "Follower");

            migrationBuilder.DropTable(
                name: "ChatComments");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "MessageComment");

            migrationBuilder.DropTable(
                name: "MoonComment");

            migrationBuilder.DropTable(
                name: "PlanetComment");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Moon");

            migrationBuilder.DropTable(
                name: "ArtificialIntelligences");

            migrationBuilder.DropTable(
                name: "Planet");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
