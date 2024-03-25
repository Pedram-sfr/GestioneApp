using GestioneApp.Core.Services.Interfaces;
using GestioneApp.DataLayer.Context;
using GestioneApp.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using SoftwareGestione.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneApp.Core.Services
{
    public class LegislativeAuditService : ILegislativeAuditService
    {
        GestioneAppContext _context;
        public LegislativeAuditService(GestioneAppContext context)
        {
            _context = context;
        }

        public List<TableViewModel> GetAllLegislativeAuditForMain(string searchtext = "")
        {
            List<TableViewModel> list = (from la in _context.tb_LegislativeAudits
                                         select new TableViewModel
                                         {
                                             Id = la.Id,
                                             References_Law = la.References_Law,
                                             WorkName = la.WorkTitle,
                                             PANAme = la.PAType,
                                             Priority = la.Priority,
                                             Done = la.WorkDoneCheck
                                         }).Where(p => EF.Functions.Like(p.References_Law, "%" + searchtext + "%")).ToList();
            return list;

        }

        public List<TableViewModel> test(string searchtext = "")
        {
            List<TableViewModel> list = new List<TableViewModel>();
            for (int i = 0; i < 300; i++)
            {
                list.Add(new TableViewModel { Id = i, References_Law = "test refrence" + i, PANAme = "PA" + i, WorkName = "work" + i, Priority = "priority" + i });
            }
            return list.Where(p => EF.Functions.Like(p.References_Law, "%" + searchtext + "%")).ToList();
        }

        

        public bool AddLegislativeAudit(tb_LegislativeAudit legislativeAudit)
        {
            _context.Add(legislativeAudit);
            int res = _context.SaveChanges();
            if (res > 0)
                return true;
            return false;
        }

        public bool DeleteLegislativeAudit(tb_LegislativeAudit legislativeAudit)
        {
            _context.Remove(legislativeAudit);
            int res = _context.SaveChanges();
            if (res > 0)
                return true;
            return false;
        }

        public tb_LegislativeAudit GetLegislativeAudit(int id)
        {
            return _context.Find<tb_LegislativeAudit>(id);
        }

        public bool DoneLegislativeAudit(tb_LegislativeAudit legislativeAudit)
        {

            _context.Update(legislativeAudit);
            int res = _context.SaveChanges();
            if (res > 0)
                return true;
            return false;

        }
    }
}
