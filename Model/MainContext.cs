using Microsoft.EntityFrameworkCore;

public class MainContext : DbContext
{
    public DbSet<Account>? Accounts { get; set; }
    public DbSet<User>? Users { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Comment>? Comments { get; set; }
    public DbSet<Picture>? Pictures { get; set; }
    public DbSet<Post>? Posts { get; set; }
    public DbSet<Role>? Roles { get; set; }
    public DbSet<Title>? Tags { get; set; }




    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
        optionsBuilder.UseMySql("server=localhost;database=sahabt;user=root;port=3306;password=toortoor", serverVersion);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        AccountDatabaseBuilder.TableBuilder(modelBuilder);
        UserDatabaseBuilder.TableBuilder(modelBuilder);
        RoleDatabaseBuilder.TableBuilder(modelBuilder);
        CategoryDatabaseBuilder.TableBuilder(modelBuilder);
        TitleDatabaseBuilder.TableBuilder(modelBuilder);
        PostDatabaseBuilder.TableBuilder(modelBuilder);
        PictureDatabaseBuilder.TableBuilder(modelBuilder);
        CommentDatabaseBuilder.TableBuilder(modelBuilder);








    }
}