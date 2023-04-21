using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Updated_Color_Product_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("31d94986-70b3-431b-bb40-774928b9f007"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("825950d0-d776-40f8-8bbf-27595097ece6"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("3c5cd4ad-fb1d-4f0b-9d24-09722f32fc89"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("c0346c0f-746c-4169-ba36-504243d69aa9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("03b9802f-df6c-4045-a01f-de55b4c91f5a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0e728769-fe9d-4b3b-8234-957e1e5b4e68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1a707fcd-2475-4c3b-b383-13837fec7284"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("283e9df7-2cfe-4d08-9b79-1f3d20e40ab2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("293fe1c8-448b-481a-ba2b-09e1ced48bee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("316bc780-a724-41dd-a980-ba95e5ccb7cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("31f461b8-fe9a-426d-b3f8-b3135e2614d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3f73520b-ba2d-4b97-b6d3-85eefc9ce9bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("439b2b31-314c-417c-9de3-3dfc64bf686e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74d3c36c-e905-4829-aa05-10e3f761ab29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("75a0c1e5-5e74-40d9-a5e4-8abd0eca5e36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("75deab04-01a7-41a5-a940-44b93cf10e7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7b8d0e95-7aaa-42b8-af91-ac803e8990e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8897d7ad-70d3-4b69-a3ab-9e2d56f878b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("acceb126-484c-453c-8907-824f36a9dc7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b14d21be-06ff-440e-9a75-320aeb1ead1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b4d87117-ed95-422c-8a74-ae291b53a4da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d0d4403d-f886-47c0-b506-435d6930a816"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e3c930c1-840d-48d5-a59d-5b4cd3fe7ebb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e5f7ef87-21fe-4d0e-957d-8acd18e7ee24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e9d1cb62-e521-4cf3-8c48-223d2133a4d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ee0a3949-5998-4738-b4e8-3f2582ee65ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ee7a8001-1a12-4a4f-8a72-9bd3637acd72"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f596f47a-5b99-4164-b242-f0e97bd6aa7d"));

            migrationBuilder.DeleteData(
                table: "Showcases",
                keyColumn: "ShowcaseId",
                keyValue: new Guid("dc49879d-1e66-4846-83aa-7cfb135bf501"));

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("01646256-2a11-4cc7-8732-461a8e71f556"), null, "Admin", "ADMIN" },
                    { new Guid("219b0f7b-9b3d-44dc-8aef-046bc0b26789"), null, "ProductManager", "PRODUCTMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Comment", "Email", "FullName" },
                values: new object[,]
                {
                    { new Guid("46533124-5839-4376-99c6-fc13e0a5b351"), "WASSUP comment", "viktor@example.com", "Viktor Warelius" },
                    { new Guid("b3b8dd10-28cb-4f75-aa72-c8236f83a295"), "Hello Comment Here", "jajja@example.com", "Jajja Stahl Warelius" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "CategoryId", "Color", "Date", "Details", "ImageUrl", "Price", "Rating", "SKU", "Title" },
                values: new object[,]
                {
                    { new Guid("0bc08a7b-06b3-403c-a5ff-90596a4a090b"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), "Blue", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3500), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("1e720925-28fe-4071-b573-493b1784cf3e"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), "Blue", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3516), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("27fa4ecd-cb84-4ed2-9843-f17cdb671f84"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), "Blue", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3512), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("547bb988-2b02-4b1f-8257-06b1f9c1f9e3"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), "Red", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3554), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("5532c7a9-5d7b-4acc-abd4-07ae4b38fbe9"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), "Blue", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3504), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("5aaeac6f-56c2-4bff-a666-0ef277694c2a"), "Nike", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), "Black", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3472), "Details Here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Men%27s-Golf-Gilet-Dri-fit-Tour_MIDNIGHT-NAVY-WHITE_38e022aa-5_M1.png", 899.0, 4, 123456789, "Golf Jacket" },
                    { new Guid("5b17ad14-f0f5-4f51-a94c-40828f93357f"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), "Red", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3546), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("67b9768b-fb5b-4b7f-aeb3-1ce3d48547fd"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), "Blue", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3508), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("67c4a3cb-2bba-4bbd-a83b-86b6ff093e39"), "Peak Performance", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), "Black", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3445), "Awsome Sweather", "data:image/jpeg;base64,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", 250.0, 4, 12345678, "Sweatshirt" },
                    { new Guid("69afad6a-bf41-4f21-a771-3083be756e45"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), "Red", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3529), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("7055dfe9-4036-4470-9fb4-285dc7973f2f"), "Peak", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), "Black", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3463), "Jacka från hehe", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/371676_101_PEAK%20PERFORMANCE_W%20Down%20Ski%20Jacket.png", 1499.0, 3, 78945612, "Jacket" },
                    { new Guid("73a518d1-3b79-45d6-bdbc-0bb55208397c"), "Adidas", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), "Black", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3468), "Details Here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Adidas-Terrex-Liteflex-Hiking-Shorts_BLACK_da645177-7_M1.png", 699.0, 2, 12345678, "Shorts" },
                    { new Guid("7aabef9c-1354-4b24-9391-d6b001515e4a"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), "Blue", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3494), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("8e247a57-2aef-4843-a739-bd87d75af8c4"), "Adidas", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), "Black", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3488), "Details Here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Adidas-Run-60s-3.0-Shoes_CWHITE-CWHITE_6389441b-0.png", 649.0, 4, 12345678, "Shoes" },
                    { new Guid("9848e630-717f-4ad9-aa21-7dd06441808f"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), "Blue", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3520), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("a13c319b-0097-4e1f-820d-440fb7ca7cf2"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), "Red", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3525), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("ced0f8ee-7ef7-4c45-8e4d-6ea7acead434"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), "Red", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3534), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("d2751441-e73e-4ce6-bea2-35e54b3e3ac2"), "Stadium", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), "Black", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3452), "HEHE", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/351947_105_NIKE_W%20COURT%20VISION%20LOW.png", 999.0, 5, 12345678, "Nike Shoes" },
                    { new Guid("dd9ce194-721b-4ee1-8cb5-75c49a20f88e"), "Adidas", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), "Black", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3480), "Details here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Adidas-Vl-Court-2.0-Shoes_CLOUD-WHITE---CORE-BLACK---CORE-BLACK_b52f6e50-5.png", 699.0, 3, 12345678, "Shoes" },
                    { new Guid("e02516d0-2b54-4304-bb81-e04c2895340d"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), "Red", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3550), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("e9dd20ad-7f37-46aa-9a9c-f8e0e6172103"), "Adidas", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), "Black", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3476), "Details Here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Adidas-Adventure-Fc-Reversible-Polar-Half-Zip-Jacket_WONDER-WHITE---DARK-GREEN_87d905d5-1_M1.png", 1399.0, 5, 12345678, "Sweather" },
                    { new Guid("e9fb9f3b-c8a8-4114-ab30-3fa2c637620b"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), "Red", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3538), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("fa26762d-1e71-48f5-b317-5c052cbd6fea"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), "Red", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3542), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("fa7f47dc-8ade-4aec-beaa-23511443c22c"), "Nike", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), "Black", new DateTime(2023, 4, 17, 14, 25, 47, 192, DateTimeKind.Local).AddTicks(3484), "Details Here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Men%27s-Golf-Polo-Dri-fit-Victory_WHITE-BLACK_7675ed4d-7_M1.png", 449.0, 2, 123456789, "Golf Polo" }
                });

            migrationBuilder.InsertData(
                table: "Showcases",
                columns: new[] { "ShowcaseId", "ButtonText", "Date", "DeliveryText", "ImageUrl", "Ingress", "Title" },
                values: new object[] { new Guid("4c1708df-bea0-4f60-924f-cb78a0aa7e35"), "SHOP NOW", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Online Shopping free home delivery over $100", "images/showcase-img.png", "Don't Miss This Opportunity", "GET UP TO 40% OFF" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("01646256-2a11-4cc7-8732-461a8e71f556"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("219b0f7b-9b3d-44dc-8aef-046bc0b26789"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("46533124-5839-4376-99c6-fc13e0a5b351"));

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: new Guid("b3b8dd10-28cb-4f75-aa72-c8236f83a295"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0bc08a7b-06b3-403c-a5ff-90596a4a090b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1e720925-28fe-4071-b573-493b1784cf3e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27fa4ecd-cb84-4ed2-9843-f17cdb671f84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("547bb988-2b02-4b1f-8257-06b1f9c1f9e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5532c7a9-5d7b-4acc-abd4-07ae4b38fbe9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5aaeac6f-56c2-4bff-a666-0ef277694c2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5b17ad14-f0f5-4f51-a94c-40828f93357f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("67b9768b-fb5b-4b7f-aeb3-1ce3d48547fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("67c4a3cb-2bba-4bbd-a83b-86b6ff093e39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("69afad6a-bf41-4f21-a771-3083be756e45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7055dfe9-4036-4470-9fb4-285dc7973f2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("73a518d1-3b79-45d6-bdbc-0bb55208397c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7aabef9c-1354-4b24-9391-d6b001515e4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8e247a57-2aef-4843-a739-bd87d75af8c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9848e630-717f-4ad9-aa21-7dd06441808f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a13c319b-0097-4e1f-820d-440fb7ca7cf2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ced0f8ee-7ef7-4c45-8e4d-6ea7acead434"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2751441-e73e-4ce6-bea2-35e54b3e3ac2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dd9ce194-721b-4ee1-8cb5-75c49a20f88e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e02516d0-2b54-4304-bb81-e04c2895340d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e9dd20ad-7f37-46aa-9a9c-f8e0e6172103"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e9fb9f3b-c8a8-4114-ab30-3fa2c637620b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fa26762d-1e71-48f5-b317-5c052cbd6fea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fa7f47dc-8ade-4aec-beaa-23511443c22c"));

            migrationBuilder.DeleteData(
                table: "Showcases",
                keyColumn: "ShowcaseId",
                keyValue: new Guid("4c1708df-bea0-4f60-924f-cb78a0aa7e35"));

            migrationBuilder.AlterColumn<int>(
                name: "Color",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("31d94986-70b3-431b-bb40-774928b9f007"), null, "Admin", "ADMIN" },
                    { new Guid("825950d0-d776-40f8-8bbf-27595097ece6"), null, "ProductManager", "PRODUCTMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Comment", "Email", "FullName" },
                values: new object[,]
                {
                    { new Guid("3c5cd4ad-fb1d-4f0b-9d24-09722f32fc89"), "WASSUP comment", "viktor@example.com", "Viktor Warelius" },
                    { new Guid("c0346c0f-746c-4169-ba36-504243d69aa9"), "Hello Comment Here", "jajja@example.com", "Jajja Stahl Warelius" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "CategoryId", "Color", "Date", "Details", "ImageUrl", "Price", "Rating", "SKU", "Title" },
                values: new object[,]
                {
                    { new Guid("03b9802f-df6c-4045-a01f-de55b4c91f5a"), "Peak Performance", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(247), "Awsome Sweather", "data:image/jpeg;base64,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", 250.0, 4, 12345678, "Sweatshirt" },
                    { new Guid("0e728769-fe9d-4b3b-8234-957e1e5b4e68"), "Nike", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(299), "Details Here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Men%27s-Golf-Polo-Dri-fit-Victory_WHITE-BLACK_7675ed4d-7_M1.png", 449.0, 2, 123456789, "Golf Polo" },
                    { new Guid("1a707fcd-2475-4c3b-b383-13837fec7284"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(323), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("283e9df7-2cfe-4d08-9b79-1f3d20e40ab2"), "Nike", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), 0, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(279), "Details Here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Men%27s-Golf-Gilet-Dri-fit-Tour_MIDNIGHT-NAVY-WHITE_38e022aa-5_M1.png", 899.0, 4, 123456789, "Golf Jacket" },
                    { new Guid("293fe1c8-448b-481a-ba2b-09e1ced48bee"), "Adidas", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), 2, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(293), "Details here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Adidas-Vl-Court-2.0-Shoes_CLOUD-WHITE---CORE-BLACK---CORE-BLACK_b52f6e50-5.png", 699.0, 3, 12345678, "Shoes" },
                    { new Guid("316bc780-a724-41dd-a980-ba95e5ccb7cd"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(348), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("31f461b8-fe9a-426d-b3f8-b3135e2614d2"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(342), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("3f73520b-ba2d-4b97-b6d3-85eefc9ce9bf"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), 0, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(329), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("439b2b31-314c-417c-9de3-3dfc64bf686e"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(355), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("74d3c36c-e905-4829-aa05-10e3f761ab29"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(335), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("75a0c1e5-5e74-40d9-a5e4-8abd0eca5e36"), "Adidas", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(273), "Details Here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Adidas-Terrex-Liteflex-Hiking-Shorts_BLACK_da645177-7_M1.png", 699.0, 2, 12345678, "Shorts" },
                    { new Guid("75deab04-01a7-41a5-a940-44b93cf10e7c"), "Adidas", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(305), "Details Here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Adidas-Run-60s-3.0-Shoes_CWHITE-CWHITE_6389441b-0.png", 649.0, 4, 12345678, "Shoes" },
                    { new Guid("7b8d0e95-7aaa-42b8-af91-ac803e8990e8"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), 0, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(360), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("8897d7ad-70d3-4b69-a3ab-9e2d56f878b0"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(312), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("acceb126-484c-453c-8907-824f36a9dc7c"), "The North Face", new Guid("e9506723-cc8e-42a8-94b2-c3b168fe1cae"), 2, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(317), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("b14d21be-06ff-440e-9a75-320aeb1ead1a"), "Peak", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), 0, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(266), "Jacka från hehe", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/371676_101_PEAK%20PERFORMANCE_W%20Down%20Ski%20Jacket.png", 1499.0, 3, 78945612, "Jacket" },
                    { new Guid("b4d87117-ed95-422c-8a74-ae291b53a4da"), "Adidas", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(285), "Details Here", "https://storacprodmarketplace.blob.core.windows.net/imageservice-processed/Detail_Adidas-Adventure-Fc-Reversible-Polar-Half-Zip-Jacket_WONDER-WHITE---DARK-GREEN_87d905d5-1_M1.png", 1399.0, 5, 12345678, "Sweather" },
                    { new Guid("d0d4403d-f886-47c0-b506-435d6930a816"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), 0, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(366), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("e3c930c1-840d-48d5-a59d-5b4cd3fe7ebb"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), 0, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(371), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("e5f7ef87-21fe-4d0e-957d-8acd18e7ee24"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), 2, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(390), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("e9d1cb62-e521-4cf3-8c48-223d2133a4d5"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), 2, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(396), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("ee0a3949-5998-4738-b4e8-3f2582ee65ce"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), 2, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(383), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" },
                    { new Guid("ee7a8001-1a12-4a4f-8a72-9bd3637acd72"), "Stadium", new Guid("97c46e14-e748-4582-ae15-60cc95bdf6b0"), 2, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(258), "HEHE", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/351947_105_NIKE_W%20COURT%20VISION%20LOW.png", 999.0, 5, 12345678, "Nike Shoes" },
                    { new Guid("f596f47a-5b99-4164-b242-f0e97bd6aa7d"), "The North Face", new Guid("b670c668-dbae-4a24-b73e-20ff0868a41a"), 1, new DateTime(2023, 4, 17, 14, 19, 52, 99, DateTimeKind.Local).AddTicks(377), "Details Here", "https://www.stadium.se/INTERSHOP/static/WFS/Stadium-SwedenB2C-Site/-/Stadium/sv_SE/Detail/370867_102_THE%20NORTH%20FACE_M%20CEPTOR%20JKT.png", 649.0, 4, 12345678, "Jacket" }
                });

            migrationBuilder.InsertData(
                table: "Showcases",
                columns: new[] { "ShowcaseId", "ButtonText", "Date", "DeliveryText", "ImageUrl", "Ingress", "Title" },
                values: new object[] { new Guid("dc49879d-1e66-4846-83aa-7cfb135bf501"), "SHOP NOW", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Online Shopping free home delivery over $100", "images/showcase-img.png", "Don't Miss This Opportunity", "GET UP TO 40% OFF" });
        }
    }
}
