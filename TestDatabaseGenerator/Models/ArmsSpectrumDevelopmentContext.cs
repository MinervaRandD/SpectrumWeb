using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestDatabaseGenerator.Models;

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

    public virtual DbSet<PartNumberXref> PartNumberXrefs { get; set; }

    public virtual DbSet<PartQuotation> PartQuotations { get; set; }

    public virtual DbSet<PartRequisition> PartRequisitions { get; set; }

    public virtual DbSet<PartRequisitionXRef> PartRequisitionXRefs { get; set; }

    public virtual DbSet<PartsListRotablesGroup> PartsListRotablesGroups { get; set; }

    public virtual DbSet<PartsMaster> PartsMasters { get; set; }

    public virtual DbSet<PartsOnAc> PartsOnAcs { get; set; }

    public virtual DbSet<PartsOnOrder> PartsOnOrders { get; set; }

    public virtual DbSet<PartsRqstIssued> PartsRqstIssueds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ArmsSpectrumDevelopment;Trusted_Connection=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcMaster>(entity =>
        {
            entity.HasKey(e => e.PkTransactId).HasName("PK__ac_maste__BDF67B3AC2C92D7C");

            entity.ToTable("ac_master", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
            entity.Property(e => e.AcIdnt)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("ac_idnt");
            entity.Property(e => e.AircraftType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("aircraft_type");
            entity.Property(e => e.BusClassSeats).HasColumnName("bus_class_seats");
            entity.Property(e => e.CheckForRemvl)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("check_for_remvl");
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
            entity.Property(e => e.IncRelRpts)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("inc_rel_rpts");
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
            entity.HasKey(e => e.PkTransactId).HasName("PK__ac_type___BDF67B3A0BF1F47A");

            entity.ToTable("ac_type_inspects", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
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
            entity.HasKey(e => e.PkTransactId).HasName("PK__ac_type___BDF67B3AC572A3C9");

            entity.ToTable("ac_type_inspect_resets", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
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
            entity.HasKey(e => e.PkTransactId).HasName("PK__ac_type___BDF67B3A1619176D");

            entity.ToTable("ac_type_scheduling_fuel_ecm_m_and_e", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
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

        modelBuilder.Entity<PartNumberXref>(entity =>
        {
            entity.HasKey(e => e.PkTransactId).HasName("PK__part_num__BDF67B3A8B103ED8");

            entity.ToTable("part_number_xref", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
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
            entity.HasKey(e => e.PkTransactId).HasName("PK__part_quo__BDF67B3AEF9533B6");

            entity.ToTable("part_quotations", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
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
            entity.HasKey(e => e.PkTransactId).HasName("PK__part_req__BDF67B3A4729A874");

            entity.ToTable("part_requisition", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
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
            entity.HasKey(e => e.PkTransactId).HasName("PK__part_req__BDF67B3A39025D07");

            entity.ToTable("part_requisition_x_ref", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
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

        modelBuilder.Entity<PartsListRotablesGroup>(entity =>
        {
            entity.HasKey(e => e.PkTransactId).HasName("PK__parts_li__BDF67B3AEB197659");

            entity.ToTable("parts_list_rotables_group", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
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
            entity.HasKey(e => e.PkTransactId).HasName("PK__parts_ma__BDF67B3A0D339181");

            entity.ToTable("parts_master", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
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
            entity.Property(e => e.PhyInvActive)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("phy_inv_active");
            entity.Property(e => e.PrcBreakAvail)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("prc_break_avail");
            entity.Property(e => e.QtyOnHand).HasColumnName("qty_on_hand");
            entity.Property(e => e.QtyOutForRepr).HasColumnName("qty_out_for_repr");
            entity.Property(e => e.QtyRequested).HasColumnName("qty_requested");
            entity.Property(e => e.QuantityOnOrdr).HasColumnName("quantity_on_ordr");
            entity.Property(e => e.RefnmbrLinksFiles).HasColumnName("refnmbr_links_files");
            entity.Property(e => e.Rwitmx)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("rwitmx");
            entity.Property(e => e.Rwwhse)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("rwwhse");
            entity.Property(e => e.ShelfLocation)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("shelf_location");
            entity.Property(e => e.SixMosStaticUse).HasColumnName("six_mos_static_use");
            entity.Property(e => e.ThreeMosStaticUse).HasColumnName("three_mos_static_use");
            entity.Property(e => e.TwelveMoStaticUse).HasColumnName("twelve_mo_static_use");
            entity.Property(e => e.UsedField)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("used_field");
            entity.Property(e => e.VendorNumber)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_number");
            entity.Property(e => e.VendorNumber1)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_number1");
            entity.Property(e => e.VendorNumber2)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor_number2");
        });

        modelBuilder.Entity<PartsOnAc>(entity =>
        {
            entity.HasKey(e => e.PkTransactId).HasName("PK__parts_on__BDF67B3AA635256C");

            entity.ToTable("parts_on_ac", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
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
            entity.Property(e => e.Pfitmnmbr)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasColumnName("pfitmnmbr");
            entity.Property(e => e.Position)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("position");
            entity.Property(e => e.PrimaryPnQty).HasColumnName("primary_pn_qty");
            entity.Property(e => e.SPASupPreAl)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("s_p_a_sup_pre_al");
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
            entity.HasKey(e => e.PkTransactId).HasName("PK__parts_on__BDF67B3A09277B64");

            entity.ToTable("parts_on_order", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
            entity.Property(e => e.Account7x84)
                .HasMaxLength(58)
                .IsUnicode(false)
                .HasColumnName("account_7x8_4");
            entity.Property(e => e.Approved)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("approved");
            entity.Property(e => e.AvgAmntWhenRecvd)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("avg_amnt_when_recvd");
            entity.Property(e => e.BuyerCode)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("buyer_code");
            entity.Property(e => e.BuyerNotes7x60)
                .HasMaxLength(422)
                .IsUnicode(false)
                .HasColumnName("buyer_notes_7x60");
            entity.Property(e => e.Confirm)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("confirm");
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
            entity.Property(e => e.FreeOnBoard)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("free_on_board");
            entity.Property(e => e.Freight7x112)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("freight_7x11_2");
            entity.Property(e => e.InvoiceFlag)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("invoice_flag");
            entity.Property(e => e.InvoicedAmnt)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("invoiced_amnt");
            entity.Property(e => e.ItemTask7x322)
                .HasMaxLength(177)
                .IsUnicode(false)
                .HasColumnName("item_task_7x3_22");
            entity.Property(e => e.JobCards7x80)
                .HasMaxLength(58)
                .IsUnicode(false)
                .HasColumnName("job_cards_7x8_0");
            entity.Property(e => e.MultiplePgYN)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("multiple_pg_y_n");
            entity.Property(e => e.NoCharge)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("no_charge");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.OrderDate)
                .HasColumnType("date")
                .HasColumnName("order_date");
            entity.Property(e => e.OrderPer)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("order_per");
            entity.Property(e => e.OriginalInvoiAmnt)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("original_invoi_amnt");
            entity.Property(e => e.PageNumber).HasColumnName("page_number");
            entity.Property(e => e.PartNumber)
                .HasMaxLength(289)
                .IsUnicode(false)
                .HasColumnName("part_number");
            entity.Property(e => e.PoTerms)
                .HasMaxLength(67)
                .IsUnicode(false)
                .HasColumnName("po_terms");
            entity.Property(e => e.PrintFlag)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("print_flag");
            entity.Property(e => e.QtyOnhandRecvd)
                .HasMaxLength(51)
                .IsUnicode(false)
                .HasColumnName("qty_onhand_recvd");
            entity.Property(e => e.QtyOrdered)
                .HasMaxLength(37)
                .IsUnicode(false)
                .HasColumnName("qty_ordered");
            entity.Property(e => e.QtyReceived)
                .HasMaxLength(37)
                .IsUnicode(false)
                .HasColumnName("qty_received");
            entity.Property(e => e.QuotedAmnt)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("quoted_amnt");
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
            entity.Property(e => e.ShpHndl7x112)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasColumnName("shp_hndl_7x11_2");
            entity.Property(e => e.SpecInstr2x70)
                .HasMaxLength(142)
                .IsUnicode(false)
                .HasColumnName("spec_instr_2x70");
            entity.Property(e => e.Status)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Taxable)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("taxable");
            entity.Property(e => e.TypeOfPo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("type_of_po");
            entity.Property(e => e.UseCurx)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("use_curx");
            entity.Property(e => e.Vendor)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("vendor");
            entity.Property(e => e.VoidCloseFlag)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("void_close_flag");
        });

        modelBuilder.Entity<PartsRqstIssued>(entity =>
        {
            entity.HasKey(e => e.PkTransactId).HasName("PK__parts_rq__BDF67B3A95D74902");

            entity.ToTable("parts_rqst_issued", "maint");

            entity.Property(e => e.PkTransactId)
                .ValueGeneratedNever()
                .HasColumnName("pk_transact_id");
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
