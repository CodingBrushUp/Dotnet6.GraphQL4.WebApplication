﻿using System;
using Dotnet5.GraphQL.WebApplication.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Dotnet5.GraphQL.WebApplication.Repositories.Migrations
{
    [DbContext(typeof(StoreContext))]
    internal class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
               .UseIdentityColumns()
               .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CS_AS")
               .HasAnnotation("Relational:MaxIdentifierLength", 128)
               .HasAnnotation("ProductVersion", "5.0.0-rc.1.20372.13");

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.Entities.Products.Product", b =>
            {
                b.Property<Guid>("Id")
                   .ValueGeneratedOnAdd()
                   .HasColumnType("uniqueidentifier");

                b.Property<string>("Description")
                   .HasMaxLength(100)
                   .HasColumnType("nvarchar(100)");

                b.Property<string>("Discriminator")
                   .IsRequired()
                   .HasColumnType("nvarchar(max)");

                b.Property<DateTimeOffset>("IntroduceAt")
                   .HasColumnType("datetimeoffset");

                b.Property<string>("Name")
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType("nvarchar(50)");

                b.Property<string>("Option")
                   .IsRequired()
                   .HasColumnType("nvarchar(max)");

                b.Property<string>("PhotoFileName")
                   .HasMaxLength(100)
                   .HasColumnType("nvarchar(100)");

                b.Property<decimal>("Price")
                   .HasPrecision(18, 2)
                   .HasColumnType("decimal(18,2)");

                b.Property<Guid?>("ProductTypeId")
                   .HasColumnType("uniqueidentifier");

                b.Property<int>("Rating")
                   .HasColumnType("int");

                b.Property<int>("Stock")
                   .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("ProductTypeId");

                b.ToTable("Products");

                b.HasDiscriminator<string>("Discriminator").HasValue("Product");
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.Entities.Review", b =>
            {
                b.Property<Guid>("Id")
                   .ValueGeneratedOnAdd()
                   .HasColumnType("uniqueidentifier");

                b.Property<string>("Comment")
                   .HasMaxLength(300)
                   .HasColumnType("nvarchar(300)");

                b.Property<Guid?>("ProductId")
                   .HasColumnType("uniqueidentifier");

                b.Property<string>("Title")
                   .HasMaxLength(50)
                   .HasColumnType("nvarchar(50)");

                b.HasKey("Id");

                b.HasIndex("ProductId");

                b.ToTable("Reviews");

                b.HasData(new
                    {
                        Id = new Guid("e7a763f9-fda9-4609-b81d-f58975631e93"),
                        Comment = "Maiores fuga animi.",
                        ProductId = new Guid("9cc428ee-e751-4491-a737-d395ef38f669"),
                        Title = "iste"
                    },
                    new
                    {
                        Id = new Guid("a4abe2e8-6c37-41c3-91d3-c3928bb5daa8"),
                        Comment = "Labore omnis velit doloremque necessitatibus nisi mollitia magni dolores qui.",
                        ProductId = new Guid("10f4a184-61c1-41a8-881a-155575182923"),
                        Title = "omnis"
                    },
                    new
                    {
                        Id = new Guid("5621b03c-8dee-4aa2-a5bc-f2212152f9ee"),
                        Comment = "Rem corporis eligendi at consequatur cupiditate architecto deleniti.",
                        ProductId = new Guid("6a8155e2-a0a5-451f-a8f7-94b55e8af5ec"),
                        Title = "porro"
                    },
                    new
                    {
                        Id = new Guid("17b907ee-3f38-433d-ab51-daaadf2b0eed"),
                        Comment = "Repellat enim voluptatem sint provident.",
                        ProductId = new Guid("9408d841-b036-426e-b9f5-c691ab4afe5d"),
                        Title = "ad"
                    },
                    new
                    {
                        Id = new Guid("5d2e6432-1d94-4a97-92c5-1a585e48d489"),
                        Comment = "Illum qui laboriosam.",
                        ProductId = new Guid("59f77a64-e564-4951-8480-6fc2203bf915"),
                        Title = "incidunt"
                    },
                    new
                    {
                        Id = new Guid("9848d22b-adfe-43a9-9e67-99b13c5ab600"),
                        Comment = "Nobis repellat fuga porro ipsum suscipit aut minus dignissimos.",
                        ProductId = new Guid("e0547840-310d-4d9a-9a06-43020d0e9abd"),
                        Title = "ducimus"
                    },
                    new
                    {
                        Id = new Guid("841bd161-1c22-4120-8b76-5690b2a005ae"),
                        Comment = "Ipsam autem nisi quis quia et aspernatur non.",
                        ProductId = new Guid("3027141d-f3d7-4f45-b48b-a5c071054506"),
                        Title = "architecto"
                    },
                    new
                    {
                        Id = new Guid("13e9910b-a1e5-4caf-9ba3-eec67682d9c0"),
                        Comment = "Eveniet dolor necessitatibus consequatur.",
                        ProductId = new Guid("870ddee1-65ad-4843-b2df-0327d0fa54c6"),
                        Title = "aut"
                    },
                    new
                    {
                        Id = new Guid("76d63d86-7304-4ed6-a310-c36468aee415"),
                        Comment = "Voluptatem aspernatur voluptatem suscipit nihil in dolorum dolorum eligendi.",
                        ProductId = new Guid("34a31f6a-7798-4147-8847-53fc5b9f79d2"),
                        Title = "incidunt"
                    },
                    new
                    {
                        Id = new Guid("487ab561-fd1f-4355-b6c7-3a194cd160bc"),
                        Comment = "Ex id molestias voluptatibus saepe unde harum impedit.",
                        ProductId = new Guid("c267e5b3-eac5-4ccf-ab9f-d389bd9c4b33"),
                        Title = "consequuntur"
                    },
                    new
                    {
                        Id = new Guid("b425919f-0f4b-462b-9b16-b68f03c2eff4"),
                        Comment = "Doloribus dolorem velit exercitationem.",
                        ProductId = new Guid("53b733c2-8bc7-4b8c-9267-2ed367efec53"),
                        Title = "vel"
                    },
                    new
                    {
                        Id = new Guid("b858ed39-79db-43ac-953f-8c46cb97766f"),
                        Comment = "Facilis repellendus numquam id.",
                        ProductId = new Guid("3b3e4b62-fd3d-4a06-b0a8-bc7d343fe0e8"),
                        Title = "impedit"
                    },
                    new
                    {
                        Id = new Guid("0fd126c0-8e01-4431-86fb-8441aa7da14d"),
                        Comment = "Non et quidem consequuntur.",
                        ProductId = new Guid("99fa66f6-41a0-4519-868a-e2fead8cb551"),
                        Title = "aut"
                    },
                    new
                    {
                        Id = new Guid("3d3ccc16-6dae-4c63-b4a9-58d778c4e1ee"),
                        Comment = "Repudiandae ipsum est deserunt reiciendis.",
                        ProductId = new Guid("fd72c248-93a2-44e4-aa3e-106556ce3005"),
                        Title = "delectus"
                    },
                    new
                    {
                        Id = new Guid("f05da3b0-60d8-45c0-9d9e-5c7d981a4f82"),
                        Comment = "Temporibus similique modi consequatur incidunt aliquam ullam nulla.",
                        ProductId = new Guid("5b000c2b-124c-4423-bd19-bd6b8f88852b"),
                        Title = "dolorum"
                    },
                    new
                    {
                        Id = new Guid("3c54f15e-b003-4bf2-a882-72567dd91a90"),
                        Comment = "Enim sed eaque laborum et.",
                        ProductId = new Guid("8b934af2-720f-4cdf-bca2-1ee654d8b46c"),
                        Title = "aut"
                    },
                    new
                    {
                        Id = new Guid("de1a69b6-e4d0-4ec9-8104-1363da18737c"),
                        Comment = "Voluptatum quos rerum nesciunt non vero ut assumenda odio.",
                        ProductId = new Guid("4bc37616-ec86-4a1e-a9af-0e62e98d6849"),
                        Title = "eum"
                    },
                    new
                    {
                        Id = new Guid("979d38e6-3155-4554-b994-89f9d1139359"),
                        Comment = "A laudantium qui pariatur ut omnis voluptatem officia nihil.",
                        ProductId = new Guid("3020569d-2be5-4442-a779-5e97a1740de6"),
                        Title = "dolor"
                    },
                    new
                    {
                        Id = new Guid("994bb424-2a16-40ae-ad57-5dfb828aea6e"),
                        Comment = "Atque voluptate aliquid et voluptatem commodi aut architecto rerum libero.",
                        ProductId = new Guid("8f302d3c-630e-467d-ade6-2c73047fd46d"),
                        Title = "adipisci"
                    },
                    new
                    {
                        Id = new Guid("34dedce7-6acf-42c0-8cca-fd3d2affe83c"),
                        Comment = "Fugit atque voluptatem qui culpa quo officiis ut autem officiis.",
                        ProductId = new Guid("d8cec59b-31a6-416a-8885-f7dbf46630f4"),
                        Title = "quas"
                    },
                    new
                    {
                        Id = new Guid("27ed43e1-a780-45b1-a4d6-9aea29a98cfa"),
                        Comment = "Nesciunt itaque nihil aut atque deserunt expedita unde illo quos.",
                        ProductId = new Guid("5fc8e291-4d46-4c8b-a4a1-d1a77c9416a5"),
                        Title = "aut"
                    },
                    new
                    {
                        Id = new Guid("3b9e010e-01ab-489a-ba46-e98c4b26e6bb"),
                        Comment = "Consequatur corporis sed voluptatibus possimus commodi quod.",
                        ProductId = new Guid("b95929f8-de35-4f5d-ac51-85b680cc0ca6"),
                        Title = "quia"
                    },
                    new
                    {
                        Id = new Guid("fcdbc034-d3a3-4beb-9528-faf3a27d095b"),
                        Comment = "Sunt minima commodi numquam ut odio debitis omnis perspiciatis.",
                        ProductId = new Guid("d3c14755-e161-4325-9509-add643864e95"),
                        Title = "consectetur"
                    },
                    new
                    {
                        Id = new Guid("a5e29ccc-e0bb-4ccb-b051-4fbca42b041e"),
                        Comment = "Ut laudantium placeat eum earum consequuntur officia.",
                        ProductId = new Guid("c5779eed-81fc-4227-b116-71b0319abf68"),
                        Title = "quae"
                    },
                    new
                    {
                        Id = new Guid("527d2c40-b2ec-45c0-940b-2abf1092c271"),
                        Comment = "Est quo fuga.",
                        ProductId = new Guid("9dbacce0-c183-4545-a462-1af55ea88932"),
                        Title = "voluptatum"
                    },
                    new
                    {
                        Id = new Guid("92af0622-c658-4dbe-8afc-b40ce319a96e"),
                        Comment = "Omnis minima quia necessitatibus deleniti et.",
                        ProductId = new Guid("266ea095-da4f-4f11-9486-53a1bdb9fae9"),
                        Title = "magni"
                    },
                    new
                    {
                        Id = new Guid("0a1a9ebb-8e78-4de6-a9df-77f32a4d5d1c"),
                        Comment = "Consequuntur qui expedita inventore libero sint.",
                        ProductId = new Guid("ac299c95-d2d7-49e3-88eb-550d991446f7"),
                        Title = "sequi"
                    },
                    new
                    {
                        Id = new Guid("d3214255-6129-4558-968a-3373c3f6162a"),
                        Comment = "Repellat molestias corporis in harum nisi iste sequi ipsa.",
                        ProductId = new Guid("18a5e72b-49c6-47e7-9f72-1ee0a3205c00"),
                        Title = "harum"
                    },
                    new
                    {
                        Id = new Guid("46329f91-3a82-4aae-adba-eb7e1cea9a30"),
                        Comment = "Eligendi aut fugit minus expedita necessitatibus qui consectetur neque.",
                        ProductId = new Guid("a9966c74-f188-4d55-b33e-a3aca71ca319"),
                        Title = "cumque"
                    },
                    new
                    {
                        Id = new Guid("f26b8ef5-2f0a-4180-8993-bd0690b80029"),
                        Comment = "Et possimus deleniti occaecati suscipit neque qui aut.",
                        ProductId = new Guid("f68b11cc-35ca-4f58-81b5-0a975e47d7f3"),
                        Title = "praesentium"
                    },
                    new
                    {
                        Id = new Guid("56942119-3ee1-44e5-aac4-a7fa513df403"),
                        Comment = "Saepe ut est.",
                        ProductId = new Guid("b5de4d13-daa3-4f75-87eb-69a5e0c33046"),
                        Title = "voluptas"
                    },
                    new
                    {
                        Id = new Guid("104335ff-d7ec-4833-a1dc-b70ef18556ee"),
                        Comment = "Beatae at et quisquam voluptatem.",
                        ProductId = new Guid("4b17c044-a7c2-40a2-be26-db0059711168"),
                        Title = "pariatur"
                    },
                    new
                    {
                        Id = new Guid("5310619d-0224-4b26-9c37-3bc55b2acdd0"),
                        Comment = "Expedita iusto ad perferendis pariatur repellat ipsum earum quia.",
                        ProductId = new Guid("d9350f7b-8abe-4aed-9484-5bb0664b4a2f"),
                        Title = "asperiores"
                    },
                    new
                    {
                        Id = new Guid("bba83b6a-b70d-411d-8bbe-63e9573d95da"),
                        Comment = "Suscipit dignissimos perspiciatis.",
                        ProductId = new Guid("e40682d0-6af8-4f02-ad10-a2aea4eb0777"),
                        Title = "sint"
                    },
                    new
                    {
                        Id = new Guid("cd403763-5ad8-460d-892f-9f61d2084736"),
                        Comment = "Aut qui molestiae.",
                        ProductId = new Guid("ac3f5151-780d-4d4f-8844-439a07f59f48"),
                        Title = "nesciunt"
                    },
                    new
                    {
                        Id = new Guid("de29a31f-ba76-4f6f-9b00-8adab4f6bd94"),
                        Comment = "Cumque quibusdam officiis laudantium.",
                        ProductId = new Guid("68c6b4ea-b9fc-4c7f-bbd7-763831eb3c8e"),
                        Title = "voluptate"
                    },
                    new
                    {
                        Id = new Guid("53773617-bb07-421e-b652-21c23708e86f"),
                        Comment = "Consequatur officiis omnis odio soluta.",
                        ProductId = new Guid("a5a3d20a-63c5-4513-aa25-a750debc8c92"),
                        Title = "vel"
                    },
                    new
                    {
                        Id = new Guid("1b60b384-a81c-44ef-9a11-e8bfb141a00e"),
                        Comment = "Aut ipsa dolore voluptatem.",
                        ProductId = new Guid("3ec8e386-f57c-4aac-a499-167719009a5c"),
                        Title = "enim"
                    },
                    new
                    {
                        Id = new Guid("1686f8e9-85d4-413a-8e92-fccc5947a734"),
                        Comment = "Quo occaecati placeat ut nesciunt ipsam aut omnis.",
                        ProductId = new Guid("b838ed84-5f61-46ad-b9b6-e3bde7102eb8"),
                        Title = "nesciunt"
                    },
                    new
                    {
                        Id = new Guid("146a977a-c0b4-44bc-8ae5-f1b835404c07"),
                        Comment = "Quam voluptas mollitia est cum a quidem in.",
                        ProductId = new Guid("63636706-3b1f-43c5-84f3-f75a006acee7"),
                        Title = "unde"
                    },
                    new
                    {
                        Id = new Guid("9646adbb-c1ab-42d1-a9fd-05dcfda83924"),
                        Comment = "Distinctio ea et error omnis qui.",
                        ProductId = new Guid("08a7c665-f616-41fc-b3a2-09e84cef2496"),
                        Title = "occaecati"
                    },
                    new
                    {
                        Id = new Guid("0ceb5f6c-dc6f-4e9f-83c7-13b3b746b586"),
                        Comment = "Odio officiis et est.",
                        ProductId = new Guid("0bd972fa-a6dc-4555-b300-af551a1cb27f"),
                        Title = "vitae"
                    },
                    new
                    {
                        Id = new Guid("c9756477-6688-4506-86a8-4872052d9499"),
                        Comment = "Dignissimos et hic eveniet porro voluptatem cupiditate natus.",
                        ProductId = new Guid("ee04be6c-e6aa-444e-a138-b44068c34324"),
                        Title = "est"
                    },
                    new
                    {
                        Id = new Guid("235aa6ce-1639-48ff-b291-c77bbbcc6b98"),
                        Comment = "Laboriosam aut dicta quia.",
                        ProductId = new Guid("298a831e-ed75-484b-bc99-2905a0886f52"),
                        Title = "perspiciatis"
                    },
                    new
                    {
                        Id = new Guid("8fe54316-1a59-434d-8835-07ef1297efb3"),
                        Comment = "Voluptate pariatur est et.",
                        ProductId = new Guid("968b61fd-a0b3-4a53-a977-c3ff4b4734dd"),
                        Title = "et"
                    },
                    new
                    {
                        Id = new Guid("9fc136f1-a729-4c55-a545-c3b1fd2052d9"),
                        Comment = "Qui amet ut omnis autem.",
                        ProductId = new Guid("16adb77a-c07a-468b-b974-ee4210fae715"),
                        Title = "expedita"
                    },
                    new
                    {
                        Id = new Guid("003120a8-9db7-4bb0-9dbc-4398430a83e8"),
                        Comment = "Quis debitis qui et eveniet.",
                        ProductId = new Guid("04c1a4ba-7f50-4d42-8ac3-c4175e3254a6"),
                        Title = "dolore"
                    },
                    new
                    {
                        Id = new Guid("13ef1302-8aba-44b6-900b-4393be68e9c2"),
                        Comment = "Consequatur quod nobis.",
                        ProductId = new Guid("13705ca3-66f0-4081-840c-40b84b1e6730"),
                        Title = "in"
                    },
                    new
                    {
                        Id = new Guid("8afee5a1-84be-4a94-9bec-c476cc9cf954"),
                        Comment = "Aut impedit itaque modi dignissimos enim qui nobis exercitationem totam.",
                        ProductId = new Guid("9769497f-5a57-423a-a667-29950e671f5b"),
                        Title = "sit"
                    },
                    new
                    {
                        Id = new Guid("feee492d-ea2e-40ce-9121-30253218ba09"),
                        Comment = "Eius et sunt velit voluptas unde tenetur ex accusamus modi.",
                        ProductId = new Guid("b51af9f9-4bd1-40cc-8f8b-f0c9751e9e16"),
                        Title = "commodi"
                    });
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType", b =>
            {
                b.Property<Guid>("Id")
                   .ValueGeneratedOnAdd()
                   .HasColumnType("uniqueidentifier");

                b.Property<string>("Discriminator")
                   .IsRequired()
                   .HasMaxLength(30)
                   .HasColumnType("nvarchar(30)");

                b.HasKey("Id");

                b.HasIndex("Discriminator")
                   .IsUnique();

                b.ToTable("ProductTypes");

                b.HasDiscriminator<string>("Discriminator").HasValue("ProductType");
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.Entities.Products.Backpack", b =>
            {
                b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.Entities.Products.Product");

                b.Property<string>("BackpackType")
                   .IsRequired()
                   .HasColumnType("nvarchar(max)");

                b.HasDiscriminator().HasValue("Backpack");

                b.HasData(new
                    {
                        Id = new Guid("9cc428ee-e751-4491-a737-d395ef38f669"),
                        Description = "Consequatur nisi velit qui rem et.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 20, 22, 29, 4, 435, DateTimeKind.Unspecified).AddTicks(9452),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "voluptas",
                        Option = "Two",
                        PhotoFileName = "array.mpg4",
                        Price = 0.805731310409395150543069026m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 417829900,
                        Stock = -547463305,
                        BackpackType = "Overnight"
                    },
                    new
                    {
                        Id = new Guid("10f4a184-61c1-41a8-881a-155575182923"),
                        Description = "Facere sed autem odio odit vero similique.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 26, 9, 2, 1, 567, DateTimeKind.Unspecified).AddTicks(4449),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "asperiores",
                        Option = "Three",
                        PhotoFileName = "montana.png",
                        Price = 0.0074774677576684747979257021m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1923363915,
                        Stock = 1349857194,
                        BackpackType = "DayPack"
                    },
                    new
                    {
                        Id = new Guid("6a8155e2-a0a5-451f-a8f7-94b55e8af5ec"),
                        Description = "Molestiae eaque nihil hic.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 18, 10, 59, 46, 180, DateTimeKind.Unspecified).AddTicks(7199),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quasi",
                        Option = "One",
                        PhotoFileName = "auxiliary_handmade_cotton_bacon_black.png",
                        Price = 0.8208352940983218875182232299m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -514543144,
                        Stock = 330686392,
                        BackpackType = "Overnight"
                    },
                    new
                    {
                        Id = new Guid("9408d841-b036-426e-b9f5-c691ab4afe5d"),
                        Description = "Quasi eum fuga suscipit voluptatem ea est commodi.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 7, 3, 42, 17, 556, DateTimeKind.Unspecified).AddTicks(9581),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "culpa",
                        Option = "Two",
                        PhotoFileName = "sleek_concrete_bacon_manager.gif",
                        Price = 0.1509859826473898470970483776m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1552732222,
                        Stock = 1560080460,
                        BackpackType = "Snowsports"
                    },
                    new
                    {
                        Id = new Guid("59f77a64-e564-4951-8480-6fc2203bf915"),
                        Description = "Et earum itaque nemo voluptatem.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 15, 6, 13, 28, 823, DateTimeKind.Unspecified).AddTicks(9158),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "consectetur",
                        Option = "Three",
                        PhotoFileName = "gorgeous_rubber_car.gif",
                        Price = 0.6285268360157395196044437391m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 702256751,
                        Stock = 1485152133,
                        BackpackType = "Snowsports"
                    },
                    new
                    {
                        Id = new Guid("e0547840-310d-4d9a-9a06-43020d0e9abd"),
                        Description = "Impedit unde dolor deleniti placeat.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 20, 10, 56, 2, 844, DateTimeKind.Unspecified).AddTicks(8934),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "qui",
                        Option = "One",
                        PhotoFileName = "monitor_arizona_adp.mpga",
                        Price = 0.8800331927670095952309140666m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -782454276,
                        Stock = -1913924633,
                        BackpackType = "Hiking"
                    },
                    new
                    {
                        Id = new Guid("3027141d-f3d7-4f45-b48b-a5c071054506"),
                        Description = "Vel aut qui quo ex.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 2, 13, 18, 0, 43, DateTimeKind.Unspecified).AddTicks(7810),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "et",
                        Option = "Three",
                        PhotoFileName = "payment_sleek_frozen_fish_myanmar.shtml",
                        Price = 0.6113059149242560620403604429m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 218070626,
                        Stock = -1980959732,
                        BackpackType = "Cycling"
                    },
                    new
                    {
                        Id = new Guid("870ddee1-65ad-4843-b2df-0327d0fa54c6"),
                        Description = "Occaecati et et odio illo aut molestiae ea magni quod.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 27, 22, 21, 49, 238, DateTimeKind.Unspecified).AddTicks(6067),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "nam",
                        Option = "Three",
                        PhotoFileName = "capacitor.html",
                        Price = 0.5867061265606466947919191587m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -939907543,
                        Stock = 747120937,
                        BackpackType = "DayPack"
                    },
                    new
                    {
                        Id = new Guid("34a31f6a-7798-4147-8847-53fc5b9f79d2"),
                        Description = "Autem voluptate doloremque est est quia non qui aut et.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 15, 9, 33, 35, 767, DateTimeKind.Unspecified).AddTicks(5180),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "nobis",
                        Option = "One",
                        PhotoFileName = "transmitting.jpg",
                        Price = 0.3843342982327879819717501206m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 2059096711,
                        Stock = -805081845,
                        BackpackType = "Snowsports"
                    },
                    new
                    {
                        Id = new Guid("c267e5b3-eac5-4ccf-ab9f-d389bd9c4b33"),
                        Description = "Aliquid possimus officiis porro accusamus est est quia debitis.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 20, 23, 52, 7, 585, DateTimeKind.Unspecified).AddTicks(1269),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "labore",
                        Option = "Two",
                        PhotoFileName = "investment_account.gif",
                        Price = 0.1192081426040254361533236298m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -1053005277,
                        Stock = -382205705,
                        BackpackType = "Overnight"
                    },
                    new
                    {
                        Id = new Guid("53b733c2-8bc7-4b8c-9267-2ed367efec53"),
                        Description = "Deserunt ut odit quam suscipit qui atque tempore.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 19, 15, 10, 51, 691, DateTimeKind.Unspecified).AddTicks(2557),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "qui",
                        Option = "Three",
                        PhotoFileName = "executive.mp4v",
                        Price = 0.6117584317567815709768591124m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 504792879,
                        Stock = -969293737,
                        BackpackType = "Snowsports"
                    },
                    new
                    {
                        Id = new Guid("3b3e4b62-fd3d-4a06-b0a8-bc7d343fe0e8"),
                        Description = "Inventore saepe ut magni.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 23, 22, 17, 12, 449, DateTimeKind.Unspecified).AddTicks(3589),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "debitis",
                        Option = "One",
                        PhotoFileName = "mission_critical.mpg4",
                        Price = 0.6622302614670385191336992427m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 1758910782,
                        Stock = -1030750781,
                        BackpackType = "Hiking"
                    },
                    new
                    {
                        Id = new Guid("99fa66f6-41a0-4519-868a-e2fead8cb551"),
                        Description = "Ab suscipit et esse.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 28, 11, 31, 43, 613, DateTimeKind.Unspecified).AddTicks(1689),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "magni",
                        Option = "Two",
                        PhotoFileName = "executive_navigating_program.gif",
                        Price = 0.4981093505958939748705256731m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1340579628,
                        Stock = 1836256318,
                        BackpackType = "DayPack"
                    },
                    new
                    {
                        Id = new Guid("fd72c248-93a2-44e4-aa3e-106556ce3005"),
                        Description = "Temporibus doloribus qui quasi doloribus ex doloremque aut quibusdam.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 3, 2, 12, 52, 980, DateTimeKind.Unspecified).AddTicks(6742),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "vero",
                        Option = "One",
                        PhotoFileName = "conglomeration_bhutan_port.mp2",
                        Price = 0.3844516406184173814497040534m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -820897287,
                        Stock = 1367543061,
                        BackpackType = "Hiking"
                    },
                    new
                    {
                        Id = new Guid("5b000c2b-124c-4423-bd19-bd6b8f88852b"),
                        Description = "Recusandae ut sunt accusamus.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 5, 15, 49, 47, 724, DateTimeKind.Unspecified).AddTicks(1219),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "non",
                        Option = "One",
                        PhotoFileName = "iceland_krona.jpeg",
                        Price = 0.9401470996684185300105355549m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 2078366352,
                        Stock = -1574173716,
                        BackpackType = "Hiking"
                    },
                    new
                    {
                        Id = new Guid("8b934af2-720f-4cdf-bca2-1ee654d8b46c"),
                        Description = "Atque quia debitis et ratione iure ducimus ex.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 9, 0, 16, 24, 168, DateTimeKind.Unspecified).AddTicks(9314),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "qui",
                        Option = "Three",
                        PhotoFileName = "bond_markets_units_european_composite_unit_(eurco).pdf",
                        Price = 0.4290288836515254352561816583m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 475301237,
                        Stock = 1094590934,
                        BackpackType = "Cycling"
                    },
                    new
                    {
                        Id = new Guid("4bc37616-ec86-4a1e-a9af-0e62e98d6849"),
                        Description = "Reprehenderit rem quia laborum odio incidunt esse esse.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 7, 22, 6, 16, 17, DateTimeKind.Unspecified).AddTicks(1682),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "vitae",
                        Option = "Two",
                        PhotoFileName = "generate.png",
                        Price = 0.4437501159167800435586039594m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 174312085,
                        Stock = 1690053177,
                        BackpackType = "Climbing"
                    },
                    new
                    {
                        Id = new Guid("3020569d-2be5-4442-a779-5e97a1740de6"),
                        Description = "Qui delectus totam earum suscipit.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 10, 20, 0, 3, 553, DateTimeKind.Unspecified).AddTicks(6994),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "est",
                        Option = "Two",
                        PhotoFileName = "wireless_latvia.wav",
                        Price = 0.3007829675821408120913286988m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 1052748516,
                        Stock = -121301066,
                        BackpackType = "Cycling"
                    },
                    new
                    {
                        Id = new Guid("8f302d3c-630e-467d-ade6-2c73047fd46d"),
                        Description = "Numquam aut ut.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 3, 9, 29, 12, 499, DateTimeKind.Unspecified).AddTicks(8965),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quis",
                        Option = "One",
                        PhotoFileName = "gabon_salmon_functionalities.jpe",
                        Price = 0.0309428269023770472693583329m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1698682812,
                        Stock = -61701202,
                        BackpackType = "DayPack"
                    },
                    new
                    {
                        Id = new Guid("d8cec59b-31a6-416a-8885-f7dbf46630f4"),
                        Description = "Eos occaecati ea voluptate.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 11, 22, 3, 43, 762, DateTimeKind.Unspecified).AddTicks(6091),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "pariatur",
                        Option = "Two",
                        PhotoFileName = "black_monetize_tasty_steel_chicken.mpga",
                        Price = 0.9165688367498492334936169326m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 1449104938,
                        Stock = -2055055167,
                        BackpackType = "Overnight"
                    },
                    new
                    {
                        Id = new Guid("5fc8e291-4d46-4c8b-a4a1-d1a77c9416a5"),
                        Description = "Vitae magni laudantium beatae.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 13, 2, 26, 18, 282, DateTimeKind.Unspecified).AddTicks(1265),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quo",
                        Option = "Three",
                        PhotoFileName = "mindshare_http.png",
                        Price = 0.1224779395182611014971816429m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 1761527068,
                        Stock = 163117207,
                        BackpackType = "Climbing"
                    },
                    new
                    {
                        Id = new Guid("b95929f8-de35-4f5d-ac51-85b680cc0ca6"),
                        Description = "Doloribus itaque reprehenderit repudiandae.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 9, 11, 1, 59, 36, 78, DateTimeKind.Unspecified).AddTicks(4346),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "dolorum",
                        Option = "One",
                        PhotoFileName = "route_handcrafted_metal_keyboard.htm",
                        Price = 0.5646208215371352322410467832m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -1227634980,
                        Stock = -1858481736,
                        BackpackType = "DayPack"
                    },
                    new
                    {
                        Id = new Guid("d3c14755-e161-4325-9509-add643864e95"),
                        Description = "Sit aut excepturi aut sit eum doloribus.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 6, 11, 49, 25, 151, DateTimeKind.Unspecified).AddTicks(6119),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "omnis",
                        Option = "Two",
                        PhotoFileName = "24_7_feed_generating.mp2a",
                        Price = 0.2914973413731705583230969579m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -285876816,
                        Stock = 566271027,
                        BackpackType = "Overnight"
                    },
                    new
                    {
                        Id = new Guid("c5779eed-81fc-4227-b116-71b0319abf68"),
                        Description = "Repellat error explicabo esse repudiandae minus.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 10, 21, 48, 43, 108, DateTimeKind.Unspecified).AddTicks(8845),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "dignissimos",
                        Option = "One",
                        PhotoFileName = "invoice.pdf",
                        Price = 0.855817324494265285553204151m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 394441469,
                        Stock = 1143775360,
                        BackpackType = "Hiking"
                    },
                    new
                    {
                        Id = new Guid("9dbacce0-c183-4545-a462-1af55ea88932"),
                        Description = "Est autem quo maiores harum iste ab dolores doloribus voluptatum.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 24, 2, 1, 34, 872, DateTimeKind.Unspecified).AddTicks(8370),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "assumenda",
                        Option = "Three",
                        PhotoFileName = "assurance_e_enable_connect.gif",
                        Price = 0.6201540322895184132582351111m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -171883210,
                        Stock = -918030404,
                        BackpackType = "DayPack"
                    },
                    new
                    {
                        Id = new Guid("266ea095-da4f-4f11-9486-53a1bdb9fae9"),
                        Description = "Corrupti officia dolor quod provident.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 11, 12, 59, 25, 599, DateTimeKind.Unspecified).AddTicks(6469),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "optio",
                        Option = "Two",
                        PhotoFileName = "fantastic_personal_loan_account.png",
                        Price = 0.1910235821263402060222870091m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1458398813,
                        Stock = 74159081,
                        BackpackType = "Cycling"
                    },
                    new
                    {
                        Id = new Guid("ac299c95-d2d7-49e3-88eb-550d991446f7"),
                        Description = "Ipsum quaerat dolorem mollitia voluptatem.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 21, 0, 39, 6, 269, DateTimeKind.Unspecified).AddTicks(2449),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "officia",
                        Option = "Three",
                        PhotoFileName = "solomon_islands_grey_invoice.png",
                        Price = 0.0227259283996609376448389122m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -522247010,
                        Stock = 1796633501,
                        BackpackType = "Cycling"
                    },
                    new
                    {
                        Id = new Guid("18a5e72b-49c6-47e7-9f72-1ee0a3205c00"),
                        Description = "Et omnis non corporis nobis doloribus ea.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 7, 26, 18, 31, 40, 412, DateTimeKind.Unspecified).AddTicks(9234),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quos",
                        Option = "Three",
                        PhotoFileName = "fresh_web_enabled_unbranded.gif",
                        Price = 0.3021549138082857100520235949m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -955887104,
                        Stock = 419591638,
                        BackpackType = "Climbing"
                    },
                    new
                    {
                        Id = new Guid("a9966c74-f188-4d55-b33e-a3aca71ca319"),
                        Description = "Nisi mollitia quia temporibus sit quo dolorum officiis facere vel.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 12, 7, 3, 14, 76, DateTimeKind.Unspecified).AddTicks(9385),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "soluta",
                        Option = "Three",
                        PhotoFileName = "money_market_account.jpeg",
                        Price = 0.7852507143342017968260247995m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -2140367550,
                        Stock = 2029663639,
                        BackpackType = "Cycling"
                    },
                    new
                    {
                        Id = new Guid("f68b11cc-35ca-4f58-81b5-0a975e47d7f3"),
                        Description = "Est facilis nisi rerum omnis consequatur.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 7, 25, 22, 11, 34, 644, DateTimeKind.Unspecified).AddTicks(8529),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quas",
                        Option = "Two",
                        PhotoFileName = "zero_tolerance_definition.gif",
                        Price = 0.3207988788421447531747823566m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1917393661,
                        Stock = 1520901273,
                        BackpackType = "Cycling"
                    },
                    new
                    {
                        Id = new Guid("b5de4d13-daa3-4f75-87eb-69a5e0c33046"),
                        Description = "Natus autem sed et ipsam et.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 7, 6, 22, 44, 11, 36, DateTimeKind.Unspecified).AddTicks(9071),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "sit",
                        Option = "Three",
                        PhotoFileName = "teal_transmitting_practical_plastic_table.gif",
                        Price = 0.1068484521939120683314920908m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 1962929980,
                        Stock = 306295959,
                        BackpackType = "Climbing"
                    },
                    new
                    {
                        Id = new Guid("4b17c044-a7c2-40a2-be26-db0059711168"),
                        Description = "Aliquid quibusdam eos qui ullam necessitatibus non eum dolor officia.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 24, 11, 13, 54, 550, DateTimeKind.Unspecified).AddTicks(3401),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "alias",
                        Option = "Three",
                        PhotoFileName = "practical_soft_pizza.jpe",
                        Price = 0.1550092958074425383801000958m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -482052297,
                        Stock = 250104312,
                        BackpackType = "Snowsports"
                    },
                    new
                    {
                        Id = new Guid("d9350f7b-8abe-4aed-9484-5bb0664b4a2f"),
                        Description = "Necessitatibus et dolor ad officiis reprehenderit fugiat.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 25, 3, 5, 56, 497, DateTimeKind.Unspecified).AddTicks(783),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "vitae",
                        Option = "Two",
                        PhotoFileName = "transition_grocery_licensed_plastic_shoes.mp2",
                        Price = 0.5060307942231429723939955531m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -272109206,
                        Stock = -1904413283,
                        BackpackType = "Overnight"
                    },
                    new
                    {
                        Id = new Guid("e40682d0-6af8-4f02-ad10-a2aea4eb0777"),
                        Description = "Dolores aut sint ullam.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 7, 7, 40, 39, 929, DateTimeKind.Unspecified).AddTicks(4578),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "nulla",
                        Option = "One",
                        PhotoFileName = "home_loan_account.pdf",
                        Price = 0.7472200546343002416268358924m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 884344646,
                        Stock = 972680634,
                        BackpackType = "Hiking"
                    },
                    new
                    {
                        Id = new Guid("ac3f5151-780d-4d4f-8844-439a07f59f48"),
                        Description = "Quo corrupti ipsa quia temporibus nisi.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 23, 16, 47, 45, 340, DateTimeKind.Unspecified).AddTicks(1324),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "nulla",
                        Option = "Three",
                        PhotoFileName = "engineer_intelligent_developer.shtml",
                        Price = 0.1573923348384465497089767032m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 1404298559,
                        Stock = 1922743469,
                        BackpackType = "Climbing"
                    },
                    new
                    {
                        Id = new Guid("68c6b4ea-b9fc-4c7f-bbd7-763831eb3c8e"),
                        Description = "Sequi corporis praesentium architecto illo.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 17, 14, 15, 21, 317, DateTimeKind.Unspecified).AddTicks(8373),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "consequatur",
                        Option = "One",
                        PhotoFileName = "orchid_proactive.gif",
                        Price = 0.2696597334912325453242666465m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -1750537882,
                        Stock = 2051132776,
                        BackpackType = "Cycling"
                    },
                    new
                    {
                        Id = new Guid("a5a3d20a-63c5-4513-aa25-a750debc8c92"),
                        Description = "Sunt totam qui accusantium laboriosam dolores quis.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 25, 10, 1, 55, 371, DateTimeKind.Unspecified).AddTicks(356),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "dolorum",
                        Option = "One",
                        PhotoFileName = "grove_impactful.pdf",
                        Price = 0.6059426555283746332882500354m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1479309508,
                        Stock = -1582057502,
                        BackpackType = "Cycling"
                    },
                    new
                    {
                        Id = new Guid("3ec8e386-f57c-4aac-a499-167719009a5c"),
                        Description = "Aut qui placeat eos.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 13, 15, 57, 35, 281, DateTimeKind.Unspecified).AddTicks(6200),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "dolore",
                        Option = "Three",
                        PhotoFileName = "rustic_wooden_soap_georgia_monitor.wav",
                        Price = 0.2218937124712883931854359134m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1883481274,
                        Stock = 2145762953,
                        BackpackType = "Snowsports"
                    },
                    new
                    {
                        Id = new Guid("b838ed84-5f61-46ad-b9b6-e3bde7102eb8"),
                        Description = "Iusto odio ad amet et est praesentium provident.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 17, 3, 53, 9, 443, DateTimeKind.Unspecified).AddTicks(7116),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "eveniet",
                        Option = "Three",
                        PhotoFileName = "cross_platform_stream.pdf",
                        Price = 0.4284272193602512822108917515m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 1882331424,
                        Stock = -715634942,
                        BackpackType = "Climbing"
                    },
                    new
                    {
                        Id = new Guid("63636706-3b1f-43c5-84f3-f75a006acee7"),
                        Description = "Non sequi aut a expedita neque exercitationem quas magnam.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 7, 12, 1, 51, 54, 648, DateTimeKind.Unspecified).AddTicks(6853),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "possimus",
                        Option = "One",
                        PhotoFileName = "soft_iowa_marketing.mpga",
                        Price = 0.4018455241189306709941988063m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -826040102,
                        Stock = 1584107523,
                        BackpackType = "DayPack"
                    },
                    new
                    {
                        Id = new Guid("08a7c665-f616-41fc-b3a2-09e84cef2496"),
                        Description = "Veritatis sunt pariatur.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 20, 12, 3, 11, 384, DateTimeKind.Unspecified).AddTicks(2364),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "beatae",
                        Option = "One",
                        PhotoFileName = "ability_capacitor_index.htm",
                        Price = 0.945258776082552498859410728m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -725282922,
                        Stock = -1742127344,
                        BackpackType = "Overnight"
                    },
                    new
                    {
                        Id = new Guid("0bd972fa-a6dc-4555-b300-af551a1cb27f"),
                        Description = "Accusantium fuga et.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 17, 15, 14, 51, 102, DateTimeKind.Unspecified).AddTicks(8452),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "id",
                        Option = "Three",
                        PhotoFileName = "mobile.mpe",
                        Price = 0.8531062218356876383296665457m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -721185924,
                        Stock = -2008109061,
                        BackpackType = "Hiking"
                    },
                    new
                    {
                        Id = new Guid("ee04be6c-e6aa-444e-a138-b44068c34324"),
                        Description = "Placeat necessitatibus amet at ea tenetur.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 8, 22, 59, 44, 347, DateTimeKind.Unspecified).AddTicks(7548),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "labore",
                        Option = "One",
                        PhotoFileName = "handmade_concrete_bacon_station.pdf",
                        Price = 0.5533066749613350331816039173m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 401763747,
                        Stock = -450161457,
                        BackpackType = "Hiking"
                    },
                    new
                    {
                        Id = new Guid("298a831e-ed75-484b-bc99-2905a0886f52"),
                        Description = "Est est minus eos voluptatem magnam recusandae.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 3, 3, 57, 3, 991, DateTimeKind.Unspecified).AddTicks(9077),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "fuga",
                        Option = "Three",
                        PhotoFileName = "regional_arkansas.pdf",
                        Price = 0.0066283429894732388894851247m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 862643594,
                        Stock = -500766730,
                        BackpackType = "Snowsports"
                    },
                    new
                    {
                        Id = new Guid("968b61fd-a0b3-4a53-a977-c3ff4b4734dd"),
                        Description = "Praesentium ut ipsa consequuntur earum quis error inventore incidunt.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 21, 5, 30, 16, 984, DateTimeKind.Unspecified).AddTicks(3341),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "excepturi",
                        Option = "One",
                        PhotoFileName = "cayman_islands_deposit_matrix.wav",
                        Price = 0.4458216890447771965809257994m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -933193982,
                        Stock = 388605327,
                        BackpackType = "Overnight"
                    },
                    new
                    {
                        Id = new Guid("16adb77a-c07a-468b-b974-ee4210fae715"),
                        Description = "Odit expedita deserunt.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 1, 23, 18, 34, 621, DateTimeKind.Unspecified).AddTicks(8640),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "libero",
                        Option = "Two",
                        PhotoFileName = "manager_reinvent_cambridgeshire.png",
                        Price = 0.7555454853296319557085637946m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 945154444,
                        Stock = 1631688324,
                        BackpackType = "Cycling"
                    },
                    new
                    {
                        Id = new Guid("04c1a4ba-7f50-4d42-8ac3-c4175e3254a6"),
                        Description = "Sint labore voluptatem consectetur.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 2, 3, 27, 19, 60, DateTimeKind.Unspecified).AddTicks(6395),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "accusamus",
                        Option = "Three",
                        PhotoFileName = "movies_new_york.gif",
                        Price = 0.4095457731278315737463384669m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 739839427,
                        Stock = 1505497842,
                        BackpackType = "Hiking"
                    },
                    new
                    {
                        Id = new Guid("13705ca3-66f0-4081-840c-40b84b1e6730"),
                        Description = "Aut cum tempora ducimus.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 6, 20, 40, 50, 997, DateTimeKind.Unspecified).AddTicks(2656),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "et",
                        Option = "One",
                        PhotoFileName = "licensed_metal_soap.jpe",
                        Price = 0.3793710678855582434860622489m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 1779456415,
                        Stock = -2042332758,
                        BackpackType = "Overnight"
                    },
                    new
                    {
                        Id = new Guid("9769497f-5a57-423a-a667-29950e671f5b"),
                        Description = "Rem et harum doloribus explicabo beatae sed.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 9, 22, 34, 16, 124, DateTimeKind.Unspecified).AddTicks(5631),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "repudiandae",
                        Option = "Three",
                        PhotoFileName = "soft.html",
                        Price = 0.7645563238610370532153311999m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 903262031,
                        Stock = 913821201,
                        BackpackType = "Climbing"
                    },
                    new
                    {
                        Id = new Guid("b51af9f9-4bd1-40cc-8f8b-f0c9751e9e16"),
                        Description = "Ducimus non consequatur amet voluptas est voluptatem dolor laboriosam.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 31, 1, 23, 0, 695, DateTimeKind.Unspecified).AddTicks(4913),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "et",
                        Option = "One",
                        PhotoFileName = "transmitting.mpeg",
                        Price = 0.4788861717470013144117491847m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -1948388119,
                        Stock = 1550951268,
                        BackpackType = "Hiking"
                    });
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.Entities.Products.Boot", b =>
            {
                b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.Entities.Products.Product");

                b.Property<string>("BootType")
                   .IsRequired()
                   .HasColumnType("nvarchar(max)");

                b.Property<int>("Size")
                   .HasColumnType("int");

                b.HasDiscriminator().HasValue("Boot");

                b.HasData(new
                    {
                        Id = new Guid("9beab515-44dc-4418-aa10-565ac8a46947"),
                        Description = "Ullam ducimus sed voluptatibus.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 19, 8, 17, 21, 259, DateTimeKind.Unspecified).AddTicks(1202),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "earum",
                        Option = "Three",
                        PhotoFileName = "auxiliary_fuchsia.m2a",
                        Price = 0.8149319276952651564687080803m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -985383122,
                        Stock = -434926967,
                        BootType = "Football",
                        Size = -1743945383
                    },
                    new
                    {
                        Id = new Guid("ab59d3ee-199e-4385-8d65-6ac971ed67a0"),
                        Description = "Nihil vero dolores.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 10, 17, 9, 12, 243, DateTimeKind.Unspecified).AddTicks(505),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "aspernatur",
                        Option = "Two",
                        PhotoFileName = "program_compressing.jpg",
                        Price = 0.6619496377903954615703699913m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 1334341297,
                        Stock = -1992305173,
                        BootType = "Cowboy",
                        Size = 768653876
                    },
                    new
                    {
                        Id = new Guid("92ec7e44-43aa-41ba-bf62-524e0d4f582b"),
                        Description = "Aspernatur eaque fugit sed fugit aut.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 31, 5, 23, 13, 206, DateTimeKind.Unspecified).AddTicks(2157),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "porro",
                        Option = "Two",
                        PhotoFileName = "indexing.mp4",
                        Price = 0.0721702512917710551183172008m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1879180017,
                        Stock = 41323002,
                        BootType = "Football",
                        Size = -1407127743
                    },
                    new
                    {
                        Id = new Guid("6c864210-d0f8-4d30-b6e7-31b1790f5af4"),
                        Description = "Eaque atque earum molestias veritatis.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 17, 17, 0, 50, 879, DateTimeKind.Unspecified).AddTicks(7497),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "unde",
                        Option = "One",
                        PhotoFileName = "canyon_incredible_granite_salad.m2v",
                        Price = 0.3819959838413905571539356937m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -289804409,
                        Stock = 1281420914,
                        BootType = "Drysuit",
                        Size = 1962373436
                    },
                    new
                    {
                        Id = new Guid("34c08f0a-3079-434d-8834-13f8fd8f8c94"),
                        Description = "Fuga optio magni nihil et.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 3, 17, 9, 4, 47, DateTimeKind.Unspecified).AddTicks(717),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "dolorem",
                        Option = "One",
                        PhotoFileName = "sleek_steel_gloves_auto_loan_account.html",
                        Price = 0.2331295696533624385064129702m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1547374434,
                        Stock = -508562143,
                        BootType = "Engineer",
                        Size = 158830887
                    },
                    new
                    {
                        Id = new Guid("f3902b80-4572-471d-b81e-7bafed25b7a6"),
                        Description = "Dolorem ipsum et reprehenderit nam pariatur cum qui provident id.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 14, 16, 55, 21, 481, DateTimeKind.Unspecified).AddTicks(6042),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "iure",
                        Option = "Two",
                        PhotoFileName = "forges.mpeg",
                        Price = 0.8710672135111785549982616194m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 579765985,
                        Stock = 2056478316,
                        BootType = "Harness",
                        Size = -1984756227
                    },
                    new
                    {
                        Id = new Guid("da1b9a03-afb6-44f2-9f57-65e30ffc87ff"),
                        Description = "Ut perspiciatis amet molestiae non et sed neque.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 12, 14, 47, 4, 271, DateTimeKind.Unspecified).AddTicks(1383),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "sunt",
                        Option = "One",
                        PhotoFileName = "turkish_lira.pdf",
                        Price = 0.3404021015955623026772874207m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1709642195,
                        Stock = 1444938060,
                        BootType = "Engineer",
                        Size = -689281811
                    },
                    new
                    {
                        Id = new Guid("faa3a010-a280-4b91-ab5b-c4a6fb7154b7"),
                        Description = "Magnam dolores explicabo.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 26, 21, 57, 9, 214, DateTimeKind.Unspecified).AddTicks(8777),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "possimus",
                        Option = "Three",
                        PhotoFileName = "points_hack_belize.html",
                        Price = 0.9822212495922639275778942644m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 537501044,
                        Stock = 1450737969,
                        BootType = "Cowboy",
                        Size = -269457469
                    },
                    new
                    {
                        Id = new Guid("b95a9491-b14c-4fea-bab6-c6b0c77dbf5f"),
                        Description = "Nulla illo harum et qui similique modi sit ipsa iste.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 30, 17, 16, 56, 847, DateTimeKind.Unspecified).AddTicks(903),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "maxime",
                        Option = "Three",
                        PhotoFileName = "sas_automotive__games_&_games.pdf",
                        Price = 0.0559919315825153668141506914m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1379102728,
                        Stock = 1415286747,
                        BootType = "Harness",
                        Size = 1703548289
                    },
                    new
                    {
                        Id = new Guid("10af2fd5-67cc-459a-a3c2-baece9276747"),
                        Description = "Optio recusandae ab rerum qui nesciunt deserunt sint.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 10, 13, 12, 26, 583, DateTimeKind.Unspecified).AddTicks(3718),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "et",
                        Option = "Three",
                        PhotoFileName = "cambridgeshire_best_of_breed_italy.png",
                        Price = 0.4964147060811030673175014419m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -177078525,
                        Stock = -1783502030,
                        BootType = "Cowboy",
                        Size = 975804304
                    },
                    new
                    {
                        Id = new Guid("4e46adae-19f7-4542-ab8f-42a41b2be986"),
                        Description = "Occaecati molestiae omnis modi rerum quam rerum aut.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 9, 21, 9, 27, 56, 787, DateTimeKind.Unspecified).AddTicks(6815),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "rem",
                        Option = "Three",
                        PhotoFileName = "grid_enabled_intranet_automotive_&_beauty.gif",
                        Price = 0.3500349991850909345065888283m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 876818966,
                        Stock = -79745040,
                        BootType = "Cowboy",
                        Size = 1228996003
                    },
                    new
                    {
                        Id = new Guid("49055f57-c03b-463b-8013-3d4cf3be404c"),
                        Description = "Nihil ut laudantium dolorem ipsa.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 16, 13, 41, 5, 358, DateTimeKind.Unspecified).AddTicks(9568),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quia",
                        Option = "Three",
                        PhotoFileName = "orchestrate_generate_credit_card_account.mpg4",
                        Price = 0.0408924509562494267169895841m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -2036390279,
                        Stock = 1861141424,
                        BootType = "Chelsea",
                        Size = 646016143
                    },
                    new
                    {
                        Id = new Guid("c0e69278-5d52-4202-9545-37e7e15d5721"),
                        Description = "Consectetur repudiandae dignissimos possimus vel sit magni.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 2, 17, 34, 15, 401, DateTimeKind.Unspecified).AddTicks(1871),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "recusandae",
                        Option = "Three",
                        PhotoFileName = "angola_checking_account_ergonomic_rubber_pants.jpeg",
                        Price = 0.7075982906615606038445367383m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -805674613,
                        Stock = 561626899,
                        BootType = "Football",
                        Size = 938855177
                    },
                    new
                    {
                        Id = new Guid("5b1da6c5-3c74-429c-b9da-473e1d776ed1"),
                        Description = "Quis nostrum voluptas voluptas sunt placeat.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 7, 19, 5, 3, 52, 537, DateTimeKind.Unspecified).AddTicks(6403),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quibusdam",
                        Option = "One",
                        PhotoFileName = "navigate_handmade_tasty.jpe",
                        Price = 0.7830323072662879830477123483m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 1424743708,
                        Stock = -313470883,
                        BootType = "Harness",
                        Size = 1823266886
                    },
                    new
                    {
                        Id = new Guid("fb48d460-86e5-4612-acd1-2a59d415a449"),
                        Description = "Animi quis consectetur possimus adipisci modi natus dolores aut.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 9, 9, 16, 32, 225, DateTimeKind.Unspecified).AddTicks(2592),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "labore",
                        Option = "One",
                        PhotoFileName = "licensed.m2v",
                        Price = 0.2551535101489137649236788836m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 503742235,
                        Stock = -1439658454,
                        BootType = "Engineer",
                        Size = 1851868132
                    },
                    new
                    {
                        Id = new Guid("79354342-c4f9-46eb-b8f1-8d1cfaa9242c"),
                        Description = "Dolorum saepe ratione est.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 14, 6, 2, 20, 637, DateTimeKind.Unspecified).AddTicks(220),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "mollitia",
                        Option = "Two",
                        PhotoFileName = "michigan_incredible_rubber_chips_tactics.htm",
                        Price = 0.5460259188628524198825606199m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -614512929,
                        Stock = -111033695,
                        BootType = "Chelsea",
                        Size = 1775601073
                    },
                    new
                    {
                        Id = new Guid("96b92eea-9c1f-4bc6-b4aa-f1af08e2c33c"),
                        Description = "Voluptas consequatur sequi.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 8, 1, 56, 29, 905, DateTimeKind.Unspecified).AddTicks(4083),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "voluptas",
                        Option = "One",
                        PhotoFileName = "integrate_tasty_rubber_chicken.m2v",
                        Price = 0.9610780999768154765940303023m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -2087988728,
                        Stock = 1531149367,
                        BootType = "Engineer",
                        Size = 1583726617
                    },
                    new
                    {
                        Id = new Guid("3646e095-837a-471e-ad57-7a3f1b92eb56"),
                        Description = "Laborum tempora itaque ea consequuntur corrupti illum assumenda sunt officia.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 5, 1, 23, 30, 225, DateTimeKind.Unspecified).AddTicks(7970),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "enim",
                        Option = "One",
                        PhotoFileName = "small.mpeg",
                        Price = 0.6645616698462666722609527626m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 41768480,
                        Stock = 404818629,
                        BootType = "Chelsea",
                        Size = -1150674576
                    },
                    new
                    {
                        Id = new Guid("93c26021-c409-4bbe-81a9-02d55aba452b"),
                        Description = "Debitis aperiam aut officiis error excepturi nostrum dolorem.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 24, 19, 0, 28, 480, DateTimeKind.Unspecified).AddTicks(5262),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "sint",
                        Option = "Two",
                        PhotoFileName = "aruba_outdoors__grocery_&_computers.html",
                        Price = 0.3502597026261455223026602683m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -605422765,
                        Stock = -484425594,
                        BootType = "Chelsea",
                        Size = 1940199611
                    },
                    new
                    {
                        Id = new Guid("510d94ff-80c0-4895-814c-fa41e1b97a5d"),
                        Description = "Quidem eum ut nobis.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 11, 10, 24, 57, 238, DateTimeKind.Unspecified).AddTicks(372),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "sit",
                        Option = "Three",
                        PhotoFileName = "ib.pdf",
                        Price = 0.7332541910231422450065177546m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 2026207803,
                        Stock = 861312765,
                        BootType = "Football",
                        Size = -2140813549
                    },
                    new
                    {
                        Id = new Guid("72a3b76c-389a-4957-942a-0f65e8ae4117"),
                        Description = "Modi magni facere.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 28, 22, 26, 31, 216, DateTimeKind.Unspecified).AddTicks(5946),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "alias",
                        Option = "Three",
                        PhotoFileName = "optimized.gif",
                        Price = 0.1629283203058939335425262976m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 969657887,
                        Stock = 2142835925,
                        BootType = "Drysuit",
                        Size = -553713764
                    },
                    new
                    {
                        Id = new Guid("f34c7adc-c3c8-4c3f-a475-41a6a3e82904"),
                        Description = "Veniam quia dolores saepe laudantium occaecati.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 3, 4, 22, 40, 41, 221, DateTimeKind.Unspecified).AddTicks(9748),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "esse",
                        Option = "Three",
                        PhotoFileName = "games__home_&_tools.pdf",
                        Price = 0.4286576119428487911526725166m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1588815485,
                        Stock = -1597593213,
                        BootType = "Chelsea",
                        Size = 433144593
                    },
                    new
                    {
                        Id = new Guid("75fc6060-805a-4fbb-bebb-df473742e907"),
                        Description = "In est reiciendis architecto eos ratione possimus sint.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 29, 8, 26, 54, 334, DateTimeKind.Unspecified).AddTicks(9849),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "rerum",
                        Option = "Three",
                        PhotoFileName = "navigate.shtml",
                        Price = 0.6698224148618680292723176144m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -886311217,
                        Stock = -1003590575,
                        BootType = "Cowboy",
                        Size = -427894925
                    },
                    new
                    {
                        Id = new Guid("d8d9c768-d8d7-4be3-9e5d-7c3c981a3c4c"),
                        Description = "Et voluptatem animi aliquam ipsum veritatis necessitatibus atque.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 28, 19, 59, 11, 117, DateTimeKind.Unspecified).AddTicks(4908),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "eos",
                        Option = "One",
                        PhotoFileName = "practical_rubber_tuna.pdf",
                        Price = 0.3184088099253520886878684929m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -1188237506,
                        Stock = -771812510,
                        BootType = "Chelsea",
                        Size = -341227399
                    },
                    new
                    {
                        Id = new Guid("843b594f-53e8-4301-9d07-f850ef29c345"),
                        Description = "Quo ut ea molestiae.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 8, 9, 2, 21, 799, DateTimeKind.Unspecified).AddTicks(1554),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "dolor",
                        Option = "One",
                        PhotoFileName = "enable_loaf_chief.gif",
                        Price = 0.5379909280746160685322260205m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -1463810588,
                        Stock = -1830220162,
                        BootType = "Harness",
                        Size = 1171460706
                    },
                    new
                    {
                        Id = new Guid("919a2623-dd26-4ef4-ab1b-8bcba666aa63"),
                        Description = "Quasi eum hic eaque alias porro.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 9, 18, 0, 3, 45, 435, DateTimeKind.Unspecified).AddTicks(6490),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "sint",
                        Option = "One",
                        PhotoFileName = "hierarchy_new_hampshire.mpg",
                        Price = 0.8155428191039471735176289475m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -844021217,
                        Stock = 1398470410,
                        BootType = "Harness",
                        Size = 2122968033
                    },
                    new
                    {
                        Id = new Guid("d8af8bf8-efcc-4e6f-8753-19a0c7c15320"),
                        Description = "Ut voluptatibus fuga facilis necessitatibus rerum beatae atque doloribus vitae.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 14, 20, 14, 53, 167, DateTimeKind.Unspecified).AddTicks(6576),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "vel",
                        Option = "Two",
                        PhotoFileName = "uniform.gif",
                        Price = 0.2388961368651812802344540388m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 496709100,
                        Stock = -1255397815,
                        BootType = "Chelsea",
                        Size = 1429984809
                    },
                    new
                    {
                        Id = new Guid("3ad49212-7a1f-4868-b259-ce9a25f0f5f4"),
                        Description = "A nemo odit dolorem qui aut illum iste blanditiis minus.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 17, 15, 25, 0, 324, DateTimeKind.Unspecified).AddTicks(401),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "eius",
                        Option = "Three",
                        PhotoFileName = "light_small_fresh_chicken_communications.jpe",
                        Price = 0.3953095647450832685464935435m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -373003139,
                        Stock = 2020498167,
                        BootType = "Chelsea",
                        Size = -1560753026
                    },
                    new
                    {
                        Id = new Guid("74f01638-fcd2-4450-a107-4664472f0cda"),
                        Description = "Quia facere dolorem esse quod itaque quas iure.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 11, 8, 14, 58, 507, DateTimeKind.Unspecified).AddTicks(6625),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "dolorum",
                        Option = "Two",
                        PhotoFileName = "interactive.png",
                        Price = 0.0130505117635600804763010467m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -1143306726,
                        Stock = -781100725,
                        BootType = "Cowboy",
                        Size = -1409854471
                    },
                    new
                    {
                        Id = new Guid("cce9c9c7-6d95-4b34-a525-ed588e755a2b"),
                        Description = "Aut non saepe quasi omnis eum mollitia quia.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 2, 15, 40, 18, 799, DateTimeKind.Unspecified).AddTicks(8471),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "est",
                        Option = "Two",
                        PhotoFileName = "zero_administration.wav",
                        Price = 0.7072945934418315183720794821m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1582999711,
                        Stock = -2137383924,
                        BootType = "Football",
                        Size = 1776324680
                    },
                    new
                    {
                        Id = new Guid("7db64887-7947-4574-bddf-e815a4558c89"),
                        Description = "Rerum magnam tempora quia minima officiis blanditiis.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 27, 18, 29, 52, 519, DateTimeKind.Unspecified).AddTicks(8542),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "illum",
                        Option = "Three",
                        PhotoFileName = "coves_optimization_credit_card_account.gif",
                        Price = 0.8753436224232801417491696025m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -633747374,
                        Stock = 1816056496,
                        BootType = "Chelsea",
                        Size = -483403543
                    },
                    new
                    {
                        Id = new Guid("7e43aa4d-8300-42d2-908e-86d56c43eb02"),
                        Description = "Occaecati commodi ipsum sint et unde id porro ullam.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 7, 2, 14, 31, 382, DateTimeKind.Unspecified).AddTicks(5983),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "et",
                        Option = "One",
                        PhotoFileName = "human_sleek_fresh_keyboard.mp4",
                        Price = 0.7522110906778148752784400732m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 1504104500,
                        Stock = -1331032687,
                        BootType = "Football",
                        Size = 1487488874
                    },
                    new
                    {
                        Id = new Guid("963bf001-b8d5-4db6-a3c5-097ffe709bcd"),
                        Description = "Nihil tempora pariatur.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 14, 7, 8, 11, 956, DateTimeKind.Unspecified).AddTicks(7261),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "aut",
                        Option = "One",
                        PhotoFileName = "enterprise_wide_transition_adp.gif",
                        Price = 0.4889210799302349187207790048m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 661697511,
                        Stock = 1668447432,
                        BootType = "Cowboy",
                        Size = -319681229
                    },
                    new
                    {
                        Id = new Guid("accf45d7-9dfa-4a47-8a2e-3280ea53ac1e"),
                        Description = "Omnis nesciunt veniam voluptatem adipisci tempora deleniti molestiae.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 1, 14, 13, 34, 926, DateTimeKind.Unspecified).AddTicks(6196),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "rerum",
                        Option = "One",
                        PhotoFileName = "puerto_rico.jpg",
                        Price = 0.2672254405367814205406479135m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1226793641,
                        Stock = -1053738576,
                        BootType = "Cowboy",
                        Size = 1893768481
                    },
                    new
                    {
                        Id = new Guid("ac88c83b-f507-408a-b428-c66cf0a0ea7b"),
                        Description = "Voluptatem odit praesentium est soluta maxime qui quia.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 25, 22, 10, 25, 228, DateTimeKind.Unspecified).AddTicks(9148),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "voluptas",
                        Option = "Three",
                        PhotoFileName = "azure_bluetooth.gif",
                        Price = 0.823329701934461163194148559m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -1226845796,
                        Stock = -769477351,
                        BootType = "Cowboy",
                        Size = 1866087496
                    },
                    new
                    {
                        Id = new Guid("c2f140ad-21f3-4025-8849-38d7ad42aa9b"),
                        Description = "Non non eveniet nobis dolores adipisci maiores et ut iure.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 10, 22, 30, 42, 773, DateTimeKind.Unspecified).AddTicks(5598),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "similique",
                        Option = "Three",
                        PhotoFileName = "calculate_berkshire_isle.gif",
                        Price = 0.1903274582411226162641076332m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -665429201,
                        Stock = -121638407,
                        BootType = "Engineer",
                        Size = 435977791
                    },
                    new
                    {
                        Id = new Guid("1d7c2d29-06ad-484b-8008-53ddf6cb471e"),
                        Description = "Quod velit provident sed tempore commodi temporibus.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 21, 12, 12, 31, 109, DateTimeKind.Unspecified).AddTicks(8839),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "repudiandae",
                        Option = "One",
                        PhotoFileName = "paradigm_card.jpg",
                        Price = 0.659704841218468550220881082m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -1505453786,
                        Stock = -2089068084,
                        BootType = "Cowboy",
                        Size = 348704708
                    },
                    new
                    {
                        Id = new Guid("16d816a2-61ac-4360-9270-49cbc50a73c1"),
                        Description = "Tempora modi ut eligendi qui nisi.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 30, 9, 5, 54, 520, DateTimeKind.Unspecified).AddTicks(2534),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "dicta",
                        Option = "Two",
                        PhotoFileName = "designer_scalable_colombia.png",
                        Price = 0.5481518424290541967023572565m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 1029778501,
                        Stock = -927431327,
                        BootType = "Chelsea",
                        Size = 484458540
                    },
                    new
                    {
                        Id = new Guid("207647fe-edad-4fb0-bf21-0858f64f3680"),
                        Description = "Maxime hic ea reiciendis reprehenderit animi deserunt porro itaque id.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 9, 26, 5, 31, 13, 229, DateTimeKind.Unspecified).AddTicks(6784),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "perspiciatis",
                        Option = "Three",
                        PhotoFileName = "smtp.wav",
                        Price = 0.3600139347184227381213324671m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1816207948,
                        Stock = 1951671123,
                        BootType = "Drysuit",
                        Size = -972240935
                    },
                    new
                    {
                        Id = new Guid("1928a7fa-4e18-40f3-a445-e95b20ee67ea"),
                        Description = "Optio voluptas qui earum nobis tempora.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 7, 20, 55, 53, 566, DateTimeKind.Unspecified).AddTicks(6445),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "et",
                        Option = "Three",
                        PhotoFileName = "ireland_grow.mp2",
                        Price = 0.5301714233540021098456819485m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 989953391,
                        Stock = -853340246,
                        BootType = "Engineer",
                        Size = 1159050835
                    },
                    new
                    {
                        Id = new Guid("529589e4-9746-4de6-b1ba-600f8d740ed4"),
                        Description = "Nihil praesentium quod qui ullam in illo.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 8, 12, 48, 37, 972, DateTimeKind.Unspecified).AddTicks(6508),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "fugiat",
                        Option = "Three",
                        PhotoFileName = "islands.gif",
                        Price = 0.690320528687447373591483399m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -513598176,
                        Stock = -264130876,
                        BootType = "Football",
                        Size = -346277146
                    },
                    new
                    {
                        Id = new Guid("65fc03dd-3520-4471-bf9b-3444ec326a57"),
                        Description = "Rerum porro et laboriosam et voluptatem incidunt temporibus.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 16, 4, 20, 44, 541, DateTimeKind.Unspecified).AddTicks(9224),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "sunt",
                        Option = "One",
                        PhotoFileName = "jamaica.png",
                        Price = 0.7552890988152548980849567875m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -227276124,
                        Stock = 1044529244,
                        BootType = "Football",
                        Size = -1284738506
                    },
                    new
                    {
                        Id = new Guid("7f08c64f-b25c-4d45-9a93-a8a728974333"),
                        Description = "Reprehenderit corporis exercitationem quaerat blanditiis debitis quo.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 22, 14, 21, 33, 118, DateTimeKind.Unspecified).AddTicks(8993),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "ex",
                        Option = "One",
                        PhotoFileName = "open_system.jpg",
                        Price = 0.7863564004408879802530849493m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -793578508,
                        Stock = 1761520138,
                        BootType = "Football",
                        Size = -436479110
                    },
                    new
                    {
                        Id = new Guid("79a67c64-3d3c-4c56-a817-541103bf2d62"),
                        Description = "Quis ipsum officiis accusantium expedita eos quasi beatae distinctio.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 9, 10, 29, 17, 61, DateTimeKind.Unspecified).AddTicks(6818),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "suscipit",
                        Option = "One",
                        PhotoFileName = "practical_fresh_soap_partnerships.mpg",
                        Price = 0.4067717394710307365299575509m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -368420525,
                        Stock = -413522130,
                        BootType = "Engineer",
                        Size = -385647993
                    },
                    new
                    {
                        Id = new Guid("b430c451-8c60-4245-bbeb-e18bfb0921a9"),
                        Description = "Distinctio distinctio ipsa.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 5, 23, 40, 47, 897, DateTimeKind.Unspecified).AddTicks(5058),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "commodi",
                        Option = "Three",
                        PhotoFileName = "azure.gif",
                        Price = 0.37243783521449139812700042m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 961607046,
                        Stock = -228161800,
                        BootType = "Engineer",
                        Size = 1450101984
                    },
                    new
                    {
                        Id = new Guid("81f1ee35-7b14-41e7-a723-1a7c624f50b5"),
                        Description = "Molestiae est beatae pariatur fuga ratione est.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 20, 11, 52, 59, 353, DateTimeKind.Unspecified).AddTicks(5960),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "ut",
                        Option = "Two",
                        PhotoFileName = "customer.mpe",
                        Price = 0.0998117897824655219426820504m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -309620312,
                        Stock = 606800873,
                        BootType = "Engineer",
                        Size = 273085531
                    },
                    new
                    {
                        Id = new Guid("d0496cd0-03dc-463c-8464-b1da9637ebab"),
                        Description = "Similique vel aspernatur.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 11, 0, 34, 17, 503, DateTimeKind.Unspecified).AddTicks(6923),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "molestias",
                        Option = "One",
                        PhotoFileName = "books__home_&_baby_reboot_home_loan_account.jpeg",
                        Price = 0.6283779686743236279492588681m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -1364914195,
                        Stock = -1459044759,
                        BootType = "Harness",
                        Size = 1476240976
                    },
                    new
                    {
                        Id = new Guid("ace9c148-364c-43dd-81f7-bba250ddd0ab"),
                        Description = "Quidem quidem quidem ut consectetur ut illum aut.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 25, 8, 42, 53, 938, DateTimeKind.Unspecified).AddTicks(1066),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "et",
                        Option = "Two",
                        PhotoFileName = "plum_avon_payment.png",
                        Price = 0.097368249350303114434338078m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1775563760,
                        Stock = -933384690,
                        BootType = "Drysuit",
                        Size = 77102041
                    },
                    new
                    {
                        Id = new Guid("de33f547-3b2c-4bcb-bc68-60b436ea62ed"),
                        Description = "Amet fugiat vel enim deserunt quidem.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 23, 20, 50, 20, 652, DateTimeKind.Unspecified).AddTicks(3561),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "itaque",
                        Option = "Three",
                        PhotoFileName = "generic.jpeg",
                        Price = 0.4823798341567415521600115935m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 536091363,
                        Stock = 1923035471,
                        BootType = "Engineer",
                        Size = 1148614553
                    },
                    new
                    {
                        Id = new Guid("84d8a526-e901-456e-9ac2-f3622da47bb3"),
                        Description = "Doloremque nulla voluptas tempore qui quaerat cumque autem nemo sed.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 9, 3, 15, 10, 27, 272, DateTimeKind.Unspecified).AddTicks(8891),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "temporibus",
                        Option = "One",
                        PhotoFileName = "transmitting.mpe",
                        Price = 0.8594945024995735019175789658m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1396148310,
                        Stock = 472040266,
                        BootType = "Chelsea",
                        Size = 504263405
                    });
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.Entities.Products.Kayak", b =>
            {
                b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.Entities.Products.Product");

                b.Property<int>("AmountOfPerson")
                   .HasColumnType("int");

                b.Property<string>("KayakType")
                   .IsRequired()
                   .HasColumnType("nvarchar(max)");

                b.HasDiscriminator().HasValue("Kayak");

                b.HasData(new
                    {
                        Id = new Guid("622ab9c1-d816-4b5a-8591-abab46ea2234"),
                        Description = "Provident adipisci cupiditate animi eos quidem.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 2, 10, 45, 32, 953, DateTimeKind.Unspecified).AddTicks(4851),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "sed",
                        Option = "Three",
                        PhotoFileName = "senior_square.wav",
                        Price = 0.3593948220652328947986654897m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 1829583477,
                        Stock = -580453870,
                        AmountOfPerson = -812063578,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("2d0e8ba0-2073-48c6-bab8-3f1820b66c9f"),
                        Description = "Dolores aut praesentium.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 17, 14, 14, 27, 199, DateTimeKind.Unspecified).AddTicks(623),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "qui",
                        Option = "Three",
                        PhotoFileName = "invoice_plum.htm",
                        Price = 0.8332443035925770613623657599m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 1327607078,
                        Stock = -1663767952,
                        AmountOfPerson = -1143798560,
                        KayakType = "Diving"
                    },
                    new
                    {
                        Id = new Guid("34b24abd-da31-47c4-bc66-df1498645e3d"),
                        Description = "Praesentium ut aut eveniet dolor non placeat sequi.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 16, 0, 44, 23, 661, DateTimeKind.Unspecified).AddTicks(9949),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "atque",
                        Option = "One",
                        PhotoFileName = "outdoors_&_garden.mp2",
                        Price = 0.5380570507384617282447168083m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1496708420,
                        Stock = -253203513,
                        AmountOfPerson = -224012786,
                        KayakType = "Racing"
                    },
                    new
                    {
                        Id = new Guid("72237f7a-8887-4a31-b5ed-fe85ac5885c1"),
                        Description = "Omnis exercitationem sequi.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 7, 20, 19, 10, 9, 705, DateTimeKind.Unspecified).AddTicks(3091),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "ut",
                        Option = "Three",
                        PhotoFileName = "index_factors_bandwidth.gif",
                        Price = 0.0733480821999891794495010655m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1470567878,
                        Stock = 173684192,
                        AmountOfPerson = -50455932,
                        KayakType = "Racing"
                    },
                    new
                    {
                        Id = new Guid("40d2a0e2-30db-4e0c-be21-8f6ff090e625"),
                        Description = "Est aut praesentium.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 1, 2, 16, 0, 228, DateTimeKind.Unspecified).AddTicks(3805),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "sunt",
                        Option = "Three",
                        PhotoFileName = "director.wav",
                        Price = 0.0181226179682340174782668359m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 629340508,
                        Stock = -1579798588,
                        AmountOfPerson = -810506207,
                        KayakType = "Fishing"
                    },
                    new
                    {
                        Id = new Guid("e503878c-dbae-4fe3-9db9-0e61bcbe4012"),
                        Description = "Debitis maxime commodi natus quae harum magni eveniet quia suscipit.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 21, 7, 29, 37, 108, DateTimeKind.Unspecified).AddTicks(9170),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "nobis",
                        Option = "Two",
                        PhotoFileName = "engineer_incredible.gif",
                        Price = 0.147924039035111919421330072m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1444926902,
                        Stock = -945258728,
                        AmountOfPerson = -754852914,
                        KayakType = "Diving"
                    },
                    new
                    {
                        Id = new Guid("7501b5c5-f02f-4f3a-84e4-dbcaec010ab8"),
                        Description = "Ut nostrum in.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 15, 13, 54, 44, 370, DateTimeKind.Unspecified).AddTicks(9286),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "explicabo",
                        Option = "Two",
                        PhotoFileName = "monetize_focus_group.jpg",
                        Price = 0.2323808919521099154450620665m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1695546675,
                        Stock = -1550603300,
                        AmountOfPerson = -1845234319,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("0188b7c4-e533-4514-848e-17fbd754c8b5"),
                        Description = "Omnis officia soluta iste.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 7, 17, 47, 42, 260, DateTimeKind.Unspecified).AddTicks(436),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quaerat",
                        Option = "One",
                        PhotoFileName = "investor_bosnia_and_herzegovina.shtml",
                        Price = 0.2518809551449218795045925721m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -65840605,
                        Stock = -633575587,
                        AmountOfPerson = -1544730671,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("7a886c4d-4f91-4abe-8184-6eb49a30115a"),
                        Description = "Aliquid omnis delectus enim est aut natus impedit at earum.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 15, 15, 45, 49, 321, DateTimeKind.Unspecified).AddTicks(9258),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "aspernatur",
                        Option = "Two",
                        PhotoFileName = "integration_coordinator_egyptian_pound.jpeg",
                        Price = 0.7355260631792380494858505917m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 709295406,
                        Stock = 72717916,
                        AmountOfPerson = -1970983091,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("7cda996b-838f-4c0c-8a45-f0d362c08dc0"),
                        Description = "Unde quis quae aspernatur a animi dolor dolorum quo et.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 9, 26, 14, 28, 17, 760, DateTimeKind.Unspecified).AddTicks(4470),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "vero",
                        Option = "Three",
                        PhotoFileName = "ftp_officer_russian_ruble.jpeg",
                        Price = 0.3950647224190453398657234161m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 1108140386,
                        Stock = 635198224,
                        AmountOfPerson = 560275642,
                        KayakType = "Diving"
                    },
                    new
                    {
                        Id = new Guid("26a973fe-5c97-49db-89f4-d8e8b9ae66c0"),
                        Description = "Et illo qui laborum iste tenetur magni ipsa maiores.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 27, 7, 13, 38, 705, DateTimeKind.Unspecified).AddTicks(8835),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "inventore",
                        Option = "Three",
                        PhotoFileName = "sri_lanka_cove.m1v",
                        Price = 0.3897068193187782709314684125m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 366220388,
                        Stock = -981278588,
                        AmountOfPerson = -2051193179,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("78cbd578-f842-4f12-88a6-11aca9e518f1"),
                        Description = "Maxime ut maxime perspiciatis ut ipsam natus.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 28, 7, 12, 28, 395, DateTimeKind.Unspecified).AddTicks(9980),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "facere",
                        Option = "Three",
                        PhotoFileName = "web_programming.pdf",
                        Price = 0.0823496739625262422847264467m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 137144513,
                        Stock = 1301918562,
                        AmountOfPerson = -929806972,
                        KayakType = "Fishing"
                    },
                    new
                    {
                        Id = new Guid("1959b410-7dd7-4a6b-b78d-ca86a74524ef"),
                        Description = "Voluptatibus et aspernatur fugiat est.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 10, 21, 29, 18, 34, DateTimeKind.Unspecified).AddTicks(611),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "voluptas",
                        Option = "Three",
                        PhotoFileName = "collaborative_systems_games_&_outdoors.shtml",
                        Price = 0.0260611328490658644815231439m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 1613459758,
                        Stock = 1913832931,
                        AmountOfPerson = 1659394302,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("db10bc37-cdec-4ceb-a802-2de0f33b15b4"),
                        Description = "Aut autem sed.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 16, 21, 41, 51, 51, DateTimeKind.Unspecified).AddTicks(701),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "et",
                        Option = "Two",
                        PhotoFileName = "leading_edge_baby__toys_&_shoes.shtml",
                        Price = 0.7516044719594649273644379067m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 371026202,
                        Stock = 1125737528,
                        AmountOfPerson = 2100007169,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("8b1dee16-e447-4587-b8b7-de0a7b1940c2"),
                        Description = "Nobis libero accusamus voluptate error non praesentium sint nostrum quis.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 22, 6, 19, 31, 328, DateTimeKind.Unspecified).AddTicks(6109),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "excepturi",
                        Option = "Three",
                        PhotoFileName = "mexican_peso_metal_integrated.m1v",
                        Price = 0.6694473069437714099628277473m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -2042750379,
                        Stock = 104565929,
                        AmountOfPerson = 873860461,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("937ad58b-2796-49ae-b43b-28cc74ea23d4"),
                        Description = "Facilis recusandae id doloribus qui dolore quia tempora sed.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 7, 4, 18, 55, 44, 304, DateTimeKind.Unspecified).AddTicks(8740),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "necessitatibus",
                        Option = "Two",
                        PhotoFileName = "wooden_cotton_alabama.m2a",
                        Price = 0.2287082914910064479599396598m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1693352735,
                        Stock = 1270180147,
                        AmountOfPerson = 812531602,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("7581446d-f191-444a-abf8-c7116a21dc05"),
                        Description = "Veniam aspernatur voluptatum adipisci.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 12, 0, 57, 50, 421, DateTimeKind.Unspecified).AddTicks(4500),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "non",
                        Option = "One",
                        PhotoFileName = "program_rustic_metal_pizza_prairie.m1v",
                        Price = 0.0170198377231181630921202924m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -679466786,
                        Stock = 12064749,
                        AmountOfPerson = -214804139,
                        KayakType = "Fishing"
                    },
                    new
                    {
                        Id = new Guid("d697517c-98c6-456b-9b55-bdb6e43a8cf5"),
                        Description = "Aut voluptatem nisi alias qui.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 26, 6, 14, 42, 424, DateTimeKind.Unspecified).AddTicks(5265),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "dolorem",
                        Option = "One",
                        PhotoFileName = "grow.mpg",
                        Price = 0.00169570714242787665960381m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 166667752,
                        Stock = 35653769,
                        AmountOfPerson = -587220263,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("6cf1b685-b3d4-4a11-9e73-70e3486399d2"),
                        Description = "Dolorum iusto quibusdam molestiae.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 30, 16, 46, 37, 551, DateTimeKind.Unspecified).AddTicks(3477),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "rerum",
                        Option = "Two",
                        PhotoFileName = "practical_granite_hat_awesome_program.gif",
                        Price = 0.040144714201421927296765917m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -1127752412,
                        Stock = -786759175,
                        AmountOfPerson = -244842366,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("b4f5db19-645b-49e9-aa72-50d72275a650"),
                        Description = "Dignissimos illum quae.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 7, 24, 12, 25, 35, 679, DateTimeKind.Unspecified).AddTicks(7134),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "et",
                        Option = "One",
                        PhotoFileName = "secured_product.m2v",
                        Price = 0.9040184666245619438437376309m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -392784745,
                        Stock = -212510540,
                        AmountOfPerson = 557856058,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("2a76b096-034a-469a-93ed-e1df7a7ed897"),
                        Description = "Alias natus molestias.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 21, 9, 19, 22, 301, DateTimeKind.Unspecified).AddTicks(8988),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "numquam",
                        Option = "One",
                        PhotoFileName = "integrated_e_business.png",
                        Price = 0.8104321355629973013412497622m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 408829285,
                        Stock = -1706770187,
                        AmountOfPerson = 1548105857,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("eeb57f79-1319-45f6-a4b0-b3a3c2918245"),
                        Description = "Iusto vel doloribus consequatur vero nesciunt.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 7, 26, 10, 9, 2, 341, DateTimeKind.Unspecified).AddTicks(5927),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "velit",
                        Option = "Two",
                        PhotoFileName = "withdrawal_multi_tasking_cultivate.mp4",
                        Price = 0.2763297074430425124634020766m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -284222065,
                        Stock = 761418322,
                        AmountOfPerson = -785778540,
                        KayakType = "Racing"
                    },
                    new
                    {
                        Id = new Guid("65af82e8-27f6-44f3-af4a-029b73f14530"),
                        Description = "Est veniam unde.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 17, 1, 14, 29, 333, DateTimeKind.Unspecified).AddTicks(4978),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "debitis",
                        Option = "Two",
                        PhotoFileName = "payment_payment.m1v",
                        Price = 0.9021107455881482847021374521m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1764562021,
                        Stock = 372403795,
                        AmountOfPerson = 1128959420,
                        KayakType = "Racing"
                    },
                    new
                    {
                        Id = new Guid("b1be7cd7-1cd3-40fa-baa2-cfb30f19b2ef"),
                        Description = "Dolorem cum perspiciatis et eos ipsum et.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 25, 21, 1, 53, 329, DateTimeKind.Unspecified).AddTicks(5271),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "beatae",
                        Option = "One",
                        PhotoFileName = "applications.png",
                        Price = 0.089373685453496465931671455m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -1231283889,
                        Stock = -1016863508,
                        AmountOfPerson = 1231631390,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("2f7b033c-f279-4f82-b9ea-43ca405074d9"),
                        Description = "Atque recusandae natus quia vero.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 9, 22, 8, 57, 33, 959, DateTimeKind.Unspecified).AddTicks(4879),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "similique",
                        Option = "Two",
                        PhotoFileName = "jewelery__electronics_&_toys_bricks_and_clicks_beauty__computers_&_jewelery.mp4v",
                        Price = 0.6173544423926818371749368141m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -1875730459,
                        Stock = 1511888505,
                        AmountOfPerson = -1715834157,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("f94887b9-b361-43c5-993e-c813f1da65f1"),
                        Description = "Libero adipisci aut ea vitae eaque asperiores voluptate excepturi aspernatur.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 27, 17, 42, 43, 549, DateTimeKind.Unspecified).AddTicks(8652),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quia",
                        Option = "Three",
                        PhotoFileName = "manager_product.gif",
                        Price = 0.2488905281693736930337196107m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -1088836768,
                        Stock = -1316793636,
                        AmountOfPerson = -1241978338,
                        KayakType = "Diving"
                    },
                    new
                    {
                        Id = new Guid("9ec2829b-b886-4cea-b043-d83a2ed6dda9"),
                        Description = "Possimus temporibus tempora enim.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 19, 9, 56, 48, 792, DateTimeKind.Unspecified).AddTicks(5775),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "ipsa",
                        Option = "Three",
                        PhotoFileName = "nebraska.wav",
                        Price = 0.7322938051966443495786153203m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -371803610,
                        Stock = -208656596,
                        AmountOfPerson = 1630936127,
                        KayakType = "Fishing"
                    },
                    new
                    {
                        Id = new Guid("974aec2b-8af8-4e99-9fa7-83fd0b8f6ac4"),
                        Description = "Qui id atque animi repellat accusantium rerum omnis.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 16, 9, 43, 4, 615, DateTimeKind.Unspecified).AddTicks(412),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "rem",
                        Option = "One",
                        PhotoFileName = "time_frame_fundamental_dominican_peso.mpeg",
                        Price = 0.4251337406622304121239440878m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -491160855,
                        Stock = -1422928677,
                        AmountOfPerson = -210380339,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("067f119f-7483-4d72-aed5-2c6c2fc223bc"),
                        Description = "Et quas provident nemo qui libero recusandae.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 18, 8, 4, 44, 913, DateTimeKind.Unspecified).AddTicks(5205),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "molestias",
                        Option = "One",
                        PhotoFileName = "home_loan_account_com_copy.pdf",
                        Price = 0.4316541080039625133505840214m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 400581836,
                        Stock = -1544953230,
                        AmountOfPerson = -1799529560,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("47936001-bc70-4353-a72a-915c1895bef8"),
                        Description = "Quibusdam et animi.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 20, 7, 49, 44, 976, DateTimeKind.Unspecified).AddTicks(1460),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "maiores",
                        Option = "Two",
                        PhotoFileName = "credit_card_account_money_market_account.gif",
                        Price = 0.4312770143238726008739507009m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1613111836,
                        Stock = 1583438951,
                        AmountOfPerson = -1962795588,
                        KayakType = "Fishing"
                    },
                    new
                    {
                        Id = new Guid("aabc40e3-c0f5-4ca5-a727-99e70a944117"),
                        Description = "Iure voluptatem alias dicta laudantium quod unde eum tempore necessitatibus.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 27, 1, 9, 18, 884, DateTimeKind.Unspecified).AddTicks(7380),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "nulla",
                        Option = "One",
                        PhotoFileName = "concrete.jpg",
                        Price = 0.1367542966043783972279005119m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 1329206501,
                        Stock = 1018267976,
                        AmountOfPerson = -880232562,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("468a7997-8f90-4c86-95f0-c2326491caee"),
                        Description = "Sunt quo nulla similique ut iste aut.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 6, 6, 1, 16, 35, 51, DateTimeKind.Unspecified).AddTicks(8872),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quo",
                        Option = "Three",
                        PhotoFileName = "background_scalable_transmit.mpg4",
                        Price = 0.1771523967890245337412355306m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -1785280163,
                        Stock = 193559004,
                        AmountOfPerson = -1692664358,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("80e2d467-97e3-441f-b706-854dc03f3abc"),
                        Description = "Quibusdam aut provident omnis mollitia accusamus sed iste minima.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 3, 3, 50, 21, 905, DateTimeKind.Unspecified).AddTicks(4564),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "vel",
                        Option = "Three",
                        PhotoFileName = "uganda.mp2",
                        Price = 0.1889454524169042147015520895m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1065464601,
                        Stock = 561613094,
                        AmountOfPerson = 2058513890,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("3dd6940c-0ef6-4a7b-9828-2bd547f4ef63"),
                        Description = "Voluptatem et sit perferendis eum quia quos.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 17, 20, 37, 50, 195, DateTimeKind.Unspecified).AddTicks(5633),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "commodi",
                        Option = "Two",
                        PhotoFileName = "metal_tasty_soft_car_well_modulated.mp2",
                        Price = 0.0071423201977937362390715658m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 959520674,
                        Stock = 1167260873,
                        AmountOfPerson = 1421235444,
                        KayakType = "Diving"
                    },
                    new
                    {
                        Id = new Guid("0a1d3eb7-a402-4dfa-9111-a0578399602a"),
                        Description = "Dicta et cumque quidem tenetur.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 18, 3, 10, 43, 827, DateTimeKind.Unspecified).AddTicks(2923),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "maiores",
                        Option = "Two",
                        PhotoFileName = "deposit_web_services_input.jpe",
                        Price = 0.6047768889989517234993308153m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1090276397,
                        Stock = 1509817141,
                        AmountOfPerson = 550084079,
                        KayakType = "Fishing"
                    },
                    new
                    {
                        Id = new Guid("4cd09b1d-37ba-44e7-8daa-35e457f92546"),
                        Description = "Voluptas sint sunt ea et dolor sit dolorum.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 15, 15, 26, 10, 79, DateTimeKind.Unspecified).AddTicks(8733),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "velit",
                        Option = "Three",
                        PhotoFileName = "balanced_cape_intranet.gif",
                        Price = 0.5307557022824415931784704151m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 875352586,
                        Stock = 46539286,
                        AmountOfPerson = -364643613,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("f722234b-630e-45fb-b98f-f5fa7090e295"),
                        Description = "Vero blanditiis sequi ea velit in.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 27, 1, 34, 28, 596, DateTimeKind.Unspecified).AddTicks(1129),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "laudantium",
                        Option = "Three",
                        PhotoFileName = "sleek_fresh_cheese_books__clothing_&_health.pdf",
                        Price = 0.0603431855455038323371633823m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 2041124470,
                        Stock = 458849584,
                        AmountOfPerson = 1943095001,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("a1066d49-6f28-45b0-974a-6eba986b7fe6"),
                        Description = "Neque consequatur soluta enim velit sunt maxime ut voluptates est.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 10, 8, 23, 17, 28, 460, DateTimeKind.Unspecified).AddTicks(6674),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "laudantium",
                        Option = "Three",
                        PhotoFileName = "fantastic_handmade_concrete_chair_neural_net.mpg",
                        Price = 0.3781487497438183630310599363m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -1210240922,
                        Stock = -1353186641,
                        AmountOfPerson = -1721306815,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("2c05b59b-8fb3-4cba-8698-01d55a0284e5"),
                        Description = "Deleniti voluptas quidem accusamus est debitis quisquam enim.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 11, 4, 16, 6, 44, 784, DateTimeKind.Unspecified).AddTicks(1480),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "libero",
                        Option = "Three",
                        PhotoFileName = "focused_neural.mp3",
                        Price = 0.0683409603672507719601089492m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -1864067132,
                        Stock = 1918868593,
                        AmountOfPerson = -1181711469,
                        KayakType = "Diving"
                    },
                    new
                    {
                        Id = new Guid("938ab1da-b683-4cfe-9b17-189a8c4b44ae"),
                        Description = "Est voluptate expedita odio molestiae quaerat.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 12, 23, 34, 11, 736, DateTimeKind.Unspecified).AddTicks(4790),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "nesciunt",
                        Option = "Three",
                        PhotoFileName = "context_sensitive_extended_gorgeous_frozen_computer.jpeg",
                        Price = 0.6950905659417237985335122352m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = 2078191345,
                        Stock = -338771637,
                        AmountOfPerson = -348050752,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("65344f10-b8e7-40b0-9751-1b44e189d4f2"),
                        Description = "Voluptatibus dolor quidem voluptas modi quia et aut ut.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 31, 20, 58, 11, 148, DateTimeKind.Unspecified).AddTicks(1581),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "incidunt",
                        Option = "Three",
                        PhotoFileName = "investment_account_engage.mp4",
                        Price = 0.0974629020548714511830649633m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 362600992,
                        Stock = -923396809,
                        AmountOfPerson = 837835994,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("ee3c878e-2dde-4ff5-b005-3fc1c9f61d3c"),
                        Description = "A voluptate eligendi quae.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 24, 13, 41, 42, 925, DateTimeKind.Unspecified).AddTicks(1241),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "qui",
                        Option = "Three",
                        PhotoFileName = "connecting.gif",
                        Price = 0.6298231094405011058412803268m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -365564294,
                        Stock = 385063832,
                        AmountOfPerson = -1487121181,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("fbd4315c-6731-4a0a-869e-ef2263eee171"),
                        Description = "Ut reprehenderit et voluptatem.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 18, 22, 43, 58, 842, DateTimeKind.Unspecified).AddTicks(4148),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "voluptatem",
                        Option = "Two",
                        PhotoFileName = "ergonomic_serbian_dinar.gif",
                        Price = 0.2012135754440516725053311953m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = -1161992328,
                        Stock = -1752731623,
                        AmountOfPerson = 1829994510,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("cbcb7930-6bd5-4334-bfa8-3c57cb74456d"),
                        Description = "Voluptas itaque omnis error odit cumque vel.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 8, 5, 9, 52, 27, 405, DateTimeKind.Unspecified).AddTicks(9862),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "quis",
                        Option = "Two",
                        PhotoFileName = "metal.jpg",
                        Price = 0.3875231454819833773544141473m,
                        ProductTypeId = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806"),
                        Rating = 1039789038,
                        Stock = -1604669546,
                        AmountOfPerson = -599441755,
                        KayakType = "Racing"
                    },
                    new
                    {
                        Id = new Guid("58493329-dbb8-44a9-bfea-0579371d222a"),
                        Description = "Enim aspernatur laborum.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 5, 2, 1, 22, 43, 66, DateTimeKind.Unspecified).AddTicks(9424),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "amet",
                        Option = "Three",
                        PhotoFileName = "copying.png",
                        Price = 0.8148728042354251714332925288m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1209674041,
                        Stock = -962260873,
                        AmountOfPerson = -1801358254,
                        KayakType = "Camping"
                    },
                    new
                    {
                        Id = new Guid("420328ec-d741-4e70-b790-ed90c40e6bc7"),
                        Description = "Nihil tempore recusandae iusto sunt eum laudantium rerum.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 12, 13, 9, 49, 106, DateTimeKind.Unspecified).AddTicks(2929),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "fuga",
                        Option = "One",
                        PhotoFileName = "balanced_handmade_cotton_chips_orchid.wav",
                        Price = 0.1569143055587204359658550854m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1927418208,
                        Stock = -2138511333,
                        AmountOfPerson = -265109205,
                        KayakType = "Family"
                    },
                    new
                    {
                        Id = new Guid("7f2a0173-c8b6-48d0-b876-07d01bc1adc3"),
                        Description = "Repudiandae et facere.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2020, 12, 29, 3, 27, 40, 737, DateTimeKind.Unspecified).AddTicks(1403),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "illum",
                        Option = "One",
                        PhotoFileName = "beauty_program_value_added.mpeg",
                        Price = 0.5126598415108057877490054231m,
                        ProductTypeId = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c"),
                        Rating = -1885905060,
                        Stock = 1806682452,
                        AmountOfPerson = 85976659,
                        KayakType = "Fishing"
                    },
                    new
                    {
                        Id = new Guid("7588bc9b-c666-4a6a-9fee-a0529141dba5"),
                        Description = "Non ipsam veritatis ipsum animi ab quo quia omnis qui.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 2, 12, 19, 52, 33, 984, DateTimeKind.Unspecified).AddTicks(9536),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "inventore",
                        Option = "Two",
                        PhotoFileName = "strategist_haptic_complexity.jpe",
                        Price = 0.5931622725976657329548495888m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 580070474,
                        Stock = -1795151752,
                        AmountOfPerson = 2127981441,
                        KayakType = "Racing"
                    },
                    new
                    {
                        Id = new Guid("d2c02466-61b7-47c6-874f-9bbc7c218671"),
                        Description = "Id dolores quia esse sunt occaecati molestiae eos commodi.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 1, 30, 21, 43, 24, 907, DateTimeKind.Unspecified).AddTicks(2917),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "debitis",
                        Option = "Three",
                        PhotoFileName = "bandwidth_pink.gif",
                        Price = 0.3103994834884257120203480145m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = -809805859,
                        Stock = -427706335,
                        AmountOfPerson = 617151944,
                        KayakType = "Racing"
                    },
                    new
                    {
                        Id = new Guid("ccc4e556-f26c-43d3-9d4b-5c106017518a"),
                        Description = "Culpa et ipsum.",
                        IntroduceAt = new DateTimeOffset(new DateTime(2021, 4, 29, 5, 4, 51, 134, DateTimeKind.Unspecified).AddTicks(1587),
                            new TimeSpan(0, -3, 0, 0, 0)),
                        Name = "delectus",
                        Option = "Three",
                        PhotoFileName = "white.pdf",
                        Price = 0.2081374304192098983340432957m,
                        ProductTypeId = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40"),
                        Rating = 1045218399,
                        Stock = 469672924,
                        AmountOfPerson = -2119227045,
                        KayakType = "Family"
                    });
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.TypeOne", b =>
            {
                b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType");

                b.HasDiscriminator().HasValue("TypeOne");

                b.HasData(new
                {
                    Id = new Guid("b80d9a45-67b7-4184-a27e-768e73920b1c")
                });
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.TypeThree", b =>
            {
                b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType");

                b.HasDiscriminator().HasValue("TypeThree");

                b.HasData(new
                {
                    Id = new Guid("815954b2-93b4-4e30-9e30-c2d3a5074f40")
                });
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.TypeTwo", b =>
            {
                b.HasBaseType("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType");

                b.HasDiscriminator().HasValue("TypeTwo");

                b.HasData(new
                {
                    Id = new Guid("b7e06be6-60a4-4bcb-830b-160736d3f806")
                });
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.Entities.Products.Product", b =>
            {
                b.HasOne("Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes.ProductType", "ProductType")
                   .WithMany()
                   .HasForeignKey("ProductTypeId");
            });

            modelBuilder.Entity("Dotnet5.GraphQL.WebApplication.Domain.Entities.Review", b =>
            {
                b.HasOne("Dotnet5.GraphQL.WebApplication.Domain.Entities.Products.Product", "Product")
                   .WithMany()
                   .HasForeignKey("ProductId");
            });
#pragma warning restore 612, 618
        }
    }
}