using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using PicturePuller.Data;

namespace PicturePuller
{
    public partial class ConDataService
    {
        private readonly ConDataContext context;
        private readonly NavigationManager navigationManager;

        public ConDataService(ConDataContext context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public async Task ExportImageTypesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/imagetypes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? fileName : "Export")}')") : $"export/condata/imagetypes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? fileName : "Export")}')", true);
        }

        public async Task ExportImageTypesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/imagetypes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? fileName : "Export")}')") : $"export/condata/imagetypes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? fileName : "Export")}')", true);
        }

        partial void OnImageTypesRead(ref IQueryable<Models.ConData.ImageType> items);

        public async Task<IQueryable<Models.ConData.ImageType>> GetImageTypes(Query query = null)
        {
            var items = context.ImageTypes.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnImageTypesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnImageTypeCreated(Models.ConData.ImageType item);

        public async Task<Models.ConData.ImageType> CreateImageType(Models.ConData.ImageType imageType)
        {
            OnImageTypeCreated(imageType);

            context.ImageTypes.Add(imageType);
            context.SaveChanges();

            return imageType;
        }

        partial void OnImageTypeDeleted(Models.ConData.ImageType item);

        public async Task<Models.ConData.ImageType> DeleteImageType(int? imageTypeId)
        {
            var item = context.ImageTypes
                              .Where(i => i.ImageTypeID == imageTypeId)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnImageTypeDeleted(item);

            context.ImageTypes.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnImageTypeGet(Models.ConData.ImageType item);

        public async Task<Models.ConData.ImageType> GetImageTypeByImageTypeId(int? imageTypeId)
        {
            var items = context.ImageTypes
                              .AsNoTracking()
                              .Where(i => i.ImageTypeID == imageTypeId);

            var item = items.FirstOrDefault();

            OnImageTypeGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.ConData.ImageType> CancelImageTypeChanges(Models.ConData.ImageType item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnImageTypeUpdated(Models.ConData.ImageType item);

        public async Task<Models.ConData.ImageType> UpdateImageType(int? imageTypeId, Models.ConData.ImageType imageType)
        {
            OnImageTypeUpdated(imageType);

            var item = context.ImageTypes
                              .Where(i => i.ImageTypeID == imageTypeId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(imageType);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return imageType;
        }
    }
}
