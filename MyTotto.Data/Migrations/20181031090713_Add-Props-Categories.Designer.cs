﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyTotto.Data;

namespace MyTotto.Data.Migrations
{
    [DbContext(typeof(TottoContext))]
    [Migration("20181031090713_Add-Props-Categories")]
    partial class AddPropsCategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyTotto.Data.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActionDate");

                    b.Property<string>("BackgroundColor");

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 10, 31, 16, 7, 12, 628, DateTimeKind.Local));

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Banners");

                    b.HasData(
                        new { Id = 1, BackgroundColor = "faffe4", Content = "При заказе на сумму от 300 рублей предоставляем бесплатную доставку в любой район Новосибирска", Created = new DateTime(2018, 10, 31, 16, 7, 12, 630, DateTimeKind.Local), ImageUrl = "/files/banners/banner-1.jpg", IsActive = true, Order = 10, Title = "Бесплатная доставка" },
                        new { Id = 2, BackgroundColor = "ffffff", Content = "чтобы узнавать самым первым все последние новости и акции!", Created = new DateTime(2018, 10, 31, 16, 7, 12, 630, DateTimeKind.Local), ImageUrl = "/files/banners/banner-2.jpg", IsActive = true, Order = 20, Title = "Подпишись на новости" },
                        new { Id = 3, BackgroundColor = "84cad0", Content = "Чтобы получить скидку на первый заказ необходимо зарегистрироваться и заполнить анкету первооткрывателя сайта", Created = new DateTime(2018, 10, 31, 16, 7, 12, 630, DateTimeKind.Local), ImageUrl = "/files/banners/banner-3.jpg", IsActive = true, Order = 15, Title = "Скидка на первый заказ" }
                    );
                });

            modelBuilder.Entity("MyTotto.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 10, 31, 16, 7, 12, 636, DateTimeKind.Local));

                    b.Property<decimal>("Discount");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("ImageUrls");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Manufacturer");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductCategoryId");

                    b.Property<int?>("ProductGroupId");

                    b.Property<int>("ProductSubcategoryId");

                    b.Property<int>("ProductType");

                    b.Property<string>("Title");

                    b.Property<string>("TitleUrl");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductGroupId");

                    b.HasIndex("ProductSubcategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, Created = new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), Discount = 78.0m, ImageUrl = "/images/cream2.png", ImageUrls = "/files/products/product-1/1.jpg;/files/products/product-1/2.jpg;/files/products/product-1/3.jpg;/files/products/product-1/4.jpg;", IsActive = true, Manufacturer = "ESTHETIC HOUSE", Price = 22.00m, ProductCategoryId = 1, ProductGroupId = 1, ProductSubcategoryId = 1, ProductType = 2, Title = "ESTHETIC HOUSE Несмываемая кератиновая сыворотка для волос СР-1 Keratin Silk Injection, 5мл" },
                        new { Id = 2, Created = new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), Discount = 50.0m, ImageUrl = "/images/cream2.png", ImageUrls = "/files/products/product-2/1.jpg;/files/products/product-2/2.jpg;/files/products/product-2/3.jpg;/files/products/product-2/4.jpg;", IsActive = true, Manufacturer = "ELIZAVECCA", Price = 660.00m, ProductCategoryId = 1, ProductGroupId = 2, ProductSubcategoryId = 1, ProductType = 0, Title = "ELIZAVECCA Крем для лица увлажняющий гиалуроновый Aqua Hyaluronic Acid Water Drop Cream, 50 мл" },
                        new { Id = 3, Created = new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), Discount = 44.0m, ImageUrl = "/images/cream2.png", ImageUrls = "/files/products/product-3/1.jpg;/files/products/product-3/2.jpg;/files/products/product-3/3.jpg;/files/products/product-3/4.jpg;", IsActive = true, Manufacturer = "ESTHETIC HOUSE", Price = 895.00m, ProductCategoryId = 1, ProductGroupId = 3, ProductSubcategoryId = 1, ProductType = 1, Title = "ESTHETIC HOUSE Кондиц.ополас. на основе малинового уксуса CP-1 Rasberry Treatment Vinegar, 500 мл" },
                        new { Id = 4, Created = new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), Discount = 35.0m, ImageUrl = "/images/cream3.png", ImageUrls = "/files/products/product-4/1.jpg;/files/products/product-4/2.jpg;/files/products/product-4/3.jpg;/files/products/product-4/4.jpg;", IsActive = true, Manufacturer = "KOELF", Price = 245.00m, ProductCategoryId = 2, ProductGroupId = 1, ProductSubcategoryId = 1, ProductType = 3, Title = "KOELF Гидрогелевая маска для лица с жемчугом и маслом Ши Pearl & Shea Butter, 30гр" },
                        new { Id = 5, Created = new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), Discount = 38.0m, ImageUrl = "/images/cream4.png", ImageUrls = "/files/products/product-5/1.jpg;/files/products/product-5/2.jpg;/files/products/product-5/3.jpg;/files/products/product-5/4.jpg;", IsActive = true, Manufacturer = "THE SAEM", Price = 92.00m, ProductCategoryId = 2, ProductGroupId = 1, ProductSubcategoryId = 2, ProductType = 2, Title = "THE SAEM Маска тканевая с экстрактом масла ши Natural Shea Butter Mask Sheet, 21мл" },
                        new { Id = 6, Created = new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), Discount = 0m, ImageUrl = "/images/cream5.png", ImageUrls = "/files/products/product-6/1.jpg;/files/products/product-6/2.jpg;/files/products/product-6/3.jpg;/files/products/product-6/4.jpg;", IsActive = true, Manufacturer = "Innisfree", Price = 120.00m, ProductCategoryId = 2, ProductGroupId = 2, ProductSubcategoryId = 1, ProductType = 3, Title = "Innisfree Листовая маска для лица с экстрактом томата My Real Squeeze Mask Tomato" },
                        new { Id = 7, Created = new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), Discount = 0m, ImageUrl = "/images/cream3.png", ImageUrls = "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", IsActive = true, Manufacturer = "ESTHETIC HOUSE", Price = 1365.00m, ProductCategoryId = 2, ProductGroupId = 2, ProductSubcategoryId = 1, ProductType = 0, Title = "ESTHETIC HOUSE Патчи гидрогелевые Красное вино Red Wine Hydrogel Eyepatch, 60шт." },
                        new { Id = 8, Created = new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), Discount = 0m, ImageUrl = "/images/cream1.png", ImageUrls = "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", IsActive = true, Manufacturer = "A'PIEU", Price = 730m, ProductCategoryId = 1, ProductGroupId = 1, ProductSubcategoryId = 1, ProductType = 0, Title = "A'PIEU Спрей для волос защитный Super Protein Hair Guard Mist, 105мл" },
                        new { Id = 9, Created = new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), Discount = 0m, ImageUrl = "/images/cream3.png", ImageUrls = "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", IsActive = true, Manufacturer = "ELIZAVECCA", Price = 1220m, ProductCategoryId = 1, ProductGroupId = 1, ProductSubcategoryId = 1, ProductType = 0, Title = "ELIZAVECCA Маска для лица глиняно-пузырьковая Carbonated Bubble Clay Mask, 100гр" },
                        new { Id = 10, Created = new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), Discount = 22m, ImageUrl = "/images/cream2.png", ImageUrls = "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", IsActive = true, Manufacturer = "ESTHETIC HOUSE", Price = 330m, ProductCategoryId = 1, ProductGroupId = 1, ProductSubcategoryId = 1, ProductType = 1, Title = "ESTHETIC HOUSE Протеиновый кондиционер д/волос CP-1 BС Intense Nourishing Conditioner, 100 мл" },
                        new { Id = 11, Created = new DateTime(2018, 10, 31, 16, 7, 12, 637, DateTimeKind.Local), Discount = 0m, ImageUrl = "/images/cream5.png", ImageUrls = "/files/products/product-6/1.jpg;/files/products/product-6/4.jpg;", IsActive = true, Manufacturer = "FARMSTAY", Price = 58m, ProductCategoryId = 1, ProductGroupId = 1, ProductSubcategoryId = 1, ProductType = 0, Title = "FARMSTAY Тканевая маска с натуральным экстрактом граната Visible Difference Pomegranate Mask, 23мл" }
                    );
                });

            modelBuilder.Entity("MyTotto.Data.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<string>("SectionUrl");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new { Id = 1, IsActive = true, Order = 10, SectionUrl = "lico", Title = "Лицо" },
                        new { Id = 2, IsActive = true, Order = 20, SectionUrl = "telo", Title = "Тело" },
                        new { Id = 3, IsActive = true, Order = 30, SectionUrl = "volosy", Title = "Волосы" },
                        new { Id = 4, IsActive = true, Order = 40, SectionUrl = "makiyazh", Title = "Макияж" },
                        new { Id = 5, IsActive = true, Order = 50, SectionUrl = "dom-semya", Title = "Дом&Семья" },
                        new { Id = 6, IsActive = false, Order = 60, SectionUrl = "nabory", Title = "Наборы" },
                        new { Id = 7, IsActive = false, Order = 70, SectionUrl = "brendy", Title = "Бренды" },
                        new { Id = 8, IsActive = false, Order = 80, SectionUrl = "po-komponentam", Title = "По компонентам" }
                    );
                });

            modelBuilder.Entity("MyTotto.Data.Models.ProductGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<int>("ProductCategoryId");

                    b.Property<int?>("ProductCategoryId1");

                    b.Property<int>("ProductSubcategoryId");

                    b.Property<int?>("ProductSubcategoryId1");

                    b.Property<string>("SectionUrl");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductCategoryId1");

                    b.HasIndex("ProductSubcategoryId");

                    b.HasIndex("ProductSubcategoryId1");

                    b.ToTable("ProductGroups");

                    b.HasData(
                        new { Id = 1, IsActive = true, Order = 10, ProductCategoryId = 1, ProductSubcategoryId = 1, SectionUrl = "molochko-dlya-snyatiya-makiyazha", Title = "Молочко для снятия макияжа" },
                        new { Id = 2, IsActive = true, Order = 20, ProductCategoryId = 1, ProductSubcategoryId = 1, SectionUrl = "penki-geli-voda-dlya-umyvaniya", Title = "Пенки, гели и вода для умывания" },
                        new { Id = 3, IsActive = true, Order = 30, ProductCategoryId = 1, ProductSubcategoryId = 1, SectionUrl = "gidrofilnye-masla", Title = "Гидрофильные масла" },
                        new { Id = 4, IsActive = true, Order = 40, ProductCategoryId = 1, ProductSubcategoryId = 1, SectionUrl = "losiony-i-toniki", Title = "Лосьоны и тоники" },
                        new { Id = 5, IsActive = true, Order = 50, ProductCategoryId = 1, ProductSubcategoryId = 1, SectionUrl = "skraby-i-pilingi", Title = "Скрабы и пилинги" },
                        new { Id = 6, IsActive = true, Order = 10, ProductCategoryId = 1, ProductSubcategoryId = 2, SectionUrl = "kremy", Title = "Кремы" },
                        new { Id = 7, IsActive = true, Order = 20, ProductCategoryId = 1, ProductSubcategoryId = 2, SectionUrl = "sprei", Title = "Спреи" },
                        new { Id = 8, IsActive = true, Order = 30, ProductCategoryId = 1, ProductSubcategoryId = 2, SectionUrl = "syvorotki", Title = "Сыворотки" },
                        new { Id = 9, IsActive = true, Order = 40, ProductCategoryId = 1, ProductSubcategoryId = 2, SectionUrl = "flyuidy-i-geli", Title = "Флюиды и гели" },
                        new { Id = 10, IsActive = true, Order = 50, ProductCategoryId = 1, ProductSubcategoryId = 2, SectionUrl = "ehmulsii-i-ehssencii", Title = "Эмульсии и эссенции" },
                        new { Id = 11, IsActive = true, Order = 60, ProductCategoryId = 1, ProductSubcategoryId = 2, SectionUrl = "BB-i-CC-kremy", Title = "BB и CC кремы" },
                        new { Id = 12, IsActive = true, Order = 10, ProductCategoryId = 1, ProductSubcategoryId = 3, SectionUrl = "tkanevye-maski", Title = "Тканевые маски" },
                        new { Id = 13, IsActive = true, Order = 20, ProductCategoryId = 1, ProductSubcategoryId = 3, SectionUrl = "gidrogelevye-maski", Title = "Гидрогелевые маски" },
                        new { Id = 14, IsActive = true, Order = 30, ProductCategoryId = 1, ProductSubcategoryId = 3, SectionUrl = "alginatnye-maski", Title = "Альгинатные маски" },
                        new { Id = 15, IsActive = true, Order = 40, ProductCategoryId = 1, ProductSubcategoryId = 3, SectionUrl = "inye-maski", Title = "Иные маски" },
                        new { Id = 16, IsActive = true, Order = 50, ProductCategoryId = 1, ProductSubcategoryId = 3, SectionUrl = "patchi", Title = "Патчи" },
                        new { Id = 17, IsActive = true, Order = 10, ProductCategoryId = 1, ProductSubcategoryId = 4, SectionUrl = "krem-dlya-kozhi-vokrug-glaz", Title = "Крем для кожи вокруг глаз" },
                        new { Id = 18, IsActive = true, Order = 20, ProductCategoryId = 1, ProductSubcategoryId = 4, SectionUrl = "balzam-dlya-gub", Title = "Бальзам для губ" },
                        new { Id = 19, IsActive = true, Order = 30, ProductCategoryId = 1, ProductSubcategoryId = 4, SectionUrl = "solncezashchitnye-sredstva", Title = "Солнцезащитные средства" },
                        new { Id = 20, IsActive = true, Order = 10, ProductCategoryId = 2, ProductSubcategoryId = 1, SectionUrl = "mylo", Title = "Мыло" },
                        new { Id = 21, IsActive = true, Order = 20, ProductCategoryId = 2, ProductSubcategoryId = 1, SectionUrl = "gel-dlya-dusha", Title = "Гель для душа" },
                        new { Id = 22, IsActive = true, Order = 30, ProductCategoryId = 2, ProductSubcategoryId = 1, SectionUrl = "skraby-i-pilingi-dlya-tela", Title = "Скрабы и пилинги для тела" },
                        new { Id = 23, IsActive = true, Order = 40, ProductCategoryId = 2, ProductSubcategoryId = 1, SectionUrl = "kremy-geli-i-molochko", Title = "Кремы, гели и молочко" },
                        new { Id = 24, IsActive = true, Order = 50, ProductCategoryId = 2, ProductSubcategoryId = 1, SectionUrl = "losiony-i-masla", Title = "Лосьоны и масла" },
                        new { Id = 25, IsActive = true, Order = 60, ProductCategoryId = 2, ProductSubcategoryId = 1, SectionUrl = "sprei-dlya-tela", Title = "Спреи для тела" },
                        new { Id = 26, IsActive = true, Order = 70, ProductCategoryId = 2, ProductSubcategoryId = 1, SectionUrl = "dezodoranty", Title = "Дезодоранты" },
                        new { Id = 27, IsActive = true, Order = 10, ProductCategoryId = 2, ProductSubcategoryId = 2, SectionUrl = "krem-dlya-ruk", Title = "Крем для рук" },
                        new { Id = 28, IsActive = true, Order = 20, ProductCategoryId = 2, ProductSubcategoryId = 2, SectionUrl = "krem-dlya-nog", Title = "Крем для ног" },
                        new { Id = 29, IsActive = true, Order = 30, ProductCategoryId = 2, ProductSubcategoryId = 2, SectionUrl = "solncezashchitnye-sredstva", Title = "Солнцезащитные средства" },
                        new { Id = 30, IsActive = true, Order = 10, ProductCategoryId = 3, ProductSubcategoryId = 1, SectionUrl = "shampuni", Title = "Шампуни" },
                        new { Id = 31, IsActive = true, Order = 20, ProductCategoryId = 3, ProductSubcategoryId = 1, SectionUrl = "balzamy", Title = "Бальзамы" },
                        new { Id = 32, IsActive = true, Order = 30, ProductCategoryId = 3, ProductSubcategoryId = 1, SectionUrl = "kondicionery", Title = "Кондиционеры" },
                        new { Id = 33, IsActive = true, Order = 40, ProductCategoryId = 3, ProductSubcategoryId = 1, SectionUrl = "sprei-i-misty", Title = "Спреи и мисты" },
                        new { Id = 34, IsActive = true, Order = 50, ProductCategoryId = 3, ProductSubcategoryId = 1, SectionUrl = "ehssencii-i-syvorotki", Title = "Эссенции и сыворотки" },
                        new { Id = 35, IsActive = true, Order = 60, ProductCategoryId = 3, ProductSubcategoryId = 1, SectionUrl = "masla", Title = "Масла" },
                        new { Id = 36, IsActive = true, Order = 70, ProductCategoryId = 3, ProductSubcategoryId = 1, SectionUrl = "maski-dlya-volos", Title = "Маски для волос" },
                        new { Id = 37, IsActive = true, Order = 10, ProductCategoryId = 3, ProductSubcategoryId = 2, SectionUrl = "vosk", Title = "Воск" },
                        new { Id = 38, IsActive = true, Order = 20, ProductCategoryId = 3, ProductSubcategoryId = 2, SectionUrl = "gel", Title = "Гель" },
                        new { Id = 39, IsActive = true, Order = 30, ProductCategoryId = 3, ProductSubcategoryId = 2, SectionUrl = "muss", Title = "Мусс" },
                        new { Id = 40, IsActive = true, Order = 40, ProductCategoryId = 3, ProductSubcategoryId = 2, SectionUrl = "lak-sprej", Title = "Лак – спрей" }
                    );
                });

            modelBuilder.Entity("MyTotto.Data.Models.ProductSubcategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<int>("ProductCategoryId");

                    b.Property<string>("SectionUrl");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("ProductSubbcategories");

                    b.HasData(
                        new { Id = 1, IsActive = true, Order = 10, ProductCategoryId = 1, SectionUrl = "ochischenie-lica", Title = "Очищение" },
                        new { Id = 2, IsActive = true, Order = 20, ProductCategoryId = 1, SectionUrl = "osnovnoj-uhod-lica", Title = "Основной уход" },
                        new { Id = 3, IsActive = true, Order = 30, ProductCategoryId = 1, SectionUrl = "maski", Title = "Маски" },
                        new { Id = 4, IsActive = true, Order = 40, ProductCategoryId = 1, SectionUrl = "osobyj-uhod-lica", Title = "Особый уход" },
                        new { Id = 5, IsActive = true, Order = 10, ProductCategoryId = 2, SectionUrl = "osnovnoj-uhod-telo", Title = "Основной уход" },
                        new { Id = 6, IsActive = true, Order = 20, ProductCategoryId = 2, SectionUrl = "osobyj-uhod-telo", Title = "Особый уход" },
                        new { Id = 7, IsActive = true, Order = 10, ProductCategoryId = 3, SectionUrl = "uhod-za-volosami", Title = "Уход за волосами" },
                        new { Id = 8, IsActive = true, Order = 20, ProductCategoryId = 3, SectionUrl = "stajling", Title = "Стайлинг" },
                        new { Id = 9, IsActive = true, Order = 30, ProductCategoryId = 3, SectionUrl = "aksessuary-dlya-volos", Title = "Аксессуары для волос" },
                        new { Id = 10, IsActive = true, Order = 10, ProductCategoryId = 4, SectionUrl = "osnova-pod-makiyazh", Title = "Основа под макияж" },
                        new { Id = 11, IsActive = true, Order = 20, ProductCategoryId = 4, SectionUrl = "tonalnyj-krem", Title = "Тональный крем" },
                        new { Id = 12, IsActive = true, Order = 30, ProductCategoryId = 4, SectionUrl = "konsilery", Title = "Консилеры" },
                        new { Id = 13, IsActive = true, Order = 40, ProductCategoryId = 4, SectionUrl = "pudra-i-hajlajtery", Title = "Пудра и хайлайтеры" },
                        new { Id = 14, IsActive = true, Order = 50, ProductCategoryId = 4, SectionUrl = "teni-i-rumyana", Title = "Тени и румяна" },
                        new { Id = 15, IsActive = true, Order = 60, ProductCategoryId = 4, SectionUrl = "sredstva-dlya-brovej", Title = "Средства для бровей" },
                        new { Id = 16, IsActive = true, Order = 70, ProductCategoryId = 4, SectionUrl = "tush-kontur-i-podvodka-dlya-glaz", Title = "Тушь, контур и подводка для глаз" },
                        new { Id = 17, IsActive = true, Order = 80, ProductCategoryId = 4, SectionUrl = "makiyazh-dlya-gub", Title = "Макияж для губ" },
                        new { Id = 18, IsActive = true, Order = 30, ProductCategoryId = 5, SectionUrl = "zubnye-pasty", Title = "Зубные пасты" },
                        new { Id = 19, IsActive = true, Order = 30, ProductCategoryId = 5, SectionUrl = "zubnye-shchetki", Title = "Зубные щетки" },
                        new { Id = 20, IsActive = true, Order = 30, ProductCategoryId = 5, SectionUrl = "peny-dlya-vann", Title = "Пены для ванн" },
                        new { Id = 21, IsActive = true, Order = 40, ProductCategoryId = 5, SectionUrl = "morskaya-solj", Title = "Морская соль" },
                        new { Id = 22, IsActive = true, Order = 50, ProductCategoryId = 5, SectionUrl = "mochalki", Title = "Мочалки" },
                        new { Id = 23, IsActive = true, Order = 60, ProductCategoryId = 5, SectionUrl = "britvy", Title = "Бритвы" },
                        new { Id = 24, IsActive = true, Order = 70, ProductCategoryId = 5, SectionUrl = "britvennye-stanki", Title = "Бритвенные станки" },
                        new { Id = 25, IsActive = true, Order = 80, ProductCategoryId = 5, SectionUrl = "dezodoranty", Title = "Дезодоранты" },
                        new { Id = 26, IsActive = true, Order = 90, ProductCategoryId = 5, SectionUrl = "stiralnye-poroshki", Title = "Стиральные порошки" },
                        new { Id = 27, IsActive = true, Order = 100, ProductCategoryId = 5, SectionUrl = "kondicionery-dly-belya", Title = "Кондиционеры для белья" },
                        new { Id = 28, IsActive = true, Order = 110, ProductCategoryId = 5, SectionUrl = "pyatnovyvoditeli-i-otbelivateli", Title = "Пятновыводители и отбеливатели" },
                        new { Id = 29, IsActive = true, Order = 120, ProductCategoryId = 5, SectionUrl = "chistyashchie-sredstva-dly-vannoj-i-kuhni", Title = "Чистящие средства для ванной и кухни" }
                    );
                });

            modelBuilder.Entity("MyTotto.Data.Models.Promo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 10, 31, 16, 7, 12, 639, DateTimeKind.Local));

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Promos");

                    b.HasData(
                        new { Id = 1, Content = "Набор из 3-х этапного ухода за кожей лица с увлажняющим эффектом", Created = new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), ImageUrl = "/images/discount-1.jpg", IsActive = true, Order = 10, Title = "3-х шаговая маска", Url = "/promo/akciya-1" },
                        new { Id = 2, Content = "широкий выбор патчей", Created = new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), ImageUrl = "/images/discount-2.jpg", IsActive = true, Order = 20, Title = "Гидрогелевые патчи", Url = "/promo/akciya-2" },
                        new { Id = 3, Content = "с экстрактом ласточкиного гнезда", Created = new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), ImageUrl = "/images/discount-3.jpg", IsActive = true, Order = 30, Title = "Сыворотка CF-nest 97%", Url = "/promo/akciya-3" },
                        new { Id = 4, Content = "для глубокого очищения кожи лица", Created = new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), ImageUrl = "/images/discount-1.jpg", IsActive = true, Order = 15, Title = "Глиняная маска", Url = "/promo/akciya-4" },
                        new { Id = 5, Content = "с экстрактом масла ши", Created = new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), ImageUrl = "/images/discount-2.jpg", IsActive = true, Order = 25, Title = "Маска теневая", Url = "/promo/akciya-5" },
                        new { Id = 6, Content = "для лица Aqua Hyalorunic Acid Water", Created = new DateTime(2018, 10, 31, 16, 7, 12, 640, DateTimeKind.Local), ImageUrl = "/images/discount-3.jpg", IsActive = true, Order = 35, Title = "Крем гиалуроновый", Url = "/promo/akciya-6" }
                    );
                });

            modelBuilder.Entity("MyTotto.Data.Models.PromoProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local));

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<int>("Order");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("PromoProducts");

                    b.HasData(
                        new { Id = 1, Content = "Введите код HAIR20 при оформлении заказа", Created = new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local), ImageUrl = "/images/new1.png", IsActive = true, Order = 10, Title = "Новая антивозрастная косметика", Url = "/promo/akciya-1" },
                        new { Id = 2, Content = "Волосы становятся шелковистее", Created = new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local), ImageUrl = "/images/new2.png", IsActive = true, Order = 20, Title = "Новинка: сыворотка от бабушки Агафьи", Url = "/promo/akciya-2" },
                        new { Id = 3, Content = "с экстрактом ласточкиного гнезда", Created = new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local), ImageUrl = "/images/new3.png", IsActive = true, Order = 30, Title = "Инновационная сыворотка CF-nest 97%", Url = "/promo/akciya-3" },
                        new { Id = 4, Content = "для глубокого очищения кожи лица", Created = new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local), ImageUrl = "/images/new4.png", IsActive = true, Order = 15, Title = "Глиняная маска", Url = "/promo/akciya-4" },
                        new { Id = 5, Content = "Огуречная маска сохранит свежесть", Created = new DateTime(2018, 10, 31, 16, 7, 12, 642, DateTimeKind.Local), ImageUrl = "/images/new1.png", IsActive = true, Order = 25, Title = "Лучшая маска всех времён", Url = "/promo/akciya-5" }
                    );
                });

            modelBuilder.Entity("MyTotto.Data.Models.Product", b =>
                {
                    b.HasOne("MyTotto.Data.Models.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MyTotto.Data.Models.ProductGroup", "ProductGroup")
                        .WithMany()
                        .HasForeignKey("ProductGroupId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("MyTotto.Data.Models.ProductSubcategory", "ProductSubcategory")
                        .WithMany()
                        .HasForeignKey("ProductSubcategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyTotto.Data.Models.ProductGroup", b =>
                {
                    b.HasOne("MyTotto.Data.Models.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MyTotto.Data.Models.ProductCategory")
                        .WithMany("Groups")
                        .HasForeignKey("ProductCategoryId1");

                    b.HasOne("MyTotto.Data.Models.ProductSubcategory", "ProductSubcategory")
                        .WithMany()
                        .HasForeignKey("ProductSubcategoryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MyTotto.Data.Models.ProductSubcategory")
                        .WithMany("Groups")
                        .HasForeignKey("ProductSubcategoryId1");
                });

            modelBuilder.Entity("MyTotto.Data.Models.ProductSubcategory", b =>
                {
                    b.HasOne("MyTotto.Data.Models.ProductCategory", "ProductCategory")
                        .WithMany("Subcategories")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
