using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Infrastructure
{
    public class LimsDbContext:DbContext
    {
        public LimsDbContext(DbContextOptions<LimsDbContext> options):base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserSkill> UserSkills { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<DictItem> DictItems { get; set; }

        public DbSet<LogItem> LogItems { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<DeviceParameter> DeviceParameters { get; set; }

        public DbSet<Labware> Labwares { get; set; }

        public DbSet<LabwarePosition> LabwarePositions { get; set; }

        public DbSet<Line> Lines { get; set; }

        public DbSet<Node> Nodes { get; set; }

        public DbSet<NodeDevice> NodeDevices { get; set; }

        public DbSet<NodeLabware> NodeLabwares { get; set; }

        public DbSet<NodeProtocolStep> NodeProtocolSteps { get; set; }

        public DbSet<NodeReagent> NodeReagents { get; set; }

        public DbSet<NodeType> NodeTypes { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Process> Processes { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectTask> ProjectTasks { get; set; }

        public DbSet<ProtocolStep> ProtocolSteps { get; set; }

        public DbSet<Reagent> Reagents { get; set; }

        public DbSet<ReagentDosage> ReagentDosages { get; set; }

        public DbSet<ReagentPosition> ReagentPositions { get; set; }

        public DbSet<Sample> Samples { get; set; }

        public DbSet<SampleDosage> SampleDosages { get; set; }

        public DbSet<Solution> Solutions { get; set; }

        public DbSet<SolutionReagentDosage> SolutionReagentDosages { get; set; }

        public DbSet<SolutionSampleDosage> SolutionSampleDosages { get; set; }

        public DbSet<Take> Takes { get; set; }

        public DbSet<TakeTask> TakeTasks { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<TaskLabware> TaskLabwares { get; set; }

        public DbSet<TaskReagent> TaskReagents { get; set; }

        public DbSet<TaskSample> TaskSamples { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Line>()
                .HasOne(l => l.StartNode)
                .WithMany(n => n.StartLines)
                .HasForeignKey(l => l.StartNodeID)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            modelBuilder.Entity<Line>()
                .HasOne(l => l.EndNode)
                .WithMany(n => n.EndLines)
                .HasForeignKey(l => l.EndNodeID)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<Project>()
                .HasOne(p => p.ProjectManager)
                .WithMany(u => u.ManagerProjects)
                .HasForeignKey(p => p.ProjectManagerID)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            modelBuilder.Entity<Project>()
                .HasOne(p => p.ARD)
                .WithMany(u => u.ARDProjects)
                .HasForeignKey(p => p.ARDID)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            modelBuilder.Entity<Project>()
                .HasOne(p => p.FRD)
                .WithMany(u => u.FRDProjects)
                .HasForeignKey(p => p.FRDID)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
            modelBuilder.Entity<Project>()
                .HasOne(p => p.SRD)
                .WithMany(u => u.SRDProjects)
                .HasForeignKey(p => p.SRDID)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<TakeTask>()
                .HasOne(t => t.Take)
                .WithMany(tk => tk.Tasks)
                .HasForeignKey(t => t.TakeID);
            modelBuilder.Entity<TakeTask>()
                .HasOne(t => t.Task)
                .WithMany(ts=> ts.Takes)
                .HasForeignKey(t => t.TaskID);

            modelBuilder.Entity<TaskSample>()
                .HasOne(ts => ts.Task)
                .WithMany(t => t.Samples)
                .HasForeignKey(ts => ts.TaskID);
            modelBuilder.Entity<TaskSample>()
                .HasOne(ts => ts.Sample)
                .WithMany(s => s.Tasks)
                .HasForeignKey(ts => ts.SampleID);
       
            modelBuilder.Entity<LabwarePosition>().HasKey(lp => new { lp.LabwareID, lp.PositionID });
            modelBuilder.Entity<NodeDevice>().HasKey(nd => new { nd.NodeID,nd.DeviceID });
            modelBuilder.Entity<NodeLabware>().HasKey(nl => new { nl.NodeID,nl.LabwareID });
            modelBuilder.Entity<NodeProtocolStep>().HasKey(np => new { np.NodeID,np.ProtocolStepID });
            modelBuilder.Entity<NodeReagent>().HasKey(nr => new { nr.NodeID,nr.ReagentID });
            modelBuilder.Entity<ProjectTask>().HasKey(pt => new { pt.ProjectID,pt.TaskID });
            modelBuilder.Entity<ReagentPosition>().HasKey(rp => new { rp.ReagentID,rp.PositionID });
            modelBuilder.Entity<RoleMenu>().HasKey(rm => new { rm.RoleID,rm.MenuID });
            modelBuilder.Entity<SolutionReagentDosage>().HasKey(sr => new { sr.SolutionID,sr.ReagentDosageID });
            modelBuilder.Entity<SolutionSampleDosage>().HasKey(ss => new { ss.SolutionID,ss.SampleDosageID });
            modelBuilder.Entity<TakeTask>().HasKey(tt => new { tt.TakeID,tt.TaskID });
            modelBuilder.Entity<TaskLabware>().HasKey(tl => new { tl.TaskID,tl.LabwareID });
            modelBuilder.Entity<TaskReagent>().HasKey(tr => new { tr.TaskID, tr.ReagentID });
            modelBuilder.Entity<TaskSample>().HasKey(ts => new { ts.TaskID, ts.SampleID });
            modelBuilder.Entity<TaskUser>().HasKey(tu => new { tu.TaskID, tu.UserID });
            modelBuilder.Entity<UserDepartmentRole>().HasKey(u => new { u.UserID, u.DepartmentID, u.RoleID });
            modelBuilder.Entity<UserSkill>().HasKey(us => new { us.UserID, us.SkillID });

            //启用Guid主键类型扩展
            modelBuilder.HasPostgresExtension("uuid-ossp");
        }
    }
}
