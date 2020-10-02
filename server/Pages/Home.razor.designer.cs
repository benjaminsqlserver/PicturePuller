using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using PicturePuller.Models.ConData;
using Microsoft.EntityFrameworkCore;

namespace PicturePuller.Pages
{
    public partial class HomeComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected ConDataService ConData { get; set; }

        protected RadzenGrid<PicturePuller.Models.Hit> grid0;

        IEnumerable<PicturePuller.Models.ConData.ImageType> _getImageTypesResult;
        protected IEnumerable<PicturePuller.Models.ConData.ImageType> getImageTypesResult
        {
            get
            {
                return _getImageTypesResult;
            }
            set
            {
                if (!object.Equals(_getImageTypesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getImageTypesResult", NewValue = value, OldValue = _getImageTypesResult };
                    _getImageTypesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        string _searchTerm;
        protected string searchTerm
        {
            get
            {
                return _searchTerm;
            }
            set
            {
                if (!object.Equals(_searchTerm, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "searchTerm", NewValue = value, OldValue = _searchTerm };
                    _searchTerm = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        string _imageType;
        protected string imageType
        {
            get
            {
                return _imageType;
            }
            set
            {
                if (!object.Equals(_imageType, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "imageType", NewValue = value, OldValue = _imageType };
                    _imageType = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<PicturePuller.Models.Hit> _getImageResult;
        protected IEnumerable<PicturePuller.Models.Hit> getImageResult
        {
            get
            {
                return _getImageResult;
            }
            set
            {
                if (!object.Equals(_getImageResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getImageResult", NewValue = value, OldValue = _getImageResult };
                    _getImageResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var conDataGetImageTypesResult = await ConData.GetImageTypes();
            getImageTypesResult = conDataGetImageTypesResult;

            searchTerm = "";

            imageType = "";

            getImageResult = new List<PicturePuller.Models.Hit>(){};
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            await FetchImages();
        }

        protected async System.Threading.Tasks.Task Button1Click(MouseEventArgs args)
        {
            await Reset();
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(PicturePuller.Models.Hit args)
        {
            DialogService.Open<ImageDetails>($"Image Details", new Dictionary<string, object>() { {"ID", args.largeImageURL} }, new DialogOptions(){ Width = $"{800}px",Height = $"{800}px" });
        }
    }
}
