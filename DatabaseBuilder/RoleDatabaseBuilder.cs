using Microsoft.EntityFrameworkCore;

public static class RoleDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
               


            });
        modelBuilder.Entity<Role>().HasData(
 new Role
 {
     Id = 1,
    Name = "Admin"

 },
 new Role
 {
    Id = 2,
    Name = "Standard"
 });




        SetDataToDB(modelBuilder);
    }

}