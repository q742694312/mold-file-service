using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Models;

namespace Models.DBContexts
{
    public partial class BigDataContext : DbContext
    {
        public BigDataContext()
        {
        }

        public BigDataContext(DbContextOptions<BigDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdRegion> AdRegions { get; set; } = null!;
        public virtual DbSet<Adescribe> Adescribes { get; set; } = null!;
        public virtual DbSet<Affusion> Affusions { get; set; } = null!;
        public virtual DbSet<Analysisdatum> Analysisdata { get; set; } = null!;
        public virtual DbSet<ApiUploadFile> ApiUploadFiles { get; set; } = null!;
        public virtual DbSet<ApkInfo> ApkInfos { get; set; } = null!;
        public virtual DbSet<Baimo> Baimos { get; set; } = null!;
        public virtual DbSet<Base> Bases { get; set; } = null!;
        public virtual DbSet<BaseFileRecord> BaseFileRecords { get; set; } = null!;
        public virtual DbSet<BimGispoint> BimGispoints { get; set; } = null!;
        public virtual DbSet<Bimproject> Bimprojects { get; set; } = null!;
        public virtual DbSet<BlockAtt> BlockAtts { get; set; } = null!;
        public virtual DbSet<BlockShp> BlockShps { get; set; } = null!;
        public virtual DbSet<BlockTypeNum> BlockTypeNums { get; set; } = null!;
        public virtual DbSet<CDrainPipe> CDrainPipes { get; set; } = null!;
        public virtual DbSet<CDrainPump> CDrainPumps { get; set; } = null!;
        public virtual DbSet<ChainHole> ChainHoles { get; set; } = null!;
        public virtual DbSet<Combine> Combines { get; set; } = null!;
        public virtual DbSet<Consolid> Consolids { get; set; } = null!;
        public virtual DbSet<CustomRegion> CustomRegions { get; set; } = null!;
        public virtual DbSet<DmtDatum> DmtData { get; set; } = null!;
        public virtual DbSet<Dpt> Dpts { get; set; } = null!;
        public virtual DbSet<Dyntable> Dyntables { get; set; } = null!;
        public virtual DbSet<Figure> Figures { get; set; } = null!;
        public virtual DbSet<GeologDarkRiver> GeologDarkRivers { get; set; } = null!;
        public virtual DbSet<GeologicAge> GeologicAges { get; set; } = null!;
        public virtual DbSet<GeologicalZone> GeologicalZones { get; set; } = null!;
        public virtual DbSet<GeologyPartition> GeologyPartitions { get; set; } = null!;
        public virtual DbSet<Geomorphy> Geomorphies { get; set; } = null!;
        public virtual DbSet<Grain> Grains { get; set; } = null!;
        public virtual DbSet<HWeather> HWeathers { get; set; } = null!;
        public virtual DbSet<Hdescribe> Hdescribes { get; set; } = null!;
        public virtual DbSet<Holedate> Holedates { get; set; } = null!;
        public virtual DbSet<Holetype> Holetypes { get; set; } = null!;
        public virtual DbSet<HydrogeologicalZone> HydrogeologicalZones { get; set; } = null!;
        public virtual DbSet<Itemcode> Itemcodes { get; set; } = null!;
        public virtual DbSet<JobTable> JobTables { get; set; } = null!;
        public virtual DbSet<LayerAttr> LayerAttrs { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<MFile> MFiles { get; set; } = null!;
        public virtual DbSet<MIntervalTypeEnum> MIntervalTypeEnums { get; set; } = null!;
        public virtual DbSet<MLineInfo> MLineInfos { get; set; } = null!;
        public virtual DbSet<MMetroGeometryInfo> MMetroGeometryInfos { get; set; } = null!;
        public virtual DbSet<MMetroInterval> MMetroIntervals { get; set; } = null!;
        public virtual DbSet<MMetroSection> MMetroSections { get; set; } = null!;
        public virtual DbSet<MRingSoil> MRingSoils { get; set; } = null!;
        public virtual DbSet<Main> Mains { get; set; } = null!;
        public virtual DbSet<MetroGeoLayer> MetroGeoLayers { get; set; } = null!;
        public virtual DbSet<OldBuilding> OldBuildings { get; set; } = null!;
        public virtual DbSet<OldBuildingFileRecord> OldBuildingFileRecords { get; set; } = null!;
        public virtual DbSet<PBuildingInfo> PBuildingInfos { get; set; } = null!;
        public virtual DbSet<PPileConnectType> PPileConnectTypes { get; set; } = null!;
        public virtual DbSet<PPileInfo> PPileInfos { get; set; } = null!;
        public virtual DbSet<PPileTest> PPileTests { get; set; } = null!;
        public virtual DbSet<PaleoRiver> PaleoRivers { get; set; } = null!;
        public virtual DbSet<Pholeatt> Pholeatts { get; set; } = null!;
        public virtual DbSet<PileFile> PileFiles { get; set; } = null!;
        public virtual DbSet<PileInfo> PileInfos { get; set; } = null!;
        public virtual DbSet<PileProject> PileProjects { get; set; } = null!;
        public virtual DbSet<Pitzone> Pitzones { get; set; } = null!;
        public virtual DbSet<Pmbg> Pmbgs { get; set; } = null!;
        public virtual DbSet<Pmhole> Pmholes { get; set; } = null!;
        public virtual DbSet<Pmlayer> Pmlayers { get; set; } = null!;
        public virtual DbSet<Pmtadjust> Pmtadjusts { get; set; } = null!;
        public virtual DbSet<Pouatt> Pouatts { get; set; } = null!;
        public virtual DbSet<PreValue> PreValues { get; set; } = null!;
        public virtual DbSet<ProjectModel> ProjectModels { get; set; } = null!;
        public virtual DbSet<ProjectTypNum> ProjectTypNums { get; set; } = null!;
        public virtual DbSet<Quanji> Quanjis { get; set; } = null!;
        public virtual DbSet<RegionModel> RegionModels { get; set; } = null!;
        public virtual DbSet<River> Rivers { get; set; } = null!;
        public virtual DbSet<Riverinterval> Riverintervals { get; set; } = null!;
        public virtual DbSet<Riverlocation> Riverlocations { get; set; } = null!;
        public virtual DbSet<Riversection> Riversections { get; set; } = null!;
        public virtual DbSet<Road> Roads { get; set; } = null!;
        public virtual DbSet<Rule> Rules { get; set; } = null!;
        public virtual DbSet<Rulecale> Rulecales { get; set; } = null!;
        public virtual DbSet<Sidedown> Sidedowns { get; set; } = null!;
        public virtual DbSet<Soilhole> Soilholes { get; set; } = null!;
        public virtual DbSet<Sudb> Sudbs { get; set; } = null!;
        public virtual DbSet<SysDepartment> SysDepartments { get; set; } = null!;
        public virtual DbSet<SysModule> SysModules { get; set; } = null!;
        public virtual DbSet<SysRole> SysRoles { get; set; } = null!;
        public virtual DbSet<SysRoleGroup> SysRoleGroups { get; set; } = null!;
        public virtual DbSet<SysUser> SysUsers { get; set; } = null!;
        public virtual DbSet<TApplicationDatum> TApplicationData { get; set; } = null!;
        public virtual DbSet<TConstructionStage> TConstructionStages { get; set; } = null!;
        public virtual DbSet<TMonitorDataType> TMonitorDataTypes { get; set; } = null!;
        public virtual DbSet<TMonitorPoint> TMonitorPoints { get; set; } = null!;
        public virtual DbSet<TMonitorPointSetting> TMonitorPointSettings { get; set; } = null!;
        public virtual DbSet<TMonitorProject> TMonitorProjects { get; set; } = null!;
        public virtual DbSet<TMonitorProjectSetting> TMonitorProjectSettings { get; set; } = null!;
        public virtual DbSet<TMonitorValue> TMonitorValues { get; set; } = null!;
        public virtual DbSet<TProject> TProjects { get; set; } = null!;
        public virtual DbSet<TProjectAlarmPoint> TProjectAlarmPoints { get; set; } = null!;
        public virtual DbSet<TProjectFile> TProjectFiles { get; set; } = null!;
        public virtual DbSet<TProjectImage> TProjectImages { get; set; } = null!;
        public virtual DbSet<TProjectLevelEnum> TProjectLevelEnums { get; set; } = null!;
        public virtual DbSet<TProjectProgress> TProjectProgresses { get; set; } = null!;
        public virtual DbSet<TProjectStatusEnum> TProjectStatusEnums { get; set; } = null!;
        public virtual DbSet<TProjectmap> TProjectmaps { get; set; } = null!;
        public virtual DbSet<ThreeDmodel> ThreeDmodels { get; set; } = null!;
        public virtual DbSet<ThreeProject> ThreeProjects { get; set; } = null!;
        public virtual DbSet<Titemdatum> Titemdata { get; set; } = null!;
        public virtual DbSet<Tpf> Tpfs { get; set; } = null!;
        public virtual DbSet<Trial> Trials { get; set; } = null!;
        public virtual DbSet<VProjectInfo> VProjectInfos { get; set; } = null!;
        public virtual DbSet<VProjectPoint> VProjectPoints { get; set; } = null!;
        public virtual DbSet<VProjectStatus> VProjectStatuses { get; set; } = null!;
        public virtual DbSet<VProjectValue> VProjectValues { get; set; } = null!;
        public virtual DbSet<VProjectValueByTianAn> VProjectValueByTianAns { get; set; } = null!;
        public virtual DbSet<VProjectValueByYunTu> VProjectValueByYunTus { get; set; } = null!;
        public virtual DbSet<VipProject> VipProjects { get; set; } = null!;
        public virtual DbSet<WaterDepth> WaterDepths { get; set; } = null!;
        public virtual DbSet<Wave> Waves { get; set; } = null!;
        public virtual DbSet<YMonitorPoint> YMonitorPoints { get; set; } = null!;
        public virtual DbSet<YMonitorPointsDictionary> YMonitorPointsDictionaries { get; set; } = null!;
        public virtual DbSet<YMonitorProjectExtraInfo> YMonitorProjectExtraInfos { get; set; } = null!;
        public virtual DbSet<YPrjGeoLayer> YPrjGeoLayers { get; set; } = null!;
        public virtual DbSet<YPrjMonitorType> YPrjMonitorTypes { get; set; } = null!;
        public virtual DbSet<YPrjStatus> YPrjStatuses { get; set; } = null!;
        public virtual DbSet<YPrjStatusImage> YPrjStatusImages { get; set; } = null!;
        public virtual DbSet<YProject> YProjects { get; set; } = null!;
        public virtual DbSet<YProjectDocument> YProjectDocuments { get; set; } = null!;
        public virtual DbSet<YProjectTypeEnum> YProjectTypeEnums { get; set; } = null!;
        public virtual DbSet<Zp93> Zp93s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.2.40;Initial Catalog=BigData;Persist Security Info=True;TrustServerCertificate=yes;User ID=sa;PWD=Sgidi123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdRegion>(entity =>
            {
                entity.ToTable("AdRegion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("region");

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.Wgs84X).HasColumnName("wgs84X");

                entity.Property(e => e.Wgs84Y).HasColumnName("wgs84Y");
            });

            modelBuilder.Entity<Adescribe>(entity =>
            {
                entity.HasKey(e => e.Anumber)
                    .HasName("PK_C_adescribe");

                entity.ToTable("adescribe");

                entity.Property(e => e.Anumber)
                    .ValueGeneratedNever()
                    .HasColumnName("anumber");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Compress)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("compress");

                entity.Property(e => e.Density)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("density");

                entity.Property(e => e.Humidity)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("humidity");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Sdescribe)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("sdescribe");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Affusion>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("affusion");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.Anumber).HasColumnName("anumber");

                entity.Property(e => e.BTime)
                    .HasColumnType("datetime")
                    .HasColumnName("bTime");

                entity.Property(e => e.BUse).HasColumnName("bUse");

                entity.Property(e => e.Bush).HasColumnName("bush");

                entity.Property(e => e.Caput).HasColumnName("caput");

                entity.Property(e => e.Data)
                    .HasColumnType("image")
                    .HasColumnName("data");

                entity.Property(e => e.Dcount).HasColumnName("dcount");

                entity.Property(e => e.ETime)
                    .HasColumnType("datetime")
                    .HasColumnName("eTime");

                entity.Property(e => e.Edep).HasColumnName("edep");

                entity.Property(e => e.Fate)
                    .HasColumnType("datetime")
                    .HasColumnName("fate");

                entity.Property(e => e.Hnumber).HasColumnName("hnumber");

                entity.Property(e => e.M).HasColumnName("m");

                entity.Property(e => e.ProjectCount).HasColumnName("Project_count");

                entity.Property(e => e.Sdep).HasColumnName("sdep");

                entity.Property(e => e.TNo).HasColumnName("tNO");

                entity.Property(e => e.Water).HasColumnName("water");
            });

