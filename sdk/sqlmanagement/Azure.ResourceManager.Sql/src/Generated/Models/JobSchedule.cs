// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Scheduling properties of a job. </summary>
    public partial class JobSchedule
    {
        /// <summary> Initializes a new instance of JobSchedule. </summary>
        public JobSchedule()
        {
        }

        /// <summary> Initializes a new instance of JobSchedule. </summary>
        /// <param name="startOn"> Schedule start time. </param>
        /// <param name="endOn"> Schedule end time. </param>
        /// <param name="scheduleType"> Schedule interval type. </param>
        /// <param name="enabled"> Whether or not the schedule is enabled. </param>
        /// <param name="interval"> Value of the schedule&apos;s recurring interval, if the ScheduleType is recurring. ISO8601 duration format. </param>
        internal JobSchedule(DateTimeOffset? startOn, DateTimeOffset? endOn, JobScheduleType? scheduleType, bool? enabled, string interval)
        {
            StartOn = startOn;
            EndOn = endOn;
            ScheduleType = scheduleType;
            Enabled = enabled;
            Interval = interval;
        }

        /// <summary> Schedule start time. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> Schedule end time. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> Schedule interval type. </summary>
        public JobScheduleType? ScheduleType { get; set; }
        /// <summary> Whether or not the schedule is enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Value of the schedule&apos;s recurring interval, if the ScheduleType is recurring. ISO8601 duration format. </summary>
        public string Interval { get; set; }
    }
}
