using CosinusApp.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace CosinusApp.Model
{
    // контекст модели
    public class CosinusAppDbContext : DbContext
    {
        public DbSet<KnownHost> KnownHosts { get; set; }
        public DbSet<Request> Requests { get; set; }
        // конфигурация контекста
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // получаем файл конфигурации
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            // устанавливаем для контекста строку подключения
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("CloudDbConnectionString"));
        }
    }
}
