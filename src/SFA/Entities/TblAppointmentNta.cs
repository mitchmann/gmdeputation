﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SFA.Entities
{
    [Table("Tbl_Appointment_NTA", Schema = "Global")]
    public partial class TblAppointmentNta
    {

        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime EventDate { get; set; }
        public TimeSpan? EventTime { get; set; }
        public int ChurchId { get; set; }
        public int? MacroScheduleDetailId { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal? PimAmount { get; set; }
        [StringLength(100)]
        public string Offering { get; set; }
        [StringLength(100)]
        public string Notes { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        public bool IsSubmit { get; set; }
        public int? SubmittedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SubmittedOn { get; set; }
        [Column("IsAcceptByDGMD")]
        public bool IsAcceptByDgmd { get; set; }
        public bool IsCreatedByPastor { get; set; }
        public bool IsAcceptByPastor { get; set; }
        public bool IsRejectByPastor { get; set; }
        [StringLength(100)]
        public string AcceptByPastorRemarks { get; set; }
        public int? AcceptByPastorBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AcceptByPastorOn { get; set; }
        public bool IsForwardForMissionary { get; set; }
        public int? ForwadedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ForwadedOn { get; set; }
        public bool IsAcceptMissionary { get; set; }
        [StringLength(100)]
        public string AcceptMissionaryRemarks { get; set; }
        public int? AcceptMissionaryBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AcceptMissionaryOn { get; set; }
        [Column("INSERT_USER")]
        [StringLength(100)]
        public string InsertUser { get; set; }
        [Column("UPDATE_USER")]
        [StringLength(100)]
        public string UpdateUser { get; set; }
        [Column("INSERT_DATETIME", TypeName = "datetime")]
        public DateTime? InsertDatetime { get; set; }
        [Column("UPDATE_DATETIME", TypeName = "datetime")]
        public DateTime? UpdateDatetime { get; set; }

        [Column("SERVICE_TYPE_ID")]
        public int ServiceTypeId { get; set; }
        [Column("OFFERING_ONLY")]
        public bool OfferingOnly { get; set; }

        [Column("IsCanceled")]
        public bool IsCanceled { get; set; }

        public int? IsCanceledBy { get; set; }
        

        [Column("Cancellation_DateTime", TypeName = "datetime")]
        public DateTime? Cancellation_DateTime { get; set; }

        [StringLength(250)]
        public string Cancellation_Notes { get; set; }

        public TblUserNta AcceptByPastorByNavigation { get; set; }
        public TblUserNta AcceptMissionaryByNavigation { get; set; }
        public TblChurchNta Church { get; set; }
        public TblUserNta CreatedByNavigation { get; set; }
        public TblMacroScheduleDetailsNta MacroScheduleDetail { get; set; }
        public TblUserNta SubmittedByNavigation { get; set; }
        public virtual TblServiceTypeNta ServiceType { get; set; }

    }
}
