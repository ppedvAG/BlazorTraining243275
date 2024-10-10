using Microsoft.AspNetCore.Authorization;

namespace BlazorTraining243275.Components.Pages.Modul2
{
    public class Class
    {
        [Authorize(Roles ="Admin")]
        void methode()
        {

        }
    }
}
