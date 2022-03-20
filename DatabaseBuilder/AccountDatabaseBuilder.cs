using Microsoft.EntityFrameworkCore;

public static class AccountDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.IsBlocked);
                entity.Property(e => e.Visibility);
                entity.HasOne(e => e.Role).WithMany(e=>e.Accounts).HasForeignKey(e => e.RoleId);



            });
        modelBuilder.Entity<Account>().HasData(
 new Account
 {
     Id = 1,
     Email = "adem@gmail.com",
     Password = "pass",
     IsBlocked = false,
     Visibility = true,
     RoleId=1

 },
 new Account
 {
     Id = 2,
     Email = "ali@gmail.com",
     Password = "pass",
     IsBlocked = false,
     Visibility = true,
     RoleId=2

 });




        SetDataToDB(modelBuilder);
    }

}