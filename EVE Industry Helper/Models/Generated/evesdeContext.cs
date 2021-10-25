using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EVE_Industry_Helper.Models.Generated
{
    public partial class evesdeContext : DbContext
    {
        public evesdeContext()
        {
        }

        public evesdeContext(DbContextOptions<evesdeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AgtAgent> AgtAgents { get; set; }
        public virtual DbSet<AgtAgentType> AgtAgentTypes { get; set; }
        public virtual DbSet<AgtAgentsInSpace> AgtAgentsInSpaces { get; set; }
        public virtual DbSet<AgtResearchAgent> AgtResearchAgents { get; set; }
        public virtual DbSet<CertCert> CertCerts { get; set; }
        public virtual DbSet<CertMastery> CertMasteries { get; set; }
        public virtual DbSet<CertSkill> CertSkills { get; set; }
        public virtual DbSet<ChrAncestry> ChrAncestries { get; set; }
        public virtual DbSet<ChrAttribute> ChrAttributes { get; set; }
        public virtual DbSet<ChrBloodline> ChrBloodlines { get; set; }
        public virtual DbSet<ChrFaction> ChrFactions { get; set; }
        public virtual DbSet<ChrRace> ChrRaces { get; set; }
        public virtual DbSet<CrpActivity> CrpActivities { get; set; }
        public virtual DbSet<CrpNpccorporation> CrpNpccorporations { get; set; }
        public virtual DbSet<CrpNpccorporationDivision> CrpNpccorporationDivisions { get; set; }
        public virtual DbSet<CrpNpccorporationResearchField> CrpNpccorporationResearchFields { get; set; }
        public virtual DbSet<CrpNpccorporationTrade> CrpNpccorporationTrades { get; set; }
        public virtual DbSet<CrpNpcdivision> CrpNpcdivisions { get; set; }
        public virtual DbSet<DgmAttributeCategory> DgmAttributeCategories { get; set; }
        public virtual DbSet<DgmAttributeType> DgmAttributeTypes { get; set; }
        public virtual DbSet<DgmEffect> DgmEffects { get; set; }
        public virtual DbSet<DgmExpression> DgmExpressions { get; set; }
        public virtual DbSet<DgmTypeAttribute> DgmTypeAttributes { get; set; }
        public virtual DbSet<DgmTypeEffect> DgmTypeEffects { get; set; }
        public virtual DbSet<EveGraphic> EveGraphics { get; set; }
        public virtual DbSet<EveIcon> EveIcons { get; set; }
        public virtual DbSet<EveUnit> EveUnits { get; set; }
        public virtual DbSet<IndustryActivity> IndustryActivities { get; set; }
        public virtual DbSet<IndustryActivityMaterial> IndustryActivityMaterials { get; set; }
        public virtual DbSet<IndustryActivityProbability> IndustryActivityProbabilities { get; set; }
        public virtual DbSet<IndustryActivityProduct> IndustryActivityProducts { get; set; }
        public virtual DbSet<IndustryActivityRace> IndustryActivityRaces { get; set; }
        public virtual DbSet<IndustryActivitySkill> IndustryActivitySkills { get; set; }
        public virtual DbSet<IndustryBlueprint> IndustryBlueprints { get; set; }
        public virtual DbSet<InvCategory> InvCategories { get; set; }
        public virtual DbSet<InvContrabandType> InvContrabandTypes { get; set; }
        public virtual DbSet<InvControlTowerResource> InvControlTowerResources { get; set; }
        public virtual DbSet<InvControlTowerResourcePurpose> InvControlTowerResourcePurposes { get; set; }
        public virtual DbSet<InvFlag> InvFlags { get; set; }
        public virtual DbSet<InvGroup> InvGroups { get; set; }
        public virtual DbSet<InvItem> InvItems { get; set; }
        public virtual DbSet<InvMarketGroup> InvMarketGroups { get; set; }
        public virtual DbSet<InvMetaGroup> InvMetaGroups { get; set; }
        public virtual DbSet<InvMetaType> InvMetaTypes { get; set; }
        public virtual DbSet<InvName> InvNames { get; set; }
        public virtual DbSet<InvPosition> InvPositions { get; set; }
        public virtual DbSet<InvTrait> InvTraits { get; set; }
        public virtual DbSet<InvType> InvTypes { get; set; }
        public virtual DbSet<InvTypeMaterial> InvTypeMaterials { get; set; }
        public virtual DbSet<InvTypeReaction> InvTypeReactions { get; set; }
        public virtual DbSet<InvUniqueName> InvUniqueNames { get; set; }
        public virtual DbSet<InvVolume> InvVolumes { get; set; }
        public virtual DbSet<MapCelestialGraphic> MapCelestialGraphics { get; set; }
        public virtual DbSet<MapCelestialStatistic> MapCelestialStatistics { get; set; }
        public virtual DbSet<MapConstellation> MapConstellations { get; set; }
        public virtual DbSet<MapConstellationJump> MapConstellationJumps { get; set; }
        public virtual DbSet<MapDenormalize> MapDenormalizes { get; set; }
        public virtual DbSet<MapJump> MapJumps { get; set; }
        public virtual DbSet<MapLandmark> MapLandmarks { get; set; }
        public virtual DbSet<MapLocationScene> MapLocationScenes { get; set; }
        public virtual DbSet<MapLocationWormholeClass> MapLocationWormholeClasses { get; set; }
        public virtual DbSet<MapRegion> MapRegions { get; set; }
        public virtual DbSet<MapRegionJump> MapRegionJumps { get; set; }
        public virtual DbSet<MapSolarSystem> MapSolarSystems { get; set; }
        public virtual DbSet<MapSolarSystemJump> MapSolarSystemJumps { get; set; }
        public virtual DbSet<MapUniverse> MapUniverses { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<PlanetSchematic> PlanetSchematics { get; set; }
        public virtual DbSet<PlanetSchematicsPinMap> PlanetSchematicsPinMaps { get; set; }
        public virtual DbSet<PlanetSchematicsTypeMap> PlanetSchematicsTypeMaps { get; set; }
        public virtual DbSet<RamActivity> RamActivities { get; set; }
        public virtual DbSet<RamAssemblyLineStation> RamAssemblyLineStations { get; set; }
        public virtual DbSet<RamAssemblyLineType> RamAssemblyLineTypes { get; set; }
        public virtual DbSet<RamAssemblyLineTypeDetailPerCategory> RamAssemblyLineTypeDetailPerCategories { get; set; }
        public virtual DbSet<RamAssemblyLineTypeDetailPerGroup> RamAssemblyLineTypeDetailPerGroups { get; set; }
        public virtual DbSet<RamInstallationTypeContent> RamInstallationTypeContents { get; set; }
        public virtual DbSet<Skin> Skins { get; set; }
        public virtual DbSet<SkinLicense> SkinLicenses { get; set; }
        public virtual DbSet<SkinMaterial> SkinMaterials { get; set; }
        public virtual DbSet<SkinShip> SkinShips { get; set; }
        public virtual DbSet<StaOperation> StaOperations { get; set; }
        public virtual DbSet<StaOperationService> StaOperationServices { get; set; }
        public virtual DbSet<StaService> StaServices { get; set; }
        public virtual DbSet<StaStation> StaStations { get; set; }
        public virtual DbSet<StaStationType> StaStationTypes { get; set; }
        public virtual DbSet<TranslationTable> TranslationTables { get; set; }
        public virtual DbSet<TrnTranslation> TrnTranslations { get; set; }
        public virtual DbSet<TrnTranslationColumn> TrnTranslationColumns { get; set; }
        public virtual DbSet<TrnTranslationLanguage> TrnTranslationLanguages { get; set; }
        public virtual DbSet<WarCombatZone> WarCombatZones { get; set; }
        public virtual DbSet<WarCombatZoneSystem> WarCombatZoneSystems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\EVEINDUSTRY;Database=evesde;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AgtAgent>(entity =>
            {
                entity.HasKey(e => e.AgentId)
                    .HasName("PK__agtAgent__350C7022FF793400");

                entity.ToTable("agtAgents");

                entity.HasIndex(e => e.CorporationId, "ix_agtAgents_corporationID");

                entity.HasIndex(e => e.LocationId, "ix_agtAgents_locationID");

                entity.Property(e => e.AgentId)
                    .ValueGeneratedNever()
                    .HasColumnName("agentID");

                entity.Property(e => e.AgentTypeId).HasColumnName("agentTypeID");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.DivisionId).HasColumnName("divisionID");

                entity.Property(e => e.IsLocator).HasColumnName("isLocator");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.Quality).HasColumnName("quality");
            });

            modelBuilder.Entity<AgtAgentType>(entity =>
            {
                entity.HasKey(e => e.AgentTypeId)
                    .HasName("PK__agtAgent__97E63E0E100E969E");

                entity.ToTable("agtAgentTypes");

                entity.Property(e => e.AgentTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("agentTypeID");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("agentType");
            });

            modelBuilder.Entity<AgtAgentsInSpace>(entity =>
            {
                entity.HasKey(e => e.AgentId)
                    .HasName("PK__agtAgent__350C70228D7381C1");

                entity.ToTable("agtAgentsInSpace");

                entity.HasIndex(e => e.SolarSystemId, "ix_agtAgentsInSpace_solarSystemID");

                entity.Property(e => e.AgentId)
                    .ValueGeneratedNever()
                    .HasColumnName("agentID");

                entity.Property(e => e.DungeonId).HasColumnName("dungeonID");

                entity.Property(e => e.SolarSystemId).HasColumnName("solarSystemID");

                entity.Property(e => e.SpawnPointId).HasColumnName("spawnPointID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<AgtResearchAgent>(entity =>
            {
                entity.HasKey(e => new { e.AgentId, e.TypeId })
                    .HasName("PK__agtResea__8A08AF332A327061");

                entity.ToTable("agtResearchAgents");

                entity.HasIndex(e => e.TypeId, "ix_agtResearchAgents_typeID");

                entity.Property(e => e.AgentId).HasColumnName("agentID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<CertCert>(entity =>
            {
                entity.HasKey(e => e.CertId)
                    .HasName("PK__certCert__D2C9361937E79962");

                entity.ToTable("certCerts");

                entity.Property(e => e.CertId)
                    .ValueGeneratedNever()
                    .HasColumnName("certID");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CertMastery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("certMasteries");

                entity.Property(e => e.CertId).HasColumnName("certID");

                entity.Property(e => e.MasteryLevel).HasColumnName("masteryLevel");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<CertSkill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("certSkills");

                entity.HasIndex(e => e.SkillId, "ix_certSkills_skillID");

                entity.Property(e => e.CertId).HasColumnName("certID");

                entity.Property(e => e.CertLevelInt).HasColumnName("certLevelInt");

                entity.Property(e => e.CertLevelText)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("certLevelText");

                entity.Property(e => e.SkillId).HasColumnName("skillID");

                entity.Property(e => e.SkillLevel).HasColumnName("skillLevel");
            });

            modelBuilder.Entity<ChrAncestry>(entity =>
            {
                entity.HasKey(e => e.AncestryId)
                    .HasName("PK__chrAnces__B33BD939E8B7AB6A");

                entity.ToTable("chrAncestries");

                entity.Property(e => e.AncestryId)
                    .ValueGeneratedNever()
                    .HasColumnName("ancestryID");

                entity.Property(e => e.AncestryName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ancestryName");

                entity.Property(e => e.BloodlineId).HasColumnName("bloodlineID");

                entity.Property(e => e.Charisma).HasColumnName("charisma");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Intelligence).HasColumnName("intelligence");

                entity.Property(e => e.Memory).HasColumnName("memory");

                entity.Property(e => e.Perception).HasColumnName("perception");

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("shortDescription");

                entity.Property(e => e.Willpower).HasColumnName("willpower");
            });

            modelBuilder.Entity<ChrAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId)
                    .HasName("PK__chrAttri__03B803D0B3A01FFD");

                entity.ToTable("chrAttributes");

                entity.Property(e => e.AttributeId)
                    .ValueGeneratedNever()
                    .HasColumnName("attributeID");

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("attributeName");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("shortDescription");
            });

            modelBuilder.Entity<ChrBloodline>(entity =>
            {
                entity.HasKey(e => e.BloodlineId)
                    .HasName("PK__chrBlood__3D71B0E440B8BB4A");

                entity.ToTable("chrBloodlines");

                entity.Property(e => e.BloodlineId)
                    .ValueGeneratedNever()
                    .HasColumnName("bloodlineID");

                entity.Property(e => e.BloodlineName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bloodlineName");

                entity.Property(e => e.Charisma).HasColumnName("charisma");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.FemaleDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("femaleDescription");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Intelligence).HasColumnName("intelligence");

                entity.Property(e => e.MaleDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("maleDescription");

                entity.Property(e => e.Memory).HasColumnName("memory");

                entity.Property(e => e.Perception).HasColumnName("perception");

                entity.Property(e => e.RaceId).HasColumnName("raceID");

                entity.Property(e => e.ShipTypeId).HasColumnName("shipTypeID");

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("shortDescription");

                entity.Property(e => e.ShortFemaleDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("shortFemaleDescription");

                entity.Property(e => e.ShortMaleDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("shortMaleDescription");

                entity.Property(e => e.Willpower).HasColumnName("willpower");
            });

            modelBuilder.Entity<ChrFaction>(entity =>
            {
                entity.HasKey(e => e.FactionId)
                    .HasName("PK__chrFacti__CA771A8E9E17B94B");

                entity.ToTable("chrFactions");

                entity.Property(e => e.FactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("factionID");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.FactionName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("factionName");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.MilitiaCorporationId).HasColumnName("militiaCorporationID");

                entity.Property(e => e.RaceIds).HasColumnName("raceIDs");

                entity.Property(e => e.SizeFactor).HasColumnName("sizeFactor");

                entity.Property(e => e.SolarSystemId).HasColumnName("solarSystemID");

                entity.Property(e => e.StationCount).HasColumnName("stationCount");

                entity.Property(e => e.StationSystemCount).HasColumnName("stationSystemCount");
            });

            modelBuilder.Entity<ChrRace>(entity =>
            {
                entity.HasKey(e => e.RaceId)
                    .HasName("PK__chrRaces__B5C1EE55711B753D");

                entity.ToTable("chrRaces");

                entity.Property(e => e.RaceId)
                    .ValueGeneratedNever()
                    .HasColumnName("raceID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.RaceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("raceName");

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("shortDescription");
            });

            modelBuilder.Entity<CrpActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK__crpActiv__0FC9CBCCA4D60B07");

                entity.ToTable("crpActivities");

                entity.Property(e => e.ActivityId)
                    .ValueGeneratedNever()
                    .HasColumnName("activityID");

                entity.Property(e => e.ActivityName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("activityName");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<CrpNpccorporation>(entity =>
            {
                entity.HasKey(e => e.CorporationId)
                    .HasName("PK__crpNPCCo__D36DBB179DF20B91");

                entity.ToTable("crpNPCCorporations");

                entity.Property(e => e.CorporationId)
                    .ValueGeneratedNever()
                    .HasColumnName("corporationID");

                entity.Property(e => e.Border).HasColumnName("border");

                entity.Property(e => e.Corridor).HasColumnName("corridor");

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.EnemyId).HasColumnName("enemyID");

                entity.Property(e => e.Extent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("extent")
                    .IsFixedLength(true);

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.FriendId).HasColumnName("friendID");

                entity.Property(e => e.Fringe).HasColumnName("fringe");

                entity.Property(e => e.Hub).HasColumnName("hub");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.InitialPrice).HasColumnName("initialPrice");

                entity.Property(e => e.InvestorId1).HasColumnName("investorID1");

                entity.Property(e => e.InvestorId2).HasColumnName("investorID2");

                entity.Property(e => e.InvestorId3).HasColumnName("investorID3");

                entity.Property(e => e.InvestorId4).HasColumnName("investorID4");

                entity.Property(e => e.InvestorShares1).HasColumnName("investorShares1");

                entity.Property(e => e.InvestorShares2).HasColumnName("investorShares2");

                entity.Property(e => e.InvestorShares3).HasColumnName("investorShares3");

                entity.Property(e => e.InvestorShares4).HasColumnName("investorShares4");

                entity.Property(e => e.MinSecurity).HasColumnName("minSecurity");

                entity.Property(e => e.PublicShares).HasColumnName("publicShares");

                entity.Property(e => e.Scattered).HasColumnName("scattered");

                entity.Property(e => e.Size)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("size")
                    .IsFixedLength(true);

                entity.Property(e => e.SizeFactor).HasColumnName("sizeFactor");

                entity.Property(e => e.SolarSystemId).HasColumnName("solarSystemID");

                entity.Property(e => e.StationCount).HasColumnName("stationCount");

                entity.Property(e => e.StationSystemCount).HasColumnName("stationSystemCount");
            });

            modelBuilder.Entity<CrpNpccorporationDivision>(entity =>
            {
                entity.HasKey(e => new { e.CorporationId, e.DivisionId })
                    .HasName("PK__crpNPCCo__3844F17FFE1E4E6B");

                entity.ToTable("crpNPCCorporationDivisions");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.DivisionId).HasColumnName("divisionID");

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<CrpNpccorporationResearchField>(entity =>
            {
                entity.HasKey(e => new { e.SkillId, e.CorporationId })
                    .HasName("PK__crpNPCCo__C35CB06E5616B2F7");

                entity.ToTable("crpNPCCorporationResearchFields");

                entity.Property(e => e.SkillId).HasColumnName("skillID");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");
            });

            modelBuilder.Entity<CrpNpccorporationTrade>(entity =>
            {
                entity.HasKey(e => new { e.CorporationId, e.TypeId })
                    .HasName("PK__crpNPCCo__6C69640608B6B193");

                entity.ToTable("crpNPCCorporationTrades");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<CrpNpcdivision>(entity =>
            {
                entity.HasKey(e => e.DivisionId)
                    .HasName("PK__crpNPCDi__B294A68FB5515E76");

                entity.ToTable("crpNPCDivisions");

                entity.Property(e => e.DivisionId)
                    .ValueGeneratedNever()
                    .HasColumnName("divisionID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.DivisionName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("divisionName");

                entity.Property(e => e.LeaderType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("leaderType");
            });

            modelBuilder.Entity<DgmAttributeCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__dgmAttri__23CAF1F8289E7AEC");

                entity.ToTable("dgmAttributeCategories");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("categoryID");

                entity.Property(e => e.CategoryDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("categoryDescription");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("categoryName");
            });

            modelBuilder.Entity<DgmAttributeType>(entity =>
            {
                entity.HasKey(e => e.AttributeId)
                    .HasName("PK__dgmAttri__03B803D04041C42C");

                entity.ToTable("dgmAttributeTypes");

                entity.Property(e => e.AttributeId)
                    .ValueGeneratedNever()
                    .HasColumnName("attributeID");

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("attributeName");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.DefaultValue).HasColumnName("defaultValue");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("displayName");

                entity.Property(e => e.HighIsGood).HasColumnName("highIsGood");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.Stackable).HasColumnName("stackable");

                entity.Property(e => e.UnitId).HasColumnName("unitID");
            });

            modelBuilder.Entity<DgmEffect>(entity =>
            {
                entity.HasKey(e => e.EffectId)
                    .HasName("PK__dgmEffec__DD40F9334BD3DFE0");

                entity.ToTable("dgmEffects");

                entity.Property(e => e.EffectId)
                    .ValueGeneratedNever()
                    .HasColumnName("effectID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.DisallowAutoRepeat).HasColumnName("disallowAutoRepeat");

                entity.Property(e => e.DischargeAttributeId).HasColumnName("dischargeAttributeID");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("displayName");

                entity.Property(e => e.Distribution).HasColumnName("distribution");

                entity.Property(e => e.DurationAttributeId).HasColumnName("durationAttributeID");

                entity.Property(e => e.EffectCategory).HasColumnName("effectCategory");

                entity.Property(e => e.EffectName)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("effectName");

                entity.Property(e => e.ElectronicChance).HasColumnName("electronicChance");

                entity.Property(e => e.FalloffAttributeId).HasColumnName("falloffAttributeID");

                entity.Property(e => e.FittingUsageChanceAttributeId).HasColumnName("fittingUsageChanceAttributeID");

                entity.Property(e => e.Guid)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("guid");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.IsAssistance).HasColumnName("isAssistance");

                entity.Property(e => e.IsOffensive).HasColumnName("isOffensive");

                entity.Property(e => e.IsWarpSafe).HasColumnName("isWarpSafe");

                entity.Property(e => e.ModifierInfo).HasColumnName("modifierInfo");

                entity.Property(e => e.NpcActivationChanceAttributeId).HasColumnName("npcActivationChanceAttributeID");

                entity.Property(e => e.NpcUsageChanceAttributeId).HasColumnName("npcUsageChanceAttributeID");

                entity.Property(e => e.PostExpression).HasColumnName("postExpression");

                entity.Property(e => e.PreExpression).HasColumnName("preExpression");

                entity.Property(e => e.PropulsionChance).HasColumnName("propulsionChance");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.RangeAttributeId).HasColumnName("rangeAttributeID");

                entity.Property(e => e.RangeChance).HasColumnName("rangeChance");

                entity.Property(e => e.SfxName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sfxName");

                entity.Property(e => e.TrackingSpeedAttributeId).HasColumnName("trackingSpeedAttributeID");
            });

            modelBuilder.Entity<DgmExpression>(entity =>
            {
                entity.HasKey(e => e.ExpressionId)
                    .HasName("PK__dgmExpre__78BD0F06B1CDBD93");

                entity.ToTable("dgmExpressions");

                entity.Property(e => e.ExpressionId)
                    .ValueGeneratedNever()
                    .HasColumnName("expressionID");

                entity.Property(e => e.Arg1).HasColumnName("arg1");

                entity.Property(e => e.Arg2).HasColumnName("arg2");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.ExpressionAttributeId).HasColumnName("expressionAttributeID");

                entity.Property(e => e.ExpressionGroupId).HasColumnName("expressionGroupID");

                entity.Property(e => e.ExpressionName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("expressionName");

                entity.Property(e => e.ExpressionTypeId).HasColumnName("expressionTypeID");

                entity.Property(e => e.ExpressionValue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("expressionValue");

                entity.Property(e => e.OperandId).HasColumnName("operandID");
            });

            modelBuilder.Entity<DgmTypeAttribute>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.AttributeId })
                    .HasName("PK__dgmTypeA__E0767127EF1C3E91");

                entity.ToTable("dgmTypeAttributes");

                entity.HasIndex(e => e.AttributeId, "ix_dgmTypeAttributes_attributeID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.AttributeId).HasColumnName("attributeID");

                entity.Property(e => e.ValueFloat).HasColumnName("valueFloat");

                entity.Property(e => e.ValueInt).HasColumnName("valueInt");
            });

            modelBuilder.Entity<DgmTypeEffect>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.EffectId })
                    .HasName("PK__dgmTypeE__DD99FE897C5400A2");

                entity.ToTable("dgmTypeEffects");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.EffectId).HasColumnName("effectID");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            });

            modelBuilder.Entity<EveGraphic>(entity =>
            {
                entity.HasKey(e => e.GraphicId)
                    .HasName("PK__eveGraph__9126745418FC4ADC");

                entity.ToTable("eveGraphics");

                entity.Property(e => e.GraphicId)
                    .ValueGeneratedNever()
                    .HasColumnName("graphicID");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GraphicFile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("graphicFile");

                entity.Property(e => e.SofFactionName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sofFactionName");

                entity.Property(e => e.SofHullName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sofHullName");

                entity.Property(e => e.SofRaceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sofRaceName");
            });

            modelBuilder.Entity<EveIcon>(entity =>
            {
                entity.HasKey(e => e.IconId)
                    .HasName("PK__eveIcons__5CE396AF8E8FC36A");

                entity.ToTable("eveIcons");

                entity.Property(e => e.IconId)
                    .ValueGeneratedNever()
                    .HasColumnName("iconID");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IconFile)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("iconFile");
            });

            modelBuilder.Entity<EveUnit>(entity =>
            {
                entity.HasKey(e => e.UnitId)
                    .HasName("PK__eveUnits__55D7921564E6A21E");

                entity.ToTable("eveUnits");

                entity.Property(e => e.UnitId)
                    .ValueGeneratedNever()
                    .HasColumnName("unitID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("displayName");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("unitName");
            });

            modelBuilder.Entity<IndustryActivity>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.ActivityId })
                    .HasName("PK__industry__20B16DA6FD9745D4");

                entity.ToTable("industryActivity");

                entity.HasIndex(e => e.ActivityId, "ix_industryActivity_activityID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.ActivityId).HasColumnName("activityID");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<IndustryActivityMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("industryActivityMaterials");

                entity.HasIndex(e => new { e.TypeId, e.ActivityId }, "industryActivityMaterials_idx1");

                entity.HasIndex(e => e.TypeId, "ix_industryActivityMaterials_typeID");

                entity.Property(e => e.ActivityId).HasColumnName("activityID");

                entity.Property(e => e.MaterialTypeId).HasColumnName("materialTypeID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<IndustryActivityProbability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("industryActivityProbabilities");

                entity.HasIndex(e => e.ProductTypeId, "ix_industryActivityProbabilities_productTypeID");

                entity.HasIndex(e => e.TypeId, "ix_industryActivityProbabilities_typeID");

                entity.Property(e => e.ActivityId).HasColumnName("activityID");

                entity.Property(e => e.Probability)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("probability");

                entity.Property(e => e.ProductTypeId).HasColumnName("productTypeID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<IndustryActivityProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("industryActivityProducts");

                entity.HasIndex(e => e.ProductTypeId, "ix_industryActivityProducts_productTypeID");

                entity.HasIndex(e => e.TypeId, "ix_industryActivityProducts_typeID");

                entity.Property(e => e.ActivityId).HasColumnName("activityID");

                entity.Property(e => e.ProductTypeId).HasColumnName("productTypeID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<IndustryActivityRace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("industryActivityRaces");

                entity.HasIndex(e => e.ProductTypeId, "ix_industryActivityRaces_productTypeID");

                entity.HasIndex(e => e.TypeId, "ix_industryActivityRaces_typeID");

                entity.Property(e => e.ActivityId).HasColumnName("activityID");

                entity.Property(e => e.ProductTypeId).HasColumnName("productTypeID");

                entity.Property(e => e.RaceId).HasColumnName("raceID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<IndustryActivitySkill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("industryActivitySkills");

                entity.HasIndex(e => new { e.TypeId, e.ActivityId }, "industryActivitySkills_idx1");

                entity.HasIndex(e => e.SkillId, "ix_industryActivitySkills_skillID");

                entity.HasIndex(e => e.TypeId, "ix_industryActivitySkills_typeID");

                entity.Property(e => e.ActivityId).HasColumnName("activityID");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.SkillId).HasColumnName("skillID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<IndustryBlueprint>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__industry__F04DF11AA905D885");

                entity.ToTable("industryBlueprints");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("typeID");

                entity.Property(e => e.MaxProductionLimit).HasColumnName("maxProductionLimit");
            });

            modelBuilder.Entity<InvCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__invCateg__23CAF1F845F74D41");

                entity.ToTable("invCategories");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("categoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("categoryName");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Published).HasColumnName("published");
            });

            modelBuilder.Entity<InvContrabandType>(entity =>
            {
                entity.HasKey(e => new { e.FactionId, e.TypeId })
                    .HasName("PK__invContr__7573C59F8CF3DF75");

                entity.ToTable("invContrabandTypes");

                entity.HasIndex(e => e.TypeId, "ix_invContrabandTypes_typeID");

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.AttackMinSec).HasColumnName("attackMinSec");

                entity.Property(e => e.ConfiscateMinSec).HasColumnName("confiscateMinSec");

                entity.Property(e => e.FineByValue).HasColumnName("fineByValue");

                entity.Property(e => e.StandingLoss).HasColumnName("standingLoss");
            });

            modelBuilder.Entity<InvControlTowerResource>(entity =>
            {
                entity.HasKey(e => new { e.ControlTowerTypeId, e.ResourceTypeId })
                    .HasName("PK__invContr__16FC4C9F74F7038A");

                entity.ToTable("invControlTowerResources");

                entity.Property(e => e.ControlTowerTypeId).HasColumnName("controlTowerTypeID");

                entity.Property(e => e.ResourceTypeId).HasColumnName("resourceTypeID");

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.MinSecurityLevel).HasColumnName("minSecurityLevel");

                entity.Property(e => e.Purpose).HasColumnName("purpose");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<InvControlTowerResourcePurpose>(entity =>
            {
                entity.HasKey(e => e.Purpose)
                    .HasName("PK__invContr__BBAA0C7271E23B7C");

                entity.ToTable("invControlTowerResourcePurposes");

                entity.Property(e => e.Purpose)
                    .ValueGeneratedNever()
                    .HasColumnName("purpose");

                entity.Property(e => e.PurposeText)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("purposeText");
            });

            modelBuilder.Entity<InvFlag>(entity =>
            {
                entity.HasKey(e => e.FlagId)
                    .HasName("PK__invFlags__12F396E01D27B895");

                entity.ToTable("invFlags");

                entity.Property(e => e.FlagId)
                    .ValueGeneratedNever()
                    .HasColumnName("flagID");

                entity.Property(e => e.FlagName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("flagName");

                entity.Property(e => e.FlagText)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("flagText");

                entity.Property(e => e.OrderId).HasColumnName("orderID");
            });

            modelBuilder.Entity<InvGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK__invGroup__88C102ADC8F1A869");

                entity.ToTable("invGroups");

                entity.HasIndex(e => e.CategoryId, "ix_invGroups_categoryID");

                entity.Property(e => e.GroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("groupID");

                entity.Property(e => e.Anchorable).HasColumnName("anchorable");

                entity.Property(e => e.Anchored).HasColumnName("anchored");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.FittableNonSingleton).HasColumnName("fittableNonSingleton");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("groupName");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.UseBasePrice).HasColumnName("useBasePrice");
            });

            modelBuilder.Entity<InvItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__invItems__56A1284AF78A873F");

                entity.ToTable("invItems");

                entity.HasIndex(e => new { e.OwnerId, e.LocationId }, "items_IX_OwnerLocation");

                entity.HasIndex(e => e.LocationId, "ix_invItems_locationID");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("itemID");

                entity.Property(e => e.FlagId).HasColumnName("flagID");

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<InvMarketGroup>(entity =>
            {
                entity.HasKey(e => e.MarketGroupId)
                    .HasName("PK__invMarke__1CC51B36E22D1DAA");

                entity.ToTable("invMarketGroups");

                entity.Property(e => e.MarketGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("marketGroupID");

                entity.Property(e => e.Description)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.HasTypes).HasColumnName("hasTypes");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.MarketGroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("marketGroupName");

                entity.Property(e => e.ParentGroupId).HasColumnName("parentGroupID");
            });

            modelBuilder.Entity<InvMetaGroup>(entity =>
            {
                entity.HasKey(e => e.MetaGroupId)
                    .HasName("PK__invMetaG__C66506F46A90806D");

                entity.ToTable("invMetaGroups");

                entity.Property(e => e.MetaGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("metaGroupID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.MetaGroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("metaGroupName");
            });

            modelBuilder.Entity<InvMetaType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__invMetaT__F04DF11A621BC62B");

                entity.ToTable("invMetaTypes");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("typeID");

                entity.Property(e => e.MetaGroupId).HasColumnName("metaGroupID");

                entity.Property(e => e.ParentTypeId).HasColumnName("parentTypeID");
            });

            modelBuilder.Entity<InvName>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__invNames__56A1284AD9F38D7C");

                entity.ToTable("invNames");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("itemID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("itemName");
            });

            modelBuilder.Entity<InvPosition>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__invPosit__56A1284A33912CAF");

                entity.ToTable("invPositions");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("itemID");

                entity.Property(e => e.Pitch).HasColumnName("pitch");

                entity.Property(e => e.Roll).HasColumnName("roll");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Yaw).HasColumnName("yaw");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<InvTrait>(entity =>
            {
                entity.HasKey(e => e.TraitId)
                    .HasName("PK__invTrait__9F5AF018EE5DE9D2");

                entity.ToTable("invTraits");

                entity.Property(e => e.TraitId).HasColumnName("traitID");

                entity.Property(e => e.Bonus).HasColumnName("bonus");

                entity.Property(e => e.BonusText).HasColumnName("bonusText");

                entity.Property(e => e.SkillId).HasColumnName("skillID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.UnitId).HasColumnName("unitID");
            });

            modelBuilder.Entity<InvType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__invTypes__F04DF11AF3A6EB3D");

                entity.ToTable("invTypes");

                entity.HasIndex(e => e.GroupId, "ix_invTypes_groupID");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("typeID");

                entity.Property(e => e.BasePrice)
                    .HasColumnType("decimal(19, 4)")
                    .HasColumnName("basePrice");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GraphicId).HasColumnName("graphicID");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.MarketGroupId).HasColumnName("marketGroupID");

                entity.Property(e => e.Mass).HasColumnName("mass");

                entity.Property(e => e.PortionSize).HasColumnName("portionSize");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.RaceId).HasColumnName("raceID");

                entity.Property(e => e.SoundId).HasColumnName("soundID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("typeName");

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<InvTypeMaterial>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.MaterialTypeId })
                    .HasName("PK__invTypeM__E739C02F584E2F15");

                entity.ToTable("invTypeMaterials");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.MaterialTypeId).HasColumnName("materialTypeID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<InvTypeReaction>(entity =>
            {
                entity.HasKey(e => new { e.ReactionTypeId, e.Input, e.TypeId })
                    .HasName("PK__invTypeR__828774307B6C499B");

                entity.ToTable("invTypeReactions");

                entity.Property(e => e.ReactionTypeId).HasColumnName("reactionTypeID");

                entity.Property(e => e.Input).HasColumnName("input");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<InvUniqueName>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__invUniqu__56A1284AE8A0EA16");

                entity.ToTable("invUniqueNames");

                entity.HasIndex(e => new { e.GroupId, e.ItemName }, "invUniqueNames_IX_GroupName");

                entity.HasIndex(e => e.ItemName, "ix_invUniqueNames_itemName")
                    .IsUnique();

                entity.Property(e => e.ItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("itemID");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("itemName");
            });

            modelBuilder.Entity<InvVolume>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__invVolum__F04DF11AAF39F5F6");

                entity.ToTable("invVolumes");

                entity.Property(e => e.TypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("typeID");

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<MapCelestialGraphic>(entity =>
            {
                entity.HasKey(e => e.CelestialId)
                    .HasName("PK__mapCeles__18B1D4CE0A21EAAA");

                entity.ToTable("mapCelestialGraphics");

                entity.Property(e => e.CelestialId)
                    .ValueGeneratedNever()
                    .HasColumnName("celestialID");

                entity.Property(e => e.HeightMap1).HasColumnName("heightMap1");

                entity.Property(e => e.HeightMap2).HasColumnName("heightMap2");

                entity.Property(e => e.Population).HasColumnName("population");

                entity.Property(e => e.ShaderPreset).HasColumnName("shaderPreset");
            });

            modelBuilder.Entity<MapCelestialStatistic>(entity =>
            {
                entity.HasKey(e => e.CelestialId)
                    .HasName("PK__mapCeles__18B1D4CEBFEF21A9");

                entity.ToTable("mapCelestialStatistics");

                entity.Property(e => e.CelestialId)
                    .ValueGeneratedNever()
                    .HasColumnName("celestialID");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Density).HasColumnName("density");

                entity.Property(e => e.Eccentricity).HasColumnName("eccentricity");

                entity.Property(e => e.EscapeVelocity).HasColumnName("escapeVelocity");

                entity.Property(e => e.Fragmented).HasColumnName("fragmented");

                entity.Property(e => e.Life).HasColumnName("life");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.Luminosity).HasColumnName("luminosity");

                entity.Property(e => e.Mass).HasColumnName("mass");

                entity.Property(e => e.MassDust).HasColumnName("massDust");

                entity.Property(e => e.MassGas).HasColumnName("massGas");

                entity.Property(e => e.OrbitPeriod).HasColumnName("orbitPeriod");

                entity.Property(e => e.OrbitRadius).HasColumnName("orbitRadius");

                entity.Property(e => e.Pressure).HasColumnName("pressure");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RotationRate).HasColumnName("rotationRate");

                entity.Property(e => e.SpectralClass)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("spectralClass");

                entity.Property(e => e.SurfaceGravity).HasColumnName("surfaceGravity");

                entity.Property(e => e.Temperature).HasColumnName("temperature");
            });

            modelBuilder.Entity<MapConstellation>(entity =>
            {
                entity.HasKey(e => e.ConstellationId)
                    .HasName("PK__mapConst__024F85798C2E7121");

                entity.ToTable("mapConstellations");

                entity.Property(e => e.ConstellationId)
                    .ValueGeneratedNever()
                    .HasColumnName("constellationID");

                entity.Property(e => e.ConstellationName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("constellationName");

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionId).HasColumnName("regionID");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<MapConstellationJump>(entity =>
            {
                entity.HasKey(e => new { e.FromConstellationId, e.ToConstellationId })
                    .HasName("PK__mapConst__1D13C5562FED2A79");

                entity.ToTable("mapConstellationJumps");

                entity.Property(e => e.FromConstellationId).HasColumnName("fromConstellationID");

                entity.Property(e => e.ToConstellationId).HasColumnName("toConstellationID");

                entity.Property(e => e.FromRegionId).HasColumnName("fromRegionID");

                entity.Property(e => e.ToRegionId).HasColumnName("toRegionID");
            });

            modelBuilder.Entity<MapDenormalize>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__mapDenor__56A1284A654AA49D");

                entity.ToTable("mapDenormalize");

                entity.HasIndex(e => e.ConstellationId, "ix_mapDenormalize_constellationID");

                entity.HasIndex(e => e.OrbitId, "ix_mapDenormalize_orbitID");

                entity.HasIndex(e => e.RegionId, "ix_mapDenormalize_regionID");

                entity.HasIndex(e => e.SolarSystemId, "ix_mapDenormalize_solarSystemID");

                entity.HasIndex(e => e.TypeId, "ix_mapDenormalize_typeID");

                entity.HasIndex(e => new { e.GroupId, e.ConstellationId }, "mapDenormalize_IX_groupConstellation");

                entity.HasIndex(e => new { e.GroupId, e.RegionId }, "mapDenormalize_IX_groupRegion");

                entity.HasIndex(e => new { e.GroupId, e.SolarSystemId }, "mapDenormalize_IX_groupSystem");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("itemID");

                entity.Property(e => e.CelestialIndex).HasColumnName("celestialIndex");

                entity.Property(e => e.ConstellationId).HasColumnName("constellationID");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("itemName");

                entity.Property(e => e.OrbitId).HasColumnName("orbitID");

                entity.Property(e => e.OrbitIndex).HasColumnName("orbitIndex");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionId).HasColumnName("regionID");

                entity.Property(e => e.Security).HasColumnName("security");

                entity.Property(e => e.SolarSystemId).HasColumnName("solarSystemID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<MapJump>(entity =>
            {
                entity.HasKey(e => e.StargateId)
                    .HasName("PK__mapJumps__F0F5445B13E9230C");

                entity.ToTable("mapJumps");

                entity.Property(e => e.StargateId)
                    .ValueGeneratedNever()
                    .HasColumnName("stargateID");

                entity.Property(e => e.DestinationId).HasColumnName("destinationID");
            });

            modelBuilder.Entity<MapLandmark>(entity =>
            {
                entity.HasKey(e => e.LandmarkId)
                    .HasName("PK__mapLandm__DC9AA17B8422E354");

                entity.ToTable("mapLandmarks");

                entity.Property(e => e.LandmarkId)
                    .ValueGeneratedNever()
                    .HasColumnName("landmarkID");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IconId).HasColumnName("iconID");

                entity.Property(e => e.LandmarkName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("landmarkName");

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<MapLocationScene>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__mapLocat__30646B0EAF86079D");

                entity.ToTable("mapLocationScenes");

                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("locationID");

                entity.Property(e => e.GraphicId).HasColumnName("graphicID");
            });

            modelBuilder.Entity<MapLocationWormholeClass>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__mapLocat__30646B0E3E816AED");

                entity.ToTable("mapLocationWormholeClasses");

                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("locationID");

                entity.Property(e => e.WormholeClassId).HasColumnName("wormholeClassID");
            });

            modelBuilder.Entity<MapRegion>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PK__mapRegio__15EA90889228C08F");

                entity.ToTable("mapRegions");

                entity.Property(e => e.RegionId)
                    .ValueGeneratedNever()
                    .HasColumnName("regionID");

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.Nebula).HasColumnName("nebula");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("regionName");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<MapRegionJump>(entity =>
            {
                entity.HasKey(e => new { e.FromRegionId, e.ToRegionId })
                    .HasName("PK__mapRegio__D11CB669A282909C");

                entity.ToTable("mapRegionJumps");

                entity.Property(e => e.FromRegionId).HasColumnName("fromRegionID");

                entity.Property(e => e.ToRegionId).HasColumnName("toRegionID");
            });

            modelBuilder.Entity<MapSolarSystem>(entity =>
            {
                entity.HasKey(e => e.SolarSystemId)
                    .HasName("PK__mapSolar__8DD88C936CC0A49A");

                entity.ToTable("mapSolarSystems");

                entity.HasIndex(e => e.ConstellationId, "ix_mapSolarSystems_constellationID");

                entity.HasIndex(e => e.RegionId, "ix_mapSolarSystems_regionID");

                entity.HasIndex(e => e.Security, "ix_mapSolarSystems_security");

                entity.Property(e => e.SolarSystemId)
                    .ValueGeneratedNever()
                    .HasColumnName("solarSystemID");

                entity.Property(e => e.Border).HasColumnName("border");

                entity.Property(e => e.Constellation).HasColumnName("constellation");

                entity.Property(e => e.ConstellationId).HasColumnName("constellationID");

                entity.Property(e => e.Corridor).HasColumnName("corridor");

                entity.Property(e => e.FactionId).HasColumnName("factionID");

                entity.Property(e => e.Fringe).HasColumnName("fringe");

                entity.Property(e => e.Hub).HasColumnName("hub");

                entity.Property(e => e.International).HasColumnName("international");

                entity.Property(e => e.Luminosity).HasColumnName("luminosity");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.RegionId).HasColumnName("regionID");

                entity.Property(e => e.Regional).HasColumnName("regional");

                entity.Property(e => e.Security).HasColumnName("security");

                entity.Property(e => e.SecurityClass)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("securityClass");

                entity.Property(e => e.SolarSystemName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("solarSystemName");

                entity.Property(e => e.SunTypeId).HasColumnName("sunTypeID");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<MapSolarSystemJump>(entity =>
            {
                entity.HasKey(e => new { e.FromSolarSystemId, e.ToSolarSystemId })
                    .HasName("PK__mapSolar__A576C10046B95BD9");

                entity.ToTable("mapSolarSystemJumps");

                entity.Property(e => e.FromSolarSystemId).HasColumnName("fromSolarSystemID");

                entity.Property(e => e.ToSolarSystemId).HasColumnName("toSolarSystemID");

                entity.Property(e => e.FromConstellationId).HasColumnName("fromConstellationID");

                entity.Property(e => e.FromRegionId).HasColumnName("fromRegionID");

                entity.Property(e => e.ToConstellationId).HasColumnName("toConstellationID");

                entity.Property(e => e.ToRegionId).HasColumnName("toRegionID");
            });

            modelBuilder.Entity<MapUniverse>(entity =>
            {
                entity.HasKey(e => e.UniverseId)
                    .HasName("PK__mapUnive__4569484B85E077EA");

                entity.ToTable("mapUniverse");

                entity.Property(e => e.UniverseId)
                    .ValueGeneratedNever()
                    .HasColumnName("universeID");

                entity.Property(e => e.Radius).HasColumnName("radius");

                entity.Property(e => e.UniverseName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("universeName");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.XMax).HasColumnName("xMax");

                entity.Property(e => e.XMin).HasColumnName("xMin");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.YMax).HasColumnName("yMax");

                entity.Property(e => e.YMin).HasColumnName("yMin");

                entity.Property(e => e.Z).HasColumnName("z");

                entity.Property(e => e.ZMax).HasColumnName("zMax");

                entity.Property(e => e.ZMin).HasColumnName("zMin");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("persons");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Salesrep)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("salesrep");
            });

            modelBuilder.Entity<PlanetSchematic>(entity =>
            {
                entity.HasKey(e => e.SchematicId)
                    .HasName("PK__planetSc__A84EA0460E997521");

                entity.ToTable("planetSchematics");

                entity.Property(e => e.SchematicId)
                    .ValueGeneratedNever()
                    .HasColumnName("schematicID");

                entity.Property(e => e.CycleTime).HasColumnName("cycleTime");

                entity.Property(e => e.SchematicName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("schematicName");
            });

            modelBuilder.Entity<PlanetSchematicsPinMap>(entity =>
            {
                entity.HasKey(e => new { e.SchematicId, e.PinTypeId })
                    .HasName("PK__planetSc__2F2D0BD85C8FA4C6");

                entity.ToTable("planetSchematicsPinMap");

                entity.Property(e => e.SchematicId).HasColumnName("schematicID");

                entity.Property(e => e.PinTypeId).HasColumnName("pinTypeID");
            });

            modelBuilder.Entity<PlanetSchematicsTypeMap>(entity =>
            {
                entity.HasKey(e => new { e.SchematicId, e.TypeId })
                    .HasName("PK__planetSc__174A7F57F3DF7B5F");

                entity.ToTable("planetSchematicsTypeMap");

                entity.Property(e => e.SchematicId).HasColumnName("schematicID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");

                entity.Property(e => e.IsInput).HasColumnName("isInput");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<RamActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK__ramActiv__0FC9CBCC2C93E7CD");

                entity.ToTable("ramActivities");

                entity.Property(e => e.ActivityId)
                    .ValueGeneratedNever()
                    .HasColumnName("activityID");

                entity.Property(e => e.ActivityName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("activityName");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.IconNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("iconNo");

                entity.Property(e => e.Published).HasColumnName("published");
            });

            modelBuilder.Entity<RamAssemblyLineStation>(entity =>
            {
                entity.HasKey(e => new { e.StationId, e.AssemblyLineTypeId })
                    .HasName("PK__ramAssem__7FEE942609D148C5");

                entity.ToTable("ramAssemblyLineStations");

                entity.HasIndex(e => e.OwnerId, "ix_ramAssemblyLineStations_ownerID");

                entity.HasIndex(e => e.RegionId, "ix_ramAssemblyLineStations_regionID");

                entity.HasIndex(e => e.SolarSystemId, "ix_ramAssemblyLineStations_solarSystemID");

                entity.Property(e => e.StationId).HasColumnName("stationID");

                entity.Property(e => e.AssemblyLineTypeId).HasColumnName("assemblyLineTypeID");

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RegionId).HasColumnName("regionID");

                entity.Property(e => e.SolarSystemId).HasColumnName("solarSystemID");

                entity.Property(e => e.StationTypeId).HasColumnName("stationTypeID");
            });

            modelBuilder.Entity<RamAssemblyLineType>(entity =>
            {
                entity.HasKey(e => e.AssemblyLineTypeId)
                    .HasName("PK__ramAssem__F4967C69A7FFD046");

                entity.ToTable("ramAssemblyLineTypes");

                entity.Property(e => e.AssemblyLineTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("assemblyLineTypeID");

                entity.Property(e => e.ActivityId).HasColumnName("activityID");

                entity.Property(e => e.AssemblyLineTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("assemblyLineTypeName");

                entity.Property(e => e.BaseCostMultiplier).HasColumnName("baseCostMultiplier");

                entity.Property(e => e.BaseMaterialMultiplier).HasColumnName("baseMaterialMultiplier");

                entity.Property(e => e.BaseTimeMultiplier).HasColumnName("baseTimeMultiplier");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.MinCostPerHour).HasColumnName("minCostPerHour");

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<RamAssemblyLineTypeDetailPerCategory>(entity =>
            {
                entity.HasKey(e => new { e.AssemblyLineTypeId, e.CategoryId })
                    .HasName("PK__ramAssem__66AAD376B6B566BB");

                entity.ToTable("ramAssemblyLineTypeDetailPerCategory");

                entity.Property(e => e.AssemblyLineTypeId).HasColumnName("assemblyLineTypeID");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.CostMultiplier).HasColumnName("costMultiplier");

                entity.Property(e => e.MaterialMultiplier).HasColumnName("materialMultiplier");

                entity.Property(e => e.TimeMultiplier).HasColumnName("timeMultiplier");
            });

            modelBuilder.Entity<RamAssemblyLineTypeDetailPerGroup>(entity =>
            {
                entity.HasKey(e => new { e.AssemblyLineTypeId, e.GroupId })
                    .HasName("PK__ramAssem__3C1A6C431B7F6189");

                entity.ToTable("ramAssemblyLineTypeDetailPerGroup");

                entity.Property(e => e.AssemblyLineTypeId).HasColumnName("assemblyLineTypeID");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.CostMultiplier).HasColumnName("costMultiplier");

                entity.Property(e => e.MaterialMultiplier).HasColumnName("materialMultiplier");

                entity.Property(e => e.TimeMultiplier).HasColumnName("timeMultiplier");
            });

            modelBuilder.Entity<RamInstallationTypeContent>(entity =>
            {
                entity.HasKey(e => new { e.InstallationTypeId, e.AssemblyLineTypeId })
                    .HasName("PK__ramInsta__EA61FA1C88EE2407");

                entity.ToTable("ramInstallationTypeContents");

                entity.Property(e => e.InstallationTypeId).HasColumnName("installationTypeID");

                entity.Property(e => e.AssemblyLineTypeId).HasColumnName("assemblyLineTypeID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Skin>(entity =>
            {
                entity.ToTable("skins");

                entity.Property(e => e.SkinId)
                    .ValueGeneratedNever()
                    .HasColumnName("skinID");

                entity.Property(e => e.InternalName)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("internalName");

                entity.Property(e => e.SkinMaterialId).HasColumnName("skinMaterialID");
            });

            modelBuilder.Entity<SkinLicense>(entity =>
            {
                entity.HasKey(e => e.LicenseTypeId)
                    .HasName("PK__skinLice__98D8B2A85D269B2A");

                entity.ToTable("skinLicense");

                entity.Property(e => e.LicenseTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("licenseTypeID");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.SkinId).HasColumnName("skinID");
            });

            modelBuilder.Entity<SkinMaterial>(entity =>
            {
                entity.ToTable("skinMaterials");

                entity.Property(e => e.SkinMaterialId)
                    .ValueGeneratedNever()
                    .HasColumnName("skinMaterialID");

                entity.Property(e => e.DisplayNameId).HasColumnName("displayNameID");

                entity.Property(e => e.MaterialSetId).HasColumnName("materialSetID");
            });

            modelBuilder.Entity<SkinShip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("skinShip");

                entity.HasIndex(e => e.SkinId, "ix_skinShip_skinID");

                entity.HasIndex(e => e.TypeId, "ix_skinShip_typeID");

                entity.Property(e => e.SkinId).HasColumnName("skinID");

                entity.Property(e => e.TypeId).HasColumnName("typeID");
            });

            modelBuilder.Entity<StaOperation>(entity =>
            {
                entity.HasKey(e => e.OperationId)
                    .HasName("PK__staOpera__34C2D1B913E80031");

                entity.ToTable("staOperations");

                entity.Property(e => e.OperationId)
                    .ValueGeneratedNever()
                    .HasColumnName("operationID");

                entity.Property(e => e.ActivityId).HasColumnName("activityID");

                entity.Property(e => e.AmarrStationTypeId).HasColumnName("amarrStationTypeID");

                entity.Property(e => e.Border).HasColumnName("border");

                entity.Property(e => e.CaldariStationTypeId).HasColumnName("caldariStationTypeID");

                entity.Property(e => e.Corridor).HasColumnName("corridor");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Fringe).HasColumnName("fringe");

                entity.Property(e => e.GallenteStationTypeId).HasColumnName("gallenteStationTypeID");

                entity.Property(e => e.Hub).HasColumnName("hub");

                entity.Property(e => e.JoveStationTypeId).HasColumnName("joveStationTypeID");

                entity.Property(e => e.MinmatarStationTypeId).HasColumnName("minmatarStationTypeID");

                entity.Property(e => e.OperationName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("operationName");

                entity.Property(e => e.Ratio).HasColumnName("ratio");
            });

            modelBuilder.Entity<StaOperationService>(entity =>
            {
                entity.HasKey(e => new { e.OperationId, e.ServiceId })
                    .HasName("PK__staOpera__D097D68A0140854F");

                entity.ToTable("staOperationServices");

                entity.Property(e => e.OperationId).HasColumnName("operationID");

                entity.Property(e => e.ServiceId).HasColumnName("serviceID");
            });

            modelBuilder.Entity<StaService>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK__staServi__4550733FC7274A92");

                entity.ToTable("staServices");

                entity.Property(e => e.ServiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("serviceID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("serviceName");
            });

            modelBuilder.Entity<StaStation>(entity =>
            {
                entity.HasKey(e => e.StationId)
                    .HasName("PK__staStati__F0A7F3E0932CFBDD");

                entity.ToTable("staStations");

                entity.HasIndex(e => e.ConstellationId, "ix_staStations_constellationID");

                entity.HasIndex(e => e.CorporationId, "ix_staStations_corporationID");

                entity.HasIndex(e => e.OperationId, "ix_staStations_operationID");

                entity.HasIndex(e => e.RegionId, "ix_staStations_regionID");

                entity.HasIndex(e => e.SolarSystemId, "ix_staStations_solarSystemID");

                entity.HasIndex(e => e.StationTypeId, "ix_staStations_stationTypeID");

                entity.Property(e => e.StationId)
                    .ValueGeneratedNever()
                    .HasColumnName("stationID");

                entity.Property(e => e.ConstellationId).HasColumnName("constellationID");

                entity.Property(e => e.CorporationId).HasColumnName("corporationID");

                entity.Property(e => e.DockingCostPerVolume).HasColumnName("dockingCostPerVolume");

                entity.Property(e => e.MaxShipVolumeDockable).HasColumnName("maxShipVolumeDockable");

                entity.Property(e => e.OfficeRentalCost).HasColumnName("officeRentalCost");

                entity.Property(e => e.OperationId).HasColumnName("operationID");

                entity.Property(e => e.RegionId).HasColumnName("regionID");

                entity.Property(e => e.ReprocessingEfficiency).HasColumnName("reprocessingEfficiency");

                entity.Property(e => e.ReprocessingHangarFlag).HasColumnName("reprocessingHangarFlag");

                entity.Property(e => e.ReprocessingStationsTake).HasColumnName("reprocessingStationsTake");

                entity.Property(e => e.Security).HasColumnName("security");

                entity.Property(e => e.SolarSystemId).HasColumnName("solarSystemID");

                entity.Property(e => e.StationName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("stationName");

                entity.Property(e => e.StationTypeId).HasColumnName("stationTypeID");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<StaStationType>(entity =>
            {
                entity.HasKey(e => e.StationTypeId)
                    .HasName("PK__staStati__0C27685C1DC3BD8E");

                entity.ToTable("staStationTypes");

                entity.Property(e => e.StationTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("stationTypeID");

                entity.Property(e => e.Conquerable).HasColumnName("conquerable");

                entity.Property(e => e.DockEntryX).HasColumnName("dockEntryX");

                entity.Property(e => e.DockEntryY).HasColumnName("dockEntryY");

                entity.Property(e => e.DockEntryZ).HasColumnName("dockEntryZ");

                entity.Property(e => e.DockOrientationX).HasColumnName("dockOrientationX");

                entity.Property(e => e.DockOrientationY).HasColumnName("dockOrientationY");

                entity.Property(e => e.DockOrientationZ).HasColumnName("dockOrientationZ");

                entity.Property(e => e.OfficeSlots).HasColumnName("officeSlots");

                entity.Property(e => e.OperationId).HasColumnName("operationID");

                entity.Property(e => e.ReprocessingEfficiency).HasColumnName("reprocessingEfficiency");
            });

            modelBuilder.Entity<TranslationTable>(entity =>
            {
                entity.HasKey(e => new { e.SourceTable, e.TranslatedKey })
                    .HasName("PK__translat__F46A12ABB36B00E8");

                entity.ToTable("translationTables");

                entity.Property(e => e.SourceTable)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("sourceTable");

                entity.Property(e => e.TranslatedKey)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("translatedKey");

                entity.Property(e => e.DestinationTable)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("destinationTable");

                entity.Property(e => e.TcGroupId).HasColumnName("tcGroupID");

                entity.Property(e => e.TcId).HasColumnName("tcID");
            });

            modelBuilder.Entity<TrnTranslation>(entity =>
            {
                entity.HasKey(e => new { e.TcId, e.KeyId, e.LanguageId })
                    .HasName("PK__trnTrans__35675F15284EC2F7");

                entity.ToTable("trnTranslations");

                entity.Property(e => e.TcId).HasColumnName("tcID");

                entity.Property(e => e.KeyId).HasColumnName("keyID");

                entity.Property(e => e.LanguageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("languageID");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<TrnTranslationColumn>(entity =>
            {
                entity.HasKey(e => e.TcId)
                    .HasName("PK__trnTrans__E072AA6268A0FC85");

                entity.ToTable("trnTranslationColumns");

                entity.Property(e => e.TcId)
                    .ValueGeneratedNever()
                    .HasColumnName("tcID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("columnName");

                entity.Property(e => e.MasterId)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("masterID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("tableName");

                entity.Property(e => e.TcGroupId).HasColumnName("tcGroupID");
            });

            modelBuilder.Entity<TrnTranslationLanguage>(entity =>
            {
                entity.HasKey(e => e.NumericLanguageId)
                    .HasName("PK__trnTrans__38AFAE05524CA7E5");

                entity.ToTable("trnTranslationLanguages");

                entity.Property(e => e.NumericLanguageId)
                    .ValueGeneratedNever()
                    .HasColumnName("numericLanguageID");

                entity.Property(e => e.LanguageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("languageID");

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("languageName");
            });

            modelBuilder.Entity<WarCombatZone>(entity =>
            {
                entity.HasKey(e => e.CombatZoneId)
                    .HasName("PK__warComba__F2212FCEA824DB5E");

                entity.ToTable("warCombatZones");

                entity.Property(e => e.CombatZoneId)
                    .ValueGeneratedNever()
                    .HasColumnName("combatZoneID");

                entity.Property(e => e.CenterSystemId).HasColumnName("centerSystemID");

                entity.Property(e => e.CombatZoneName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("combatZoneName");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.FactionId).HasColumnName("factionID");
            });

            modelBuilder.Entity<WarCombatZoneSystem>(entity =>
            {
                entity.HasKey(e => e.SolarSystemId)
                    .HasName("PK__warComba__8DD88C930072C813");

                entity.ToTable("warCombatZoneSystems");

                entity.Property(e => e.SolarSystemId)
                    .ValueGeneratedNever()
                    .HasColumnName("solarSystemID");

                entity.Property(e => e.CombatZoneId).HasColumnName("combatZoneID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
