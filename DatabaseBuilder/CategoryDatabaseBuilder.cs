using Microsoft.EntityFrameworkCore;

public static class CategoryDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
               


            });
        modelBuilder.Entity<Category>().HasData(
 new Category
 {
     Id = 1,
    Name = "Yazılım"

 },
 new Category
 {
    Id = 2,
    Name = "Ekonomi"
 });




        SetDataToDB(modelBuilder);
    }

}