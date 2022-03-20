using Microsoft.EntityFrameworkCore;

public static class UserDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.Username);
                entity.Property(e => e.PhoneNumber);
                entity.HasOne(e=>e.Account).WithMany(e=>e.User).HasForeignKey(e => e.AccountId);



            });
        modelBuilder.Entity<User>().HasData(
 new User
 {
     Id = 1,
     FirstName = "adem",
     LastName = "Simsek",
     Username = "as",
     PhoneNumber = 05451848,
     AccountId=1

 },
 new User
 {
    Id = 2,
     FirstName = "ali",
     LastName = "veli",
     Username = "av",
     PhoneNumber = 05300000,
     AccountId=2

 });




        SetDataToDB(modelBuilder);
    }

}