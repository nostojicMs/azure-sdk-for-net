// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> One and only one of the schedule types should be specified. Choose either 'daily', 'weekly', 'absoluteMonthly' or 'relativeMonthly' for your maintenance schedule. </summary>
    public partial class ContainerServiceMaintenanceSchedule
    {
        /// <summary> Initializes a new instance of ContainerServiceMaintenanceSchedule. </summary>
        public ContainerServiceMaintenanceSchedule()
        {
        }

        /// <summary> Initializes a new instance of ContainerServiceMaintenanceSchedule. </summary>
        /// <param name="daily"> For schedules like: 'recur every day' or 'recur every 3 days'. </param>
        /// <param name="weekly"> For schedules like: 'recur every Monday' or 'recur every 3 weeks on Wednesday'. </param>
        /// <param name="absoluteMonthly"> For schedules like: 'recur every month on the 15th' or 'recur every 3 months on the 20th'. </param>
        /// <param name="relativeMonthly"> For schedules like: 'recur every month on the first Monday' or 'recur every 3 months on last Friday'. </param>
        internal ContainerServiceMaintenanceSchedule(DailySchedule daily, ContainerServiceMaintenanceWeeklySchedule weekly, ContainerServiceMaintenanceAbsoluteMonthlySchedule absoluteMonthly, ContainerServiceMaintenanceRelativeMonthlySchedule relativeMonthly)
        {
            Daily = daily;
            Weekly = weekly;
            AbsoluteMonthly = absoluteMonthly;
            RelativeMonthly = relativeMonthly;
        }

        /// <summary> For schedules like: 'recur every day' or 'recur every 3 days'. </summary>
        internal DailySchedule Daily { get; set; }
        /// <summary> Specifies the number of days between each set of occurrences. </summary>
        public int? DailyIntervalDays
        {
            get => Daily is null ? default(int?) : Daily.IntervalDays;
            set
            {
                Daily = value.HasValue ? new DailySchedule(value.Value) : null;
            }
        }

        /// <summary> For schedules like: 'recur every Monday' or 'recur every 3 weeks on Wednesday'. </summary>
        public ContainerServiceMaintenanceWeeklySchedule Weekly { get; set; }
        /// <summary> For schedules like: 'recur every month on the 15th' or 'recur every 3 months on the 20th'. </summary>
        public ContainerServiceMaintenanceAbsoluteMonthlySchedule AbsoluteMonthly { get; set; }
        /// <summary> For schedules like: 'recur every month on the first Monday' or 'recur every 3 months on last Friday'. </summary>
        public ContainerServiceMaintenanceRelativeMonthlySchedule RelativeMonthly { get; set; }
    }
}
