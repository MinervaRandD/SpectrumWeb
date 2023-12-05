using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SpectrumWeb.Models;

public partial class ArmsSpectrumDevelopmentContext : DbContext
{
    public ArmsSpectrumDevelopmentContext()
    {
    }

    public ArmsSpectrumDevelopmentContext(DbContextOptions<ArmsSpectrumDevelopmentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcMaster> AcMasters { get; set; }

    public virtual DbSet<AcTypeInspect> AcTypeInspects { get; set; }

    public virtual DbSet<AcTypeInspectReset> AcTypeInspectResets { get; set; }

    public virtual DbSet<AcTypeSchedulingFuelEcmMAndE> AcTypeSchedulingFuelEcmMAndEs { get; set; }

    public virtual DbSet<AdAndSb> AdAndSbs { get; set; }

    public virtual DbSet<AdAndSbNrReason> AdAndSbNrReasons { get; set; }

    public virtual DbSet<ApplyTimeLogFile> ApplyTimeLogFiles { get; set; }

    public virtual DbSet<AtaChapActyReliabilityMonitoring> AtaChapActyReliabilityMonitorings { get; set; }

    public virtual DbSet<Atachap> Atachaps { get; set; }

    public virtual DbSet<AtachapSubChap> AtachapSubChaps { get; set; }

    public virtual DbSet<Batchnmbr> Batchnmbrs { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<GuaranteeWarranty> GuaranteeWarranties { get; set; }

    public virtual DbSet<GuaranteeWarrantyBaseView> GuaranteeWarrantyBaseViews { get; set; }

    public virtual DbSet<Inspection> Inspections { get; set; }

    public virtual DbSet<InspectionPart> InspectionParts { get; set; }

    public virtual DbSet<InspectionReset> InspectionResets { get; set; }

    public virtual DbSet<InspectionResult> InspectionResults { get; set; }

    public virtual DbSet<InspectionsByPartNmbr> InspectionsByPartNmbrs { get; set; }

    public virtual DbSet<InspectionsByTailNmbr> InspectionsByTailNmbrs { get; set; }

    public virtual DbSet<MaintHistOfIssuesToAc> MaintHistOfIssuesToAcs { get; set; }

    public virtual DbSet<MaintHistOfReceiptsFromAc> MaintHistOfReceiptsFromAcs { get; set; }

    public virtual DbSet<PartNumberXref> PartNumberXrefs { get; set; }

    public virtual DbSet<PartQuotation> PartQuotations { get; set; }

    public virtual DbSet<PartRequisition> PartRequisitions { get; set; }

    public virtual DbSet<PartRequisitionXRef> PartRequisitionXRefs { get; set; }

    public virtual DbSet<PartTypeMaster> PartTypeMasters { get; set; }

    public virtual DbSet<PartsListRotablesGroup> PartsListRotablesGroups { get; set; }

    public virtual DbSet<PartsMaster> PartsMasters { get; set; }

    public virtual DbSet<PartsOnAc> PartsOnAcs { get; set; }

    public virtual DbSet<PartsOnOrder> PartsOnOrders { get; set; }

    public virtual DbSet<PartsRqstIssued> PartsRqstIssueds { get; set; }

    public virtual DbSet<PhysInv> PhysInvs { get; set; }

    public virtual DbSet<Resources0> Resources0s { get; set; }

    public virtual DbSet<Resources1> Resources1s { get; set; }

    public virtual DbSet<SquawkDeferralDateAudit> SquawkDeferralDateAudits { get; set; }

    public virtual DbSet<SquawkMaster> SquawkMasters { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VendorMaster> VendorMasters { get; set; }

    public virtual DbSet<WarehouseMaster> WarehouseMasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLExpress;Database=ArmsSpectrumDevelopment;Trusted_Connection=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcMaster>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__ac_maste__4ADA2B432D044FCE");

            entity.ToTable("ac_master", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AcIdnt)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("ac_idnt");
            entity.Property(e => e.AircraftType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("aircraft_type");
            entity.Property(e => e.BusClassSeats).HasColumnName("bus_class_seats");
            entity.Property(e => e.CheckForRemvl).HasColumnName("check_for_remvl");
            entity.Property(e => e.CoachSeats).HasColumnName("coach_seats");
            entity.Property(e => e.Cycles).HasColumnName("cycles");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.DateAcquired)
                .HasColumnType("date")
                .HasColumnName("date_acquired");
            entity.Property(e => e.DateDispDuDef)
                .HasColumnType("date")
                .HasColumnName("date_disp_du_def");
            entity.Property(e => e.DaysInService).HasColumnName("days_in_service");
            entity.Property(e => e.DaysOutOfSvc).HasColumnName("days_out_of_svc");
            entity.Property(e => e.Description)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FltFollName)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("flt_foll_name");
            entity.Property(e => e.FrstClassSeats).HasColumnName("frst_class_seats");
            entity.Property(e => e.Hours).HasColumnName("hours");
            entity.Property(e => e.IncRelRpts).HasColumnName("inc_rel_rpts");
            entity.Property(e => e.MaintBase)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("maint_base");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.StatusState)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("status_state");
            entity.Property(e => e.TailNmbr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr");
            entity.Property(e => e.Weeks).HasColumnName("weeks");
        });

        modelBuilder.Entity<AcTypeInspect>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__ac_type___4ADA2B43719E209C");

