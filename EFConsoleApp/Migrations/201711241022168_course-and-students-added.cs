namespace EFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class courseandstudentsadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        CourseCode = c.String(),
                        Year = c.String(),
                        CourseName = c.String(),
                    })
                .PrimaryKey(t => t.CourseID);
            
            CreateTable(
                "dbo.StudentCourse",
                c => new
                    {
                        CourseID = c.String(nullable: false, maxLength: 128),
                        StudentID = c.String(nullable: false, maxLength: 128),
                        course_CourseID = c.Int(),
                    })
                .PrimaryKey(t => new { t.CourseID, t.StudentID })
                .ForeignKey("dbo.Course", t => t.course_CourseID)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.course_CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourse", "StudentID", "dbo.Student");
            DropForeignKey("dbo.StudentCourse", "course_CourseID", "dbo.Course");
            DropIndex("dbo.StudentCourse", new[] { "course_CourseID" });
            DropIndex("dbo.StudentCourse", new[] { "StudentID" });
            DropTable("dbo.StudentCourse");
            DropTable("dbo.Course");
        }
    }
}
