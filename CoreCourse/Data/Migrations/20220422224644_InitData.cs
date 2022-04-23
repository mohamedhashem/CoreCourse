using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCourse.Data.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("1611b6e2-de3d-459f-8828-dfaf2123f71d"), "Cairo", "Cairo", "Google" });

            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("9eb5874f-2315-4afb-9bc9-200e348f94c8"), "London", "London", "Facebook" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("641c895d-683f-40af-b831-e7a4a8dea895"), 30, new Guid("1611b6e2-de3d-459f-8828-dfaf2123f71d"), "Mohamed", "Junior" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("49746903-1394-42bf-86fc-18c345cdc7e5"), 35, new Guid("1611b6e2-de3d-459f-8828-dfaf2123f71d"), "Ahmed", "Senior" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("c7bdbb9c-1b26-4deb-83a7-d411bcbe20e2"), 40, new Guid("9eb5874f-2315-4afb-9bc9-200e348f94c8"), "Ali", "Team Leader" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("49746903-1394-42bf-86fc-18c345cdc7e5"));

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("641c895d-683f-40af-b831-e7a4a8dea895"));

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("c7bdbb9c-1b26-4deb-83a7-d411bcbe20e2"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("1611b6e2-de3d-459f-8828-dfaf2123f71d"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("9eb5874f-2315-4afb-9bc9-200e348f94c8"));
        }
    }
}
