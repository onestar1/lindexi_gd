﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Input.StylusPlugIns;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace KicaicicayiJearjelrelur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                NalbibechaLuhaqayna();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void NalbibechaLuhaqayna()
        {
            Exception exception = null;
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                exception = e;
            }

            if (exception != null)
            {
                ReThrowException(exception);
            }
        }

        private static void ReThrowException(Exception exception)
        {
            throw exception;
        }
    }

    public class Foo : StylusPlugIn
    {
        /// <inheritdoc />
        protected override void OnStylusDown(RawStylusInput rawStylusInput)
        {
            try
            {

            }
            catch (Exception e)
            {
                Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(e).Throw();
                });
            }
        }
    }
}