using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;

namespace PicturePuller.Pages
{
    public partial class ImageDetailsComponent
    {

        private async Task ReturnToHomePage()
        {
            UriHelper.NavigateTo("home", true);
        }

    }
}
