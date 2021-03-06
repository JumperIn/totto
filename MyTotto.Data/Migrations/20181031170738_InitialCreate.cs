﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTotto.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: false),
                    BackgroundColor = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ActionDate = table.Column<DateTime>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 209, DateTimeKind.Local))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    SectionUrl = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromoProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 220, DateTimeKind.Local))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubbcategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    SectionUrl = table.Column<string>(nullable: true),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubbcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubbcategories_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    SectionUrl = table.Column<string>(nullable: true),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    ProductSubcategoryId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductGroups_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductGroups_ProductSubbcategories_ProductSubcategoryId",
                        column: x => x.ProductSubcategoryId,
                        principalTable: "ProductSubbcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    TitleUrl = table.Column<string>(nullable: true),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    ProductSubcategoryId = table.Column<int>(nullable: false),
                    ProductGroupId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Discount = table.Column<decimal>(nullable: false),
                    ProductType = table.Column<int>(nullable: false),
                    ImageUrls = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2018, 11, 1, 0, 7, 37, 217, DateTimeKind.Local))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductGroups_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Products_ProductSubbcategories_ProductSubcategoryId",
                        column: x => x.ProductSubcategoryId,
                        principalTable: "ProductSubbcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "ActionDate", "BackgroundColor", "Content", "Created", "ImageUrl", "IsActive", "Order", "Title" },
                values: new object[,]
                {
                    { 1, null, "faffe4", "При заказе на сумму от 300 рублей предоставляем бесплатную доставку в любой район Новосибирска", new DateTime(2018, 11, 1, 0, 7, 37, 211, DateTimeKind.Local), "/files/banners/banner-1.jpg", true, 10, "Бесплатная доставка" },
                    { 2, null, "ffffff", "чтобы узнавать самым первым все последние новости и акции!", new DateTime(2018, 11, 1, 0, 7, 37, 212, DateTimeKind.Local), "/files/banners/banner-2.jpg", true, 20, "Подпишись на новости" },
                    { 3, null, "84cad0", "Чтобы получить скидку на первый заказ необходимо зарегистрироваться и заполнить анкету первооткрывателя сайта", new DateTime(2018, 11, 1, 0, 7, 37, 212, DateTimeKind.Local), "/files/banners/banner-3.jpg", true, 15, "Скидка на первый заказ" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "IsActive", "Order", "SectionUrl", "Title" },
                values: new object[,]
                {
                    { 7, false, 70, "brendy", "Бренды" },
                    { 6, false, 60, "nabory", "Наборы" },
                    { 5, true, 50, "dom-semya", "Дом&Семья" },
                    { 8, false, 80, "po-komponentam", "По компонентам" },
                    { 3, true, 30, "volosy", "Волосы" },
                    { 2, true, 20, "telo", "Тело" },
                    { 1, true, 10, "lico", "Лицо" },
                    { 4, true, 40, "makiyazh", "Макияж" }
                });

            migrationBuilder.InsertData(
                table: "PromoProducts",
                columns: new[] { "Id", "Content", "Created", "ImageUrl", "IsActive", "Order", "Title", "Url" },
                values: new object[,]
                {
                    { 4, "для глубокого очищения кожи лица", new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local), "/images/new4.png", true, 15, "Глиняная маска", "/promo/akciya-4" },
                    { 1, "Введите код HAIR20 при оформлении заказа", new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local), "/images/new1.png", true, 10, "Новая антивозрастная косметика", "/promo/akciya-1" },
                    { 2, "Волосы становятся шелковистее", new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local), "/images/new2.png", true, 20, "Новинка: сыворотка от бабушки Агафьи", "/promo/akciya-2" },
                    { 3, "с экстрактом ласточкиного гнезда", new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local), "/images/new3.png", true, 30, "Инновационная сыворотка CF-nest 97%", "/promo/akciya-3" },
                    { 5, "Огуречная маска сохранит свежесть", new DateTime(2018, 11, 1, 0, 7, 37, 223, DateTimeKind.Local), "/images/new1.png", true, 25, "Лучшая маска всех времён", "/promo/akciya-5" }
                });

            migrationBuilder.InsertData(
                table: "Promos",
                columns: new[] { "Id", "Content", "Created", "ImageUrl", "IsActive", "Order", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "Набор из 3-х этапного ухода за кожей лица с увлажняющим эффектом", new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local), "/images/discount-1.jpg", true, 10, "3-х шаговая маска", "/promo/akciya-1" },
                    { 2, "широкий выбор патчей", new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local), "/images/discount-2.jpg", true, 20, "Гидрогелевые патчи", "/promo/akciya-2" },
                    { 3, "с экстрактом ласточкиного гнезда", new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local), "/images/discount-3.jpg", true, 30, "Сыворотка CF-nest 97%", "/promo/akciya-3" },
                    { 4, "для глубокого очищения кожи лица", new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local), "/images/discount-1.jpg", true, 15, "Глиняная маска", "/promo/akciya-4" },
                    { 5, "с экстрактом масла ши", new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local), "/images/discount-2.jpg", true, 25, "Маска теневая", "/promo/akciya-5" },
                    { 6, "для лица Aqua Hyalorunic Acid Water", new DateTime(2018, 11, 1, 0, 7, 37, 221, DateTimeKind.Local), "/images/discount-3.jpg", true, 35, "Крем гиалуроновый", "/promo/akciya-6" }
                });

            migrationBuilder.InsertData(
                table: "ProductSubbcategories",
                columns: new[] { "Id", "IsActive", "Order", "ProductCategoryId", "SectionUrl", "Title" },
                values: new object[,]
                {
                    { 1, true, 10, 1, "ochischenie-lica", "Очищение" },
                    { 27, true, 100, 5, "kondicionery-dly-belya", "Кондиционеры для белья" },
                    { 26, true, 90, 5, "stiralnye-poroshki", "Стиральные порошки" },
                    { 25, true, 80, 5, "dezodoranty", "Дезодоранты" },
                    { 24, true, 70, 5, "britvennye-stanki", "Бритвенные станки" },
                    { 23, true, 60, 5, "britvy", "Бритвы" },
                    { 22, true, 50, 5, "mochalki", "Мочалки" },
                    { 21, true, 40, 5, "morskaya-solj", "Морская соль" },
                    { 20, true, 30, 5, "peny-dlya-vann", "Пены для ванн" },
                    { 19, true, 30, 5, "zubnye-shchetki", "Зубные щетки" },
                    { 18, true, 30, 5, "zubnye-pasty", "Зубные пасты" },
                    { 17, true, 80, 4, "makiyazh-dlya-gub", "Макияж для губ" },
                    { 16, true, 70, 4, "tush-kontur-i-podvodka-dlya-glaz", "Тушь, контур и подводка для глаз" },
                    { 28, true, 110, 5, "pyatnovyvoditeli-i-otbelivateli", "Пятновыводители и отбеливатели" },
                    { 15, true, 60, 4, "sredstva-dlya-brovej", "Средства для бровей" },
                    { 13, true, 40, 4, "pudra-i-hajlajtery", "Пудра и хайлайтеры" },
                    { 12, true, 30, 4, "konsilery", "Консилеры" },
                    { 11, true, 20, 4, "tonalnyj-krem", "Тональный крем" },
                    { 10, true, 10, 4, "osnova-pod-makiyazh", "Основа под макияж" },
                    { 9, true, 30, 3, "aksessuary-dlya-volos", "Аксессуары для волос" },
                    { 8, true, 20, 3, "stajling", "Стайлинг" },
                    { 7, true, 10, 3, "uhod-za-volosami", "Уход за волосами" },
                    { 6, true, 20, 2, "osobyj-uhod-telo", "Особый уход" },
                    { 5, true, 10, 2, "osnovnoj-uhod-telo", "Основной уход" },
                    { 4, true, 40, 1, "osobyj-uhod-lica", "Особый уход" },
                    { 3, true, 30, 1, "maski", "Маски" },
                    { 2, true, 20, 1, "osnovnoj-uhod-lica", "Основной уход" },
                    { 14, true, 50, 4, "teni-i-rumyana", "Тени и румяна" },
                    { 29, true, 120, 5, "chistyashchie-sredstva-dly-vannoj-i-kuhni", "Чистящие средства для ванной и кухни" }
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "IsActive", "Order", "ProductCategoryId", "ProductSubcategoryId", "SectionUrl", "Title" },
                values: new object[,]
                {
                    { 1, true, 10, 1, 1, "molochko-dlya-snyatiya-makiyazha", "Молочко для снятия макияжа" },
                    { 9, true, 40, 1, 2, "flyuidy-i-geli", "Флюиды и гели" },
                    { 10, true, 50, 1, 2, "ehmulsii-i-ehssencii", "Эмульсии и эссенции" },
                    { 11, true, 60, 1, 2, "BB-i-CC-kremy", "BB и CC кремы" },
                    { 27, true, 10, 2, 2, "krem-dlya-ruk", "Крем для рук" },
                    { 28, true, 20, 2, 2, "krem-dlya-nog", "Крем для ног" },
                    { 29, true, 30, 2, 2, "solncezashchitnye-sredstva", "Солнцезащитные средства" },
                    { 37, true, 10, 3, 2, "vosk", "Воск" },
                    { 8, true, 30, 1, 2, "syvorotki", "Сыворотки" },
                    { 38, true, 20, 3, 2, "gel", "Гель" },
                    { 40, true, 40, 3, 2, "lak-sprej", "Лак – спрей" },
                    { 12, true, 10, 1, 3, "tkanevye-maski", "Тканевые маски" },
                    { 13, true, 20, 1, 3, "gidrogelevye-maski", "Гидрогелевые маски" },
                    { 14, true, 30, 1, 3, "alginatnye-maski", "Альгинатные маски" },
                    { 15, true, 40, 1, 3, "inye-maski", "Иные маски" },
                    { 16, true, 50, 1, 3, "patchi", "Патчи" },
                    { 17, true, 10, 1, 4, "krem-dlya-kozhi-vokrug-glaz", "Крем для кожи вокруг глаз" },
                    { 39, true, 30, 3, 2, "muss", "Мусс" },
                    { 7, true, 20, 1, 2, "sprei", "Спреи" },
                    { 6, true, 10, 1, 2, "kremy", "Кремы" },
                    { 36, true, 70, 3, 1, "maski-dlya-volos", "Маски для волос" },
                    { 2, true, 20, 1, 1, "penki-geli-voda-dlya-umyvaniya", "Пенки, гели и вода для умывания" },
                    { 3, true, 30, 1, 1, "gidrofilnye-masla", "Гидрофильные масла" },
                    { 4, true, 40, 1, 1, "losiony-i-toniki", "Лосьоны и тоники" },
                    { 5, true, 50, 1, 1, "skraby-i-pilingi", "Скрабы и пилинги" },
                    { 20, true, 10, 2, 1, "mylo", "Мыло" },
                    { 21, true, 20, 2, 1, "gel-dlya-dusha", "Гель для душа" },
                    { 22, true, 30, 2, 1, "skraby-i-pilingi-dlya-tela", "Скрабы и пилинги для тела" },
                    { 23, true, 40, 2, 1, "kremy-geli-i-molochko", "Кремы, гели и молочко" },
                    { 24, true, 50, 2, 1, "losiony-i-masla", "Лосьоны и масла" },
                    { 25, true, 60, 2, 1, "sprei-dlya-tela", "Спреи для тела" },
                    { 26, true, 70, 2, 1, "dezodoranty", "Дезодоранты" },
                    { 30, true, 10, 3, 1, "shampuni", "Шампуни" },
                    { 31, true, 20, 3, 1, "balzamy", "Бальзамы" },
                    { 32, true, 30, 3, 1, "kondicionery", "Кондиционеры" },
                    { 33, true, 40, 3, 1, "sprei-i-misty", "Спреи и мисты" },
                    { 34, true, 50, 3, 1, "ehssencii-i-syvorotki", "Эссенции и сыворотки" },
                    { 35, true, 60, 3, 1, "masla", "Масла" },
                    { 18, true, 20, 1, 4, "balzam-dlya-gub", "Бальзам для губ" },
                    { 19, true, 30, 1, 4, "solncezashchitnye-sredstva", "Солнцезащитные средства" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Created", "Discount", "ImageUrl", "ImageUrls", "IsActive", "Manufacturer", "Price", "ProductCategoryId", "ProductGroupId", "ProductSubcategoryId", "ProductType", "Title", "TitleUrl" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local), 78.0m, "/images/cream2.png", "/files/products/product-1/1.jpg;/files/products/product-1/2.jpg;/files/products/product-1/3.jpg;/files/products/product-1/4.jpg;", true, "ESTHETIC HOUSE", 22.00m, 1, 1, 1, 2, "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл", "1-esthetic-house-name-product" },
                    { 4, new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local), 35.0m, "/images/cream3.png", "/files/products/product-4/1.jpg;/files/products/product-4/2.jpg;/files/products/product-4/3.jpg;/files/products/product-4/4.jpg;", true, "KOELF", 245.00m, 2, 1, 1, 3, "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр", "4-koelf-name-product" },
                    { 5, new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local), 38.0m, "/images/cream4.png", "/files/products/product-5/1.jpg;/files/products/product-5/2.jpg;/files/products/product-5/3.jpg;/files/products/product-5/4.jpg;", true, "THE SAEM", 92.00m, 2, 1, 2, 2, "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл", "5-the-saem-name-product" },
                    { 8, new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local), 0m, "/images/cream1.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", true, "A'PIEU", 730m, 1, 1, 1, 0, "A'PIEU Спрей для волос защитный Super Protein Hair Guard Mist, 105мл", "8-apieu-name-product" },
                    { 9, new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local), 0m, "/images/cream3.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", true, "ELIZAVECCA", 1220m, 1, 1, 1, 0, "ELIZAVECCA Маска для лица глиняно-пузырьковая Carbonated Bubble Clay Mask, 100гр", "9-elizavecca-name-product" },
                    { 10, new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local), 22m, "/images/cream2.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", true, "ESTHETIC HOUSE", 330m, 1, 1, 1, 1, "ESTHETIC HOUSE Протеиновый кондиционер д/волос CP-1 BС Intense Nourishing Conditioner, 100 мл", "10-esthetic-house-name-product" },
                    { 11, new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local), 0m, "/images/cream5.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", true, "FARMSTAY", 58m, 1, 1, 1, 0, "FARMSTAY Тканевая маска с натуральным экстрактом граната Visible Difference Pomegranate Mask, 23мл", "11-farmstay-name-product" },
                    { 2, new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local), 50.0m, "/images/cream2.png", "/files/products/product-2/1.jpg;/files/products/product-2/2.jpg;/files/products/product-2/3.jpg;/files/products/product-2/4.jpg;", true, "ELIZAVECCA", 660.00m, 1, 2, 1, 0, "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл", "2-elizavecca-name-product" },
                    { 6, new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local), 0m, "/images/cream5.png", "/files/products/product-6/1.jpg;/files/products/product-6/2.jpg;/files/products/product-6/3.jpg;/files/products/product-6/4.jpg;", true, "Innisfree", 120.00m, 2, 2, 1, 3, "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato", "6-innisfree-name-product" },
                    { 7, new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local), 0m, "/images/cream3.png", "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", true, "ESTHETIC HOUSE", 1365.00m, 2, 2, 1, 0, "ESTHETIC HOUSE Патчи гидрогелевые Красное вино Red Wine Hydrogel Eyepatch, 60шт.", "7-esthetic-house-name-product" },
                    { 3, new DateTime(2018, 11, 1, 0, 7, 37, 218, DateTimeKind.Local), 44.0m, "/images/cream2.png", "/files/products/product-3/1.jpg;/files/products/product-3/2.jpg;/files/products/product-3/3.jpg;/files/products/product-3/4.jpg;", true, "ESTHETIC HOUSE", 895.00m, 1, 3, 1, 1, "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл", "3-esthetic-house-name-product" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banners_Id",
                table: "Banners",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_Id",
                table: "ProductCategories",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_Id",
                table: "ProductGroups",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ProductCategoryId",
                table: "ProductGroups",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGroups_ProductSubcategoryId",
                table: "ProductGroups",
                column: "ProductSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id",
                table: "Products",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductGroupId",
                table: "Products",
                column: "ProductGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSubcategoryId",
                table: "Products",
                column: "ProductSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubbcategories_Id",
                table: "ProductSubbcategories",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubbcategories_ProductCategoryId",
                table: "ProductSubbcategories",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PromoProducts_Id",
                table: "PromoProducts",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Promos_Id",
                table: "Promos",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PromoProducts");

            migrationBuilder.DropTable(
                name: "Promos");

            migrationBuilder.DropTable(
                name: "ProductGroups");

            migrationBuilder.DropTable(
                name: "ProductSubbcategories");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
