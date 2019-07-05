namespace InterfaceSegregationPrinciple
{
	// ISP – Interface Segregation Principle
	// Don't make a unwanted method a third wheel :)

	public class Employee
	{
		// What NOT to do.
		public interface IEmployeeDatabase
		{
			bool AddEmployee();
			bool PrintEmployee();
		}

		// What should be done.
		public interface IAddOperation
		{
			bool AddEmployee();
		}
		public interface IPrintOperation
		{
			bool PrintEmployee();
		}
	}
}
