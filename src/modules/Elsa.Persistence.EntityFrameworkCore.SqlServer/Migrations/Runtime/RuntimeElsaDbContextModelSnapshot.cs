﻿// <auto-generated />
using System;
using Elsa.Persistence.EntityFrameworkCore.Modules.Runtime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elsa.Persistence.EntityFrameworkCore.SqlServer.Migrations.Runtime
{
    [DbContext(typeof(RuntimeElsaDbContext))]
    partial class RuntimeElsaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Elsa")
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Elsa.Workflows.Core.State.WorkflowState", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DefinitionVersion")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CorrelationId")
                        .HasDatabaseName("IX_WorkflowState_CorrelationId");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("IX_WorkflowState_CreatedAt");

                    b.HasIndex("DefinitionId")
                        .HasDatabaseName("IX_WorkflowState_DefinitionId");

                    b.HasIndex("UpdatedAt")
                        .HasDatabaseName("IX_WorkflowState_UpdatedAt");

                    b.HasIndex("Status", "DefinitionId")
                        .HasDatabaseName("IX_WorkflowState_Status_DefinitionId");

                    b.HasIndex("Status", "SubStatus")
                        .HasDatabaseName("IX_WorkflowState_Status_SubStatus");

                    b.HasIndex("Status", "SubStatus", "DefinitionId", "DefinitionVersion")
                        .HasDatabaseName("IX_WorkflowState_Status_SubStatus_DefinitionId_DefinitionVersion");

                    b.ToTable("WorkflowStates", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.StoredTrigger", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hash")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WorkflowDefinitionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Hash")
                        .HasDatabaseName("IX_StoredTrigger_Hash");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_StoredTrigger_Name");

                    b.HasIndex("WorkflowDefinitionId")
                        .HasDatabaseName("IX_StoredTrigger_WorkflowDefinitionId");

                    b.ToTable("WorkflowTriggers", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Entities.WorkflowExecutionLogRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityInstanceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentActivityInstanceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PayloadData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("Timestamp")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("WorkflowDefinitionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WorkflowVersion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityId");

                    b.HasIndex("ActivityInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityInstanceId");

                    b.HasIndex("ActivityType")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityType");

                    b.HasIndex("EventName")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_EventName");

                    b.HasIndex("ParentActivityInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ParentActivityInstanceId");

                    b.HasIndex("Timestamp")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Timestamp");

                    b.HasIndex("WorkflowDefinitionId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowDefinitionId");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowInstanceId");

                    b.HasIndex("WorkflowVersion")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowVersion");

                    b.ToTable("WorkflowExecutionLogRecords", "Elsa");
                });

            modelBuilder.Entity("Elsa.Workflows.Runtime.Models.StoredBookmark", b =>
                {
                    b.Property<string>("BookmarkId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BookmarkId");

                    b.HasIndex(new[] { "ActivityTypeName" }, "IX_StoredBookmark_ActivityTypeName");

                    b.HasIndex(new[] { "ActivityTypeName", "Hash" }, "IX_StoredBookmark_ActivityTypeName_Hash");

                    b.HasIndex(new[] { "ActivityTypeName", "Hash", "WorkflowInstanceId" }, "IX_StoredBookmark_ActivityTypeName_Hash_WorkflowInstanceId");

                    b.HasIndex(new[] { "Hash" }, "IX_StoredBookmark_Hash");

                    b.HasIndex(new[] { "WorkflowInstanceId" }, "IX_StoredBookmark_WorkflowInstanceId");

                    b.ToTable("Bookmarks", "Elsa");
                });
#pragma warning restore 612, 618
        }
    }
}
