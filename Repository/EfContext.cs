using System.Threading.Tasks;
using Domain;
using Domain.Departments;
using Domain.Employees;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class EfContext : DbContext, IEfContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public EfContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department[]
                {
                    new Department()
                    {
                        Id = 1,
                        Name = "Разработчики"
                    },
                    new Department()
                    {
                        Id = 2,
                        Name = "Юристы"
                    },
                    new Department()
                    {
                        Id = 3,
                        Name = "Начальники"
                    },
                    new Department()
                    {
                        Id = 4,
                        Name = "Реальные работники"
                    },
                    new Department()
                    {
                        Id = 5,
                        Name = "Эйчарочки"
                    }
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee[]
                {
                    new Employee()
                    {
                        Id = 1,
                        Name = "Саша Девопсов",
                        Salary = 100500,
                        DepartmentId = 1
                    },
                    new Employee()
                    {
                        Id = 2,
                        Name = "Миша Тестин",
                        Salary = 12345.99909,
                        DepartmentId = 1
                    },
                    new Employee()
                    {
                        Id = 3,
                        Name = "Артур Джунов",
                        Salary = 40000,
                        DepartmentId = 1
                    },
                    new Employee()
                    {
                        Id = 4,
                        Name = "Семен Мидлин",
                        Salary = 100000,
                        DepartmentId = 1
                    },
                    new Employee()
                    {
                        Id = 5,
                        Name = "Денис Апачин",
                        Salary = 120000,
                        DepartmentId = 1
                    },
                    new Employee()
                    {
                        Id = 6,
                        Name = "Максим Сишарпин",
                        Salary = 150000,
                        DepartmentId = 1
                    },
                    
                    new Employee()
                    {
                        Id = 7,
                        Name = "Роман Таймсньюмов",
                        Salary = 100500,
                        DepartmentId = 2
                    },
                    new Employee()
                    {
                        Id = 8,
                        Name = "Зина Адвокатова",
                        Salary = 140000,
                        DepartmentId = 2
                    },
                    new Employee()
                    {
                        Id = 9,
                        Name = "Настя Судова",
                        Salary = 132000,
                        DepartmentId = 2
                    },
                    new Employee()
                    {
                        Id = 10,
                        Name = "Олег Тожеадвокатов",
                        Salary = 120000,
                        DepartmentId = 2
                    },
                    new Employee()
                    {
                        Id = 11,
                        Name = "Ярослав Посадилин",
                        Salary = 90000,
                        DepartmentId = 2
                    },
                    new Employee()
                    {
                        Id = 12,
                        Name = "Ваня Студентов",
                        Salary = 40000,
                        DepartmentId = 2
                    },
                    
                    
                    new Employee()
                    {
                        Id = 13,
                        Name = "Дима Главный",
                        Salary = 300500,
                        DepartmentId = 3
                    },
                    new Employee()
                    {
                        Id = 14,
                        Name = "Никита Замглавов",
                        Salary = 200500,
                        DepartmentId = 3
                    },
                    new Employee()
                    {
                        Id = 15,
                        Name = "Саша Секретарева",
                        Salary = 100500,
                        DepartmentId = 3
                    },
                    new Employee()
                    {
                        Id = 16,
                        Name = "Олег Итуттоженачальников",
                        Salary = 120000,
                        DepartmentId = 3
                    },
                    new Employee()
                    {
                        Id = 17,
                        Name = "Михаил Победоносный",
                        Salary = 90000,
                        DepartmentId = 3
                    },
                    new Employee()
                    {
                        Id = 18,
                        Name = "Никита Стажёров",
                        Salary = 40000,
                        DepartmentId = 3
                    },
                    
                    
                    new Employee()
                    {
                        Id = 19,
                        Name = "Вася Пупкин",
                        Salary = 50000,
                        DepartmentId = 4
                    },
                    new Employee()
                    {
                        Id = 20,
                        Name = "Братвася Пупкин",
                        Salary = 45000,
                        DepartmentId = 4
                    },
                    new Employee()
                    {
                        Id = 21,
                        Name = "Василина Пупкина",
                        Salary = 49999,
                        DepartmentId = 4
                    },
                    new Employee()
                    {
                        Id = 22,
                        Name = "Иван Иванов",
                        Salary = 59000,
                        DepartmentId = 4
                    },
                    new Employee()
                    {
                        Id = 23,
                        Name = "Виктор Рабочев",
                        Salary = 54000,
                        DepartmentId = 4
                    },
                    new Employee()
                    {
                        Id = 24,
                        Name = "Георгий Нерабочев",
                        Salary = 30000,
                        DepartmentId = 4
                    },
                    
                    
                    new Employee()
                    {
                        Id = 25,
                        Name = "Екатерина Вацапова",
                        Salary = 90000,
                        DepartmentId = 5
                    },
                    new Employee()
                    {
                        Id = 26,
                        Name = "Алина Вайберова",
                        Salary = 86000,
                        DepartmentId = 5
                    },
                    new Employee()
                    {
                        Id = 27,
                        Name = "Марина Хедхантеровна",
                        Salary = 110000,
                        DepartmentId = 5
                    },
                    new Employee()
                    {
                        Id = 28,
                        Name = "Татьяна Телеграмина",
                        Salary = 106000,
                        DepartmentId = 5
                    },
                    new Employee()
                    {
                        Id = 29,
                        Name = "Арина Топмесяцевна",
                        Salary = 130000,
                        DepartmentId = 5
                    },
                    new Employee()
                    {
                        Id = 30,
                        Name = "Лера Последняя",
                        Salary = 99999,
                        DepartmentId = 5
                    },
                });
        }
    }
}