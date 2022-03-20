using Microsoft.EntityFrameworkCore;

public static class PictureDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Picture>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SmallPath);
                entity.Property(e => e.MiddlePath);
                entity.Property(e => e.BigPath);
                entity.HasOne(e=>e.User).WithMany(e=>e.Picture).HasForeignKey(e=>e.USerId);
                entity.HasOne(e=>e.Post).WithMany(e=>e.Picture).HasForeignKey(e=>e.PostId);



            });
       




        SetDataToDB(modelBuilder);
    }

}