            modelBuilder.Entity<Analysisdatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Foundationrelativeposition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Geozone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("geozone");

                entity.Property(e => e.Holerelativeposition)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Initialconvergence).HasColumnName("initialconvergence");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.MaxdigDepthvsDepth).HasColumnName("maxdigDepthvsDepth");

                entity.Property(e => e.Pointname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pointname");

                entity.Property(e => e.Prjid).HasColumnName("prjid");

                entity.Property(e => e.Tunneldepth).HasColumnName("tunneldepth");
            });

            modelBuilder.Entity<ApiUploadFile>(entity =>
            {
                entity.ToTable("Api_UploadFiles");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DelShow).HasColumnName("del_show");

                entity.Property(e => e.Filename)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("filename");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LoginID");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProType).HasMaxLength(225);
            });

            modelBuilder.Entity<ApkInfo>(entity =>
            {
                entity.ToTable("ApkInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddTime)
                    .HasColumnType("datetime")
                    .HasColumnName("addTime");

                entity.Property(e => e.Content)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("_content");

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("path");

                entity.Property(e => e.RecordId)
                    .HasMaxLength(10)
                    .HasColumnName("recordID")
                    .IsFixedLength();

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .HasColumnName("version")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Baimo>(entity =>
            {
                entity.ToTable("baimo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Belong)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("belong");

                entity.Property(e => e.Floor).HasColumnName("floor");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Base>(entity =>
            {
                entity.HasKey(e => e.ProjectCount);

                entity.ToTable("base");

                entity.Property(e => e.ProjectCount)
                    .ValueGeneratedNever()
                    .HasColumnName("project_count");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.Client)
                    .IsUnicode(false)
                    .HasColumnName("client");

                entity.Property(e => e.Desinger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("desinger");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ProjectAddress)
                    .IsUnicode(false)
                    .HasColumnName("project_address");

                entity.Property(e => e.ProjectApproved)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("project_approved");

                entity.Property(e => e.ProjectManger)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("project_manger");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("project_name");

                entity.Property(e => e.ProjectNameing)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("project_nameing");

                entity.Property(e => e.ProjectSubNb).HasColumnName("project_subNb");

                entity.Property(e => e.ProjectSubname)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("project_subname");

                entity.Property(e => e.ProjectType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectVerifid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("project_verifid");

                entity.Property(e => e.Prospector)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("prospector");

                entity.Property(e => e.Stage)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("stage");

                entity.Property(e => e.TuApproved)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tu_approved");

                entity.Property(e => e.TuManger)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tu_manger");

                entity.Property(e => e.TuVerifid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tu_verifid");

                entity.Property(e => e.Wgs84x).HasColumnName("WGS84X");

                entity.Property(e => e.Wgs84y).HasColumnName("WGS84Y");

                entity.Property(e => e.WzX).HasColumnName("wz_x");

                entity.Property(e => e.WzY).HasColumnName("wz_y");
            });

            modelBuilder.Entity<BaseFileRecord>(entity =>
            {
                entity.ToTable("BaseFileRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BimGispoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BIM_GISpoint");

                entity.Property(e => e.Camera)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("camera");

                entity.Property(e => e.Pitname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("pitname");

                entity.Property(e => e.Projectid)
                    .IsUnicode(false)
                    .HasColumnName("projectid");

                entity.Property(e => e.Wgs84X).HasColumnName("wgs84X");

                entity.Property(e => e.Wgs84Y).HasColumnName("wgs84Y");
            });

            modelBuilder.Entity<Bimproject>(entity =>
            {
                entity.ToTable("BIMProject");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("enddate");

                entity.Property(e => e.Id1)
                    .IsUnicode(false)
                    .HasColumnName("_id");

                entity.Property(e => e.Manager)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("manager");

                entity.Property(e => e.Modelid)
                    .IsUnicode(false)
                    .HasColumnName("modelid");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Prjlevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prjlevel");

                entity.Property(e => e.Prjtype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prjtype");

                entity.Property(e => e.Projurl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("projurl");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("startdate");

                entity.Property(e => e.Summarizes)
                    .HasColumnType("text")
                    .HasColumnName("summarizes");
            });

            modelBuilder.Entity<BlockAtt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BlockAtt");

                entity.Property(e => e.BlockAtt1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BlockAtt");

                entity.Property(e => e.BlockBelong)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BlockId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BlockID");

                entity.Property(e => e.BlockType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingInfo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PlanTarget)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnderGround).HasColumnName("underGround");
            });

            modelBuilder.Entity<BlockShp>(entity =>
            {
                entity.ToTable("BlockShp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Belong)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("belong");

                entity.Property(e => e.Hknum).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BlockTypeNum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BlockTypeNum");

                entity.Property(e => e.BlockRgb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BlockRGB");

                entity.Property(e => e.BlockType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BLockType");

                entity.Property(e => e.BlockTypeName)
                    .IsUnicode(false)
                    .HasColumnName("BLockTypeName");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Notes).IsUnicode(false);
            });

            modelBuilder.Entity<CDrainPipe>(entity =>
            {
                entity.ToTable("C_DrainPipe");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BJbh)
                    .HasMaxLength(255)
                    .HasColumnName("B_JBH");

                entity.Property(e => e.BManhole)
                    .HasMaxLength(255)
                    .HasColumnName("B_MANHOLE_");

                entity.Property(e => e.BManhole1)
                    .HasMaxLength(255)
                    .HasColumnName("B_MANHOLE1");

                entity.Property(e => e.Bbxx)
                    .HasMaxLength(255)
                    .HasColumnName("BBXX");

                entity.Property(e => e.Bianhao).HasColumnName("BIANHAO");

                entity.Property(e => e.Biaoduan)
                    .HasMaxLength(255)
                    .HasColumnName("BIAODUAN");

                entity.Property(e => e.Builddate)
                    .HasColumnType("date")
                    .HasColumnName("BUILDDATE");

                entity.Property(e => e.Buildstate).HasColumnName("BUILDSTATE");

                entity.Property(e => e.Buildyear).HasColumnName("BUILDYEAR");

                entity.Property(e => e.Buriesmeth).HasColumnName("BURIESMETH");

                entity.Property(e => e.Bx)
                    .HasMaxLength(255)
                    .HasColumnName("BX");

                entity.Property(e => e.By)
                    .HasMaxLength(255)
                    .HasColumnName("BY_");

                entity.Property(e => e.Changdu).HasColumnName("CHANGDU");

                entity.Property(e => e.District).HasColumnName("DISTRICT");

                entity.Property(e => e.DraiDep1).HasColumnName("DRAI_DEP_1");

                entity.Property(e => e.DraiDepth).HasColumnName("DRAI_DEPTH");

                entity.Property(e => e.DraiPi10).HasColumnName("DRAI_PI_10");

                entity.Property(e => e.DraiPi11).HasColumnName("DRAI_PI_11");

                entity.Property(e => e.DraiPi12).HasColumnName("DRAI_PI_12");

                entity.Property(e => e.DraiPi13).HasColumnName("DRAI_PI_13");

                entity.Property(e => e.DraiPi14).HasColumnName("DRAI_PI_14");

                entity.Property(e => e.DraiPi15).HasColumnName("DRAI_PI_15");

                entity.Property(e => e.DraiPi16)
                    .HasMaxLength(255)
                    .HasColumnName("DRAI_PI_16");

                entity.Property(e => e.DraiPi17)
                    .HasMaxLength(255)
                    .HasColumnName("DRAI_PI_17");

                entity.Property(e => e.DraiPi18)
                    .HasMaxLength(255)
                    .HasColumnName("DRAI_PI_18");

                entity.Property(e => e.DraiPi19)
                    .HasMaxLength(255)
                    .HasColumnName("DRAI_PI_19");

                entity.Property(e => e.DraiPi20)
                    .HasMaxLength(255)
                    .HasColumnName("DRAI_PI_20");

                entity.Property(e => e.DraiPi21)
                    .HasMaxLength(255)
                    .HasColumnName("DRAI_PI_21");

                entity.Property(e => e.DraiPip1).HasColumnName("DRAI_PIP_1");

                entity.Property(e => e.DraiPip2).HasColumnName("DRAI_PIP_2");

                entity.Property(e => e.DraiPip3)
                    .HasMaxLength(255)
                    .HasColumnName("DRAI_PIP_3");

                entity.Property(e => e.DraiPip4)
                    .HasMaxLength(255)
                    .HasColumnName("DRAI_PIP_4");

                entity.Property(e => e.DraiPip5).HasColumnName("DRAI_PIP_5");

                entity.Property(e => e.DraiPip6).HasColumnName("DRAI_PIP_6");

                entity.Property(e => e.DraiPip7).HasColumnName("DRAI_PIP_7");

                entity.Property(e => e.DraiPip8).HasColumnName("DRAI_PIP_8");

                entity.Property(e => e.DraiPip9).HasColumnName("DRAI_PIP_9");

                entity.Property(e => e.DraiPipe)
                    .HasMaxLength(255)
                    .HasColumnName("DRAI_PIPE_");

                entity.Property(e => e.DraiPipe1)
                    .HasMaxLength(255)
                    .HasColumnName("DRAI_PIPE1");

                entity.Property(e => e.EJbh)
                    .HasMaxLength(255)
                    .HasColumnName("E_JBH");

                entity.Property(e => e.EManhole)
                    .HasMaxLength(255)
                    .HasColumnName("E_MANHOLE_");

                entity.Property(e => e.EManhole1)
                    .HasMaxLength(255)
                    .HasColumnName("E_MANHOLE1");

                entity.Property(e => e.Eexx)
                    .HasMaxLength(255)
                    .HasColumnName("EEXX");

                entity.Property(e => e.Enabled).HasColumnName("ENABLED");

                entity.Property(e => e.Ex)
                    .HasMaxLength(255)
                    .HasColumnName("EX");

                entity.Property(e => e.Ey)
                    .HasMaxLength(255)
                    .HasColumnName("EY");

                entity.Property(e => e.Finishdate)
                    .HasColumnType("date")
                    .HasColumnName("FINISHDATE");

                entity.Property(e => e.GId)
                    .HasMaxLength(255)
                    .HasColumnName("G_ID");

                entity.Property(e => e.Gcfl)
                    .HasMaxLength(255)
                    .HasColumnName("GCFL");

                entity.Property(e => e.Gongnengga).HasColumnName("GONGNENGGA");

                entity.Property(e => e.Guandaocux).HasColumnName("GUANDAOCUX");

                entity.Property(e => e.Guandaoqin)
                    .HasMaxLength(255)
                    .HasColumnName("GUANDAOQIN");

                entity.Property(e => e.InCom)
                    .HasMaxLength(255)
                    .HasColumnName("IN_COM");

                entity.Property(e => e.InDate)
                    .HasColumnType("date")
                    .HasColumnName("IN_DATE");

                entity.Property(e => e.InUse)
                    .HasMaxLength(255)
                    .HasColumnName("IN_USE");

                entity.Property(e => e.Isuse).HasColumnName("ISUSE");

                entity.Property(e => e.Jianshedan)
                    .HasMaxLength(255)
                    .HasColumnName("JIANSHEDAN");

                entity.Property(e => e.Jiekouxing).HasColumnName("JIEKOUXING");

                entity.Property(e => e.Keyid).HasColumnName("KEYID");

                entity.Property(e => e.Liuzhiliux)
                    .HasMaxLength(255)
                    .HasColumnName("LIUZHILIUX");

                entity.Property(e => e.Main).HasColumnName("MAIN");

                entity.Property(e => e.Manageunit)
                    .HasMaxLength(255)
                    .HasColumnName("MANAGEUNIT");

                entity.Property(e => e.Mapsheetid)
                    .HasMaxLength(255)
                    .HasColumnName("MAPSHEETID");

                entity.Property(e => e.NetShape)
                    .HasMaxLength(255)
                    .HasColumnName("NET_SHAPE");

                entity.Property(e => e.NetType)
                    .HasMaxLength(255)
                    .HasColumnName("NET_TYPE");

                entity.Property(e => e.Obid)
                    .HasMaxLength(255)
                    .HasColumnName("OBID");

                entity.Property(e => e.Oeid)
                    .HasMaxLength(255)
                    .HasColumnName("OEID");

                entity.Property(e => e.Podu).HasColumnName("PODU");

                entity.Property(e => e.Presstype).HasColumnName("PRESSTYPE");

                entity.Property(e => e.Psgsgl)
                    .HasMaxLength(255)
                    .HasColumnName("PSGSGL");

                entity.Property(e => e.Rebuilddat)
                    .HasColumnType("date")
                    .HasColumnName("REBUILDDAT");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Ringroad).HasColumnName("RINGROAD");

                entity.Property(e => e.Rundate)
                    .HasColumnType("date")
                    .HasColumnName("RUNDATE");

                entity.Property(e => e.ShapeLen).HasColumnName("SHAPE_LEN");

                entity.Property(e => e.Shifoshuan)
                    .HasMaxLength(255)
                    .HasColumnName("SHIFOSHUAN");

                entity.Property(e => e.Shifouchon)
                    .HasMaxLength(255)
                    .HasColumnName("SHIFOUCHON");

                entity.Property(e => e.Shifouquxi)
                    .HasMaxLength(255)
                    .HasColumnName("SHIFOUQUXI");

                entity.Property(e => e.Shifouxian)
                    .HasMaxLength(255)
                    .HasColumnName("SHIFOUXIAN");

                entity.Property(e => e.Shifouyiji)
                    .HasMaxLength(255)
                    .HasColumnName("SHIFOUYIJI");

                entity.Property(e => e.Shujuxingz)
                    .HasMaxLength(255)
                    .HasColumnName("SHUJUXINGZ");

                entity.Property(e => e.Sjly)
                    .HasMaxLength(255)
                    .HasColumnName("SJLY");

                entity.Property(e => e.Str)
                    .HasMaxLength(255)
                    .HasColumnName("STR");

                entity.Property(e => e.Sx).HasColumnName("SX");

                entity.Property(e => e.SysId)
                    .HasMaxLength(255)
                    .HasColumnName("SYS_ID");

                entity.Property(e => e.Theirsyste).HasColumnName("THEIRSYSTE");

                entity.Property(e => e.Townowned).HasColumnName("TOWNOWNED");

                entity.Property(e => e.Versionid).HasColumnName("VERSIONID");

                entity.Property(e => e.Xiulifangf).HasColumnName("XIULIFANGF");

                entity.Property(e => e.Xtbm)
                    .HasMaxLength(255)
                    .HasColumnName("XTBM");

                entity.Property(e => e.Yhbm)
                    .HasMaxLength(255)
                    .HasColumnName("YHBM");
            });

            modelBuilder.Entity<CDrainPump>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("C_DrainPump");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CBuildyear).HasColumnName("C_BUILDYEAR");

                entity.Property(e => e.CDistrict)
                    .HasMaxLength(50)
                    .HasColumnName("C_District");

                entity.Property(e => e.CDraiPumpAdd)
                    .HasMaxLength(50)
                    .HasColumnName("C_DRAI_PUMP_ADD");

                entity.Property(e => e.CDraiPumpComBuild)
                    .HasMaxLength(50)
                    .HasColumnName("C_DRAI_PUMP_COM_BUILD");

                entity.Property(e => e.CDraiPumpComDsn)
                    .HasMaxLength(50)
                    .HasColumnName("C_DRAI_PUMP_COM_DSN");

                entity.Property(e => e.CDraiPumpId)
                    .HasMaxLength(50)
                    .HasColumnName("C_DRAI_PUMP_ID");

                entity.Property(e => e.CDraiPumpName)
                    .HasMaxLength(50)
                    .HasColumnName("C_DRAI_PUMP_NAME");

                entity.Property(e => e.CDraiPumpPhone)
                    .HasMaxLength(50)
                    .HasColumnName("C_DRAI_PUMP_PHONE");

                entity.Property(e => e.CDraiPumpPostCode)
                    .HasMaxLength(50)
                    .HasColumnName("C_DRAI_PUMP_POST_CODE");

                entity.Property(e => e.CDraiPumpType).HasColumnName("C_DRAI_PUMP_TYPE");

                entity.Property(e => e.CDraiPumpTypeFeat).HasColumnName("C_DRAI_PUMP_TYPE_FEAT");

                entity.Property(e => e.CFinishDate)
                    .HasColumnType("datetime")
                    .HasColumnName("C_FinishDate");

                entity.Property(e => e.CInCom)
                    .HasMaxLength(50)
                    .HasColumnName("C_In_Com");

                entity.Property(e => e.CInDate)
                    .HasColumnType("datetime")
                    .HasColumnName("C_In_Date");

                entity.Property(e => e.CInUser)
                    .HasMaxLength(50)
                    .HasColumnName("C_In_User");

                entity.Property(e => e.CKeyid).HasColumnName("C_KEYID");

                entity.Property(e => e.CNDraiPumpState).HasColumnName("C_N_DRAI_PUMP_STATE");

                entity.Property(e => e.CReBuildDate)
                    .HasColumnType("datetime")
                    .HasColumnName("C_ReBuildDate");

                entity.Property(e => e.CRemark)
                    .HasMaxLength(50)
                    .HasColumnName("C_Remark");

                entity.Property(e => e.CRingRoad).HasColumnName("C_RingRoad");

                entity.Property(e => e.CRunDate)
                    .HasColumnType("datetime")
                    .HasColumnName("C_RunDate");

                entity.Property(e => e.CSysId)
                    .HasMaxLength(50)
                    .HasColumnName("C_SYS_ID");

                entity.Property(e => e.CSysName)
                    .HasMaxLength(50)
                    .HasColumnName("C_SYS_NAME");

                entity.Property(e => e.CTownowned)
                    .HasMaxLength(50)
                    .HasColumnName("C_Townowned");

                entity.Property(e => e.CUserId)
                    .HasMaxLength(50)
                    .HasColumnName("C_UserId");

                entity.Property(e => e.CVersionId)
                    .HasMaxLength(50)
                    .HasColumnName("C_VersionId");

                entity.Property(e => e.CXtbm)
                    .HasMaxLength(50)
                    .HasColumnName("C_XTBM");
            });

            modelBuilder.Entity<ChainHole>(entity =>
            {
                entity.ToTable("ChainHole");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attribute).HasColumnName("attribute");

                entity.Property(e => e.Hnumber).HasColumnName("hnumber");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Combine>(entity =>
            {
                entity.HasKey(e => e.Mnumber);

                entity.ToTable("combine");

                entity.Property(e => e.Mnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("mnumber");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("m_name");

                entity.Property(e => e.PCnt).HasColumnName("p_cnt");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");
            });

            modelBuilder.Entity<Consolid>(entity =>
            {
                entity.HasKey(e => e.Tnumber);

                entity.ToTable("consolids");

                entity.Property(e => e.Tnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("tnumber");

                entity.Property(e => e.Consolid1)
                    .HasColumnType("image")
                    .HasColumnName("consolid");

                entity.Property(e => e.Isuse).HasColumnName("ISUse");

                entity.Property(e => e.MaxP).HasColumnName("max_P");

                entity.Property(e => e.Method).HasColumnName("method");

                entity.Property(e => e.ModifyD).HasColumnName("modify_D");

                entity.Property(e => e.ModifyEi).HasColumnName("modify_ei");

                entity.Property(e => e.ModifyG).HasColumnName("modify_G");

                entity.Property(e => e.ModifyPi).HasColumnName("modify_pi");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Series).HasColumnName("series");
            });

            modelBuilder.Entity<CustomRegion>(entity =>
            {
                entity.ToTable("CustomRegion");

                entity.Property(e => e.CustomRegionId).HasColumnName("CustomRegionID");

                entity.Property(e => e.Bimmodelid)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BIMmodelid");

                entity.Property(e => e.Cim).HasColumnName("CIM");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.LatestTime)
                    .HasColumnType("date")
                    .HasColumnName("latestTime");

                entity.Property(e => e.LatestUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("latestUser");

                entity.Property(e => e.ParentId).HasColumnName("parentID");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<DmtDatum>(entity =>
            {
                entity.HasKey(e => e.Hnumber);

                entity.ToTable("DMT_data");

                entity.Property(e => e.Hnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("hnumber");

                entity.Property(e => e.BData)
                    .HasColumnType("image")
                    .HasColumnName("b_data");

                entity.Property(e => e.Da).HasColumnName("da");

                entity.Property(e => e.DataCount).HasColumnName("data_count");

                entity.Property(e => e.Db).HasColumnName("db");

                entity.Property(e => e.EquipNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("equipNo");

                entity.Property(e => e.ProjectCount).HasColumnName("Project_count");

                entity.Property(e => e.StartDep).HasColumnName("start_dep");

                entity.Property(e => e.Zm).HasColumnName("zm");
            });

            modelBuilder.Entity<Dpt>(entity =>
            {
                entity.HasKey(e => e.Hnumber);

                entity.ToTable("DPT");

                entity.Property(e => e.Hnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("hnumber");

                entity.Property(e => e.AgeNo).HasColumnName("age_No");

                entity.Property(e => e.Data)
                    .HasColumnType("image")
                    .HasColumnName("data");

                entity.Property(e => e.ProjectCount).HasColumnName("Project_count");

                entity.Property(e => e.TestSort).HasColumnName("test_sort");
            });

            modelBuilder.Entity<Dyntable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dyntable");

                entity.Property(e => e.Fdata)
                    .HasColumnType("image")
                    .HasColumnName("fdata");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("fname");

                entity.Property(e => e.Ftablecode)
                    .HasMaxLength(50)
                    .HasColumnName("ftablecode");

                entity.Property(e => e.Tid).HasColumnName("tid");
            });

            modelBuilder.Entity<Figure>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("figures");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.FigCount).HasColumnName("fig_count");

                entity.Property(e => e.FigsmlpNum).HasColumnName("figsmlp_num");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");
            });

            modelBuilder.Entity<GeologDarkRiver>(entity =>
            {
                entity.ToTable("GeologDarkRiver");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<GeologicAge>(entity =>
            {
                entity.HasKey(e => e.Anumber);

                entity.ToTable("geologic_age");

                entity.Property(e => e.Anumber)
                    .ValueGeneratedNever()
                    .HasColumnName("anumber");

                entity.Property(e => e.AgeNo).HasColumnName("age_No");

                entity.Property(e => e.Cause)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cause");

                entity.Property(e => e.CauseEn)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("cause_en");

                entity.Property(e => e.GeologicAge1)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("geologic_age");

                entity.Property(e => e.GeologicEra)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("geologic_era");

                entity.Property(e => e.GeologicEraEn)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("geologic_era_en");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");
            });

            modelBuilder.Entity<GeologicalZone>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("PK_dbo.GeologicalZone");

                entity.ToTable("GeologicalZone");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Belong)
                    .HasMaxLength(100)
                    .HasColumnName("belong");

                entity.Property(e => e.Fenqu).HasMaxLength(255);

                entity.Property(e => e.Geometry).HasColumnName("geometry");

                entity.Property(e => e.Rgb)
                    .HasMaxLength(100)
                    .HasColumnName("rgb");

                entity.Property(e => e.Zuhe).HasMaxLength(255);
            });

            modelBuilder.Entity<GeologyPartition>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("PK_dbo.GeologyPartition");

                entity.ToTable("GeologyPartition");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Belong)
                    .HasMaxLength(100)
                    .HasColumnName("belong");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Thickness).HasMaxLength(255);
            });

            modelBuilder.Entity<Geomorphy>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("PK_dbo.Geomorphy");

                entity.ToTable("Geomorphy");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.Region).HasMaxLength(255);

                entity.Property(e => e.RegionName).HasMaxLength(255);
            });

            modelBuilder.Entity<Grain>(entity =>
            {
                entity.HasKey(e => e.Tnumber);

                entity.ToTable("grain");

                entity.Property(e => e.Tnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("tnumber");

                entity.Property(e => e.D10).HasColumnName("d10");

                entity.Property(e => e.D30).HasColumnName("d30");

                entity.Property(e => e.D50).HasColumnName("d50");

                entity.Property(e => e.D60).HasColumnName("d60");

                entity.Property(e => e.D70).HasColumnName("d70");

                entity.Property(e => e.D85).HasColumnName("d85");

                entity.Property(e => e.DiaPercent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dia_percent");

                entity.Property(e => e.K0002).HasColumnName("k_0002");

                entity.Property(e => e.K0005).HasColumnName("k_0005");

                entity.Property(e => e.K0010005).HasColumnName("k001_0005");

                entity.Property(e => e.K005001).HasColumnName("k005_001");

                entity.Property(e => e.K0074005).HasColumnName("k0074_005");

                entity.Property(e => e.K0250074).HasColumnName("k025_0074");

                entity.Property(e => e.K05025).HasColumnName("k05_025");

                entity.Property(e => e.K10).HasColumnName("k_10");

                entity.Property(e => e.K2).HasColumnName("k_2");

                entity.Property(e => e.K20).HasColumnName("k_20");

                entity.Property(e => e.K205).HasColumnName("k2_05");

                entity.Property(e => e.K40).HasColumnName("k_40");

                entity.Property(e => e.K5).HasColumnName("k_5");

                entity.Property(e => e.K60).HasColumnName("k_60");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");
            });

            modelBuilder.Entity<HWeather>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("H_Weather");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Weather).HasMaxLength(50);

                entity.Property(e => e.Wind).HasMaxLength(50);

                entity.Property(e => e.WindLevel).HasMaxLength(50);
            });

            modelBuilder.Entity<Hdescribe>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("hdescribe");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.Anumber).HasColumnName("anumber");

                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Compress)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("compress");

                entity.Property(e => e.ConsultHole)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("consult_hole");

                entity.Property(e => e.Density)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("density");

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.Hnumber).HasColumnName("hnumber");

                entity.Property(e => e.Humidity)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("humidity");

                entity.Property(e => e.Layername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("layername");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Sdescribe)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("sdescribe");

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Holedate>(entity =>
            {
                entity.HasKey(e => e.Hnumber);

                entity.ToTable("holedate");

                entity.Property(e => e.Hnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("hnumber");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.Edate)
                    .HasColumnType("datetime")
                    .HasColumnName("edate");

                entity.Property(e => e.PageN).HasColumnName("page_n");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Sdate)
                    .HasColumnType("datetime")
                    .HasColumnName("sdate");
            });

            modelBuilder.Entity<Holetype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("holetype");

                entity.Property(e => e.Attribute).HasColumnName("attribute");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<HydrogeologicalZone>(entity =>
            {
                entity.ToTable("HydrogeologicalZone");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Belong)
                    .HasMaxLength(100)
                    .HasColumnName("belong");

                entity.Property(e => e.Color)
                    .HasMaxLength(255)
                    .HasColumnName("color");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");

                entity.Property(e => e.ShapeArea).HasColumnName("Shape_Area");

                entity.Property(e => e.ShapeLeng).HasColumnName("Shape_Leng");
            });

            modelBuilder.Entity<Itemcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("itemcode");

                entity.Property(e => e.Ch)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CH");

                entity.Property(e => e.En)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EN");

                entity.Property(e => e.Extitle)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("extitle");

                entity.Property(e => e.ISort).HasColumnName("i_sort");

                entity.Property(e => e.Itemcode1)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("itemcode");

                entity.Property(e => e.Itemnum).HasColumnName("itemnum");

                entity.Property(e => e.Itemtype).HasColumnName("itemtype");

                entity.Property(e => e.Tid).HasColumnName("tid");
            });

            modelBuilder.Entity<JobTable>(entity =>
            {
                entity.ToTable("job_tables");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CName)
                    .HasMaxLength(20)
                    .HasColumnName("cName");

                entity.Property(e => e.TableName)
                    .HasMaxLength(20)
                    .HasColumnName("tableName");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.TransFg).HasColumnName("transFG");
            });

            modelBuilder.Entity<LayerAttr>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("LayerAttr");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Data)
                    .HasColumnType("image")
                    .HasColumnName("data");

                entity.Property(e => e.FChar)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("f_char");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.Useradd).HasColumnName("useradd");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Log");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MFile>(entity =>
            {
                entity.ToTable("M_File");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CloudUrl)
                    .IsUnicode(false)
                    .HasColumnName("cloudUrl");

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IntervalMap)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IntervalName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MetroId).HasColumnName("MetroID");

                entity.Property(e => e.MetroName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("date");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtfgridServer)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("UTFGridServer");
            });

            modelBuilder.Entity<MIntervalTypeEnum>(entity =>
            {
                entity.ToTable("M_IntervalTypeEnum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Number).HasColumnName("number");
            });

            modelBuilder.Entity<MLineInfo>(entity =>
            {
                entity.HasKey(e => e.MetroId);

                entity.ToTable("M_LineInfo");

                entity.Property(e => e.MetroId)
                    .ValueGeneratedNever()
                    .HasColumnName("metroId");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.MetroCode).HasColumnName("metroCode");

                entity.Property(e => e.MetroColor)
                    .HasMaxLength(255)
                    .HasColumnName("metroColor");

                entity.Property(e => e.MetroDelTime)
                    .HasMaxLength(255)
                    .HasColumnName("metroDelTime");

                entity.Property(e => e.MetroDownEndTime)
                    .HasPrecision(0)
                    .HasColumnName("metroDownEndTime");

                entity.Property(e => e.MetroDownStartTime)
                    .HasPrecision(0)
                    .HasColumnName("metroDownStartTime");

                entity.Property(e => e.MetroEndStationId)
                    .HasMaxLength(255)
                    .HasColumnName("metroEndStationId");

                entity.Property(e => e.MetroIsDel).HasColumnName("metroIsDel");

                entity.Property(e => e.MetroLength).HasColumnName("metroLength");

                entity.Property(e => e.MetroName)
                    .HasMaxLength(255)
                    .HasColumnName("metroName");

                entity.Property(e => e.MetroOpenTime)
                    .HasColumnType("date")
                    .HasColumnName("metroOpenTime");

                entity.Property(e => e.MetroRemark)
                    .HasMaxLength(255)
                    .HasColumnName("metroRemark");

                entity.Property(e => e.MetroStartStationId)
                    .HasMaxLength(255)
                    .HasColumnName("metroStartStationId");

                entity.Property(e => e.MetroUpEndTime)
                    .HasPrecision(0)
                    .HasColumnName("metroUpEndTime");

                entity.Property(e => e.MetroUpStartTime)
                    .HasPrecision(0)
                    .HasColumnName("metroUpStartTime");
            });

            modelBuilder.Entity<MMetroGeometryInfo>(entity =>
            {
                entity.HasKey(e => e.MetroGeoLineId)
                    .HasName("PK_metro_geoline_info$");

                entity.ToTable("M_MetroGeometryInfo");

                entity.Property(e => e.MetroGeoLineId)
                    .ValueGeneratedNever()
                    .HasColumnName("metroGeoLineId");

                entity.Property(e => e.GeoLineBaiDuX).HasColumnName("geoLineBaiDuX");

                entity.Property(e => e.GeoLineBaiDuY).HasColumnName("geoLineBaiDuY");

                entity.Property(e => e.GeoLineCalcFlag).HasColumnName("geoLineCalcFlag");

                entity.Property(e => e.GeoLineDelTime)
                    .HasMaxLength(255)
                    .HasColumnName("geoLineDelTime");

                entity.Property(e => e.GeoLineDirect).HasColumnName("geoLineDirect");

                entity.Property(e => e.GeoLineEvaluation).HasColumnName("geoLineEvaluation");

                entity.Property(e => e.GeoLineIsDel).HasColumnName("geoLineIsDel");

                entity.Property(e => e.GeoLineMileage).HasColumnName("geoLineMileage");

                entity.Property(e => e.GeoLinePointSequence).HasColumnName("geoLinePointSequence");

                entity.Property(e => e.GeoLineRemark)
                    .HasMaxLength(255)
                    .HasColumnName("geoLineRemark");

                entity.Property(e => e.GeoLineStructureType).HasColumnName("geoLineStructureType");

                entity.Property(e => e.GeoLineWgs84x).HasColumnName("geoLineWGS84X");

                entity.Property(e => e.GeoLineWgs84y).HasColumnName("geoLineWGS84Y");

                entity.Property(e => e.GeoLineX).HasColumnName("geoLineX");

                entity.Property(e => e.GeoLineY).HasColumnName("geoLineY");

                entity.Property(e => e.MetroIntervalId).HasColumnName("metroIntervalId");

                entity.Property(e => e.SegmentLiningsId)
                    .HasMaxLength(255)
                    .HasColumnName("segmentLiningsId");
            });

            modelBuilder.Entity<MMetroInterval>(entity =>
            {
                entity.HasKey(e => e.MetroIntervalId)
                    .HasName("PK_metro_interval$");

                entity.ToTable("M_MetroInterval");

                entity.Property(e => e.MetroIntervalId)
                    .ValueGeneratedNever()
                    .HasColumnName("metroIntervalId");

                entity.Property(e => e.AcrossSoillayer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GeoZone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntervalDelTime)
                    .HasMaxLength(255)
                    .HasColumnName("intervalDelTime");

                entity.Property(e => e.IntervalDirect).HasColumnName("intervalDirect");

                entity.Property(e => e.IntervalHoopCount).HasColumnName("intervalHoopCount");

                entity.Property(e => e.IntervalHoopWide).HasColumnName("intervalHoopWide");

                entity.Property(e => e.IntervalIsDel).HasColumnName("intervalIsDel");

                entity.Property(e => e.IntervalRemark)
                    .HasMaxLength(255)
                    .HasColumnName("intervalRemark");

                entity.Property(e => e.IntervalSequence).HasColumnName("intervalSequence");

                entity.Property(e => e.IntervalShaftCount).HasColumnName("intervalShaftCount");

                entity.Property(e => e.IntervalType).HasColumnName("intervalType");

                entity.Property(e => e.MetroIntervalName)
                    .HasMaxLength(255)
                    .HasColumnName("metroIntervalName");

                entity.Property(e => e.MetroSectionId).HasColumnName("metroSectionId");
            });

            modelBuilder.Entity<MMetroSection>(entity =>
            {
                entity.HasKey(e => e.MetroSectionId);

                entity.ToTable("M_MetroSection");

                entity.Property(e => e.MetroSectionId)
                    .ValueGeneratedNever()
                    .HasColumnName("metroSectionId");

                entity.Property(e => e.MetroId).HasColumnName("metroId");

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(255)
                    .HasColumnName("sectionCode");

                entity.Property(e => e.SectionDelTime)
                    .HasMaxLength(255)
                    .HasColumnName("sectionDelTime");

                entity.Property(e => e.SectionIsDel).HasColumnName("sectionIsDel");

                entity.Property(e => e.SectionName)
                    .HasMaxLength(255)
                    .HasColumnName("sectionName");

                entity.Property(e => e.SectionOpenTime)
                    .HasColumnType("date")
                    .HasColumnName("sectionOpenTime");

                entity.Property(e => e.SectionRemark)
                    .HasMaxLength(255)
                    .HasColumnName("sectionRemark");
            });

            modelBuilder.Entity<MRingSoil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("M_RingSoil");

                entity.Property(e => e.BottomsoilLength).HasColumnName("bottomsoilLength");

                entity.Property(e => e.BottomsoilNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bottomsoilNO");

                entity.Property(e => e.Direct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direct");

                entity.Property(e => e.Guid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GUID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IntervalId).HasColumnName("intervalID");

                entity.Property(e => e.Pid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PID");

                entity.Property(e => e.RingBottomdepth).HasColumnName("ringBottomdepth");

                entity.Property(e => e.RingBottomheight).HasColumnName("ringBottomheight");

                entity.Property(e => e.RingMiddleheight).HasColumnName("ringMiddleheight");

                entity.Property(e => e.RingTopdepth).HasColumnName("ringTopdepth");

                entity.Property(e => e.RingTopheight).HasColumnName("ringTopheight");

                entity.Property(e => e.ThroughsoilName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("throughsoilName");

                entity.Property(e => e.ThroughsoilNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("throughsoilNO");

                entity.Property(e => e.TopsoilLength).HasColumnName("topsoilLength");

                entity.Property(e => e.TopsoilNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("topsoilNO");

                entity.Property(e => e.Wgs84X).HasColumnName("wgs84X");

                entity.Property(e => e.Wgs84Y).HasColumnName("wgs84Y");
            });

            modelBuilder.Entity<Main>(entity =>
            {
                entity.HasKey(e => e.Tnumber);

                entity.ToTable("main");

                entity.Property(e => e.Tnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("tnumber");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.CnNote)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("cn_note");

                entity.Property(e => e.Color)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Enddep).HasColumnName("enddep");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.SoilHnumber).HasColumnName("soil_hnumber");

                entity.Property(e => e.SoilNo)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("soilNo");

                entity.Property(e => e.Stardep).HasColumnName("stardep");
            });

            modelBuilder.Entity<MetroGeoLayer>(entity =>
            {
                entity.ToTable("MetroGeoLayer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Layer).HasMaxLength(255);

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");
            });

            modelBuilder.Entity<OldBuilding>(entity =>
            {
                entity.ToTable("OldBuilding");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.BaiduX).HasColumnName("baiduX");

                entity.Property(e => e.BaiduY).HasColumnName("baiduY");

                entity.Property(e => e.Codenum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("codenum");

                entity.Property(e => e.ConYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("conYear");

                entity.Property(e => e.Details)
                    .HasColumnType("text")
                    .HasColumnName("details");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.StructType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("structType");

                entity.Property(e => e.Wgs84X).HasColumnName("wgs84X");

                entity.Property(e => e.Wgs84Y).HasColumnName("wgs84Y");
            });

            modelBuilder.Entity<OldBuildingFileRecord>(entity =>
            {
                entity.ToTable("OldBuildingFileRecord");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuildingId).HasColumnName("BuildingID");

                entity.Property(e => e.FileAutoName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileOriginalName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Building)
                    .WithMany(p => p.OldBuildingFileRecords)
                    .HasForeignKey(d => d.BuildingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OldBuildi__Build__6E0C4425");
            });

            modelBuilder.Entity<PBuildingInfo>(entity =>
            {
                entity.ToTable("P_BuildingInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbsBottomHeight).HasColumnName("absBottomHeight");

                entity.Property(e => e.AbsTopHeight).HasColumnName("absTopHeight");

                entity.Property(e => e.BuildingName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eqlength).HasColumnName("EQlength");

                entity.Property(e => e.Eqwidth).HasColumnName("EQwidth");

                entity.Property(e => e.FloorNo).HasColumnName("floorNo");

                entity.Property(e => e.FoundationDepth).HasColumnName("foundationDepth");

                entity.Property(e => e.Pilelenth).HasColumnName("pilelenth");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Start).HasColumnType("date");

                entity.Property(e => e.StructType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PPileConnectType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("P_PileConnectType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PPileInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("P_PileInfo");

                entity.Property(e => e.Bearing)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNO");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LimitLoad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Maxsettlement).HasColumnName("MAXsettlement");

                entity.Property(e => e.Maxtestload).HasColumnName("MAXTestload");

                entity.Property(e => e.PileConnect)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PileDate).HasColumnType("date");

                entity.Property(e => e.PileId).HasColumnName("PileID");

                entity.Property(e => e.PileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PileShaftSize)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PileSoilType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PileTipSize)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PileType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Projectname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("projectname");

                entity.Property(e => e.Remsettlement).HasColumnName("REMsettlement");

                entity.Property(e => e.TestDate).HasColumnType("date");

                entity.Property(e => e.Wgs84X).HasColumnName("wgs84X");

                entity.Property(e => e.Wgs84Y).HasColumnName("wgs84Y");

                entity.Property(e => e.WzX).HasColumnName("wz_x");

                entity.Property(e => e.WzY).HasColumnName("wz_y");
            });

            modelBuilder.Entity<PPileTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("P_PileTest");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Load).HasColumnName("load");

                entity.Property(e => e.PileId).HasColumnName("PileID");

                entity.Property(e => e.SequencNo).HasColumnName("SequencNO");
            });

            modelBuilder.Entity<PaleoRiver>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PaleoRiver");

                entity.Property(e => e.Objectid).HasColumnName("OBJECTID");
            });

            modelBuilder.Entity<Pholeatt>(entity =>
            {
                entity.HasKey(e => e.Hnumber)
                    .HasName("PK_C_pholeatt");

                entity.ToTable("pholeatt");

                entity.Property(e => e.Hnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("hnumber");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.Assort)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("assort");

                entity.Property(e => e.AssortNb).HasColumnName("assort_nb");

                entity.Property(e => e.Attribute).HasColumnName("attribute");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.HoleOrder).HasColumnName("hole_order");

                entity.Property(e => e.Holeno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("holeno");

                entity.Property(e => e.IsTran).HasColumnName("is_tran");

                entity.Property(e => e.Lastlayerno)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("lastlayerno");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.ProjectSource).HasColumnName("project_source");

                entity.Property(e => e.SlurryEnd).HasColumnName("slurry_end");

                entity.Property(e => e.SlurryStar).HasColumnName("slurry_star");

                entity.Property(e => e.TzOffset).HasColumnName("tz_offset");

                entity.Property(e => e.TzWgs84x).HasColumnName("tz_WGS84X");

                entity.Property(e => e.TzWgs84y).HasColumnName("tz_WGS84Y");

                entity.Property(e => e.TzX).HasColumnName("tz_x");

                entity.Property(e => e.TzY).HasColumnName("tz_y");

                entity.Property(e => e.Waterlevel).HasColumnName("waterlevel");

                entity.Property(e => e.WzWgs84x).HasColumnName("wz_WGS84X");

                entity.Property(e => e.WzWgs84y).HasColumnName("wz_WGS84Y");

                entity.Property(e => e.WzX).HasColumnName("wz_x");

                entity.Property(e => e.WzY).HasColumnName("wz_y");

                entity.Property(e => e.Zklx).HasColumnName("zklx");
            });

            modelBuilder.Entity<PileFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PileFile");

                entity.Property(e => e.DeleteId).HasColumnName("DeleteID");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.Filename)
                    .IsUnicode(false)
                    .HasColumnName("filename");

                entity.Property(e => e.Filetype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("filetype");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Projectname)
                    .IsUnicode(false)
                    .HasColumnName("projectname");

                entity.Property(e => e.UploadId).HasColumnName("UploadID");

                entity.Property(e => e.Uploadtime).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<PileInfo>(entity =>
            {
                entity.HasKey(e => e.PileId)
                    .HasName("PK__PileInfo__53AB90FC23A93AC7");

                entity.ToTable("PileInfo");

                entity.Property(e => e.Conclusion).IsUnicode(false);

                entity.Property(e => e.DeleteId).HasColumnName("DeleteID");

                entity.Property(e => e.DeleteTime).HasPrecision(0);

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.PileLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PileNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PileType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PilesinkingDate).HasPrecision(0);

                entity.Property(e => e.TestDate).HasPrecision(0);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.PileInfos)
                    .HasForeignKey(d => d.Projectid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PileInfo_pileProject_1");
            });

            modelBuilder.Entity<PileProject>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK__pileProj__761ABEF01EE485AA");

                entity.ToTable("PileProject");

                entity.Property(e => e.ClientUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConstructionUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteId).HasColumnName("DeleteID");

                entity.Property(e => e.DeleteTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DesignerUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProjectNO");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SupervisorUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Wgs84x).HasColumnName("WGS84X");

                entity.Property(e => e.Wgs84y).HasColumnName("WGS84Y");

                entity.Property(e => e.WorkingUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pitzone>(entity =>
            {
                entity.ToTable("pitzone");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Belong)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("belong");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Stage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("stage");
            });

            modelBuilder.Entity<Pmbg>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("pmbg");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.Bgpoint)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bgpoint");

                entity.Property(e => e.Endpos).HasColumnName("endpos");

                entity.Property(e => e.Hnumber).HasColumnName("hnumber");

                entity.Property(e => e.N635).HasColumnName("n635");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Startpos).HasColumnName("startpos");

                entity.Property(e => e.StatFg).HasColumnName("stat_FG");
            });

            modelBuilder.Entity<Pmhole>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("pmhole");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.CutFg).HasColumnName("cut_fg");

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.Excursion).HasColumnName("excursion");

                entity.Property(e => e.Hnumber).HasColumnName("hnumber");

                entity.Property(e => e.N).HasColumnName("n");

                entity.Property(e => e.Pnumber).HasColumnName("pnumber");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");
            });

            modelBuilder.Entity<Pmlayer>(entity =>
            {
                entity.HasKey(e => e.Anumber);

                entity.ToTable("pmlayer");

                entity.Property(e => e.Anumber)
                    .ValueGeneratedNever()
                    .HasColumnName("anumber");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.LayerAttr).HasColumnType("image");

                entity.Property(e => e.LayerNameEn)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("LayerName_en");

                entity.Property(e => e.Layername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("layername");

                entity.Property(e => e.Layerno)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("layerno");

                entity.Property(e => e.Layerorder).HasColumnName("layerorder");

                entity.Property(e => e.Layertype).HasColumnName("layertype");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");
            });

            modelBuilder.Entity<Pmtadjust>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("PMTAdjust");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.MData)
                    .HasColumnType("image")
                    .HasColumnName("m_data");

                entity.Property(e => e.MSize).HasColumnName("m_size");

                entity.Property(e => e.Pnumber).HasColumnName("pnumber");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Subnumber).HasColumnName("subnumber");
            });

            modelBuilder.Entity<Pouatt>(entity =>
            {
                entity.HasKey(e => e.Pnumber);

                entity.ToTable("pouatt");

                entity.Property(e => e.Pnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("pnumber");

                entity.Property(e => e.AgeNo).HasColumnName("age_No");

                entity.Property(e => e.ConsultHole)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("consult_hole");

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.PageN).HasColumnName("page_n");

                entity.Property(e => e.PouNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");
            });

            modelBuilder.Entity<PreValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PreValue");

                entity.Property(e => e.Gksequence).HasColumnName("GKsequence");

                entity.Property(e => e.Gongkuang).HasColumnName("gongkuang");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PointId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pointID");

                entity.Property(e => e.PreValue1).HasColumnName("PreValue");

                entity.Property(e => e.ProjectId).HasColumnName("projectID");
            });

            modelBuilder.Entity<ProjectModel>(entity =>
            {
                entity.ToTable("projectModel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Engineering)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("engineering");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ProjectId).HasColumnName("projectID");

                entity.Property(e => e.RHeight).HasColumnName("rHeight");

                entity.Property(e => e.RRotate).HasColumnName("rRotate");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("updateUser");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<ProjectTypNum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("projectTypNUM");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Quanji>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quanji");

                entity.Property(e => e.Belong)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("belong");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Quanji1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("quanji");
            });

            modelBuilder.Entity<RegionModel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("regionModel");

                entity.Property(e => e.Engineering)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("engineering");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RegionId).HasColumnName("regionID");

                entity.Property(e => e.Remark)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("date")
                    .HasColumnName("updateDate");

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("updateUser");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<River>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("river");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ManagerUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("managerUnit");

                entity.Property(e => e.Rivername)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rivername");
            });

            modelBuilder.Entity<Riverinterval>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("riverinterval");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Intervalname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("intervalname");

                entity.Property(e => e.Riverid).HasColumnName("riverid");

                entity.Property(e => e.Sectionid).HasColumnName("sectionid");

                entity.Property(e => e.Sequence).HasColumnName("sequence");
            });

            modelBuilder.Entity<Riverlocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("riverlocation");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.Riverintervalid).HasColumnName("riverintervalid");

                entity.Property(e => e.Wgs84x).HasColumnName("wgs84x");

                entity.Property(e => e.Wgs84y).HasColumnName("wgs84y");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");
            });

            modelBuilder.Entity<Riversection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("riversection");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Riverid).HasColumnName("riverid");

                entity.Property(e => e.Sectionname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sectionname");
            });

            modelBuilder.Entity<Road>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("road");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ProjectId).HasColumnName("projectID");

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.Wgs84Y).HasColumnName("wgs84Y");

                entity.Property(e => e.Wgs84x).HasColumnName("wgs84x");
            });

            modelBuilder.Entity<Rule>(entity =>
            {
                entity.HasKey(e => e.Tnumber);

                entity.ToTable("rules");

                entity.Property(e => e.Tnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("tnumber");

                entity.Property(e => e.A0102).HasColumnName("a01_02");

                entity.Property(e => e.C).HasColumnName("c");

                entity.Property(e => e.CqFlag).HasColumnName("CQ_flag");

                entity.Property(e => e.Es0102).HasColumnName("es01_02");

                entity.Property(e => e.H).HasColumnName("h");

                entity.Property(e => e.Kh).HasColumnName("kh");

                entity.Property(e => e.Kv).HasColumnName("kv");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.P0).HasColumnName("p0");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Q).HasColumnName("q");

                entity.Property(e => e.W).HasColumnName("w");

                entity.Property(e => e.Wl).HasColumnName("wl");

                entity.Property(e => e.Wp).HasColumnName("wp");
            });

            modelBuilder.Entity<Rulecale>(entity =>
            {
                entity.HasKey(e => e.Tnumber);

                entity.ToTable("rulecale");

                entity.Property(e => e.Tnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("tnumber");

                entity.Property(e => e.E0).HasColumnName("e0");

                entity.Property(e => e.G).HasColumnName("g");

                entity.Property(e => e.Il).HasColumnName("il");

                entity.Property(e => e.Ip).HasColumnName("ip");

                entity.Property(e => e.MC).HasColumnName("m_c");

                entity.Property(e => e.MQ).HasColumnName("m_q");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Rorder).HasColumnName("rorder");

                entity.Property(e => e.Soilname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("soilname");

                entity.Property(e => e.Sr).HasColumnName("sr");

                entity.Property(e => e.St).HasColumnName("st");
            });

            modelBuilder.Entity<Sidedown>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("sidedown");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.A).HasColumnName("a");

                entity.Property(e => e.Anumber).HasColumnName("anumber");

                entity.Property(e => e.BShow).HasColumnName("bShow");

                entity.Property(e => e.Data)
                    .HasColumnType("image")
                    .HasColumnName("data");

                entity.Property(e => e.Dcount).HasColumnName("dcount");

                entity.Property(e => e.H).HasColumnName("h");

                entity.Property(e => e.Hhigh).HasColumnName("hhigh");

                entity.Property(e => e.Hnumber).HasColumnName("hnumber");

                entity.Property(e => e.NOption).HasColumnName("nOption");

                entity.Property(e => e.NReforce).HasColumnName("nReforce");

                entity.Property(e => e.P).HasColumnName("p");

                entity.Property(e => e.ProjectCount).HasColumnName("Project_count");

                entity.Property(e => e.TNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tNo");

                entity.Property(e => e.Testdate)
                    .HasColumnType("datetime")
                    .HasColumnName("testdate");

                entity.Property(e => e.Thigh).HasColumnName("thigh");

                entity.Property(e => e.U).HasColumnName("u");

                entity.Property(e => e.Water).HasColumnName("water");
            });

            modelBuilder.Entity<Soilhole>(entity =>
            {
                entity.HasKey(e => e.SoilHnumber);

                entity.ToTable("soilhole");

                entity.Property(e => e.SoilHnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("soil_hnumber");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.Hnumber).HasColumnName("hnumber");

                entity.Property(e => e.HoleOrder).HasColumnName("hole_order");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.SoilHoleNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("soil_holeNo");
            });

            modelBuilder.Entity<Sudb>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("sudb");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.Hnumber).HasColumnName("hnumber");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Startdep).HasColumnName("startdep");

                entity.Property(e => e.StatFg).HasColumnName("stat_FG");

                entity.Property(e => e.Su).HasColumnName("su");

                entity.Property(e => e.Su1).HasColumnName("su1");
            });

            modelBuilder.Entity<SysDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("Sys_Department");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Department_Name");
            });

            modelBuilder.Entity<SysModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("Sys_Module");

                entity.Property(e => e.ModuleId).HasColumnName("Module_ID");

                entity.Property(e => e.Isdelete).HasColumnName("isdelete");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Module_Name");

                entity.Property(e => e.ModuleUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Module_Url");
            });

            modelBuilder.Entity<SysRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("Sys_Role");

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.CreateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleDescribe)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Role_Describe");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Role_Name");
            });

            modelBuilder.Entity<SysRoleGroup>(entity =>
            {
                entity.ToTable("Sys_RoleGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleId).HasColumnName("Module_ID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");
            });

            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Sys_User");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.UserBirthday)
                    .HasColumnType("date")
                    .HasColumnName("User_Birthday");

                entity.Property(e => e.UserLoginId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Login_ID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("User_Name");

                entity.Property(e => e.UserNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Number");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.SysUsers)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Sys_User_Sys_Department");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Sys_User_Sys_Role");
            });

            modelBuilder.Entity<TApplicationDatum>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("tApplicationData");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.Bindata)
                    .HasColumnType("image")
                    .HasColumnName("bindata");

                entity.Property(e => e.FormId).HasColumnName("formID");

                entity.Property(e => e.Hnumber).HasColumnName("hnumber");

                entity.Property(e => e.Item1size).HasColumnName("item1size");

                entity.Property(e => e.Item2size).HasColumnName("item2size");

                entity.Property(e => e.Item3size).HasColumnName("item3size");

                entity.Property(e => e.Mnumber).HasColumnName("mnumber");

                entity.Property(e => e.Pnumber).HasColumnName("pnumber");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Totalsize).HasColumnName("totalsize");
            });

            modelBuilder.Entity<TConstructionStage>(entity =>
            {
                entity.ToTable("T_ConstructionStage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConstructionEndDate).HasColumnType("datetime");

                entity.Property(e => e.ConstructionStageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ConstructionStageID");

                entity.Property(e => e.ConstructionStageName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ConstructionStartDate).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Memo).HasColumnType("text");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.ProProgressId).HasColumnName("ProProgressID");

                entity.HasOne(d => d.ProProgress)
                    .WithMany(p => p.TConstructionStages)
                    .HasForeignKey(d => d.ProProgressId)
                    .HasConstraintName("FK_T_ConstructionStage_T_ProjectProgress");
            });

            modelBuilder.Entity<TMonitorDataType>(entity =>
            {
                entity.ToTable("T_MonitorDataType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComponentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MeasureUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonitorDataTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MonitorDataTypeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMonitorPoint>(entity =>
            {
                entity.ToTable("T_MonitorPoint");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataTypeId).HasColumnName("DataTypeID");

                entity.Property(e => e.Depth).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HoleElevation).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.HoleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HoleID");

                entity.Property(e => e.MonitorPointId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MonitorPointID");

                entity.Property(e => e.MonitorProjectId).HasColumnName("MonitorProjectID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.X).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Y).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Z).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TMonitorPointSetting>(entity =>
            {
                entity.ToTable("T_MonitorPointSetting");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlarmConfig)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DailyAlertLowerLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DailyAlertUpLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DailyWarningLowerLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DailyWarningUpLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FinalUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.InitialDate).HasColumnType("datetime");

                entity.Property(e => e.InitialValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MonitorPointId).HasColumnName("MonitorPointID");

                entity.Property(e => e.MonitorPointSettingsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MonitorPointSettingsID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.TotalAlertLowerLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalAlertUpLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalWarningLowerLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalWarningUpLimit).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.MonitorPoint)
                    .WithMany(p => p.TMonitorPointSettings)
                    .HasForeignKey(d => d.MonitorPointId)
                    .HasConstraintName("FK_T_MonitorPointSetting_T_MonitorPoint");
            });

            modelBuilder.Entity<TMonitorProject>(entity =>
            {
                entity.ToTable("T_MonitorProjects");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataTypeId).HasColumnName("DataTypeID");

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeasureUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonitorProjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MonitorProjectID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.HasOne(d => d.DataType)
                    .WithMany(p => p.TMonitorProjects)
                    .HasForeignKey(d => d.DataTypeId)
                    .HasConstraintName("FK_T_MonitorProjects_T_MonitorDataType");
            });

            modelBuilder.Entity<TMonitorProjectSetting>(entity =>
            {
                entity.ToTable("T_MonitorProjectSetting");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DailyAlertLowerLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DailyAlertUpLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DailyWarningLowerLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DailyWarningUpLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LastestMonitorDate).HasColumnType("datetime");

                entity.Property(e => e.MoniotorProjectId).HasColumnName("MoniotorProjectID");

                entity.Property(e => e.MonitorProjectSettingId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MonitorProjectSettingID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.TotalAlertLowerLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalAlertUpLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalWarningLowerLimit).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalWarningUpLimit).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.MoniotorProject)
                    .WithMany(p => p.TMonitorProjectSettings)
                    .HasForeignKey(d => d.MoniotorProjectId)
                    .HasConstraintName("FK_T_MonitorProjectSetting_T_MonitorProjects");
            });

            modelBuilder.Entity<TMonitorValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_MonitorValue");

                entity.Property(e => e.CurrentValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CurrentVariance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DailyVariance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DailyWarningState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataComponentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MonitorDate).HasColumnType("datetime");

                entity.Property(e => e.MonitorPointId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MonitorPointID");

                entity.Property(e => e.MonitorPointSettingsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MonitorPointSettingsID");

                entity.Property(e => e.MonitorProjectId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MonitorProjectID");

                entity.Property(e => e.MonitorvalueId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("monitorvalueID");

                entity.Property(e => e.Pid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PID");

                entity.Property(e => e.TotalVariance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalWarningState)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TProject>(entity =>
            {
                entity.ToTable("T_Project");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbbreviationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActualEndDate).HasColumnType("date");

                entity.Property(e => e.ActualStartDate).HasColumnType("date");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BiggestDepthofTunnel).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExcavateArea).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExcavateDepth).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExpectEndDate).HasColumnType("date");

                entity.Property(e => e.ExpectStartDate).HasColumnType("date");

                entity.Property(e => e.GeoZone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Manager)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PID");

                entity.Property(e => e.PrjState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProStageState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Procom)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PROCOM");

                entity.Property(e => e.ProjectType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortestDistanceToTunnel).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SurroundDepth).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SurroundType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wgs84x).HasColumnName("WGS84X");

                entity.Property(e => e.Wgs84y).HasColumnName("WGS84Y");

                entity.Property(e => e.X).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Y).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Z).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TProjectAlarmPoint>(entity =>
            {
                entity.ToTable("T_ProjectAlarmPoints");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.PointId).HasColumnName("PointID");

                entity.Property(e => e.PointName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectAlarmPointId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProjectAlarmPointID");

                entity.Property(e => e.SummaryTableId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SummaryTableID");

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.TProjectAlarmPoints)
                    .HasForeignKey(d => d.PointId)
                    .HasConstraintName("FK_T_ProjectAlarmPoints_T_MonitorPoint");
            });

            modelBuilder.Entity<TProjectFile>(entity =>
            {
                entity.ToTable("T_ProjectFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileTyoe)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FileURL");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.ProjectFileId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProjectFileID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TProjectImage>(entity =>
            {
                entity.ToTable("T_ProjectImage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImagePath).HasColumnType("text");

                entity.Property(e => e.ImageType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasColumnType("text")
                    .HasColumnName("ImageURL");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.ProjectImageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProjectImageID");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TProjectLevelEnum>(entity =>
            {
                entity.ToTable("T_ProjectLevelEnum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TProjectProgress>(entity =>
            {
                entity.ToTable("T_ProjectProgress");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Describe).IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FrequencyString)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.PrjProgressId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PrjProgressID");

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.SectionExcavateArea).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SectionExcavateDepth).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.State).IsUnicode(false);
            });

            modelBuilder.Entity<TProjectStatusEnum>(entity =>
            {
                entity.ToTable("T_ProjectStatusEnum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TProjectmap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_projectmap");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Pid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PID");

                entity.Property(e => e.XmlLayers).IsUnicode(false);
            });

            modelBuilder.Entity<ThreeDmodel>(entity =>
            {
                entity.ToTable("ThreeDModel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Int).HasColumnName("int");

                entity.Property(e => e.IntervalName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("intervalName");

                entity.Property(e => e.LineId).HasColumnName("lineId");

                entity.Property(e => e.ModelId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("modelId");

                entity.Property(e => e.Pid).HasColumnName("PID");
            });

            modelBuilder.Entity<ThreeProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ThreeProject");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModelId)
                    .IsUnicode(false)
                    .HasColumnName("ModelID");

                entity.Property(e => e.ProjectName)
                    .IsUnicode(false)
                    .HasColumnName("projectName");
            });

            modelBuilder.Entity<Titemdatum>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("titemdata");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.AgeNo).HasColumnName("age_no");

                entity.Property(e => e.Anumber).HasColumnName("anumber");

                entity.Property(e => e.ExTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("exTitle");

                entity.Property(e => e.IN).HasColumnName("i_n");

                entity.Property(e => e.ISort).HasColumnName("i_sort");

                entity.Property(e => e.Iavg).HasColumnName("iavg");

                entity.Property(e => e.Icv).HasColumnName("icv");

                entity.Property(e => e.Imax).HasColumnName("imax");

                entity.Property(e => e.Imin).HasColumnName("imin");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("itemCode");

                entity.Property(e => e.Itemtype).HasColumnName("itemtype");

                entity.Property(e => e.Ivar).HasColumnName("ivar");

                entity.Property(e => e.N).HasColumnName("n");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");
            });

            modelBuilder.Entity<Tpf>(entity =>
            {
                entity.HasKey(e => e.Hnumber);

                entity.ToTable("tpfs");

                entity.Property(e => e.Hnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("hnumber");

                entity.Property(e => e.Dep).HasColumnName("dep");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.PsVarfg).HasColumnName("ps_varfg");

                entity.Property(e => e.QcFs)
                    .HasColumnType("image")
                    .HasColumnName("qc_fs");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.TpfsCount).HasColumnName("tpfs_count");
            });

            modelBuilder.Entity<Trial>(entity =>
            {
                entity.HasKey(e => e.Tnumber);

                entity.ToTable("trial");

                entity.Property(e => e.Tnumber)
                    .ValueGeneratedNever()
                    .HasColumnName("tnumber");

                entity.Property(e => e.Ccu).HasColumnName("ccu");

                entity.Property(e => e.Cl).HasColumnName("cl");

                entity.Property(e => e.Cu).HasColumnName("cu");

                entity.Property(e => e.K0).HasColumnName("k0");

                entity.Property(e => e.Nn).HasColumnName("nn");

                entity.Property(e => e.Ou).HasColumnName("ou");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.Qcu).HasColumnName("qcu");

                entity.Property(e => e.Ql).HasColumnName("ql");

                entity.Property(e => e.Qlu).HasColumnName("qlu");

                entity.Property(e => e.Qu).HasColumnName("qu");
            });

            modelBuilder.Entity<VProjectInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ProjectInfo");

                entity.Property(e => e.DataSource)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VProjectPoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ProjectPoints");

                entity.Property(e => e.DataSource)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonitorType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PointName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VProjectStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ProjectStatus");

                entity.Property(e => e.DataSource)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Describe).IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<VProjectValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ProjectValue");

                entity.Property(e => e.DailyVariance).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.DailyWarningState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MonitorDate).HasColumnType("datetime");

                entity.Property(e => e.MonitorType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PointId).HasColumnName("PointID");

                entity.Property(e => e.PointName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalVariance).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.TotalWarningState)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VProjectValueByTianAn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ProjectValueByTianAn");

                entity.Property(e => e.CurrentValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CurrentVariance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DailyVariance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DailyWarningState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Depth).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MonitorDate).HasColumnType("datetime");

                entity.Property(e => e.MonitorType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PointId).HasColumnName("PointID");

                entity.Property(e => e.PointName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalVariance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalWarningState)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VProjectValueByYunTu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ProjectValueByYunTu");

                entity.Property(e => e.DataSource)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.MonitorType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PointId).HasColumnName("PointID");

                entity.Property(e => e.PointName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VipProject>(entity =>
            {
                entity.ToTable("VipProject");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("adress");

                entity.Property(e => e.Belong).HasColumnName("belong");

                entity.Property(e => e.Bimmodel)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("BIMmodel");

                entity.Property(e => e.GeoGis)
                    .IsUnicode(false)
                    .HasColumnName("geoGIS");

                entity.Property(e => e.IsCase).HasColumnName("isCase");

                entity.Property(e => e.IsLinable).HasColumnName("isLinable");

                entity.Property(e => e.LatestTime)
                    .HasColumnType("date")
                    .HasColumnName("latestTime");

                entity.Property(e => e.LatestUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("latestUser");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("projectName");

                entity.Property(e => e.ProjectType)
                    .HasMaxLength(512)
                    .IsUnicode(false)
                    .HasColumnName("projectType");

                entity.Property(e => e.Region).HasColumnName("region");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.Wgs84X).HasColumnName("wgs84X");

                entity.Property(e => e.Wgs84Y).HasColumnName("wgs84Y");
            });

            modelBuilder.Entity<WaterDepth>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("waterDepth");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ParentType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wave>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("Wave");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.AgeNo).HasColumnName("age_No");

                entity.Property(e => e.Cdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("cdate");

                entity.Property(e => e.D0).HasColumnName("d0");

                entity.Property(e => e.Data1)
                    .HasColumnType("image")
                    .HasColumnName("data1");

                entity.Property(e => e.Defernce).HasColumnName("defernce");

                entity.Property(e => e.Dspace).HasColumnName("dspace");

                entity.Property(e => e.Hnumber).HasColumnName("hnumber");

                entity.Property(e => e.M).HasColumnName("m");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");

                entity.Property(e => e.T).HasColumnName("t");

                entity.Property(e => e.TestWay).HasColumnName("test_way");

                entity.Property(e => e.Tno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tno");

                entity.Property(e => e.Totalsize).HasColumnName("totalsize");
            });

            modelBuilder.Entity<YMonitorPoint>(entity =>
            {
                entity.HasKey(e => e.Identity);

                entity.ToTable("Y_MonitorPoints");

                entity.Property(e => e.DateTime).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YMonitorPointsDictionary>(entity =>
            {
                entity.HasKey(e => e.Identity);

                entity.ToTable("Y_MonitorPointsDictionary");

                entity.Property(e => e.Identity).ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonitorType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YMonitorProjectExtraInfo>(entity =>
            {
                entity.HasKey(e => e.Identity);

                entity.ToTable("Y_MonitorProjectExtraInfo");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.BiggestDepthOfTunnel).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ConstructionCorp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractEndTime).HasColumnType("date");

                entity.Property(e => e.ContractStartTime).HasColumnType("date");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("date");

                entity.Property(e => e.ExcavateArea).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExcavateDepth).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.GeoZone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerCorp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrjLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrjState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrjSummary).IsUnicode(false);

                entity.Property(e => e.ShortestDistanceToTunnel).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StartTime).HasColumnType("date");

                entity.Property(e => e.TunnelType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YPrjGeoLayer>(entity =>
            {
                entity.HasKey(e => e.Identity);

                entity.ToTable("Y_PrjGeoLayers");

                entity.Property(e => e.Json).IsUnicode(false);

                entity.Property(e => e.LayerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YPrjMonitorType>(entity =>
            {
                entity.HasKey(e => e.Identity);

                entity.ToTable("Y_PrjMonitorTypes");

                entity.Property(e => e.Identity).HasColumnName("identity");

                entity.Property(e => e.MonitorType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YPrjStatus>(entity =>
            {
                entity.HasKey(e => e.Identity);

                entity.ToTable("Y_PrjStatus");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SectionExcavateArea).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SectionExcavateDepth).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YPrjStatusImage>(entity =>
            {
                entity.HasKey(e => e.Identity);

                entity.ToTable("Y_PrjStatusImage");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YProject>(entity =>
            {
                entity.HasKey(e => e.PrjId);

                entity.ToTable("Y_Projects");

                entity.Property(e => e.PrjId).ValueGeneratedNever();

                entity.Property(e => e.Center)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Identity).HasColumnName("identity");

                entity.Property(e => e.IntervalName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wgs84x).HasColumnName("WGS84X");

                entity.Property(e => e.Wgs84y).HasColumnName("WGS84Y");

                entity.HasOne(d => d.ProjectTypeNavigation)
                    .WithMany(p => p.YProjects)
                    .HasForeignKey(d => d.ProjectType)
                    .HasConstraintName("FK_Y_Projects_Y_ProjectTypeEnum");
            });

            modelBuilder.Entity<YProjectDocument>(entity =>
            {
                entity.ToTable("Y_ProjectDocument");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Ext)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UploadUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YProjectTypeEnum>(entity =>
            {
                entity.HasKey(e => e.ProjectType);

                entity.ToTable("Y_ProjectTypeEnum");

                entity.Property(e => e.ProjectType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zp93>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("zp93");

                entity.Property(e => e.Tid)
                    .ValueGeneratedNever()
                    .HasColumnName("tid");

                entity.Property(e => e.Anumber).HasColumnName("anumber");

                entity.Property(e => e.Dep).HasColumnName("dep");

                entity.Property(e => e.Hnumber).HasColumnName("hnumber");

                entity.Property(e => e.Norder).HasColumnName("norder");

                entity.Property(e => e.ProjectCount).HasColumnName("project_count");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
