using Microsoft.EntityFrameworkCore;

public static class TitleDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Title>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
               


            });
        modelBuilder.Entity<Title>().HasData(
 new Title
 {
     Id = 1,
    Name = "Yazılım Nasıl Öğrenilir"

 },
 new Title
 {
    Id = 2,
    Name = "Ekonomik Sorunlar"
 });




        SetDataToDB(modelBuilder);
    }

}