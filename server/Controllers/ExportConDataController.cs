using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PicturePuller.Data;

namespace PicturePuller
{
    public partial class ExportConDataController : ExportController
    {
        private readonly ConDataContext context;

        public ExportConDataController(ConDataContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/ConData/imagetypes/csv")]
        [HttpGet("/export/ConData/imagetypes/csv(fileName='{fileName}')")]
        public FileStreamResult ExportImageTypesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.ImageTypes, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/imagetypes/excel")]
        [HttpGet("/export/ConData/imagetypes/excel(fileName='{fileName}')")]
        public FileStreamResult ExportImageTypesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.ImageTypes, Request.Query), fileName);
        }
    }
}
