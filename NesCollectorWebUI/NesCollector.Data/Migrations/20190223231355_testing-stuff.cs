using Microsoft.EntityFrameworkCore.Migrations;

namespace NesCollector.Data.Migrations
{
    public partial class testingstuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "34e3d1a3-bf89-429f-8bdc-8c41b82bbc59", "5b1847c7-0f9b-47f1-9c69-643fb1e0a492" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "6beaa07a-ea93-48c1-8f01-c8e43760d1e1", "6b3546d4-62c0-42f0-af0d-2bdc1199d2e2" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "58f2710e-d00d-4259-a450-cfc86a61cc3c", "347e9c7f-75b4-409f-b721-191910207b25", "User", "USER" },
                    { "0171b6db-2f6b-4b5d-b7cd-ea31c1dea88f", "453ac20c-dca6-4133-9290-e00f9d881e05", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApiGameId", "CibPrice", "CoverURL", "GameConsoleId", "Genre", "LoosePrice", "SystemId", "Title", "Upc" },
                values: new object[,]
                {
                    { 598, 12368, 1, "http://nesninja.com/public/images/nes/covers/qbert-label.jpg", 1, "Arcade", 1, "NES", "Q*bert", "" },
                    { 599, 12369, 1, "https://gamefaqs.akamaized.net/box/5/0/9/41509_front.jpg", 1, "Puzzle", 1, "NES", "Qix", "" },
                    { 600, 12371, 1, "https://gamefaqs.akamaized.net/box/5/6/9/49569_front.jpg", 1, "Action & Adventure", 1, "NES", "Quattro Adventure", "" },
                    { 601, 39524, 1, "https://i.ebayimg.com/images/g/oyEAAOSw-W5UylKy/s-l300.jpg", 1, "Action & Adventure", 1, "NES", "Quattro Adventure [Aladdin]", "" },
                    { 602, 19308, 1, "http://www.neshq.com/media/mag/Quatro%20Arcade%20Promp.jpg", 1, "Arcade", 1, "NES", "Quattro Arcade", "" },
                    { 603, 12372, 1, "https://i.ebayimg.com/images/g/hd4AAOSwNSxVboJS/s-l300.jpg", 1, "Sports", 1, "NES", "Quattro Sports", "" },
                    { 604, 39525, 1, "https://gamefaqs.akamaized.net/box/5/7/9/49579_front.jpg", 1, "Sports", 1, "NES", "Quattro Sports [Aladdin]", "" },
                    { 605, 21024, 1, "https://i.ebayimg.com/images/g/V9MAAOSwV3dcL425/s-l300.jpg", 1, "Controllers", 1, "NES", "Quickshot Joystick", "" },
                    { 606, 16260, 1, "https://commondatastorage.googleapis.com/jjgames-static/images/12762.JPG", 1, "Accessories", 1, "NES", "Quickshot Sighting Scope", "" },
                    { 607, 9635, 1, "", 1, "Baseball", 1, "NES", "RBI Baseball", "" },
                    { 608, 12373, 1, "", 1, "Baseball", 1, "NES", "RBI Baseball 2", "" },
                    { 609, 12374, 1, "", 1, "Baseball", 1, "NES", "RBI Baseball 3", "" },
                    { 610, 39512, 1, "", 1, "Baseball", 1, "NES", "RBI Baseball [Gray Cart]", "" },
                    { 611, 12375, 1, "", 1, "Racing", 1, "NES", "RC Pro-AM", "" },
                    { 612, 9639, 1, "", 1, "Racing", 1, "NES", "RC Pro-AM II", "" },
                    { 613, 34135, 1, "", 1, "Accessories", 1, "NES", "ROB the Robot", "" },
                    { 614, 9615, 1, "", 1, "Racing", 1, "NES", "Race America", "" },
                    { 615, 30824, 1, "", 1, "Action & Adventure", 1, "NES", "Racermate Challenge II", "" },
                    { 616, 12376, 1, "", 1, "Sports", 1, "NES", "Racket Attack", "" },
                    { 617, 12378, 1, "", 1, "Racing", 1, "NES", "Rad Racer", "" },
                    { 618, 12379, 1, "", 1, "Racing", 1, "NES", "Rad Racer II", "" },
                    { 619, 38037, 1, "", 1, "Racing", 1, "NES", "Rad Racer [5 Screw]", "" },
                    { 620, 30982, 1, "", 1, "Sports", 1, "NES", "Rad Racket: Deluxe Tennis II", "" },
                    { 621, 12380, 1, "", 1, "Action & Adventure", 1, "NES", "Raid 2020", "" },
                    { 597, 12367, 1, "https://server.emulator.games/images/nintendo/pyramid.jpg", 1, "Action & Adventure", 1, "NES", "Pyramid", "" },
                    { 596, 12366, 1, "https://www.mobygames.com/images/covers/l/202655-puzznic-nes-front-cover.jpg", 1, "Puzzle", 1, "NES", "Puzznic", "" },
                    { 595, 12365, 1, "http://www.vgmpf.com/Wiki/images/thumb/3/31/Puzzle_-_NES_-_USA.jpg/250px-Puzzle_-_NES_-_USA.jpg", 1, "Puzzle", 1, "NES", "Puzzle", "" },
                    { 594, 12364, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/9/9d/Puss_%27n_Boots_Pero%27s_Great_Adventure_Cover.jpg/220px-Puss_%27n_Boots_Pero%27s_Great_Adventure_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Puss N' Boots: Pero's Great Adventure", "" },
                    { 570, 12353, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f3/Phantom_Fighter_cover.png/220px-Phantom_Fighter_cover.png", 1, "Other", 1, "NES", "Phantom Fighter", "" },
                    { 571, 12354, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/ff/Pictionary_NES_cover.jpg/220px-Pictionary_NES_cover.jpg", 1, "Other", 1, "NES", "Pictionary", "" },
                    { 572, 12355, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/16/PinBot_NES_boxart.jpg/220px-PinBot_NES_boxart.jpg", 1, "Action & Adventure", 1, "NES", "Pin-Bot", "" },
                    { 573, 12005, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f3/P_NES.PNG/220px-P_NES.PNG", 1, "Arcade", 1, "NES", "Pinball", "" },
                    { 574, 12356, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f3/Pinball_Quest_cover.jpg/220px-Pinball_Quest_cover.jpg", 1, "Arcade", 1, "NES", "Pinball Quest", "" },
                    { 575, 37979, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f3/P_NES.PNG/220px-P_NES.PNG", 1, "Arcade", 1, "NES", "Pinball [5 Screw]", "" },
                    { 576, 12357, 1, "https://i.pinimg.com/originals/ec/5d/15/ec5d15c4fac19397f7b7362ec40b1eaa.jpg", 1, "Puzzle", 1, "NES", "Pipe Dream", "" },
                    { 577, 9558, 1, "https://www.mobygames.com/images/covers/l/33525-sid-meier-s-pirates-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Pirates", "" },
                    { 578, 12358, 1, "https://www.mobygames.com/images/covers/l/32218-platoon-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Platoon", "" },
                    { 579, 9566, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/8/86/NES_Play_Action_Football_Cover.jpg/220px-NES_Play_Action_Football_Cover.jpg", 1, "Football", 1, "NES", "Play Action Football", "" },
                    { 580, 12359, 1, "https://www.mobygames.com/images/covers/l/21411-popeye-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Popeye", "" },
                    { 622, 12381, 1, "", 1, "Action & Adventure", 1, "NES", "Raid on Bungeling Bay", "" },
                    { 581, 37988, 1, "https://www.mobygames.com/images/covers/l/21411-popeye-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Popeye [5 Screw]", "" },
                    { 583, 9575, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/9/94/Power_Blade_2_cover.png/256px-Power_Blade_2_cover.png", 1, "Action & Adventure", 1, "NES", "Power Blade 2", "" },
                    { 584, 13715, 1, "http://cdn1.sbnation.com/assets/3861165/image04.jpg", 1, "Controllers", 1, "NES", "Power Glove", "" },
                    { 585, 13761, 1, "http://image.gamevaluenow.com/nes/power_pad.jpg", 1, "Controllers", 1, "NES", "Power Pad", "" },
                    { 586, 9577, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/1f/Power_Punch_II_Cover.jpg/220px-Power_Punch_II_Cover.jpg", 1, "Fighting", 1, "NES", "Power Punch II", "" },
                    { 587, 12360, 1, "https://static.giantbomb.com/uploads/scale_medium/9/93770/2362129-nes_predator.jpg", 1, "Action & Adventure", 1, "NES", "Predator", "" },
                    { 588, 9584, 1, "https://www.mobygames.com/images/covers/l/34382-prince-of-persia-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Prince of Persia", "" },
                    { 589, 12361, 1, "https://www.mobygames.com/images/covers/l/260577-princess-tomato-in-the-salad-kingdom-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Princess Tomato in the Salad Kingdom", "" },
                    { 590, 9592, 1, "https://images-na.ssl-images-amazon.com/images/I/51VxuBhVNhL._AC_SX215_.jpg", 1, "Sports", 1, "NES", "Pro Sports Hockey", "" },
                    { 591, 12362, 1, "https://upload.wikimedia.org/wikipedia/en/8/8d/Nesprowrestlingbox.jpg", 1, "Wrestling", 1, "NES", "Pro Wrestling", "" },
                    { 592, 38001, 1, "https://upload.wikimedia.org/wikipedia/en/8/8d/Nesprowrestlingbox.jpg", 1, "Wrestling", 1, "NES", "Pro Wrestling [5 Screw]", "" },
                    { 593, 12006, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/3/3d/Punch-out_mrdream_boxart.PNG/220px-Punch-out_mrdream_boxart.PNG", 1, "Sports", 1, "NES", "Punch-Out", "" },
                    { 582, 9574, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/10/Power_Blade_Boxart.jpg/220px-Power_Blade_Boxart.jpg", 1, "Action & Adventure", 1, "NES", "Power Blade", "" },
                    { 623, 38025, 1, "", 1, "Action & Adventure", 1, "NES", "Raid on Bungeling Bay [5 Screw]", "" },
                    { 624, 12382, 1, "", 1, "Action & Adventure", 1, "NES", "Rainbow Islands", "" },
                    { 625, 12383, 1, "", 1, "Racing", 1, "NES", "Rally Bike", "" },
                    { 655, 12403, 1, "", 1, "Action & Adventure", 1, "NES", "Rygar", "" },
                    { 656, 38012, 1, "", 1, "Action & Adventure", 1, "NES", "Rygar [5 Screw]", "" },
                    { 657, 9697, 1, "", 1, "Action & Adventure", 1, "NES", "SCAT Special Cybernetic Attack Team", "" },
                    { 658, 12404, 1, "", 1, "Action & Adventure", 1, "NES", "Secret Scout", "" },
                    { 659, 12405, 1, "", 1, "Action & Adventure", 1, "NES", "Section Z", "" },
                    { 660, 38013, 1, "", 1, "Action & Adventure", 1, "NES", "Section-Z [5 Screw]", "" },
                    { 661, 12406, 1, "", 1, "Action & Adventure", 1, "NES", "Seicross", "" },
                    { 662, 13827, 1, "", 1, "Other", 1, "NES", "Sesame Street 123", "" },
                    { 663, 12408, 1, "", 1, "Other", 1, "NES", "Sesame Street ABC", "" },
                    { 664, 9720, 1, "", 1, "Other", 1, "NES", "Sesame Street ABC and 123", "" },
                    { 665, 12409, 1, "", 1, "Other", 1, "NES", "Sesame Street Big Bird's Hide and Speak", "" },
                    { 654, 38004, 1, "", 1, "Action & Adventure", 1, "NES", "Rush'n Attack [5 Screw]", "" },
                    { 666, 9721, 1, "", 1, "Other", 1, "NES", "Sesame Street Countdown", "" },
                    { 668, 12411, 1, "", 1, "Action & Adventure", 1, "NES", "Shadowgate", "" },
                    { 669, 40395, 1, "", 1, "Systems", 1, "NES", "Sharp Nintendo NES TV", "" },
                    { 670, 9729, 1, "", 1, "Action & Adventure", 1, "NES", "Shatterhand", "" },
                    { 671, 12412, 1, "", 1, "Action & Adventure", 1, "NES", "Shingen the Ruler", "" },
                    { 672, 12413, 1, "", 1, "Action & Adventure", 1, "NES", "Shinobi", "" },
                    { 673, 12414, 1, "", 1, "Action & Adventure", 1, "NES", "Shockwave", "" },
                    { 674, 12415, 1, "", 1, "Other", 1, "NES", "Shooting Range", "" },
                    { 675, 12416, 1, "", 1, "Action & Adventure", 1, "NES", "Short Order/Eggsplode", "" },
                    { 676, 12417, 1, "", 1, "Sports", 1, "NES", "Side Pocket", "" },
                    { 677, 12418, 1, "", 1, "Action & Adventure", 1, "NES", "Silent Assault", "" },
                    { 678, 12419, 1, "", 1, "Action & Adventure", 1, "NES", "Silent Service", "" },
                    { 667, 12410, 1, "", 1, "Action & Adventure", 1, "NES", "Shadow of the Ninja", "" },
                    { 653, 12402, 1, "", 1, "Action & Adventure", 1, "NES", "Rush'n Attack", "" },
                    { 652, 9687, 1, "", 1, "Basketball", 1, "NES", "Roundball 2-on-2 Challenge", "" },
                    { 651, 12401, 1, "", 1, "Strategy", 1, "NES", "Romance of the Three Kingdoms II", "" },
                    { 626, 12384, 1, "", 1, "Action & Adventure", 1, "NES", "Rambo", "" },
                    { 627, 12385, 1, "", 1, "Action & Adventure", 1, "NES", "Rampage", "" },
                    { 628, 9624, 1, "", 1, "Racing", 1, "NES", "Rampart", "" },
                    { 629, 12387, 1, "", 1, "Action & Adventure", 1, "NES", "Renegade", "" },
                    { 630, 12388, 1, "", 1, "Action & Adventure", 1, "NES", "Rescue the Embassy Mission", "" },
                    { 631, 12389, 1, "", 1, "Action & Adventure", 1, "NES", "Ring King", "" },
                    { 632, 38026, 1, "", 1, "Sports", 1, "NES", "Ring King [5 Screw]", "" },
                    { 633, 12390, 1, "", 1, "Action & Adventure", 1, "NES", "River City Ransom", "" },
                    { 634, 12391, 1, "", 1, "Action & Adventure", 1, "NES", "Road Runner", "" },
                    { 635, 12392, 1, "", 1, "Action & Adventure", 1, "NES", "RoadBlasters", "" },
                    { 636, 9669, 1, "", 1, "Action & Adventure", 1, "NES", "Robin Hood Prince of Thieves", "" },
                    { 637, 12393, 1, "", 1, "Action & Adventure", 1, "NES", "Robo Warrior", "" },
                    { 638, 9671, 1, "", 1, "Action & Adventure", 1, "NES", "RoboCop 2", "" },
                    { 639, 12394, 1, "", 1, "Action & Adventure", 1, "NES", "Robocop", "" },
                    { 640, 9673, 1, "", 1, "Action & Adventure", 1, "NES", "Robocop 3", "" },
                    { 641, 16141, 1, "", 1, "Action & Adventure", 1, "NES", "Robodemons", "" },
                    { 642, 12395, 1, "", 1, "Action & Adventure", 1, "NES", "Rock 'n Ball", "" },
                    { 643, 12396, 1, "", 1, "Action & Adventure", 1, "NES", "Rocket Ranger", "" },
                    { 644, 9678, 1, "", 1, "Action & Adventure", 1, "NES", "Rockin' Kats", "" },
                    { 645, 9681, 1, "", 1, "Baseball", 1, "NES", "Roger Clemens' MVP Baseball", "" },
                    { 646, 12397, 1, "", 1, "Sports", 1, "NES", "Roller Games", "" },
                    { 647, 12398, 1, "", 1, "Action & Adventure", 1, "NES", "Rollerball", "" },
                    { 648, 9682, 1, "", 1, "Sports", 1, "NES", "Rollerblade Racer", "" },
                    { 649, 12399, 1, "", 1, "Action & Adventure", 1, "NES", "Rolling Thunder", "" },
                    { 650, 12400, 1, "", 1, "Strategy", 1, "NES", "Romance of the Three Kingdoms", "" },
                    { 569, 12352, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/0/05/Peter_Pan_and_the_Pirates_NES_cover.jpg/220px-Peter_Pan_and_the_Pirates_NES_cover.jpg", 1, "Action & Adventure", 1, "NES", "Peter Pan and the Pirates", "" },
                    { 568, 19452, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/3/3b/PesttheWestExteBoxShotNES.jpg/220px-PesttheWestExteBoxShotNES.jpg", 1, "Action & Adventure", 1, "NES", "Pesterminator", "" },
                    { 567, 14932, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/6/65/Peek-A-Boo_Poker_Cover.jpg/220px-Peek-A-Boo_Poker_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Peek-a-Boo Poker", "" },
                    { 566, 9530, 1, "https://www.mobygames.com/images/covers/l/34384-paperboy-2-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Paperboy 2", "" },
                    { 485, 38511, 1, "https://i.pinimg.com/originals/f0/4e/31/f04e31da22c62eb2140e9c3223f0ef10.jpg", 1, "Action & Adventure", 1, "NES", "Metroid [Yellow Label]", "" },
                    { 486, 12332, 1, "https://upload.wikimedia.org/wikipedia/en/e/e6/Maworldgp.jpg", 1, "Racing", 1, "NES", "Michael Andretti's World GP", "" },
                    { 487, 9337, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/8/83/MickeyMousecapadeBoxart.jpg/220px-MickeyMousecapadeBoxart.jpg", 1, "Action & Adventure", 1, "NES", "Mickey Mousecapade", "" },
                    { 488, 9338, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/0/01/Mickey%27s_Adventures_in_Numberland_Cover.jpg/220px-Mickey%27s_Adventures_in_Numberland_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Mickey's Adventure in Numberland", "" },
                    { 489, 9339, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Mickey%27s_Safari_in_Letterland_Cover.jpg/220px-Mickey%27s_Safari_in_Letterland_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Mickey's Safari in Letterland", "" },
                    { 490, 12333, 1, "https://www.mobygames.com/images/covers/l/14469-micro-machines-nes-front-cover.jpg", 1, "Racing", 1, "NES", "Micro Machines", "" },
                    { 491, 39523, 1, "https://server.emulator.games/images/nintendo/micro-machines.jpg", 1, "Racing", 1, "NES", "Micro Machines [Aladdin]", "" },
                    { 492, 12334, 1, "https://upload.wikimedia.org/wikipedia/en/2/28/MiG_29_Soviet_Fighter_cover.jpg", 1, "Other", 1, "NES", "Mig 29", "" },
                    { 493, 9349, 1, "http://img1.game-oldies.com/sites/default/files/packshots/nintendo-nes/might-magic-secret-of-the-inner-sanctum-usa.png", 1, "Strategy", 1, "NES", "Might and Magic", "" },
                    { 494, 12002, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f9/Mighty_Bomb_Jack_cover.jpg/220px-Mighty_Bomb_Jack_cover.jpg", 1, "Action & Adventure", 1, "NES", "Mighty Bomb Jack", "" },
                    { 495, 38011, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f9/Mighty_Bomb_Jack_cover.jpg/220px-Mighty_Bomb_Jack_cover.jpg", 1, "Action & Adventure", 1, "NES", "Mighty Bomb Jack [5 Screw]", "" },
                    { 484, 37991, 1, "https://upload.wikimedia.org/wikipedia/en/5/5d/Metroid_boxart.jpg", 1, "Action & Adventure", 1, "NES", "Metroid [5 Screw]", "" },
                    { 496, 9351, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/7/7a/Mighty_Final_Fight_%28American_cover%29.jpg/220px-Mighty_Final_Fight_%28American_cover%29.jpg", 1, "Action & Adventure", 1, "NES", "Mighty Final Fight", "" },
                    { 498, 39517, 1, "https://cdn.wikimg.net/en/strategywiki/images/thumb/1/13/Mike_Tyson%27s_Punch_Out%21%21_Boxart.jpg/250px-Mike_Tyson%27s_Punch_Out%21%21_Boxart.jpg", 1, "Sports", 1, "NES", "Mike Tyson's Punch-Out [5 Screw]", "" },
                    { 499, 12336, 1, "https://www.mobygames.com/images/covers/l/175443-millipede-nes-front-cover.jpg", 1, "Arcade", 1, "NES", "Millipede", "" },
                    { 500, 12003, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/fb/Milon%27s_Secret_Castle_cover.jpg/220px-Milon%27s_Secret_Castle_cover.jpg", 1, "Action & Adventure", 1, "NES", "Milon's Secret Castle", "" },
                    { 501, 12337, 1, "http://cdn.shopify.com/s/files/1/1007/9564/products/nes_miraclepianoteachingsystem_front_grande.jpg?v=1496986037", 1, "Music", 1, "NES", "Miracle Piano", "" },
                    { 502, 50113, 1, "https://upload.wikimedia.org/wikipedia/en/3/33/Miracle_Piano_Teaching_System_cover.jpg", 1, "Accessories", 1, "NES", "Miracle Piano Keyboard", "" },
                    { 503, 19303, 1, "https://upload.wikimedia.org/wikipedia/en/3/37/Mission_Cobra_Coverart.png", 1, "Other", 1, "NES", "Mission Cobra", "" },
                    { 504, 9358, 1, "https://www.mobygames.com/images/covers/l/93129-mission-impossible-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Mission Impossible", "" },
                    { 505, 9366, 1, "https://gamefaqs.akamaized.net/box/2/8/4/5284_front.jpg", 1, "Strategy", 1, "NES", "Monopoly", "" },
                    { 506, 12338, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/4/41/Monster_Party_Box.JPG/220px-Monster_Party_Box.JPG", 1, "Action & Adventure", 1, "NES", "Monster Party", "" },
                    { 507, 12339, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/57/MonsterTruckRallyBoxShotNES.jpg/220px-MonsterTruckRallyBoxShotNES.jpg", 1, "Racing", 1, "NES", "Monster Truck Rally", "" },
                    { 508, 12340, 1, "https://gamefaqs.akamaized.net/box/4/7/0/49470_front.jpg", 1, "Action & Adventure", 1, "NES", "Monster in My Pocket", "" },
                    { 497, 12001, 1, "https://cdn.wikimg.net/en/strategywiki/images/thumb/1/13/Mike_Tyson%27s_Punch_Out%21%21_Boxart.jpg/250px-Mike_Tyson%27s_Punch_Out%21%21_Boxart.jpg", 1, "Sports", 1, "NES", "Mike Tyson's Punch-Out", "" },
                    { 483, 9331, 1, "https://upload.wikimedia.org/wikipedia/en/5/5d/Metroid_boxart.jpg", 1, "Action & Adventure", 1, "NES", "Metroid", "" },
                    { 482, 12331, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/4/46/Metal_Storm_North_American_NES_box_art.jpg/220px-Metal_Storm_North_American_NES_box_art.jpg", 1, "Action & Adventure", 1, "NES", "Metal Storm", "" },
                    { 481, 12330, 1, "https://server.emulator.games/images/nintendo/metal-mech.jpg", 1, "Action & Adventure", 1, "NES", "Metal Mech", "" },
                    { 456, 13766, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/7/76/Mappy_Land_box_art.jpg/250px-Mappy_Land_box_art.jpg", 1, "Action & Adventure", 1, "NES", "Mappy-Land", "" },
                    { 457, 12319, 1, "https://www.mobygames.com/images/covers/l/78197-marble-madness-nes-front-cover.jpg", 1, "Puzzle", 1, "NES", "Marble Madness", "" },
                    { 458, 12000, 1, "https://www.mobygames.com/images/covers/l/14501-mario-bros-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Mario Bros", "" },
                    { 459, 37987, 1, "https://www.mobygames.com/images/covers/l/14501-mario-bros-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Mario Bros [5 Screw]", "" },
                    { 460, 9287, 1, "https://www.mobygames.com/images/covers/l/246802-mario-is-missing-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Mario Is Missing", "" },
                    { 461, 9289, 1, "https://www.retrogamecases.com/wp-content/uploads/nes_mariostimemachine.jpg", 1, "Action & Adventure", 1, "NES", "Mario's Time Machine", "" },
                    { 462, 12321, 1, "https://upload.wikimedia.org/wikipedia/en/8/89/Master_Chu_and_the_Drunkard_Hu_cover.jpg", 1, "Action & Adventure", 1, "NES", "Master Chu and the Drunkard Hu", "" },
                    { 463, 14925, 1, "https://www.mobygames.com/images/covers/l/308613-maxi-15-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Maxi 15", "" },
                    { 464, 12322, 1, "https://www.mobygames.com/images/covers/l/94962-mechanized-attack-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Mechanized Attack", "" },
                    { 465, 9314, 1, "https://venturebeat.com/wp-content/uploads/2013/03/megamanbox.jpg", 1, "Action & Adventure", 1, "NES", "Mega Man", "" },
                    { 466, 37373, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/56/Megaman10.jpg/220px-Megaman10.jpg", 1, "Action & Adventure", 1, "NES", "Mega Man 10", "" },
                    { 467, 12323, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/b/be/Megaman2_box.jpg/220px-Megaman2_box.jpg", 1, "Action & Adventure", 1, "NES", "Mega Man 2", "" },
                    { 468, 53798, 1, "https://cdn.shopify.com/s/files/1/0580/0965/products/MM2_STOREIMG_SET.png?v=1539970159", 1, "Action & Adventure", 1, "NES", "Mega Man 2 [30th Anniversary Edition]", "" },
                    { 469, 9315, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/4/49/Megaman3_box.jpg/220px-Megaman3_box.jpg", 1, "Action & Adventure", 1, "NES", "Mega Man 3", "" },
                    { 470, 12324, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/8/8f/Megaman4_box.jpg/220px-Megaman4_box.jpg", 1, "Action & Adventure", 1, "NES", "Mega Man 4", "" },
                    { 471, 9316, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/2/2c/Megaman5_box.jpg/220px-Megaman5_box.jpg", 1, "Action & Adventure", 1, "NES", "Mega Man 5", "" },
                    { 472, 9317, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/17/Megaman6_box.jpg/220px-Megaman6_box.jpg", 1, "Action & Adventure", 1, "NES", "Mega Man 6", "" },
                    { 473, 34155, 1, "https://i.pinimg.com/originals/b7/3f/a2/b73fa299eeed7897f50589bfdc31faa5.jpg", 1, "Action & Adventure", 1, "NES", "Mega Man 9 Press Kit", "" },
                    { 474, 38045, 1, "https://venturebeat.com/wp-content/uploads/2013/03/megamanbox.jpg", 1, "Action & Adventure", 1, "NES", "Mega Man [5 Screw]", "" },
                    { 475, 16294, 1, "https://i.ebayimg.com/images/g/Du4AAOSwjrlaxCWA/s-l300.jpg", 1, "Other", 1, "NES", "Megacom 76", "" },
                    { 476, 12325, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/7/7a/Menace_Beach_cover.jpg/220px-Menace_Beach_cover.jpg", 1, "Action & Adventure", 1, "NES", "Menace Beach", "" },
                    { 477, 12326, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/2/2e/Mendel_Palace_Cover.jpg/220px-Mendel_Palace_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Mendel Palace", "" },
                    { 478, 12327, 1, "https://r.mprd.se/fup/up/56259-Mermaids_of_Atlantis_-_The_Riddle_of_the_Magic_Bubble_(USA)_(Unl)-1498362429.jpg", 1, "Action & Adventure", 1, "NES", "Mermaids of Atlantis", "" },
                    { 479, 12328, 1, "https://www.mobygames.com/images/covers/l/18241-metal-fighter-nes-front-cover.jpg", 1, "Fighting", 1, "NES", "Metal Fighter", "" },
                    { 480, 12329, 1, "https://www.mobygames.com/images/covers/l/79987-metal-gear-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Metal Gear", "" },
                    { 509, 21116, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/58/Moon_Ranger_Cover.jpg/220px-Moon_Ranger_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Moon Ranger", "" },
                    { 679, 12420, 1, "", 1, "Action & Adventure", 1, "NES", "Silk Worm", "" },
                    { 510, 9377, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/Motor_City_Patrol_Cover.jpg/220px-Motor_City_Patrol_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Motor City Patrol", "" },
                    { 512, 30883, 1, "https://www.mobygames.com/images/covers/l/253238-ms-pac-man-nes-front-cover.png", 1, "Arcade", 1, "NES", "Ms. Pac-Man [Tengen]", "" },
                    { 542, 40469, 1, "", 1, "Systems", 1, "NES", "Nintendo NES Power Set Console", "" },
                    { 543, 38569, 1, "", 1, "Systems", 1, "NES", "Nintendo NES Sports Set Console", "" },
                    { 544, 14933, 1, "https://www.mariowiki.com/images/thumb/2/28/Standard_Cartridge_-_Nintendo_World_Championship.jpg/1200px-Standard_Cartridge_-_Nintendo_World_Championship.jpg", 1, "Action & Adventure", 1, "NES", "Nintendo World Championship", "" },
                    { 545, 16173, 1, "https://image.gamevaluenow.com/nes/nwc_gold.jpg", 1, "Action & Adventure", 1, "NES", "Nintendo World Championship Gold", "" },
                    { 546, 38640, 1, "https://images.offerup.com/GT52uTyfcS6rTKOSkxWKARahJzg=/600x752/a74c/a74cfc419905409a9f043785f68dd580.jpg", 1, "Other", 1, "NES", "Nintendo World Championship [25th Anniversary]", "" },
                    { 547, 34873, 1, "", 1, "Action & Adventure", 1, "NES", "Nintendo World Championship [Reproduction]", "" },
                    { 548, 9492, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f0/Nintendo_World_Cup_Cover.jpg/220px-Nintendo_World_Cup_Cover.jpg", 1, "Soccer", 1, "NES", "Nintendo World Cup", "" },
                    { 549, 9495, 1, "https://r.mprd.se/fup/up/56462-Nobunaga's_Ambition_(USA)-1510806975.jpg", 1, "Strategy", 1, "NES", "Nobunaga's Ambition", "" },
                    { 550, 13108, 1, "http://img2.game-oldies.com/sites/default/files/packshots/nintendo-nes/nobunaga-s-ambition-ii-usa.png", 1, "Strategy", 1, "NES", "Nobunaga's Ambition 2", "" },
                    { 551, 12346, 1, "https://www.mobygames.com/images/covers/l/116397-north-south-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "North and South", "" },
                    { 552, 12347, 1, "https://www.mobygames.com/images/covers/l/18651-orb-3d-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "ORB 3D", "" },
                    { 541, 39977, 1, "", 1, "Systems", 1, "NES", "Nintendo NES Deluxe Set Console", "" },
                    { 553, 14281, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/d/d0/Operation_Secret_Storm_Cover.jpg/220px-Operation_Secret_Storm_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Operation Secret Storm", "" },
                    { 555, 12349, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/b/b6/Othello_%28video_game_-_box_art%29.jpg/250px-Othello_%28video_game_-_box_art%29.jpg", 1, "Puzzle", 1, "NES", "Othello", "" },
                    { 556, 9516, 1, "https://www.mobygames.com/images/covers/l/34386-overlord-nes-front-cover.jpg", 1, "Strategy", 1, "NES", "Overlord", "" },
                    { 557, 19390, 1, "https://i.ebayimg.com/images/g/uB4AAOSwO-pcD5Jq/s-l640.jpg", 1, "Strategy", 1, "NES", "P'radikus Conflict", "" },
                    { 558, 12350, 1, "https://www.mobygames.com/images/covers/l/241653-p-o-w-prisoners-of-war-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "POW Prisoners of War", "" },
                    { 559, 9518, 1, "http://images.nintendolife.com/0122e34331721/pac-man-cover.cover_large.jpg", 1, "Action & Adventure", 1, "NES", "Pac-Man [Namco]", "" },
                    { 560, 40508, 1, "https://www.mobygames.com/images/covers/l/253219-pac-man-nes-front-cover.png", 1, "Arcade", 1, "NES", "Pac-Man [Tengen Gray]", "" },
                    { 561, 30882, 1, "https://www.mobygames.com/images/covers/l/253219-pac-man-nes-front-cover.png", 1, "Arcade", 1, "NES", "Pac-Man [Tengen]", "" },
                    { 562, 12351, 1, "https://www.mobygames.com/images/covers/l/19471-pac-mania-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Pac-Mania", "" },
                    { 563, 16126, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/c/c9/Palamedes_Cover.jpg/220px-Palamedes_Cover.jpg", 1, "Other", 1, "NES", "Palamedes", "" },
                    { 564, 9523, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/4/45/Panic_Restaurant_cover.jpg/220px-Panic_Restaurant_cover.jpg", 1, "Action & Adventure", 1, "NES", "Panic Restaurant", "" },
                    { 565, 9528, 1, "https://www.mobygames.com/images/covers/l/202028-paperboy-nes-front-cover.jpg", 1, "Racing", 1, "NES", "Paperboy", "" },
                    { 554, 12348, 1, "https://www.mobygames.com/images/covers/l/14625-operation-wolf-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Operation Wolf", "" },
                    { 540, 13805, 1, "", 1, "Controllers", 1, "NES", "Nintendo NES Controller", "" },
                    { 539, 13743, 1, "", 1, "Systems", 1, "NES", "Nintendo NES Console", "" },
                    { 538, 37198, 1, "", 1, "Controllers", 1, "NES", "Nintendo NES Classic Edition Controller", "" },
                    { 513, 12341, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/Muppet_Adventure_Chaos_at_the_Carnival_Cover.jpg/250px-Muppet_Adventure_Chaos_at_the_Carnival_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Muppet Adventure", "" },
                    { 514, 9390, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/5e/The_Mutant_Virus_-_Crisis_in_a_Computer_World_Coverart.jpg/220px-The_Mutant_Virus_-_Crisis_in_a_Computer_World_Coverart.jpg", 1, "Action & Adventure", 1, "NES", "Mutant Virus", "" },
                    { 515, 14929, 1, "https://upload.wikimedia.org/wikipedia/commons/6/62/6in1myriad.jpg", 1, "Action & Adventure", 1, "NES", "Myriad 6-in-1", "" },
                    { 516, 12342, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/6/6c/MysteryQuestNABoxart.jpg/220px-MysteryQuestNABoxart.jpg", 1, "Action & Adventure", 1, "NES", "Mystery Quest", "" },
                    { 517, 12343, 1, "https://www.mobygames.com/images/covers/l/175624-narc-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "NARC", "" },
                    { 518, 16388, 1, "https://images-na.ssl-images-amazon.com/images/I/51jjr9lsIcL.jpg", 1, "Controllers", 1, "NES", "NES Advantage Controller", "" },
                    { 519, 16389, 1, "https://images-na.ssl-images-amazon.com/images/I/51dKXsPNaFL._AC_.jpg", 1, "Accessories", 1, "NES", "NES Four Score", "" },
                    { 520, 21587, 1, "http://www.thealmightyguru.com/Wiki/images/7/7b/NES_Max_-_Box_-_Front.jpg", 1, "Controllers", 1, "NES", "NES Max Controller", "" },
                    { 521, 9449, 1, "https://upload.wikimedia.org/wikipedia/en/f/f8/Nesopen.jpg", 1, "Sports", 1, "NES", "NES Open Tournament Golf", "" },
                    { 522, 19364, 1, "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/NES-Satellite.jpg/1200px-NES-Satellite.jpg", 1, "Accessories", 1, "NES", "NES Satellite 4 Controller Port", "" },
                    { 523, 9459, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/c/ce/NFL_Football_1988_NES_cover.jpg/220px-NFL_Football_1988_NES_cover.jpg", 1, "Football", 1, "NES", "NFL Football", "" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApiGameId", "CibPrice", "CoverURL", "GameConsoleId", "Genre", "LoosePrice", "SystemId", "Title", "Upc" },
                values: new object[,]
                {
                    { 524, 21251, 1, "http://nintendoagemedia.com/elements_nocache/7702D98E-C197-9472-6F47310219681A2D.jpg", 1, "Other", 1, "NES", "NTF2 Test Cartridge", "" },
                    { 525, 9483, 1, "https://www.mobygames.com/images/covers/l/146968-nigel-mansell-s-world-championship-racing-nes-front-cover.jpg", 1, "Racing", 1, "NES", "Nigel Mansell's World Championship Racing", "" },
                    { 526, 9487, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/d/d7/Nightshade_%28NES%29_Coverart.png/220px-Nightshade_%28NES%29_Coverart.png", 1, "Action & Adventure", 1, "NES", "Nightshade", "" },
                    { 527, 12344, 1, "https://www.mobygames.com/images/covers/l/294267-ninja-crusaders-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Ninja Crusaders", "" },
                    { 528, 9488, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/9/9b/Ninja_Gaiden_%28NES%29.jpg/220px-Ninja_Gaiden_%28NES%29.jpg", 1, "Action & Adventure", 1, "NES", "Ninja Gaiden", "" },
                    { 529, 12004, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/6/66/Ninja_Gaiden_II-_The_Dark_Sword_of_Chaos_boxart.jpg/220px-Ninja_Gaiden_II-_The_Dark_Sword_of_Chaos_boxart.jpg", 1, "Action & Adventure", 1, "NES", "Ninja Gaiden II The Dark Sword of Chaos", "" },
                    { 530, 9490, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/Ninja_Gaiden_III_The_Ancient_Ship_of_Doom.jpg/220px-Ninja_Gaiden_III_The_Ancient_Ship_of_Doom.jpg", 1, "Action & Adventure", 1, "NES", "Ninja Gaiden III Ancient Ship of Doom", "" },
                    { 531, 12345, 1, "https://images-na.ssl-images-amazon.com/images/I/51A4D1yqAsL._AC_SX215_.jpg", 1, "Action & Adventure", 1, "NES", "Ninja Kid", "" },
                    { 532, 37995, 1, "https://images-na.ssl-images-amazon.com/images/I/51A4D1yqAsL._AC_SX215_.jpg", 1, "Action & Adventure", 1, "NES", "Ninja Kid [5 Screw]", "" },
                    { 533, 19387, 1, "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8e/Campus-challenge-1991.jpg/220px-Campus-challenge-1991.jpg", 1, "Other", 1, "NES", "Nintendo Campus Challenge 1991", "" },
                    { 534, 34874, 1, "https://www.retrousb.com/images/ncc_med.png", 1, "Action & Adventure", 1, "NES", "Nintendo Campus Challenge 1991 [Reproduction]", "" },
                    { 535, 38568, 1, "", 1, "Systems", 1, "NES", "Nintendo NES Action Set Console", "" },
                    { 536, 38570, 1, "", 1, "Systems", 1, "NES", "Nintendo NES Challenge Set Console", "" },
                    { 537, 37130, 1, "", 1, "Systems", 1, "NES", "Nintendo NES Classic Edition", "" },
                    { 511, 9382, 1, "https://cdn11.bigcommerce.com/s-ymgqt/images/stencil/300x300/products/28734/19904/Game_Nintendo_NES_MS_Pac_Namco-2__19232.1394743515.jpg?c=2&imbypass=on", 1, "Action & Adventure", 1, "NES", "Ms. Pac-Man (Namco)", "" },
                    { 680, 12421, 1, "", 1, "Action & Adventure", 1, "NES", "Silver Surfer", "" },
                    { 681, 12422, 1, "", 1, "Extreme Sports", 1, "NES", "Skate or Die", "" },
                    { 682, 12423, 1, "", 1, "Extreme Sports", 1, "NES", "Skate or Die 2", "" },
                    { 826, 12499, 1, "", 1, "Sports", 1, "NES", "Track and Field II", "" },
                    { 827, 38005, 1, "", 1, "Sports", 1, "NES", "Track and Field [5 Screw]", "" },
                    { 828, 10064, 1, "", 1, "Action & Adventure", 1, "NES", "Treasure Master", "" },
                    { 829, 10068, 1, "", 1, "Action & Adventure", 1, "NES", "Trog", "" },
                    { 830, 12500, 1, "", 1, "Action & Adventure", 1, "NES", "Trojan", "" },
                    { 831, 38000, 1, "", 1, "Action & Adventure", 1, "NES", "Trojan [5 Screw]", "" },
                    { 832, 12501, 1, "", 1, "Action & Adventure", 1, "NES", "Trolls on Treasure Island", "" },
                    { 833, 12502, 1, "", 1, "Action & Adventure", 1, "NES", "Twin Cobra", "" },
                    { 834, 12503, 1, "", 1, "Action & Adventure", 1, "NES", "Twin Eagle", "" },
                    { 835, 54274, 1, "", 1, "Controllers", 1, "NES", "UForce", "" },
                    { 836, 12504, 1, "", 1, "RPG", 1, "NES", "Ultima Exodus", "" },
                    { 825, 12498, 1, "", 1, "Sports", 1, "NES", "Track and Field", "" },
                    { 837, 12505, 1, "", 1, "RPG", 1, "NES", "Ultima Quest of the Avatar", "" },
                    { 839, 10081, 1, "", 1, "Action & Adventure", 1, "NES", "Ultimate Air Combat", "" },
                    { 840, 12506, 1, "", 1, "Basketball", 1, "NES", "Ultimate Basketball", "" },
                    { 841, 12507, 1, "", 1, "Soccer", 1, "NES", "Ultimate League Soccer", "" },
                    { 842, 12481, 1, "", 1, "Action & Adventure", 1, "NES", "Ultimate Stuntman", "" },
                    { 843, 10090, 1, "", 1, "Strategy", 1, "NES", "Uncharted Waters", "" },
                    { 844, 10091, 1, "", 1, "Action & Adventure", 1, "NES", "Uninvited", "" },
                    { 845, 12012, 1, "", 1, "Action & Adventure", 1, "NES", "Urban Champion", "" },
                    { 846, 37989, 1, "", 1, "Action & Adventure", 1, "NES", "Urban Champion [5 Screw]", "" },
                    { 847, 12508, 1, "", 1, "Other", 1, "NES", "Vegas Dream", "" },
                    { 848, 12509, 1, "", 1, "Sports", 1, "NES", "Venice Beach Volleyball", "" },
                    { 849, 12510, 1, "", 1, "Action & Adventure", 1, "NES", "Vice Project Doom", "" },
                    { 838, 10080, 1, "", 1, "RPG", 1, "NES", "Ultima Warriors of Destiny", "" },
                    { 824, 10056, 1, "", 1, "Action & Adventure", 1, "NES", "Toxic Crusaders", "" },
                    { 823, 12461, 1, "", 1, "Sports", 1, "NES", "Town & Country Surf Designs: Wood and Water Rage", "" },
                    { 822, 12483, 1, "", 1, "Action & Adventure", 1, "NES", "Town & Country II: Thrilla's Surfari", "" },
                    { 797, 10096, 1, "", 1, "Action & Adventure", 1, "NES", "The Untouchables", "" },
                    { 798, 12484, 1, "", 1, "Action & Adventure", 1, "NES", "Thunder and Lightning", "" },
                    { 799, 12485, 1, "", 1, "Action & Adventure", 1, "NES", "Thunderbirds", "" },
                    { 800, 12486, 1, "", 1, "Action & Adventure", 1, "NES", "Thundercade", "" },
                    { 801, 12487, 1, "", 1, "Other", 1, "NES", "Tiger-Heli", "" },
                    { 802, 38033, 1, "", 1, "Action & Adventure", 1, "NES", "Tiger-Heli [5 Screw]", "" },
                    { 803, 12488, 1, "", 1, "Puzzle", 1, "NES", "Tiles of Fate", "" },
                    { 804, 12489, 1, "", 1, "Action & Adventure", 1, "NES", "Time Lord", "" },
                    { 805, 10020, 1, "", 1, "RPG", 1, "NES", "Times of Lore", "" },
                    { 806, 10021, 1, "", 1, "Action & Adventure", 1, "NES", "Tiny Toon Adventures", "" },
                    { 807, 10022, 1, "", 1, "Action & Adventure", 1, "NES", "Tiny Toon Adventures 2 Trouble in Wackyland", "" },
                    { 808, 10024, 1, "", 1, "Action & Adventure", 1, "NES", "Tiny Toon Adventures Cartoon Workshop", "" },
                    { 809, 12490, 1, "", 1, "Action & Adventure", 1, "NES", "To the Earth", "" },
                    { 810, 12491, 1, "", 1, "Action & Adventure", 1, "NES", "Toki", "" },
                    { 811, 10035, 1, "", 1, "Action & Adventure", 1, "NES", "Tom and Jerry", "" },
                    { 812, 12492, 1, "", 1, "Action & Adventure", 1, "NES", "Tombs and Treasure", "" },
                    { 813, 12493, 1, "", 1, "Action & Adventure", 1, "NES", "Toobin'", "" },
                    { 814, 12494, 1, "", 1, "Action & Adventure", 1, "NES", "Top Gun", "" },
                    { 815, 10052, 1, "", 1, "Other", 1, "NES", "Top Gun The Second Mission", "" },
                    { 816, 38044, 1, "", 1, "Action & Adventure", 1, "NES", "Top Gun [5 Screw]", "" },
                    { 817, 13883, 1, "", 1, "Systems", 1, "NES", "Top Loading Nintendo NES Console", "" },
                    { 818, 12495, 1, "", 1, "Sports", 1, "NES", "Top Players Tennis", "" },
                    { 819, 10053, 1, "", 1, "Action & Adventure", 1, "NES", "Total Recall", "" },
                    { 820, 12496, 1, "", 1, "Racing", 1, "NES", "Totally Rad", "" },
                    { 821, 12497, 1, "", 1, "Football", 1, "NES", "Touchdown Fever", "" },
                    { 850, 10105, 1, "", 1, "Other", 1, "NES", "Videomation", "" },
                    { 796, 12482, 1, "", 1, "Action & Adventure", 1, "NES", "The Uncanny X-Men", "" },
                    { 851, 12511, 1, "", 1, "Action & Adventure", 1, "NES", "Vindicators", "" },
                    { 853, 38003, 1, "", 1, "Sports", 1, "NES", "Volleyball [5 Screw]", "" },
                    { 883, 12528, 1, "", 1, "RPG", 1, "NES", "Wizards and Warriors", "" },
                    { 884, 10167, 1, "", 1, "Action & Adventure", 1, "NES", "Wizards and Warriors III Kuros Visions of Power", "" },
                    { 885, 38046, 1, "", 1, "Action & Adventure", 1, "NES", "Wizards and Warriors [5 Screw]", "" },
                    { 886, 10169, 1, "", 1, "Action & Adventure", 1, "NES", "Wolverine", "" },
                    { 887, 10172, 1, "", 1, "Sports", 1, "NES", "World Champ", "" },
                    { 888, 12530, 1, "", 1, "Sports", 1, "NES", "World Class Track Meet", "" },
                    { 889, 12532, 1, "", 1, "Sports", 1, "NES", "World Games", "" },
                    { 890, 12533, 1, "", 1, "Action & Adventure", 1, "NES", "Wrath of the Black Manta", "" },
                    { 891, 12014, 1, "", 1, "Action & Adventure", 1, "NES", "Wrecking Crew", "" },
                    { 892, 37975, 1, "", 1, "Action & Adventure", 1, "NES", "Wrecking Crew [5 Screw]", "" },
                    { 893, 10208, 1, "", 1, "Action & Adventure", 1, "NES", "Wurm Journey to the Center of the Earth", "" },
                    { 882, 19592, 1, "", 1, "RPG", 1, "NES", "Wizardry: Proving Grounds of the Mad Overlord", "" },
                    { 894, 12534, 1, "", 1, "Action & Adventure", 1, "NES", "Xenophobe", "" },
                    { 896, 12535, 1, "", 1, "Action & Adventure", 1, "NES", "Xexyz", "" },
                    { 897, 12536, 1, "", 1, "Action & Adventure", 1, "NES", "Yo Noid", "" },
                    { 898, 10228, 1, "", 1, "Puzzle", 1, "NES", "Yoshi", "" },
                    { 899, 10229, 1, "", 1, "Puzzle", 1, "NES", "Yoshi's Cookie", "" },
                    { 900, 10230, 1, "", 1, "Action & Adventure", 1, "NES", "Young Indiana Jones Chronicles", "" },
                    { 901, 12016, 1, "", 1, "Action & Adventure", 1, "NES", "Zanac", "" },
                    { 902, 38038, 1, "", 1, "Action & Adventure", 1, "NES", "Zanac [5 Screw]", "" },
                    { 903, 13716, 1, "", 1, "Controllers", 1, "NES", "Zapper Light Gun", "" },
                    { 904, 10234, 1, "", 1, "RPG", 1, "NES", "Zelda II The Adventure of Link", "" },
                    { 905, 38510, 1, "", 1, "Action & Adventure", 1, "NES", "Zelda II The Adventure of Link [Gray Cart]", "" },
                    { 906, 20786, 1, "", 1, "Other", 1, "NES", "Zelda Test Cartridge", "" },
                    { 895, 12015, 1, "", 1, "Action & Adventure", 1, "NES", "Xevious", "" },
                    { 881, 10166, 1, "", 1, "RPG", 1, "NES", "Wizardry: Knight of Diamonds Second Scenario", "" },
                    { 880, 38034, 1, "", 1, "Sports", 1, "NES", "Winter Games [5 Screw]", "" },
                    { 879, 12525, 1, "", 1, "Sports", 1, "NES", "Winter Games", "" },
                    { 854, 12512, 1, "", 1, "Wrestling", 1, "NES", "WCW World Championship Wrestling", "" },
                    { 855, 10214, 1, "", 1, "Wrestling", 1, "NES", "WWF King of the Ring", "" },
                    { 856, 10221, 1, "", 1, "Wrestling", 1, "NES", "WWF Wrestlemania", "" },
                    { 857, 13833, 1, "", 1, "Wrestling", 1, "NES", "WWF Wrestlemania Challenge", "" },
                    { 858, 10218, 1, "", 1, "Wrestling", 1, "NES", "WWF Wrestlemania Steel Cage Challenge", "" },
                    { 859, 10132, 1, "", 1, "Racing", 1, "NES", "Wacky Races", "" },
                    { 860, 10133, 1, "", 1, "Strategy", 1, "NES", "Wall Street Kid", "" },
                    { 861, 12513, 1, "", 1, "Action & Adventure", 1, "NES", "Wally Bear and the No Gang", "" },
                    { 862, 10138, 1, "", 1, "Puzzle", 1, "NES", "Wario's Woods", "" },
                    { 863, 12514, 1, "", 1, "Sports", 1, "NES", "Wayne Gretzky Hockey", "" },
                    { 864, 10146, 1, "", 1, "Action & Adventure", 1, "NES", "Wayne's World", "" },
                    { 865, 12515, 1, "", 1, "Action & Adventure", 1, "NES", "Werewolf", "" },
                    { 866, 12517, 1, "", 1, "Other", 1, "NES", "Wheel of Fortune", "" },
                    { 867, 12516, 1, "", 1, "Other", 1, "NES", "Wheel of Fortune Family Edition", "" },
                    { 868, 10149, 1, "", 1, "Other", 1, "NES", "Wheel of Fortune Featuring Vanna White", "" },
                    { 869, 12518, 1, "", 1, "Other", 1, "NES", "Wheel of Fortune Junior Edition", "" },
                    { 870, 10152, 1, "", 1, "Action & Adventure", 1, "NES", "Where in Time is Carmen Sandiego", "" },
                    { 871, 12519, 1, "", 1, "Other", 1, "NES", "Where's Waldo", "" },
                    { 872, 12520, 1, "", 1, "Action & Adventure", 1, "NES", "Who Framed Roger Rabbit", "" },
                    { 873, 12521, 1, "", 1, "Action & Adventure", 1, "NES", "Whomp 'Em", "" },
                    { 874, 10154, 1, "", 1, "Action & Adventure", 1, "NES", "Widget", "" },
                    { 875, 12522, 1, "", 1, "Other", 1, "NES", "Wild Gunman", "" },
                    { 876, 37974, 1, "", 1, "Action & Adventure", 1, "NES", "Wild Gunman [5 Screw]", "" },
                    { 877, 12523, 1, "", 1, "Action & Adventure", 1, "NES", "Willow", "" },
                    { 878, 12524, 1, "", 1, "Other", 1, "NES", "Win Lose or Draw", "" },
                    { 852, 12013, 1, "", 1, "Sports", 1, "NES", "Volleyball", "" },
                    { 455, 12317, 1, "https://www.mobygames.com/images/covers/l/44818-maniac-mansion-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Maniac Mansion", "" },
                    { 795, 12480, 1, "", 1, "Action & Adventure", 1, "NES", "The Three Stooges", "" },
                    { 793, 12197, 1, "", 1, "Action & Adventure", 1, "NES", "The Simpsons Bart vs the World", "" },
                    { 712, 16127, 1, "", 1, "Other", 1, "NES", "Stack Up", "" },
                    { 713, 9839, 1, "", 1, "Action & Adventure", 1, "NES", "Stanley The Search for Dr Livingston", "" },
                    { 714, 12439, 1, "", 1, "Action & Adventure", 1, "NES", "Star Force", "" },
                    { 715, 38042, 1, "", 1, "Action & Adventure", 1, "NES", "Star Force [5 Screw]", "" },
                    { 716, 12009, 1, "", 1, "Other", 1, "NES", "Star Soldier", "" },
                    { 717, 9842, 1, "", 1, "Action & Adventure", 1, "NES", "Star Trek 25th Anniversary", "" },
                    { 718, 9847, 1, "", 1, "Action & Adventure", 1, "NES", "Star Trek The Next Generation", "" },
                    { 719, 9848, 1, "", 1, "Strategy", 1, "NES", "Star Tropics", "" },
                    { 720, 10238, 1, "", 1, "RPG", 1, "NES", "Star Tropics II: Zoda's Revenge", "" },
                    { 721, 12440, 1, "", 1, "Action & Adventure", 1, "NES", "Star Voyager", "" },
                    { 722, 38031, 1, "", 1, "Action & Adventure", 1, "NES", "Star Voyager [5 Screw]", "" },
                    { 711, 12438, 1, "", 1, "Action & Adventure", 1, "NES", "Sqoon", "" },
                    { 723, 9849, 1, "", 1, "Action & Adventure", 1, "NES", "Star Wars", "" },
                    { 725, 12441, 1, "", 1, "Action & Adventure", 1, "NES", "Starship Hector", "" },
                    { 726, 18720, 1, "", 1, "Other", 1, "NES", "Stealth", "" },
                    { 727, 12443, 1, "", 1, "Action & Adventure", 1, "NES", "Stinger", "" },
                    { 728, 12444, 1, "", 1, "Action & Adventure", 1, "NES", "Street Cop", "" },
                    { 729, 12445, 1, "", 1, "Fighting", 1, "NES", "Street Fighter 2010 the Final Fight", "" },
                    { 730, 12446, 1, "", 1, "Action & Adventure", 1, "NES", "Strider", "" },
                    { 731, 12447, 1, "", 1, "Action & Adventure", 1, "NES", "Stunt Kids", "" },
                    { 732, 19476, 1, "", 1, "Action & Adventure", 1, "NES", "Sunday Funday", "" },
                    { 733, 9883, 1, "", 1, "Other", 1, "NES", "Super C", "" },
                    { 734, 12448, 1, "", 1, "Racing", 1, "NES", "Super Cars", "" },
                    { 735, 12449, 1, "", 1, "Sports", 1, "NES", "Super Dodge Ball", "" },
                    { 724, 9857, 1, "", 1, "Action & Adventure", 1, "NES", "Star Wars The Empire Strikes Back", "" },
                    { 710, 9832, 1, "", 1, "Action & Adventure", 1, "NES", "Spy vs. Spy", "" },
                    { 709, 38029, 1, "", 1, "Racing", 1, "NES", "Spy Hunter [5 Screw]", "" },
                    { 708, 12437, 1, "", 1, "Action & Adventure", 1, "NES", "Spy Hunter", "" },
                    { 683, 12424, 1, "", 1, "Extreme Sports", 1, "NES", "Ski or Die", "" },
                    { 684, 12425, 1, "", 1, "Action & Adventure", 1, "NES", "Skull and Crossbones", "" },
                    { 685, 12426, 1, "", 1, "Action & Adventure", 1, "NES", "Sky Kid", "" },
                    { 686, 38027, 1, "", 1, "Action & Adventure", 1, "NES", "Sky Kid [5 Screw]", "" },
                    { 687, 12427, 1, "", 1, "Action & Adventure", 1, "NES", "Sky Shark", "" },
                    { 688, 12428, 1, "", 1, "Sports", 1, "NES", "Slalom", "" },
                    { 689, 38019, 1, "", 1, "Sports", 1, "NES", "Slalom [5 Screw]", "" },
                    { 690, 9764, 1, "", 1, "Action & Adventure", 1, "NES", "Smash TV", "" },
                    { 691, 12429, 1, "", 1, "Action & Adventure", 1, "NES", "Snake Rattle n Roll", "" },
                    { 692, 9765, 1, "", 1, "Action & Adventure", 1, "NES", "Snake's Revenge", "" },
                    { 693, 12430, 1, "", 1, "Sports", 1, "NES", "Snoopy Silly Sports", "" },
                    { 694, 9768, 1, "", 1, "Puzzle", 1, "NES", "Snow Brothers", "" },
                    { 695, 12007, 1, "", 1, "Soccer", 1, "NES", "Soccer", "" },
                    { 696, 38002, 1, "", 1, "Soccer", 1, "NES", "Soccer [5 Screw]", "" },
                    { 697, 12431, 1, "", 1, "Action & Adventure", 1, "NES", "Solar Jetman", "" },
                    { 698, 12432, 1, "", 1, "Other", 1, "NES", "Solitaire", "" },
                    { 699, 12008, 1, "", 1, "Action & Adventure", 1, "NES", "Solomon's Key", "" },
                    { 700, 38014, 1, "", 1, "Action & Adventure", 1, "NES", "Solomon's Key [5 Screw]", "" },
                    { 701, 9776, 1, "", 1, "Puzzle", 1, "NES", "Solstice", "" },
                    { 702, 9803, 1, "", 1, "Other", 1, "NES", "Space Shuttle", "" },
                    { 703, 12434, 1, "", 1, "Action & Adventure", 1, "NES", "Spelunker", "" },
                    { 704, 38028, 1, "", 1, "Action & Adventure", 1, "NES", "Spelunker [5 Screw]", "" },
                    { 705, 10594, 1, "", 1, "Action & Adventure", 1, "NES", "Spiderman Return of the Sinister Six", "" },
                    { 706, 12436, 1, "", 1, "Action & Adventure", 1, "NES", "Spiritual Warfare", "" },
                    { 707, 9830, 1, "", 1, "Strategy", 1, "NES", "Spot", "" },
                    { 736, 12450, 1, "", 1, "Sports", 1, "NES", "Super Glove Ball", "" },
                    { 794, 9751, 1, "", 1, "Action & Adventure", 1, "NES", "The Simpsons Bartman Meets Radioactive Man", "" },
                    { 737, 9889, 1, "", 1, "Action & Adventure", 1, "NES", "Super Mario Bros", "" },
                    { 739, 9891, 1, "", 1, "Action & Adventure", 1, "NES", "Super Mario Bros 3", "" },
                    { 769, 12468, 1, "", 1, "Action & Adventure", 1, "NES", "Teenage Mutant Ninja Turtles II", "" },
                    { 770, 9942, 1, "", 1, "Action & Adventure", 1, "NES", "Teenage Mutant Ninja Turtles III The Manhattan Project", "" },
                    { 771, 9944, 1, "", 1, "Fighting", 1, "NES", "Teenage Mutant Ninja Turtles Tournament Fighters", "" },
                    { 772, 12011, 1, "", 1, "Sports", 1, "NES", "Tennis", "" },
                    { 773, 37982, 1, "", 1, "Sports", 1, "NES", "Tennis [5 Screw]", "" },
                    { 774, 9951, 1, "", 1, "Action & Adventure", 1, "NES", "Terminator", "" },
                    { 775, 9953, 1, "", 1, "Action & Adventure", 1, "NES", "Terminator 2 Judgment Day", "" },
                    { 776, 12469, 1, "", 1, "Action & Adventure", 1, "NES", "Terra Cresta", "" },
                    { 777, 9964, 1, "", 1, "Puzzle", 1, "NES", "Tetris", "" },
                    { 778, 9966, 1, "", 1, "Puzzle", 1, "NES", "Tetris 2", "" },
                    { 779, 12595, 1, "", 1, "Puzzle", 1, "NES", "Tetris [Tengen]", "" },
                    { 768, 9941, 1, "", 1, "Action & Adventure", 1, "NES", "Teenage Mutant Ninja Turtles", "" },
                    { 780, 8471, 1, "", 1, "Action & Adventure", 1, "NES", "The Adventures of Rocky and Bullwinkle and Friends", "" },
                    { 782, 38040, 1, "", 1, "Action & Adventure", 1, "NES", "The Goonies II [5 Screw]", "" },
                    { 783, 12472, 1, "", 1, "Action & Adventure", 1, "NES", "The Guardian Legend", "" },
                    { 784, 9990, 1, "", 1, "Action & Adventure", 1, "NES", "The Jungle Book", "" },
                    { 785, 12474, 1, "", 1, "Action & Adventure", 1, "NES", "The Karate Kid", "" },
                    { 786, 12475, 1, "", 1, "Action & Adventure", 1, "NES", "The Last Ninja", "" },
                    { 787, 12477, 1, "", 1, "Action & Adventure", 1, "NES", "The Mafat Conspiracy", "" },
                    { 788, 12478, 1, "", 1, "Action & Adventure", 1, "NES", "The Magic of Scheherazade", "" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApiGameId", "CibPrice", "CoverURL", "GameConsoleId", "Genre", "LoosePrice", "SystemId", "Title", "Upc" },
                values: new object[,]
                {
                    { 789, 9997, 1, "", 1, "Action & Adventure", 1, "NES", "The Punisher", "" },
                    { 790, 9648, 1, "", 1, "Action & Adventure", 1, "NES", "The Ren and Stimpy Show Buckeroos", "" },
                    { 791, 9677, 1, "", 1, "Action & Adventure", 1, "NES", "The Rocketeer", "" },
                    { 792, 12479, 1, "", 1, "Action & Adventure", 1, "NES", "The Simpsons Bart vs the Space Mutants", "" },
                    { 781, 12471, 1, "", 1, "Action & Adventure", 1, "NES", "The Goonies II", "" },
                    { 767, 9938, 1, "", 1, "Wrestling", 1, "NES", "Tecmo World Wrestling", "" },
                    { 766, 9934, 1, "", 1, "Football", 1, "NES", "Tecmo Super Bowl", "" },
                    { 765, 9931, 1, "", 1, "Basketball", 1, "NES", "Tecmo NBA Basketball", "" },
                    { 740, 12452, 1, "", 1, "Action & Adventure", 1, "NES", "Super Mario Bros Duck Hunt World Class Track Meet", "" },
                    { 741, 37981, 1, "", 1, "Action & Adventure", 1, "NES", "Super Mario Bros [5 Screw]", "" },
                    { 742, 12451, 1, "", 1, "Action & Adventure", 1, "NES", "Super Mario Bros and Duck Hunt", "" },
                    { 743, 12453, 1, "", 1, "Racing", 1, "NES", "Super Off Road", "" },
                    { 744, 12454, 1, "", 1, "Action & Adventure", 1, "NES", "Super Pitfall", "" },
                    { 745, 38043, 1, "", 1, "Action & Adventure", 1, "NES", "Super Pitfall [5 Screw]", "" },
                    { 746, 9898, 1, "", 1, "Sports", 1, "NES", "Super Spike Volleyball", "" },
                    { 747, 12455, 1, "", 1, "Sports", 1, "NES", "Super Spike Volleyball and World Cup Soccer", "" },
                    { 748, 12456, 1, "", 1, "Racing", 1, "NES", "Super Sprint", "" },
                    { 749, 9899, 1, "", 1, "Racing", 1, "NES", "Super Spy Hunter", "" },
                    { 750, 12457, 1, "", 1, "Sports", 1, "NES", "Super Team Games", "" },
                    { 751, 12458, 1, "", 1, "Action & Adventure", 1, "NES", "Superman", "" },
                    { 752, 9913, 1, "", 1, "Action & Adventure", 1, "NES", "Swamp Thing", "" },
                    { 753, 19306, 1, "", 1, "Action & Adventure", 1, "NES", "Sword Master", "" },
                    { 754, 12459, 1, "", 1, "Action & Adventure", 1, "NES", "Swords and Serpents", "" },
                    { 755, 12462, 1, "", 1, "Action & Adventure", 1, "NES", "Taboo the Sixth Sense", "" },
                    { 756, 12463, 1, "", 1, "Wrestling", 1, "NES", "Tag Team Wrestling", "" },
                    { 757, 37994, 1, "", 1, "Wrestling", 1, "NES", "Tag Team Wrestling [5 Screw]", "" },
                    { 758, 30846, 1, "", 1, "Action & Adventure", 1, "NES", "Tagin' Dragon", "" },
                    { 759, 12162, 1, "", 1, "Action & Adventure", 1, "NES", "TaleSpin", "" },
                    { 760, 12465, 1, "", 1, "Other", 1, "NES", "Talking Super Jeopardy", "" },
                    { 761, 12466, 1, "", 1, "Action & Adventure", 1, "NES", "Target Renegade", "" },
                    { 762, 12467, 1, "", 1, "Baseball", 1, "NES", "Tecmo Baseball", "" },
                    { 763, 9929, 1, "", 1, "Football", 1, "NES", "Tecmo Bowl", "" },
                    { 764, 9930, 1, "", 1, "Soccer", 1, "NES", "Tecmo Cup Soccer", "" },
                    { 738, 12010, 1, "", 1, "Action & Adventure", 1, "NES", "Super Mario Bros 2", "" },
                    { 454, 12316, 1, "https://www.mobygames.com/images/covers/l/127932-major-league-baseball-nes-front-cover.jpg", 1, "Baseball", 1, "NES", "Major League Baseball", "" },
                    { 453, 12315, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/c/cf/MagMax_Cover.jpg/250px-MagMax_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Magmax", "" },
                    { 452, 12314, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/5d/Magician_Cover.jpg/220px-Magician_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Magician", "" },
                    { 143, 8706, 1, "https://www.mobygames.com/images/covers/l/41555-castlevania-iii-dracula-s-curse-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Castlevania III Dracula's Curse", "" },
                    { 144, 38007, 1, "https://www.mobygames.com/images/covers/l/41554-castlevania-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Castlevania [5 Screw]", "" },
                    { 145, 12126, 1, "https://www.mobygames.com/images/covers/l/247160-caveman-ugh-lympics-nes-front-cover.jpg", 1, "Party", 1, "NES", "Caveman Games", "" },
                    { 146, 16130, 1, "https://upload.wikimedia.org/wikipedia/en/c/c2/Challenge_of_the_Dragon_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Challenge of the Dragon", "" },
                    { 147, 8713, 1, "https://www.mobygames.com/images/covers/l/111029-championship-bowling-nes-front-cover.jpg", 1, "Sports", 1, "NES", "Championship Bowling", "" },
                    { 148, 8714, 1, "https://upload.wikimedia.org/wikipedia/en/d/d6/NESPool.jpg", 1, "Sports", 1, "NES", "Championship Pool", "" },
                    { 149, 14927, 1, "https://static.miraheze.org/crappygameswiki/thumb/b/b4/CHEEH.PNG/411px-CHEEH.PNG", 1, "Action & Adventure", 1, "NES", "Cheetahmen II", "" },
                    { 150, 8722, 1, "https://cdn11.bigcommerce.com/s-m92i69d8x0/images/stencil/1280x1775/products/6196/8136/TheChessMasterNES15252_f__53024.1502153741.jpg", 1, "Strategy", 1, "NES", "Chessmaster", "" },
                    { 151, 8729, 1, "https://upload.wikimedia.org/wikipedia/en/9/9f/Chiller_NES_cover.jpg", 1, "Action & Adventure", 1, "NES", "Chiller", "" },
                    { 152, 12127, 1, "https://upload.wikimedia.org/wikipedia/en/0/02/Chip_%27n_Dale_Rescue_Rangers_NES_Cover.png", 1, "Action & Adventure", 1, "NES", "Chip and Dale Rescue Rangers", "" },
                    { 153, 8730, 1, "https://upload.wikimedia.org/wikipedia/en/e/e1/Chip-and-dale-rescue-rangers-2-cover.jpg", 1, "Action & Adventure", 1, "NES", "Chip and Dale Rescue Rangers 2", "" },
                    { 142, 11984, 1, "https://www.mobygames.com/images/covers/l/24055-castlevania-ii-simon-s-quest-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Castlevania II Simon's Quest", "" },
                    { 154, 12128, 1, "https://upload.wikimedia.org/wikipedia/en/2/25/Chubby_Cherub_Coverart.png", 1, "Action & Adventure", 1, "NES", "Chubby Cherub", "" },
                    { 156, 12130, 1, "https://upload.wikimedia.org/wikipedia/en/2/2a/City_Connection_NA_NESboxart.png", 1, "Action & Adventure", 1, "NES", "City Connection", "" },
                    { 157, 12131, 1, "https://upload.wikimedia.org/wikipedia/en/5/57/Clashatdemonhead.jpg", 1, "Action & Adventure", 1, "NES", "Clash at Demonhead", "" },
                    { 158, 12132, 1, "https://www.mobygames.com/images/covers/l/247164-classic-concentration-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Classic Concentration", "" },
                    { 159, 38378, 1, "https://i-h2.pinimg.com/564x/0f/b6/05/0fb6051452c629e28f8f7257636e2872.jpg", 1, "Accessories", 1, "NES", "Cleaning Kit", "" },
                    { 160, 8738, 1, "https://upload.wikimedia.org/wikipedia/en/f/fd/NesCliffhanger.jpg", 1, "Action & Adventure", 1, "NES", "Cliffhanger", "" },
                    { 161, 12133, 1, "https://upload.wikimedia.org/wikipedia/en/4/41/Clu_Clu_Land_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Clu Clu Land", "" },
                    { 162, 12134, 1, "https://www.mobygames.com/images/covers/l/41828-cobra-command-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Cobra Command", "" },
                    { 163, 8743, 1, "https://upload.wikimedia.org/wikipedia/en/b/b5/Cobratriangle.jpg", 1, "Action & Adventure", 1, "NES", "Cobra Triangle", "" },
                    { 164, 8747, 1, "https://upload.wikimedia.org/wikipedia/en/9/9a/Code_Name_Viper_cover.jpg", 1, "Action & Adventure", 1, "NES", "Code Name Viper", "" },
                    { 165, 8753, 1, "https://www.mobygames.com/images/covers/l/26352-color-a-dinosaur-nes-front-cover.jpg", 1, "Other", 1, "NES", "Color A Dinosaur", "" },
                    { 166, 12135, 1, "https://www.mobygames.com/images/covers/l/85915-commando-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Commando", "" },
                    { 155, 12129, 1, "https://upload.wikimedia.org/wikipedia/en/1/1a/Circus_Caper_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Circus Caper", "" },
                    { 167, 37997, 1, "https://www.mobygames.com/images/covers/l/85915-commando-nes-front-cover.jpg", 1, "Other", 1, "NES", "Commando [5 Screw]", "" },
                    { 141, 8704, 1, "https://www.mobygames.com/images/covers/l/41554-castlevania-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Castlevania", "" },
                    { 139, 12123, 1, "https://www.mobygames.com/images/covers/l/247158-castle-of-dragon-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Castle of Dragon", "" },
                    { 115, 12113, 1, "https://now.estarland.com/images/products/hr/13219/013252002081.jpg", 1, "Puzzle", 1, "NES", "BreakThru", "" },
                    { 116, 38039, 1, "https://now.estarland.com/images/products/hr/13219/013252002081.jpg", 1, "Action & Adventure", 1, "NES", "Breakthru [5 Screw]", "" },
                    { 117, 14930, 1, "https://tiredoldhackdotcom.files.wordpress.com/2015/12/bubble-bath-babes.jpg", 1, "Action & Adventure", 1, "NES", "Bubble Bath Babes", "" },
                    { 118, 11983, 1, "https://www.mobygames.com/images/covers/l/16218-bubble-bobble-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Bubble Bobble", "" },
                    { 119, 8654, 1, "https://upload.wikimedia.org/wikipedia/en/e/eb/Bubbobpart2.jpg", 1, "Action & Adventure", 1, "NES", "Bubble Bobble Part 2", "" },
                    { 120, 8658, 1, "https://www.mobygames.com/images/covers/l/90637-bucky-o-hare-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Bucky O'Hare", "" },
                    { 121, 8661, 1, "https://upload.wikimedia.org/wikipedia/en/5/50/Bugs_Bunny_Birthday_Blowout.jpg", 1, "Action & Adventure", 1, "NES", "Bugs Bunny Birthday Blowout", "" },
                    { 122, 8662, 1, "https://upload.wikimedia.org/wikipedia/en/3/31/Crazy_Castle_Cover.png", 1, "Action & Adventure", 1, "NES", "Bugs Bunny Crazy Castle", "" },
                    { 123, 12114, 1, "https://www.mobygames.com/images/covers/l/247156-bump-n-jump-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Bump 'n' Jump", "" },
                    { 124, 12115, 1, "https://www.mobygames.com/images/covers/l/224593-burai-fighter-nes-front-cover.png", 1, "Fighting", 1, "NES", "Burai Fighter", "" },
                    { 125, 38006, 1, "https://www.mobygames.com/images/covers/l/174677-burgertime-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "BurgerTime [5 Screw]", "" },
                    { 140, 12124, 1, "https://upload.wikimedia.org/wikipedia/en/3/34/CastlequestNESBoxart.jpg", 1, "Action & Adventure", 1, "NES", "Castlequest", "" },
                    { 126, 12116, 1, "https://www.mobygames.com/images/covers/l/174677-burgertime-nes-front-cover.jpg", 1, "Puzzle", 1, "NES", "Burgertime", "" },
                    { 128, 8683, 1, "https://www.mobygames.com/images/covers/l/175373-caesars-palace-nes-front-cover.jpg", 1, "Sports", 1, "NES", "Caesar's Palace", "" },
                    { 129, 12118, 1, "https://www.mobygames.com/images/covers/l/16338-california-games-nes-front-cover.jpg", 1, "Sports", 1, "NES", "California Games", "" },
                    { 130, 8687, 1, "https://52f4e29a8321344e30ae-0f55c9129972ac85d6b1f4e703468e6b.ssl.cf2.rackcdn.com/products/pictures/181765.jpg", 1, "Action & Adventure", 1, "NES", "California Raisins The Great Escape [Reproduction]", "" },
                    { 131, 14928, 1, "https://upload.wikimedia.org/wikipedia/en/f/fe/Caltron_6-in-1.jpg", 1, "Action & Adventure", 1, "NES", "Caltron 6-in-1", "" },
                    { 132, 8695, 1, "http://nintendoagemedia.com/elements_nocache/E8BF839B-EA69-A7B0-58883B3CA65FDE3B.jpg", 1, "Action & Adventure", 1, "NES", "Captain America and the Avengers", "" },
                    { 133, 8696, 1, "https://upload.wikimedia.org/wikipedia/en/3/34/Captain_Planet_and_the_Planeteers_Coverart.png", 1, "Action & Adventure", 1, "NES", "Captain Planet and the Planeteers", "" },
                    { 134, 12120, 1, "https://upload.wikimedia.org/wikipedia/en/b/b0/Captain_Skyhawk_Coverart.png", 1, "Action & Adventure", 1, "NES", "Captain Skyhawk", "" },
                    { 135, 12121, 1, "https://upload.wikimedia.org/wikipedia/en/2/2f/CasinoKidBoxart.jpg", 1, "Other", 1, "NES", "Casino Kid", "" },
                    { 136, 8701, 1, "https://static.giantbomb.com/uploads/scale_small/0/3413/210957-casino_kid_2.jpg", 1, "Other", 1, "NES", "Casino Kid II", "" },
                    { 137, 8702, 1, "http://img2.game-oldies.com/sites/default/files/packshots/nintendo-nes/castelian-usa.png", 1, "Action & Adventure", 1, "NES", "Castelian", "" },
                    { 138, 12122, 1, "https://upload.wikimedia.org/wikipedia/en/0/0e/CastleofDeceitBoxart.jpg", 1, "Action & Adventure", 1, "NES", "Castle of Deceit", "" },
                    { 127, 12117, 1, "https://www.mobygames.com/images/covers/l/72807-cabal-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Cabal", "" },
                    { 168, 12136, 1, "https://upload.wikimedia.org/wikipedia/en/2/2c/Mysteries_of_Time_cover.jpg", 1, "Action & Adventure", 1, "NES", "Conan the Mysteries of Time", "" },
                    { 169, 12137, 1, "https://upload.wikimedia.org/wikipedia/en/0/00/Conflict_NES_cover.jpg", 1, "Action & Adventure", 1, "NES", "Conflict", "" },
                    { 170, 12138, 1, "https://upload.wikimedia.org/wikipedia/en/4/4d/Conquest_of_the_Crystal_Palace_cover.jpg", 1, "Action & Adventure", 1, "NES", "Conquest of the Crystal Palace", "" },
                    { 200, 12156, 1, "https://upload.wikimedia.org/wikipedia/en/3/31/Destiny_of_an_Emperor_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Destiny of an Emperor", "" },
                    { 201, 12157, 1, "https://www.mobygames.com/images/covers/l/32221-dick-tracy-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Dick Tracy", "" },
                    { 202, 8841, 1, "https://www.mobygames.com/images/covers/l/60371-die-hard-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Die Hard", "" },
                    { 203, 12159, 1, "https://www.mobygames.com/images/covers/l/18840-dig-dug-ii-trouble-in-paradise-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Dig Dug II: Trouble in Paradise", "" },
                    { 204, 12160, 1, "https://www.mobygames.com/images/covers/l/187076-digger-t-rock-legend-of-the-lost-city-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Digger T Rock", "" },
                    { 205, 12161, 1, "https://upload.wikimedia.org/wikipedia/en/7/7a/Dirty_Harry_-_The_War_Against_Drugs_Coverart.png", 1, "Action & Adventure", 1, "NES", "Dirty Harry", "" },
                    { 206, 39508, 1, "https://www.mobygames.com/images/covers/l/15240-the-fantastic-adventures-of-dizzy-nes-front-cover.jpg", 1, "Puzzle", 1, "NES", "Dizzy the Adventurer", "" },
                    { 207, 21555, 1, "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a4/Nintendo-Famicom-NES-Dogbone-Controller-FL.jpg/800px-Nintendo-Famicom-NES-Dogbone-Controller-FL.jpg", 1, "Controllers", 1, "NES", "Dogbone Controller", "" },
                    { 208, 11985, 1, "https://www.mobygames.com/images/covers/l/206582-donkey-kong-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Donkey Kong", "" },
                    { 209, 12163, 1, "https://www.mobygames.com/images/covers/l/246580-donkey-kong-3-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Donkey Kong 3", "" },
                    { 210, 37986, 1, "https://www.mobygames.com/images/covers/l/246580-donkey-kong-3-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Donkey Kong 3 [5 Screw]", "" },
                    { 199, 12155, 1, "https://upload.wikimedia.org/wikipedia/en/d/d2/Destination_Earthstar_Cover.jpg", 1, "Other", 1, "NES", "Destination Earthstar", "" },
                    { 211, 12164, 1, "https://www.mobygames.com/images/covers/l/15771-donkey-kong-classics-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Donkey Kong Classics", "" },
                    { 213, 11987, 1, "https://www.mobygames.com/images/covers/l/206578-donkey-kong-jr-math-nes-front-cover.png", 1, "Other", 1, "NES", "Donkey Kong Jr Math", "" },
                    { 214, 37968, 1, "https://www.mobygames.com/images/covers/l/206578-donkey-kong-jr-math-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Donkey Kong Jr Math [5 Screw]", "" },
                    { 215, 37985, 1, "https://www.mobygames.com/images/covers/l/16324-donkey-kong-junior-nes-front-cover", 1, "Action & Adventure", 1, "NES", "Donkey Kong Jr [5 Screw]", "" },
                    { 216, 37984, 1, "https://www.mobygames.com/images/covers/l/206582-donkey-kong-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Donkey Kong [5 Screw]", "" },
                    { 217, 12167, 1, "https://www.mobygames.com/images/covers/l/218409-double-dare-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Double Dare", "" },
                    { 218, 12207, 1, "https://www.mobygames.com/images/covers/l/16095-double-dragon-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Double Dragon", "" },
                    { 219, 12208, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/0/02/NES_Double_Dragon_II_packaging_front.jpg/220px-NES_Double_Dragon_II_packaging_front.jpg", 1, "Action & Adventure", 1, "NES", "Double Dragon II", "" },
                    { 220, 12209, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/2/2e/NES_Double_Dragon_III_cover.jpg/255px-NES_Double_Dragon_III_cover.jpg", 1, "Action & Adventure", 1, "NES", "Double Dragon III", "" },
                    { 222, 38023, 1, "https://www.mobygames.com/images/covers/l/70319-double-dribble-amiga-front-cover.jpg", 1, "Basketball", 1, "NES", "Double Dribble [5 Screw]", "" },
                    { 221, 11988, 1, "https://www.mobygames.com/images/covers/l/70319-double-dribble-amiga-front-cover.jpg", 1, "Basketball", 1, "NES", "Double Dribble", "" },
                    { 223, 12210, 1, "https://www.mobygames.com/images/covers/l/16840-double-strike-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Double Strike", "" },
                    { 212, 11986, 1, "https://www.mobygames.com/images/covers/l/16324-donkey-kong-junior-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Donkey Kong Jr", "" },
                    { 198, 12154, 1, "https://upload.wikimedia.org/wikipedia/en/f/fa/Desert_Commander.jpg", 1, "Action & Adventure", 1, "NES", "Desert Commander", "" },
                    { 197, 12153, 1, "https://upload.wikimedia.org/wikipedia/en/6/68/Demon_Sword_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Demon Sword", "" },
                    { 196, 12152, 1, "https://www.mobygames.com/images/covers/l/65720-deja-vu-a-nightmare-comes-true-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Deja Vu", "" },
                    { 171, 12139, 1, "https://upload.wikimedia.org/wikipedia/en/6/65/Contra_cover.jpg", 1, "Action & Adventure", 1, "NES", "Contra", "" },
                    { 172, 12140, 1, "https://upload.wikimedia.org/wikipedia/en/4/48/Contraforcecover.gif", 1, "Action & Adventure", 1, "NES", "Contra Force", "" },
                    { 173, 37258, 1, "http://nintendoagemedia.com/elements_nocache/2F9241FA-E870-DFF2-495AE1481536AE00.jpg", 1, "Other", 1, "NES", "Control Deck Test Cartridge", "" },
                    { 174, 8764, 1, "https://upload.wikimedia.org/wikipedia/en/c/ca/Cool_World_NES.jpg", 1, "Action & Adventure", 1, "NES", "Cool World", "" },
                    { 175, 12142, 1, "https://image.gamevaluenow.com/nes/cowboy_kid.jpg", 1, "Action & Adventure", 1, "NES", "Cowboy Kid", "" },
                    { 176, 12143, 1, "https://upload.wikimedia.org/wikipedia/en/2/2a/Crash_N_the_Boys_Street_Challenge_NES_box_art.jpg", 1, "Action & Adventure", 1, "NES", "Crash 'n' the Boys: Street Challenge", "" },
                    { 177, 8786, 1, "https://www.mobygames.com/images/covers/l/14569-crystal-mines-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Crystal Mines", "" },
                    { 178, 12144, 1, "https://upload.wikimedia.org/wikipedia/en/9/9b/Crystalisboxart.jpg", 1, "Action & Adventure", 1, "NES", "Crystalis", "" },
                    { 179, 8794, 1, "https://upload.wikimedia.org/wikipedia/en/1/12/Cyberball_Cover.jpg", 1, "Sports", 1, "NES", "Cyberball", "" },
                    { 180, 8796, 1, "https://upload.wikimedia.org/wikipedia/en/d/d2/Cybernoid_computer_game_cover.jpg", 1, "Action & Adventure", 1, "NES", "Cybernoid The Fighting Machine", "" },
                    { 181, 12145, 1, "https://www.mobygames.com/images/covers/l/29799-base-wars-cyber-stadium-series-nes-front-cover.jpg", 1, "Sports", 1, "NES", "Cyberstadium Series Base Wars", "" },
                    { 182, 8801, 1, "https://www.mobygames.com/images/covers/l/247172-dance-aerobics-nes-front-cover.jpg", 1, "Other", 1, "NES", "Dance Aerobics", "" },
                    { 183, 8804, 1, "https://www.mobygames.com/images/covers/l/247318-danny-sullivan-s-indy-heat-nes-front-cover.jpg", 1, "Racing", 1, "NES", "Danny Sullivan's Indy Heat", "" },
                    { 184, 8808, 1, "https://www.mobygames.com/images/covers/l/247317-darkman-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Darkman", "" },
                    { 185, 8810, 1, "https://upload.wikimedia.org/wikipedia/en/c/c3/Darkwing_Duck_NES_Cover.png", 1, "Action & Adventure", 1, "NES", "Darkwing Duck", "" },
                    { 186, 12146, 1, "https://upload.wikimedia.org/wikipedia/en/d/da/DashGalaxyBoxart.jpg", 1, "Action & Adventure", 1, "NES", "Dash Galaxy in the Alien Asylum", "" },
                    { 187, 8817, 1, "https://upload.wikimedia.org/wikipedia/en/a/a2/DayDreaminDaveyNES.jpg", 1, "Action & Adventure", 1, "NES", "Day Dreamin' Davey", "" },
                    { 188, 8818, 1, "https://upload.wikimedia.org/wikipedia/en/8/8b/Days_of_Thunder_cover_art_%28NES%29.jpg", 1, "Racing", 1, "NES", "Days Of Thunder", "" },
                    { 189, 12147, 1, "https://upload.wikimedia.org/wikipedia/en/f/f3/Deadly_Towers_boxart.png", 1, "Action & Adventure", 1, "NES", "Deadly Towers", "" },
                    { 190, 38022, 1, "https://upload.wikimedia.org/wikipedia/en/f/f3/Deadly_Towers_boxart.png", 1, "Action & Adventure", 1, "NES", "Deadly Towers [5 Screw]", "" },
                    { 191, 12148, 1, "https://upload.wikimedia.org/wikipedia/en/d/d8/DeathRaceBoxShotNES.jpg", 1, "Racing", 1, "NES", "Death Race", "" },
                    { 192, 12149, 1, "https://www.mobygames.com/images/covers/l/42366-deathbots-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Deathbots", "" },
                    { 193, 12150, 1, "https://server.emulator.games/images/nintendo/defender-2.jpg", 1, "Action & Adventure", 1, "NES", "Defender II", "" },
                    { 194, 12151, 1, "https://www.mobygames.com/images/covers/l/247326-defender-of-the-crown-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Defender of the Crown", "" },
                    { 195, 8836, 1, "https://upload.wikimedia.org/wikipedia/en/1/1e/Defenders_of_Dynatron_City_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Defenders of Dynatron City", "" },
                    { 114, 8645, 1, "https://www.mobygames.com/images/covers/l/202384-break-time-the-national-pool-tour-nes-front-cover.jpg", 1, "Sports", 1, "NES", "Break Time The National Pool Tour", "" },
                    { 113, 8643, 1, "https://static.giantbomb.com/uploads/scale_small/9/93770/2361185-nes_dracula_eu.jpg", 1, "Action & Adventure", 1, "NES", "Bram Stoker's Dracula", "" },
                    { 112, 12112, 1, "https://upload.wikimedia.org/wikipedia/en/a/a6/Boulder_Dash_NES.jpg", 1, "Action & Adventure", 1, "NES", "Boulder Dash", "" },
                    { 111, 8636, 1, "https://cdn11.bigcommerce.com/s-ymgqt/images/stencil/1280x1280/products/24691/16176/Game%20Nintendo%20NES-617-2__72500.1394726290.jpg", 1, "Action & Adventure", 1, "NES", "Bonk's Adventure", "" },
                    { 30, 12377, 1, "https://upload.wikimedia.org/wikipedia/en/4/49/Radbox3.jpg", 1, "Action & Adventure", 1, "NES", "Adventures of Rad Gravity", "" },
                    { 31, 8472, 1, "https://upload.wikimedia.org/wikipedia/en/c/cf/NES_Adventures_of_Tom_Sawyer_Box.JPG", 1, "Action & Adventure", 1, "NES", "Adventures of Tom Sawyer", "" },
                    { 32, 12177, 1, "https://server.emulator.games/images/nintendo/after-burner.jpg", 1, "Other", 1, "NES", "After Burner", "" },
                    { 33, 8488, 1, "https://upload.wikimedia.org/wikipedia/en/2/2e/Air_Fortress_Cover.png", 1, "Other", 1, "NES", "Air Fortress", "" },
                    { 34, 12178, 1, "https://upload.wikimedia.org/wikipedia/en/0/02/NesAirwolf.jpg", 1, "Action & Adventure", 1, "NES", "Airwolf", "" },
                    { 35, 8491, 1, "https://upload.wikimedia.org/wikipedia/en/c/c4/Al_Unser_Jr.%27s_Turbo_Racing_Coverart.png", 1, "Racing", 1, "NES", "Al Unser Turbo Racing", "" },
                    { 36, 39509, 1, "https://thumbs.worthpoint.com/zoom/images2/1/0311/13/aladdin-deck-enhancer-sealed-nintendo_1_628ed7d576f3a7f0e6e7142fbb062180.jpg", 1, "Accessories", 1, "NES", "Aladdin Deck Enhancer", "" },
                    { 37, 8493, 1, "https://upload.wikimedia.org/wikipedia/en/b/b9/Alfred_Chicken_cover.jpg", 1, "Action & Adventure", 1, "NES", "Alfred Chicken", "" },
                    { 38, 8495, 1, "https://vignette.wikia.nocookie.net/avp/images/2/28/Alien3_NES.jpg/revision/latest?cb=20160414151617", 1, "Action & Adventure", 1, "NES", "Alien 3", "" },
                    { 39, 12179, 1, "https://now.estarland.com/images/products/hr/13153/031763101123.jpg", 1, "Action & Adventure", 1, "NES", "Alien Syndrome", "" },
                    { 40, 12180, 1, "https://upload.wikimedia.org/wikipedia/en/0/09/All-Pro_Basketball_Cover.png", 1, "Basketball", 1, "NES", "All-Pro Basketball", "" },
                    { 29, 8469, 1, "https://upload.wikimedia.org/wikipedia/en/c/c7/BoxArtLolo3%28US%29.jpg", 1, "Puzzle", 1, "NES", "Adventures of Lolo 3", "" },
                    { 41, 12181, 1, "https://www.mobygames.com/images/covers/l/310359-alpha-mission-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Alpha Mission", "" },
                    { 43, 12183, 1, "https://upload.wikimedia.org/wikipedia/en/c/c7/Amagon_Cover.png", 1, "Action & Adventure", 1, "NES", "Amagon", "" },
                    { 44, 8507, 1, "https://upload.wikimedia.org/wikipedia/en/2/24/American_Gladiators_Coverart.png", 1, "Sports", 1, "NES", "American Gladiators", "" },
                    { 45, 12184, 1, "https://upload.wikimedia.org/wikipedia/en/8/85/Anticipation_nes.jpg", 1, "Action & Adventure", 1, "NES", "Anticipation", "" },
                    { 46, 12185, 1, "https://upload.wikimedia.org/wikipedia/en/0/0d/Archrival_box.jpg", 1, "Basketball", 1, "NES", "Arch Rivals", "" },
                    { 47, 12186, 1, "http://vgmpf.com/Wiki/images/thumb/8/85/Archon_-_NES_-_Box_-_Front.jpg/416px-Archon_-_NES_-_Box_-_Front.jpg", 1, "Action & Adventure", 1, "NES", "Archon", "" },
                    { 48, 8527, 1, "https://cdn.thegamesdb.net/images/original/boxart/front/2153-1.jpg", 1, "Arcade", 1, "NES", "Arkanoid", "" },
                    { 49, 38015, 1, "https://cdn.thegamesdb.net/images/original/boxart/front/2153-1.jpg", 1, "Action & Adventure", 1, "NES", "Arkanoid [5 Screw]", "" },
                    { 50, 37957, 1, "https://cdn.shopify.com/s/files/1/0363/6845/products/fee49b078ce79f43e671c837d5fc9f7a.jpg?v=1534687228", 1, "Arcade", 1, "NES", "Arkanoid [Controller Bundle]", "" },
                    { 51, 16264, 1, "https://upload.wikimedia.org/wikipedia/en/4/47/NES_Arkistas_Ring.jpg", 1, "Action & Adventure", 1, "NES", "Arkista's Ring", "" },
                    { 52, 8538, 1, "https://www.mobygames.com/images/covers/l/78034-astyanax-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Astyanax", "" },
                    { 53, 12187, 1, "https://www.mobygames.com/images/covers/l/93958-athena-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Athena", "" },
                    { 42, 38035, 1, "https://www.mobygames.com/images/covers/l/310359-alpha-mission-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Alpha Mission [5 Screw]", "" },
                    { 28, 11980, 1, "https://upload.wikimedia.org/wikipedia/en/9/9e/Adventures_of_Lolo_2_Cover.png", 1, "Action & Adventure", 1, "NES", "Adventures of Lolo 2", "" },
                    { 27, 11979, 1, "https://upload.wikimedia.org/wikipedia/en/9/9b/BoxArtLolo1%28US%29.jpg", 1, "Action & Adventure", 1, "NES", "Adventures of Lolo", "" },
                    { 26, 12175, 1, "https://upload.wikimedia.org/wikipedia/en/e/ea/AdventuresofDinoRiki.jpg", 1, "Action & Adventure", 1, "NES", "Adventures of Dino Riki", "" },
                    { 1, 12168, 1, "https://github.com/ramiabraham/cover-art-collection/blob/master/nes/10%20yard%20fight.jpg?raw=true", 1, "Football", 1, "NES", "10-Yard Fight", "" },
                    { 2, 37965, 1, "https://github.com/ramiabraham/cover-art-collection/blob/master/nes/10%20Yard%20Fight.jpg?raw=true", 1, "Football", 1, "NES", "10-Yard Fight [5 Screw]", "" },
                    { 3, 12169, 1, "https://github.com/ramiabraham/cover-art-collection/blob/master/nes/1942.jpg?raw=true", 1, "Other", 1, "NES", "1942", "" },
                    { 4, 37996, 1, "https://github.com/ramiabraham/cover-art-collection/blob/master/nes/1942.jpg?raw=true", 1, "Other", 1, "NES", "1942 [5 Screw]", "" },
                    { 5, 12170, 1, "https://github.com/ramiabraham/cover-art-collection/blob/master/nes/1943%20The%20Battle%20Of%20Midway.jpg?raw=true", 1, "Other", 1, "NES", "1943: The Battle of Midway", "" },
                    { 6, 8445, 1, "https://upload.wikimedia.org/wikipedia/en/6/6a/NES3dworldrunnerbox_mod.png", 1, "Action & Adventure", 1, "NES", "3D WorldRunner", "" },
                    { 7, 38021, 1, "https://upload.wikimedia.org/wikipedia/en/6/6a/NES3dworldrunnerbox_mod.png", 1, "Action & Adventure", 1, "NES", "3D WorldRunner [5 Screw]", "" },
                    { 8, 12171, 1, "https://github.com/ramiabraham/cover-art-collection/blob/master/nes/720.jpg?raw=true", 1, "Sports", 1, "NES", "720", "" },
                    { 9, 12172, 1, "https://www.mobygames.com/images/covers/l/33004-8-eyes-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "8 Eyes", "" },
                    { 10, 12173, 1, "https://github.com/ramiabraham/cover-art-collection/blob/master/nes/A%20Boy%20and%20His%20Blob.jpg?raw=true", 1, "Action & Adventure", 1, "NES", "A Boy and His Blob Trouble on Blobolonia", "" },
                    { 11, 12174, 1, "https://upload.wikimedia.org/wikipedia/en/3/30/A_Nightmare_on_Elm_Street_NES_box_art.jpg", 1, "Action & Adventure", 1, "NES", "A Nightmare on Elm Street", "" },
                    { 12, 8451, 1, "https://github.com/ramiabraham/cover-art-collection/blob/master/nes/Abadox.jpg?raw=true", 1, "Action & Adventure", 1, "NES", "Abadox", "" },
                    { 13, 8453, 1, "https://image.gamevaluenow.com/nes/action_52.jpg", 1, "Action & Adventure", 1, "NES", "Action 52", "" },
                    { 14, 8455, 1, "https://www.mobygames.com/images/covers/l/107779-the-addams-family-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Addams Family", "" },
                    { 15, 8456, 1, "https://www.mobygames.com/images/covers/l/246769-the-addams-family-pugsley-s-scavenger-hunt-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Addams Family Pugsley's Scavenger Hunt", "" },
                    { 16, 8458, 1, "https://52f4e29a8321344e30ae-0f55c9129972ac85d6b1f4e703468e6b.ssl.cf2.rackcdn.com/products/pictures/181680.jpg", 1, "Strategy", 1, "NES", "Advanced Dungeons & Dragons Dragon Strike", "" },
                    { 18, 8460, 1, "https://raw.githubusercontent.com/ramiabraham/cover-art-collection/master/nes/Advanced%20Dungeons%20and%20Dragons%20Hillsfar.jpg", 1, "Strategy", 1, "NES", "Advanced Dungeons & Dragons Hillsfar", "" },
                    { 17, 8459, 1, "https://upload.wikimedia.org/wikipedia/en/8/8f/Advanced_Dungeons_%26_Dragons_Heroes_of_the_Lance_Cover.png", 1, "Strategy", 1, "NES", "Advanced Dungeons & Dragons Heroes of the Lance", "" },
                    { 19, 8462, 1, "http://img1.game-oldies.com/sites/default/files/packshots/nintendo-nes/advanced-dungeons-dragons-pool-of-radiance-usa.png", 1, "Strategy", 1, "NES", "Advanced Dungeons & Dragons Pool of Radiance", "" },
                    { 20, 8464, 1, "https://raw.githubusercontent.com/ramiabraham/cover-art-collection/master/nes/Adventure%20Island.jpg", 1, "Action & Adventure", 1, "NES", "Adventure Island", "" },
                    { 21, 12176, 1, "https://raw.githubusercontent.com/ramiabraham/cover-art-collection/master/nes/Adventure%20Island%203.jpg", 1, "Action & Adventure", 1, "NES", "Adventure Island 3", "" },
                    { 22, 8465, 1, "https://raw.githubusercontent.com/ramiabraham/cover-art-collection/master/nes/Adventure%20Island%202.jpg", 1, "Action & Adventure", 1, "NES", "Adventure Island II", "" },
                    { 23, 8466, 1, "https://upload.wikimedia.org/wikipedia/en/c/ce/Adventures_in_the_Magic_Kingdom.png", 1, "Action & Adventure", 1, "NES", "Adventures in the Magic Kingdom", "" },
                    { 24, 8468, 1, "https://upload.wikimedia.org/wikipedia/en/2/23/Bayou_Billy_box.jpg", 1, "Action & Adventure", 1, "NES", "Adventures of Bayou Billy", "" },
                    { 25, 12119, 1, "https://upload.wikimedia.org/wikipedia/en/9/99/CaptainComicBoxart.jpg", 1, "Action & Adventure", 1, "NES", "Adventures of Captain Comic", "" },
                    { 54, 38016, 1, "https://www.mobygames.com/images/covers/l/93958-athena-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Athena [5 Screw]", "" },
                    { 224, 12211, 1, "https://www.mobygames.com/images/covers/l/202665-dr-chaos-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Dr Chaos", "" },
                    { 55, 12188, 1, "https://now.estarland.com/images/products/hr/13167/045557077006.jpg", 1, "Sports", 1, "NES", "Athletic World", "" },
                    { 57, 8541, 1, "https://upload.wikimedia.org/wikipedia/en/3/3d/Attack_of_the_Killer_Tomatoes_%281991%29_Coverart.png", 1, "Action & Adventure", 1, "NES", "Attack of the Killer Tomatoes", "" },
                    { 87, 8586, 1, "https://www.mobygames.com/images/covers/l/78545-battletoads-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Battletoads", "" },
                    { 88, 8588, 1, "https://www.mobygames.com/images/covers/l/247143-battletoads-double-dragon-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Battletoads and Double Dragon The Ultimate Team", "" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApiGameId", "CibPrice", "CoverURL", "GameConsoleId", "Genre", "LoosePrice", "SystemId", "Title", "Upc" },
                values: new object[,]
                {
                    { 89, 12203, 1, "https://www.mobygames.com/images/covers/l/19360-bee-52-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Bee 52", "" },
                    { 90, 12204, 1, "https://i.ebayimg.com/00/z/5l4AAOxyVaBS0sQy/$_32.JPG", 1, "Action & Adventure", 1, "NES", "BeetleJuice", "" },
                    { 91, 8600, 1, "https://www.mobygames.com/images/covers/l/247146-best-of-the-best-championship-karate-nes-front-cover.jpg", 1, "Fighting", 1, "NES", "Best of the Best Championship Karate", "" },
                    { 92, 8603, 1, "https://www.mobygames.com/images/covers/l/18977-bible-adventures-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Bible Adventures", "" },
                    { 93, 12205, 1, "https://m.media-amazon.com/images/M/MV5BNzBhZjZkMzItMTkwZi00ZWJkLWE0MGEtODM2OTQwOWNiZjdjXkEyXkFqcGdeQXVyNTY2MzQ3MDE@._V1_.jpg", 1, "Other", 1, "NES", "Bible Buffet", "" },
                    { 94, 12106, 1, "https://www.mobygames.com/images/covers/l/14905-big-nose-freaks-out-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Big Nose Freaks Out", "" },
                    { 95, 39520, 1, "https://cdn11.bigcommerce.com/s-ymgqt/images/stencil/300x300/products/40265/34180/big-nose__04372.1462545219.__17808.1473967314.jpg", 1, "Action & Adventure", 1, "NES", "Big Nose Freaks Out [Aladdin]", "" },
                    { 96, 16129, 1, "https://i.ebayimg.com/07/!!e!Uv1gEWM~$(KGrHqUOKnIEz6TrDnSKBNP3nOLZ1Q~~_32.JPG?set_id=89040003C1", 1, "Action & Adventure", 1, "NES", "Big Nose the Caveman", "" },
                    { 97, 12206, 1, "https://www.mobygames.com/images/covers/l/29925-bigfoot-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Bigfoot", "" },
                    { 86, 12202, 1, "https://www.mobygames.com/images/covers/l/62303-garry-kitchen-s-battletank-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Battletank", "" },
                    { 98, 8607, 1, "http://img2.game-oldies.com/sites/default/files/packshots/nintendo-nes/bill-elliotts-nascar-challenge-usa.png", 1, "Racing", 1, "NES", "Bill Elliott's NASCAR Challenge", "" },
                    { 100, 12107, 1, "https://www.mobygames.com/images/covers/l/19540-bionic-commando-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Bionic Commando", "" },
                    { 101, 12108, 1, "https://www.mobygames.com/images/covers/l/51657-black-bass-windows-front-cover.jpg", 1, "Sports", 1, "NES", "Black Bass", "" },
                    { 102, 12109, 1, "https://cdn11.bigcommerce.com/s-ymgqt/images/stencil/1280x1280/products/24683/16162/Game%20Nintendo%20NES-609-2__79382.1394726169.jpg", 1, "Other", 1, "NES", "Blackjack", "" },
                    { 103, 8614, 1, "https://www.mobygames.com/images/covers/l/45167-blades-of-steel-nes-front-cover.jpg", 1, "Sports", 1, "NES", "Blades of Steel", "" },
                    { 104, 39515, 1, "https://cdn11.bigcommerce.com/s-ymgqt/images/stencil/300x300/products/39769/31263/563389_108267_front__09625.1457469319.jpg", 1, "Sports", 1, "NES", "Blades of Steel [Classic Series]", "" },
                    { 105, 12110, 1, "https://upload.wikimedia.org/wikipedia/en/9/99/Blaster_Master_boxart.jpg", 1, "Action & Adventure", 1, "NES", "Blaster Master", "" },
                    { 106, 8625, 1, "https://upload.wikimedia.org/wikipedia/en/7/73/The_blue_marlin_nes_box_art.jpg", 1, "Sports", 1, "NES", "Blue Marlin", "" },
                    { 107, 8627, 1, "https://www.mobygames.com/images/covers/l/247148-the-blues-brothers-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Blues Brothers", "" },
                    { 108, 8628, 1, "https://www.mobygames.com/images/covers/l/175248-bo-jackson-baseball-nes-front-cover.jpg", 1, "Baseball", 1, "NES", "Bo Jackson Baseball", "" },
                    { 109, 12111, 1, "https://upload.wikimedia.org/wikipedia/en/7/72/BombermanCover.jpg", 1, "Action & Adventure", 1, "NES", "Bomberman", "" },
                    { 110, 8632, 1, "https://upload.wikimedia.org/wikipedia/en/3/3a/Bomberman2Cover.jpg", 1, "Puzzle", 1, "NES", "Bomberman II", "" },
                    { 99, 8606, 1, "https://www.mobygames.com/images/covers/l/29993-bill-ted-s-excellent-video-game-adventure-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Bill and Ted's Excellent Video Game", "" },
                    { 85, 8582, 1, "https://www.mobygames.com/images/covers/l/177327-battleship-nes-front-cover.jpg", 1, "Strategy", 1, "NES", "Battleship", "" },
                    { 84, 12201, 1, "https://upload.wikimedia.org/wikipedia/en/7/7c/Battle_of_olympus.jpg", 1, "Action & Adventure", 1, "NES", "Battle of Olympus", "" },
                    { 83, 12200, 1, "https://www.mobygames.com/images/covers/l/216162-battle-chess-nes-front-cover.jpg", 1, "Strategy", 1, "NES", "Battle Chess", "" },
                    { 58, 12189, 1, "https://upload.wikimedia.org/wikipedia/en/e/ea/Babyboomer.jpg", 1, "Action & Adventure", 1, "NES", "Baby Boomer", "" },
                    { 59, 12190, 1, "https://upload.wikimedia.org/wikipedia/en/a/af/BackToTheFutureNESBoxart.jpg", 1, "Action & Adventure", 1, "NES", "Back to the Future", "" },
                    { 60, 12191, 1, "https://vignette.wikia.nocookie.net/bttf/images/1/15/BTTFIIandIII.jpg/revision/latest?cb=20070201220246", 1, "Action & Adventure", 1, "NES", "Back to the Future II and III", "" },
                    { 61, 12192, 1, "https://www.mobygames.com/images/covers/l/94792-bad-dudes-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Bad Dudes", "" },
                    { 62, 12193, 1, "https://upload.wikimedia.org/wikipedia/en/6/65/Bad_News_Baseball_Coverart.png", 1, "Baseball", 1, "NES", "Bad News Baseball", "" },
                    { 63, 12194, 1, "https://upload.wikimedia.org/wikipedia/en/e/e9/Bad_Street_Brawler_cover.png", 1, "Fighting", 1, "NES", "Bad Street Brawler", "" },
                    { 64, 11981, 1, "https://upload.wikimedia.org/wikipedia/en/a/a8/BalloonFightnesboxart.jpg", 1, "Action & Adventure", 1, "NES", "Balloon Fight", "" },
                    { 65, 37983, 1, "https://upload.wikimedia.org/wikipedia/en/a/a8/BalloonFightnesboxart.jpg", 1, "Action & Adventure", 1, "NES", "Balloon Fight [5 Screw]", "" },
                    { 66, 12195, 1, "https://upload.wikimedia.org/wikipedia/en/2/2f/Bandai_Golf_-_Challenge_Pebble_Beach_game_cover_art.jpg", 1, "Sports", 1, "NES", "Bandai Golf Challenge Pebble Beach", "" },
                    { 67, 13109, 1, "https://www.mobygames.com/images/covers/l/11191-bandit-kings-of-ancient-china-dos-front-cover.jpg", 1, "Strategy", 1, "NES", "Bandit Kings of Ancient China", "" },
                    { 68, 8554, 1, "https://upload.wikimedia.org/wikipedia/en/7/78/Barbie_NES_box_art.jpg", 1, "Action & Adventure", 1, "NES", "Barbie", "" },
                    { 69, 8559, 1, "http://img1.game-oldies.com/sites/default/files/packshots/nintendo-nes/bard-s-tale-the-usa.png", 1, "RPG", 1, "NES", "Bard's Tale", "" },
                    { 70, 8560, 1, "https://upload.wikimedia.org/wikipedia/en/1/13/BB_TS_NES.PNG", 1, "Other", 1, "NES", "Barker Bill's Trick Shooting", "" },
                    { 71, 11982, 1, "https://upload.wikimedia.org/wikipedia/en/6/64/Baseball_NES_box_art.jpg", 1, "Baseball", 1, "NES", "Baseball", "" },
                    { 72, 13843, 1, "https://upload.wikimedia.org/wikipedia/en/7/7c/BaseballSimulatorNESBoxart.jpg", 1, "Baseball", 1, "NES", "Baseball Simulator 1.000", "" },
                    { 73, 12198, 1, "https://upload.wikimedia.org/wikipedia/en/2/28/BaseballStarsNESCover.jpg", 1, "Baseball", 1, "NES", "Baseball Stars", "" },
                    { 74, 8562, 1, "https://server.emulator.games/images/nintendo/baseball-stars-2.jpg", 1, "Baseball", 1, "NES", "Baseball Stars 2", "" },
                    { 75, 37966, 1, "https://upload.wikimedia.org/wikipedia/en/6/64/Baseball_NES_box_art.jpg", 1, "Baseball", 1, "NES", "Baseball [5 Screw]", "" },
                    { 76, 8564, 1, "https://upload.wikimedia.org/wikipedia/en/c/cb/NES_Bases_Loaded_cover_art.jpg", 1, "Baseball", 1, "NES", "Bases Loaded", "" },
                    { 77, 8565, 1, "https://upload.wikimedia.org/wikipedia/en/7/7c/Bases_Loaded_2_box_art.jpg", 1, "Baseball", 1, "NES", "Bases Loaded 2 Second Season", "" },
                    { 78, 12199, 1, "https://upload.wikimedia.org/wikipedia/en/a/a7/Bases_Loaded_3_box_art.jpg", 1, "Baseball", 1, "NES", "Bases Loaded 3", "" },
                    { 79, 8566, 1, "https://upload.wikimedia.org/wikipedia/en/f/fd/Basesloaded4.jpg", 1, "Baseball", 1, "NES", "Bases Loaded 4", "" },
                    { 80, 8574, 1, "https://www.mobygames.com/images/covers/l/29788-batman-returns-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Batman Returns", "" },
                    { 81, 13844, 1, "https://www.mobygames.com/images/covers/l/59498-batman-the-video-game-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Batman The Video Game", "" },
                    { 82, 8570, 1, "https://www.mobygames.com/images/covers/l/77994-batman-return-of-the-joker-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Batman: Return of the Joker", "" },
                    { 56, 38009, 1, "https://now.estarland.com/images/products/hr/13167/045557077006.jpg", 1, "Sports", 1, "NES", "Athletic World [5 Screw]", "" },
                    { 225, 12212, 1, "https://www.mobygames.com/images/covers/l/163637-dr-jekyll-and-mr-hyde-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Dr Jekyll and Mr Hyde", "" },
                    { 226, 8859, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f8/Dr._Mario_box_art.jpg/220px-Dr._Mario_box_art.jpg", 1, "Puzzle", 1, "NES", "Dr. Mario", "" },
                    { 227, 8864, 1, "https://upload.wikimedia.org/wikipedia/en/a/a6/Dragon_Fighter_cover.jpg", 1, "Action & Adventure", 1, "NES", "Dragon Fighter", "" },
                    { 371, 39519, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/1e/Jaws_%28NES%29.jpg/220px-Jaws_%28NES%29.jpg", 1, "Action & Adventure", 1, "NES", "Jaws [5 Screw]", "" },
                    { 372, 9169, 1, "https://www.mobygames.com/images/covers/l/174665-jeopardy-nes-front-cover.jpg", 1, "Other", 1, "NES", "Jeopardy", "" },
                    { 373, 9170, 1, "https://www.mobygames.com/images/covers/l/78029-jeopardy-25th-anniversary-edition-nes-front-cover.jpg", 1, "Other", 1, "NES", "Jeopardy 25th Anniversary", "" },
                    { 374, 9172, 1, "http://img1.game-oldies.com/sites/default/files/packshots/nintendo-nes/jeopardy-junior-edition-usa.png", 1, "Other", 1, "NES", "Jeopardy Jr", "" },
                    { 375, 9176, 1, "https://upload.wikimedia.org/wikipedia/en/c/c0/The_Jetsons_Cogswell%27s_Caper.jpg", 1, "Action & Adventure", 1, "NES", "Jetsons Cogswell's Caper", "" },
                    { 376, 9177, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/a/a1/JimmyConnorsTennisUSNovember1993NESCoverArtImage.jpg/220px-JimmyConnorsTennisUSNovember1993NESCoverArtImage.jpg", 1, "Sports", 1, "NES", "Jimmy Connors Tennis", "" },
                    { 377, 9179, 1, "https://www.mobygames.com/images/covers/l/76292-joe-mac-caveman-ninja-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Joe and Mac", "" },
                    { 378, 12279, 1, "https://www.mobygames.com/images/covers/l/17567-john-elway-s-quarterback-nes-front-cover.jpg", 1, "Football", 1, "NES", "John Elway's Quarterback", "" },
                    { 379, 12280, 1, "http://img1.game-oldies.com/sites/default/files/packshots/nintendo-nes/jordan-vs-bird-one-on-one-usa.png", 1, "Basketball", 1, "NES", "Jordan vs Bird One on One", "" },
                    { 380, 12281, 1, "https://www.mobygames.com/images/covers/l/174560-joshua-the-battle-of-jericho-genesis-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Joshua: The Battle of Jericho", "" },
                    { 381, 12282, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f1/Journey_to_Silius_box.jpg/220px-Journey_to_Silius_box.jpg", 1, "Action & Adventure", 1, "NES", "Journey to Silius", "" },
                    { 370, 12278, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/1e/Jaws_%28NES%29.jpg/220px-Jaws_%28NES%29.jpg", 1, "Action & Adventure", 1, "NES", "Jaws", "" },
                    { 382, 12283, 1, "https://www.mobygames.com/images/covers/l/205175-joust-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Joust", "" },
                    { 384, 12284, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/2/23/Kabuki_Quantum_Fighter.jpg/220px-Kabuki_Quantum_Fighter.jpg", 1, "Fighting", 1, "NES", "Kabuki Quantum Fighter", "" },
                    { 385, 12285, 1, "https://www.mobygames.com/images/covers/l/16474-karate-champ-nes-front-cover.jpg", 1, "Fighting", 1, "NES", "Karate Champ", "" },
                    { 386, 39518, 1, "https://www.mobygames.com/images/covers/l/16474-karate-champ-nes-front-cover.jpg", 1, "Sports", 1, "NES", "Karate Champ [5 Screw]", "" },
                    { 387, 12286, 1, "https://i.pinimg.com/originals/8f/18/80/8f1880d9448e44e6a83f2fc543dac581.jpg", 1, "Action & Adventure", 1, "NES", "Karnov", "" },
                    { 388, 9204, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/fe/Kick_Master_Coverart.png/220px-Kick_Master_Coverart.png", 1, "Action & Adventure", 1, "NES", "Kick Master", "" },
                    { 389, 12287, 1, "https://www.mobygames.com/images/covers/l/77990-kickle-cubicle-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Kickle Cubicle", "" },
                    { 390, 11996, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/b/b1/Kid_Icarus_NES_box_art.png/220px-Kid_Icarus_NES_box_art.png", 1, "Action & Adventure", 1, "NES", "Kid Icarus", "" },
                    { 391, 38010, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/b/b1/Kid_Icarus_NES_box_art.png/220px-Kid_Icarus_NES_box_art.png", 1, "Action & Adventure", 1, "NES", "Kid Icarus [5 Screw]", "" },
                    { 392, 9205, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/8/88/Kid_Klown_in_Night_Mayor_World_Coverart.png/220px-Kid_Klown_in_Night_Mayor_World_Coverart.png", 1, "Action & Adventure", 1, "NES", "Kid Klown in Night Mayor World", "" },
                    { 393, 12288, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/8/80/Kid_Kool_Coverart.png/220px-Kid_Kool_Coverart.png", 1, "Action & Adventure", 1, "NES", "Kid Kool", "" },
                    { 394, 12289, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Kid_Niki_-_Radical_Ninja_Coverart.png/220px-Kid_Niki_-_Radical_Ninja_Coverart.png", 1, "Action & Adventure", 1, "NES", "Kid Niki Radical Ninja", "" },
                    { 383, 9190, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/Jurassic_Park_box_art_%28NES%29.jpg/220px-Jurassic_Park_box_art_%28NES%29.jpg", 1, "Action & Adventure", 1, "NES", "Jurassic Park", "" },
                    { 369, 9161, 1, "https://i0.wp.com/www.nintendology.com/wp-content/uploads/2017/04/James-Bond-Jr-NES-Box-Art.jpg?fit=540%2C739&ssl=1", 1, "Action & Adventure", 1, "NES", "James Bond Jr", "" },
                    { 368, 12277, 1, "https://www.mobygames.com/images/covers/l/56227-jackie-chan-s-action-kung-fu-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Jackie Chan's Action Kung Fu", "" },
                    { 367, 12276, 1, "https://www.mobygames.com/images/covers/l/78560-jackal-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Jackal", "" },
                    { 342, 9132, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/c/cb/Hudson_Hawk_-_cover_art_%28NES%29.jpg/220px-Hudson_Hawk_-_cover_art_%28NES%29.jpg", 1, "Action & Adventure", 1, "NES", "Hudson Hawk", "" },
                    { 343, 9133, 1, "https://www.mobygames.com/images/covers/l/175020-the-hunt-for-red-october-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Hunt for Red October", "" },
                    { 344, 12264, 1, "https://www.mobygames.com/images/covers/l/175300-hydlide-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Hydlide", "" },
                    { 345, 11994, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/d/df/IceClimberboxartnes.jpg/220px-IceClimberboxartnes.jpg", 1, "Action & Adventure", 1, "NES", "Ice Climber", "" },
                    { 346, 37972, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/d/df/IceClimberboxartnes.jpg/220px-IceClimberboxartnes.jpg", 1, "Action & Adventure", 1, "NES", "Ice Climber [5 Screw]", "" },
                    { 347, 11995, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/3/3d/Icehockeyvideogame.jpg/220px-Icehockeyvideogame.jpg", 1, "Sports", 1, "NES", "Ice Hockey", "" },
                    { 348, 12265, 1, "https://www.mobygames.com/images/covers/l/93961-ikari-warriors-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Ikari Warriors", "" },
                    { 349, 12266, 1, "https://www.mobygames.com/images/covers/l/370579-ikari-warriors-ii-victory-road-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Ikari Warriors II", "" },
                    { 350, 12267, 1, "https://static.giantbomb.com/uploads/scale_medium/9/93770/2361851-nes_ikariwarriors3.jpg", 1, "Action & Adventure", 1, "NES", "Ikari Warriors III", "" },
                    { 351, 38008, 1, "https://www.mobygames.com/images/covers/l/93961-ikari-warriors-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Ikari Warriors [5 Screw]", "" },
                    { 352, 12268, 1, "https://i.pinimg.com/originals/35/0b/d8/350bd8b570f35b1720d45a6f08ff6e3a.jpg", 1, "Fighting", 1, "NES", "Image Fight", "" },
                    { 353, 9138, 1, "https://www.mobygames.com/images/covers/l/395031-the-immortal-nes-front-cover.jpg", 1, "RPG", 1, "NES", "Immortal", "" },
                    { 354, 12269, 1, "https://server.emulator.games/images/nintendo/impossible-mission-2.jpg", 1, "Action & Adventure", 1, "NES", "Impossible Mission II", "" },
                    { 355, 44966, 1, "https://gamefaqs.akamaized.net/box/2/5/5/49255_front.jpg", 1, "Action & Adventure", 1, "NES", "Impossible Mission II [AVE]", "" },
                    { 356, 39510, 1, "https://gamefaqs.akamaized.net/box/2/5/5/49255_front.jpg", 1, "Action & Adventure", 1, "NES", "Impossible Mission II [SEI]", "" },
                    { 357, 9143, 1, "http://img2.game-oldies.com/sites/default/files/packshots/nintendo-nes/incredible-crash-dummies-the-usa.png", 1, "Action & Adventure", 1, "NES", "Incredible Crash Dummies", "" },
                    { 358, 12270, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/e/e0/Indiana_Jones_and_the_Last_Crusade_%281991%29_Coverart.png/220px-Indiana_Jones_and_the_Last_Crusade_%281991%29_Coverart.png", 1, "Action & Adventure", 1, "NES", "Indiana Jones and the Last Crusade", "" },
                    { 359, 30748, 1, "https://vignette.wikia.nocookie.net/nintendo/images/9/97/Indiana_Jones_and_the_Last_Crusade_%28Ubisoft%29_%28NES%29_%28NA%29.jpg/revision/latest?cb=20130630234332&path-prefix=en", 1, "Action & Adventure", 1, "NES", "Indiana Jones and the Last Crusade [Ubisoft]", "" },
                    { 360, 12271, 1, "https://www.mobygames.com/images/covers/l/73741-indiana-jones-and-the-temple-of-doom-commodore-64-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Indiana Jones and the Temple of Doom", "" },
                    { 361, 39513, 1, "https://www.mobygames.com/images/covers/l/15589-indiana-jones-and-the-temple-of-doom-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Indiana Jones and the Temple of Doom [Tengen]", "" },
                    { 362, 12272, 1, "https://i.pinimg.com/originals/d7/ba/48/d7ba4871e835e011855b019f7f2ba5c9.jpg", 1, "Action & Adventure", 1, "NES", "Infiltrator", "" },
                    { 363, 12274, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/6/6d/Ironsword_cover.png/220px-Ironsword_cover.png", 1, "RPG", 1, "NES", "Iron Sword Wizards and Warriors II", "" },
                    { 364, 12273, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/e/eb/Iron_tank_cover_nes.jpg/220px-Iron_tank_cover_nes.jpg", 1, "Action & Adventure", 1, "NES", "Iron Tank", "" },
                    { 365, 12275, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/7/70/Isolated_Warrior_Cover.png/220px-Isolated_Warrior_Cover.png", 1, "Action & Adventure", 1, "NES", "Isolated Warrior", "" },
                    { 366, 9155, 1, "https://www.mobygames.com/images/covers/l/17146-jack-nicklaus-greatest-18-holes-of-major-championship-golf-nes-front-cover.jpg", 1, "Sports", 1, "NES", "Jack Nicklaus Golf", "" },
                    { 395, 38041, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/53/Kid_Niki_-_Radical_Ninja_Coverart.png/220px-Kid_Niki_-_Radical_Ninja_Coverart.png", 1, "Action & Adventure", 1, "NES", "Kid Niki Radical Ninja [5 Screw]", "" },
                    { 341, 14931, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/18/HotSlotsBoxShotNES.jpg/220px-HotSlotsBoxShotNES.jpg", 1, "Action & Adventure", 1, "NES", "Hot Slots", "" },
                    { 396, 16437, 1, "https://now.estarland.com/images/products/hr/13446/096962810160.jpg", 1, "Action & Adventure", 1, "NES", "King Neptune's Adventure", "" },
                    { 398, 9212, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/King%27s_Knight_Screenshot1.jpg/220px-King%27s_Knight_Screenshot1.jpg", 1, "Strategy", 1, "NES", "King's Knight", "" },
                    { 428, 12306, 1, "https://www.mobygames.com/images/covers/l/14449-life-force-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Life Force", "" },
                    { 429, 12307, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/55/Linus_Spacehead%27s_Cosmic_Crusade_cover.png/256px-Linus_Spacehead%27s_Cosmic_Crusade_cover.png", 1, "Action & Adventure", 1, "NES", "Linus Spacehead's Cosmic Adventure", "" },
                    { 430, 39522, 1, "https://www.mobygames.com/images/covers/l/14723-cosmic-spacehead-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Linus Spacehead's Cosmic Adventure [Aladdin]", "" },
                    { 431, 12308, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/3/37/LittleLeagueBaseballBoxShotNES.jpg/220px-LittleLeagueBaseballBoxShotNES.jpg", 1, "Baseball", 1, "NES", "Little League Baseball", "" },
                    { 432, 9248, 1, "https://www.mobygames.com/images/covers/l/255951-disney-s-the-little-mermaid-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Little Mermaid", "" },
                    { 433, 9249, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/0/0b/Littlenemocover.png/250px-Littlenemocover.png", 1, "Action & Adventure", 1, "NES", "Little Nemo The Dream Master", "" },
                    { 434, 12309, 1, "http://img1.game-oldies.com/sites/default/files/packshots/nintendo-nes/little-ninja-brothers-usa.png", 1, "Action & Adventure", 1, "NES", "Little Ninja Brothers", "" },
                    { 435, 9250, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/0/0f/NES-LittleSamson.jpg/220px-NES-LittleSamson.jpg", 1, "Action & Adventure", 1, "NES", "Little Samson", "" },
                    { 436, 11998, 1, "http://img2.game-oldies.com/sites/default/files/packshots/nintendo-nes/lode-runner-usa.png", 1, "Action & Adventure", 1, "NES", "Lode Runner", "" },
                    { 437, 38024, 1, "http://img2.game-oldies.com/sites/default/files/packshots/nintendo-nes/lode-runner-usa.png", 1, "Action & Adventure", 1, "NES", "Lode Runner [5 Screw]", "" },
                    { 438, 9253, 1, "https://www.mobygames.com/images/covers/l/115003-the-lone-ranger-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Lone Ranger", "" },
                    { 427, 9245, 1, "https://www.mobygames.com/images/covers/l/351852-lethal-weapon-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Lethal Weapon", "" },
                    { 439, 12310, 1, "https://www.mobygames.com/images/covers/l/175551-loopz-nes-front-cover.jpg", 1, "Puzzle", 1, "NES", "Loopz", "" },
                    { 441, 9260, 1, "https://upload.wikimedia.org/wikipedia/en/2/25/LunarPoolNESBoxart.jpg", 1, "Sports", 1, "NES", "Lunar Pool", "" },
                    { 442, 38036, 1, "https://upload.wikimedia.org/wikipedia/en/2/25/LunarPoolNESBoxart.jpg", 1, "Sports", 1, "NES", "Lunar Pool [5 Screw]", "" },
                    { 443, 9307, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/8/89/M.C._Kids_cover.png/220px-M.C._Kids_cover.png", 1, "Action & Adventure", 1, "NES", "M.C. Kids", "" },
                    { 444, 9387, 1, "https://www.mobygames.com/images/covers/l/80346-m-u-l-e-nes-front-cover.jpg", 1, "Other", 1, "NES", "M.U.L.E.", "" },
                    { 445, 12386, 1, "https://www.mobygames.com/images/covers/l/175543-remote-control-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "MTV Remote Control", "" },
                    { 446, 12312, 1, "https://www.mobygames.com/images/covers/l/120864-m-u-s-c-l-e-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "MUSCLE", "" },
                    { 447, 11999, 1, "https://www.mobygames.com/images/covers/l/76295-mach-rider-nes-front-cover.png", 1, "Racing", 1, "NES", "Mach Rider", "" },
                    { 448, 37978, 1, "https://www.mobygames.com/images/covers/l/76295-mach-rider-nes-front-cover.png", 1, "Racing", 1, "NES", "Mach Rider [5 Screw]", "" },
                    { 449, 12313, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/Mad_Max_Coverart.png/220px-Mad_Max_Coverart.png", 1, "Action & Adventure", 1, "NES", "Mad Max", "" },
                    { 450, 9275, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f5/Magic_Darts_Cover.jpg/220px-Magic_Darts_Cover.jpg", 1, "Sports", 1, "NES", "Magic Darts", "" },
                    { 451, 12227, 1, "https://www.mobygames.com/images/covers/l/163635-magic-johnson-s-fast-break-nes-front-cover.jpg", 1, "Basketball", 1, "NES", "Magic Johnson's Fast Break", "" },
                    { 440, 12311, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/0/0c/Low_G_Man_NES_US_box.jpg/220px-Low_G_Man_NES_US_box.jpg", 1, "Action & Adventure", 1, "NES", "Low G Man", "" },
                    { 426, 9240, 1, "https://www.mobygames.com/images/covers/l/59103-lemmings-nes-front-cover.jpg", 1, "Puzzle", 1, "NES", "Lemmings", "" },
                    { 425, 12305, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/c/ca/Legends_of_the_Diamond_cover.jpg/220px-Legends_of_the_Diamond_cover.jpg", 1, "Baseball", 1, "NES", "Legends of the Diamond", "" },
                    { 424, 12304, 1, "https://i.pinimg.com/originals/ce/54/84/ce5484a576f991776d561b73cbc280e7.jpg", 1, "Other", 1, "NES", "Legendary Wings", "" },
                    { 399, 12291, 1, "https://www.mobygames.com/images/covers/l/224591-king-s-quest-v-nes-front-cover.png", 1, "RPG", 1, "NES", "King's Quest V", "" },
                    { 400, 12292, 1, "https://www.mobygames.com/images/covers/l/51824-kings-of-the-beach-nes-front-cover.jpg", 1, "Sports", 1, "NES", "Kings of the Beach", "" },
                    { 401, 9213, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Kirby%27s_Adventure_Coverart.png/220px-Kirby%27s_Adventure_Coverart.png", 1, "Action & Adventure", 1, "NES", "Kirby's Adventure", "" },
                    { 402, 12293, 1, "https://takeontheneslibrary.com/wp-content/uploads/2018/01/063-Kiwi-Kraze.jpg", 1, "Action & Adventure", 1, "NES", "Kiwi Kraze", "" },
                    { 403, 12294, 1, "https://r.mprd.se/fup/up/56010-Klash_Ball_(USA)-1496879694.jpg", 1, "Sports", 1, "NES", "Klash Ball", "" },
                    { 404, 12295, 1, "https://www.mobygames.com/images/covers/l/15584-klax-nes-front-cover.jpg", 1, "Puzzle", 1, "NES", "Klax", "" },
                    { 405, 12296, 1, "https://www.mobygames.com/images/covers/l/169346-knight-rider-nes-front-cover.jpg", 1, "Racing", 1, "NES", "Knight Rider", "" },
                    { 406, 12297, 1, "https://www.mobygames.com/images/covers/l/17989-krazy-kreatures-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Krazy Kreatures", "" },
                    { 407, 12298, 1, "https://www.mobygames.com/images/covers/l/224596-the-krion-conquest-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Krion Conquest", "" },
                    { 408, 9217, 1, "https://www.mobygames.com/images/covers/l/146966-krusty-s-super-fun-house-nes-front-cover.jpg", 1, "Puzzle", 1, "NES", "Krusty's Fun House", "" },
                    { 409, 12299, 1, "https://www.mobygames.com/images/covers/l/15705-kung-fu-master-nes-front-cover.jpg", 1, "Fighting", 1, "NES", "Kung Fu", "" },
                    { 410, 12300, 1, "https://upload.wikimedia.org/wikipedia/en/5/5c/KungFuHeroes_frontcover.png", 1, "Fighting", 1, "NES", "Kung Fu Heroes", "" },
                    { 411, 37973, 1, "https://www.mobygames.com/images/covers/l/15705-kung-fu-master-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Kung Fu [5 Screw]", "" },
                    { 412, 9242, 1, "https://www.mobygames.com/images/covers/l/249192-l-empereur-dos-front-cover.jpg", 1, "Strategy", 1, "NES", "L'Empereur", "" },
                    { 413, 9222, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/a/a2/Laser_Invasion_Coverart.png/220px-Laser_Invasion_Coverart.png", 1, "Action & Adventure", 1, "NES", "Laser Invasion", "" },
                    { 414, 19472, 1, "http://jmarcosn.wanadooadsl.net/colecciones/coleccion_NES_scope.jpg", 1, "Accessories", 1, "NES", "Laserscope", "" },
                    { 415, 9224, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/8/8f/Last_Action_Hero_Coverart.png/220px-Last_Action_Hero_Coverart.png", 1, "Action & Adventure", 1, "NES", "Last Action Hero", "" },
                    { 416, 12301, 1, "https://cdn.thegamesdb.net/images/original/boxart/front/2296-1.png", 1, "Action & Adventure", 1, "NES", "Last Starfighter", "" },
                    { 417, 12302, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/8/8a/LeeTrevinoFightingGolfBoxart.jpg/220px-LeeTrevinoFightingGolfBoxart.jpg", 1, "Sports", 1, "NES", "Lee Trevino's Fighting Golf", "" },
                    { 418, 12303, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/e/ec/Legacyofthewizard.jpg/220px-Legacyofthewizard.jpg", 1, "RPG", 1, "NES", "Legacy of the Wizard", "" },
                    { 419, 11997, 1, "https://www.mobygames.com/images/covers/l/260581-the-legend-of-kage-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Legend of Kage", "" },
                    { 420, 38018, 1, "https://www.mobygames.com/images/covers/l/260581-the-legend-of-kage-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Legend of Kage [5 Screw]", "" },
                    { 421, 9236, 1, "https://www.mobygames.com/images/covers/l/14445-the-legend-of-zelda-nes-front-cover.jpg", 1, "Strategy", 1, "NES", "Legend of Zelda", "" },
                    { 422, 38020, 1, "https://www.mobygames.com/images/covers/l/14445-the-legend-of-zelda-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Legend of Zelda [5 Screw]", "" },
                    { 423, 38512, 1, "https://www.mobygames.com/images/covers/l/14445-the-legend-of-zelda-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Legend of Zelda [Gray Cart]", "" },
                    { 397, 12290, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/d/d7/King_of_Kings_-_The_Early_Years_Coverart.png/250px-King_of_Kings_-_The_Early_Years_Coverart.png", 1, "RPG", 1, "NES", "King of Kings", "" },
                    { 907, 10236, 1, "", 1, "Action & Adventure", 1, "NES", "Zen Intergalactic Ninja", "" },
                    { 340, 12263, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/b/b4/Hoops_Cover.jpg/220px-Hoops_Cover.jpg", 1, "Basketball", 1, "NES", "Hoops", "" },
                    { 338, 9119, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/59/HomeAlone2LINY.jpg/220px-HomeAlone2LINY.jpg", 1, "Action & Adventure", 1, "NES", "Home Alone 2 Lost In New York", "" },
                    { 257, 39521, 1, "https://server.emulator.games/images/nintendo/fantastic-adventures-of-dizzy-the.jpg", 1, "Action & Adventure", 1, "NES", "Fantastic Adventures of Dizzy [Aladdin]", "" },
                    { 258, 12226, 1, "https://static.giantbomb.com/uploads/scale_small/0/3413/214159-fantasy_zone.jpg", 1, "Action & Adventure", 1, "NES", "Fantasy Zone", "" },
                    { 259, 8939, 1, "https://upload.wikimedia.org/wikipedia/en/5/58/Faria_cover.jpg", 1, "RPG", 1, "NES", "Faria", "" },
                    { 260, 13717, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/57/Faxanadu_NES_US_box.jpg/200px-Faxanadu_NES_US_box.jpg", 1, "Action & Adventure", 1, "NES", "Faxanadu", "" },
                    { 261, 8948, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/a/a9/FelixNESBoxart.JPG/220px-FelixNESBoxart.JPG", 1, "Action & Adventure", 1, "NES", "Felix the Cat", "" },
                    { 262, 8949, 1, "https://www.mobygames.com/images/covers/l/154784-ferrari-grand-prix-challenge-nes-front-cover.jpg", 1, "Racing", 1, "NES", "Ferrari Grand Prix Challenge", "" },
                    { 263, 8950, 1, "https://www.mobygames.com/images/covers/l/163627-fester-s-quest-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Fester's Quest", "" },
                    { 264, 8970, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/d/d8/FF1_USA_boxart.jpg/220px-FF1_USA_boxart.jpg", 1, "RPG", 1, "NES", "Final Fantasy", "" },
                    { 265, 8975, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/7/7d/Fire_%27n_Ice_Cover.jpg/220px-Fire_%27n_Ice_Cover.jpg", 1, "Puzzle", 1, "NES", "Fire 'N Ice", "" },
                    { 266, 12229, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/0/0e/FirehawkNES.jpg/250px-FirehawkNES.jpg", 1, "Action & Adventure", 1, "NES", "Firehawk", "" },
                    { 267, 12230, 1, "https://www.mobygames.com/images/covers/l/175579-fisher-price-i-can-remember-nes-front-cover.jpg", 1, "Other", 1, "NES", "Fisher Price I Can Remember", "" },
                    { 256, 12225, 1, "https://upload.wikimedia.org/wikipedia/en/a/a0/Cover-of-the-fantastic-adventures-of-dizzy.jpg", 1, "Action & Adventure", 1, "NES", "Fantastic Adventures of Dizzy", "" },
                    { 268, 12231, 1, "https://www.mobygames.com/images/covers/l/175380-fisher-price-perfect-fit-nes-front-cover.jpg", 1, "Other", 1, "NES", "Fisher Price Perfect Fit", "" },
                    { 270, 12232, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/e/e2/Fist_of_the_North_Star_Coverart.png/220px-Fist_of_the_North_Star_Coverart.png", 1, "Fighting", 1, "NES", "Fist of the North Star", "" },
                    { 271, 8981, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/1e/Flight_of_the_Intruder_Cover.jpg/220px-Flight_of_the_Intruder_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Flight of the Intruder", "" },
                    { 272, 13107, 1, "https://server.emulator.games/images/nintendo/flintstones-2-the-surprise-at-dinosaur-peak-the.jpg", 1, "Action & Adventure", 1, "NES", "Flintstones Surprise at Dinosaur Peak", "" },
                    { 273, 8983, 1, "https://www.mobygames.com/images/covers/l/64858-the-flintstones-the-rescue-of-dino-hoppy-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Flintstones The Rescue of Dino and Hoppy", "" },
                    { 274, 12234, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/c/c7/Flying_Dragon_The_Secret_Scroll_Cover.jpg/250px-Flying_Dragon_The_Secret_Scroll_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Flying Dragon", "" },
                    { 275, 12235, 1, "https://upload.wikimedia.org/wikipedia/en/6/61/FW_NES.PNG", 1, "Action & Adventure", 1, "NES", "Flying Warriors", "" },
                    { 276, 14550, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/4/43/Formula_One_Built_to_Win_Cover.jpg/220px-Formula_One_Built_to_Win_Cover.jpg", 1, "Racing", 1, "NES", "Formula One Built To Win", "" },
                    { 277, 12236, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/9/99/Frankenstein_The_Monster_Returns_Cover.jpg/220px-Frankenstein_The_Monster_Returns_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Frankenstein the Monster Returns", "" },
                    { 278, 12237, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/b/b2/Freedom_Force_Video_Game_Boxcover.jpg/250px-Freedom_Force_Video_Game_Boxcover.jpg", 1, "Action & Adventure", 1, "NES", "Freedom Force", "" },
                    { 279, 12238, 1, "https://upload.wikimedia.org/wikipedia/en/b/be/Friday_the_13th_NES.png", 1, "Action & Adventure", 1, "NES", "Friday the 13th", "" },
                    { 280, 12239, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/a/a7/Fun_House_Cover.jpg/220px-Fun_House_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Fun House", "" },
                    { 269, 8976, 1, "https://cdn.thegamesdb.net/images/original/boxart/front/2382-1.jpg", 1, "Action & Adventure", 1, "NES", "Fisher-Price Firehouse Rescue", "" },
                    { 255, 12224, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/7/70/Stadium_Events_cover.jpg/220px-Stadium_Events_cover.jpg", 1, "Sports", 1, "NES", "Family Fun Fitness Stadium Events", "" },
                    { 254, 45059, 1, "http://image.gamevaluenow.com/nes/family_fun_fitness_pad.jpg", 1, "Controllers", 1, "NES", "Family Fun Fitness Pad", "" },
                    { 253, 8935, 1, "https://server.emulator.games/images/nintendo/family-feud.jpg", 1, "Other", 1, "NES", "Family Feud", "" },
                    { 228, 12213, 1, "https://www.mobygames.com/images/covers/l/153084-dragon-power-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Dragon Power", "" },
                    { 229, 12214, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/19/Dragon-spirit.jpg/250px-Dragon-spirit.jpg", 1, "Action & Adventure", 1, "NES", "Dragon Spirit", "" },
                    { 230, 12216, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/8/84/Dragon_Warrior.jpg/220px-Dragon_Warrior.jpg", 1, "RPG", 1, "NES", "Dragon Warrior", "" },
                    { 231, 12215, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/fd/Dragon_Warrior_II.jpg/220px-Dragon_Warrior_II.jpg", 1, "RPG", 1, "NES", "Dragon Warrior II", "" },
                    { 232, 8868, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/b/b8/Dragon_Warrior_III.jpg/220px-Dragon_Warrior_III.jpg", 1, "RPG", 1, "NES", "Dragon Warrior III", "" },
                    { 233, 8869, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/d/db/Dragon_Quest_IV_cover.jpg/220px-Dragon_Quest_IV_cover.jpg", 1, "RPG", 1, "NES", "Dragon Warrior IV", "" },
                    { 234, 12217, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/fd/Dragon%27s_Lair_NES_cover.jpg/220px-Dragon%27s_Lair_NES_cover.jpg", 1, "Action & Adventure", 1, "NES", "Dragon's Lair the Legend", "" },
                    { 235, 12218, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/14/DuckHuntBox.jpg/220px-DuckHuntBox.jpg", 1, "Other", 1, "NES", "Duck Hunt", "" },
                    { 236, 37976, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/14/DuckHuntBox.jpg/220px-DuckHuntBox.jpg", 1, "Action & Adventure", 1, "NES", "Duck Hunt [5 Screw]", "" },
                    { 237, 12219, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/6/64/DuckTales_NES_Cover.png/220px-DuckTales_NES_Cover.png", 1, "Action & Adventure", 1, "NES", "Duck Tales", "" },
                    { 238, 8878, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/15/Ducktales_2_cover.png/220px-Ducktales_2_cover.png", 1, "Action & Adventure", 1, "NES", "Duck Tales 2", "" },
                    { 239, 34156, 1, "https://4.bp.blogspot.com/-8oUO9GvEKJY/UgkFGDSg_JI/AAAAAAAAHJo/q4C_K2pOhJc/s1600/gold-duck-tales-nes.jpg", 1, "Action & Adventure", 1, "NES", "Duck Tales Gold Cartridge", "" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "ApiGameId", "CibPrice", "CoverURL", "GameConsoleId", "Genre", "LoosePrice", "SystemId", "Title", "Upc" },
                values: new object[,]
                {
                    { 240, 12220, 1, "https://static.giantbomb.com/uploads/scale_small/9/93770/2361690-nes_dudeswithattitude.jpg", 1, "Action & Adventure", 1, "NES", "Dudes with Attitude", "" },
                    { 241, 12221, 1, "https://upload.wikimedia.org/wikipedia/en/8/85/Dungeon_Magic_Sword_of_the_Elements.jpg", 1, "RPG", 1, "NES", "Dungeon Magic", "" },
                    { 242, 12222, 1, "http://img2.game-oldies.com/sites/default/files/packshots/nintendo-nes/dusty-diamond-s-all-star-softball-usa.png", 1, "Baseball", 1, "NES", "Dusty Diamond's All-Star Softball", "" },
                    { 243, 8889, 1, "https://www.mobygames.com/images/covers/l/128205-dynowarz-destruction-of-spondylus-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Dynowarz The Destruction of Spondylus", "" },
                    { 244, 11989, 1, "https://www.mobygames.com/images/covers/l/224482-elevator-action-nes-front-cover.png", 1, "Puzzle", 1, "NES", "Elevator Action", "" },
                    { 245, 38017, 1, "https://www.mobygames.com/images/covers/l/224482-elevator-action-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Elevator Action [5 Screw]", "" },
                    { 246, 8906, 1, "https://upload.wikimedia.org/wikipedia/en/a/a3/Eliminator_Boat_Duel_cover.jpg", 1, "Racing", 1, "NES", "Eliminator Boat Duel", "" },
                    { 247, 11990, 1, "https://upload.wikimedia.org/wikipedia/en/f/f8/Excitebike_cover.jpg", 1, "Racing", 1, "NES", "Excitebike", "" },
                    { 248, 37977, 1, "https://upload.wikimedia.org/wikipedia/en/f/f8/Excitebike_cover.jpg", 1, "Racing", 1, "NES", "Excitebike [5 Screw]", "" },
                    { 249, 12223, 1, "https://www.mobygames.com/images/covers/l/26358-exodus-journey-to-the-promised-land-nes-front-cover.jpg", 1, "RPG", 1, "NES", "Exodus Journey to the Promised Land", "" },
                    { 250, 8928, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/56/F-117A_Stealth_Fighter_cover.png/220px-F-117A_Stealth_Fighter_cover.png", 1, "Other", 1, "NES", "F-117A Stealth Fighter", "" },
                    { 251, 19760, 1, "https://www.mobygames.com/images/covers/l/17798-f-15-city-war-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "F-15 City War", "" },
                    { 252, 8929, 1, "https://www.mobygames.com/images/covers/l/79919-f-15-strike-eagle-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "F-15 Strike Eagle", "" },
                    { 281, 12240, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/2/27/G.I._Joe_NES_Cover.jpg/220px-G.I._Joe_NES_Cover.jpg", 1, "Action & Adventure", 1, "NES", "G.I. Joe: A Real American Hero", "" },
                    { 339, 9121, 1, "https://i.ebayimg.com/images/g/UoUAAOSwvytcD5jn/s-l300.jpg", 1, "Action & Adventure", 1, "NES", "Hook", "" },
                    { 282, 9034, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/5e/G.I._Joe_The_Atlantis_Factor_Cover.jpg/220px-G.I._Joe_The_Atlantis_Factor_Cover.jpg", 1, "Action & Adventure", 1, "NES", "GI Joe The Atlantis Factor", "" },
                    { 284, 11991, 1, "https://i.pinimg.com/originals/c3/c8/60/c3c860ab71820d0c4084be8a5e8a87c7.jpg", 1, "Other", 1, "NES", "Galaga: Demons of Death", "" },
                    { 314, 39516, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/7/7e/Gotcha_box.JPG/220px-Gotcha_box.JPG", 1, "Action & Adventure", 1, "NES", "Gotcha [5 Screw]", "" },
                    { 315, 11993, 1, "https://www.mobygames.com/images/covers/l/14540-gradius-nes-front-cover.jpg", 1, "Other", 1, "NES", "Gradius", "" },
                    { 316, 37999, 1, "https://www.mobygames.com/images/covers/l/14540-gradius-nes-front-cover.jpg", 1, "Other", 1, "NES", "Gradius [5 Screw]", "" },
                    { 317, 9063, 1, "https://server.emulator.games/images/nintendo/great-waldo-search-the.jpg", 1, "Puzzle", 1, "NES", "Great Waldo Search", "" },
                    { 318, 9068, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/7/71/GregNormansGolfPowerBoxShotNES.jpg/220px-GregNormansGolfPowerBoxShotNES.jpg", 1, "Sports", 1, "NES", "Greg Norman's Golf Power", "" },
                    { 319, 12252, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/e/e5/Gremlins2nes.PNG/250px-Gremlins2nes.PNG", 1, "Action & Adventure", 1, "NES", "Gremlins 2", "" },
                    { 320, 12253, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/1b/Guerrilla_War_Cover.png/252px-Guerrilla_War_Cover.png", 1, "Action & Adventure", 1, "NES", "Guerrilla War", "" },
                    { 321, 12254, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/56/Gumshoebox.jpg/220px-Gumshoebox.jpg", 1, "Action & Adventure", 1, "NES", "Gumshoe", "" },
                    { 322, 37990, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/56/Gumshoebox.jpg/220px-Gumshoebox.jpg", 1, "Other", 1, "NES", "Gumshoe [5 Screw]", "" },
                    { 323, 12255, 1, "https://upload.wikimedia.org/wikipedia/en/d/d6/Gun_Nac_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Gun-Nac", "" },
                    { 324, 12256, 1, "https://www.mobygames.com/images/covers/l/253224-gun-smoke-nes-front-cover.png", 1, "Action & Adventure", 1, "NES", "Gun.Smoke", "" },
                    { 313, 12251, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/7/7e/Gotcha_box.JPG/220px-Gotcha_box.JPG", 1, "Action & Adventure", 1, "NES", "Gotcha", "" },
                    { 325, 12257, 1, "https://upload.wikimedia.org/wikipedia/en/3/36/Gyromite_front.jpg", 1, "Action & Adventure", 1, "NES", "Gyromite", "" },
                    { 327, 37958, 1, "http://www.mobygames.com/images/covers/l/75247-gyromite-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Gyromite [ROB Bundle]", "" },
                    { 328, 12258, 1, "https://www.mobygames.com/images/covers/l/16161-gyruss-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Gyruss", "" },
                    { 329, 12259, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f6/Harlem_Globetrotters_cover.jpg/220px-Harlem_Globetrotters_cover.jpg", 1, "Basketball", 1, "NES", "Harlem Globetrotters", "" },
                    { 330, 9097, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/7/71/Hatris_cover.png/220px-Hatris_cover.png", 1, "Puzzle", 1, "NES", "Hatris", "" },
                    { 331, 12260, 1, "https://www.mobygames.com/images/covers/l/191291-heavy-barrel-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Heavy Barrel", "" },
                    { 332, 12261, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/7/70/Heavy_shreddin_cover_NES.jpg/250px-Heavy_shreddin_cover_NES.jpg", 1, "Action & Adventure", 1, "NES", "Heavy Shreddin'", "" },
                    { 333, 9109, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/9/9d/High_Speed_box_art.jpg/220px-High_Speed_box_art.jpg", 1, "Arcade", 1, "NES", "High Speed", "" },
                    { 334, 12262, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/12/Hogan%27s_Alley_Cover.jpg/250px-Hogan%27s_Alley_Cover.jpg", 1, "Other", 1, "NES", "Hogan's Alley", "" },
                    { 335, 37971, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/12/Hogan%27s_Alley_Cover.jpg/250px-Hogan%27s_Alley_Cover.jpg", 1, "Other", 1, "NES", "Hogan's Alley [5 Screw]", "" },
                    { 336, 9115, 1, "https://www.mobygames.com/images/covers/l/73125-hollywood-squares-nes-front-cover.jpg", 1, "Other", 1, "NES", "Hollywood Squares", "" },
                    { 337, 9117, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/5/57/HomeAlone1game.jpg/220px-HomeAlone1game.jpg", 1, "Action & Adventure", 1, "NES", "Home Alone", "" },
                    { 326, 37970, 1, "https://upload.wikimedia.org/wikipedia/en/3/36/Gyromite_front.jpg", 1, "Other", 1, "NES", "Gyromite [5 Screw]", "" },
                    { 312, 12250, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/b/bd/Golgo_13_Top_Secret_Episode_%28cover_art%29.jpg/220px-Golgo_13_Top_Secret_Episode_%28cover_art%29.jpg", 1, "Action & Adventure", 1, "NES", "Golgo 13 Top Secret Episode", "" },
                    { 311, 37969, 1, "https://i.pinimg.com/736x/14/d3/41/14d341315f65f6f028f027a815820c45.jpg", 1, "Sports", 1, "NES", "Golf [5 Screw]", "" },
                    { 310, 9051, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/9/9c/Golf_Grand_Slam.jpg/220px-Golf_Grand_Slam.jpg", 1, "Sports", 1, "NES", "Golf Grand Slam", "" },
                    { 285, 12242, 1, "https://www.mobygames.com/images/covers/l/95012-galaxy-5000-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Galaxy 5000", "" },
                    { 286, 52012, 1, "https://limitedgamenews.com/wp-content/uploads/2018/09/galf-limitedgamenews.com-nintendo-nes-cover-label.jpg", 1, "Sports", 1, "NES", "Galf", "" },
                    { 287, 52013, 1, "https://cdn.shopify.com/s/files/1/0912/7444/products/GALF-NES-White.png", 1, "Sports", 1, "NES", "Galf [White]", "" },
                    { 288, 13192, 1, "https://r.mprd.se/fup/up/55576-Game_Genie_(USA)_(Unl)-1496104634.jpg", 1, "Accessories", 1, "NES", "Game Genie", "" },
                    { 289, 37040, 1, "http://atariage.com/forums/uploads/post-7533-1169575068.jpg", 1, "Accessories", 1, "NES", "Game Genie Top Loader Adaptor", "" },
                    { 290, 9012, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/Gargoylesquest2.jpg/220px-Gargoylesquest2.jpg", 1, "Action & Adventure", 1, "NES", "Gargoyle's Quest II The Demon Darkness", "" },
                    { 291, 12243, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/f/f1/Gauntlet-NES-1989.jpg/220px-Gauntlet-NES-1989.jpg", 1, "Action & Adventure", 1, "NES", "Gauntlet", "" },
                    { 292, 9013, 1, "https://www.mobygames.com/images/covers/l/16037-gauntlet-ii-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Gauntlet II", "" },
                    { 293, 39511, 1, "https://i.ebayimg.com/images/g/FiYAAOSwFZtbQUmb/s-l300.jpg", 1, "Action & Adventure", 1, "NES", "Gauntlet [Gray Cart]", "" },
                    { 294, 9018, 1, "https://www.mobygames.com/images/covers/l/54369-gemfire-nes-front-cover.jpg", 1, "Strategy", 1, "NES", "Gemfire", "" },
                    { 295, 12244, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/1/1a/Genghis_Khan_Cover.jpg/220px-Genghis_Khan_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Genghis Khan", "" },
                    { 296, 9025, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/b/b7/George_Foreman%27s_KO_Boxing_Cover.jpg/220px-George_Foreman%27s_KO_Boxing_Cover.jpg", 1, "Sports", 1, "NES", "George Foreman's KO Boxing", "" },
                    { 297, 9029, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/Ghost_Lion_Coverart.png/220px-Ghost_Lion_Coverart.png", 1, "RPG", 1, "NES", "Ghost Lion", "" },
                    { 298, 12245, 1, "https://www.mobygames.com/images/covers/l/33098-ghostbusters-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Ghostbusters", "" },
                    { 299, 9032, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/e/e4/Ghostbusters2nes.jpg/220px-Ghostbusters2nes.jpg", 1, "Action & Adventure", 1, "NES", "Ghostbusters II", "" },
                    { 300, 11992, 1, "https://www.mobygames.com/images/covers/l/43175-ghosts-n-goblins-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Ghosts 'n Goblins", "" },
                    { 301, 37998, 1, "https://www.mobygames.com/images/covers/l/43175-ghosts-n-goblins-nes-front-cover.jpg", 1, "Action & Adventure", 1, "NES", "Ghosts 'n Goblins [5 Screw]", "" },
                    { 302, 9033, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/9/9b/Ghoul_School_Cover.jpg/220px-Ghoul_School_Cover.jpg", 1, "Action & Adventure", 1, "NES", "Ghoul School", "" },
                    { 303, 12247, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/9/92/GilligansIslandNESBoxArt.jpg/220px-GilligansIslandNESBoxArt.jpg", 1, "Action & Adventure", 1, "NES", "Gilligan's Island", "" },
                    { 304, 12248, 1, "https://i0.wp.com/www.nintendology.com/wp-content/uploads/2018/08/goal-NES-box-art.jpg", 1, "Soccer", 1, "NES", "Goal", "" },
                    { 305, 9039, 1, "https://upload.wikimedia.org/wikipedia/en/1/14/Goal%21_Two_%28video_game_box_art%29.jpg", 1, "Soccer", 1, "NES", "Goal Two", "" },
                    { 306, 12249, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/d/d5/Godzilla_-_Monster_of_Monsters_%28video_game_box_art%29.jpg/220px-Godzilla_-_Monster_of_Monsters_%28video_game_box_art%29.jpg", 1, "Action & Adventure", 1, "NES", "Godzilla", "" },
                    { 307, 9042, 1, "https://vignette.wikia.nocookie.net/godzilla/images/6/66/Godzilla2WotM.jpg/revision/latest?cb=20120513164126", 1, "Strategy", 1, "NES", "Godzilla 2", "" },
                    { 308, 9045, 1, "https://upload.wikimedia.org/wikipedia/en/thumb/8/8f/Capcom%27s_Gold_Medal_Challenge_%2792_Cover.jpg/220px-Capcom%27s_Gold_Medal_Challenge_%2792_Cover.jpg", 1, "Sports", 1, "NES", "Gold Medal Challenge '92", "" },
                    { 309, 9050, 1, "https://i.pinimg.com/736x/14/d3/41/14d341315f65f6f028f027a815820c45.jpg", 1, "Sports", 1, "NES", "Golf", "" },
                    { 283, 32330, 1, "https://upload.wikimedia.org/wikipedia/en/3/3f/Galactic_Crusader_cover.jpg", 1, "Action & Adventure", 1, "NES", "Galactic Crusader", "" },
                    { 908, 10239, 1, "", 1, "Other", 1, "NES", "Zombie Nation", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0171b6db-2f6b-4b5d-b7cd-ea31c1dea88f", "453ac20c-dca6-4133-9290-e00f9d881e05" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "58f2710e-d00d-4259-a450-cfc86a61cc3c", "347e9c7f-75b4-409f-b721-191910207b25" });

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34e3d1a3-bf89-429f-8bdc-8c41b82bbc59", "5b1847c7-0f9b-47f1-9c69-643fb1e0a492", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6beaa07a-ea93-48c1-8f01-c8e43760d1e1", "6b3546d4-62c0-42f0-af0d-2bdc1199d2e2", "Admin", "ADMIN" });
        }
    }
}
