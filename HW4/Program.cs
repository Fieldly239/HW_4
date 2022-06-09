// See https://aka.ms/new-console-template for more information
using HW4;

Console.WriteLine("========== HW-4 Abstract Class ==========");

/*var job = new Job("GT", "Developer",15000m,10);
var resWhoAmI = job.WhoAmI();
var resGetTax = job.GetTax();

Console.WriteLine($"Who Am I : {resWhoAmI}");
Console.WriteLine($"Get Tax : {resGetTax}");
*/
Console.WriteLine("========= Doctor ========");
var doctor = new Doctor("Phatsakorn", "Joker", 150000.50m, 2);
var doctorWhoAmI = doctor.WhoAmI();
var doctorGetTax = doctor.GetTax();

Console.WriteLine($"Who Am I : {doctorWhoAmI}");
Console.WriteLine($"Get Tax : {doctorGetTax}");

Console.WriteLine("========= Police ========");
var police = new Police("Phatsakorn", "Police", 7500.50m,5);
var policeWhoAmI = police.WhoAmI();
var policeGetTax = police.GetTax();

Console.WriteLine($"Who Am I : {policeWhoAmI}");
Console.WriteLine($"Get Tax : {policeGetTax}");

Console.WriteLine("========= Teacher ========");
var teacher = new Teacher("Phatsakorn", "Teacher", 12000m, 6);
var teacherWhoAmI = teacher.WhoAmI();
var teacherGetTax = teacher.GetTax();

Console.WriteLine($"Who Am I : {teacherWhoAmI}");
Console.WriteLine($"Get Tax : {teacherGetTax}");