using Microsoft.EntityFrameworkCore;

public static class CommentDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Content).IsRequired();
                entity.Property(e => e.DateTime);
                entity.Property(e => e.LikeCount);
                entity.HasOne(e => e.Post).WithMany(e => e.Comment).HasForeignKey(e => e.PostId);
               entity.HasOne(e=>e.User).WithMany(e=>e.Comment).HasForeignKey(e => e.UserId);


            });
        modelBuilder.Entity<Comment>().HasData(
 new Comment
 {
     Id = 1,
    Content = "new Comment",
    DateTime = System.DateTime.Now,
    LikeCount =2,
    PostId =1,
    UserId=1


 },
 new Comment
 {
     Id = 2,
    Content = "No Comment",
    DateTime = System.DateTime.Now,
    LikeCount =8,
    PostId =2,
    UserId=2
 });




        SetDataToDB(modelBuilder);
    }

}