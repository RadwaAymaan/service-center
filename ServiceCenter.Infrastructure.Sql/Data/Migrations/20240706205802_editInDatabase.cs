using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServiceCenter.Infrastructure.Sql.Data.Migrations
{
    /// <inheritdoc />
    public partial class editInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01da0fbc-81a8-4ca8-b6b4-5af4a3cfb48a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "078bf048-2cc4-4217-a500-07834ab7a1eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "469018bf-16c0-46a0-b45a-2a28d0e736b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "482f4aec-03c5-4c3f-b023-bce0229e90d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50343f79-87f0-413e-9272-319f9bf737d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85a423d3-9989-48f8-9802-41909297cad4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b00b2121-9fce-4a34-9f8c-84b6b47eb443");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7ad7c7c-6b0c-4780-8082-f49a648d6466");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef4cae78-b72f-4096-a3fd-c3da339d6054");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26b83568-b2fa-458d-80ea-ec6e97616665", null, "Admin", "ADMIN" },
                    { "37bcba15-5413-49e9-aa7b-a40989bdec52", null, "Vendor", "VENDOR" },
                    { "4232ef1e-a0cc-4a95-84df-e1ce43bee8dd", null, "WarehouseManager", "WAREHOUSEMANAGER" },
                    { "4c3a8fec-ed48-4e2c-888a-31deb74a5b1b", null, "Customer", "CUSTOMER" },
                    { "5d316e9b-b25b-44f6-b825-29f6e69205eb", null, "ServiceProvider", "SERVICEPROVIDER" },
                    { "83caa7dd-1715-46e2-853a-d714027f4f75", null, "Contact", "CONTACT" },
                    { "94f64d4e-90bb-45e2-8dc2-a95e8e67f25a", null, "Employee", "EMPLOYEE" },
                    { "b9591a96-c19f-4964-8e56-45c45983b6de", null, "Sales", "SALES" },
                    { "d0a3612d-fc0a-48e3-bbf1-67ea19f5fc16", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26b83568-b2fa-458d-80ea-ec6e97616665");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37bcba15-5413-49e9-aa7b-a40989bdec52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4232ef1e-a0cc-4a95-84df-e1ce43bee8dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c3a8fec-ed48-4e2c-888a-31deb74a5b1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d316e9b-b25b-44f6-b825-29f6e69205eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83caa7dd-1715-46e2-853a-d714027f4f75");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94f64d4e-90bb-45e2-8dc2-a95e8e67f25a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9591a96-c19f-4964-8e56-45c45983b6de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0a3612d-fc0a-48e3-bbf1-67ea19f5fc16");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01da0fbc-81a8-4ca8-b6b4-5af4a3cfb48a", null, "Contact", "CONTACT" },
                    { "078bf048-2cc4-4217-a500-07834ab7a1eb", null, "WarehouseManager", "WAREHOUSEMANAGER" },
                    { "469018bf-16c0-46a0-b45a-2a28d0e736b4", null, "Customer", "CUSTOMER" },
                    { "482f4aec-03c5-4c3f-b023-bce0229e90d6", null, "Sales", "SALES" },
                    { "50343f79-87f0-413e-9272-319f9bf737d6", null, "Employee", "EMPLOYEE" },
                    { "85a423d3-9989-48f8-9802-41909297cad4", null, "Admin", "ADMIN" },
                    { "b00b2121-9fce-4a34-9f8c-84b6b47eb443", null, "Manager", "MANAGER" },
                    { "e7ad7c7c-6b0c-4780-8082-f49a648d6466", null, "Vendor", "VENDOR" },
                    { "ef4cae78-b72f-4096-a3fd-c3da339d6054", null, "ServiceProvider", "SERVICEPROVIDER" }
                });
        }
    }
}
