// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Recurrence schedule definition. </summary>
    public partial class RecurrenceSchedule : ScheduleBase
    {
        /// <summary> Initializes a new instance of RecurrenceSchedule. </summary>
        /// <param name="frequency"> [Required] Specifies frequency with with which to trigger schedule. </param>
        /// <param name="interval"> [Required] Specifies schedule interval in conjunction with frequency. </param>
        public RecurrenceSchedule(RecurrenceFrequency frequency, int interval)
        {
            Frequency = frequency;
            Interval = interval;
            ScheduleType = ScheduleType.Recurrence;
        }

        /// <summary> Initializes a new instance of RecurrenceSchedule. </summary>
        /// <param name="endOn">
        /// Specifies end time of schedule in ISO 8601 format.
        /// If not present, the schedule will run indefinitely
        /// </param>
        /// <param name="scheduleStatus"> Specifies the schedule&apos;s status. </param>
        /// <param name="scheduleType"> [Required] Specifies the schedule type. </param>
        /// <param name="startOn"> Specifies start time of schedule in ISO 8601 format. </param>
        /// <param name="timeZone">
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format.
        /// </param>
        /// <param name="frequency"> [Required] Specifies frequency with with which to trigger schedule. </param>
        /// <param name="interval"> [Required] Specifies schedule interval in conjunction with frequency. </param>
        /// <param name="pattern"> Specifies the recurrence schedule pattern. </param>
        internal RecurrenceSchedule(DateTimeOffset? endOn, ScheduleStatus? scheduleStatus, ScheduleType scheduleType, DateTimeOffset? startOn, string timeZone, RecurrenceFrequency frequency, int interval, RecurrencePattern pattern) : base(endOn, scheduleStatus, scheduleType, startOn, timeZone)
        {
            Frequency = frequency;
            Interval = interval;
            Pattern = pattern;
            ScheduleType = scheduleType;
        }

        /// <summary> [Required] Specifies frequency with with which to trigger schedule. </summary>
        public RecurrenceFrequency Frequency { get; set; }
        /// <summary> [Required] Specifies schedule interval in conjunction with frequency. </summary>
        public int Interval { get; set; }
        /// <summary> Specifies the recurrence schedule pattern. </summary>
        public RecurrencePattern Pattern { get; set; }
    }
}
