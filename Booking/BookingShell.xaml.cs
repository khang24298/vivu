﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Booking
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingShell : Shell
    {
        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public BookingShell()
        {
            InitializeComponent();
        }
    }
}