using ClientCheck.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace ClientCheck
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public sealed partial class SearchPage : Page
    {


        //moet deze lijst vervangen worden door mijn eigen observeble list? komt dit dan overeen met db?
    private MobileServiceCollection<TodoItem, TodoItem> items;
    private IMobileServiceTable<TodoItem> todoTable = App.MobileService.GetTable<TodoItem>();
    //private IMobileServiceSyncTable<TodoItem> todoTable = App.MobileService.GetSyncTable<TodoItem>(); // offline sync



        private NavigationHelper navigationHelper;
        
        public SearchPage()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //zoket client op en laat resultaat in de resultpage zien
             zoek();
            await zoek();
            this.Frame.Navigate(typeof(ResultPage), items);
           
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void surNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private async Task zoek()
        {
            //await todoTable.Select() ;
            List<TodoItem> items = await todoTable
              .Where(todoItem => todoItem.Name == NameTextBox.Text && todoItem.SurName == surNameTextBox.Text )
                 .ToListAsync();

        }

        //verslag werking prog en hoe opgebouwd grote blokken hoe werkt het  hoe werkt het? pwp geen visual studio alle code in pwp

    }
}
