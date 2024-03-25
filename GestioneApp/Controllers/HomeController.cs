using GestioneApp.Core.Services.Interfaces;
using GestioneApp.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareGestione.Core.ViewModel;

namespace GestioneApp.Controllers
{
    public class HomeController : Controller
    {
        ILegislativeAuditService _LAS;
        public HomeController(ILegislativeAuditService legislativeAuditService)
        {
            _LAS = legislativeAuditService;
        }

        public IActionResult Index(int page = 1, string searchtext = "")
        {
            ViewBag.PageId = page;
            int totalcount = _LAS.GetAllLegislativeAuditForMain(searchtext).Count();
            int pageitem = 8;
            int skip = (page - 1) * pageitem;
            ViewBag.PageCount = totalcount / pageitem;
            ViewBag.searchtext = searchtext;
            if (totalcount % pageitem != 0)
            {
                ViewBag.PageCount = (totalcount / pageitem) + 1;
            }
            var list = _LAS.GetAllLegislativeAuditForMain(searchtext).Skip(skip).Take(pageitem);
            return View(list);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateTableViewModel table)
        {
            if (!ModelState.IsValid)
            {
                return View(table);
            }

            switch (table.Priority)
            {
                case "Annuale":
                    {
                        table.year = 1;
                        break;
                    }
                case "Triennale":
                    {
                        table.year = 3;
                        break;
                    }
                case "Biennale":
                    {
                        table.year = 2;
                        break;
                    }
                case "Quadriennale":
                    {
                        table.year = 4;
                        break;
                    }
                case "Decennale":
                    {
                        table.year = 10;
                        break;
                    }
                case "Quinquennale":
                    {
                        table.year = 5;
                        break;
                    }
            }
            tb_LegislativeAudit legislativeAudit = new tb_LegislativeAudit
            {
                References_Law = table.References_Law,
                Applicable = table.Applicable,
                Activity_Description = table.Activity_Description,
                Priority = table.Priority,
                Update_Normative = table.Update_Normative,
                Actions_ToBeCarryOut = table.Actions_ToBeCarryOut,
                Responsible_Name = table.Responsible_Name,
                Amb = table.Amb,
                SS = table.SS,
                Storaged = table.Storaged,
                DaysNotice = table.DaysNotice,
                Project = table.Project,
                CreatedDate = DateTime.Now,
                Energy = table.Energy,
                COD = table.COD,
                SPriority = table.SPriority,
                Confidential = table.Confidential,
                JobTitle = table.JobTitle,
                WorkTitle = table.WorkTitle,
                PAType = table.PAType,
                WorkDoneCheck = false,
                Deadline = DateTime.Now.AddYears(table.year),
            };

            bool res = _LAS.AddLegislativeAudit(legislativeAudit);
            TempData["res"] = res ? "success" : "faild";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            tb_LegislativeAudit legislativeAudit = _LAS.GetLegislativeAudit(id);
            if (legislativeAudit == null)
            {
                TempData["res"] = "faild";
                return RedirectToAction(nameof(Index));
            }
            bool res = _LAS.DeleteLegislativeAudit(legislativeAudit);
            TempData["res"] = res ? "success" : "faild";
            return RedirectToAction(nameof(Index));


        }

        public IActionResult Done(int id)
        {
            tb_LegislativeAudit legislativeAudit = _LAS.GetLegislativeAudit(id);
            if (legislativeAudit == null)
            {
                TempData["res"] = "faild";
                return RedirectToAction(nameof(Index));
            }

            DoneViewModel doneView = new DoneViewModel()
            {
                Id = id,
                Actions_ToBeCarriedOut = legislativeAudit.Actions_ToBeCarriedOut,
                CreatedDate = legislativeAudit.CreatedDate,
                Deadline = legislativeAudit.Deadline,
                WorkDoneCheck = legislativeAudit.WorkDoneCheck,
                WorkDoneDate = legislativeAudit.WorkDoneDate,
            };
            return View(doneView);
        }

