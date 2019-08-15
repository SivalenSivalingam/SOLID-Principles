namespace SOLID_Principles
{
	public class OpenClosedPrincipleWithDecorator 
	{
		public void Main()
		{
			//This demonstrates how to make an object open for extension but closed for modification
			var normalCamera = new Camera();
			var normalPicture = normalCamera.TakePicture();

			var ThreeDCamera = new ThreeDimensionalCameraDecorator(normalCamera);
			var threeDPicture = ThreeDCamera.TakePicture();
		}

	}

	public class Camera : CameraComponent
	{
		//Here we have a class Camera which performs TakePicture, simply returning a new picture
		//Decorator Pattern helps us to extend this class without modifying it's implementation, satisfying open/closed.
		public override Picture TakePicture()
		{
			return new Picture();
		}
	}

	// We have the component which describes the functionality that needs to be overriden
	public abstract class CameraComponent
	{
		public abstract Picture TakePicture();
	}

	//We have the more specialized camera, extending the functionality of a normal camera but not modifying it
	public class ThreeDimensionalCameraDecorator : CameraComponent
	{
		CameraComponent _cameraComponent;

		public ThreeDimensionalCameraDecorator(CameraComponent cameraComponent)
		{
			_cameraComponent = cameraComponent;
		}

		public override Picture TakePicture()
		{
			var picture = _cameraComponent.TakePicture();
			ApplyThreeDimensions(picture);
			return picture;
		}

		void ApplyThreeDimensions(Picture picture)
		{
			//Logic applied to picture
		}
	}

	public class Picture
	{
	}
}
