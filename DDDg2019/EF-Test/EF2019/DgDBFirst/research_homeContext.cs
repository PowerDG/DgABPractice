using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DgDBFirst
{
    public partial class research_homeContext : DbContext
    {
        public research_homeContext()
        {
        }

        public research_homeContext(DbContextOptions<research_homeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Annualintegrals> Annualintegrals { get; set; }
        public virtual DbSet<Appraisals> Appraisals { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookComment> BookComment { get; set; }
        public virtual DbSet<ContributionStandard> ContributionStandard { get; set; }
        public virtual DbSet<Feedbacks> Feedbacks { get; set; }
        public virtual DbSet<Fund> Fund { get; set; }
        public virtual DbSet<Gifts> Gifts { get; set; }
        public virtual DbSet<Integrals> Integrals { get; set; }
        public virtual DbSet<Introductions> Introductions { get; set; }
        public virtual DbSet<Keyresults> Keyresults { get; set; }
        public virtual DbSet<Likerecords> Likerecords { get; set; }
        public virtual DbSet<Medals> Medals { get; set; }
        public virtual DbSet<Memberlabels> Memberlabels { get; set; }
        public virtual DbSet<Membermedals> Membermedals { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Memberskills> Memberskills { get; set; }
        public virtual DbSet<MembersTest> MembersTest { get; set; }
        public virtual DbSet<Parties> Parties { get; set; }
        public virtual DbSet<Partiesreviews> Partiesreviews { get; set; }
        public virtual DbSet<Partyphotos> Partyphotos { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<Plans> Plans { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<Taskcommunicationreplys> Taskcommunicationreplys { get; set; }
        public virtual DbSet<Taskcommunications> Taskcommunications { get; set; }
        public virtual DbSet<TaskFeedback> TaskFeedback { get; set; }
        public virtual DbSet<Taskpartners> Taskpartners { get; set; }
        public virtual DbSet<Taskreviews> Taskreviews { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Tasktrackings> Tasktrackings { get; set; }
        public virtual DbSet<Titlechanges> Titlechanges { get; set; }
        public virtual DbSet<Todos> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=192.168.1.102;Database=research_home;Uid=fooww;Pwd=Fooww_08@2018;SslMode=none;Allow User Variables=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Annualintegrals>(entity =>
            {
                entity.ToTable("annualintegrals");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AnnualIntegral).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.Years).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Appraisals>(entity =>
            {
                entity.ToTable("appraisals");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedMemberId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PerformanceScore).HasColumnType("decimal(5,2)");

                entity.Property(e => e.TotalScore).HasColumnType("decimal(5,2)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.ValueScore).HasColumnType("decimal(5,2)");

                entity.Property(e => e.Year).HasColumnType("int(4)");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.AverageScore)
                    .HasColumnName("average_score")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.LastComment)
                    .HasColumnName("last_comment")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Photo).HasColumnType("varchar(255)");

                entity.Property(e => e.PhotoHd)
                    .HasColumnName("PhotoHD")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Resource)
                    .HasColumnName("resource")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BookComment>(entity =>
            {
                entity.ToTable("book_comment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BookId)
                    .HasColumnName("book_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasColumnType("int(255)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ContributionStandard>(entity =>
            {
                entity.ToTable("contribution_standard");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Level).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Feedbacks>(entity =>
            {
                entity.ToTable("feedbacks");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ProviderId).HasColumnType("int(11)");

                entity.Property(e => e.ProviderName).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Fund>(entity =>
            {
                entity.ToTable("fund");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.InsertTime).HasColumnType("datetime");

                entity.Property(e => e.ItemName).HasColumnType("varchar(255)");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OperatMoney).HasColumnType("decimal(15,2)");

                entity.Property(e => e.RemainMoney)
                    .HasColumnType("decimal(15,2)")
                    .HasDefaultValueSql("'0.00'");
            });

            modelBuilder.Entity<Gifts>(entity =>
            {
                entity.ToTable("gifts");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedMemberId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.Hyperlink).HasColumnType("varchar(255)");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Price).HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Integrals>(entity =>
            {
                entity.ToTable("integrals");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Integral).HasColumnType("int(11)");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SourceId).HasColumnType("int(11)");

                entity.Property(e => e.SourceType).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Introductions>(entity =>
            {
                entity.ToTable("introductions");

                entity.HasIndex(e => e.CreateUser)
                    .HasName("article_ibfk_1");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.CreateUser).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Title).HasColumnType("varchar(255)");

                entity.Property(e => e.Type).HasColumnType("int(11)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.UpdateUser).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Keyresults>(entity =>
            {
                entity.ToTable("keyresults");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClosedMemberId).HasColumnType("int(11)");

                entity.Property(e => e.ClosedTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.LastUpdateMemberId).HasColumnType("int(11)");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.Status).HasColumnType("varchar(255)");

                entity.Property(e => e.TaskId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Likerecords>(entity =>
            {
                entity.ToTable("likerecords");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.LastOperateTime)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.LikeMeMemberId).HasColumnType("int(11)");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OperateType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Medals>(entity =>
            {
                entity.ToTable("medals");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.DiscardTime).HasColumnType("datetime");

                entity.Property(e => e.Grade).HasColumnType("int(11)");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsDiscard)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Memberlabels>(entity =>
            {
                entity.ToTable("memberlabels");

                entity.Property(e => e.Id).HasColumnType("int(20)");

                entity.Property(e => e.Count).HasColumnType("int(20)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MemberId).HasColumnType("int(20)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Membermedals>(entity =>
            {
                entity.ToTable("membermedals");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.GainDate)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.GainType).HasColumnType("int(11)");

                entity.Property(e => e.MedalId).HasColumnType("int(11)");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.TaskId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Members>(entity =>
            {
                entity.ToTable("members");

                entity.Property(e => e.Id).HasColumnType("int(20)");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AliasName).HasColumnType("varchar(50)");

                entity.Property(e => e.ArtPhoto)
                    .HasColumnName("art_photo")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BirthDay).HasColumnType("date");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.DislikeCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.EntryTime).HasColumnType("date");

                entity.Property(e => e.Gender).HasColumnType("bit(1)");

                entity.Property(e => e.IsAdmin)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.IsLeave)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.LeaveTime).HasColumnType("date");

                entity.Property(e => e.LikeCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Motto).HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.PasswordKey)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(22)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Photo).HasColumnType("varchar(255)");

                entity.Property(e => e.PhotoHd)
                    .HasColumnName("PhotoHD")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasColumnType("varchar(22)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TotalIntegral)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WeChat).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Memberskills>(entity =>
            {
                entity.ToTable("memberskills");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.GainDate).HasColumnType("date");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SkillId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<MembersTest>(entity =>
            {
                entity.ToTable("members_test");

                entity.Property(e => e.Id).HasColumnType("int(20)");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AliasName).HasColumnType("varchar(50)");

                entity.Property(e => e.ArtPhoto)
                    .HasColumnName("art_photo")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.BirthDay).HasColumnType("date");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.DislikeCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.EntryTime).HasColumnType("date");

                entity.Property(e => e.Gender).HasColumnType("bit(1)");

                entity.Property(e => e.IsAdmin)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.IsLeave)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.LeaveTime).HasColumnType("date");

                entity.Property(e => e.LikeCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Motto).HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.PasswordKey)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(22)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Photo).HasColumnType("varchar(255)");

                entity.Property(e => e.PhotoHd)
                    .HasColumnName("PhotoHD")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasColumnType("varchar(22)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Remarks).HasColumnType("text");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TotalIntegral)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WeChat).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Parties>(entity =>
            {
                entity.ToTable("parties");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address).HasColumnType("varchar(255)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasColumnType("varchar(255)");

                entity.Property(e => e.LikeLevel).HasColumnType("int(2)");

                entity.Property(e => e.Longitude).HasColumnType("varchar(255)");

                entity.Property(e => e.MemberId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Money).HasColumnType("decimal(11,2)");

                entity.Property(e => e.MoneyResource).HasColumnType("int(3)");

                entity.Property(e => e.Number).HasColumnType("int(10)");

                entity.Property(e => e.PartyName).HasColumnType("varchar(255)");

                entity.Property(e => e.PartyPlace).HasColumnType("varchar(255)");

                entity.Property(e => e.ReviewTimes)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Tel).HasColumnType("varchar(22)");
            });

            modelBuilder.Entity<Partiesreviews>(entity =>
            {
                entity.ToTable("partiesreviews");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PartyId).HasColumnType("int(11)");

                entity.Property(e => e.Review).HasColumnType("varchar(255)");

                entity.Property(e => e.ReviewTime)
                    .HasColumnType("datetime")
                    ;
            });

            modelBuilder.Entity<Partyphotos>(entity =>
            {
                entity.ToTable("partyphotos");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.ImgDescription).HasColumnType("varchar(255)");

                entity.Property(e => e.ImgUrl).HasColumnType("varchar(255)");

                entity.Property(e => e.ImgUrlPart).HasColumnType("varchar(255)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PartyId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Pictures>(entity =>
            {
                entity.ToTable("pictures");

                entity.Property(e => e.Id).HasColumnType("bigint(20)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PartialPictureUrl).HasColumnType("varchar(255)");

                entity.Property(e => e.UpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Plans>(entity =>
            {
                entity.ToTable("plans");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClosedTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedMemberId).HasColumnType("int(11)");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.Status).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.ToTable("skills");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Level).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ParentId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Taskcommunicationreplys>(entity =>
            {
                entity.ToTable("taskcommunicationreplys");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CommunicationId).HasColumnType("int(11)");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ReplyMemberId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Taskcommunications>(entity =>
            {
                entity.ToTable("taskcommunications");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaskId).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<TaskFeedback>(entity =>
            {
                entity.ToTable("task_feedback");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaskId)
                    .HasColumnName("task_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Taskpartners>(entity =>
            {
                entity.ToTable("taskpartners");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaskId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Taskreviews>(entity =>
            {
                entity.ToTable("taskreviews");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PerfectFunction)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StrongAspect)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.TaskId).HasColumnType("int(11)");

                entity.Property(e => e.TroubleFunction)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.WeaknessAspect)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.ToTable("tasks");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedMemberId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DeadLineTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name).HasColumnType("varchar(255)");

                entity.Property(e => e.PlanId).HasColumnType("int(11)");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.Score).HasColumnType("int(11)");

                entity.Property(e => e.ScoreApportioned)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Tasktrackings>(entity =>
            {
                entity.ToTable("tasktrackings");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.FollowDescription).HasColumnType("text");

                entity.Property(e => e.FollowTime).HasColumnType("datetime");

                entity.Property(e => e.FollowType).HasColumnType("varchar(150)");

                entity.Property(e => e.FollowerId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.TaskId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Titlechanges>(entity =>
            {
                entity.ToTable("titlechanges");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ChangedTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.CreatedMemberId).HasColumnType("int(11)");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.NewTitle)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.OldTitle)
                    .IsRequired()
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Todos>(entity =>
            {
                entity.ToTable("todos");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClosedTime).HasColumnType("datetime");

                entity.Property(e => e.CreateMemberId).HasColumnType("int(11)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.Executor).HasColumnType("int(11)");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnType("datetime")
                    ;

                entity.Property(e => e.ModifiedTime)
                    .HasColumnName("modified_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Remark).HasColumnType("text");

                entity.Property(e => e.Status).HasColumnType("varchar(255)");

                entity.Property(e => e.TaskId).HasColumnType("int(11)");
            });
        }
    }
}
