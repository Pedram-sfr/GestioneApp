using GestioneApp.DataLayer.Entities;
using SoftwareGestione.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneApp.Core.Services.Interfaces
{
    public interface ILegislativeAuditService
    {
        List<TableViewModel> GetAllLegislativeAuditForMain(string searchtext = "");
        List<TableViewModel> test(string searchtext = "");
        bool AddLegislativeAudit(tb_LegislativeAudit legislativeAudit);
        bool DeleteLegislativeAudit(tb_LegislativeAudit legislativeAudit);
        tb_LegislativeAudit GetLegislativeAudit(int id);
        bool DoneLegislativeAudit(tb_LegislativeAudit legislativeAudit);
    }
}
