namespace LiskovSubstitutionPrinciple
{
	// LSP – Liskov Substitution Principle
	// Child should not break parent class’s type definition and behavior.

	// What NOT to do.
	public class Bad
	{
		public class Rectangle
		{
			public virtual float Heigth { get; set; }
			public virtual float Width { get; set; }
			public virtual float Area
			{
				get { return Heigth * Width; }
			}
		}
		public class Square : Rectangle
		{
			private float _heigth;
			private float _width;
			public override float Heigth
			{
				get
				{
					return _heigth;
				}
				set
				{
					_heigth = value;
					_width = value;
				}
			}
			public override float Width
			{
				get
				{
					return _width;
				}
				set
				{
					_width = value;
					_heigth = value;
				}
			}
		}

		public void TestWithRectangle()
		{
			Rectangle sut = new Rectangle
			{
				Heigth = 3,
				Width = 7
			};
			//Assert.AreEqual(21, sut.Area); 
			//This test will pass. 3 X 7 = 21
		}

		public void TestWithSquare()
		{
			Rectangle sut = new Square
			{
				Heigth = 3,
				Width = 7
			};
			//Assert.AreEqual(21, sut.Area); 
			//This test will fail. Area equals 49. (Hint: We set "Width" to 7, calling Area property will be 7 X 7 = 49)
		}
	}

	// What should be done.
	public abstract class Shape
	{
		public abstract float Area { get; }
	}
	public class Rectangle : Shape
	{
		public float Heigth { get; set; }
		public float Width { get; set; }
		public override float Area
		{
			get { return Heigth * Width; }
		}
	}
	public class Square : Shape
	{
		public float Edge { get; set; }
		public override float Area
		{
			get { return Edge * Edge; }
		}
	}
}
