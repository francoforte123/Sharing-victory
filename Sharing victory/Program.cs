using Grading_the_students;

Console.WriteLine("creo 10 studenti con nomi e voto");
Student students = new();

Student student1 = new Student("Marco", 26);
Student student2 = new Student("Luca", 30);
Student student3 = new Student("Anna", 28);
Student student4 = new Student("GianMarco", 19);
Student student5 = new Student("Franco", 21);
Student student6 = new Student("Lucia", 30);
Student student7 = new Student("Alice", 26);
Student student8 = new Student("Francesca", 29);
Student student9 = new Student("Emanuele", 23);
Student student10 = new Student("Mario", 22);

List<Student> StudentList = new()
{
    student1, student2, student3, student4, student5,
    student6, student7, student8, student9, student10,
};

foreach (Student name in StudentList)
{
    Console.WriteLine(name.GetStudent());
}

double TotalGrade = 0;

foreach (Student student in StudentList)
{
    TotalGrade = (TotalGrade += student.GradeStudent) / StudentList.Count;
}

Console.WriteLine("\nla media totale è " + TotalGrade);

Console.Write("\nlo/a studente/ssa con il voto più alto è: ");

string NameStudent = students.GetNameStudentWithGradeMax(StudentList);
Console.WriteLine(NameStudent);

int NewGradeTheStudent = student4.SetGrade(5);      //andando a sostituire "student4" con un altro studente, si può cambiare il voto
Console.WriteLine($"E' stato cambiato il voto dello studente {student4.NameStudent}, in: " + NewGradeTheStudent);

Console.WriteLine("--------------------------------------");

Console.WriteLine("sto stampando i nomi delgi studenti al contrario:");

List<string> ciao = students.PrintNameStudentOrderAlfhabetical(StudentList);

foreach(string s in ciao)
{
    Console.WriteLine(s);
}

