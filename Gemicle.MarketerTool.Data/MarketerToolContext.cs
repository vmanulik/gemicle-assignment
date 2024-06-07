using Microsoft.EntityFrameworkCore;
using Gemicle.MarketerTool.Data.Models;
using Serialize.Linq.Serializers;
using System.Linq.Expressions;

namespace Gemicle.MarketerTool.Data
{
    public class MarketerToolContext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasData(GetCustomers());

            modelBuilder.Entity<Campaign>()
                .HasData(GetCampaigns());
        }

        internal static IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new() { Id = 1, Age = 53, Gender = Gender.Male, City = "London", Deposite= 104, IsNewCustomer = false },
                new() { Id = 2, Age = 44, Gender = Gender.Female, City = "New York", Deposite= 209, IsNewCustomer = true },
                new() { Id = 3, Age = 36, Gender = Gender.Male, City = "New York", Deposite= 208, IsNewCustomer = true },
                new() { Id = 4, Age = 87, Gender = Gender.Female, City = "London", Deposite= 134, IsNewCustomer = false },
                new() { Id = 5, Age = 54, Gender = Gender.Male, City = "Paris", Deposite= 123, IsNewCustomer = true },
                new() { Id = 6, Age = 45, Gender = Gender.Female, City = "New York", Deposite= 210, IsNewCustomer = true },
                new() { Id = 7, Age = 49, Gender = Gender.Female, City = "Tel-Aviv", Deposite= 174, IsNewCustomer = false },
                new() { Id = 8, Age = 35, Gender = Gender.Male, City = "Paris", Deposite= 52, IsNewCustomer = true },
                new() { Id = 9, Age = 61, Gender = Gender.Male, City = "Tel-Aviv", Deposite= 151, IsNewCustomer = false },
                new() { Id = 10, Age = 78, Gender = Gender.Male, City = "Paris", Deposite= 57, IsNewCustomer = false },
                new() { Id = 11, Age = 41, Gender = Gender.Female, City = "New York", Deposite= 131, IsNewCustomer = false },
                new() { Id = 12, Age = 32, Gender = Gender.Female, City = "Tel-Aviv", Deposite= 154, IsNewCustomer = true },
                new() { Id = 13, Age = 62, Gender = Gender.Female, City = "Paris", Deposite= 135, IsNewCustomer = false },
                new() { Id = 14, Age = 67, Gender = Gender.Male, City = "Tel-Aviv", Deposite= 153, IsNewCustomer = true },
                new() { Id = 15, Age = 68, Gender = Gender.Female, City = "London", Deposite= 241, IsNewCustomer = true },
                new() { Id = 16, Age = 41, Gender = Gender.Male, City = "London", Deposite= 134, IsNewCustomer = false },
                new() { Id = 17, Age = 46, Gender = Gender.Female, City = "London", Deposite= 212, IsNewCustomer = false },
                new() { Id = 18, Age = 77, Gender = Gender.Female, City = "Tel-Aviv", Deposite= 97, IsNewCustomer = true },
                new() { Id = 19, Age = 51, Gender = Gender.Male, City = "London", Deposite= 141, IsNewCustomer = true },
                new() { Id = 20, Age = 80, Gender = Gender.Male, City = "Paris", Deposite= 189, IsNewCustomer = false },
                new() { Id = 21, Age = 31, Gender = Gender.Female, City = "Tel-Aviv", Deposite= 134, IsNewCustomer = true },
                new() { Id = 22, Age = 80, Gender = Gender.Female, City = "Tel-Aviv", Deposite= 81, IsNewCustomer = false },
                new() { Id = 23, Age = 36, Gender = Gender.Female, City = "London", Deposite= 237, IsNewCustomer = true },
                new() { Id = 24, Age = 65, Gender = Gender.Female, City = "Tel-Aviv", Deposite= 119, IsNewCustomer = false },
                new() { Id = 25, Age = 72, Gender = Gender.Male, City = "Tel-Aviv", Deposite= 139, IsNewCustomer = false },
                new() { Id = 26, Age = 64, Gender = Gender.Male, City = "Tel-Aviv", Deposite= 128, IsNewCustomer = true },
                new() { Id = 27, Age = 29, Gender = Gender.Male, City = "London", Deposite= 76, IsNewCustomer = true },
                new() { Id = 28, Age = 25, Gender = Gender.Male, City = "London", Deposite= 203, IsNewCustomer = true },
                new() { Id = 29, Age = 77, Gender = Gender.Male, City = "New York", Deposite= 54, IsNewCustomer = true },
                new() { Id = 30, Age = 79, Gender = Gender.Female, City = "Paris", Deposite= 165, IsNewCustomer = true },
                new() { Id = 31, Age = 26, Gender = Gender.Female, City = "Paris", Deposite= 143, IsNewCustomer = true },
                new() { Id = 32, Age = 74, Gender = Gender.Female, City = "London", Deposite= 61, IsNewCustomer = false },
                new() { Id = 33, Age = 74, Gender = Gender.Male, City = "New York", Deposite= 103, IsNewCustomer = false },
                new() { Id = 34, Age = 46, Gender = Gender.Female, City = "New York", Deposite= 121, IsNewCustomer = true },
                new() { Id = 35, Age = 47, Gender = Gender.Female, City = "New York", Deposite= 214, IsNewCustomer = false },
                new() { Id = 36, Age = 78, Gender = Gender.Female, City = "New York", Deposite= 111, IsNewCustomer = false },
                new() { Id = 37, Age = 46, Gender = Gender.Female, City = "New York", Deposite= 223, IsNewCustomer = true },
                new() { Id = 38, Age = 26, Gender = Gender.Female, City = "New York", Deposite= 78, IsNewCustomer = true },
                new() { Id = 39, Age = 49, Gender = Gender.Female, City = "Tel-Aviv", Deposite= 60, IsNewCustomer = false },
                new() { Id = 40, Age = 74, Gender = Gender.Female, City = "New York", Deposite= 53, IsNewCustomer = true },
            };
        }
      
        internal static IEnumerable<Campaign> GetCampaigns()
        {
            var serializer = new ExpressionSerializer(new JsonSerializer());

            return new List<Campaign>()
            {
                new() {
                    Id = 1,
                    Priority = 1,
                    Template = Template.A,
                    Time = new TimeSpan(hours: 10, minutes: 15, seconds: 0),
                    PredicateJson = serializer.SerializeText(
                        (Expression<Func<Domain.Customer, bool>>)(customer => customer.Gender == Domain.Gender.Male)
                    ) 
                },
                new() {
                    Id = 2,
                    Priority = 2,
                    Template = Template.B,
                    Time = new TimeSpan(hours: 10, minutes: 05, seconds: 0),
                    PredicateJson = serializer.SerializeText(
                        (Expression<Func<Domain.Customer, bool>>)(customer => customer.Age > 45)
                    )
                },
                new() {
                    Id = 3,
                    Priority = 5,
                    Template = Template.C,
                    Time = new TimeSpan(hours: 10, minutes: 15, seconds: 0),
                    PredicateJson = serializer.SerializeText(
                        (Expression<Func<Domain.Customer, bool>>)(customer => customer.City == "New York")
                    )
                },
                new() {
                    Id = 4,
                    Priority = 3,
                    Template = Template.A,
                    Time = new TimeSpan(hours: 10, minutes: 15, seconds: 0),
                    PredicateJson = serializer.SerializeText(
                        (Expression<Func<Domain.Customer, bool>>)(customer => customer.Deposite > 100)
                    )
                },
                new() {
                    Id = 5,
                    Priority = 4,
                    Template = Template.C,
                    Time = new TimeSpan(hours: 10, minutes: 05, seconds: 0),
                    PredicateJson = serializer.SerializeText(
                        (Expression<Func<Domain.Customer, bool>>)(customer => customer.IsNewCustomer)
                    )
                }
            };
        }
    }
}