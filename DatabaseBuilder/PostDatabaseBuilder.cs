using Microsoft.EntityFrameworkCore;

public static class PostDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Content).IsRequired();
                entity.Property(e => e.DateTime).IsRequired();
                entity.Property(e => e.LikeCount);
                entity.HasOne(e => e.Category).WithMany(e => e.Post).HasForeignKey(e => e.CategoryId);
                entity.HasOne(e => e.Title).WithMany(e => e.Post).HasForeignKey(e => e.TitleId);
                entity.HasOne(e => e.User).WithMany(e => e.Post).HasForeignKey(e => e.UserId);

            });
        modelBuilder.Entity<Post>().HasData(
 new Post
 {
     Id = 1,
     Content = "Lorem Ipsum is simply dummy text of tccacapclspaplcpacpasclpplacplclpalpcplaclpasclpcslplc",
     DateTime =System.DateTime.Now,
     LikeCount =5,
     CategoryId=1,
     TitleId=1,
     UserId=1




 },
 new Post
 {
    Id = 2,
     Content = "it is a long established fact that a reader will be distracted by the readable content of a page",
     DateTime =System.DateTime.Now,
     LikeCount =4,
     CategoryId=2,
     TitleId=2,
     UserId=2
 });




        SetDataToDB(modelBuilder);
    }

}