        [HttpPost]
        public IActionResult Done(DoneViewModel doneView)
        {
            if (!ModelState.IsValid)
                return View(Index);
            var table = _LAS.GetLegislativeAudit(int.Parse(TempData["Id"].ToString()));
            table.Actions_ToBeCarriedOut = doneView.Actions_ToBeCarriedOut;
            table.WorkDoneCheck = true;
            table.WorkDoneDate = doneView.WorkDoneDate;
            

            bool res = _LAS.DoneLegislativeAudit(table);
            TempData["res"] = res ? "success" : "faild";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult EditlegislativeAudit(int id)
        {
            tb_LegislativeAudit legislativeAudit = _LAS.GetLegislativeAudit(id);
            if (legislativeAudit == null)
            {
                TempData["res"] = "faild";
                return RedirectToAction(nameof(Index));
            }
            EditViewModel editView = new EditViewModel()
            {
                Id = legislativeAudit.Id,
                Actions_ToBeCarriedOut = legislativeAudit.Actions_ToBeCarriedOut,
                Actions_ToBeCarryOut = legislativeAudit.Actions_ToBeCarryOut,
                Activity_Description = legislativeAudit.Activity_Description,
                Amb = legislativeAudit.Amb,
                Applicable = legislativeAudit.Applicable,
                COD = legislativeAudit.COD,
                Confidential = legislativeAudit.Confidential,
                CreatedDate = legislativeAudit.CreatedDate,
                DaysNotice = legislativeAudit.DaysNotice,
                Deadline = legislativeAudit.Deadline,
                Energy = legislativeAudit.Energy,
                JobTitle = legislativeAudit.JobTitle,
                PAType = legislativeAudit.PAType,
                Priority = legislativeAudit.Priority,
                Project = legislativeAudit.Project,
                References_Law = legislativeAudit.References_Law,
                Responsible_Name = legislativeAudit.Responsible_Name,
                SPriority = legislativeAudit.SPriority,
                SS = legislativeAudit.SS,
                Storaged = legislativeAudit.Storaged,
                Update_Normative = legislativeAudit.Update_Normative,
                WorkDoneCheck = legislativeAudit.WorkDoneCheck,
                WorkDoneDate = legislativeAudit.WorkDoneDate,
                WorkTitle = legislativeAudit.WorkTitle,
            };
            return View(editView);
        }

        [HttpPost]
        public IActionResult EditlegislativeAudit(EditViewModel edit)
        {
            if (!ModelState.IsValid)
                return View(Index);
            var el = _LAS.GetLegislativeAudit(int.Parse(TempData["Id"].ToString()));
            switch (edit.Priority)
            {
                case "Annuale":
                    {
                        edit.year = 1;
                        break;
                    }
                case "Triennale":
                    {
                        edit.year = 3;
                        break;
                    }
                case "Biennale":
                    {
                        edit.year = 2;
                        break;
                    }
                case "Quadriennale":
                    {
                        edit.year = 4;
                        break;
                    }
                case "Decennale":
                    {
                        edit.year = 10;
                        break;
                    }
                case "Quinquennale":
                    {
                        edit.year = 5;
                        break;
                    }
            }
            el.Actions_ToBeCarriedOut = edit.Actions_ToBeCarriedOut;
            el.Actions_ToBeCarryOut = edit.Actions_ToBeCarryOut;
            el.Activity_Description = edit.Activity_Description;
            el.Amb = edit.Amb;
            el.Applicable = edit.Applicable;
            el.COD = edit.COD;
            el.Confidential = edit.Confidential;
            el.DaysNotice = edit.DaysNotice;
            el.Deadline = el.CreatedDate.AddYears(edit.year);
            el.Energy = edit.Energy;
            el.JobTitle = edit.JobTitle;
            el.PAType = edit.PAType;
            el.Priority = edit.Priority;
            el.Project = edit.Project;
            el.References_Law = edit.References_Law;
            el.Responsible_Name = edit.Responsible_Name;
            el.SPriority = edit.SPriority;
            el.SS = edit.SS;
            el.Storaged = edit.Storaged;
            el.Update_Normative = edit.Update_Normative;
            el.WorkTitle = edit.WorkTitle;
            
            bool res = _LAS.DoneLegislativeAudit(el);
            TempData["res"] = res ? "success" : "faild";
            return RedirectToAction(nameof(Index));
        }
    }
}
