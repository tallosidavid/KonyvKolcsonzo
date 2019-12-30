namespace WEB191010.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using WEB191010.Models;
    
    public partial class SeedRoles : DbMigration
    {
        public override void Up()
        {
            Sql($@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'08284933-10f5-4cdf-96bf-a3790c7556c8', N'vendeg@vendeg.com', 0, N'ACam+C2VJxLziwdYws9wYKwGHDZtzt2ZwzcHmCT88awwBHfvbDokQl+42QhCZE7t7A==', N'99a622dd-c293-462b-b541-bd4f9c96fe7d', NULL, 0, 0, NULL, 1, 0, N'vendeg@vendeg.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bfa9774d-8f1f-42f1-84ea-20076d23660b', N'admin@admin.hu', 0, N'AL3z0Unk/Jsswi4UI264fm5y6Kt+7xfNtU3P5pssx2fpSFUnMqGUdV0JXZ5z7dUyLA==', N'6ef923bd-34cc-4c6f-a124-3d779199288b', NULL, 0, 0, NULL, 1, 0, N'admin@admin.hu')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd1e86887-4492-4cdb-8048-508436869428', N'{RoleNevek.Admin}')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bfa9774d-8f1f-42f1-84ea-20076d23660b', N'd1e86887-4492-4cdb-8048-508436869428')
                
");
        }
        
        public override void Down()
        {
        }
    }
}
