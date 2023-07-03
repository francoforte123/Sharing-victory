using System.Globalization;

namespace Grading_the_students
{
    internal class Student
    {
        public string NameStudent;
        public int GradeStudent;

        public int SetGrade(int Grade)
        {
            int NewGrade = Grade;
            return NewGrade;
        }

        public Student()
        {
        }

        public Student(string nameStudent, int gradeStudent)
        {
            NameStudent = nameStudent;
            GradeStudent = gradeStudent;
        }

        public string GetStudent()
        {
            return "nome dello studente: " + NameStudent + ", voto: " + GradeStudent;
        }

        public List<string> GetNameStudentWithGradeMax(List<Student> ListOfStudents)
        {
            List<string> listNameStudentWithGradeMax = new();
            int maxGrade = ListOfStudents[1].GradeStudent;

            foreach (var student in ListOfStudents)
            {
                if (student.GradeStudent > maxGrade)
                {
                    maxGrade = student.GradeStudent;
                    listNameStudentWithGradeMax.Add(student.NameStudent);
                }
                else if(student.GradeStudent == maxGrade)
                {
                    listNameStudentWithGradeMax.Add(student.NameStudent);
                }
            }
            return listNameStudentWithGradeMax;
        }

        public List<string> PrintNameStudentOrderAlfhabetical(List<Student> StudentList)
        {
            List<string> orderedNames = new();

            foreach (Student student in StudentList)
            {
                orderedNames.Add(student.NameStudent);
            }
            orderedNames.Sort();
            return orderedNames;
        }
    }
}
