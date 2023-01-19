using System;
using System.Diagnostics;
using System.Text;
using Code.MVVM.Views;

namespace Code.Utilities
{
    public static class NavUtilities
    {
        public static void Examine(INavigation navigation)
        {
            StringBuilder builder = new StringBuilder();

            foreach (var page in navigation.NavigationStack)
                builder.AppendLine(page.GetType().Name);

            builder.AppendLine("------------");
            Debug.WriteLine(builder.ToString());

        }

        public static void InsertPage(INavigation navigation)
        {
            navigation.InsertPageBefore(new CoolView(), navigation.NavigationStack.ElementAtOrDefault(1));
        }

        public static void DeletePage(INavigation navigation, string pageNameDelete)
        {
            navigation.RemovePage(navigation.NavigationStack.FirstOrDefault(x=>x.GetType().Name == pageNameDelete));
        }
    }
}