            entity.ToTable("ac_type_inspects", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.ActyAbbreviatn)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("acty_abbreviatn");
            entity.Property(e => e.AdTerminated)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ad_terminated");
            entity.Property(e => e.AircraftType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("aircraft_type");
            entity.Property(e => e.Description)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.EarlyCycWindow).HasColumnName("early_cyc_window");
            entity.Property(e => e.EarlyHrsWindow).HasColumnName("early_hrs_window");
            entity.Property(e => e.EarlyWksWindow).HasColumnName("early_wks_window");
            entity.Property(e => e.HardDate)
                .HasColumnType("date")
                .HasColumnName("hard_date");
            entity.Property(e => e.InspectName)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("inspect_name");
            entity.Property(e => e.LateCycWindow).HasColumnName("late_cyc_window");
            entity.Property(e => e.LateHrsWindow).HasColumnName("late_hrs_window");
            entity.Property(e => e.LateWksWindow).HasColumnName("late_wks_window");
            entity.Property(e => e.NmbrDaysToAccomp).HasColumnName("nmbr_days_to_accomp");
            entity.Property(e => e.NmbrOfWorkPacks).HasColumnName("nmbr_of_work_packs");
            entity.Property(e => e.NoteRevisionNmbr)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("note_revision_nmbr");
            entity.Property(e => e.OneTimeInspec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("one_time_inspec");
            entity.Property(e => e.PartInstalled)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("part_installed");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.PerfEveryCyc).HasColumnName("perf_every_cyc");
            entity.Property(e => e.PerfEveryHrs).HasColumnName("perf_every_hrs");
            entity.Property(e => e.PerfEveryWks).HasColumnName("perf_every_wks");
            entity.Property(e => e.RepeatEveryCyc).HasColumnName("repeat_every_cyc");
            entity.Property(e => e.RepeatEveryHrs).HasColumnName("repeat_every_hrs");
            entity.Property(e => e.RepeatEveryWks).HasColumnName("repeat_every_wks");
            entity.Property(e => e.ResetTo0)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("reset_to_0");
            entity.Property(e => e.ScndPartNbr)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("scnd_part_nbr");
            entity.Property(e => e.Src)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("src");
            entity.Property(e => e.TaskCardTieIn)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("task_card_tie_in");
            entity.Property(e => e.ThrdPartNbr)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("thrd_part_nbr");
            entity.Property(e => e.ThresholdCyc).HasColumnName("threshold_cyc");
            entity.Property(e => e.ThresholdHrs).HasColumnName("threshold_hrs");
            entity.Property(e => e.ThresholdWks).HasColumnName("threshold_wks");
        });

        modelBuilder.Entity<AcTypeInspectReset>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__ac_type___4ADA2B437755EE8A");

            entity.ToTable("ac_type_inspect_resets", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AircraftType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("aircraft_type");
            entity.Property(e => e.InspectName)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("inspect_name");
            entity.Property(e => e.NameToBeReset)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("name_to_be_reset");
        });

        modelBuilder.Entity<AcTypeSchedulingFuelEcmMAndE>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__ac_type___4ADA2B430EACEC98");

            entity.ToTable("ac_type_scheduling_fuel_ecm_m_and_e", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.ActyAbbreviatn)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("acty_abbreviatn");
            entity.Property(e => e.AvgMachNmbr).HasColumnName("avg_mach_nmbr");
            entity.Property(e => e.BusClassSeats).HasColumnName("bus_class_seats");
            entity.Property(e => e.CabACNmbr).HasColumnName("cab_a_c_nmbr");
            entity.Property(e => e.ChartEpr).HasColumnName("chart_epr");
            entity.Property(e => e.CoachClassSeat).HasColumnName("coach_class_seat");
            entity.Property(e => e.Description)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.EgtLowerLimit).HasColumnName("egt_lower_limit");
            entity.Property(e => e.EgtOffset).HasColumnName("egt_offset");
            entity.Property(e => e.EgtUpperLimit).HasColumnName("egt_upper_limit");
            entity.Property(e => e.FFLowerLimit).HasColumnName("f_f_lower_limit");
            entity.Property(e => e.FFOffset).HasColumnName("f_f_offset");
            entity.Property(e => e.FFUpperLimit).HasColumnName("f_f_upper_limit");
            entity.Property(e => e.FlightFuel).HasColumnName("flight_fuel");
            entity.Property(e => e.FrstClassSeats).HasColumnName("frst_class_seats");
            entity.Property(e => e.FuelFlow).HasColumnName("fuel_flow");
            entity.Property(e => e.GradientFactor).HasColumnName("gradient_factor");
            entity.Property(e => e.GrossWeight).HasColumnName("gross_weight");
            entity.Property(e => e.N1n2LowerLimit).HasColumnName("n1n2_lower_limit");
            entity.Property(e => e.N1n2UpperLimit).HasColumnName("n1n2_upper_limit");
            entity.Property(e => e.NbrOfEngines).HasColumnName("nbr_of_engines");
            entity.Property(e => e.NmbrInCabinCrew).HasColumnName("nmbr_in_cabin_crew");
            entity.Property(e => e.NmbrInCrew)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("nmbr_in_crew");
            entity.Property(e => e.NmbrInFlightCrew).HasColumnName("nmbr_in_flight_crew");
            entity.Property(e => e.NmbrSeatsOnAcft).HasColumnName("nmbr_seats_on_acft");
            entity.Property(e => e.PressAlt).HasColumnName("press_alt");
            entity.Property(e => e.ReactionFactor).HasColumnName("reaction_factor");
            entity.Property(e => e.RpmOffset).HasColumnName("rpm_offset");
            entity.Property(e => e.SpecificRange).HasColumnName("specific_range");
            entity.Property(e => e.TaxiFuel).HasColumnName("taxi_fuel");
            entity.Property(e => e.ThrotOffset).HasColumnName("throt_offset");
            entity.Property(e => e.ThrotlLowerLim).HasColumnName("throtl_lower_lim");
            entity.Property(e => e.ThrotlUpperLim).HasColumnName("throtl_upper_lim");
            entity.Property(e => e.TypeCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("type_code");
        });

        modelBuilder.Entity<AdAndSb>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__ad_and_s__4ADA2B4341C534F5");

            entity.ToTable("ad_and_sb", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.ACModNmbr)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("a_c_mod_nmbr");
            entity.Property(e => e.Adact1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("adact1");
            entity.Property(e => e.Adact2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("adact2");
            entity.Property(e => e.AircraftType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("aircraft_type");
            entity.Property(e => e.AlertYN).HasColumnName("alert_y_n");
            entity.Property(e => e.AlsoComplyNmbr1)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("also_comply_nmbr1");
            entity.Property(e => e.AlsoComplyNmbr2)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("also_comply_nmbr2");
            entity.Property(e => e.AlsoComplyNmbr3)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("also_comply_nmbr3");
            entity.Property(e => e.AlsoComplyNmbr4)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("also_comply_nmbr4");
            entity.Property(e => e.ApplyToSerNmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("apply_to_ser_nmbr");
            entity.Property(e => e.AtaChap)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ata_chap");
            entity.Property(e => e.BridgeToInspec).HasColumnName("bridge_to_inspec");
            entity.Property(e => e.ComplianceDate)
                .HasColumnType("date")
                .HasColumnName("compliance_date");
            entity.Property(e => e.ComplyYN).HasColumnName("comply_y_n");
            entity.Property(e => e.DateComp)
                .HasColumnType("date")
                .HasColumnName("date_comp");
            entity.Property(e => e.DateEntered)
                .HasColumnType("date")
                .HasColumnName("date_entered");
            entity.Property(e => e.DateIssued)
                .HasColumnType("date")
                .HasColumnName("date_issued");
            entity.Property(e => e.DateTerminated)
                .HasColumnType("date")
                .HasColumnName("date_terminated");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.InclInInspec).HasColumnName("incl_in_inspec");
            entity.Property(e => e.ModNmbr).HasColumnName("mod_nmbr");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.OneTimeInspec).HasColumnName("one_time_inspec");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.PerformEveryCy).HasColumnName("perform_every_cy");
            entity.Property(e => e.PerformEveryHr).HasColumnName("perform_every_hr");
            entity.Property(e => e.PerformEveryWk).HasColumnName("perform_every_wk");
            entity.Property(e => e.Resolution)
                .HasColumnType("text")
                .HasColumnName("resolution");
            entity.Property(e => e.RevisionNmbr)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("revision_nmbr");
            entity.Property(e => e.TailNmbrs)
                .HasMaxLength(502)
                .IsUnicode(false)
                .HasColumnName("tail_nmbrs");
            entity.Property(e => e.Terminate).HasColumnName("terminate");
            entity.Property(e => e.TerminateReason)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("terminate_reason");
            entity.Property(e => e.ThresholdCyc).HasColumnName("threshold_cyc");
            entity.Property(e => e.ThresholdHrs).HasColumnName("threshold_hrs");
            entity.Property(e => e.ThresholdWks).HasColumnName("threshold_wks");
            entity.Property(e => e.ThruSerNmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("thru_ser_nmbr");
            entity.Property(e => e.TypeCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("type_code");
            entity.Property(e => e.VendorNumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_number");
        });

        modelBuilder.Entity<AdAndSbNrReason>(entity =>
        {
            entity.HasKey(e => e.PkTransactId).HasName("PK__ad_and_s__BDF67B3A3CD69D36");

            entity.ToTable("ad_and_sb_nr_reasons", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
            entity.Property(e => e.Number)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.Reason)
                .HasColumnType("ntext")
                .HasColumnName("reason");
        });

        modelBuilder.Entity<ApplyTimeLogFile>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__apply_ti__4ADA2B438EA2BA74");

            entity.ToTable("apply_time_log_file", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AFAdjusted).HasColumnName("a_f_adjusted");
            entity.Property(e => e.AFCycAfter).HasColumnName("a_f_cyc_after");
            entity.Property(e => e.AFHoursAfter).HasColumnName("a_f_hours_after");
            entity.Property(e => e.AFWksAfter).HasColumnName("a_f_wks_after");
            entity.Property(e => e.DateApplied)
                .HasColumnType("date")
                .HasColumnName("date_applied");
            entity.Property(e => e.FltNmbr).HasColumnName("flt_nmbr");
            entity.Property(e => e.FromBulkLoad).HasColumnName("from_bulk_load");
            entity.Property(e => e.LegNmbr).HasColumnName("leg_nmbr");
            entity.Property(e => e.NmbrTimesChanged).HasColumnName("nmbr_times_changed");
            entity.Property(e => e.NrevCycApplied).HasColumnName("nrev_cyc_applied");
            entity.Property(e => e.NrevDepartures).HasColumnName("nrev_departures");
            entity.Property(e => e.NrevHrsApplied).HasColumnName("nrev_hrs_applied");
            entity.Property(e => e.NrevWksApplied).HasColumnName("nrev_wks_applied");
            entity.Property(e => e.RevCycApplied).HasColumnName("rev_cyc_applied");
            entity.Property(e => e.RevDepartures).HasColumnName("rev_departures");
            entity.Property(e => e.RevHrsApplied).HasColumnName("rev_hrs_applied");
            entity.Property(e => e.RevWksApplied).HasColumnName("rev_wks_applied");
            entity.Property(e => e.TailNmbr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr");
            entity.Property(e => e.UpdatedByUtil)
                .HasColumnType("date")
                .HasColumnName("updated_by_util");
        });

        modelBuilder.Entity<AtaChapActyReliabilityMonitoring>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__ata_chap__4ADA2B43EE8FC3BD");

            entity.ToTable("ata_chap_acty_reliability_monitoring", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AircraftType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("aircraft_type");
            entity.Property(e => e.AtaCode).HasColumnName("ata_code");
            entity.Property(e => e.CmpGrphLowLim).HasColumnName("cmp_grph_low_lim");
            entity.Property(e => e.CmpRelLowLim).HasColumnName("cmp_rel_low_lim");
            entity.Property(e => e.CmpRelUprLim).HasColumnName("cmp_rel_upr_lim");
            entity.Property(e => e.DateSet1)
                .HasColumnType("date")
                .HasColumnName("date_set1");
            entity.Property(e => e.DateSet2)
                .HasColumnType("date")
                .HasColumnName("date_set2");
            entity.Property(e => e.ETopsSignific)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("e_tops_signific");
            entity.Property(e => e.FltCycDays)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("flt__cyc__days");
            entity.Property(e => e.GraphIncrement1).HasColumnName("graph_increment1");
            entity.Property(e => e.GraphIncrement2).HasColumnName("graph_increment2");
            entity.Property(e => e.MelDefinitions)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("mel_definitions");
            entity.Property(e => e.NbrReliabPoint).HasColumnName("nbr_reliab_point");
            entity.Property(e => e.PartNmbrAtaGroup)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("part_nmbr_ata_group");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.ReliabDate)
                .HasColumnType("date")
                .HasColumnName("reliab_date");
            entity.Property(e => e.ReliabilityData)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("reliability_data");
            entity.Property(e => e.SqkGrphLowLim).HasColumnName("sqk_grph_low_lim");
            entity.Property(e => e.SqkRelLowLim).HasColumnName("sqk_rel_low_lim");
            entity.Property(e => e.SqkRelUprLim).HasColumnName("sqk_rel_upr_lim");
            entity.Property(e => e.TimeValue)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("time_value");
        });

        modelBuilder.Entity<Atachap>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__ATAChap__4ADA2B4375CFCDB7");

            entity.ToTable("ATAChap", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.ChapName)
                .HasMaxLength(1024)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AtachapSubChap>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__ATAChapS__4ADA2B43EF53F565");

            entity.ToTable("ATAChapSubChap", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.SubChapNmbr)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Batchnmbr>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__batchnmb__4ADA2B43786F514C");

            entity.ToTable("batchnmbr", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AtaChapSub)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ata_chap_sub");
            entity.Property(e => e.BatchNmbr1).HasColumnName("batch_nmbr");
            entity.Property(e => e.Blank)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("blank");
            entity.Property(e => e.Description1)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("description1");
            entity.Property(e => e.Description2)
                .HasMaxLength(33)
                .IsUnicode(false)
                .HasColumnName("description2");
            entity.Property(e => e.Description3)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("description3");
            entity.Property(e => e.FrstXRef)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("frst_x_ref");
            entity.Property(e => e.ItemNmbr)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("item_nmbr");
            entity.Property(e => e.Keyword1)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("keyword1");
            entity.Property(e => e.Keyword2)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("keyword2");
            entity.Property(e => e.PartNmbr1)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_nmbr1");
            entity.Property(e => e.PartNmbr2)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_nmbr2");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.Prefix)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("prefix");
            entity.Property(e => e.Rakey)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("rakey");
            entity.Property(e => e.Rbkey)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("rbkey");
            entity.Property(e => e.RefNmbr1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ref_nmbr1");
            entity.Property(e => e.RefNmbr2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ref_nmbr2");
            entity.Property(e => e.Remarks)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Rkkey)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("rkkey");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.XrefActPartNmbr)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("xref_act_part_nmbr");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__companie__4ADA2B436313A270");

            entity.ToTable("companies", "admin");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.Address1)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("address_1");
            entity.Property(e => e.Address2)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("address_2");
            entity.Property(e => e.City)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("company_name");
            entity.Property(e => e.Country)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Email)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Notes)
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.Phone1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("phone1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("phone2");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("postal_code");
            entity.Property(e => e.PrimaryPointOfContact)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("primary_point_of_contact");
            entity.Property(e => e.PrimaryProduct)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("primary_product");
            entity.Property(e => e.Role)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("role");
            entity.Property(e => e.StateOrRegion)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("state_or_region");
            entity.Property(e => e.WebSite)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("web_site");
        });

        modelBuilder.Entity<GuaranteeWarranty>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__guarante__4ADA2B4302CD95EF");

            entity.ToTable("guarantee_warranty", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AtaChap).HasColumnName("ata_chap");
            entity.Property(e => e.ControlTag).HasColumnName("control_tag");
            entity.Property(e => e.CyclesGuaranteed).HasColumnName("cycles_guaranteed");
            entity.Property(e => e.CyclsAtInstall).HasColumnName("cycls_at_install");
            entity.Property(e => e.DateReceived)
                .HasColumnType("date")
                .HasColumnName("date_received");
            entity.Property(e => e.ExchangedSerNmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("exchanged_ser_nmbr");
            entity.Property(e => e.HoursAtInstall).HasColumnName("hours_at_install");
            entity.Property(e => e.HoursGuaranteed).HasColumnName("hours_guaranteed");
            entity.Property(e => e.Notes)
                .HasColumnType("ntext")
                .HasColumnName("notes");
            entity.Property(e => e.Number)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.Revision).HasColumnName("revision");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.Terms)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("terms");
            entity.Property(e => e.VendorNumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_number");
            entity.Property(e => e.WeeksAtInstall).HasColumnName("weeks_at_install");
            entity.Property(e => e.WeeksGuaranteed).HasColumnName("weeks_guaranteed");
        });

        modelBuilder.Entity<GuaranteeWarrantyBaseView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("guarantee_warranty_base_view", "maint");

            entity.Property(e => e.AtaChap).HasColumnName("ata_chap");
            entity.Property(e => e.ControlTag).HasColumnName("control_tag");
            entity.Property(e => e.CyclesGuaranteed).HasColumnName("cycles_guaranteed");
            entity.Property(e => e.CyclsAtInstall).HasColumnName("cycls_at_install");
            entity.Property(e => e.DateReceived)
                .HasColumnType("date")
                .HasColumnName("date_received");
            entity.Property(e => e.ExchangedSerNmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("exchanged_ser_nmbr");
            entity.Property(e => e.HoursAtInstall).HasColumnName("hours_at_install");
            entity.Property(e => e.HoursGuaranteed).HasColumnName("hours_guaranteed");
            entity.Property(e => e.Notes)
                .HasColumnType("ntext")
                .HasColumnName("notes");
            entity.Property(e => e.Number)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("number");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.Revision).HasColumnName("revision");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.Terms)
                .HasMaxLength(72)
                .IsUnicode(false)
                .HasColumnName("terms");
            entity.Property(e => e.VendorNumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_number");
            entity.Property(e => e.WeeksAtInstall).HasColumnName("weeks_at_install");
            entity.Property(e => e.WeeksGuaranteed).HasColumnName("weeks_guaranteed");
        });

        modelBuilder.Entity<Inspection>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__inspecti__4ADA2B431228CA49");

            entity.ToTable("inspections", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AcftType)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("acft_type");
            entity.Property(e => e.ComplDate)
                .HasColumnType("date")
                .HasColumnName("compl_date");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EarlyWindEveryCycles).HasColumnName("early_wind_every_cycles");
            entity.Property(e => e.EarlyWindEveryDays).HasColumnName("early_wind_every_days");
            entity.Property(e => e.EarlyWindEveryHours).HasColumnName("early_wind_every_hours");
            entity.Property(e => e.IncludeOnTaskCard).HasColumnName("include_on_task_card");
            entity.Property(e => e.InspectionName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("inspection_name");
            entity.Property(e => e.LateWindEveryCycles).HasColumnName("late_wind_every_cycles");
            entity.Property(e => e.LateWindEveryDays).HasColumnName("late_wind_every_days");
            entity.Property(e => e.LateWindEveryHours).HasColumnName("late_wind_every_hours");
            entity.Property(e => e.OneTimeInspection).HasColumnName("one_time_inspection");
            entity.Property(e => e.PartNmbr1)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("part_nmbr_1");
            entity.Property(e => e.PartNmbr2)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("part_nmbr_2");
            entity.Property(e => e.PartNmbr3)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("part_nmbr_3");
            entity.Property(e => e.PerfEveryCycles).HasColumnName("perf_every_cycles");
            entity.Property(e => e.PerfEveryDays).HasColumnName("perf_every_days");
            entity.Property(e => e.PerfEveryHours).HasColumnName("perf_every_hours");
            entity.Property(e => e.RepeatEveryCycles).HasColumnName("repeat_every_cycles");
            entity.Property(e => e.RepeatEveryDays).HasColumnName("repeat_every_days");
            entity.Property(e => e.RepeatEveryHours).HasColumnName("repeat_every_hours");
            entity.Property(e => e.ResetToZero).HasColumnName("reset_to_zero");
            entity.Property(e => e.ThreshCycles).HasColumnName("thresh_cycles");
            entity.Property(e => e.ThreshDays).HasColumnName("thresh_days");
            entity.Property(e => e.ThreshHours).HasColumnName("thresh_hours");
            entity.Property(e => e.WorkPackages).HasColumnName("work_packages");
        });

        modelBuilder.Entity<InspectionPart>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__inspecti__4ADA2B43FA97CA04");

            entity.ToTable("inspection_parts", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.MasterInspectionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("master_inspection_id");
            entity.Property(e => e.PartId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("part_id");
        });

        modelBuilder.Entity<InspectionReset>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__inspecti__4ADA2B4379BA4B21");

            entity.ToTable("inspection_resets", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.MasterInspectionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("master_inspection_id");
            entity.Property(e => e.ResetInspectionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("reset_inspection_id");
        });

        modelBuilder.Entity<InspectionResult>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__inspecti__4ADA2B4349CFEF67");

            entity.ToTable("inspection_results", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AirframeTotalCycles).HasColumnName("airframe_total_cycles");
            entity.Property(e => e.AirframeTotalDays).HasColumnName("airframe_total_days");
            entity.Property(e => e.AirframeTotalHours).HasColumnName("airframe_total_hours");
            entity.Property(e => e.CyclesAfterReset).HasColumnName("cycles_after_reset");
            entity.Property(e => e.CyclesBeforeReset).HasColumnName("cycles_before_reset");
            entity.Property(e => e.DaysAfterReset).HasColumnName("days_after_reset");
            entity.Property(e => e.DaysBeforeReset).HasColumnName("days_before_reset");
            entity.Property(e => e.DeferDate)
                .HasColumnType("date")
                .HasColumnName("defer_date");
            entity.Property(e => e.DeferReason)
                .HasColumnType("text")
                .HasColumnName("defer_reason");
            entity.Property(e => e.HoursAfterReset).HasColumnName("hours_after_reset");
            entity.Property(e => e.HoursBeforeReset).HasColumnName("hours_before_reset");
            entity.Property(e => e.InspectDate)
                .HasColumnType("date")
                .HasColumnName("inspect_date");
            entity.Property(e => e.InspectLocation)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("inspect_location");
            entity.Property(e => e.InspectResults)
                .HasColumnType("text")
                .HasColumnName("inspect_results");
            entity.Property(e => e.InspectionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("inspection_id");
            entity.Property(e => e.NextRepeatCycles).HasColumnName("next_repeat_cycles");
            entity.Property(e => e.NextRepeatDays).HasColumnName("next_repeat_days");
            entity.Property(e => e.NextRepeatHours).HasColumnName("next_repeat_hours");
            entity.Property(e => e.PackageNmbr).HasColumnName("package_nmbr");
            entity.Property(e => e.Reset).HasColumnName("reset");
        });

        modelBuilder.Entity<InspectionsByPartNmbr>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__inspecti__4ADA2B43A4B619D5");

            entity.ToTable("inspections_by_part_nmbr", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AcftType)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("acft_type");
            entity.Property(e => e.CurrWorkPckgNmbr).HasColumnName("curr_work_pckg_nmbr");
            entity.Property(e => e.CyclesCurr).HasColumnName("cycles_curr");
            entity.Property(e => e.CyclesOverride).HasColumnName("cycles_override");
            entity.Property(e => e.CyclesSinceNew).HasColumnName("cycles_since_new");
            entity.Property(e => e.DaysCurr).HasColumnName("days_curr");
            entity.Property(e => e.DaysOverride).HasColumnName("days_override");
            entity.Property(e => e.DaysSinceNew).HasColumnName("days_since_new");
            entity.Property(e => e.DaysToAccomplish).HasColumnName("days_to_accomplish");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.HoursCurr).HasColumnName("hours_curr");
            entity.Property(e => e.HoursOverride).HasColumnName("hours_override");
            entity.Property(e => e.HoursSinceNew).HasColumnName("hours_since_new");
            entity.Property(e => e.InspectionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("inspection_id");
            entity.Property(e => e.InspectionName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("inspection_name");
            entity.Property(e => e.LastAppliedOnDate)
                .HasColumnType("date")
                .HasColumnName("last_applied_on_date");
            entity.Property(e => e.LastPerformedOn)
                .HasColumnType("date")
                .HasColumnName("last_performed_on");
            entity.Property(e => e.PartNmbr)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("part_nmbr");
            entity.Property(e => e.PerformedTimes).HasColumnName("performed_times");
            entity.Property(e => e.ResetToZero).HasColumnName("reset_to_zero");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.TerminateInspection).HasColumnName("terminate_inspection");
        });

        modelBuilder.Entity<InspectionsByTailNmbr>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__inspecti__4ADA2B431823487B");

            entity.ToTable("inspections_by_tail_nmbr", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.CurrWorkPckgNmbr).HasColumnName("curr_work_pckg_nmbr");
            entity.Property(e => e.CyclesCurr).HasColumnName("cycles_curr");
            entity.Property(e => e.CyclesCurrAirframe).HasColumnName("cycles_curr_airframe");
            entity.Property(e => e.CyclesSinceNew).HasColumnName("cycles_since_new");
            entity.Property(e => e.DaysCurr).HasColumnName("days_curr");
            entity.Property(e => e.DaysCurrAirframe).HasColumnName("days_curr_airframe");
            entity.Property(e => e.DaysSinceNew).HasColumnName("days_since_new");
            entity.Property(e => e.DaysToAccomplish).HasColumnName("days_to_accomplish");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.HoursCurr).HasColumnName("hours_curr");
            entity.Property(e => e.HoursCurrAirframe).HasColumnName("hours_curr_airframe");
            entity.Property(e => e.HoursSinceNew).HasColumnName("hours_since_new");
            entity.Property(e => e.InspectionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("inspection_id");
            entity.Property(e => e.InspectionName)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("inspection_name");
            entity.Property(e => e.LastAppliedOnDate)
                .HasColumnType("date")
                .HasColumnName("last_applied_on_date");
            entity.Property(e => e.LastPerformedOn)
                .HasColumnType("date")
                .HasColumnName("last_performed_on");
            entity.Property(e => e.PerformedTimes).HasColumnName("performed_times");
            entity.Property(e => e.ResetToZero).HasColumnName("reset_to_zero");
            entity.Property(e => e.TailNmbr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr");
            entity.Property(e => e.TerminateInspection).HasColumnName("terminate_inspection");
        });

        modelBuilder.Entity<MaintHistOfIssuesToAc>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__maint_hi__4ADA2B432FEA37D7");

            entity.ToTable("maint_hist_of_issues_to_ac", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AtaCode).HasColumnName("ata_code");
            entity.Property(e => e.AtaParagraph).HasColumnName("ata_paragraph");
            entity.Property(e => e.CyclsAtIntsall).HasColumnName("cycls_at_intsall");
            entity.Property(e => e.CyclsSinceNew).HasColumnName("cycls_since_new");
            entity.Property(e => e.CyclsTbo).HasColumnName("cycls_tbo");
            entity.Property(e => e.CyclsThisInst).HasColumnName("cycls_this_inst");
            entity.Property(e => e.CyclsTso).HasColumnName("cycls_tso");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.HoursAtIntsall).HasColumnName("hours_at_intsall");
            entity.Property(e => e.HoursSinceNew).HasColumnName("hours_since_new");
            entity.Property(e => e.HoursTbo).HasColumnName("hours_tbo");
            entity.Property(e => e.HoursThisInst).HasColumnName("hours_this_inst");
            entity.Property(e => e.HoursTso).HasColumnName("hours_tso");
            entity.Property(e => e.IssueNumber).HasColumnName("issue_number");
            entity.Property(e => e.JobCardNmbr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("job_card_nmbr");
            entity.Property(e => e.MatchToReceipt).HasColumnName("match_to_receipt");
            entity.Property(e => e.OverrideAFCyc).HasColumnName("override_a_f_cyc");
            entity.Property(e => e.OverrideAFDay).HasColumnName("override_a_f_day");
            entity.Property(e => e.OverrideAfHrs).HasColumnName("override_af_hrs");
            entity.Property(e => e.PartNmbr)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_nmbr");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.TailNmbr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr");
            entity.Property(e => e.VendorBatch).HasColumnName("vendor_batch");
            entity.Property(e => e.WeeksAtIntsall).HasColumnName("weeks_at_intsall");
            entity.Property(e => e.WeeksSinceNew).HasColumnName("weeks_since_new");
            entity.Property(e => e.WeeksTbo).HasColumnName("weeks_tbo");
            entity.Property(e => e.WeeksThisInst).HasColumnName("weeks_this_inst");
            entity.Property(e => e.WeeksTso).HasColumnName("weeks_tso");
        });

        modelBuilder.Entity<MaintHistOfReceiptsFromAc>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__maint_hi__4ADA2B4306EE1B65");

            entity.ToTable("maint_hist_of_receipts_from_ac", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AtaOfRemoval).HasColumnName("ata_of_removal");
            entity.Property(e => e.AtaParagraph).HasColumnName("ata_paragraph");
            entity.Property(e => e.CyclsAtIntsall).HasColumnName("cycls_at_intsall");
            entity.Property(e => e.CyclsSinceNew).HasColumnName("cycls_since_new");
            entity.Property(e => e.CyclsTbo).HasColumnName("cycls_tbo");
            entity.Property(e => e.CyclsThisInst).HasColumnName("cycls_this_inst");
            entity.Property(e => e.CyclsTso).HasColumnName("cycls_tso");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.DateInstalled)
                .HasColumnType("date")
                .HasColumnName("date_installed");
            entity.Property(e => e.HoursAtIntsall).HasColumnName("hours_at_intsall");
            entity.Property(e => e.HoursSinceNew).HasColumnName("hours_since_new");
            entity.Property(e => e.HoursTbo).HasColumnName("hours_tbo");
            entity.Property(e => e.HoursThisInst).HasColumnName("hours_this_inst");
            entity.Property(e => e.HoursTso).HasColumnName("hours_tso");
            entity.Property(e => e.IssueMatchFlag).HasColumnName("issue_match_flag");
            entity.Property(e => e.LocationOnAC)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("location_on_a_c");
            entity.Property(e => e.OverrideAFCyc).HasColumnName("override_a_f_cyc");
            entity.Property(e => e.OverrideAFDay).HasColumnName("override_a_f_day");
            entity.Property(e => e.OverrideAfHrs).HasColumnName("override_af_hrs");
            entity.Property(e => e.Part)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part");
            entity.Property(e => e.PostionOnAC)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("postion_on_a_c");
            entity.Property(e => e.ReceiptNumber).HasColumnName("receipt_number");
            entity.Property(e => e.RemovalReason)
                .HasMaxLength(74)
                .IsUnicode(false)
                .HasColumnName("removal_reason");
            entity.Property(e => e.SchedRemoveYN)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("sched_remove_y_n");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.TailNmbr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr");
            entity.Property(e => e.UserChgdData)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("user_chgd_data");
            entity.Property(e => e.VoidRecFlag)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("void_rec_flag");
            entity.Property(e => e.WeeksAtIntsall).HasColumnName("weeks_at_intsall");
            entity.Property(e => e.WeeksSinceNew).HasColumnName("weeks_since_new");
            entity.Property(e => e.WeeksTbo).HasColumnName("weeks_tbo");
            entity.Property(e => e.WeeksThisInst).HasColumnName("weeks_this_inst");
            entity.Property(e => e.WeeksTso).HasColumnName("weeks_tso");
            entity.Property(e => e.WhoVoided)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("who_voided");
        });

        modelBuilder.Entity<PartNumberXref>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__part_num__4ADA2B430C1D6476");

            entity.ToTable("part_number_xref", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.FrstXRef)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("frst_x_ref");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.Prefix)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("prefix");
            entity.Property(e => e.Remarks)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.XrefActPartNmbr)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("xref_act_part_nmbr");
        });

        modelBuilder.Entity<PartQuotation>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__part_quo__4ADA2B43A199C5DD");

            entity.ToTable("part_quotations", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.Comments)
                .HasMaxLength(182)
                .IsUnicode(false)
                .HasColumnName("comments");
            entity.Property(e => e.CurrencyOfQt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("currency_of_qt");
            entity.Property(e => e.DateKey)
                .HasColumnType("date")
                .HasColumnName("date_key");
            entity.Property(e => e.KeyPartNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("key_part_number");
            entity.Property(e => e.KeyVendor)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("key_vendor");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.PartNumberKey)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("part_number_key");
            entity.Property(e => e.PnWithPrefix)
                .HasMaxLength(43)
                .IsUnicode(false)
                .HasColumnName("pn_with_prefix");
            entity.Property(e => e.PurchaseQty).HasColumnName("purchase_qty");
            entity.Property(e => e.QuotedPrice).HasColumnName("quoted_price");
            entity.Property(e => e.RefNmbr).HasColumnName("ref_nmbr");
            entity.Property(e => e.RefNmbrKey)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ref_nmbr_key");
            entity.Property(e => e.UnitOfPurchase)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("unit_of_purchase");
            entity.Property(e => e.VendPnSeq)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("vend_pn_seq");
            entity.Property(e => e.VendorKey)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_key");
            entity.Property(e => e.VendorNumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_number");
        });

        modelBuilder.Entity<PartRequisition>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__part_req__4ADA2B435871B78A");

            entity.ToTable("part_requisition", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.CompletedYP)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("completed_y_p");
            entity.Property(e => e.DateCancelled)
                .HasColumnType("date")
                .HasColumnName("date_cancelled");
            entity.Property(e => e.DateEntered)
                .HasColumnType("date")
                .HasColumnName("date_entered");
            entity.Property(e => e.DateLastModif)
                .HasColumnType("date")
                .HasColumnName("date_last_modif");
            entity.Property(e => e.DateOrdered)
                .HasColumnType("date")
                .HasColumnName("date_ordered");
            entity.Property(e => e.DateRequired)
                .HasColumnType("date")
                .HasColumnName("date_required");
            entity.Property(e => e.DetailSeqNmbr).HasColumnName("detail_seq_nmbr");
            entity.Property(e => e.LatestReqDate)
                .HasColumnType("date")
                .HasColumnName("latest_req_date");
            entity.Property(e => e.NbrOfRecords).HasColumnName("nbr_of_records");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.PickedYN)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("picked_y_n");
            entity.Property(e => e.RecordCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("record_code");
            entity.Property(e => e.Requestor).HasColumnName("requestor");
            entity.Property(e => e.ShippingMethod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("shipping_method");
            entity.Property(e => e.ShippingWaybil)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("shipping_waybil");
            entity.Property(e => e.SvcOrdNmbr).HasColumnName("svc_ord_nmbr");
            entity.Property(e => e.TailNmbr)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr");
            entity.Property(e => e.TimeOfOrder).HasColumnName("time_of_order");
            entity.Property(e => e.Tskey)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("tskey");
            entity.Property(e => e.TypeR)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("type_r");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("warehouse");
        });

        modelBuilder.Entity<PartRequisitionXRef>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__part_req__4ADA2B43642F251A");

            entity.ToTable("part_requisition_x_ref", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.DateCancelled)
                .HasColumnType("date")
                .HasColumnName("date_cancelled");
            entity.Property(e => e.OrderDate)
                .HasColumnType("date")
                .HasColumnName("order_date");
            entity.Property(e => e.OrderWhse)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("order_whse");
            entity.Property(e => e.ReqNumber).HasColumnName("req_number");
            entity.Property(e => e.Requestor).HasColumnName("requestor");
            entity.Property(e => e.SvcOrdNmbr).HasColumnName("svc_ord_nmbr");
            entity.Property(e => e.TailNmbr)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr");
            entity.Property(e => e.TsalKey)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("tsal_key");
        });

        modelBuilder.Entity<PartTypeMaster>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__part_typ__4ADA2B4392EDE148");

            entity.ToTable("part_type_master", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.Allotment).HasColumnName("allotment");
            entity.Property(e => e.AveragePrice).HasColumnName("average__price");
            entity.Property(e => e.AvgReprLeadTm).HasColumnName("avg_repr_lead_tm");
            entity.Property(e => e.AvgVendLeadTm).HasColumnName("avg_vend_lead_tm");
            entity.Property(e => e.BinLocation)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("bin_location");
            entity.Property(e => e.CurrentPoNmbr).HasColumnName("current_po_nmbr");
            entity.Property(e => e.CurrentPoType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("current_po_type");
            entity.Property(e => e.CurrentPrice).HasColumnName("current__price");
            entity.Property(e => e.DateUpdated)
                .HasColumnType("date")
                .HasColumnName("date_updated");
            entity.Property(e => e.ExtraDta)
                .HasMaxLength(27)
                .IsUnicode(false)
                .HasColumnName("extra_dta");
            entity.Property(e => e.GLAcctNbr).HasColumnName("g_l_acct_nbr");
            entity.Property(e => e.InSuspense).HasColumnName("in_suspense");
            entity.Property(e => e.IssTypeInUse)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("iss_type_in_use");
            entity.Property(e => e.LastInventDate)
                .HasColumnType("date")
                .HasColumnName("last_invent_date");
            entity.Property(e => e.LastIssueDate)
                .HasColumnType("date")
                .HasColumnName("last_issue_date");
            entity.Property(e => e.LastPoNmbr).HasColumnName("last_po_nmbr");
            entity.Property(e => e.LastPoType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("last_po_type");
            entity.Property(e => e.LastPrice).HasColumnName("last_price");
            entity.Property(e => e.LastRecvdDate)
                .HasColumnType("date")
                .HasColumnName("last_recvd_date");
            entity.Property(e => e.NotesOnPart)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("notes_on_part");
            entity.Property(e => e.NumberOfSpares).HasColumnName("number_of_spares");
            entity.Property(e => e.OrderLevel).HasColumnName("order_level");
            entity.Property(e => e.OrderQuantity).HasColumnName("order_quantity");
            entity.Property(e => e.PartDesignator)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("part_designator");
            entity.Property(e => e.PhyCycleNmbr).HasColumnName("phy_cycle_nmbr");
            entity.Property(e => e.PhyInvActive).HasColumnName("phy_inv_active");
            entity.Property(e => e.PkPartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("pk_part_number");
            entity.Property(e => e.PrcBreakAvail).HasColumnName("prc_break_avail");
            entity.Property(e => e.QtyOnHand).HasColumnName("qty_on_hand");
            entity.Property(e => e.QtyOutForRepr).HasColumnName("qty_out_for_repr");
            entity.Property(e => e.QtyRequested).HasColumnName("qty_requested");
            entity.Property(e => e.QuantityOnOrdr).HasColumnName("quantity_on_ordr");
            entity.Property(e => e.RefnmbrLinksFiles).HasColumnName("refnmbr_links_files");
            entity.Property(e => e.Rwitmx)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("rwitmx");
            entity.Property(e => e.ShelfLocation)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("shelf_location");
            entity.Property(e => e.SixMosStaticUse).HasColumnName("six_mos_static_use");
            entity.Property(e => e.ThreeMosStaticUse).HasColumnName("three_mos_static_use");
            entity.Property(e => e.TwelveMoStaticUse).HasColumnName("twelve_mo_static_use");
            entity.Property(e => e.Used).HasColumnName("used");
            entity.Property(e => e.Vendor1)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor1");
            entity.Property(e => e.Vendor2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor2");
            entity.Property(e => e.Vendor3)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor3");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("warehouse");
        });

        modelBuilder.Entity<PartsListRotablesGroup>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__parts_li__4ADA2B4390413DFF");

            entity.ToTable("parts_list_rotables_group", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.PartNmbrArray)
                .HasMaxLength(1562)
                .IsUnicode(false)
                .HasColumnName("part_nmbr_array");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.PartType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("part_type");
            entity.Property(e => e.QtyRequireArry)
                .HasMaxLength(122)
                .IsUnicode(false)
                .HasColumnName("qty_require_arry");
            entity.Property(e => e.RefnmbrLinksFiles).HasColumnName("refnmbr_links_files");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.SerialNmbrArray)
                .HasMaxLength(722)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr_array");
        });

        modelBuilder.Entity<PartsMaster>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__parts_ma__4ADA2B43DC8E3B76");

            entity.ToTable("parts_master", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.Allotment).HasColumnName("allotment");
            entity.Property(e => e.AveragePrice).HasColumnName("average__price");
            entity.Property(e => e.AvgReprLeadTm).HasColumnName("avg_repr_lead_tm");
            entity.Property(e => e.AvgVendLeadTm).HasColumnName("avg_vend_lead_tm");
            entity.Property(e => e.BinLocation)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("bin_location");
            entity.Property(e => e.CurrentPoNmbr).HasColumnName("current_po_nmbr");
            entity.Property(e => e.CurrentPoType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("current_po_type");
            entity.Property(e => e.CurrentPrice).HasColumnName("current__price");
            entity.Property(e => e.DateUpdated)
                .HasColumnType("date")
                .HasColumnName("date_updated");
            entity.Property(e => e.ExtraDta)
                .HasMaxLength(27)
                .IsUnicode(false)
                .HasColumnName("extra_dta");
            entity.Property(e => e.GLAcctNbr).HasColumnName("g_l_acct_nbr");
            entity.Property(e => e.InSuspense).HasColumnName("in_suspense");
            entity.Property(e => e.IssTypeInUse)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("iss_type_in_use");
            entity.Property(e => e.LastInventDate)
                .HasColumnType("date")
                .HasColumnName("last_invent_date");
            entity.Property(e => e.LastIssueDate)
                .HasColumnType("date")
                .HasColumnName("last_issue_date");
            entity.Property(e => e.LastPoNmbr).HasColumnName("last_po_nmbr");
            entity.Property(e => e.LastPoType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("last_po_type");
            entity.Property(e => e.LastPrice).HasColumnName("last_price");
            entity.Property(e => e.LastRecvdDate)
                .HasColumnType("date")
                .HasColumnName("last_recvd_date");
            entity.Property(e => e.NotesOnPart)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("notes_on_part");
            entity.Property(e => e.NumberOfSpares).HasColumnName("number_of_spares");
            entity.Property(e => e.OrderLevel).HasColumnName("order_level");
            entity.Property(e => e.OrderQuantity).HasColumnName("order_quantity");
            entity.Property(e => e.PartDesignator)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("part_designator");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.PhyCycleNmbr).HasColumnName("phy_cycle_nmbr");
            entity.Property(e => e.PhyInvActive).HasColumnName("phy_inv_active");
            entity.Property(e => e.PrcBreakAvail).HasColumnName("prc_break_avail");
            entity.Property(e => e.QtyOnHand).HasColumnName("qty_on_hand");
            entity.Property(e => e.QtyOutForRepr).HasColumnName("qty_out_for_repr");
            entity.Property(e => e.QtyRequested).HasColumnName("qty_requested");
            entity.Property(e => e.QuantityOnOrdr).HasColumnName("quantity_on_ordr");
            entity.Property(e => e.RefnmbrLinksFiles).HasColumnName("refnmbr_links_files");
            entity.Property(e => e.Rwitmx)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("rwitmx");
            entity.Property(e => e.ShelfLocation)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("shelf_location");
            entity.Property(e => e.SixMosStaticUse).HasColumnName("six_mos_static_use");
            entity.Property(e => e.ThreeMosStaticUse).HasColumnName("three_mos_static_use");
            entity.Property(e => e.TwelveMoStaticUse).HasColumnName("twelve_mo_static_use");
            entity.Property(e => e.Used).HasColumnName("used");
            entity.Property(e => e.Vendor1)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor1");
            entity.Property(e => e.Vendor2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor2");
            entity.Property(e => e.Vendor3)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor3");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("warehouse");
        });

        modelBuilder.Entity<PartsOnAc>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__parts_on__4ADA2B4392D8A534");

            entity.ToTable("parts_on_ac", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AltPnQty).HasColumnName("alt_pn_qty");
            entity.Property(e => e.ExpendableQty).HasColumnName("expendable_qty");
            entity.Property(e => e.Location)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.PartNmbrUsed)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("part_nmbr_used");
            entity.Property(e => e.Pfitmnmbr).HasColumnName("pfitmnmbr");
            entity.Property(e => e.Position)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.PrimaryPnQty).HasColumnName("primary_pn_qty");
            entity.Property(e => e.SPASupPreAl).HasColumnName("s_p_a_sup_pre_al");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.TailNmbr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr");
        });

        modelBuilder.Entity<PartsOnOrder>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__parts_on__4ADA2B43B1CBC0E3");

            entity.ToTable("parts_on_order", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.Account)
                .HasMaxLength(58)
                .IsUnicode(false)
                .HasColumnName("account");
            entity.Property(e => e.Approved).HasColumnName("approved");
            entity.Property(e => e.AvgAmntWhenRecvd).HasColumnName("avg_amnt_when_recvd");
            entity.Property(e => e.BuyerCode)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("buyer_code");
            entity.Property(e => e.BuyerNotes)
                .HasColumnType("text")
                .HasColumnName("buyer_notes");
            entity.Property(e => e.Confirm).HasColumnName("confirm");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("contact_person");
            entity.Property(e => e.CstmImpBrkr)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("cstm_imp_brkr");
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("currency_code");
            entity.Property(e => e.DateDue)
                .HasColumnType("date")
                .HasColumnName("date_due");
            entity.Property(e => e.DateReceived)
                .HasColumnType("date")
                .HasColumnName("date_received");
            entity.Property(e => e.EnteredQuote)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("entered_quote");
            entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");
            entity.Property(e => e.FreeOnBoard).HasColumnName("free_on_board");
            entity.Property(e => e.Freight)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("freight");
            entity.Property(e => e.InvoiceFlag).HasColumnName("invoice_flag");
            entity.Property(e => e.InvoicedAmnt).HasColumnName("invoiced_amnt");
            entity.Property(e => e.ItemTask)
                .HasColumnType("text")
                .HasColumnName("item_task");
            entity.Property(e => e.JobCards)
                .HasMaxLength(58)
                .IsUnicode(false)
                .HasColumnName("job_cards");
            entity.Property(e => e.MultiplePgYN).HasColumnName("multiple_pg_y_n");
            entity.Property(e => e.NoCharge)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("no_charge");
            entity.Property(e => e.OrderDate)
                .HasColumnType("date")
                .HasColumnName("order_date");
            entity.Property(e => e.OrderPer)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("order_per");
            entity.Property(e => e.OriginalInvoiAmnt).HasColumnName("original_invoi_amnt");
            entity.Property(e => e.PageNumber).HasColumnName("page_number");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(289)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("po_number");
            entity.Property(e => e.PoTerms)
                .HasColumnType("text")
                .HasColumnName("po_terms");
            entity.Property(e => e.PrintFlag).HasColumnName("print_flag");
            entity.Property(e => e.QtyOnhandRecvd).HasColumnName("qty_onhand_recvd");
            entity.Property(e => e.QtyOrdered).HasColumnName("qty_ordered");
            entity.Property(e => e.QtyReceived).HasColumnName("qty_received");
            entity.Property(e => e.QuotedAmnt).HasColumnName("quoted_amnt");
            entity.Property(e => e.RevisionNmbr).HasColumnName("revision_nmbr");
            entity.Property(e => e.RevisionStatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("revision_status");
            entity.Property(e => e.SalesOrderNmbr).HasColumnName("sales_order_nmbr");
            entity.Property(e => e.ShipVia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ship_via");
            entity.Property(e => e.ShpHndl)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("shp_hndl");
            entity.Property(e => e.SpecInstr)
                .HasColumnType("text")
                .HasColumnName("spec_instr");
            entity.Property(e => e.Status)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Taxable).HasColumnName("taxable");
            entity.Property(e => e.TypeOfPo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("type_of_po");
            entity.Property(e => e.UseCurx).HasColumnName("use_curx");
            entity.Property(e => e.Vendor)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor");
            entity.Property(e => e.VoidCloseFlag).HasColumnName("void_close_flag");
        });

        modelBuilder.Entity<PartsRqstIssued>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__parts_rq__4ADA2B431FEED220");

            entity.ToTable("parts_rqst_issued", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AccountNumber).HasColumnName("account_number");
            entity.Property(e => e.AirwayBill)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("airway_bill");
            entity.Property(e => e.AtaCode).HasColumnName("ata_code");
            entity.Property(e => e.AveragePrice).HasColumnName("average__price");
            entity.Property(e => e.BorrowLoanFlag)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("borrow_loan_flag");
            entity.Property(e => e.CatGroup)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("cat_group");
            entity.Property(e => e.ControlTagNmbr).HasColumnName("control_tag_nmbr");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("customer_id");
            entity.Property(e => e.DateOfIssue)
                .HasColumnType("date")
                .HasColumnName("date_of_issue");
            entity.Property(e => e.DateReturned)
                .HasColumnType("date")
                .HasColumnName("date_returned");
            entity.Property(e => e.InspecNmbr).HasColumnName("inspec_nmbr");
            entity.Property(e => e.IssueNumber).HasColumnName("issue_number");
            entity.Property(e => e.IssueType).HasColumnName("issue_type");
            entity.Property(e => e.Isuser)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("isuser");
            entity.Property(e => e.JobCardNmbr).HasColumnName("job_card_nmbr");
            entity.Property(e => e.KaeNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("kae_number");
            entity.Property(e => e.KaeSerialNmbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kae_serial_nmbr");
            entity.Property(e => e.LocationCity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("location_city");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.QtyRequested).HasColumnName("qty_requested");
            entity.Property(e => e.RecordCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("record_code");
            entity.Property(e => e.ReleaseNoteNmbr).HasColumnName("release_note_nmbr");
            entity.Property(e => e.RepOrdNmbr)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("rep_ord_nmbr");
            entity.Property(e => e.ReqNmbr).HasColumnName("req_nmbr");
            entity.Property(e => e.RetToVendNmbr)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("ret_to_vend_nmbr");
            entity.Property(e => e.ReturnNmbr).HasColumnName("return_nmbr");
            entity.Property(e => e.Rotable)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("rotable");
            entity.Property(e => e.SalOrdLineNmbr).HasColumnName("sal_ord_line_nmbr");
            entity.Property(e => e.SalOrdLinePut)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("sal_ord_line_put");
            entity.Property(e => e.SalesPrice).HasColumnName("sales_price");
            entity.Property(e => e.SerialCategory)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("serial_category");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.SourceCode).HasColumnName("source_code");
            entity.Property(e => e.StmBilledOn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("stm_billed_on");
            entity.Property(e => e.TailNmbr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr");
            entity.Property(e => e.TaskCardId)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("task_card_id");
            entity.Property(e => e.Usage)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("usage");
            entity.Property(e => e.VendorBatchNmbr).HasColumnName("vendor_batch_nmbr");
            entity.Property(e => e.WorkOrderNmbr).HasColumnName("work_order_nmbr");
        });

        modelBuilder.Entity<PhysInv>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__phys_inv__4ADA2B43A30F1C29");

            entity.ToTable("phys_inv", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AccountNumber).HasColumnName("account_number");
            entity.Property(e => e.Auditor1)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("auditor_1");
            entity.Property(e => e.Auditor2)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("auditor_2");
            entity.Property(e => e.AveragePrice).HasColumnName("average__price");
            entity.Property(e => e.BinLocation)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("bin_location");
            entity.Property(e => e.CardUpdated)
                .HasColumnType("date")
                .HasColumnName("card_updated");
            entity.Property(e => e.CategoryType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("category_type");
            entity.Property(e => e.CityName)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("city_name");
            entity.Property(e => e.Control)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("control");
            entity.Property(e => e.CountCards).HasColumnName("count_cards");
            entity.Property(e => e.CrossRef1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cross_ref_1");
            entity.Property(e => e.DateLoaded)
                .HasColumnType("date")
                .HasColumnName("date_loaded");
            entity.Property(e => e.Description)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.NewUsedConsign)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("new_used_consign");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.PurchasePrice).HasColumnName("purchase_price");
            entity.Property(e => e.QtyInRepair1).HasColumnName("qty_in_repair1");
            entity.Property(e => e.QtyInRepair2).HasColumnName("qty_in_repair2");
            entity.Property(e => e.QtyInSuspense1).HasColumnName("qty_in_suspense1");
            entity.Property(e => e.QtyInSuspense2).HasColumnName("qty_in_suspense2");
            entity.Property(e => e.QtyOnHand1).HasColumnName("qty_on_hand1");
            entity.Property(e => e.QtyOnHand2).HasColumnName("qty_on_hand2");
            entity.Property(e => e.Remarks)
                .HasMaxLength(62)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.SerialNmbrCtCard).HasColumnName("serial_nmbr_ct_card");
            entity.Property(e => e.ShelfLocation)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("shelf_location");
            entity.Property(e => e.StatusState)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("status_state");
            entity.Property(e => e.TimeLoaded).HasColumnName("time_loaded");
            entity.Property(e => e.UnitOfIssue)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("unit_of_issue");
            entity.Property(e => e.UseridOfLoad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("userid_of_load");
            entity.Property(e => e.VarianceQty).HasColumnName("variance_qty");
            entity.Property(e => e.WhseLoadedFrom)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("whse_loaded_from");
            entity.Property(e => e.WsidLoaded)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("wsid_loaded");
        });

        modelBuilder.Entity<Resources0>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__resource__4ADA2B43826820AC");

            entity.ToTable("resources_0", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AccountNumber).HasColumnName("account_number");
            entity.Property(e => e.AircraftType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("aircraft_type");
            entity.Property(e => e.Allotment).HasColumnName("allotment");
            entity.Property(e => e.AogAnAirplane).HasColumnName("aog_an_airplane");
            entity.Property(e => e.AtaChapCode).HasColumnName("ata_chap_code");
            entity.Property(e => e.AtaSubchptPara).HasColumnName("ata_subchpt_para");
            entity.Property(e => e.AveragePrice).HasColumnName("average__price");
            entity.Property(e => e.AvgRepairCost).HasColumnName("avg_repair_cost");
            entity.Property(e => e.AvgReprLeadTm).HasColumnName("avg_repr_lead_tm");
            entity.Property(e => e.AvgVendLeadTm).HasColumnName("avg_vend_lead_tm");
            entity.Property(e => e.BinLocation)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("bin_location");
            entity.Property(e => e.CasePartCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("case_part_code");
            entity.Property(e => e.CheckDigit).HasColumnName("check_digit");
            entity.Property(e => e.CorePrice).HasColumnName("core_price");
            entity.Property(e => e.CrossRef1)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("cross_ref_1");
            entity.Property(e => e.CurrentPoNmbr).HasColumnName("current_po_nmbr");
            entity.Property(e => e.CurrentPoType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("current_po_type");
            entity.Property(e => e.CurrentPrice).HasColumnName("current__price");
            entity.Property(e => e.CycOverRide)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("cyc_over_ride");
            entity.Property(e => e.DateUpdated)
                .HasColumnType("date")
                .HasColumnName("date_updated");
            entity.Property(e => e.Description)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Extra20Byte)
                .HasMaxLength(27)
                .IsUnicode(false)
                .HasColumnName("extra_20_byte");
            entity.Property(e => e.ExtraPrcNmbr1).HasColumnName("extra_prc_nmbr_1");
            entity.Property(e => e.ExtraPrcNmbr2).HasColumnName("extra_prc_nmbr_2");
            entity.Property(e => e.HazMaterial)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("haz_material");
            entity.Property(e => e.HrsOverRide)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("hrs_over_ride");
            entity.Property(e => e.InSuspense).HasColumnName("in_suspense");
            entity.Property(e => e.IssTypeInUse)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("iss_type_in_use");
            entity.Property(e => e.KaeMandatory).HasColumnName("kae_mandatory");
            entity.Property(e => e.KeyWord)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("key_word");
            entity.Property(e => e.LastInventDate)
                .HasColumnType("date")
                .HasColumnName("last_invent_date");
            entity.Property(e => e.LastIssueDate)
                .HasColumnType("date")
                .HasColumnName("last_issue_date");
            entity.Property(e => e.LastPoNmbr1).HasColumnName("last_po_nmbr1");
            entity.Property(e => e.LastPoType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("last_po_type");
            entity.Property(e => e.LastPrice).HasColumnName("last_price");
            entity.Property(e => e.LastRecvdDate)
                .HasColumnType("date")
                .HasColumnName("last_recvd_date");
            entity.Property(e => e.LastSerialNmbr).HasColumnName("last_serial_nmbr");
            entity.Property(e => e.LastSerialNmbr2).HasColumnName("last_serial_nmbr2");
            entity.Property(e => e.LifeLimitCycl).HasColumnName("life_limit_cycl");
            entity.Property(e => e.LifeLimitHrs).HasColumnName("life_limit_hrs");
            entity.Property(e => e.LifeLimitWks).HasColumnName("life_limit_wks");
            entity.Property(e => e.MaxCycls).HasColumnName("max_cycls");
            entity.Property(e => e.MaxHours).HasColumnName("max_hours");
            entity.Property(e => e.MaxWeeks).HasColumnName("max_weeks");
            entity.Property(e => e.MinEquipList)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("min_equip_list");
            entity.Property(e => e.NewPrice).HasColumnName("new_price");
            entity.Property(e => e.NmbrOnAC).HasColumnName("nmbr_on_a_c");
            entity.Property(e => e.NmbrTimesOrdered).HasColumnName("nmbr_times_ordered");
            entity.Property(e => e.NotesOnPart)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("notes_on_part");
            entity.Property(e => e.NumberOfSpares).HasColumnName("number_of_spares");
            entity.Property(e => e.OrderLevel).HasColumnName("order_level");
            entity.Property(e => e.OrderQuantity).HasColumnName("order_quantity");
            entity.Property(e => e.PartDesignator)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("part_designator");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.PartType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("part_type");
            entity.Property(e => e.PhyCycleNmbr).HasColumnName("phy_cycle_nmbr");
            entity.Property(e => e.PhyInvActive).HasColumnName("phy_inv_active");
            entity.Property(e => e.PnInspecActive).HasColumnName("pn_inspec_active");
            entity.Property(e => e.PrcBreakAvail).HasColumnName("prc_break_avail");
            entity.Property(e => e.QtyInAdvExch).HasColumnName("qty_in_adv_exch");
            entity.Property(e => e.QtyOnHand).HasColumnName("qty_on_hand");
            entity.Property(e => e.QtyOnOrdr).HasColumnName("qty_on_ordr");
            entity.Property(e => e.QtyOutForRepr).HasColumnName("qty_out_for_repr");
            entity.Property(e => e.QtyRequested).HasColumnName("qty_requested");
            entity.Property(e => e.ReceiptInspec)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("receipt_inspec");
            entity.Property(e => e.RecordCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("record_code");
            entity.Property(e => e.RefnmbrLinksFiles).HasColumnName("refnmbr_links_files");
            entity.Property(e => e.RelAlertLevel).HasColumnName("rel_alert_level");
            entity.Property(e => e.RemovalInspec)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("removal_inspec");
            entity.Property(e => e.RentalPrice).HasColumnName("rental_price");
            entity.Property(e => e.RepairWhere)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("repair_where");
            entity.Property(e => e.RestrictedIssue).HasColumnName("restricted_issue");
            entity.Property(e => e.Rotable).HasColumnName("rotable");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.ShelfLife).HasColumnName("shelf_life");
            entity.Property(e => e.ShelfLocation)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("shelf_location");
            entity.Property(e => e.SixMosStaticUse).HasColumnName("six_mos_static_use");
            entity.Property(e => e.SourceDoc)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("source_doc");
            entity.Property(e => e.SubstitutePartnmbr)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("substitute_partnmbr");
            entity.Property(e => e.SupercededBy)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("superceded_by");
            entity.Property(e => e.Supercedes)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("supercedes");
            entity.Property(e => e.Taxable).HasColumnName("taxable");
            entity.Property(e => e.ThreeMosStaticUse).HasColumnName("three_mos_static_use");
            entity.Property(e => e.TwelveMoStaticUse).HasColumnName("twelve_mo_static_use");
            entity.Property(e => e.TypeOfCalendar)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("type_of_calendar");
            entity.Property(e => e.TypeOfCycle)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("type_of_cycle");
            entity.Property(e => e.TypeOfMel)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("type_of_mel");
            entity.Property(e => e.UnitOfIssue)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("unit_of_issue");
            entity.Property(e => e.UnitsOfRepair).HasColumnName("units_of_repair");
            entity.Property(e => e.UseAtaOnRlbil).HasColumnName("use_ata_on_rlbil");
            entity.Property(e => e.UsedPrice).HasColumnName("used_price");
            entity.Property(e => e.VendorNumber1)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_number1");
            entity.Property(e => e.VendorNumber2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_number2");
            entity.Property(e => e.VendorNumber3)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_number3");
            entity.Property(e => e.Warehouse)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("warehouse");
            entity.Property(e => e.WksOverRide)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("wks_over_ride");
        });

        modelBuilder.Entity<Resources1>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__resource__4ADA2B43C48105F6");

            entity.ToTable("resources_1", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AdSbDueDate)
                .HasColumnType("date")
                .HasColumnName("ad_sb_due_date");
            entity.Property(e => e.AdSbNumber)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ad_sb_number");
            entity.Property(e => e.AdSbUpdateFlg)
                .HasColumnType("date")
                .HasColumnName("ad_sb_update_flg");
            entity.Property(e => e.AtaOfLastIssu).HasColumnName("ata_of_last_issu");
            entity.Property(e => e.AtaParagraph).HasColumnName("ata_paragraph");
            entity.Property(e => e.BinLocation)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("bin_location");
            entity.Property(e => e.BorrowLoanFlag).HasColumnName("borrow_loan_flag");
            entity.Property(e => e.BorrowLoanNmbr).HasColumnName("borrow_loan_nmbr");
            entity.Property(e => e.BorrowedFrom)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("borrowed_from");
            entity.Property(e => e.CategoryType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("category_type");
            entity.Property(e => e.CityName)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("city_name");
            entity.Property(e => e.ConditionCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("condition_code");
            entity.Property(e => e.ControlTagNmbr).HasColumnName("control_tag_nmbr");
            entity.Property(e => e.CummRprCost).HasColumnName("cumm_rpr_cost");
            entity.Property(e => e.CyclThisInstal).HasColumnName("cycl_this_instal");
            entity.Property(e => e.CyclsAtIntsall).HasColumnName("cycls_at_intsall");
            entity.Property(e => e.CyclsSinceNew).HasColumnName("cycls_since_new");
            entity.Property(e => e.CyclsTbo).HasColumnName("cycls_tbo");
            entity.Property(e => e.CyclsTso).HasColumnName("cycls_tso");
            entity.Property(e => e.DateFittedKae)
                .HasColumnType("date")
                .HasColumnName("date_fitted_kae");
            entity.Property(e => e.DateInstIssued)
                .HasColumnType("date")
                .HasColumnName("date_inst_issued");
            entity.Property(e => e.DateOrdered)
                .HasColumnType("date")
                .HasColumnName("date_ordered");
            entity.Property(e => e.DateReceived)
                .HasColumnType("date")
                .HasColumnName("date_received");
            entity.Property(e => e.HigherAssmMvmt).HasColumnName("higher_assm_mvmt");
            entity.Property(e => e.HourThisInstl).HasColumnName("hour_this_instl");
            entity.Property(e => e.HoursAtInstall).HasColumnName("hours_at_install");
            entity.Property(e => e.HoursSinceNew).HasColumnName("hours_since_new");
            entity.Property(e => e.HoursTbo).HasColumnName("hours_tbo");
            entity.Property(e => e.HoursTso).HasColumnName("hours_tso");
            entity.Property(e => e.InspectNmbr).HasColumnName("inspect_nmbr");
            entity.Property(e => e.KaeCodeNumber).HasColumnName("kae_code_number");
            entity.Property(e => e.KaeRefSernmbr)
                .HasMaxLength(28)
                .IsUnicode(false)
                .HasColumnName("kae_ref_sernmbr");
            entity.Property(e => e.KnownUnkTsn)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("known_unk_tsn");
            entity.Property(e => e.LastInspecDate)
                .HasColumnType("date")
                .HasColumnName("last_inspec_date");
            entity.Property(e => e.LastIssStatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("last_iss_status");
            entity.Property(e => e.LastIssuedOn).HasColumnName("last_issued_on");
            entity.Property(e => e.LastRcvStatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("last_rcv_status");
            entity.Property(e => e.LastReceivedOn).HasColumnName("last_received_on");
            entity.Property(e => e.LastRepairShop)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("last_repair_shop");
            entity.Property(e => e.LoanedTo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("loaned_to");
            entity.Property(e => e.LocationOnAC)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("location_on_a_c");
            entity.Property(e => e.MfrBatchLotNmbr).HasColumnName("mfr_batch_lot_nmbr");
            entity.Property(e => e.ModLevel)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("mod_level");
            entity.Property(e => e.NewUsedConsign).HasColumnName("new_used_consign");
            entity.Property(e => e.NoteRevisionNmbr).HasColumnName("note_revision_nmbr");
            entity.Property(e => e.OrigPurchaseAmnt).HasColumnName("orig_purchase_amnt");
            entity.Property(e => e.OverrideMaxCyc).HasColumnName("override_max_cyc");
            entity.Property(e => e.OverrideMaxDay).HasColumnName("override_max_day");
            entity.Property(e => e.OverrideMaxHrs).HasColumnName("override_max_hrs");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.PositionOnAC)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("position_on_a_c");
            entity.Property(e => e.PurchaseOrderNmbr).HasColumnName("purchase_order_nmbr");
            entity.Property(e => e.PurchasePrice).HasColumnName("purchase_price");
            entity.Property(e => e.Ref)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ref");
            entity.Property(e => e.RefnmbrLinksFiles).HasColumnName("refnmbr_links_files");
            entity.Property(e => e.RepairDate)
                .HasColumnType("date")
                .HasColumnName("repair_date");
            entity.Property(e => e.RepairTagNmbrPt1)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("repair_tag_nmbr_pt1");
            entity.Property(e => e.RepairTagNmbrPt2).HasColumnName("repair_tag_nmbr_pt2");
            entity.Property(e => e.SerialNmbr)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("serial_nmbr");
            entity.Property(e => e.ShelfLocation)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("shelf_location");
            entity.Property(e => e.StatusState)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("status_state");
            entity.Property(e => e.SuspDirection)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("susp_direction");
            entity.Property(e => e.TailNmbr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr");
            entity.Property(e => e.TearDownRptnmbr).HasColumnName("tear_down_rptnmbr");
            entity.Property(e => e.TimeInstIn).HasColumnName("time_inst_in");
            entity.Property(e => e.TscAtLastRepr).HasColumnName("tsc_at_last_repr");
            entity.Property(e => e.TsnAtLastRepr).HasColumnName("tsn_at_last_repr");
            entity.Property(e => e.TswAtLastRepr).HasColumnName("tsw_at_last_repr");
            entity.Property(e => e.TypeAdSb).HasColumnName("type_ad_sb");
            entity.Property(e => e.UpdateCalendar)
                .HasColumnType("date")
                .HasColumnName("update_calendar");
            entity.Property(e => e.WarrantyNumber)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("warranty_number");
            entity.Property(e => e.WeekThisInstal).HasColumnName("week_this_instal");
            entity.Property(e => e.WeeksAtInstall).HasColumnName("weeks_at_install");
            entity.Property(e => e.WeeksSinceNew).HasColumnName("weeks_since_new");
            entity.Property(e => e.WeeksTbo).HasColumnName("weeks_tbo");
            entity.Property(e => e.WeeksTso).HasColumnName("weeks_tso");
        });

        modelBuilder.Entity<SquawkDeferralDateAudit>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__squawk_d__4ADA2B435E81084A");

            entity.ToTable("squawk_deferral_date_audit", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AtaChged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ata_chged");
            entity.Property(e => e.CnxChged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("cnx_chged");
            entity.Property(e => e.DateComp)
                .HasColumnType("date")
                .HasColumnName("date_comp");
            entity.Property(e => e.DateDispDuDef)
                .HasColumnType("date")
                .HasColumnName("date_disp_du_def");
            entity.Property(e => e.DelayChnged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("delay_chnged");
            entity.Property(e => e.DmiNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dmi_number");
            entity.Property(e => e.DmiType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("dmi_type");
            entity.Property(e => e.EnginePosChged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("engine_pos_chged");
            entity.Property(e => e.NewDataComp).HasColumnName("new_data_comp");
            entity.Property(e => e.NewDate)
                .HasColumnType("date")
                .HasColumnName("new_date");
            entity.Property(e => e.NewDmiNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("new_dmi_number");
            entity.Property(e => e.NewDmiType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("new_dmi_type");
            entity.Property(e => e.PartListChged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("part_list_chged");
            entity.Property(e => e.Sadate)
                .HasColumnType("date")
                .HasColumnName("sadate");
            entity.Property(e => e.Saprnt)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("saprnt");
            entity.Property(e => e.Saterm)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("saterm");
            entity.Property(e => e.Satime).HasColumnName("satime");
            entity.Property(e => e.Sauser)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sauser");
            entity.Property(e => e.ShutdownChged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("shutdown_chged");
            entity.Property(e => e.SquawkNumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("squawk_number");
            entity.Property(e => e.TailNmbrChged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr_chged");
            entity.Property(e => e.TextNmbrChged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("text_nmbr_chged");
            entity.Property(e => e.TypeOfAction)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("type_of_action");
        });

        modelBuilder.Entity<SquawkMaster>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__squawk_m__4ADA2B43C93980BB");

            entity.ToTable("squawk_master", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AFWhenDone).HasColumnName("a_f_when_done");
            entity.Property(e => e.AcType)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ac_type");
            entity.Property(e => e.AirframeAtSqwk).HasColumnName("airframe_at_sqwk");
            entity.Property(e => e.Approach).HasColumnName("approach");
            entity.Property(e => e.AtaChapAndSub).HasColumnName("ata_chap__and__sub");
            entity.Property(e => e.AtaChapCode).HasColumnName("ata_chap_code");
            entity.Property(e => e.AtaParagraph).HasColumnName("ata_paragraph");
            entity.Property(e => e.AuditPrint).HasColumnName("audit_print");
            entity.Property(e => e.CancellationYN).HasColumnName("cancellation_y_n");
            entity.Property(e => e.CatIiiApproach).HasColumnName("cat_iii_approach");
            entity.Property(e => e.CatIiiLndgTyp).HasColumnName("cat_iii_lndg_typ");
            entity.Property(e => e.CatIiiSignif).HasColumnName("cat_iii_signif");
            entity.Property(e => e.CatIiiVerified).HasColumnName("cat_iii_verified");
            entity.Property(e => e.City)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.DateComp)
                .HasColumnType("date")
                .HasColumnName("date_comp");
            entity.Property(e => e.DateDispDuDef)
                .HasColumnType("date")
                .HasColumnName("date_disp_du_def");
            entity.Property(e => e.DateReceived)
                .HasColumnType("date")
                .HasColumnName("date_received");
            entity.Property(e => e.DelayMinutes).HasColumnName("delay_minutes");
            entity.Property(e => e.DelayYN).HasColumnName("delay_y_n");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.DmiNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dmi_number");
            entity.Property(e => e.DmiType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("dmi_type");
            entity.Property(e => e.DmiYN).HasColumnName("dmi_y_n");
            entity.Property(e => e.EngPositionNmbr).HasColumnName("eng_position_nmbr");
            entity.Property(e => e.EngineShutDown).HasColumnName("engine_shut_down");
            entity.Property(e => e.EtopsConfirmed).HasColumnName("etops_confirmed");
            entity.Property(e => e.EtopsConfirmedBy).HasColumnName("etops_confirmed_by");
            entity.Property(e => e.EtopsSignificant).HasColumnName("etops_significant");
            entity.Property(e => e.EtopsVerified).HasColumnName("etops_verified");
            entity.Property(e => e.EtopsVerifiedBy).HasColumnName("etops_verified_by");
            entity.Property(e => e.FirstInspector).HasColumnName("first_inspector");
            entity.Property(e => e.Flight).HasColumnName("flight");
            entity.Property(e => e.FlightLogNmbr).HasColumnName("flight_log_nmbr");
            entity.Property(e => e.ItemNmbr).HasColumnName("item_nmbr");
            entity.Property(e => e.Landing).HasColumnName("landing");
            entity.Property(e => e.MinEquipList)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("min_equip_list");
            entity.Property(e => e.PartNumbers)
                .HasMaxLength(197)
                .IsUnicode(false)
                .HasColumnName("part_numbers");
            entity.Property(e => e.ReportedBy).HasColumnName("reported_by");
            entity.Property(e => e.Resolution)
                .HasColumnType("text")
                .HasColumnName("resolution");
            entity.Property(e => e.SecondInspector).HasColumnName("second_inspector");
            entity.Property(e => e.SerialNumbers)
                .HasMaxLength(92)
                .IsUnicode(false)
                .HasColumnName("serial_numbers");
            entity.Property(e => e.ServiceDiffYN).HasColumnName("service_diff_y_n");
            entity.Property(e => e.SquawkNumber)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("squawk_number");
            entity.Property(e => e.TailNmbr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("tail_nmbr");
            entity.Property(e => e.TextProbAndResolu)
                .HasMaxLength(587)
                .IsUnicode(false)
                .HasColumnName("text_prob_and_resolu");
            entity.Property(e => e.TypeCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("type_code");
            entity.Property(e => e.WhoFixed).HasColumnName("who_fixed");
            entity.Property(e => e.WorkOrderNmbr).HasColumnName("work_order_nmbr");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.PkTransactionId).HasName("PK__transact__2B807A3E705A911B");

            entity.ToTable("transactions", "common");

            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.RecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("record_id");
            entity.Property(e => e.TableId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("table_id");
            entity.Property(e => e.TransactDate)
                .HasColumnType("datetime")
                .HasColumnName("transact_date");
            entity.Property(e => e.TransactType)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("transact_type");
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__user__4ADA2B436A8A6DE7");

            entity.ToTable("user", "admin");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.Address1)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("address_1");
            entity.Property(e => e.Address2)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("address_2");
            entity.Property(e => e.City)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("company_id");
            entity.Property(e => e.Country)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Email)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("job_title");
            entity.Property(e => e.LastName)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("middle_name");
            entity.Property(e => e.Notes)
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.Phone1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("phone_1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("phone_2");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("postal_code");
            entity.Property(e => e.Role)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("role");
            entity.Property(e => e.StateOrRegion)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("state_or_region");
        });

        modelBuilder.Entity<VendorMaster>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__vendor_m__4ADA2B43BDA915C6");

            entity.ToTable("vendor_master", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.APNameXRef)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("a_p_name_x_ref");
            entity.Property(e => e.ARNameXRef)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("a_r_name_x_ref");
            entity.Property(e => e.AtaChaptCode).HasColumnName("ata_chapt_code");
            entity.Property(e => e.BillToAddr1)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("bill_to_addr_1");
            entity.Property(e => e.BillToAddr2)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("bill_to_addr_2");
            entity.Property(e => e.BillToCity)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("bill_to_city");
            entity.Property(e => e.BillingContact)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("billing_contact");
            entity.Property(e => e.BillingState)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("billing_state");
            entity.Property(e => e.BillingZipCode).HasColumnName("billing_zip_code");
            entity.Property(e => e.Cable)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("cable");
            entity.Property(e => e.CaseIdNmbr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("case_id_nmbr");
            entity.Property(e => e.CaseListed)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("case_listed");
            entity.Property(e => e.CertificateNmbr)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("certificate_nmbr");
            entity.Property(e => e.Contact)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("contact");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("currency");
            entity.Property(e => e.FobDS).HasColumnName("fob_d_s");
            entity.Property(e => e.NameItemParty)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("name_item_party");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.PurchCycGuar).HasColumnName("purch_cyc_guar");
            entity.Property(e => e.PurchHrsGuar).HasColumnName("purch_hrs_guar");
            entity.Property(e => e.PurchWksGuar).HasColumnName("purch_wks_guar");
            entity.Property(e => e.ReprCycGuar).HasColumnName("repr_cyc_guar");
            entity.Property(e => e.ReprHrsGuar).HasColumnName("repr_hrs_guar");
            entity.Property(e => e.ReprWksGuar).HasColumnName("repr_wks_guar");
            entity.Property(e => e.SendViaMFE).HasColumnName("send_via_m_f_e");
            entity.Property(e => e.ShipToAddr1)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("ship_to_addr_1");
            entity.Property(e => e.ShipToAddr2)
                .HasMaxLength(34)
                .IsUnicode(false)
                .HasColumnName("ship_to_addr_2");
            entity.Property(e => e.ShipToCity)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ship_to_city");
            entity.Property(e => e.ShipToState)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ship_to_state");
            entity.Property(e => e.ShipToZipCode).HasColumnName("ship_to_zip_code");
            entity.Property(e => e.ShipTypeCode)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ship_type_code");
            entity.Property(e => e.ShipVia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ship_via");
            entity.Property(e => e.SortName)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("sort_name");
            entity.Property(e => e.Telex)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telex");
            entity.Property(e => e.TermsOfPayment)
                .HasMaxLength(67)
                .IsUnicode(false)
                .HasColumnName("terms_of_payment");
            entity.Property(e => e.Twx)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("twx");
            entity.Property(e => e.VendorNumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_number");
        });

        modelBuilder.Entity<WarehouseMaster>(entity =>
        {
            entity.HasKey(e => new { e.PkRecordId, e.PkTransactionId }).HasName("PK__warehous__4ADA2B43F4EB5E65");

            entity.ToTable("warehouse_master", "maint");

            entity.Property(e => e.PkRecordId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_record_id");
            entity.Property(e => e.PkTransactionId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("pk_transaction_id");
            entity.Property(e => e.AddressLine1)
                .HasColumnType("text")
                .HasColumnName("address_line_1");
            entity.Property(e => e.AddressLine2)
                .HasColumnType("text")
                .HasColumnName("address_line_2");
            entity.Property(e => e.City)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Contact)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("contact");
            entity.Property(e => e.Department)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.IssuePrinter)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("issue_printer");
            entity.Property(e => e.POPrinter)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("p_o__printer");
            entity.Property(e => e.PickTkt)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("pick_tkt");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("postal_code");
            entity.Property(e => e.RcptPrinter)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("rcpt_printer");
            entity.Property(e => e.RepairPrinter)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("repair_printer");
            entity.Property(e => e.ReprShipTkt)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("repr_ship_tkt");
            entity.Property(e => e.StateOrRegion)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("state_or_region");
            entity.Property(e => e.SystemPrinter)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("system_printer");
            entity.Property(e => e.TelNmbr)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("tel_nmbr");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("warehouse_code");
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("warehouse_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
