using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareGestione.Core.ViewModel
{
    public class TableViewModel
    {
        [Key]
        public int Id { get; set; }
        public string References_Law { get; set; }
        public string? WorkName { get; set; }
        public string? PANAme { get; set; }
        public string? Priority { get; set; }
        public bool? Done { get; set; }

    }

    public class CreateTableViewModel
    {
        [Display(Name = "Legge di riferimento")]
        public string References_Law { get; set; }
        [Display(Name = "Applicabile")]
        public bool? Applicable { get; set; }
        [Display(Name = "Attività/Obbiettivo")]
        public string? Activity_Description { get; set; }
        [Display(Name = "Periodicità")]
        public string? Priority { get; set; }
        [Display(Name = "Agg.Normativo")]
        public bool? Update_Normative { get; set; }
        [Display(Name = "Azioni/Interventi DA EFFETTUARE")]
        public string? Actions_ToBeCarryOut { get; set; }
        [Display(Name = "Resp")]
        public string? Responsible_Name { get; set; }
        [Display(Name = "Amb")]
        public bool? Amb { get; set; }
        [Display(Name = "SS")]
        public bool? SS { get; set; }
        [Display(Name = "Archiviazione")]
        public bool? Storaged { get; set; }
        [Display(Name = "Progetto")]
        public string? Project { get; set; }
        [Display(Name = "Energia")]
        public bool? Energy { get; set; }
        [Display(Name = "COD")]
        public int? COD { get; set; }
        [Display(Name = "Prioritario")]
        public bool? SPriority { get; set; }
        [Display(Name = "Riservato")]
        public bool? Confidential { get; set; }
        [Display(Name = "Nr. gg Preavviso")]
        public int? DaysNotice { get; set; }
        [Display(Name = "Oggetto")]
        public string? WorkTitle { get; set; }
        [Display(Name = "Tipo PA")]
        public string? PAType { get; set; }
        [Display(Name = "Mansione Resp")]
        public string JobTitle { get; set; }
        public int year { get; set; }  
    }

    public class DoneViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Da effettuare entro il")]
        public DateTime? Deadline { get; set; }
        [Display(Name = "Effettuato il")]
        public DateTime? WorkDoneDate { get; set; }
        [Display(Name = "Azioni/Interventi EFFETTUATI")]
        public string? Actions_ToBeCarriedOut { get; set; }
        [Display(Name = "Attuato")]
        public bool? WorkDoneCheck { get; set; }
        [Display(Name = "Data di creazione scheda")]
        public DateTime? CreatedDate { get; set; }
    }

    

    public class EditViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Legge di riferimento")]
        public string References_Law { get; set; }
        [Display(Name = "Applicabile")]
        public bool? Applicable { get; set; }
        [Display(Name = "Attività/Obbiettivo")]
        public string? Activity_Description { get; set; }
        [Display(Name = "Periodicità")]
        public string? Priority { get; set; }
        [Display(Name = "Agg.Normativo")]
        public bool? Update_Normative { get; set; }
        [Display(Name = "Azioni/Interventi DA EFFETTUARE")]
        public string? Actions_ToBeCarryOut { get; set; }
        [Display(Name = "Da effettuare entro il")]
        public DateTime? Deadline { get; set; }
        [Display(Name = "Resp")]
        public string? Responsible_Name { get; set; }
        [Display(Name = "Effettuato il")]
        public DateTime? WorkDoneDate { get; set; }
        [Display(Name = "Amb")]
        public bool? Amb { get; set; }
        [Display(Name = "SS")]
        public bool? SS { get; set; }
        [Display(Name = "Azioni/Interventi EFFETTUATI")]
        public string? Actions_ToBeCarriedOut { get; set; }
        [Display(Name = "Attuato")]
        public bool? WorkDoneCheck { get; set; }
        [Display(Name = "Archiviazione")]
        public bool? Storaged { get; set; }
        [Display(Name = "Progetto")]
        public string? Project { get; set; }
        [Display(Name = "Data di creazione scheda")]
        public DateTime? CreatedDate { get; set; }
        [Display(Name = "Energia")]
        public bool? Energy { get; set; }
        [Display(Name = "COD")]
        public int? COD { get; set; }
        [Display(Name = "Prioritario")]
        public bool? SPriority { get; set; }
        [Display(Name = "Riservato")]
        public bool? Confidential { get; set; }
        public int? DaysNotice { get; set; }
        public string? WorkTitle { get; set; }
        [Display(Name = "Tipo PA")]
        public string? PAType { get; set; }
        [Display(Name = "Mansione Resp")]
        public string JobTitle { get; set; }
        public int year { get; set; }
    }
}

