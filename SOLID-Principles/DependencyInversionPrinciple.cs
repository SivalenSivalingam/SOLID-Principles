namespace DependencyInversionPrinciple
{
	// DIP – Dependency Inversion Principle
	// No tightly coupled code
	// If a class depends on another class, then we need to change one class if something changes in that dependent class. 
	// We should always try to write loosely coupled class.

	// What NOT to do.
	public class Email
	{
		public void SendEmail() { }
	}

	public class Notification
	{
		private Email _email;

		public Notification()
		{
			_email = new Email();
		}

		public void PromotionalNotification()
		{
			_email.SendEmail();
		}
	}

	// What should be done.
	public interface IMessenger
	{
		void SendMessage();
	}

	public class Mail : IMessenger
	{
		public void SendMessage() { }
	}

	public class SMS : IMessenger
	{
		public void SendMessage() { }
	}

	public class SendNotification
	{
		private IMessenger _iMessenger;

		//Property/Setter Injection
		public IMessenger MessageService
		{
			set
			{
				_iMessenger = value;
			}
		}

		//Constructor injection
		public SendNotification(IMessenger iMessenger)
		{
			_iMessenger = iMessenger;
		}

		//Method Injection
		public void SetMessengerType(IMessenger iMessenger)
		{
			_iMessenger = iMessenger;
		}

		public void Notify()
		{
			_iMessenger.SendMessage();
		}
	}
}
