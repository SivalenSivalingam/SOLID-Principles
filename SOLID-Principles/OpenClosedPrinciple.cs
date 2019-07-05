namespace OpenClosedPrinciple
{
	// OCP – Open/Closed Principle
	// Open for extension but closed for modification
	// Introduce new features without modification of current code file  

	// What NOT to do.
	public class ReportGeneration
	{
		public string ReportType;

		public void GenerateReport()
		{
			if (ReportType == "Excel")
			{
			}

			if (ReportType == "PDF")
			{
			}
		}
	}

	// What should be done.
	public class IReportGeneration
	{
		public virtual void GenerateReport()
		{
		}
	}

	public class ExcelReportGeneraion : IReportGeneration
	{
		public override void GenerateReport()
		{
		}
	}

	public class PDFReportGeneraion : IReportGeneration
	{
		public override void GenerateReport()
		{
		}
	}
}
