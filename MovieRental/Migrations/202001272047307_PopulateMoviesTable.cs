namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Terminator',1, '1997-06-18', '2000-06-18',13)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Thrill 2',2, '1996-06-18', '2000-06-18',4)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Jumanji',3, '1997-06-18', '2000-06-18',7)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Romance in S.',4, '1997-06-18', '2000-06-18',6)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Zoolander',5, '1998-06-18', '2001-06-18',10)");
        }
        
        public override void Down()
        {
        }
    }
}
