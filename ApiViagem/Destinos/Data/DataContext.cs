using Destinos.Model;
using Microsoft.EntityFrameworkCore;

namespace Destinos.Data
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Destino> Destinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Destino>().HasData(
                new Destino { Id = 1, Nome = "Jericoacoara", Estado = "CE", Pais ="Brasil", destinoUrl = "data:image/jpeg;base64,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", Valor ="R$ 659,00"},

                new Destino { Id = 2, Nome = "Bonito", Estado = "MS", Pais ="Brasil", destinoUrl = "https://images.squarespace-cdn.com/content/v1/5ca69b78ebfc7fa935a56f7e/1654792443846-D6TF30JB7D8G1GYE6FN9/IMG_0808%2BRIO.jpg?format=2500w", Valor ="R$ 599,00"},

                new Destino { Id = 3, Nome = "Lençóis Maranhenses", Estado = "MA", Pais ="Brasil", destinoUrl = "https://portaledicase.com/wp-content/uploads/2023/11/lencois-maranhenses.jpg", Valor ="R$ 679,00"},

                new Destino { Id = 4, Nome = "Alter do Chão", Estado = "PA", Pais ="Brasil", destinoUrl = "https://www.escolhaviajar.com/wp-content/uploads/2018/11/Praias-de-Alter-do-Ch%C3%A3o.jpg", Valor ="R$ 899,00"},

                new Destino { Id = 5, Nome = "Fernando de Noronha", Estado = "PE", Pais ="Brasil", destinoUrl = "https://teatur.com.br/wp-content/uploads/2018/09/Noronha_1.jpg", Valor ="R$ 1.200,00"},

                new Destino { Id = 6, Nome = "Gramado", Estado = "RS", Pais ="Brasil", destinoUrl = "https://lh3.googleusercontent.com/proxy/rWcyPYjGYCSgc0cijgw7Sl4EKNWG3GbSvOEpbQfdM70AZf6A_DHLOiqjFh7SOVk0DWgqWt7IZPslgnd8x-AiTAUJvWHqLcbxr7KFzF9_mKleaYU8ia-H0at9hS0DYr2Hmqae10FwUlM5d2vd6rCL1T0ZEbG8EyAhCEIzD_tfQcfoRKDp87mVpO8u5a2d1A", Valor ="R$ 998,00"},

                new Destino { Id = 7, Nome = "Machu Picchu", Estado = "Cusco", Pais ="Perú", destinoUrl = "https://www.adventureclub.com.br/wp-content/uploads/2014/08/1-MachuPicchu-1.jpg", Valor ="R$ 559,00"},

                new Destino { Id = 8, Nome = "Monte Roraima", Estado = "RR", Pais ="Venezuela", destinoUrl = "https://www.infoescola.com/wp-content/uploads/2012/12/monte-roraima_747945205.jpg", Valor ="R$ 799,00"}
            );
        }

    }

}
