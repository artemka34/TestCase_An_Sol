using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class fillDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Разработчики");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Юристы" },
                    { 3, "Начальники" },
                    { 4, "Реальные работники" },
                    { 5, "Эйчарочки" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Salary" },
                values: new object[] { "Саша Девопсов", 100500.0 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Name", "Salary" },
                values: new object[,]
                {
                    { 2, 1, "Миша Тестин", 12345.999089999999 },
                    { 3, 1, "Артур Джунов", 40000.0 },
                    { 4, 1, "Семен Мидлин", 100000.0 },
                    { 5, 1, "Денис Апачин", 120000.0 },
                    { 6, 1, "Максим Сишарпин", 150000.0 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Name", "Salary" },
                values: new object[,]
                {
                    { 7, 2, "Роман Таймсньюмов", 100500.0 },
                    { 28, 5, "Татьяна Телеграмина", 106000.0 },
                    { 27, 5, "Марина Хедхантеровна", 110000.0 },
                    { 26, 5, "Алина Вайберова", 86000.0 },
                    { 25, 5, "Екатерина Вацапова", 90000.0 },
                    { 24, 4, "Георгий Нерабочев", 30000.0 },
                    { 23, 4, "Виктор Рабочев", 54000.0 },
                    { 22, 4, "Иван Иванов", 59000.0 },
                    { 21, 4, "Василина Пупкина", 49999.0 },
                    { 20, 4, "Братвася Пупкин", 45000.0 },
                    { 19, 4, "Вася Пупкин", 50000.0 },
                    { 18, 3, "Никита Стажёров", 40000.0 },
                    { 17, 3, "Михаил Победоносный", 90000.0 },
                    { 16, 3, "Олег Итуттоженачальников", 120000.0 },
                    { 15, 3, "Саша Секретарева", 100500.0 },
                    { 14, 3, "Никита Замглавов", 200500.0 },
                    { 13, 3, "Дима Главный", 300500.0 },
                    { 12, 2, "Ваня Студентов", 40000.0 },
                    { 11, 2, "Ярослав Посадилин", 90000.0 },
                    { 10, 2, "Олег Тожеадвокатов", 120000.0 },
                    { 9, 2, "Настя Судова", 132000.0 },
                    { 8, 2, "Зина Адвокатова", 140000.0 },
                    { 29, 5, "Арина Топмесяцевна", 130000.0 },
                    { 30, 5, "Лера Последняя", 99999.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Development");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Salary" },
                values: new object[] { "", 1000.0 });
        }
    }
}
