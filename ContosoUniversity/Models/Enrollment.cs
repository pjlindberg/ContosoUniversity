namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        // Entity Framework interprets a property as a foreign key property if it's named: 
        // <navigation property name><primary key property name> 
        // ...For example, StudentID for the Student navigation property since the Student entity's primary key is ID). 
        // Foreign key properties can also be named simply: 
        // <primary key property name> 
        // ...For example, CourseID since the Course entity's primary key is CourseID).

        // The CourseID property is a foreign key, and the corresponding navigation property is Course (see below). 
        public int CourseID { get; set; }

        // The StudentID property is a foreign key, and the corresponding navigation property is Student (see below).
        public int StudentID { get; set; }

        // The question mark after the Grade type declaration indicates that the Grade property is nullable. 
        // A grade that's null is different from a zero grade -- null means a grade isn't known or hasn't been assigned yet.
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}