namespace SingleResponsibilityPrinciple
{
	// SRP – Single Responsibility Principle
	// Do one thing...and only one thing. 
	// Don't create a swiss army knife class to act like a knife class  

	// What NOT to do.
	public class Employee
	{
		public void SaveEmployeeToDatabase() { }

		public void GenerateEmployeeReport() { }
	}

	// What should be done.
	public class Database
	{
		public void SaveEmployeeToDatabase() { }
	}

	public class ReportGeneration
	{
		public void GenerateEmployeeReport() { }
	}
}
