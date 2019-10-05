namespace Models
{
	public class BaseEntity : object
	{
		public BaseEntity() : base()
		{
			//Id = System.Guid.NewGuid();
		}

		// **********
		//[System.ComponentModel.Browsable(browsable: false)]
		//public System.Guid Id { get; set; }
		// **********

		// **********
		//[System.ComponentModel.Browsable(browsable: false)]
		[System.ComponentModel.DataAnnotations.Schema.Column(Order = 0)]
		public int Id { get; set; }
		// **********
	}
}
