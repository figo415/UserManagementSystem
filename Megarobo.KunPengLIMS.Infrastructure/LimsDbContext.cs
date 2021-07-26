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

        public DbSet<Line> Lines { get; set; }

        public DbSet<Node> Nodes { get; set; }

        public DbSet<NodeDevice> NodeDevices { get; set; }

        public DbSet<NodeLabware> NodeLabwares { get; set; }

        public DbSet<NodeProtocolStep> NodeProtocolSteps { get; set; }

        public DbSet<NodeReagent> NodeReagents { get; set; }

        public DbSet<Process> Processes { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectTask> ProjectTasks { get; set; }

        public DbSet<ProtocolStep> ProtocolSteps { get; set; }

        public DbSet<Reagent> Reagents { get; set; }

        public DbSet<Sample> Samples { get; set; }

        public DbSet<SampleDosage> SampleDosages { get; set; }

        public DbSet<Solution> Solutions { get; set; }

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

            //modelBuilder.Entity<Project>()
            //    .HasOne(p => p.ProjectManager)
            //    .WithMany(u => u.ManagerProjects)
            //    .HasForeignKey(p => p.ProjectManagerId)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .IsRequired();
            //modelBuilder.Entity<Project>()
            //    .HasOne(p => p.ARD)
            //    .WithMany(u => u.ARDProjects)
            //    .HasForeignKey(p => p.ARDId)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .IsRequired();
            //modelBuilder.Entity<Project>()
            //    .HasOne(p => p.FRD)
            //    .WithMany(u => u.FRDProjects)
            //    .HasForeignKey(p => p.FRDId)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .IsRequired();
            //modelBuilder.Entity<Project>()
            //    .HasOne(p => p.SRD)
            //    .WithMany(u => u.SRDProjects)
            //    .HasForeignKey(p => p.SRDId)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .IsRequired();

            modelBuilder.Entity<TakeTask>()
                .HasOne(t => t.Take)
                .WithMany(tk => tk.Tasks)
                .HasForeignKey(t => t.TakeId);
            modelBuilder.Entity<TakeTask>()
                .HasOne(t => t.Task)
                .WithMany(ts=> ts.Takes)
                .HasForeignKey(t => t.TaskId);

            modelBuilder.Entity<TaskSample>()
                .HasOne(ts => ts.Task)
                .WithMany(t => t.Samples)
                .HasForeignKey(ts => ts.TaskId);
            modelBuilder.Entity<TaskSample>()
                .HasOne(ts => ts.Sample)
                .WithMany(s => s.Tasks)
                .HasForeignKey(ts => ts.SampleId);

            modelBuilder.Entity<UserDepartmentRole>().HasKey(u => new { u.UserId, u.DepartmentId, u.RoleId });
            modelBuilder.Entity<UserSkill>().HasKey(us => new { us.UserId, us.SkillId });
            modelBuilder.Entity<RoleMenu>().HasKey(rm => new { rm.RoleId, rm.MenuId });
            modelBuilder.Entity<RoleButton>().HasKey(rb => new { rb.RoleId, rb.ButtonId });
            //modelBuilder.Entity<LabwarePosition>().HasKey(lp => new { lp.LabwareId, lp.PositionId });
            //modelBuilder.Entity<ReagentPosition>().HasKey(rp => new { rp.ReagentId, rp.PositionId });
            //modelBuilder.Entity<DevicePosition>().HasKey(dp => new { dp.DeviceId, dp.PositionId });
            //modelBuilder.Entity<SamplePosition>().HasKey(sp => new { sp.SampleId, sp.PositionId });
            modelBuilder.Entity<NodeDevice>().HasKey(nd => new { nd.NodeId,nd.DeviceId });
            modelBuilder.Entity<NodeLabware>().HasKey(nl => new { nl.NodeId,nl.LabwareId });
            modelBuilder.Entity<NodeProtocolStep>().HasKey(np => new { np.NodeId,np.ProtocolStepId });
            modelBuilder.Entity<NodeReagent>().HasKey(nr => new { nr.NodeId,nr.ReagentId });
            modelBuilder.Entity<ProjectTask>().HasKey(pt => new { pt.ProjectId,pt.TaskId });
            modelBuilder.Entity<ProjectUser>().HasKey(pu => new { pu.ProjectId, pu.UserId });
            //modelBuilder.Entity<SolutionReagentDosage>().HasKey(sr => new { sr.SolutionId,sr.ReagentDosageId });
            //modelBuilder.Entity<SolutionSampleDosage>().HasKey(ss => new { ss.SolutionId,ss.SampleDosageId });
            modelBuilder.Entity<TakeTask>().HasKey(tt => new { tt.TakeId,tt.TaskId });
            modelBuilder.Entity<TaskLabware>().HasKey(tl => new { tl.TaskId,tl.LabwareId });
            modelBuilder.Entity<TaskReagent>().HasKey(tr => new { tr.TaskId, tr.ReagentId });
            modelBuilder.Entity<TaskSample>().HasKey(ts => new { ts.TaskId, ts.SampleId });
            modelBuilder.Entity<TaskUser>().HasKey(tu => new { tu.TaskId, tu.UserId });
            

            //启用Guid主键类型扩展
            modelBuilder.HasPostgresExtension("uuid-ossp");
        }
    }
}
