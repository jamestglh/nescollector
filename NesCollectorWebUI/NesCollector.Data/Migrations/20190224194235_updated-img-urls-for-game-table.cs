using Microsoft.EntityFrameworkCore.Migrations;

namespace NesCollector.Data.Migrations
{
    public partial class updatedimgurlsforgametable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "09bb03f8-4c45-41fc-a148-0fc57431ce73", "a4cd79fd-8a33-46fa-aa82-3af75f8effdb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a4fd0570-99bc-450c-a2b8-dd831c3315ea", "05e3474b-41d8-4518-bed2-a243d5b5f2b7" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b42f0531-1730-4b89-acf4-042a3ec92d8e", "3bc2cd2d-0bb2-4141-b819-d6d06ad90ee8", "User", "USER" },
                    { "f11f1220-5f24-405d-9dad-22953e7cbcc2", "3724fdd7-041b-4944-98c6-009b364543b3", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 607,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/7/7b/R.B.I._Baseball_Cover.jpg/250px-R.B.I._Baseball_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 608,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/156483-r-b-i-baseball-2-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 609,
                column: "CoverURL",
                value: "https://i.ebayimg.com/images/g/XqgAAOxy4YdTT~ei/s-l300.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 610,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/7/7b/R.B.I._Baseball_Cover.jpg/250px-R.B.I._Baseball_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 611,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/4/46/RC_Pro_Am_cover.jpg/220px-RC_Pro_Am_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 612,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/RC_Pro_Am_2_cover.jpg/220px-RC_Pro_Am_2_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 613,
                column: "CoverURL",
                value: "https://image.gamevaluenow.com/nes/rob_robotic_operating_buddy.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 614,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/3/37/Race_America_Cover.jpg/220px-Race_America_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 615,
                column: "CoverURL",
                value: "http://nintendoagemedia.com/elements_nocache/B1477F4C-A6ED-2E75-C1A3AE9985F93B8E.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 616,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/6/65/Racket_Attack.jpg/220px-Racket_Attack.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 617,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/4/49/Rad_racer_box_front.jpg/220px-Rad_racer_box_front.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 618,
                column: "CoverURL",
                value: "http://www.gameigloo.com/2151/rad-racer-2-nintendo-nes-1990.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 619,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/4/49/Rad_racer_box_front.jpg/220px-Rad_racer_box_front.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 620,
                column: "CoverURL",
                value: "https://images-na.ssl-images-amazon.com/images/I/31db8eOPE-L._AC_.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 621,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/6/68/Raid_2020_Cover.jpg/220px-Raid_2020_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 622,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/132415-raid-on-bungeling-bay-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 623,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/132415-raid-on-bungeling-bay-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 624,
                column: "CoverURL",
                value: "https://static.giantbomb.com/uploads/scale_medium/9/93770/2362152-nes_rainbowislands.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 625,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/1/1a/Rally_Bike_NES_cover.jpg/220px-Rally_Bike_NES_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 626,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/321613-rambo-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 627,
                column: "CoverURL",
                value: "https://i.ebayimg.com/images/i/291808721130-0-1/s-l1000.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 628,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/361416-rampart-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 629,
                column: "CoverURL",
                value: "https://i2.wp.com/www.nintendology.com/wp-content/uploads/2017/11/Renegade-NES-box-art.jpg?resize=550%2C752&ssl=1");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 630,
                column: "CoverURL",
                value: "http://img2.game-oldies.com/sites/default/files/packshots/nintendo-nes/rescue-the-embassy-mission-usa.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 631,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/26349-ring-king-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 632,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/26349-ring-king-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 633,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/4/46/River_City_Ransom-front.jpg/220px-River_City_Ransom-front.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 634,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/206669-road-runner-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 635,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/17219-roadblasters-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 636,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/205177-robin-hood-prince-of-thieves-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 637,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/d/de/Robowarrior_Cover.jpg/220px-Robowarrior_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 638,
                column: "CoverURL",
                value: "https://retro.poromagia.com/media/images/products/2016/03/Robocop-2-1-112665.JPG");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 639,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/246957-robocop-3-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 640,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/246957-robocop-3-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 641,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/175866-robocop-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 642,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/f/ff/RocknBallBoxShotNES.jpg/220px-RocknBallBoxShotNES.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 643,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/202668-rocket-ranger-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 644,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/4/4b/Rockin_Kats_cover.jpg/220px-Rockin_Kats_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 645,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/0/0e/Roger_Clemens%27_MVP_Baseball_cover.jpg/220px-Roger_Clemens%27_MVP_Baseball_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 646,
                column: "CoverURL",
                value: "https://i.pinimg.com/originals/8e/3c/93/8e3c9320aeac9d4fa18a239d3fec966e.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 647,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/16477-rollerball-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 648,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/a/ab/Rollerblade-Racer-nes.jpg/220px-Rollerblade-Racer-nes.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 649,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/14936-rolling-thunder-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 650,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/328864-romance-of-the-three-kingdoms-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 651,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/9/94/Romance_of_the_Three_Kingdoms_II.jpg/220px-Romance_of_the_Three_Kingdoms_II.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 652,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/3/3d/RoundballNABoxShotNES.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 653,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/33537-rush-n-attack-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 654,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/33537-rush-n-attack-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 655,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/31744-rygar-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 656,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/31744-rygar-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 657,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/78082-s-c-a-t-special-cybernetic-attack-team-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 658,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/326547-secret-scout-in-the-temple-of-demise-nes-media.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 659,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/56175-section-z-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 660,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/56175-section-z-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 661,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/163640-seicross-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 662,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/79956-sesame-street-1-2-3-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 663,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/79948-sesame-street-a-b-c-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 664,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/415995-sesame-street-1-2-3-sesame-street-a-b-c-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 665,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/175570-big-bird-s-hide-and-speak-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 666,
                column: "CoverURL",
                value: "https://www.speedrun.com/themes/sscountdown/cover-256.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 667,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/78095-shadow-of-the-ninja-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 668,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/23075-shadowgate-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 669,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Sharp_C1_NES_TV_14C-C1F.jpg/250px-Sharp_C1_NES_TV_14C-C1F.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 670,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/34933-shatterhand-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 671,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/194038-shingen-the-ruler-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 672,
                column: "CoverURL",
                value: "https://i.pinimg.com/originals/a0/d4/51/a0d4512b9f84ade87ab0870f05c97a1e.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 673,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/14942-shockwave-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 674,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/5/57/Shooting_Range_Cover.jpg/200px-Shooting_Range_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 675,
                column: "CoverURL",
                value: "https://cdn11.bigcommerce.com/s-m92i69d8x0/images/stencil/1280x1775/products/8874/10085/Short_Order_Egg-splode__50769.1505331690.jpg?c=2&imbypass=on");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 676,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/50767-side-pocket-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 677,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/321109-silent-assault-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 678,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/45163-silent-service-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 679,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/179015-silkworm-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 680,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/241830-silver-surfer-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 681,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/56231-skate-or-die-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 682,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/f/fb/Skate_or_Die_2_Cover.PNG/250px-Skate_or_Die_2_Cover.PNG");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 683,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/205131-ski-or-die-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 684,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/33556-skull-crossbones-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 685,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/128209-sky-kid-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 686,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/128209-sky-kid-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 687,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/16134-sky-shark-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 688,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/18588-slalom-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 689,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/18588-slalom-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 690,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/257195-smash-t-v-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 691,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/29928-snake-rattle-n-roll-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 692,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/187979-snake-s-revenge-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 693,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/6/63/Snoopy%27s_Silly_Sports_Spectacular_Cover.jpg/220px-Snoopy%27s_Silly_Sports_Spectacular_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 694,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/207268-snow-bros-nick-tom-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 695,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/19167-soccer-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 696,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/19167-soccer-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 697,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/241956-solar-jetman-hunt-for-the-golden-warpship-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 698,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/119555-solitaire-nes-media.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 699,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/78541-solomon-s-key-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 700,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/78541-solomon-s-key-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 701,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/9/96/Solstice_The_Quest_for_the_Staff_of_Demnos_Cover.jpg/220px-Solstice_The_Quest_for_the_Staff_of_Demnos_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 702,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/5/5c/Space_Shuttle_Project_Cover.jpg/250px-Space_Shuttle_Project_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 703,
                column: "CoverURL",
                value: "http://images.nintendolife.com/games/nes/spelunker/cover_large.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 704,
                column: "CoverURL",
                value: "http://images.nintendolife.com/games/nes/spelunker/cover_large.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 705,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/Spiderman_return_of_the_sinister_six_NES.jpg/220px-Spiderman_return_of_the_sinister_six_NES.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 706,
                column: "CoverURL",
                value: "https://www.retrogamecases.com/wp-content/uploads/nes_spiritualwarfare.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 707,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/c/c2/Spot_The_Video_Game_Cover.jpg/220px-Spot_The_Video_Game_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 708,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/120902-spy-hunter-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 709,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/120902-spy-hunter-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 710,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/175685-spy-vs-spy-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 711,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/5/5d/Sqoon_boxart.jpg/220px-Sqoon_boxart.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 712,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/206570-stack-up-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 713,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/c/ce/Stanleythesearchfordrlivingston.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 714,
                column: "CoverURL",
                value: "https://images-na.ssl-images-amazon.com/images/I/51wTjfjpshL._AC_SX215_.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 715,
                column: "CoverURL",
                value: "https://images-na.ssl-images-amazon.com/images/I/51wTjfjpshL._AC_SX215_.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 716,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/15014-star-soldier-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 717,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/174674-star-trek-25th-anniversary-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 718,
                column: "CoverURL",
                value: "http://img2.game-oldies.com/sites/default/files/packshots/nintendo-nes/star-trek-the-next-generation-usa.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 719,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/8/84/Startropics_box.jpg/220px-Startropics_box.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 720,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/33581-zoda-s-revenge-star-tropics-ii-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 721,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/175191-star-voyager-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 722,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/175191-star-voyager-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 723,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/1/1e/JVC_Star_Wars.jpg/220px-JVC_Star_Wars.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 724,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/6/6b/Star_Wars_The_Empire_Strikes_Back_NES_cover.jpg/220px-Star_Wars_The_Empire_Strikes_Back_NES_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 725,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/e/e3/Starship_Hector_Cover.jpg/220px-Starship_Hector_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 726,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/2/23/Stealth_ATF2.jpg/220px-Stealth_ATF2.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 727,
                column: "CoverURL",
                value: "https://vignette.wikia.nocookie.net/nintendo/images/b/ba/Stinger_%28NES%29_%28NA%29.jpg/revision/latest?cb=20130115004152&path-prefix=en");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 728,
                column: "CoverURL",
                value: "https://www.picclickimg.com/d/l400/pict/132948870996_/Vintage-Toys-R-Us-VIDPRO-CARD-for-STREET.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 729,
                column: "CoverURL",
                value: "https://i.pinimg.com/originals/11/31/69/1131694ad832b2a9c4f06d25b569eda7.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 730,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/2/22/Strider_NES_cover.jpg/220px-Strider_NES_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 731,
                column: "CoverURL",
                value: "http://nesninja.com/public/images/nes/covers/stuntkids-label.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 732,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/348956-sunday-funday-the-ride-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 733,
                column: "CoverURL",
                value: "https://vignette.wikia.nocookie.net/contra/images/8/87/Super_Contra_-_%28NA%29_-_01.jpg/revision/latest?cb=20180129093422");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 734,
                column: "CoverURL",
                value: "https://www.retrogamecases.com/wp-content/uploads/nes_supercars.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 735,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/2/2d/Super_Dodge_Ball_%28NES_cover%29.JPG/220px-Super_Dodge_Ball_%28NES_cover%29.JPG");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 736,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/33906-super-glove-ball-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 737,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/14507-super-mario-bros-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 738,
                column: "CoverURL",
                value: "https://images-na.ssl-images-amazon.com/images/I/716PmEJwraL._SY679_.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 739,
                column: "CoverURL",
                value: "https://images-na.ssl-images-amazon.com/images/I/51156B1VoAL.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 740,
                column: "CoverURL",
                value: "https://images-na.ssl-images-amazon.com/images/I/81RdY00vQ4L._AC_SX215_.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 741,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/14507-super-mario-bros-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 742,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/80359-super-mario-bros-duck-hunt-nes-media.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 743,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/78527-ivan-ironman-stewart-s-super-off-road-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 744,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/194068-super-pitfall-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 745,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/194068-super-pitfall-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 746,
                column: "CoverURL",
                value: "http://www.mobygames.com/images/covers/l/163630-u-s-championship-v-ball-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 747,
                column: "CoverURL",
                value: "https://cdn11.bigcommerce.com/s-m92i69d8x0/images/stencil/1280x1775/products/10957/14217/Super_Spike_VBall_Nintendo_World_Cup_Soccer_nes__48048.1518478712.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 748,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/15284-super-sprint-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 749,
                column: "CoverURL",
                value: "https://server.emulator.games/images/nintendo/super-spy-hunter.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 750,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/48258-super-team-games-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 751,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/5/59/SupermanNES.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 752,
                column: "CoverURL",
                value: "https://comicgamersassemble.files.wordpress.com/2014/10/swamp-thing-nes-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 753,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/9/9a/Sword_Master_for_NES_cover_art.jpg/220px-Sword_Master_for_NES_cover_art.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 754,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/0/02/Swords_and_Serpents_cover.jpg/220px-Swords_and_Serpents_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 755,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/193358-taboo-the-sixth-sense-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 756,
                column: "CoverURL",
                value: "https://server.emulator.games/images/nintendo/tag-team-wrestling.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 757,
                column: "CoverURL",
                value: "https://server.emulator.games/images/nintendo/tag-team-wrestling.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 758,
                column: "CoverURL",
                value: "https://static.giantbomb.com/uploads/scale_small/0/3413/206251-tagin__dragon.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 759,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/57441-disney-s-talespin-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 760,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/255147-super-jeopardy-dos-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 761,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/15710-target-renegade-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 762,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/a/a6/TecmoBaseball.jpg/220px-TecmoBaseball.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 763,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/6/63/Tecmobowlfront.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 764,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/2/24/TecmoCupSoccerGame.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 765,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/2/21/Tecmo_NBA_Basketball_cover.png/220px-Tecmo_NBA_Basketball_cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 766,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/1/13/Tecmo_Super_Bowl.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 767,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/156104-tecmo-world-wrestling-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 768,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/5/54/Teenage_Mutant_Ninja_Turtles_%281989_video_game%29.jpg/220px-Teenage_Mutant_Ninja_Turtles_%281989_video_game%29.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 769,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/b/bc/TMNT2boxNES.jpg/220px-TMNT2boxNES.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 770,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/307605-teenage-mutant-ninja-turtles-iii-the-manhattan-project-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 771,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/246933-teenage-mutant-ninja-turtles-tournament-fighters-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 772,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/128207-tennis-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 773,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/128207-tennis-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 774,
                column: "CoverURL",
                value: "https://static.miraheze.org/crappygameswiki/e/e8/Terminator-the-usa-europe.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 775,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/94667-terminator-2-judgment-day-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 776,
                column: "CoverURL",
                value: "http://www.hardcoregaming101.net/wp-content/uploads/2018/07/Terra-Cresta-spectrum-cover-spa2speccyorg.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 777,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/16097-tetris-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 778,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/69707-tetris-2-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 779,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/15763-tetris-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 780,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/246772-the-adventures-of-rocky-and-bullwinkle-and-friends-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 781,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/68778-the-goonies-ii-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 782,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/68778-the-goonies-ii-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 783,
                column: "CoverURL",
                value: "http://www.mobygames.com/images/covers/l/78032-the-guardian-legend-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 784,
                column: "CoverURL",
                value: "http://www.mobygames.com/images/covers/l/146947-disney-s-the-jungle-book-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 785,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/3/33/KarateKidNEScover.jpg/250px-KarateKidNEScover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 786,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/202651-last-ninja-2-back-with-a-vengeance-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 787,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/0/0b/The_Mafat_Conspiracy_cover.jpg/220px-The_Mafat_Conspiracy_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 788,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/5/59/Magic_of_Scherezade.JPG/220px-Magic_of_Scherezade.JPG");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 789,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/d/d2/Cover_to_1990_Punisher_NES_game.jpg/220px-Cover_to_1990_Punisher_NES_game.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 790,
                column: "CoverURL",
                value: "https://i.pinimg.com/originals/60/07/1c/60071c693dc49846171fc90fff2dc814.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 791,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/c/ca/The_Rocketeer_cover.jpg/220px-The_Rocketeer_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 792,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/c/c2/Bart_vs._The_Space_Mutants_cover.jpg/220px-Bart_vs._The_Space_Mutants_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 793,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/b/b1/Bart_world_front.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 794,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/3/3c/Bartman_Meets_Radioactive_Man_Cover.jpg/220px-Bartman_Meets_Radioactive_Man_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 795,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/96980-the-three-stooges-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 796,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/b/bd/The_Uncanny_X-Men_Coverart.png/220px-The_Uncanny_X-Men_Coverart.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 797,
                column: "CoverURL",
                value: "https://static.giantbomb.com/uploads/scale_medium/9/93770/2362342-nes_untouchables.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 798,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/77941-thunder-lightning-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 799,
                column: "CoverURL",
                value: "http://www.vgmpf.com/Wiki/images/thumb/8/81/Thunderbirds_-_NES.jpg/250px-Thunderbirds_-_NES.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 800,
                column: "CoverURL",
                value: "https://commondatastorage.googleapis.com/jjgames-static/images/6620.JPG");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 801,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/34603-tiger-heli-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 802,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/34603-tiger-heli-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 803,
                column: "CoverURL",
                value: "http://www.mobygames.com/images/covers/l/16100-tiles-of-fate-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 804,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/67003-time-lord-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 805,
                column: "CoverURL",
                value: "http://www.vgmpf.com/Wiki/images/thumb/2/2d/Times_of_Lore_-_NES_-_USA.jpg/250px-Times_of_Lore_-_NES_-_USA.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 806,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/14893-tiny-toon-adventures-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 807,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/67254-tiny-toon-adventures-2-trouble-in-wackyland-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 808,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/199946-tiny-toon-adventures-cartoon-workshop-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 809,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/5/56/Totheaf.jpg/220px-Totheaf.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 810,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/34475-toki-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 811,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/78293-tom-jerry-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 812,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/f/fb/TombsandTreasurebox.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 813,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/61792-toobin-commodore-64-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 814,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/33584-top-gun-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 815,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/33634-top-gun-the-second-mission-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 816,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/33584-top-gun-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 817,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/commons/e/e0/NES-101-Console-Set.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 818,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/e/e3/Top_Players_Tennis_NES.jpg/220px-Top_Players_Tennis_NES.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 819,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/51822-total-recall-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 820,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/4/43/Totally_Rad_cover_NES.jpg/250px-Totally_Rad_cover_NES.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 821,
                column: "CoverURL",
                value: "https://cdn.wikimg.net/en/strategywiki/images/thumb/8/8c/Touchdown_Fever_NES_box.jpg/250px-Touchdown_Fever_NES_box.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 822,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/7/7c/ThrillasSurfariBoxShotNES.jpg/220px-ThrillasSurfariBoxShotNES.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 823,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/b/bd/WoodWaterRageNESBoxShot.jpg/220px-WoodWaterRageNESBoxShot.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 824,
                column: "CoverURL",
                value: "https://images-na.ssl-images-amazon.com/images/I/511YY%2BzL24L._AC_SX215_.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 825,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/297870-track-field-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 826,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/Track_and_Field_2_cover.jpg/220px-Track_and_Field_2_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 827,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/297870-track-field-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 828,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/3/3a/TreasureMasterNes.jpg/220px-TreasureMasterNes.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 829,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/55200-trog-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 830,
                column: "CoverURL",
                value: "https://uknesboy.files.wordpress.com/2013/02/trojanboxart.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 831,
                column: "CoverURL",
                value: "https://uknesboy.files.wordpress.com/2013/02/trojanboxart.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 832,
                column: "CoverURL",
                value: "http://image.gamevaluenow.com/nes/trolls_on_treasure_island.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 833,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/36348-twin-cobra-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 834,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/26355-twin-eagle-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 835,
                column: "CoverURL",
                value: "http://image.gamevaluenow.com/nes/uforce.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 836,
                column: "CoverURL",
                value: "https://server.emulator.games/images/nintendo/ultima-exodus.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 837,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/96599-ultima-iv-quest-of-the-avatar-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 838,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/518525-ultima-v-warriors-of-destiny-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 839,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/1/1f/Ultimate_Air_Combat_Cover.jpg/220px-Ultimate_Air_Combat_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 840,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Ultimate_Basketball_cover.jpg/220px-Ultimate_Basketball_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 841,
                column: "CoverURL",
                value: "https://r.mprd.se/fup/up/57370-Ultimate_League_Soccer_(USA)_(Unl)-1502932218.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 842,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/1/1f/Ultimatestuntman_boxart.png/220px-Ultimatestuntman_boxart.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 843,
                column: "CoverURL",
                value: "https://images-na.ssl-images-amazon.com/images/I/51V8uOFw43L._AC_SX215_.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 844,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/31742-uninvited-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 845,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/8/8d/Urban_Champion_cover.jpg/220px-Urban_Champion_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 846,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/8/8d/Urban_Champion_cover.jpg/220px-Urban_Champion_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 847,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/5/55/Vegas_Dream_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 848,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/17819-venice-beach-volleyball-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 849,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/d/d8/Vice_Project_Doom_%28cover_art%29.jpg/256px-Vice_Project_Doom_%28cover_art%29.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 850,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/VideomationBoxArt.jpg/220px-VideomationBoxArt.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 851,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/4/47/Vindicators_cover.jpg/220px-Vindicators_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 852,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/8/83/Volleyball_Cover.png/220px-Volleyball_Cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 853,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/8/83/Volleyball_Cover.png/220px-Volleyball_Cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 854,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/1/1f/WCW_World_Championship_Wrestling_Coverart.png/220px-WCW_World_Championship_Wrestling_Coverart.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 855,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/c/c0/Kingofthering.jpg/220px-Kingofthering.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 856,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/5/5b/WWF_NES.PNG/220px-WWF_NES.PNG");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 857,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/2/24/Wmchallenge.JPG/220px-Wmchallenge.JPG");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 858,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/94234-wwf-wrestlemania-steel-cage-challenge-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 859,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/298147-wacky-races-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 860,
                column: "CoverURL",
                value: "http://www.mobygames.com/images/covers/l/168775-wall-street-kid-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 861,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/0/0e/Wbandtng.jpg/220px-Wbandtng.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 862,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/246775-wario-s-woods-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 863,
                column: "CoverURL",
                value: "http://nintendoagemedia.com/elements_nocache/DD632B94-F3F3-5C09-CC6B0DAEDEA09940.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 864,
                column: "CoverURL",
                value: "http://vgmpf.com/Wiki/images/thumb/6/69/Wayne%27s_World_-_NES.jpg/250px-Wayne%27s_World_-_NES.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 865,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/9/9f/Werewolf_The_Last_Warrior_cover.jpg/250px-Werewolf_The_Last_Warrior_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 866,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/163648-wheel-of-fortune-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 867,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/175591-wheel-of-fortune-family-edition-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 868,
                column: "CoverURL",
                value: "https://i.pinimg.com/originals/df/6c/9d/df6c9df0628627ad94c4957a4ad9052f.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 869,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/175014-wheel-of-fortune-junior-edition-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 870,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/85967-where-in-time-is-carmen-sandiego-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 871,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/c/c1/WheresWaldoNesBox.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 872,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/Roger_Rabbit_NES.jpg/220px-Roger_Rabbit_NES.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 873,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/8/8c/Whomp_%27Em_Coverart.png/220px-Whomp_%27Em_Coverart.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 874,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/0/09/Widget_Coverart.png/220px-Widget_Coverart.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 875,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/d/d1/Wild_Gunman_Coverart.png/220px-Wild_Gunman_Coverart.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 876,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/d/d1/Wild_Gunman_Coverart.png/220px-Wild_Gunman_Coverart.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 877,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/1/1f/Willow_vg_box.jpg/220px-Willow_vg_box.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 878,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/175269-win-lose-or-draw-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 879,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/16039-winter-games-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 880,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/16039-winter-games-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 881,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/257236-wizardry-knight-of-diamonds-the-second-scenario-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 882,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/256363-wizardry-proving-grounds-of-the-mad-overlord-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 883,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/146921-wizards-warriors-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 884,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/3/34/Wizards_and_Warriors_III_NES_cover.jpg/220px-Wizards_and_Warriors_III_NES_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 885,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/146921-wizards-warriors-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 886,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/f/fb/Wolverine_Cover.jpg/220px-Wolverine_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 887,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/24694-world-champ-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 888,
                column: "CoverURL",
                value: "http://takeontheneslibrary.com/wp-content/uploads/2018/02/066-World-Class-Track-Meet.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 889,
                column: "CoverURL",
                value: "https://server.emulator.games/images/nintendo/world-games.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 890,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/e/ed/Wrath_of_the_Black_Manta_Cover.jpg/220px-Wrath_of_the_Black_Manta_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 891,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/b/bb/Wrecking_Crew_cover.jpg/250px-Wrecking_Crew_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 892,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/b/bb/Wrecking_Crew_cover.jpg/250px-Wrecking_Crew_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 893,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Wurm_Journey_To_The_Center_Of_The_Earth_Cover.jpg/220px-Wurm_Journey_To_The_Center_Of_The_Earth_Cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 894,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/18312-xenophobe-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 895,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/187377-xevious-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 896,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/0/02/Xexyz_Coverart.png/220px-Xexyz_Coverart.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 897,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/115341-yo-noid-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 898,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/7/7d/Yoshi_game_cover.jpg/250px-Yoshi_game_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 899,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/16148-yoshi-s-cookie-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 900,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/a/a3/Young_Indy_%28NES%29.jpg/220px-Young_Indy_%28NES%29.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 901,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/262644-zanac-a-i-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 902,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/262644-zanac-a-i-nes-front-cover.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 903,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/commons/2/2e/Nintendo-Entertainment-System-NES-Zapper-Gray-L.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 904,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/f/fd/Zelda_II_The_Adventure_of_Link_box.jpg/220px-Zelda_II_The_Adventure_of_Link_box.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 905,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/thumb/f/fd/Zelda_II_The_Adventure_of_Link_box.jpg/220px-Zelda_II_The_Adventure_of_Link_box.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 906,
                column: "CoverURL",
                value: "http://image.gamevaluenow.com/nes/legend_of_zelda_test.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 907,
                column: "CoverURL",
                value: "https://www.mobygames.com/images/covers/l/205134-zen-intergalactic-ninja-nes-front-cover.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 908,
                column: "CoverURL",
                value: "https://upload.wikimedia.org/wikipedia/en/e/e4/Zombienation.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b42f0531-1730-4b89-acf4-042a3ec92d8e", "3bc2cd2d-0bb2-4141-b819-d6d06ad90ee8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f11f1220-5f24-405d-9dad-22953e7cbcc2", "3724fdd7-041b-4944-98c6-009b364543b3" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a4fd0570-99bc-450c-a2b8-dd831c3315ea", "05e3474b-41d8-4518-bed2-a243d5b5f2b7", "User", "USER" },
                    { "09bb03f8-4c45-41fc-a148-0fc57431ce73", "a4cd79fd-8a33-46fa-aa82-3af75f8effdb", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 607,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 608,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 609,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 610,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 611,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 612,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 613,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 614,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 615,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 616,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 617,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 618,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 619,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 620,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 621,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 622,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 623,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 624,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 625,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 626,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 627,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 628,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 629,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 630,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 631,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 632,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 633,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 634,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 635,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 636,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 637,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 638,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 639,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 640,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 641,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 642,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 643,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 644,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 645,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 646,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 647,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 648,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 649,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 650,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 651,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 652,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 653,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 654,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 655,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 656,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 657,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 658,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 659,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 660,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 661,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 662,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 663,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 664,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 665,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 666,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 667,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 668,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 669,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 670,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 671,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 672,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 673,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 674,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 675,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 676,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 677,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 678,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 679,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 680,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 681,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 682,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 683,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 684,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 685,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 686,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 687,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 688,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 689,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 690,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 691,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 692,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 693,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 694,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 695,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 696,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 697,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 698,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 699,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 700,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 701,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 702,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 703,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 704,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 705,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 706,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 707,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 708,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 709,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 710,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 711,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 712,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 713,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 714,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 715,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 716,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 717,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 718,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 719,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 720,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 721,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 722,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 723,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 724,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 725,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 726,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 727,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 728,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 729,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 730,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 731,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 732,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 733,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 734,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 735,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 736,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 737,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 738,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 739,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 740,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 741,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 742,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 743,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 744,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 745,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 746,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 747,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 748,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 749,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 750,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 751,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 752,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 753,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 754,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 755,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 756,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 757,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 758,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 759,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 760,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 761,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 762,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 763,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 764,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 765,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 766,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 767,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 768,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 769,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 770,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 771,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 772,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 773,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 774,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 775,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 776,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 777,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 778,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 779,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 780,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 781,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 782,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 783,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 784,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 785,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 786,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 787,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 788,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 789,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 790,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 791,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 792,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 793,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 794,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 795,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 796,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 797,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 798,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 799,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 800,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 801,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 802,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 803,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 804,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 805,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 806,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 807,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 808,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 809,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 810,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 811,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 812,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 813,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 814,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 815,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 816,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 817,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 818,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 819,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 820,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 821,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 822,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 823,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 824,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 825,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 826,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 827,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 828,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 829,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 830,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 831,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 832,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 833,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 834,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 835,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 836,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 837,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 838,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 839,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 840,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 841,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 842,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 843,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 844,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 845,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 846,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 847,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 848,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 849,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 850,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 851,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 852,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 853,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 854,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 855,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 856,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 857,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 858,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 859,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 860,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 861,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 862,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 863,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 864,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 865,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 866,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 867,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 868,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 869,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 870,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 871,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 872,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 873,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 874,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 875,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 876,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 877,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 878,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 879,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 880,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 881,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 882,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 883,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 884,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 885,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 886,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 887,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 888,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 889,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 890,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 891,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 892,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 893,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 894,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 895,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 896,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 897,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 898,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 899,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 900,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 901,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 902,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 903,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 904,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 905,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 906,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 907,
                column: "CoverURL",
                value: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 908,
                column: "CoverURL",
                value: "");
        }
    }
}
