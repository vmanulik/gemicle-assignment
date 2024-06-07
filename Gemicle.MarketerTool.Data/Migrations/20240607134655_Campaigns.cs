using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gemicle.MarketerTool.Data.Migrations
{
    /// <inheritdoc />
    public partial class Campaigns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaign",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Template = table.Column<int>(type: "INTEGER", nullable: false),
                    Time = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    PredicateJson = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Campaign",
                columns: new[] { "Id", "PredicateJson", "Priority", "Template", "Time" },
                values: new object[,]
                {
                    { 1L, "{\"__type\":\"LambdaExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":18,\"Type\":{\"GenericArguments\":[{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},{\"Name\":\"System.Boolean\"}],\"Name\":\"System.Func`2\"},\"Body\":{\"__type\":\"BinaryExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":13,\"Type\":{\"Name\":\"System.Boolean\"},\"Left\":{\"__type\":\"UnaryExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":10,\"Type\":{\"Name\":\"System.Int32\"},\"Operand\":{\"__type\":\"MemberExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":23,\"Type\":{\"Name\":\"Gemicle.MarketerTool.Domain.Gender\"},\"Expression\":{\"__type\":\"ParameterExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":38,\"Type\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Name\":\"customer\"},\"Member\":{\"DeclaringType\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Signature\":\"Gemicle.MarketerTool.Domain.Gender Gender\"}}},\"Method\":{},\"Right\":{\"__type\":\"ConstantExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":9,\"Type\":{\"Name\":\"System.Int32\"},\"Value\":1}},\"Parameters\":[{\"__type\":\"ParameterExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":38,\"Type\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Name\":\"customer\"}]}", 1, 0, new TimeSpan(0, 10, 15, 0, 0) },
                    { 2L, "{\"__type\":\"LambdaExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":18,\"Type\":{\"GenericArguments\":[{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},{\"Name\":\"System.Boolean\"}],\"Name\":\"System.Func`2\"},\"Body\":{\"__type\":\"BinaryExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":15,\"Type\":{\"Name\":\"System.Boolean\"},\"Left\":{\"__type\":\"MemberExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":23,\"Type\":{\"Name\":\"System.Int32\"},\"Expression\":{\"__type\":\"ParameterExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":38,\"Type\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Name\":\"customer\"},\"Member\":{\"DeclaringType\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Signature\":\"Int32 Age\"}},\"Method\":{},\"Right\":{\"__type\":\"ConstantExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":9,\"Type\":{\"Name\":\"System.Int32\"},\"Value\":45}},\"Parameters\":[{\"__type\":\"ParameterExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":38,\"Type\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Name\":\"customer\"}]}", 2, 1, new TimeSpan(0, 10, 5, 0, 0) },
                    { 3L, "{\"__type\":\"LambdaExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":18,\"Type\":{\"GenericArguments\":[{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},{\"Name\":\"System.Boolean\"}],\"Name\":\"System.Func`2\"},\"Body\":{\"__type\":\"BinaryExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":13,\"Type\":{\"Name\":\"System.Boolean\"},\"Left\":{\"__type\":\"MemberExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":23,\"Type\":{\"Name\":\"System.String\"},\"Expression\":{\"__type\":\"ParameterExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":38,\"Type\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Name\":\"customer\"},\"Member\":{\"DeclaringType\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Signature\":\"System.String City\"}},\"Method\":{\"DeclaringType\":{\"Name\":\"System.String\"},\"Signature\":\"Boolean op_Equality(System.String, System.String)\"},\"Right\":{\"__type\":\"ConstantExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":9,\"Type\":{\"Name\":\"System.String\"},\"Value\":\"New York\"}},\"Parameters\":[{\"__type\":\"ParameterExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":38,\"Type\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Name\":\"customer\"}]}", 5, 2, new TimeSpan(0, 10, 15, 0, 0) },
                    { 4L, "{\"__type\":\"LambdaExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":18,\"Type\":{\"GenericArguments\":[{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},{\"Name\":\"System.Boolean\"}],\"Name\":\"System.Func`2\"},\"Body\":{\"__type\":\"BinaryExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":15,\"Type\":{\"Name\":\"System.Boolean\"},\"Left\":{\"__type\":\"MemberExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":23,\"Type\":{\"Name\":\"System.Decimal\"},\"Expression\":{\"__type\":\"ParameterExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":38,\"Type\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Name\":\"customer\"},\"Member\":{\"DeclaringType\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Signature\":\"System.Decimal Deposite\"}},\"Method\":{\"DeclaringType\":{\"Name\":\"System.Decimal\"},\"Signature\":\"Boolean op_GreaterThan(System.Decimal, System.Decimal)\"},\"Right\":{\"__type\":\"ConstantExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":9,\"Type\":{\"Name\":\"System.Decimal\"},\"Value\":100}},\"Parameters\":[{\"__type\":\"ParameterExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":38,\"Type\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Name\":\"customer\"}]}", 3, 0, new TimeSpan(0, 10, 15, 0, 0) },
                    { 5L, "{\"__type\":\"LambdaExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":18,\"Type\":{\"GenericArguments\":[{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},{\"Name\":\"System.Boolean\"}],\"Name\":\"System.Func`2\"},\"Body\":{\"__type\":\"MemberExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":23,\"Type\":{\"Name\":\"System.Boolean\"},\"Expression\":{\"__type\":\"ParameterExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":38,\"Type\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Name\":\"customer\"},\"Member\":{\"DeclaringType\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Signature\":\"Boolean IsNewCustomer\"}},\"Parameters\":[{\"__type\":\"ParameterExpressionNode:#Serialize.Linq.Nodes\",\"NodeType\":38,\"Type\":{\"Name\":\"Gemicle.MarketerTool.Domain.Customer\"},\"Name\":\"customer\"}]}", 4, 2, new TimeSpan(0, 10, 5, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campaign");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
