//匯入内容
using front.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace front.DataAcess.Data
{
    public class ApplicationDbContext: IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "人偶", DisplayOrder = 1 },
                new Category { Id = 2, Name = "扭蛋", DisplayOrder = 2 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "獅子座", Description = "毛茸茸的小獅子穿著那套大紅衣裳，戴起了那可愛的毛絨帽，那條翹著的尾巴，像鐘擺一樣。" ,Price=750,CategoryId=1,ImageUrl=""},
                new Product { Id = 2, Name = "天秤座", Description = "以希臘的維納斯女神為設計靈感整體色調以白色為主，金色、亮黃色突出天秤座的優雅大方。", Price=1040, CategoryId = 1, ImageUrl = "" },
                new Product { Id = 3, Name = "處女座", Description = "仙女閣裡，淡淡一抹胭脂，著一身粉嫩花裙，花苞般的裙子，宛如含羞待放的花朵，出尘如仙。", Price = 1270, CategoryId = 1 , ImageUrl = "" },
                new Product { Id = 4, Name = "巨蟹座", Description = "夏天開始的第一個星座，以螃蟹可愛的蟹鉗和鮮豔的橙黃色為主為靈感來源，融入古風元素。", Price = 790, CategoryId = 1 , ImageUrl = ""},
                new Product { Id = 5, Name = "野餐兔兔", Description = "这些兔兔帶給人們放鬆、開心和充滿溫馨感的感覺，營造出一種歡樂和愉悅的氛圍，讓人感受到無憂無慮的野餐時光。", Price = 300, CategoryId = 2, ImageUrl = "" }

    );
        }
    }
}
