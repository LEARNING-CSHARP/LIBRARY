﻿//namespace MyApplication.Infrastructure
namespace Infrastructure
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static string FixText(string text)
		{
			if (text == null)
			{
				return string.Empty;
			}

			string result = text.Trim();

			if (result == string.Empty)
			{
				return string.Empty;
			}

			while (result.Contains("  "))
			{
				result =
					result.Replace("  ", " ");
			}

			return result;
		}

		// **************************************************
		// **************************************************
		// **************************************************
		//public static string FullName { get; set; }
		//public static string Username { get; set; }
		//public static System.Guid? UserId { get; set; }
		// **************************************************

		// **************************************************
		public static Models.User AuthenticatedUser { get; set; }
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// Solution (1)
		// **************************************************

		// **************************************************
		//public static MyApplication.MainForm MainForm;
		//public static MyApplication.LoginForm LoginForm;
		//public static MyApplication.RegisterForm RegisterForm;
		// **************************************************

		// **************************************************
		// /Solution (1)
		// **************************************************

		// **************************************************
		// Solution (2)
		// **************************************************

		// **************************************************
		//public static MyApplication.MainForm MainForm = new MyApplication.MainForm();
		//public static MyApplication.LoginForm LoginForm = new MyApplication.LoginForm();
		//public static MyApplication.RegisterForm RegisterForm = new MyApplication.RegisterForm();
		// **************************************************

		// **************************************************
		// /Solution (2)
		// **************************************************

		// **************************************************
		// Solution (3)
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		private static MyApplication.MainForm mainForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.MainForm MainForm
		{
			get
			{
				if (mainForm == null || mainForm.IsDisposed)
				{
					mainForm =
						new MyApplication.MainForm();
				}

				return mainForm;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		private static MyApplication.LoginForm loginForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.LoginForm LoginForm
		{
			get
			{
				if (loginForm == null || loginForm.IsDisposed)
				{
					loginForm =
						new MyApplication.LoginForm();
				}

				return loginForm;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// **************************************************
		// **************************************************
		private static MyApplication.RegisterForm registerForm;
		// **************************************************

		// **************************************************
		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// </summary>
		public static MyApplication.RegisterForm RegisterForm
		{
			get
			{
				if (registerForm == null || registerForm.IsDisposed)
				{
					registerForm =
						new MyApplication.RegisterForm();
				}

				return registerForm;
			}
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// /Solution (3)
		// **************************************************
	}
}
