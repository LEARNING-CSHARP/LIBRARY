using System.Linq;

namespace MyApplication.Admin
{
	public partial class CreateResourceForm : Infrastructure.BaseForm
	{
		public CreateResourceForm()
		{
			InitializeComponent();
		}

		private void CreateResourceForm_Load(object sender, System.EventArgs e)
		{
			typeComboBox.DataSource =
				System.Enum.GetValues(typeof(Models.Enums.ResourceType));
		}

		private void CreateButton_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(titleTextBox.Text))
			{
				System.Windows.Forms.MessageBox.Show("Title is required!");
				return;
			}

			if (string.IsNullOrWhiteSpace(authorTextBox.Text))
			{
				System.Windows.Forms.MessageBox.Show("Author is required!");
				return;
			}

			if (string.IsNullOrWhiteSpace(publishYearTextBox.Text))
			{
				System.Windows.Forms.MessageBox.Show("Publish year is required!");
				return;
			}

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.Resource resource = new Models.Resource
				{
					Title = titleTextBox.Text,
					Author = authorTextBox.Text,
					Translator = translatorTextBox.Text,
					Description = descriptionTextBox.Text,
					Type = (Models.Enums.ResourceType)typeComboBox.SelectedValue,
					PublishYear = System.Convert.ToInt32(publishYearTextBox.Text),
				};

				databaseContext.Resources.Add(resource);

				databaseContext.SaveChanges();

				System.Windows.Forms.MessageBox
					.Show("Resource created successfully...");
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
