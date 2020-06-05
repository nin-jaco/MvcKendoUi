using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EvolutionRepository.Models.Mapping;

namespace EvolutionRepository.Models
{
    public class EvolutionDBContext : DbContext
    {
        static EvolutionDBContext()
        {
            Database.SetInitializer<EvolutionDBContext>(null);
        }

		public EvolutionDBContext()
			: base("Name=EvolutionDBContext")
		{
            this.SetCommandTimeOut(300);
		}

        public void SetCommandTimeOut(int Timeout)
        {
            var objectContext = (this as IObjectContextAdapter).ObjectContext;
            objectContext.CommandTimeout = Timeout;
        }

        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Action> Actions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<ApplicationTab> ApplicationTabs { get; set; }
        public DbSet<ApplicationTabSubType> ApplicationTabSubTypes { get; set; }
        public DbSet<Approval> Approvals { get; set; }
        public DbSet<ApprovalStatus> ApprovalStatuses { get; set; }
        public DbSet<ApprovalType> ApprovalTypes { get; set; }
        public DbSet<ApprovedCertifiedModel> ApprovedCertifiedModels { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Audit> Audits { get; set; }
        public DbSet<AuditDailyArea> AuditDailyAreas { get; set; }
        public DbSet<AuditDailyCollection> AuditDailyCollections { get; set; }
        public DbSet<AuditDailyDeduction> AuditDailyDeductions { get; set; }
        public DbSet<AuditFiscalPeriod> AuditFiscalPeriods { get; set; }
        public DbSet<AuditFiscalPeriodType> AuditFiscalPeriodTypes { get; set; }
        public DbSet<AuditFiscalTotal> AuditFiscalTotals { get; set; }
        public DbSet<AuditMachineDeduction> AuditMachineDeductions { get; set; }
        public DbSet<AuditMachineTotal> AuditMachineTotals { get; set; }
        public DbSet<AuditOrganisationDeduction> AuditOrganisationDeductions { get; set; }
        public DbSet<AuditOrganisationInvoice> AuditOrganisationInvoices { get; set; }
        public DbSet<AuditOrganisationTotal> AuditOrganisationTotals { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<BankAccountType> BankAccountTypes { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<CardAction> CardActions { get; set; }
        public DbSet<CardData> CardDatas { get; set; }
        public DbSet<CardList> CardLists { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<CardWriteResult> CardWriteResults { get; set; }
        public DbSet<CEMSUtilLog> CEMSUtilLogs { get; set; }
        public DbSet<CertifiedFileHashResult> CertifiedFileHashResults { get; set; }
        public DbSet<CertifiedFile> CertifiedFiles { get; set; }
        public DbSet<CertifiedGame> CertifiedGames { get; set; }
        public DbSet<CertifiedModel> CertifiedModels { get; set; }
        public DbSet<CertifiedSoftwareHashingAlgorithm> CertifiedSoftwareHashingAlgorithms { get; set; }
        public DbSet<CollectionType> CollectionTypes { get; set; }
        public DbSet<CommunicationProtocol> CommunicationProtocols { get; set; }
        public DbSet<CommunicationProtocolVersion> CommunicationProtocolVersions { get; set; }
        public DbSet<DailyArea> DailyAreas { get; set; }
        public DbSet<DailyCollection> DailyCollections { get; set; }
        public DbSet<DailyDeduction> DailyDeductions { get; set; }
        public DbSet<DeductionTotalType> DeductionTotalTypes { get; set; }
        public DbSet<DeductionType> DeductionTypes { get; set; }
        public DbSet<Demographic> Demographics { get; set; }
        public DbSet<Denomination> Denominations { get; set; }
        public DbSet<DenominationType> DenominationTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<dtproperty> dtproperties { get; set; }
        public DbSet<EDCUnitSite> EDCUnitSites { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeStatus> EmployeeStatuses { get; set; }
        public DbSet<EmployeeTypeCardType> EmployeeTypeCardTypes { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<EntityType> EntityTypes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<FiscalPeriod> FiscalPeriods { get; set; }
        public DbSet<FiscalPeriodType> FiscalPeriodTypes { get; set; }
        public DbSet<FiscalYear> FiscalYears { get; set; }
        public DbSet<FrequencyType> FrequencyTypes { get; set; }
        public DbSet<FundsTransferMethod> FundsTransferMethods { get; set; }
        public DbSet<GameCollection> GameCollections { get; set; }
        public DbSet<GameStatus> GameStatus { get; set; }
        public DbSet<GameStatuses> GameStatuses { get; set; }
        public DbSet<GameTheme> GameThemes { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InstructionIssueType> InstructionIssueTypes { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<InstructionStatu> InstructionStatus { get; set; }
        public DbSet<InstructionType> InstructionTypes { get; set; }
        public DbSet<Jurisdiction> Jurisdictions { get; set; }
        public DbSet<JurisdictionType> JurisdictionTypes { get; set; }
        public DbSet<LicenseRenewal> LicenseRenewals { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<LicenseStatus> LicenseStatuses { get; set; }
        public DbSet<LicenseType> LicenseTypes { get; set; }
        public DbSet<LifeCycleStatu> LifeCycleStatus { get; set; }
        public DbSet<LoanRepayment> LoanRepayments { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<MachineApproval> MachineApprovals { get; set; }
        public DbSet<MachineCertifiedModel> MachineCertifiedModels { get; set; }
        public DbSet<MachineCollection> MachineCollections { get; set; }
        public DbSet<MachineConfig> MachineConfigs { get; set; }
        public DbSet<MachineDeduction> MachineDeductions { get; set; }
        public DbSet<MachineMovement> MachineMovements { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineStatu> MachineStatus { get; set; }
        public DbSet<MachineTotal> MachineTotals { get; set; }
        public DbSet<MachineType> MachineTypes { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<MovementStatu> MovementStatus { get; set; }
        public DbSet<MovementType> MovementTypes { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<OrganisationAddress> OrganisationAddresses { get; set; }
        public DbSet<OrganisationChildSubType> OrganisationChildSubTypes { get; set; }
        public DbSet<OrganisationComm> OrganisationComms { get; set; }
        public DbSet<OrganisationCommType> OrganisationCommTypes { get; set; }
        public DbSet<OrganisationDeduction> OrganisationDeductions { get; set; }
        public DbSet<OrganisationOption> OrganisationOptions { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<OrganisationStatu> OrganisationStatus { get; set; }
        public DbSet<OrganisationSubType> OrganisationSubTypes { get; set; }
        public DbSet<OrganisationTotal> OrganisationTotals { get; set; }
        public DbSet<OrganisationTypeCardType> OrganisationTypeCardTypes { get; set; }
        public DbSet<OrganisationType> OrganisationTypes { get; set; }
        public DbSet<OrgTree> OrgTrees { get; set; }
        public DbSet<PhotoEmployee> PhotoEmployees { get; set; }
        public DbSet<PhotoLibrary> PhotoLibraries { get; set; }
        public DbSet<PINUpdate> PINUpdates { get; set; }
        public DbSet<PrintJob> PrintJobs { get; set; }
        public DbSet<ProcessAuditLog> ProcessAuditLogs { get; set; }
        public DbSet<RepairStatus> RepairStatuses { get; set; }
        public DbSet<ResourceAction> ResourceActions { get; set; }
        public DbSet<ResourceLocation> ResourceLocations { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<RevenueProfile> RevenueProfiles { get; set; }
        public DbSet<RevenueProfileType> RevenueProfileTypes { get; set; }
        public DbSet<RevenueScale> RevenueScales { get; set; }
        public DbSet<ServiceCall> ServiceCalls { get; set; }
        public DbSet<SiteDeletedCard> SiteDeletedCards { get; set; }
        public DbSet<SiteDisabledPeriod> SiteDisabledPeriods { get; set; }
        public DbSet<SiteMachine> SiteMachines { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<SiteVisit> SiteVisits { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<systemsetting> systemsettings { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSession> UserSessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountTypeMap());
            modelBuilder.Configurations.Add(new ActionMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new AddressTypeMap());
            modelBuilder.Configurations.Add(new ApplicationTabMap());
            modelBuilder.Configurations.Add(new ApplicationTabSubTypeMap());
            modelBuilder.Configurations.Add(new ApprovalMap());
            modelBuilder.Configurations.Add(new ApprovalStatusMap());
            modelBuilder.Configurations.Add(new ApprovalTypeMap());
            modelBuilder.Configurations.Add(new ApprovedCertifiedModelMap());
            modelBuilder.Configurations.Add(new AreaMap());
            modelBuilder.Configurations.Add(new AuditMap());
            modelBuilder.Configurations.Add(new AuditDailyAreaMap());
            modelBuilder.Configurations.Add(new AuditDailyCollectionMap());
            modelBuilder.Configurations.Add(new AuditDailyDeductionMap());
            modelBuilder.Configurations.Add(new AuditFiscalPeriodMap());
            modelBuilder.Configurations.Add(new AuditFiscalPeriodTypeMap());
            modelBuilder.Configurations.Add(new AuditFiscalTotalMap());
            modelBuilder.Configurations.Add(new AuditMachineDeductionMap());
            modelBuilder.Configurations.Add(new AuditMachineTotalMap());
            modelBuilder.Configurations.Add(new AuditOrganisationDeductionMap());
            modelBuilder.Configurations.Add(new AuditOrganisationInvoiceMap());
            modelBuilder.Configurations.Add(new AuditOrganisationTotalMap());
            modelBuilder.Configurations.Add(new BankAccountMap());
            modelBuilder.Configurations.Add(new BankAccountTypeMap());
            modelBuilder.Configurations.Add(new BankMap());
            modelBuilder.Configurations.Add(new CabinetMap());
            modelBuilder.Configurations.Add(new CardActionMap());
            modelBuilder.Configurations.Add(new CardDataMap());
            modelBuilder.Configurations.Add(new CardListMap());
            modelBuilder.Configurations.Add(new CardMap());
            modelBuilder.Configurations.Add(new CardTypeMap());
            modelBuilder.Configurations.Add(new CardWriteResultMap());
            modelBuilder.Configurations.Add(new CEMSUtilLogMap());
            modelBuilder.Configurations.Add(new CertifiedFileHashResultMap());
            modelBuilder.Configurations.Add(new CertifiedFileMap());
            modelBuilder.Configurations.Add(new CertifiedGameMap());
            modelBuilder.Configurations.Add(new CertifiedModelMap());
            modelBuilder.Configurations.Add(new CertifiedSoftwareHashingAlgorithmMap());
            modelBuilder.Configurations.Add(new CollectionTypeMap());
            modelBuilder.Configurations.Add(new CommunicationProtocolMap());
            modelBuilder.Configurations.Add(new CommunicationProtocolVersionMap());
            modelBuilder.Configurations.Add(new DailyAreaMap());
            modelBuilder.Configurations.Add(new DailyCollectionMap());
            modelBuilder.Configurations.Add(new DailyDeductionMap());
            modelBuilder.Configurations.Add(new DeductionTotalTypeMap());
            modelBuilder.Configurations.Add(new DeductionTypeMap());
            modelBuilder.Configurations.Add(new DemographicMap());
            modelBuilder.Configurations.Add(new DenominationMap());
            modelBuilder.Configurations.Add(new DenominationTypeMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new dtpropertyMap());
            modelBuilder.Configurations.Add(new EDCUnitSiteMap());
            modelBuilder.Configurations.Add(new EmployeeAddressMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeStatusMap());
            modelBuilder.Configurations.Add(new EmployeeTypeCardTypeMap());
            modelBuilder.Configurations.Add(new EmployeeTypeMap());
            modelBuilder.Configurations.Add(new EntityTypeMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new EventTypeMap());
            modelBuilder.Configurations.Add(new FiscalPeriodMap());
            modelBuilder.Configurations.Add(new FiscalPeriodTypeMap());
            modelBuilder.Configurations.Add(new FiscalYearMap());
            modelBuilder.Configurations.Add(new FrequencyTypeMap());
            modelBuilder.Configurations.Add(new FundsTransferMethodMap());
            modelBuilder.Configurations.Add(new GameCollectionMap());
            modelBuilder.Configurations.Add(new GameStatusMap());
            modelBuilder.Configurations.Add(new GameStatusesMap());
            modelBuilder.Configurations.Add(new GameThemeMap());
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new InspectionMap());
            modelBuilder.Configurations.Add(new InstructionIssueTypeMap());
            modelBuilder.Configurations.Add(new InstructionMap());
            modelBuilder.Configurations.Add(new InstructionStatuMap());
            modelBuilder.Configurations.Add(new InstructionTypeMap());
            modelBuilder.Configurations.Add(new JurisdictionMap());
            modelBuilder.Configurations.Add(new JurisdictionTypeMap());
            modelBuilder.Configurations.Add(new LicenseRenewalMap());
            modelBuilder.Configurations.Add(new LicenseMap());
            modelBuilder.Configurations.Add(new LicenseStatusMap());
            modelBuilder.Configurations.Add(new LicenseTypeMap());
            modelBuilder.Configurations.Add(new LifeCycleStatuMap());
            modelBuilder.Configurations.Add(new LoanRepaymentMap());
            modelBuilder.Configurations.Add(new LoanMap());
            modelBuilder.Configurations.Add(new MachineApprovalMap());
            modelBuilder.Configurations.Add(new MachineCertifiedModelMap());
            modelBuilder.Configurations.Add(new MachineCollectionMap());
            modelBuilder.Configurations.Add(new MachineConfigMap());
            modelBuilder.Configurations.Add(new MachineDeductionMap());
            modelBuilder.Configurations.Add(new MachineMovementMap());
            modelBuilder.Configurations.Add(new MachineMap());
            modelBuilder.Configurations.Add(new MachineStatuMap());
            modelBuilder.Configurations.Add(new MachineTotalMap());
            modelBuilder.Configurations.Add(new MachineTypeMap());
            modelBuilder.Configurations.Add(new ModuleMap());
            modelBuilder.Configurations.Add(new MovementMap());
            modelBuilder.Configurations.Add(new MovementStatuMap());
            modelBuilder.Configurations.Add(new MovementTypeMap());
            modelBuilder.Configurations.Add(new NotificationMap());
            modelBuilder.Configurations.Add(new NotificationTypeMap());
            modelBuilder.Configurations.Add(new OperatorMap());
            modelBuilder.Configurations.Add(new OptionMap());
            modelBuilder.Configurations.Add(new OrganisationAddressMap());
            modelBuilder.Configurations.Add(new OrganisationChildSubTypeMap());
            modelBuilder.Configurations.Add(new OrganisationCommMap());
            modelBuilder.Configurations.Add(new OrganisationCommTypeMap());
            modelBuilder.Configurations.Add(new OrganisationDeductionMap());
            modelBuilder.Configurations.Add(new OrganisationOptionMap());
            modelBuilder.Configurations.Add(new OrganisationMap());
            modelBuilder.Configurations.Add(new OrganisationStatuMap());
            modelBuilder.Configurations.Add(new OrganisationSubTypeMap());
            modelBuilder.Configurations.Add(new OrganisationTotalMap());
            modelBuilder.Configurations.Add(new OrganisationTypeCardTypeMap());
            modelBuilder.Configurations.Add(new OrganisationTypeMap());
            modelBuilder.Configurations.Add(new OrgTreeMap());
            modelBuilder.Configurations.Add(new PhotoEmployeeMap());
            modelBuilder.Configurations.Add(new PhotoLibraryMap());
            modelBuilder.Configurations.Add(new PINUpdateMap());
            modelBuilder.Configurations.Add(new PrintJobMap());
            modelBuilder.Configurations.Add(new ProcessAuditLogMap());
            modelBuilder.Configurations.Add(new RepairStatusMap());
            modelBuilder.Configurations.Add(new ResourceActionMap());
            modelBuilder.Configurations.Add(new ResourceLocationMap());
            modelBuilder.Configurations.Add(new ResourceMap());
            modelBuilder.Configurations.Add(new RevenueProfileMap());
            modelBuilder.Configurations.Add(new RevenueProfileTypeMap());
            modelBuilder.Configurations.Add(new RevenueScaleMap());
            modelBuilder.Configurations.Add(new ServiceCallMap());
            modelBuilder.Configurations.Add(new SiteDeletedCardMap());
            modelBuilder.Configurations.Add(new SiteDisabledPeriodMap());
            modelBuilder.Configurations.Add(new SiteMachineMap());
            modelBuilder.Configurations.Add(new SiteMap());
            modelBuilder.Configurations.Add(new SiteVisitMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new systemsettingMap());
            modelBuilder.Configurations.Add(new TitleMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserSessionMap());
        }
    }
}
