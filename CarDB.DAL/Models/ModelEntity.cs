namespace CarDB.DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelEntity : DbContext
    {
        public ModelEntity()
            : base("name=ModelEntity")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AccessTab> AccessTab { get; set; }
        public virtual DbSet<AccessUser> AccessUser { get; set; }
        public virtual DbSet<Checklist> Checklist { get; set; }
        public virtual DbSet<ChecklistInterval> ChecklistInterval { get; set; }
        public virtual DbSet<ChecklistPart> ChecklistPart { get; set; }
        public virtual DbSet<ChecklistStep> ChecklistStep { get; set; }
        public virtual DbSet<newEquipment> newEquipment { get; set; }
        public virtual DbSet<PMChecklist> PMChecklist { get; set; }
        public virtual DbSet<PMChecklistAssign> PMChecklistAssign { get; set; }
        public virtual DbSet<PMChecklistInterval> PMChecklistInterval { get; set; }
        public virtual DbSet<PMChecklistPart> PMChecklistPart { get; set; }
        public virtual DbSet<PMChecklistStep> PMChecklistStep { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TableEquipmentHistory> TableEquipmentHistory { get; set; }
        public virtual DbSet<TableEvaluationPriority> TableEvaluationPriority { get; set; }
        public virtual DbSet<TableEvaluationStatys> TableEvaluationStatys { get; set; }
        public virtual DbSet<TableEvaluationSysStatus> TableEvaluationSysStatus { get; set; }
        public virtual DbSet<TableExchangeRate> TableExchangeRate { get; set; }
        public virtual DbSet<TableGroupAccess> TableGroupAccess { get; set; }
        public virtual DbSet<TableGroupAccessTab> TableGroupAccessTab { get; set; }
        public virtual DbSet<TablesAction> TablesAction { get; set; }
        public virtual DbSet<TablesComponentType> TablesComponentType { get; set; }
        public virtual DbSet<TablesComponentTypeModelReleased> TablesComponentTypeModelReleased { get; set; }
        public virtual DbSet<TablesComponentTypeSMCSInterval> TablesComponentTypeSMCSInterval { get; set; }
        public virtual DbSet<TablesConsumable> TablesConsumable { get; set; }
        public virtual DbSet<TablesCurrency> TablesCurrency { get; set; }
        public virtual DbSet<TablesEquipmentType> TablesEquipmentType { get; set; }
        public virtual DbSet<TablesFamilyType> TablesFamilyType { get; set; }
        public virtual DbSet<TablesJobReason> TablesJobReason { get; set; }
        public virtual DbSet<TablesLocation> TablesLocation { get; set; }
        public virtual DbSet<TablesMachineSystem> TablesMachineSystem { get; set; }
        public virtual DbSet<TablesManufacturer> TablesManufacturer { get; set; }
        public virtual DbSet<TablesMasterPart> TablesMasterPart { get; set; }
        public virtual DbSet<TablesModel> TablesModel { get; set; }
        public virtual DbSet<TablesModifier> TablesModifier { get; set; }
        public virtual DbSet<TablesQuantity> TablesQuantity { get; set; }
        public virtual DbSet<TablesSimsCode> TablesSimsCode { get; set; }
        public virtual DbSet<TablesSimsType> TablesSimsType { get; set; }
        public virtual DbSet<TablesSize> TablesSize { get; set; }
        public virtual DbSet<TablesSmcsCodeMachineSystem> TablesSmcsCodeMachineSystem { get; set; }
        public virtual DbSet<TablesSMCSComponent> TablesSMCSComponent { get; set; }
        public virtual DbSet<TablesSMCSFamily> TablesSMCSFamily { get; set; }
        public virtual DbSet<TablesSMCSJob> TablesSMCSJob { get; set; }
        public virtual DbSet<TablesSMCSModifier> TablesSMCSModifier { get; set; }
        public virtual DbSet<TablesSMCSQuantity> TablesSMCSQuantity { get; set; }
        public virtual DbSet<TablesSNPrefix> TablesSNPrefix { get; set; }
        public virtual DbSet<TablesStopReason> TablesStopReason { get; set; }
        public virtual DbSet<TablesSupplier> TablesSupplier { get; set; }
        public virtual DbSet<TableStopReason> TableStopReason { get; set; }
        public virtual DbSet<TablesTypesInspection> TablesTypesInspection { get; set; }
        public virtual DbSet<TableSubcontracting> TableSubcontracting { get; set; }
        public virtual DbSet<TrackAdditionalInformation> TrackAdditionalInformation { get; set; }
        public virtual DbSet<TrackComponent> TrackComponent { get; set; }
        public virtual DbSet<TrackComponentHistory> TrackComponentHistory { get; set; }
        public virtual DbSet<TrackConsumable> TrackConsumable { get; set; }
        public virtual DbSet<TrackEvaluation> TrackEvaluation { get; set; }
        public virtual DbSet<TrackEvaluationComment> TrackEvaluationComment { get; set; }
        public virtual DbSet<TrackEvaluationPart> TrackEvaluationPart { get; set; }
        public virtual DbSet<TrackEvaluationSimsData> TrackEvaluationSimsData { get; set; }
        public virtual DbSet<TrackMeter> TrackMeter { get; set; }
        public virtual DbSet<TrackSchedule> TrackSchedule { get; set; }
        public virtual DbSet<TrackSchedulePlan> TrackSchedulePlan { get; set; }
        public virtual DbSet<TrackSchedulePlanInterval> TrackSchedulePlanInterval { get; set; }
        public virtual DbSet<TrackServiceHistory> TrackServiceHistory { get; set; }
        public virtual DbSet<TrackServiceHistoryPart> TrackServiceHistoryPart { get; set; }
        public virtual DbSet<TrackServiceHistoryProvider> TrackServiceHistoryProvider { get; set; }
        public virtual DbSet<TrackTechnicalWorkComponent> TrackTechnicalWorkComponent { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserHistory> UserHistory { get; set; }
        public virtual DbSet<UserHistoryKJ> UserHistoryKJ { get; set; }
        public virtual DbSet<UserHistorySet> UserHistorySet { get; set; }
        public virtual DbSet<UsersLocation> UsersLocation { get; set; }
        public virtual DbSet<ChecklistAssign> ChecklistAssign { get; set; }
        public virtual DbSet<TablesComponentCodeType_Altyntau> TablesComponentCodeType_Altyntau { get; set; }
        public virtual DbSet<TablesComponentCodeType_BogatyrCoal> TablesComponentCodeType_BogatyrCoal { get; set; }
        public virtual DbSet<TablesComponentCodeType_Ormet> TablesComponentCodeType_Ormet { get; set; }
        public virtual DbSet<TablesComponentCodeType_Ust_Kamenogorsk> TablesComponentCodeType_Ust_Kamenogorsk { get; set; }
        public virtual DbSet<TablesComponentCodeType_Varvarinskoye> TablesComponentCodeType_Varvarinskoye { get; set; }
        public virtual DbSet<TablesPMRepairType_Altyntau> TablesPMRepairType_Altyntau { get; set; }
        public virtual DbSet<TablesPMRepairType_BogatyrCoal> TablesPMRepairType_BogatyrCoal { get; set; }
        public virtual DbSet<TablesPMRepairType_Ormet> TablesPMRepairType_Ormet { get; set; }
        public virtual DbSet<TablesPMRepairType_Ust_Kamenogorsk> TablesPMRepairType_Ust_Kamenogorsk { get; set; }
        public virtual DbSet<TablesPMRepairType_Varvarinskoye> TablesPMRepairType_Varvarinskoye { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Checklist>()
                .HasMany(e => e.ChecklistInterval)
                .WithRequired(e => e.Checklist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Checklist>()
                .HasMany(e => e.ChecklistStep)
                .WithRequired(e => e.Checklist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Checklist>()
                .HasMany(e => e.PMChecklistAssign)
                .WithRequired(e => e.Checklist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChecklistInterval>()
                .HasMany(e => e.ChecklistStep)
                .WithRequired(e => e.ChecklistInterval)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChecklistStep>()
                .HasMany(e => e.ChecklistPart)
                .WithRequired(e => e.ChecklistStep)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<newEquipment>()
                .HasMany(e => e.TrackMeter)
                .WithRequired(e => e.newEquipment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PMChecklist>()
                .HasMany(e => e.TrackSchedule)
                .WithOptional(e => e.PMChecklist)
                .HasForeignKey(e => e.intPmChecklist);

            modelBuilder.Entity<TableEvaluationPriority>()
                .HasMany(e => e.TrackEvaluation)
                .WithOptional(e => e.TableEvaluationPriority)
                .HasForeignKey(e => e.intPriority);

            modelBuilder.Entity<TablesConsumable>()
                .HasMany(e => e.TrackConsumable)
                .WithOptional(e => e.TablesConsumable)
                .HasForeignKey(e => e.intTypeConsumableId);

            modelBuilder.Entity<TablesEquipmentType>()
                .HasMany(e => e.Checklist)
                .WithOptional(e => e.TablesEquipmentType)
                .HasForeignKey(e => e.intEquipmentType);

            modelBuilder.Entity<TablesEquipmentType>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesEquipmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesEquipmentType>()
                .HasMany(e => e.PMChecklist)
                .WithOptional(e => e.TablesEquipmentType)
                .HasForeignKey(e => e.intEquipmentType);

            modelBuilder.Entity<TablesFamilyType>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesFamilyType)
                .HasForeignKey(e => e.intSMCSFamilyID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesLocation>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesLocation>()
                .HasMany(e => e.TablesEquipmentType)
                .WithRequired(e => e.TablesLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesLocation>()
                .HasMany(e => e.TablesJobReason)
                .WithRequired(e => e.TablesLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesLocation>()
                .HasMany(e => e.TablesStopReason)
                .WithRequired(e => e.TablesLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesLocation>()
                .HasMany(e => e.TablesSupplier)
                .WithRequired(e => e.TablesLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesLocation>()
                .HasMany(e => e.UsersLocation)
                .WithRequired(e => e.TablesLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesManufacturer>()
                .HasMany(e => e.Checklist)
                .WithOptional(e => e.TablesManufacturer)
                .HasForeignKey(e => e.intManufacturer);

            modelBuilder.Entity<TablesManufacturer>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesManufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesManufacturer>()
                .HasMany(e => e.PMChecklist)
                .WithOptional(e => e.TablesManufacturer)
                .HasForeignKey(e => e.intManufacturer);

            modelBuilder.Entity<TablesMasterPart>()
                .HasOptional(e => e.ChecklistPart)
                .WithRequired(e => e.TablesMasterPart);

            modelBuilder.Entity<TablesMasterPart>()
                .HasMany(e => e.PMChecklistPart)
                .WithRequired(e => e.TablesMasterPart)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesMasterPart>()
                .HasMany(e => e.TrackEvaluationPart)
                .WithRequired(e => e.TablesMasterPart)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesMasterPart>()
                .HasMany(e => e.TrackServiceHistoryPart)
                .WithRequired(e => e.TablesMasterPart)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesModel>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesModel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesSize>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesSize)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesSNPrefix>()
                .HasMany(e => e.newEquipment)
                .WithRequired(e => e.TablesSNPrefix)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TablesSupplier>()
                .HasMany(e => e.TrackServiceHistoryProvider)
                .WithRequired(e => e.TablesSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TrackComponent>()
                .HasMany(e => e.TrackTechnicalWorkComponent)
                .WithRequired(e => e.TrackComponent)
                .HasForeignKey(e => e.intTWComponentId);

            modelBuilder.Entity<TrackEvaluation>()
                .HasMany(e => e.TrackEvaluationSimsData)
                .WithRequired(e => e.TrackEvaluation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TrackEvaluationPart>()
                .HasMany(e => e.TrackEvaluationSimsData)
                .WithRequired(e => e.TrackEvaluationPart)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TrackEvaluation)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.intCreateUserIdBL);
        }
    }
}
