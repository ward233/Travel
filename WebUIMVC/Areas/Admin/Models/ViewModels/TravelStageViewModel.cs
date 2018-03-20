using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace WebUIMVC.Areas.Admin.Models.ViewModels
{
    public class TravelStageViewModel
    {
        public IEnumerable<TravelCategory> TravelCategories { get; set; }
        public TravelStage TravelStage { get; set; }
    }
}