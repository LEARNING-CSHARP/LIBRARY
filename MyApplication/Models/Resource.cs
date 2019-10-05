namespace Models
{
	public class Resource : BaseEntity
	{
		public Resource() : base()
		{
		}

		// **********
		public int VisitCount { get; set; }
		// **********

		// **********
		public int PublishYear { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Title { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Author { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Translator { get; set; }
		// **********

		// **********
		public string Description { get; set; }
		// **********

		// **********
		public Enums.ResourceType Type { get; set; }
		// **********
	}
}
