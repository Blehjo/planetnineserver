using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace K.Migrations
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
                    Brief = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ModelLink = table.Column<string>(type: "TEXT", nullable: true),
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
                    MoonName = table.Column<string>(type: "TEXT", nullable: true),
                    MoonMass = table.Column<string>(type: "TEXT", nullable: true),
                    Perihelion = table.Column<string>(type: "TEXT", nullable: true),
                    Aphelion = table.Column<string>(type: "TEXT", nullable: true),
                    Gravity = table.Column<string>(type: "TEXT", nullable: true),
                    Temperature = table.Column<string>(type: "TEXT", nullable: true),
                    Brief = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ModelLink = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: true),
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
                values: new object[] { 1, "cyberpunk", new DateTime(2023, 6, 13, 5, 9, 12, 58, DateTimeKind.Utc).AddTicks(9310), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "spacemarauder@email.com", "malorian", null, "major", "Password1", "spacemarauder" });

            migrationBuilder.InsertData(
                table: "Planet",
                columns: new[] { "PlanetId", "Aphelion", "Brief", "Description", "Gravity", "ImageLink", "ModelLink", "Perihelion", "PlanetMass", "PlanetName", "Temperature", "Type", "UserId" },
                values: new object[,]
                {
                    { 2, "69816900", "From the surface of Mercury, the Sun would appear more than three times as large as it does when viewed from Earth, and the sunlight would be as much as 11 times brighter.", "The smallest planet in our solar system and nearest to the Sun, Mercury is only slightly larger than Earth's Moon. From the surface of Mercury, the Sun would appear more than three times as large as it does when viewed from Earth, and the sunlight would be as much as seven times brighter. Despite its proximity to the Sun, Mercury is not the hottest planet in our solar system – that title belongs to nearby Venus, thanks to its dense atmosphere. Because of Mercury's elliptical – egg-shaped – orbit, and sluggish rotation, the Sun appears to rise briefly, set, and rise again from some parts of the planet's surface. The same thing happens in reverse at sunset.", "3.7", "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBc0VRIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--b43e79a5b43d2063c4866ccff66bede5faff17b8/mercury_th.jpg", "https://solarsystem.nasa.gov/gltf_embed/2369", "46001200", "3.30114", "Mercury", "5.4291", "planet", 1 },
                    { 3, "108939000", "Similar in structure and size to Earth, Venus's thick atmosphere traps heat in a runaway greenhouse effect, making it the hottest planet in our solar system.", "Venus is the second planet from the Sun and is Earth’s closest planetary neighbor. It’s one of the four inner, terrestrial (or rocky) planets, and it’s often called Earth’s twin because it’s similar in size and density. These are not identical twins, however – there are radical differences between the two worlds. Venus has a thick, toxic atmosphere filled with carbon dioxide and it’s perpetually shrouded in thick, yellowish clouds of sulfuric acid that trap heat, causing a runaway greenhouse effect. It’s the hottest planet in our solar system, even though Mercury is closer to the Sun. Surface temperatures on Venus are about 900 degrees Fahrenheit (475 degrees Celsius) – hot enough to melt lead. The surface is a rusty color and it’s peppered with intensely crunched mountains and thousands of large volcanoes. Scientists think it’s possible some volcanoes are still active. Another big difference from Earth – Venus rotates on its axis backward, compared to most of the other planets in the solar system. This means that, on Venus, the Sun rises in the west and sets in the east, opposite to what we experience on Earth. (It’s not the only planet in our solar system with such an oddball rotation – Uranus spins on its side.)", "8.87", "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBajl5IiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1771be6bd46710c30aa93cd6c3ababe23ad52681/480x320_venus.png?disposition=inline", "https://solarsystem.nasa.gov/gltf_embed/2343", "107477000", "4.86747", "Venus", "5.243", "planet", 1 },
                    { 4, "152100000", "Earth—our home planet—is the only place we know of so far that’s inhabited by living things. It's also the only planet in our solar system with liquid water on the surface.", "Our home planet is the third planet from the Sun, and the only place we know of so far that’s inhabited by living things. While Earth is only the fifth largest planet in the solar system, it is the only world in our solar system with liquid water on the surface. Just slightly larger than nearby Venus, Earth is the biggest of the four planets closest to the Sun, all of which are made of rock and metal. Earth is the only planet in the Solar System whose English name does not come from Greek or Roman mythology. The name was taken from Old English and Germanic. It simply means the ground. There are, of course, many names for our planet in the thousands of languages spoken by the people of the third planet from the Sun.", "9.8", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Earth_from_Space.jpg/2048px-Earth_from_Space.jpg", "https://solarsystem.nasa.gov/gltf_embed/2393", "147095000", "5.97237", "Earth", "5.5136", "planet", 1 },
                    { 5, "249200000", "Mars is a dusty, cold, desert world with a very thin atmosphere. There is strong evidence Mars was – billions of years ago – wetter and warmer, with a thicker atmosphere.", "​Mars is the fourth planet from the Sun – a dusty, cold, desert world with a very thin atmosphere. Mars is also a dynamic planet with seasons, polar ice caps, canyons, extinct volcanoes, and evidence that it was even more active in the past. Mars is one of the most explored bodies in our solar system, and it's the only planet where we've sent rovers to roam the alien landscape. NASA currently has two rovers (Curiosity and Perseverance), one lander (InSight), and one helicopter (Ingenuity) exploring the surface of Mars.", "3.7", "https://solarsystem.nasa.gov/system/stellar_items/image_files/6_mars.jpg", "https://solarsystem.nasa.gov/gltf_embed/2372", "206700000", "3.71", "Mars", "3.9341", "planet", 1 },
                    { 6, "816620000", "Jupiter is more than twice as massive than the other planets of our solar system combined. The giant planet's Great Red Spot is a centuries-old storm bigger than Earth.", "Jupiter has a long history of surprising scientists – all the way back to 1610 when Galileo Galilei found the first moons beyond Earth. That discovery changed the way we see the universe. Jupiter's familiar stripes and swirls are actually cold, windy clouds of ammonia and water, floating in an atmosphere of hydrogen and helium. Jupiter’s iconic Great Red Spot is a giant storm bigger than Earth that has raged for hundreds of years", "24.79", "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdGxyIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--229ba26c079b7122001319d5dcffec49c8d4e0cb/STSCI-H-p1936a-f-640.jpg?disposition=attachment", "https://solarsystem.nasa.gov/gltf_embed/2375", "740379835", "1.89819", "Jupiter", "1.3262", "planet", 1 },
                    { 7, "1503509229", "Adorned with a dazzling, complex system of icy rings, Saturn is unique in our solar system. The other giant planets have rings, but none are as spectacular as Saturn's.", "Saturn is the sixth planet from the Sun and the second-largest planet in our solar system. Adorned with thousands of beautiful ringlets, Saturn is unique among the planets. It is not the only planet to have rings – made of chunks of ice and rock – but none are as spectacular or as complicated as Saturn's. Like fellow gas giant Jupiter, Saturn is a massive ball made mostly of hydrogen and helium.", "10.44", "https://solarsystem.nasa.gov/system/stellar_items/image_files/38_saturn_1600x900.jpg", "https://solarsystem.nasa.gov/gltf_embed/2355", "1349823615", "5.68336", "Saturn", "0.6871", "planet", 1 },
                    { 8, "3006318143", "Uranus—seventh planet from the Sun—rotates at a nearly 90-degree angle from the plane of its orbit. This unique tilt makes Uranus appear to spin on its side.", "Uranus is the seventh planet from the Sun, and has the third-largest diameter in our solar system. It was the first planet found with the aid of a telescope, Uranus was discovered in 1781 by astronomer William Herschel, although he originally thought it was either a comet or a star. It was two years later that the object was universally accepted as a new planet, in part because of observations by astronomer Johann Elert Bode. Herschel tried unsuccessfully to name his discovery Georgium Sidus after King George III. Instead, the scientific community accepted Bode's suggestion to name it Uranus, the Greek god of the sky, as suggested by Bode.​", "8.87", "https://images.english.elpais.com/resizer/BH_KvY_lAzwSrpp8v7D55nGax8A=/1960x1470/filters:focal(2464x2210:2474x2220)/cloudfront-eu-central-1.images.arcpublishing.com/prisa/WQ773ELGFRDOHJ46MOLRXKJ7AY.jpg", "https://solarsystem.nasa.gov/gltf_embed/2344&", "2734998229", "8.68127", "Uranus", "1.27", "planet", 1 },
                    { 9, "4537039826", "Neptune—the eighth and most distant major planet orbiting our Sun—is dark, cold and whipped by supersonic winds. It was the first planet located through mathematical calculations.", "Dark, cold, and whipped by supersonic winds, ice giant Neptune is the eighth and most distant planet in our solar system. More than 30 times as far from the Sun as Earth, Neptune is the only planet in our solar system not visible to the naked eye and the first predicted by mathematics before its discovery. In 2011 Neptune completed its first 165-year orbit since its discovery in 1846. NASA's Voyager 2 is the only spacecraft to have visited Neptune up close. It flew past in 1989 on its way out of the solar system.", "11.15", "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBbkp5IiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--cb7cb2868fd8b4892788893961c20975baffeb52/neptune_480x320.jpg?disposition=inline", "https://solarsystem.nasa.gov/gltf_embed/2364", "4459753056", "1.02413", "Neptune", "1.638", "planet", 1 }
                });

            migrationBuilder.InsertData(
                table: "Moon",
                columns: new[] { "MoonId", "Aphelion", "Brief", "Description", "Gravity", "ImageLink", "ModelLink", "MoonMass", "MoonName", "Perihelion", "PlanetId", "Temperature", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, "405500", "The fifth largest moon in the solar system, Earth's moon is the only place beyond Earth where humans have set foot.", "Earth's Moon is the only place beyond Earth where humans have set foot. The brightest and largest object in our night sky, the Moon makes Earth a more livable planet by moderating our home planet's wobble on its axis, leading to a relatively stable climate. It also causes tides, creating a rhythm that has guided humans for thousands of years. The Moon was likely formed after a Mars-sized body collided with Earth.Earth's Moon is the fifth largest of the 200+ moons orbiting planets in our solar system.", "1.62", "https://solarsystem.nasa.gov/rails/active_storage/disk/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaDdDVG9JYTJWNVNTSXBaVFpsTlROaVlXTXRabVJsTnkwMFl6TmtMV0k1TkRJdFlUY3lOamt6Tm1WbU5ESmtCam9HUlZRNkVHUnBjM0J2YzJsMGFXOXVTU0pUYVc1c2FXNWxPeUJtYVd4bGJtRnRaVDBpYkhKdlgyNWxZWEp6YVdSbFh6Z3dNQzVxY0djaU95Qm1hV3hsYm1GdFpTbzlWVlJHTFRnbkoyeHliMTl1WldGeWMybGtaVjg0TURBdWFuQm5CanNHVkRvUlkyOXVkR1Z1ZEY5MGVYQmxTU0lQYVcxaFoyVXZhbkJsWndZN0JsUTZFWE5sY25acFkyVmZibUZ0WlRvS2JHOWpZV3c9IiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2tleSJ9fQ==--12f04d32265fa546e880584dbd51d437d716afd0/lro_nearside_800.jpg", "https://solarsystem.nasa.gov/gltf_embed/2366", "7.346", "Moon", "363300", 4, "3.344", "moon", 1 },
                    { 2, "9518", "Phobos, gouged and nearly shattered by a giant impact crater and beaten by thousands of meteorite impacts, is on a collision course with Mars.", "New modeling indicates that the grooves on Mars’ moon Phobos could be produced by tidal forces – the mutual gravitational pull of the planet and the moon. Initially, scientists had thought the grooves were created by the massive impact that made Stickney crater (lower right). Phobos, gouged and nearly shattered by a giant impact crater and beaten by thousands of meteorite impacts, is on a collision course with Mars. Phobos is the larger of Mars' two moons and is 17 x 14 x 11 miles (27 by 22 by 18 kilometers) in diameter. It orbits Mars three times a day, and is so close to the planet's surface that in some locations on Mars it cannot always be seen. Phobos is nearing Mars at a rate of six feet (1.8 meters) every hundred years; at that rate, it will either crash into Mars in 50 million years or break up into a ring. Its most prominent feature is the 6-mile (9.7 kilometer) crater Stickney, its impact causing streak patterns across the moon's surface. Stickney was seen by Mars Global Surveyor to be filled with fine dust, with evidence of boulders sliding down its sloped surface.", "0.0057", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fplanetary.s3.amazonaws.com%2Fweb%2Fassets%2Fpictures%2Fphobos_mro_globe_color_PSP_007769_9010_IRB_northup.jpg&tbnid=wZ4E43TOr9wfbM&vet=12ahUKEwjY4ouds7__AhVGNN4AHczKBfgQMygLegUIARD-AQ..i&imgrefurl=https%3A%2F%2Fwww.planetary.org%2Fspace-images%2Fcolor-view-of-phobos-from-mars-reconnaissance-orbiter&docid=4DjRBd-_uaBWIM&w=3804&h=3403&q=phobos%20moon&ved=2ahUKEwjY4ouds7__AhVGNN4AHczKBfgQMygLegUIARD-AQ", "https://solarsystem.nasa.gov/gltf_embed/2358", "1.06", "Phobos", "9234", 5, "1.9", "moon", 1 },
                    { 3, "23471", "Deimos is the smaller of Mars' two moons. Being only 9 by 7 by 6.8 miles in size (15 by 12 by 11 kilometers), Deimos whirls around Mars every 30 hours.", "Like Phobos, Deimos is a small and lumpy, heavily cratered object. Its craters are generally smaller than 1.6 miles (2.5 kilometers) in diameter, however, and it lacks the grooves and ridges seen on Phobos. Typically when a meteorite hits a surface, surface material is thrown up and out of the resulting crater. The material usually falls back to the surface surrounding the crater. However, these ejecta deposits are not seen on Deimos, perhaps because the moon's gravity is so low that the ejecta escaped to space. Material does appear to have moved down slopes. Deimos also has a thick regolith, perhaps as deep as 328 feet (100 meters), formed as meteorites pulverized the surface. Deimos is a dark body that appears to be composed of C-type surface materials, similar to that of asteroids found in the outer asteroid belt.", "0.003", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fsolarsystem.nasa.gov%2Fsystem%2Fstellar_items%2Fimage_files%2F8_feature_1600x900_deimos_2.jpg&tbnid=S3YDeJG6RQSdsM&vet=12ahUKEwi59ubqs7__AhWnwMkDHYSkCSIQMygBegUIARDoAQ..i&imgrefurl=https%3A%2F%2Fsolarsystem.nasa.gov%2Fmoons%2Fmars-moons%2Fdeimos%2Fin-depth%2F&docid=UmhTmy3VK84G6M&w=1600&h=900&q=deimos%20moon&ved=2ahUKEwi59ubqs7__AhWnwMkDHYSkCSIQMygBegUIARDoAQ", "https://solarsystem.nasa.gov/gltf_embed/2434", "1.4762", "Deimos", "23456", 5, "1.75", "moon", 1 },
                    { 4, "423529", "Io is the most volcanically active body in the solar system.", "Jupiter's moon Io is the most volcanically active world in the Solar System, with hundreds of volcanoes, some erupting lava fountains dozens of miles (or kilometers) high. Io is caught in a tug-of-war between Jupiter's massive gravity and the smaller but precisely timed pulls from two neighboring moons that orbit farther from Jupiter—Europa and Ganymede.", "1.79", "", "https://solarsystem.nasa.gov/gltf_embed/2379", "8.932", "Io", "420071", 6, "3.53", "moon", 1 },
                    { 5, "0", "Europa may be the most promising place in our solar system to find present-day environments suitable for some form of life beyond Earth.", "Scientists are almost certain that hidden beneath the icy surface of Europa is a salty-water ocean thought to contain twice as much water as Earth’s oceans combined. And like Earth, Europa is thought to also contain a rocky mantle and iron core. There is very strong evidence suggesting Europa's ocean is in contact with rock.​ This is important because life as we know it requires three key basic ingredients: liquid water, an energy source, and organic compounds to use as the building blocks for biological processes.", "1.31", "", "https://solarsystem.nasa.gov/gltf_embed/2388", "4.8", "Europa", "0", 6, "3.01", "moon", 1 },
                    { 6, "0", "Ganymede is the largest satellite in our solar system. It is larger than Mercury and Pluto, and three-quarters the size of Mars.", "Jupiter’s icy moon Ganymede is the largest moon in our solar system, even bigger than the planet Mercury, and the dwarf planet Pluto. There’s strong evidence that Ganymede has an underground saltwater ocean that may hold more water than all the water on Earth's surface. It might even have ice and oceans stacked up in several layers like a club sandwich. Ganymede is the only moon known to have its own magnetic field – something typically found on planets like Earth. The magnetic field causes auroras, or bright ribbons of glowing gas, that circle the moon’s poles.", "1.428", "", "https://solarsystem.nasa.gov/gltf_embed/2385", "1.4819", "Ganymede", "0", 6, "1.94", "moon", 1 },
                    { 7, "0", "Callisto is the most heavily cratered object in our solar system.", "Callisto is Jupiter’s second largest moon and the third largest moon in our solar system. Its surface is the most heavily cratered of any object in our solar system. Images of Callisto captured by passing spacecraft show bright white spots standing out against darker regions. Scientists think the bright areas are mostly ice and the darker patches are areas where the ice has eroded. Once thought to be a dead, inactive rocky body, data gathered by the Galileo spacecraft in the 1990s indicate Callisto may have a salty ocean beneath its icy surface. More recent research reveals that this ocean may be located deeper beneath the surface than previously thought, or may not exist at all. If an ocean is present, it’s possible the ocean is interacting with rock on Callisto, creating a potential habitat for life.", "1.235", "", "https://solarsystem.nasa.gov/gltf_embed/2402", "1.0759", "Callisto", "0", 6, "1.83", "moon", 1 },
                    { 8, "182840", "Amalthea is the reddest object in the solar system and it appears to give out more heat than it receives from the sun. This may be because, as it orbits within Jupiter's powerful magnetic field, electric currents are included in the moon's core. Alternatively, the heat could be from tidal stresses.", "Orbiting within Io's orbit, which is the innermost of the four largest moons of Jupiter (called the Galilean moons), are four smaller moons named Metis, Adrastea, Amalthea, and Thebe. All of the moons within this grouping are oddly shaped, lacking either the mass and/or fluidity of composition to pull themselves into a reasonably spherical shape. The Galileo spacecraft has revealed some surface features, including impact craters, hills, and valleys. Amalthea is the largest within this grouping with a mean radius of about 83.5 ± 2.4 km. Amalthea orbits 181,400 km from its parent planet, Jupiter. Amalthea takes 0.498 Earth days to complete one orbit.", "0.02", "", "", "7.5", "Amalthea", "181150", 6, "3.1", "moon", 1 },
                    { 9, "13082000", "Himalia is the fifth largest moon orbiting Jupiter. With a mean radius of 85 km assuming an albedo of 0.04), it's only about 5% the size of the fourth largest moon, Europa. But it's by far the largest member of the Himalia group, a family of Jovian satellites which have similar orbits and appearance, and are therefore thought to have a common origin.", "Himalia is the fifth largest moon orbiting Jupiter. With a mean radius of 85 km assuming an albedo of 0.04), it's only about 5% the size of the fourth largest moon, Europa. But it's by far the largest member of the Himalia group, a family of Jovian satellites which have similar orbits and appearance, and are therefore thought to have a common origin.", "0.062", "", "", "9.5", "Himalia", "9782900", 6, "1", "moon", 1 },
                    { 10, "0", "Elara is the eighth largest moon of Jupiter. With a mean radius of 26.7 miles (43 km) assuming an albedo of 0.04, it's only about 2 percent the size of Europa, the smallest of the four Galilean moons. But it's about half as big as Himalia, which makes it the second biggest in the Himalia group, a family of Jovian satellites which have similar orbits and appearance, and are therefore thought to have a common origin.", "Elara is the eighth largest moon of Jupiter. With a mean radius of 26.7 miles (43 km) assuming an albedo of 0.04, it's only about 2 percent the size of Europa, the smallest of the four Galilean moons. But it's about half as big as Himalia, which makes it the second biggest in the Himalia group, a family of Jovian satellites which have similar orbits and appearance, and are therefore thought to have a common origin.", "0.031", "", "", "8", "Elara", "0", 6, "1", "moon", 1 },
                    { 11, "0", "Pasiphae is the largest member of the Pasiphae group, a family of Jovian satellites which have similar orbits and are therefore thought to have a common origin. Pasiphae was probably an asteroid that was captured by Jupiter's gravity and then suffered a collision which broke off a number of pieces. Those pieces became at least some, and perhaps all, of the other moons commonly categorized as members of the Pasiphae group.", "Pasiphae is the largest member of the Pasiphae group, a family of Jovian satellites which have similar orbits and are therefore thought to have a common origin. Pasiphae was probably an asteroid that was captured by Jupiter's gravity and then suffered a collision which broke off a number of pieces. Those pieces became at least some, and perhaps all, of the other moons commonly categorized as members of the Pasiphae group.", "0.022", "", "", "3", "Pasiphae", "0", 6, "1", "moon", 1 },
                    { 12, "0", "Sinope is generally considered a member of the Pasiphae group, a family of Jovian satellites which have similar orbits and are therefore thought to have a common origin. However, there is some uncertainty about whether Sinope belongs in this group or not.", "Sinope is generally considered a member of the Pasiphae group, a family of Jovian satellites which have similar orbits and are therefore thought to have a common origin. However, there is some uncertainty about whether Sinope belongs in this group or not.", "0.014", "", "", "8", "Sinope", "0", 6, "1", "moon", 1 },
                    { 13, "0", "", "", "0.013", "", "", "8", "Lysithea", "0", 6, "1", "moon", 1 },
                    { 14, "0", "", "", "0.017", "", "", "1", "Carme", "0", 6, "1", "moon", 1 },
                    { 15, "0", "", "", "0.01", "", "", "4", "Ananke", "0", 6, "1", "moon", 1 },
                    { 16, "0", "", "", "0.0073", "", "", "6", "Leda", "0", 6, "1", "moon", 1 },
                    { 17, "226000", "", "", "0.02", "", "", "8", "Thebe", "218000", 6, "1", "moon", 1 },
                    { 18, "0", "", "", "0.002", "", "", "2", "Adrastea", "0", 6, "1", "moon", 1 },
                    { 19, "128026", "", "", "0.005", "", "", "1", "Metis", "127974", 6, "1", "moon", 1 },
                    { 20, "0", "", "", "0.0031", "", "", "8.7", "Callirrhoe", "0", 6, "1", "moon", 1 },
                    { 21, "8874300", "", "", "0.0029", "", "", "6.9", "Themisto", "5909000", 6, "1", "moon", 1 },
                    { 22, "0", "", "", "0", "", "", "2.1", "Megaclite", "0", 6, "1", "moon", 1 },
                    { 23, "0", "", "", "0", "", "", "1.6", "Taygete", "0", 6, "1", "moon", 1 },
                    { 24, "0", "", "", "0", "", "", "7.5", "Chaldene", "0", 6, "1", "moon", 1 },
                    { 25, "0", "", "", "0", "", "", "1.2", "Harpalyke", "0", 6, "1", "moon", 1 },
                    { 26, "0", "", "", "0", "", "", "1.9", "Kalyke", "0", 6, "1", "moon", 1 },
                    { 27, "0", "", "", "0", "", "", "1.9", "Iocaste", "0", 6, "1", "moon", 1 },
                    { 28, "0", "", "", "0", "", "", "4.5", "Erinome", "0", 6, "1", "moon", 1 },
                    { 29, "0", "", "", "0", "", "", "7.5", "Isonoe", "0", 6, "1", "moon", 1 },
                    { 30, "0", "", "", "0", "", "", "4.3", "Praxidike", "0", 6, "1", "moon", 1 },
                    { 31, "0", "", "", "0.0015", "", "", "9", "Autonoe", "0", 6, "1", "moon", 1 },
                    { 32, "0", "", "", "0.0015", "", "", "9", "Thyone", "0", 6, "1", "moon", 1 },
                    { 33, "0", "", "", "0.0015", "", "", "9", "Hermippe", "0", 6, "1", "moon", 1 },
                    { 34, "0", "", "", "0.0012", "", "", "4.5", "Aitne", "0", 6, "1", "moon", 1 },
                    { 35, "0", "", "", "0.0012", "", "", "4.5", "Eurydome", "0", 6, "1", "moon", 1 },
                    { 36, "0", "", "", "0.0012", "", "", "4.5", "Euanthe", "0", 6, "1", "moon", 1 },
                    { 37, "0", "", "", "0", "", "", "1.5", "Euporie", "0", 6, "1", "moon", 1 },
                    { 38, "0", "", "", "0.00081", "", "", "1.5", "Orthosie", "0", 6, "1", "moon", 1 },
                    { 39, "0", "", "", "0.00081", "", "", "1.5", "Sponde", "0", 6, "1", "moon", 1 },
                    { 40, "0", "", "", "0.00081", "", "", "1.5", "Kale", "0", 6, "1", "moon", 1 },
                    { 41, "0", "", "", "0.00081", "", "", "1.5", "Pasithee", "0", 6, "1", "moon", 1 },
                    { 42, "0", "", "", "0", "", "", "4.5", "Hegemone", "0", 6, "1", "moon", 1 },
                    { 43, "0", "", "", "0", "", "", "1.5", "Mneme", "0", 6, "1", "moon", 1 },
                    { 44, "0", "", "", "0", "", "", "9", "Aoede", "0", 6, "1", "moon", 1 },
                    { 45, "0", "", "", "0", "", "", "1.5", "Thelxinoe", "0", 6, "1", "moon", 1 },
                    { 46, "0", "", "", "0.0012", "", "", "4.15", "Arche", "0", 6, "1", "moon", 1 },
                    { 47, "0", "", "", "0", "", "", "1.5", "Kallichore", "0", 6, "1", "moon", 1 },
                    { 48, "0", "", "", "0", "", "", "9", "Helike", "0", 6, "1", "moon", 1 },
                    { 49, "0", "", "", "0", "", "", "4.5", "Carpo", "0", 6, "1", "moon", 1 },
                    { 50, "0", "", "", "0", "", "", "9", "Eukelade", "0", 6, "1", "moon", 1 },
                    { 51, "0", "", "", "0", "", "", "1.5", "Cyllene", "0", 6, "1", "moon", 1 },
                    { 52, "0", "", "", "0", "", "", "1.5", "Kore", "0", 6, "1", "moon", 1 },
                    { 53, "0", "", "", "0", "", "", "1.5", "Herse", "0", 6, "1", "moon", 1 },
                    { 54, "0", "", "", "0", "", "", "1.5", "S/2003 J 2", "0", 6, "1", "moon", 1 },
                    { 55, "0", "", "", "0", "", "", "1.5", "Eupheme", "0", 6, "1", "moon", 1 },
                    { 56, "0", "", "", "0", "", "", "1.5", "S/2003 J 4", "0", 6, "1", "moon", 1 },
                    { 57, "0", "", "", "0", "", "", "9", "Eirene", "0", 6, "1", "moon", 1 },
                    { 58, "0", "", "", "0", "", "", "1.5", "S/2003 J 9", "0", 6, "1", "moon", 1 },
                    { 59, "0", "", "", "0", "", "", "1.5", "S/2003 J 10", "0", 6, "1", "moon", 1 },
                    { 60, "0", "", "", "0", "", "", "1", "S/2003 J 12", "0", 6, "1", "moon", 1 },
                    { 61, "0", "", "", "0", "", "", "1.5", "Philophrosyne", "0", 6, "1", "moon", 1 },
                    { 62, "0", "", "", "0", "", "", "1.5", "S/2003 J 16", "0", 6, "1", "moon", 1 },
                    { 63, "0", "", "", "0", "", "", "1.5", "S/2003 J 18", "0", 6, "1", "moon", 1 },
                    { 64, "0", "", "", "0", "", "", "1.5", "S/2003 J 19", "0", 6, "1", "moon", 1 },
                    { 65, "0", "", "", "0.00081", "", "", "1.5", "S/2003 J 23", "0", 6, "1", "moon", 1 },
                    { 66, "189270", "", "", "0", "", "", "3.79", "Mimas", "181770", 7, "1.15", "moon", 1 },
                    { 67, "239066", "", "", "0", "", "", "1.08", "Enceladus", "236830", 7, "1.61", "moon", 1 },
                    { 68, "294648", "", "", "0", "", "", "6.18", "Tethys", "294589", 7, "0.985", "moon", 1 },
                    { 69, "378260", "", "", "0", "", "", "1.095", "Dione", "376580", 7, "1.48", "moon", 1 },
                    { 70, "527597", "", "", "0", "", "", "2.3", "Rhea", "526543", 7, "1.24", "moon", 1 },
                    { 71, "1257060", "", "", "0", "", "", "1.3452", "Titan", "1186680", 7, "1.88", "moon", 1 },
                    { 72, "1535756", "", "", "0", "", "", "5.6", "Hyperion", "1466112", 7, "0.55", "moon", 1 },
                    { 73, "3661612", "", "", "0", "", "", "1.805", "Iapetus", "3460068", 7, "1.09", "moon", 1 },
                    { 74, "0", "", "", "0", "", "", "8.292", "Phoebe", "0", 7, "1.64", "moon", 1 },
                    { 75, "0", "", "", "0", "", "", "1.9", "Janus", "0", 7, "0.63", "moon", 1 },
                    { 76, "0", "", "", "0", "", "", "5.3", "Epimetheus", "0", 7, "0.64", "moon", 1 },
                    { 77, "0", "", "", "0", "", "", "null", "Helene", "0", 7, "1.3", "moon", 1 },
                    { 78, "0", "", "", "0", "", "", "1", "Telesto", "0", 7, "1", "moon", 1 },
                    { 79, "0", "", "", "0", "", "", "6.5", "Calypso", "0", 7, "1", "moon", 1 },
                    { 80, "0", "", "", "0", "", "", "7", "Atlas", "0", 7, "0.5", "moon", 1 },
                    { 81, "0", "", "", "0", "", "", "1.6", "Prometheus", "0", 7, "0.48", "moon", 1 },
                    { 82, "0", "", "", "0", "", "", "1.4", "Pandora", "0", 7, "0.49", "moon", 1 },
                    { 83, "0", "", "", "0", "", "", "4.95", "Pan", "0", 7, "0.42", "moon", 1 },
                    { 84, "0", "", "", "0", "", "", "3.97", "Ymir", "0", 7, "1", "moon", 1 },
                    { 85, "23139965", "", "", "0", "", "", "7.25", "Paaliaq", "6908035", 7, "1", "moon", 1 },
                    { 86, "0", "", "", "0", "", "", "2.3", "Tarvos", "0", 7, "1", "moon", 1 },
                    { 87, "0", "", "", "0", "", "", "1.18", "Ijiraq", "0", 7, "1", "moon", 1 },
                    { 88, "0", "", "", "0", "", "", "2.3", "Suttungr", "0", 7, "1", "moon", 1 },
                    { 89, "0", "", "", "0", "", "", "2.79", "Kiviuq", "0", 7, "1", "moon", 1 },
                    { 90, "0", "", "", "0", "", "", "2.3", "Mundilfari", "0", 7, "1", "moon", 1 },
                    { 91, "0", "", "", "0", "", "", "2.23", "Albiorix", "0", 7, "1", "moon", 1 },
                    { 92, "0", "", "", "0", "", "", "3.5", "Skathi", "0", 7, "1", "moon", 1 },
                    { 93, "0", "", "", "0", "", "", "6.8", "Erriapus", "0", 7, "1", "moon", 1 },
                    { 94, "0", "", "", "0", "", "", "4.35", "Siarnaq", "0", 7, "1", "moon", 1 },
                    { 95, "0", "", "", "0", "", "", "2.3", "Thrymr", "0", 7, "1", "moon", 1 },
                    { 96, "0", "", "", "0", "", "", "2.3", "Narvi", "0", 7, "1", "moon", 1 },
                    { 97, "194459", "", "", "0", "", "", "2", "Methone", "194421", 7, "1", "moon", 1 },
                    { 98, "0", "", "", "0", "", "", "6", "Pallene", "0", 7, "1", "moon", 1 },
                    { 99, "0", "", "", "0", "", "", "1", "Polydeuces", "0", 7, "1", "moon", 1 },
                    { 100, "0", "", "", "0", "", "", "1", "Daphnis", "0", 7, "0.34", "moon", 1 },
                    { 101, "0", "", "", "0", "", "", "1.5", "Aegir", "0", 7, "1", "moon", 1 },
                    { 102, "0", "", "", "0", "", "", "1.5", "Bebhionn", "0", 7, "1", "moon", 1 },
                    { 103, "0", "", "", "0", "", "", "1.5", "Bergelmir", "0", 7, "1", "moon", 1 },
                    { 104, "0", "", "", "0", "", "", "2.3", "Bestla", "0", 7, "1", "moon", 1 },
                    { 105, "0", "", "", "0", "", "", "9", "Farbauti", "0", 7, "1", "moon", 1 },
                    { 106, "0", "", "", "0", "", "", "5", "Fenrir", "0", 7, "1", "moon", 1 },
                    { 107, "0", "", "", "0", "", "", "1.5", "Fornjot", "0", 7, "1", "moon", 1 },
                    { 108, "0", "", "", "0", "", "", "1.5", "Hati", "0", 7, "1", "moon", 1 },
                    { 109, "0", "", "", "0", "", "", "3.5", "Hyrrokkin", "0", 7, "1", "moon", 1 },
                    { 110, "0", "", "", "0", "", "", "2.3", "Kari", "0", 7, "1", "moon", 1 },
                    { 111, "0", "", "", "0", "", "", "1.5", "Loge", "0", 7, "1", "moon", 1 },
                    { 112, "0", "", "", "0", "", "", "1.5", "Skoll", "0", 7, "1", "moon", 1 },
                    { 113, "0", "", "", "0", "", "", "1.5", "Surtur", "0", 7, "1", "moon", 1 },
                    { 114, "0", "", "", "0", "", "", "5", "Anthe", "0", 7, "1", "moon", 1 },
                    { 115, "0", "", "", "0", "", "", "1", "Jarnsaxa", "0", 7, "1", "moon", 1 },
                    { 116, "0", "", "", "0", "", "", "1.5", "Greip", "0", 7, "1", "moon", 1 },
                    { 117, "0", "", "", "0", "", "", "2.3", "Tarqeq", "0", 7, "1", "moon", 1 },
                    { 118, "0", "", "", "0", "", "", "1", "Aegaeon", "0", 7, "1", "moon", 1 },
                    { 119, "0", "", "", "0", "", "", "1.5", "S/2004 S 7", "0", 7, "1", "moon", 1 },
                    { 120, "0", "", "", "0", "", "", "9", "S/2004 S 12", "0", 7, "1", "moon", 1 },
                    { 121, "0", "", "", "0", "", "", "1.5", "S/2004 S 13", "0", 7, "1", "moon", 1 },
                    { 122, "0", "", "", "0", "", "", "5", "S/2004 S 17", "0", 7, "1", "moon", 1 },
                    { 123, "0", "", "", "0", "", "", "1", "S/2006 S 1", "0", 7, "1", "moon", 1 },
                    { 124, "0", "", "", "0", "", "", "1.5", "S/2006 S 3", "0", 7, "1", "moon", 1 },
                    { 125, "0", "", "", "0", "", "", "1.5", "S/2007 S 2", "0", 7, "1", "moon", 1 },
                    { 126, "0", "", "", "0", "", "", "1.5", "S/2007 S 3", "0", 7, "1", "moon", 1 },
                    { 127, "0", "", "", "0", "", "", "1", "S/2009 S 1", "0", 7, "1", "moon", 1 },
                    { 128, "191130", "", "", "0", "", "", "12.9", "Ariel", "190670", 8, "1.59", "moon", 1 },
                    { 129, "267500", "", "", "0", "", "", "12.2", "Umbriel", "265100", 8, "1.46", "moon", 1 },
                    { 130, "436800", "", "", "0", "", "", "34.2", "Titania", "435800", 8, "1.66", "moon", 1 },
                    { 131, "584336", "", "", "0", "", "", "28.8", "Oberon", "582702", 8, "1.56", "moon", 1 },
                    { 132, "130041", "", "", "0", "", "", "6.6", "Miranda", "129703", 8, "1.2", "moon", 1 },
                    { 133, "0", "", "", "0", "", "", "4.5", "Cordelia", "0", 8, "1", "moon", 1 },
                    { 134, "0", "", "", "0", "", "", "5.4", "Ophelia", "0", 8, "1", "moon", 1 },
                    { 135, "0", "", "", "0", "", "", "9.2", "Bianca", "0", 8, "1", "moon", 1 },
                    { 136, "0", "", "", "0", "", "", "3.4", "Cressida", "0", 8, "1", "moon", 1 },
                    { 137, "0", "", "", "0", "", "", "1.8", "Desdemona", "0", 8, "1", "moon", 1 },
                    { 138, "0", "", "", "0", "", "", "5.6", "Juliet", "0", 8, "1", "moon", 1 },
                    { 139, "0", "", "", "0", "", "", "1.7", "Portia", "0", 8, "1", "moon", 1 },
                    { 140, "0", "", "", "0", "", "", "0.25", "Rosalind", "0", 8, "1", "moon", 1 },
                    { 141, "0", "", "", "0", "", "", "4.9", "Belinda", "0", 8, "1", "moon", 1 },
                    { 142, "0", "", "", "0", "", "", "2.9", "Puck", "0", 8, "1", "moon", 1 },
                    { 143, "0", "", "", "0", "", "", "2.5", "Caliban", "0", 8, "1", "moon", 1 },
                    { 144, "0", "", "", "0", "", "", "2.3", "Sycorax", "0", 8, "1", "moon", 1 },
                    { 145, "0", "", "", "0", "", "", "8.5", "Prospero", "0", 8, "1", "moon", 1 },
                    { 146, "0", "", "", "0", "", "", "7.5", "Setebos", "0", 8, "1", "moon", 1 },
                    { 147, "0", "", "", "0", "", "", "2.2", "Stephano", "0", 8, "1", "moon", 1 },
                    { 148, "0", "", "", "0", "", "", "3.9", "Trinculo", "0", 8, "1", "moon", 1 },
                    { 149, "0", "", "", "0", "", "", "7.2", "Francisco", "0", 8, "1", "moon", 1 },
                    { 150, "0", "", "", "0", "", "", "5.4", "Margaret", "0", 8, "1", "moon", 1 },
                    { 151, "0", "", "", "0", "", "", "5.4", "Ferdinand", "0", 8, "1", "moon", 1 },
                    { 152, "0", "", "", "0", "", "", "1.8", "Perdita", "0", 8, "1", "moon", 1 },
                    { 153, "0", "", "", "0", "", "", "1", "Mab", "0", 8, "1", "moon", 1 },
                    { 154, "0", "", "", "0", "", "", "3.8", "Cupid", "0", 8, "1", "moon", 1 },
                    { 155, "354765", "", "", "0.78", "", "", "2.14", "Triton", "354753", 9, "2.05", "moon", 1 },
                    { 156, "9655000", "", "", "0.071", "", "", "3", "Nereid", "1372000", 9, "1", "moon", 1 },
                    { 157, "0", "", "", "0.01", "", "", "2", "Naiad", "0", 9, "1", "moon", 1 },
                    { 158, "0", "", "", "0.013", "", "", "4", "Thalassa", "0", 9, "1", "moon", 1 },
                    { 159, "0", "", "", "0.023", "", "", "2", "Despina", "0", 9, "1", "moon", 1 },
                    { 160, "0", "", "", "0.03", "", "", "2", "Galatea", "0", 9, "1", "moon", 1 },
                    { 161, "0", "", "", "0.034", "", "", "5", "Larissa", "0", 9, "1", "moon", 1 },
                    { 162, "0", "", "", "0.075", "", "", "5", "Proteus", "0", 9, "1", "moon", 1 },
                    { 163, "0", "", "", "0.01", "", "", "2", "Halimede", "0", 9, "1", "moon", 1 },
                    { 164, "0", "", "", "0", "", "", "2", "Psamathe", "0", 9, "1", "moon", 1 },
                    { 165, "0", "", "", "0.01", "", "", "1", "Sao", "0", 9, "1", "moon", 1 },
                    { 166, "0", "", "", "0.01", "", "", "1", "Laomedeia", "0", 9, "1", "moon", 1 },
                    { 167, "0", "", "", "0", "", "", "1", "Neso", "0", 9, "1", "moon", 1 }
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
