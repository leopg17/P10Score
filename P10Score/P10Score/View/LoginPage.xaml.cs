﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P10Score.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : CarouselPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
	}
}