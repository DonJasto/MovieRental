namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4ee93228-3cb3-436a-b34b-979c0c503151', N'jakov.stosic@gmail.com', 0, N'AFslliIex+K2kvGf9Snc8UUNmxPTe/VPeNIRmmN/SKq2t5Cb+4P5ycuXpEKgkDFegg==', N'd0afd05c-d79e-4537-80e9-0dde4751e5eb', NULL, 0, 0, NULL, 1, 0, N'jakov.stosic@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'54a830e6-56d9-490b-9779-2b30ee22b7e1', N'ja.stosic@gmail.com', 0, N'AHOApH6xlW/Y/u/vupNxbWI8KNAiLB20gSEQ1VoZokyFH/o7iJIToT0O2fCFD7QY3w==', N'7cca4d69-7d5c-4764-b4b2-2125c4f40a8c', NULL, 0, 0, NULL, 1, 0, N'ja.stosic@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'146ceef7-4a77-4835-b63b-657f2aa7e87c', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'54a830e6-56d9-490b-9779-2b30ee22b7e1', N'146ceef7-4a77-4835-b63b-657f2aa7e87c')

");
        }
        
        public override void Down()
        {
        }
    }
}
