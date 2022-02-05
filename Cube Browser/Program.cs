using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cube_Browser
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppContainer appContainer = new AppContainer();
            
            appContainer.Tabs.Add(
                new TitleBarTab(appContainer)
                {
                    Content = new frmBrowser
                    {
                        Text = "Nueva pestaña"
                    }
                }
            );

            appContainer.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(appContainer);
            Application.Run(applicationContext);

        }
    }
}
