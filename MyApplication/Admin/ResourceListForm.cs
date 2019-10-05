using System.Linq;

namespace MyApplication.Admin
{
	public partial class ResourceListForm : Infrastructure.BaseForm
	{
		public ResourceListForm()
		{
			InitializeComponent();
		}

		private void SearchButton_Click(object sender, System.EventArgs e)
		{
			Search();
		}

		public void Search()
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				titleTextBox.Text = Infrastructure.Utility.FixText(titleTextBox.Text);
				authorTextBox.Text = Infrastructure.Utility.FixText(authorTextBox.Text);
				translatorTextBox.Text = Infrastructure.Utility.FixText(translatorTextBox.Text);

				var request =
					databaseContext.Resources
					.AsQueryable()
					;

				if (titleTextBox.Text != string.Empty)
				{
					request =
						request
						.Where(current => current.Title.Contains(titleTextBox.Text));
				}

				if (authorTextBox.Text != string.Empty)
				{
					request =
						request
						.Where(current => current.Author.Contains(authorTextBox.Text));
				}

				if (translatorTextBox.Text != string.Empty)
				{
					request =
						request
						.Where(current => current.Translator.Contains(translatorTextBox.Text));
				}

				request =
					request
					.OrderByDescending(current => current.VisitCount);

				var result =
					request
					.ToList()
					;

				// **************************************************
				myDataGridView.DataSource = result;
				myDataGridView.Columns[nameof(Models.Resource.Id)].DisplayIndex = 0;
				// **************************************************
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
					databaseContext = null;
				}
			}
		}

		private void DisplayButton_Click(object sender, System.EventArgs e)
		{
			if (myDataGridView.CurrentRow == null)
			{
				System.Windows.Forms.MessageBox.Show("You did not select any row!");
				return;
			}

			string selectedIdString =
				myDataGridView.CurrentRow.Cells[nameof(Models.Resource.Id)].Value.ToString();

			DisplayResourceForm displayResourceForm = new DisplayResourceForm
			{
				Id = System.Convert.ToInt32(selectedIdString),
			};

			displayResourceForm.ShowDialog();

			Search();
		}

		private void ResourceListForm_Load(object sender, System.EventArgs e)
		{
		}
	}
}
