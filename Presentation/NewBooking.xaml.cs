using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        public NewUser()
        {
            InitializeComponent();
        }
        /*
         * TO DO
         * Complete Validation
         * Recieve All inputs
         * Complete Total
         * pat self on back
         */


        private void GuestIn_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
            
        }

        private void BFast_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Cnfrm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Booking newBooking = new Booking();
                newBooking.StartDate = StrtDte.SelectedDate.Value;
                newBooking.EndDate = Enddte.SelectedDate.Value;
                newBooking.TotalDays = (Convert.ToInt16(newBooking.EndDate - newBooking.StartDate));
                newBooking.TotalGuest = (Convert.ToInt16(GuestIn));
                if (BFast.IsChecked == true)
                {
                    newBooking.Breakfast = true;
                }
                if (Dinner.IsChecked == true)
                {
                    newBooking.Dinner = true;
                }
                if (Cars.IsChecked == true)
                {
                    newBooking.CarHire = true;
                }
            }catch (Exception excep)
 {
 Console.WriteLine(excep.Message);
 }

        }
    }
}
