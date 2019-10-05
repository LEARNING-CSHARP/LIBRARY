using System.Linq;

namespace MyApplication.Admin
{
	public partial class DisplayResourceForm : Infrastructure.BaseForm
	{
		public DisplayResourceForm()
		{
			InitializeComponent();
		}

		public int Id { get; set; }

		private void DisplayResourceForm_Load(object sender, System.EventArgs e)
		{
			typeComboBox.DataSource =
				System.Enum.GetValues(typeof(Models.Enums.ResourceType));

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.Resource resource =
					databaseContext.Resources
					.Where(current => current.Id == Id)
					.FirstOrDefault();

				if (resource == null)
				{
					System.Windows.Forms.MessageBox.Show("There is not resource any more!");
					Close();
				}

				resource.VisitCount++;

				databaseContext.SaveChanges();

				titleTextBox.Text = resource.Title;
				authorTextBox.Text = resource.Author;
				translatorTextBox.Text = resource.Translator;
				descriptionTextBox.Text = resource.Description;
				publishYearTextBox.Text = resource.PublishYear.ToString();

				//typeComboBox.SelectedText = resource.Type.ToString();
				typeComboBox.SelectedItem = (Models.Enums.ResourceType)resource.Type;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"Error: { ex.Message }");
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}
	}
}
