using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.HS;

public partial class HsContext : DbContext
{
    public HsContext()
    {
    }

    public HsContext(DbContextOptions<HsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BillingInfoIdtf> BillingInfoIdtfs { get; set; }

    public virtual DbSet<ClientApp> ClientApps { get; set; }

    public virtual DbSet<ClientAppsAction> ClientAppsActions { get; set; }

    public virtual DbSet<Clinic> Clinics { get; set; }

    public virtual DbSet<ClinicRequest> ClinicRequests { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<DeviceMonitoringCenter> DeviceMonitoringCenters { get; set; }

    public virtual DbSet<DeviceSetting> DeviceSettings { get; set; }

    public virtual DbSet<DeviceStatistic> DeviceStatistics { get; set; }

    public virtual DbSet<DeviceUtilization> DeviceUtilizations { get; set; }

    public virtual DbSet<Distributor> Distributors { get; set; }

    public virtual DbSet<EcgEvent> EcgEvents { get; set; }

    public virtual DbSet<EcgEventMdg> EcgEventMdgs { get; set; }

    public virtual DbSet<EcgEventMobile> EcgEventMobiles { get; set; }

    public virtual DbSet<EcgEventOp> EcgEventOps { get; set; }

    public virtual DbSet<Indication> Indications { get; set; }

    public virtual DbSet<IndicationsGroup> IndicationsGroups { get; set; }

    public virtual DbSet<InsuranceCompany> InsuranceCompanies { get; set; }

    public virtual DbSet<IpaddressStatistic> IpaddressStatistics { get; set; }

    public virtual DbSet<LicenseManagerUser> LicenseManagerUsers { get; set; }

    public virtual DbSet<LicenseRequest> LicenseRequests { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LocationsGroup> LocationsGroups { get; set; }

    public virtual DbSet<MonitoringCenter> MonitoringCenters { get; set; }

    public virtual DbSet<PassCode> PassCodes { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<PatientAdditionalInfo> PatientAdditionalInfos { get; set; }

    public virtual DbSet<PatientMobileApp> PatientMobileApps { get; set; }

    public virtual DbSet<PhysicanClinicsGroup> PhysicanClinicsGroups { get; set; }

    public virtual DbSet<Physician> Physicians { get; set; }

    public virtual DbSet<Productivity> Productivities { get; set; }

    public virtual DbSet<ReceivedDatum> ReceivedData { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportBacklog> ReportBacklogs { get; set; }

    public virtual DbSet<Software> Softwares { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<StudyStatistic> StudyStatistics { get; set; }

    public virtual DbSet<TeamStatistic> TeamStatistics { get; set; }

    public virtual DbSet<Update> Updates { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserTime> UserTimes { get; set; }

    public virtual DbSet<UsersGroup> UsersGroups { get; set; }

    public virtual DbSet<ZipCode> ZipCodes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=HS;User Id=sa;Password=StrongPassword123!;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Cyrillic_General_CI_AS");

        modelBuilder.Entity<BillingInfoIdtf>(entity =>
        {
            entity.ToTable("BillingInfoIDTF");

            entity.HasIndex(e => e.Idpatient, "UQ__BillingI__44AED67468F1B266").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ClaimSubmDate).HasColumnType("datetime");
            entity.Property(e => e.ClinicBusinessName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Contact1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contact2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contact3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cpt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CPT");
            entity.Property(e => e.DeviceRecordingStartDate).HasColumnType("datetime");
            entity.Property(e => e.Gender)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Idpatient).HasColumnName("IDPatient");
            entity.Property(e => e.IndForMonitor)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Npi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientDob)
                .HasColumnType("datetime")
                .HasColumnName("PatientDOB");
            entity.Property(e => e.PatientLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PatientMi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PatientMI");
            entity.Property(e => e.PatientName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhysicianLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhysicianName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimInsCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrimInsGroupNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PrimInsIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PrimInsIDNumber");
            entity.Property(e => e.PrimInsPhone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrimPolicyName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RecordingId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RecordingID");
            entity.Property(e => e.SecInsCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SecInsGroupNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SecInsIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SecInsIDNumber");
            entity.Property(e => e.SecInsPhoneNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SecPolicyName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StudyType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SubscDob)
                .HasColumnType("datetime")
                .HasColumnName("SubscDOB");
            entity.Property(e => e.SubscRelationship)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClientApp>(entity =>
        {
            entity.HasIndex(e => e.Idcenter, "NonClusteredIndex-20211227-064742");

            entity.HasIndex(e => new { e.IdlicenseRequest, e.IsActive }, "NonClusteredIndex-20230925-230240");

            entity.HasIndex(e => new { e.Idcenter, e.IsActive }, "NonClusteredIndex-20230925-230316");

            entity.HasIndex(e => e.IsActive, "NonClusteredIndex-20230926-001435");

            entity.HasIndex(e => e.Idclinic, "NonClusteredIndex-20231021-075628");

            entity.HasIndex(e => e.AppKey, "NonClusteredIndex-20240629-043513");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdditionalClinics)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.AppKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdappRelated).HasColumnName("IDAppRelated");
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.Idclinic).HasColumnName("IDClinic");
            entity.Property(e => e.IdlicenseRequest).HasColumnName("IDLicenseRequest");

            entity.HasOne(d => d.IdcenterNavigation).WithMany(p => p.ClientApps)
                .HasForeignKey(d => d.Idcenter)
                .HasConstraintName("FK_ClientApps_Clinics");

            entity.HasOne(d => d.IdclinicNavigation).WithMany(p => p.ClientApps)
                .HasForeignKey(d => d.Idclinic)
                .HasConstraintName("FK_ClientApps_Clinic");

            entity.HasOne(d => d.IdlicenseRequestNavigation).WithMany(p => p.ClientApps)
                .HasForeignKey(d => d.IdlicenseRequest)
                .HasConstraintName("FK_ClientApps_LicenseRequests");
        });

        modelBuilder.Entity<ClientAppsAction>(entity =>
        {
            entity.HasIndex(e => e.AddedDate, "NonClusteredIndex-20230822-080711");

            entity.HasIndex(e => e.AddedDate, "NonClusteredIndex-20230828-233845");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionData)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.ClientAppId).HasColumnName("ClientAppID");
            entity.Property(e => e.ClinicName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeviceSn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DeviceSN");
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.Idclinic).HasColumnName("IDClinic");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.RecordingId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RecordingID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Clinic>(entity =>
        {
            entity.ToTable("Clinic");

            entity.HasIndex(e => e.Idcenter, "NonClusteredIndex-20211227-064805");

            entity.HasIndex(e => e.Idlocation, "NonClusteredIndex-20220628-075009");

            entity.HasIndex(e => e.ClinicName, "NonClusteredIndex-20220801-222531");

            entity.HasIndex(e => new { e.Iddistributor, e.Id }, "NonClusteredIndex-20230419-053258");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apikey)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("APIKey");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CellPhone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ClinicName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ClinicPhone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DestinationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DestinationID");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalID");
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.Iddistributor).HasColumnName("IDDistributor");
            entity.Property(e => e.IdindicationsGroup).HasColumnName("IDIndicationsGroup");
            entity.Property(e => e.IdlinkedClinic).HasColumnName("IDLinkedClinic");
            entity.Property(e => e.Idlocation).HasColumnName("IDLocation");
            entity.Property(e => e.IsFullMct).HasColumnName("IsFullMCT");
            entity.Property(e => e.IsUseSh).HasColumnName("IsUseSH");
            entity.Property(e => e.ItcontactInfo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ITContactInfo");
            entity.Property(e => e.Logo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SettingsTemplate)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.WiFiPwd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WiFiPWD");
            entity.Property(e => e.WiFiSsid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WiFiSSID");

            entity.HasOne(d => d.IdcenterNavigation).WithMany(p => p.Clinics)
                .HasForeignKey(d => d.Idcenter)
                .HasConstraintName("FK_Clinic_MonitoringCenter");

            entity.HasOne(d => d.IdlocationNavigation).WithMany(p => p.Clinics)
                .HasForeignKey(d => d.Idlocation)
                .HasConstraintName("FK_Clinic_Location");
        });

        modelBuilder.Entity<ClinicRequest>(entity =>
        {
            entity.ToTable("ClinicRequest");

            entity.HasIndex(e => e.AddedDate, "NonClusteredIndex-20230821-021032");

            entity.HasIndex(e => e.AddedDate, "NonClusteredIndex-20230828-233634");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.ClinicName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idclinic).HasColumnName("IDClinic");
            entity.Property(e => e.Idlrequest).HasColumnName("IDLRequest");
            entity.Property(e => e.RecordingId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RecordingID");
            entity.Property(e => e.RequestInfo)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.StatusInfo)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Device>(entity =>
        {
            entity.ToTable("Device");

            entity.HasIndex(e => new { e.Idcenter, e.Status, e.Idclinic }, "NonClusteredIndex-20211128-083607");

            entity.HasIndex(e => new { e.Idcenter, e.Idclinic }, "NonClusteredIndex-20211128-091228");

            entity.HasIndex(e => e.Idcenter, "NonClusteredIndex-20211205-060252");

            entity.HasIndex(e => e.Idclinic, "NonClusteredIndex-20211222-070435");

            entity.HasIndex(e => e.UniqueId, "NonClusteredIndex-20220801-222608");

            entity.HasIndex(e => e.Status, "NonClusteredIndex-20220801-222640");

            entity.HasIndex(e => new { e.Idclinic, e.IsRemoved }, "NonClusteredIndex-20221103-073935");

            entity.HasIndex(e => new { e.Idcenter, e.Model, e.Status }, "NonClusteredIndex-20221104-103415");

            entity.HasIndex(e => new { e.Idclinic, e.Class }, "NonClusteredIndex-20230712-001332");

            entity.HasIndex(e => e.UniqueId, "NonClusteredIndex-20231009-065540");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BuildDate).HasColumnType("datetime");
            entity.Property(e => e.DspfirmwareVer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DSPfirmwareVer");
            entity.Property(e => e.FirmwareDate).HasColumnType("datetime");
            entity.Property(e => e.Iccid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ICCID");
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.Idclinic).HasColumnName("IDClinic");
            entity.Property(e => e.Imei)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IMEI");
            entity.Property(e => e.McfirmwareVer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MCfirmwareVer");
            entity.Property(e => e.MdmfirmwareVer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MDMfirmwareVer");
            entity.Property(e => e.ModelNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Udi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UDI");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.IdcenterNavigation).WithMany(p => p.Devices)
                .HasForeignKey(d => d.Idcenter)
                .HasConstraintName("FK_Device_MonitoringCenter");

            entity.HasOne(d => d.IdclinicNavigation).WithMany(p => p.Devices)
                .HasForeignKey(d => d.Idclinic)
                .HasConstraintName("FK_Device_Clinic");
        });

        modelBuilder.Entity<DeviceMonitoringCenter>(entity =>
        {
            entity.HasIndex(e => e.IddeviceSettings, "NonClusteredIndex-20211128-083812");

            entity.HasIndex(e => new { e.Iddevice, e.Idcenter, e.Idclinic }, "NonClusteredIndex-20220111-222041");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttachDate).HasColumnType("datetime");
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.Idclinic).HasColumnName("IDClinic");
            entity.Property(e => e.Iddevice).HasColumnName("IDDevice");
            entity.Property(e => e.IddeviceSettings).HasColumnName("IDDeviceSettings");

            entity.HasOne(d => d.IddeviceNavigation).WithMany(p => p.DeviceMonitoringCenters)
                .HasForeignKey(d => d.Iddevice)
                .HasConstraintName("FK_DeviceMonitoringCenters_Device");
        });

        modelBuilder.Entity<DeviceSetting>(entity =>
        {
            entity.HasIndex(e => e.RecordingId, "IX_DeviceSettings").IsUnique();

            entity.HasIndex(e => e.Iddevice, "NonClusteredIndex-20211124-080650");

            entity.HasIndex(e => e.IsArchived, "NonClusteredIndex-20211128-083454");

            entity.HasIndex(e => e.Idpatient, "NonClusteredIndex-20211128-083735");

            entity.HasIndex(e => e.IsArchived, "NonClusteredIndex-20211205-060606");

            entity.HasIndex(e => new { e.IsArchived, e.Idclinic }, "NonClusteredIndex-20220103-053628");

            entity.HasIndex(e => e.Idclinic, "NonClusteredIndex-20220111-222218");

            entity.HasIndex(e => e.RecordingId, "NonClusteredIndex-20220520-070356");

            entity.HasIndex(e => e.RecordingId, "NonClusteredIndex-20220806-091344");

            entity.HasIndex(e => new { e.Idpatient, e.IsArchived }, "NonClusteredIndex-20221109-050126");

            entity.HasIndex(e => new { e.IsArchived, e.S3bucket }, "NonClusteredIndex-20230413-231831");

            entity.HasIndex(e => e.RecordingId, "NonClusteredIndex-20230524-090204");

            entity.HasIndex(e => e.Hpdays, "NonClusteredIndex-20230721-065742");

            entity.HasIndex(e => e.S3bucket, "NonClusteredIndex-20240113-032839");

            entity.HasIndex(e => e.HomeHookupStatus, "NonClusteredIndex-20240225-100835");

            entity.HasIndex(e => e.HomeHookupStatus, "NonClusteredIndex-20240225-101311");

            entity.HasIndex(e => e.Idclinic, "NonClusteredIndex-20240903-234224");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AfdurationUrgent).HasColumnName("AFDurationUrgent");
            entity.Property(e => e.AlternativeMode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BsmerrorMessage)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("BSMErrorMessage");
            entity.Property(e => e.Bsmstatus).HasColumnName("BSMStatus");
            entity.Property(e => e.ChannelLabelCh1)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.ChannelLabelCh2)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CompressDenEcg).HasColumnName("CompressDenECG");
            entity.Property(e => e.Cpt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CPT");
            entity.Property(e => e.Crc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CRC");
            entity.Property(e => e.CriticalSave)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Drl).HasColumnName("DRL");
            entity.Property(e => e.Dst).HasColumnName("DST");
            entity.Property(e => e.HomeHookupEnd).HasColumnType("datetime");
            entity.Property(e => e.HomeHookupStart).HasColumnType("datetime");
            entity.Property(e => e.Hpdays).HasColumnName("HPDays");
            entity.Property(e => e.Idclinic).HasColumnName("IDClinic");
            entity.Property(e => e.Iddevice).HasColumnName("IDDevice");
            entity.Property(e => e.Idpatient).HasColumnName("IDPatient");
            entity.Property(e => e.IsAf).HasColumnName("IsAF");
            entity.Property(e => e.LevelDrl).HasColumnName("LevelDRL");
            entity.Property(e => e.LevelLod).HasColumnName("LevelLOD");
            entity.Property(e => e.ReasonText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReasonsWr).HasColumnName("ReasonsWR");
            entity.Property(e => e.RecordingId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RecordingID");
            entity.Property(e => e.S3bucket).HasColumnName("S3Bucket");
            entity.Property(e => e.SaveDenEcg).HasColumnName("SaveDenECG");
            entity.Property(e => e.Svtrate).HasColumnName("SVTRate");
            entity.Property(e => e.Svtsensitivity).HasColumnName("SVTSensitivity");
            entity.Property(e => e.TimeZone)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Vtrate).HasColumnName("VTRate");
            entity.Property(e => e.Vtsensitivity).HasColumnName("VTSensitivity");

            entity.HasOne(d => d.IddeviceNavigation).WithMany(p => p.DeviceSettings)
                .HasForeignKey(d => d.Iddevice)
                .HasConstraintName("FK_DeviceSettings_Device");
        });

        modelBuilder.Entity<DeviceStatistic>(entity =>
        {
            entity.HasIndex(e => e.RecordingId, "NonClusteredIndex-20211128-083358");

            entity.HasIndex(e => e.Iddevice, "NonClusteredIndex-20211128-085138");

            entity.HasIndex(e => e.DeviceRecordingEndDate, "NonClusteredIndex-20220806-090714");

            entity.HasIndex(e => e.IndicatorNoData, "NonClusteredIndex-20220903-121653");

            entity.HasIndex(e => e.DeviceRecordingEndDate, "NonClusteredIndex-20230524-084802");

            entity.HasIndex(e => e.RecordingId, "NonClusteredIndex-20230524-085718");

            entity.HasIndex(e => new { e.Iddevice, e.RecordingId }, "NonClusteredIndex-20231001-233531");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DeviceRecordingEndDate).HasColumnType("datetime");
            entity.Property(e => e.DeviceRecordingStartDate).HasColumnType("datetime");
            entity.Property(e => e.Iddevice).HasColumnName("IDDevice");
            entity.Property(e => e.LastTransmission).HasColumnType("datetime");
            entity.Property(e => e.Qcsq)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("QCSQ");
            entity.Property(e => e.RecordingId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RecordingID");
            entity.Property(e => e.SdreFormatted).HasColumnName("SDreFormatted");

            entity.HasOne(d => d.IddeviceNavigation).WithMany(p => p.DeviceStatistics)
                .HasForeignKey(d => d.Iddevice)
                .HasConstraintName("FK_DeviceStatistics_Device");
        });

        modelBuilder.Entity<DeviceUtilization>(entity =>
        {
            entity.ToTable("DeviceUtilization");

            entity.HasIndex(e => e.Idclinic, "NonClusteredIndex-20220520-140125");

            entity.HasIndex(e => new { e.Idclinic, e.Idcenter }, "NonClusteredIndex-20220520-140158");

            entity.HasIndex(e => new { e.Idclinic, e.Idcenter }, "NonClusteredIndex-20220520-140218");

            entity.HasIndex(e => e.Day, "NonClusteredIndex-20221031-060032");

            entity.HasIndex(e => new { e.Day, e.Idclinic }, "NonClusteredIndex-20230419-065848");

            entity.HasIndex(e => e.Idcenter, "NonClusteredIndex-20250614-070211");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CountRma).HasColumnName("CountRMA");
            entity.Property(e => e.Day).HasColumnType("datetime");
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.Idclinic).HasColumnName("IDClinic");

            entity.HasOne(d => d.IdclinicNavigation).WithMany(p => p.DeviceUtilizations)
                .HasForeignKey(d => d.Idclinic)
                .HasConstraintName("FK_DeviceUtilization_Clinic");
        });

        modelBuilder.Entity<Distributor>(entity =>
        {
            entity.ToTable("Distributor");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DestinationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DestinationID");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalID");
            entity.Property(e => e.Idlocation).HasColumnName("IDLocation");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EcgEvent>(entity =>
        {
            entity.HasKey(e => e.IdecgEvent);

            entity.ToTable("EcgEvent");

            entity.HasIndex(e => new { e.IdreceivedData, e.Start }, "NonClusteredIndex-20211128-084420");

            entity.HasIndex(e => new { e.EcgEventSource, e.EventType, e.EventStartDate }, "NonClusteredIndex-20211128-084503");

            entity.HasIndex(e => e.IdreceivedData, "NonClusteredIndex-20211128-084608");

            entity.HasIndex(e => e.EventStatus, "NonClusteredIndex-20211206-000802");

            entity.HasIndex(e => new { e.EcgEventSource, e.EventType }, "NonClusteredIndex-20220130-031257");

            entity.HasIndex(e => e.EventStartDate, "NonClusteredIndex-20220520-133515");

            entity.HasIndex(e => new { e.Idoperator, e.EventStatus, e.EventStartDate }, "NonClusteredIndex-20220818-085229");

            entity.Property(e => e.IdecgEvent).HasColumnName("IDEcgEvent");
            entity.Property(e => e.Action)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.AvgHr).HasColumnName("AvgHR");
            entity.Property(e => e.EcgStripCaption)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.EventStartDate).HasColumnType("datetime");
            entity.Property(e => e.Idoperator).HasColumnName("IDOperator");
            entity.Property(e => e.IdreceivedData).HasColumnName("IDReceivedData");

            entity.HasOne(d => d.IdreceivedDataNavigation).WithMany(p => p.EcgEvents)
                .HasForeignKey(d => d.IdreceivedData)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EcgEvent_ReceivedData");
        });

        modelBuilder.Entity<EcgEventMdg>(entity =>
        {
            entity.ToTable("EcgEventMDG");

            entity.HasIndex(e => e.StartDate, "NonClusteredIndex-20240424-000756");

            entity.HasIndex(e => e.StartDate, "NonClusteredIndex-20240424-000915");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AvgHr).HasColumnName("AvgHR");
            entity.Property(e => e.EventType)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.RecordingId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RecordingID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EcgEventMobile>(entity =>
        {
            entity.ToTable("EcgEventMobile");

            entity.HasIndex(e => e.RecordingId, "NonClusteredIndex-20251014-044103");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Activity)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.IdecgEvent).HasColumnName("IDEcgEvent");
            entity.Property(e => e.Idpatient).HasColumnName("IDPatient");
            entity.Property(e => e.Location)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RecordingId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RecordingID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Symptoms)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<EcgEventOp>(entity =>
        {
            entity.ToTable("EcgEventOP");

            entity.HasIndex(e => e.Idcenter, "NonClusteredIndex-20230202-143908");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.IdecgEvent).HasColumnName("IDEcgEvent");
            entity.Property(e => e.IdreceivedData).HasColumnName("IDReceivedData");
        });

        modelBuilder.Entity<Indication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Indications");

            entity.ToTable("Indication");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IndicationsGroup>(entity =>
        {
            entity.ToTable("IndicationsGroup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Indications)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InsuranceCompany>(entity =>
        {
            entity.ToTable("InsuranceCompany");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUsabilityDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<IpaddressStatistic>(entity =>
        {
            entity.ToTable("IPAddressStatistics");

            entity.HasIndex(e => e.AddedDate, "NonClusteredIndex-20240522-233839");

            entity.HasIndex(e => e.AddedDate, "NonClusteredIndex-20240522-234305");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idapp).HasColumnName("IDApp");
            entity.Property(e => e.Idlicense).HasColumnName("IDLicense");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.IpinfoVpn).HasColumnName("IPinfoVPN");
            entity.Property(e => e.Organization)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Raa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RAA");
            entity.Property(e => e.Rdp).HasColumnName("RDP");
            entity.Property(e => e.UserName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Vpn).HasColumnName("VPN");
        });

        modelBuilder.Entity<LicenseManagerUser>(entity =>
        {
            entity.ToTable("LicenseManagerUser");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LastAccessDate).HasColumnType("datetime");
            entity.Property(e => e.MachineName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MotherboardInfo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LicenseRequest>(entity =>
        {
            entity.HasIndex(e => e.SoftwareType, "NonClusteredIndex-20220203-225740");

            entity.HasIndex(e => e.SoftwareType, "NonClusteredIndex-20220204-230902");

            entity.HasIndex(e => e.Email, "NonClusteredIndex-20220520-133436");

            entity.HasIndex(e => e.Name, "NonClusteredIndex-20221107-114440");

            entity.HasIndex(e => new { e.IsApproved, e.SoftwareType }, "NonClusteredIndex-20230524-083509");

            entity.HasIndex(e => new { e.SoftwareType, e.AllClinicLoad }, "NonClusteredIndex-20240514-064805");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HardwareInfo)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Idphysician).HasColumnName("IDPhysician");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastPwdChanged).HasColumnType("datetime");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Netversion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NETVersion");
            entity.Property(e => e.OptOut2Fa).HasColumnName("OptOut2FA");
            entity.Property(e => e.Organization)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Osversion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OSVersion");
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PortalUrl)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PortalURL");
            entity.Property(e => e.RegistrationInfo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ResetPwdDate).HasColumnType("datetime");
            entity.Property(e => e.SoftwareType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SoftwareVersion)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UserLoggedName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Waiver2Fa).HasColumnName("Waiver2FA");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("Location");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Address2)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Idstate).HasColumnName("IDState");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.IdstateNavigation).WithMany(p => p.Locations)
                .HasForeignKey(d => d.Idstate)
                .HasConstraintName("FK_Location_States");
        });

        modelBuilder.Entity<LocationsGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Locations");

            entity.ToTable("LocationsGroup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Idlocation).HasColumnName("IDLocation");

            entity.HasOne(d => d.IdlocationNavigation).WithMany(p => p.LocationsGroups)
                .HasForeignKey(d => d.Idlocation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_LocationsGroup_Location");
        });

        modelBuilder.Entity<MonitoringCenter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Clinics");

            entity.ToTable("MonitoringCenter");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apikey)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("APIKey");
            entity.Property(e => e.BusinessName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IdlocationsGroup).HasColumnName("IDLocationsGroup");
            entity.Property(e => e.IsFullMct).HasColumnName("IsFullMCT");
            entity.Property(e => e.Logo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PackageFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackageFileArchived)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdlocationsGroupNavigation).WithMany(p => p.MonitoringCenters)
                .HasForeignKey(d => d.IdlocationsGroup)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_MonitoringCenter_Locations");
        });

        modelBuilder.Entity<PassCode>(entity =>
        {
            entity.ToTable("PassCode");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AppliedDate).HasColumnType("datetime");
            entity.Property(e => e.GeneratedDate).HasColumnType("datetime");
            entity.Property(e => e.Idrequest).HasColumnName("IDRequest");
            entity.Property(e => e.PassCode1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PassCode");

            entity.HasOne(d => d.IdrequestNavigation).WithMany(p => p.PassCodes)
                .HasForeignKey(d => d.Idrequest)
                .HasConstraintName("FK_PassCode_LicenseRequests");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.ToTable("Patient");

            entity.HasIndex(e => e.Iddevice, "NonClusteredIndex-20211124-081104");

            entity.HasIndex(e => e.Idcenter, "NonClusteredIndex-20211128-083658");

            entity.HasIndex(e => new { e.Id, e.IdclinicPhysicianOrdering, e.Idcenter }, "NonClusteredIndex-20211128-084007");

            entity.HasIndex(e => new { e.Iddevice, e.IddeviceSettings, e.Idcenter }, "NonClusteredIndex-20211128-091338");

            entity.HasIndex(e => new { e.IdclinicPhysicianOrdering, e.Idcenter, e.Id }, "NonClusteredIndex-20211129-111813");

            entity.HasIndex(e => e.IdphysicianOrdering, "NonClusteredIndex-20220111-221943");

            entity.HasIndex(e => new { e.Iddevice, e.IddeviceSettings, e.IdclinicPhysicianOrdering, e.Idcenter, e.IsRemoved }, "NonClusteredIndex-20220119-074645");

            entity.HasIndex(e => e.IddeviceSettings, "NonClusteredIndex-20220124-211601");

            entity.HasIndex(e => e.Idlocation, "NonClusteredIndex-20220124-211637");

            entity.HasIndex(e => new { e.Iddevice, e.IddeviceSettings, e.IdclinicPhysicianOrdering, e.Idcenter, e.IsRemoved }, "NonClusteredIndex-20220204-231209");

            entity.HasIndex(e => new { e.Idcenter, e.IsRemoved, e.AddedDate }, "NonClusteredIndex-20220427-013222");

            entity.HasIndex(e => new { e.Name, e.LastName }, "NonClusteredIndex-20230524-084554");

            entity.HasIndex(e => e.Id, "NonClusteredIndex-20230524-090309");

            entity.HasIndex(e => new { e.Iddevice, e.IddeviceSettings, e.IdclinicPhysicianOrdering, e.Idcenter, e.IsRemoved }, "NonClusteredIndex-20230826-000739");

            entity.HasIndex(e => e.LastName, "NonClusteredIndex-20230930-090244");

            entity.HasIndex(e => new { e.Id, e.Idcenter }, "NonClusteredIndex-20231001-052945");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.CardiacDevice)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Comment)
                .HasMaxLength(1600)
                .IsUnicode(false);
            entity.Property(e => e.Contact1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contact2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contact3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Dst).HasColumnName("DST");
            entity.Property(e => e.Emrtype).HasColumnName("EMRType");
            entity.Property(e => e.ExternalId)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("ExternalID");
            entity.Property(e => e.Gender)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.IdclinicPhysicianOrdering).HasColumnName("IDClinicPhysicianOrdering");
            entity.Property(e => e.IdclinicPhysicianReading).HasColumnName("IDClinicPhysicianReading");
            entity.Property(e => e.IdclinicPhysicianReferring).HasColumnName("IDClinicPhysicianReferring");
            entity.Property(e => e.Iddevice).HasColumnName("IDDevice");
            entity.Property(e => e.IddeviceSettings).HasColumnName("IDDeviceSettings");
            entity.Property(e => e.Idlocation).HasColumnName("IDLocation");
            entity.Property(e => e.IdphysicianOrdering).HasColumnName("IDPhysicianOrdering");
            entity.Property(e => e.IdphysicianReading).HasColumnName("IDPhysicianReading");
            entity.Property(e => e.IdphysicianReferring).HasColumnName("IDPhysicianReferring");
            entity.Property(e => e.IndForMonitor)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Medications)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Mi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MI");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OrderID");
            entity.Property(e => e.PatientIdclinic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PatientIDClinic");
            entity.Property(e => e.PhysicianComment)
                .HasMaxLength(350)
                .IsUnicode(false);
            entity.Property(e => e.Ssn)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SSN");
            entity.Property(e => e.TimeZoneStandardName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdcenterNavigation).WithMany(p => p.Patients)
                .HasForeignKey(d => d.Idcenter)
                .HasConstraintName("FK_Patient_MonitoringCenter");

            entity.HasOne(d => d.IdclinicPhysicianOrderingNavigation).WithMany(p => p.PatientIdclinicPhysicianOrderingNavigations)
                .HasForeignKey(d => d.IdclinicPhysicianOrdering)
                .HasConstraintName("FK_Patient_Clinic");

            entity.HasOne(d => d.IdclinicPhysicianReadingNavigation).WithMany(p => p.PatientIdclinicPhysicianReadingNavigations)
                .HasForeignKey(d => d.IdclinicPhysicianReading)
                .HasConstraintName("FK_Patient_Clinic1");

            entity.HasOne(d => d.IdclinicPhysicianReferringNavigation).WithMany(p => p.PatientIdclinicPhysicianReferringNavigations)
                .HasForeignKey(d => d.IdclinicPhysicianReferring)
                .HasConstraintName("FK_Patient_Clinic2");

            entity.HasOne(d => d.IddeviceNavigation).WithMany(p => p.Patients)
                .HasForeignKey(d => d.Iddevice)
                .HasConstraintName("FK_Patient_Device");

            entity.HasOne(d => d.IddeviceSettingsNavigation).WithMany(p => p.Patients)
                .HasForeignKey(d => d.IddeviceSettings)
                .HasConstraintName("FK_Patient_DeviceSettings");

            entity.HasOne(d => d.IdlocationNavigation).WithMany(p => p.Patients)
                .HasForeignKey(d => d.Idlocation)
                .HasConstraintName("FK_Patient_Location");

            entity.HasOne(d => d.IdphysicianOrderingNavigation).WithMany(p => p.PatientIdphysicianOrderingNavigations)
                .HasForeignKey(d => d.IdphysicianOrdering)
                .HasConstraintName("FK_Patient_Physician1");

            entity.HasOne(d => d.IdphysicianReadingNavigation).WithMany(p => p.PatientIdphysicianReadingNavigations)
                .HasForeignKey(d => d.IdphysicianReading)
                .HasConstraintName("FK_Patient_Physician");

            entity.HasOne(d => d.IdphysicianReferringNavigation).WithMany(p => p.PatientIdphysicianReferringNavigations)
                .HasForeignKey(d => d.IdphysicianReferring)
                .HasConstraintName("FK_Patient_Physician2");
        });

        modelBuilder.Entity<PatientAdditionalInfo>(entity =>
        {
            entity.ToTable("PatientAdditionalInfo");

            entity.HasIndex(e => e.Idpatient, "NonClusteredIndex-20240423-082922");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.CardFiles)
                .HasMaxLength(600)
                .IsUnicode(false);
            entity.Property(e => e.Cpt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CPT");
            entity.Property(e => e.Entity)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Idlocation).HasColumnName("IDLocation");
            entity.Property(e => e.Idpatient).HasColumnName("IDPatient");
            entity.Property(e => e.PrimInsCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrimInsGroupNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PrimInsIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PrimInsIDNumber");
            entity.Property(e => e.PrimInsPhone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrimPolicyName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SecInsCompany)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SecInsGroupNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SecInsIdnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SecInsIDNumber");
            entity.Property(e => e.SecInsPhoneNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SecPolicyName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SpecifyRelationship)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SubscDob)
                .HasColumnType("datetime")
                .HasColumnName("SubscDOB");
            entity.Property(e => e.SubscFirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubscLastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubscRelationship)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PatientMobileApp>(entity =>
        {
            entity.ToTable("PatientMobileApp");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idpatient).HasColumnName("IDPatient");
            entity.Property(e => e.PatientPhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.RemovedDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdpatientNavigation).WithMany(p => p.PatientMobileApps)
                .HasForeignKey(d => d.Idpatient)
                .HasConstraintName("FK_PatientMobileApp_Patient");
        });

        modelBuilder.Entity<PhysicanClinicsGroup>(entity =>
        {
            entity.ToTable("PhysicanClinicsGroup");

            entity.HasIndex(e => e.Idphysician, "NonClusteredIndex-20231001-233336");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idclinic).HasColumnName("IDClinic");
            entity.Property(e => e.Idphysician).HasColumnName("IDPhysician");

            entity.HasOne(d => d.IdclinicNavigation).WithMany(p => p.PhysicanClinicsGroups)
                .HasForeignKey(d => d.Idclinic)
                .HasConstraintName("FK_PhysicanClinicsGroup_Clinic");

            entity.HasOne(d => d.IdphysicianNavigation).WithMany(p => p.PhysicanClinicsGroups)
                .HasForeignKey(d => d.Idphysician)
                .HasConstraintName("FK_PhysicanClinicsGroup_Physician");
        });

        modelBuilder.Entity<Physician>(entity =>
        {
            entity.ToTable("Physician");

            entity.HasIndex(e => e.Idcenter, "NonClusteredIndex-20231218-134213");

            entity.HasIndex(e => e.Idcenter, "NonClusteredIndex-20231218-134343");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Mi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MI");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NotificationCriteria)
                .HasMaxLength(700)
                .IsUnicode(false);
            entity.Property(e => e.NotificationTemplate)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Npi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Phone2)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.IdcenterNavigation).WithMany(p => p.Physicians)
                .HasForeignKey(d => d.Idcenter)
                .HasConstraintName("FK_Physician_MonitoringCenter");
        });

        modelBuilder.Entity<Productivity>(entity =>
        {
            entity.ToTable("Productivity");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Day).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Evcount).HasColumnName("EVCount");
            entity.Property(e => e.GroupName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.OperatorName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Statcount).HasColumnName("STATCount");
            entity.Property(e => e.SummaryEr).HasColumnName("SummaryER");
            entity.Property(e => e.SummaryMct).HasColumnName("SummaryMCT");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ReceivedDatum>(entity =>
        {
            entity.HasIndex(e => new { e.FolderName, e.Iddevice }, "IX_FolderName_IDDevice");

            entity.HasIndex(e => new { e.Iddevice, e.RecordingId }, "IX_IDDevice_RecordingID");

            entity.HasIndex(e => new { e.Iddevice, e.RecordingId, e.EventSource }, "IX_IDDevice_RecordingID_EventSource");

            entity.HasIndex(e => new { e.Iddevice, e.RecordingId, e.IsResolved }, "IX_IDDevice_RecordingID_IsResolved");

            entity.HasIndex(e => new { e.RecordingId, e.StartDate }, "IX_RecordingID_StartDate");

            entity.HasIndex(e => e.StartDate, "IX_StartDate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FolderName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Idclinic).HasColumnName("IDClinic");
            entity.Property(e => e.Iddevice).HasColumnName("IDDevice");
            entity.Property(e => e.RecordingId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RecordingID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");

            entity.HasOne(d => d.IdclinicNavigation).WithMany(p => p.ReceivedData)
                .HasForeignKey(d => d.Idclinic)
                .HasConstraintName("FK_ReceivedData_Clinic");

            entity.HasOne(d => d.IddeviceNavigation).WithMany(p => p.ReceivedData)
                .HasForeignKey(d => d.Iddevice)
                .HasConstraintName("FK_ReceivedData_Device");

            entity.HasOne(d => d.Recording).WithMany(p => p.ReceivedData)
                .HasPrincipalKey(p => p.RecordingId)
                .HasForeignKey(d => d.RecordingId)
                .HasConstraintName("FK_ReceivedData_DeviceSettings");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.ToTable("Report");

            entity.HasIndex(e => e.IddeviceSettings, "<RIDDS, sysname,>");

            entity.HasIndex(e => new { e.Id, e.Idclinic }, "NonClusteredIndex-20211128-083910");

            entity.HasIndex(e => e.Idclinic, "NonClusteredIndex-20211129-111706");

            entity.HasIndex(e => e.Iduser, "NonClusteredIndex-20220809-055045");

            entity.HasIndex(e => new { e.Iduser, e.ReportDate }, "NonClusteredIndex-20221217-050726");

            entity.HasIndex(e => e.ReportDate, "NonClusteredIndex-20230721-065704");

            entity.HasIndex(e => new { e.Iduser, e.ReportDate }, "NonClusteredIndex-20240225-101426");

            entity.HasIndex(e => new { e.Iduser, e.ReportDate }, "NonClusteredIndex-20240225-101907");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DailyReportDay).HasColumnType("datetime");
            entity.Property(e => e.Idclinic).HasColumnName("IDClinic");
            entity.Property(e => e.IddeviceSettings).HasColumnName("IDDeviceSettings");
            entity.Property(e => e.IdreceivedData).HasColumnName("IDReceivedData");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.MergedInfo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhysicianInterpretation)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ReportDate).HasColumnType("datetime");
            entity.Property(e => e.ReportDownloadPath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
            entity.Property(e => e.SummaryData)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.TechnicianFindings)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(d => d.IddeviceSettingsNavigation).WithMany(p => p.Reports)
                .HasForeignKey(d => d.IddeviceSettings)
                .HasConstraintName("FK_Report_DeviceSettings");

            entity.HasOne(d => d.IduserNavigation).WithMany(p => p.Reports)
                .HasForeignKey(d => d.Iduser)
                .HasConstraintName("FK_Report_User");
        });

        modelBuilder.Entity<ReportBacklog>(entity =>
        {
            entity.ToTable("ReportBacklog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Day).HasColumnType("datetime");
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
        });

        modelBuilder.Entity<Software>(entity =>
        {
            entity.ToTable("Software");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SoftwareType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.State1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("State");
        });

        modelBuilder.Entity<StudyStatistic>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AlternativeMode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ClinicName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Cpt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CPT");
            entity.Property(e => e.DeviceRecordingEndDate).HasColumnType("datetime");
            entity.Property(e => e.DeviceRecordingStartDate).HasColumnType("datetime");
            entity.Property(e => e.DeviceSn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DeviceSN");
            entity.Property(e => e.DowngradedMode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirstConfirmedArrhythmia).HasColumnType("datetime");
            entity.Property(e => e.FirstStat)
                .HasColumnType("datetime")
                .HasColumnName("FirstSTAT");
            entity.Property(e => e.Hpdays).HasColumnName("HPDays");
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.Idclinic).HasColumnName("IDClinic");
            entity.Property(e => e.IndForMonitor)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.OperatingMode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PatientDob)
                .HasColumnType("datetime")
                .HasColumnName("PatientDOB");
            entity.Property(e => e.PatientMrn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PatientMRN");
            entity.Property(e => e.RecordingId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RecordingID");
            entity.Property(e => e.TechDiagnoses)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TeamStatistic>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AvglengthEr).HasColumnName("AVGLengthER");
            entity.Property(e => e.AvglengthHolter).HasColumnName("AVGLengthHolter");
            entity.Property(e => e.AvglengthHolterPlus).HasColumnName("AVGLengthHolterPlus");
            entity.Property(e => e.AvglengthMct).HasColumnName("AVGLengthMCT");
            entity.Property(e => e.CenterName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Day).HasColumnType("datetime");
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.ReportsEr).HasColumnName("ReportsER");
            entity.Property(e => e.ReportsMct).HasColumnName("ReportsMCT");
            entity.Property(e => e.StudiesEr).HasColumnName("StudiesER");
            entity.Property(e => e.StudiesMct).HasColumnName("StudiesMCT");
        });

        modelBuilder.Entity<Update>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Details)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.SoftwareType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SoftwareVersion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateFileWebPath)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.HasIndex(e => e.Idapp, "NonClusteredIndex-20240225-100924");

            entity.HasIndex(e => e.Idapp, "NonClusteredIndex-20240225-101019");

            entity.HasIndex(e => e.Idapp, "NonClusteredIndex-20240225-101433");

            entity.HasIndex(e => e.Idapp, "NonClusteredIndex-20240225-101450");

            entity.HasIndex(e => new { e.IdusersGroup, e.Activated }, "NonClusteredIndex-20240225-101854");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idapp).HasColumnName("IDApp");
            entity.Property(e => e.IdusersGroup).HasColumnName("IDUsersGroup");
            entity.Property(e => e.Initials)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastAccessDate).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdappNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Idapp)
                .HasConstraintName("FK_User_ClientApps");

            entity.HasOne(d => d.IdusersGroupNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdusersGroup)
                .HasConstraintName("FK_User_Users");
        });

        modelBuilder.Entity<UserTime>(entity =>
        {
            entity.ToTable("UserTime");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullUserName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Idcenter).HasColumnName("IDCenter");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");

            entity.HasOne(d => d.IduserNavigation).WithMany(p => p.UserTimes)
                .HasForeignKey(d => d.Iduser)
                .HasConstraintName("FK_UserTime_User");
        });

        modelBuilder.Entity<UsersGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Users");

            entity.ToTable("UsersGroup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdsoftwareType).HasColumnName("IDSoftwareType");

            entity.HasOne(d => d.IdsoftwareTypeNavigation).WithMany(p => p.UsersGroups)
                .HasForeignKey(d => d.IdsoftwareType)
                .HasConstraintName("FK_UsersGroup_Software");
        });

        modelBuilder.Entity<ZipCode>(entity =>
        {
            entity.ToTable("ZipCode");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Dst).HasColumnName("DST");
            entity.Property(e => e.State)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Timezone)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
