using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreProject.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_productImages",
                table: "productImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.EnsureSchema(
                name: "asdas");

            migrationBuilder.RenameTable(
                name: "productImages",
                newName: "ProductImage",
                newSchema: "asdas");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "categsories");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                schema: "asdas",
                table: "ProductImage",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "asdas",
                table: "ProductImage",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "categsories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImage",
                schema: "asdas",
                table: "ProductImage",
                columns: new[] { "ImageUrl", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_categsories",
                table: "categsories",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImage",
                schema: "asdas",
                table: "ProductImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categsories",
                table: "categsories");

            migrationBuilder.RenameTable(
                name: "ProductImage",
                schema: "asdas",
                newName: "productImages");

            migrationBuilder.RenameTable(
                name: "categsories",
                newName: "categories");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "productImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "productImages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_productImages",
                table: "productImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "Id");
        }
    }
}
