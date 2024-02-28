using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auction.DataAccess.Data.Migrations
{
    /// <inheritdoc />
    public partial class PayentHistoryConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentIntentId",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8467), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8482), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8488), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8494), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8499), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8504), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8515), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8520), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8525), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8530), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8536), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8541), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8545), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8555), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8560), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8564), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8569), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8574), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8579), new DateTime(2024, 2, 28, 20, 4, 38, 803, DateTimeKind.Local).AddTicks(8578) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "PaymentHistories");

            migrationBuilder.DropColumn(
                name: "StripePaymentIntentId",
                table: "PaymentHistories");

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9246), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9256), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9265), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9269), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9274), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9278), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9282), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9286), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9290), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9294), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9298), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9340), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9344), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9348), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9353), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9357), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9361), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9365), new DateTime(2024, 2, 27, 14, 41, 0, 668, DateTimeKind.Local).AddTicks(9365) });
        }
    }
}
