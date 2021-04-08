using Blazorise.Sidebar;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LucyWebsite {
    public static class SidebarInfoProcessor {

        public static string ToJson(SidebarInfo sidebarInfo){

            string newstring = sidebarInfo.ToString();
            return newstring;

        }
    }
}