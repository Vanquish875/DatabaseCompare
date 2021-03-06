using System;

namespace DatabaseCompare.Models
{
    public class Rate : IEquatable<Rate>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }
        public string RTU { get; set; }
        public string BaseMessage { get; set; }
        public string MinEGU { get; set; }
        public string MaxEGU { get; set; }
        public string SourceOfData { get; set; }
        public string PriorityDisplay { get; set; }
        public string SafetyRelated { get; set; }
        public string PulseInputCoordinates { get; set; }
        public string PulseInputType { get; set; }
        public string AnalogInputType { get; set; }
        public string AnalogInputCoordinates { get; set; }
        public string ConvertRawToEGU { get; set; }
        public string MinRaw { get; set; }
        public string MaxRaw { get; set; }
        public string IntegrationEGUUnits { get; set; }
        public string RateEGUUnits { get; set; }
        public string HasHiHiAlarm { get; set; }
        public string HasHiAlarm { get; set; }
        public string HasLoAlarm { get; set; }
        public string HasLoLoAlarm { get; set; }
        public string HiHiLimit { get; set; }
        public string HiLimit { get; set; }
        public string LoLimit { get; set; }
        public string LoLoLimit { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Rate);
        }

        public bool Equals(Rate other)
        {
            if (other == null)
                return false;

            return
                (
                object.ReferenceEquals(this.Name, other.Name) ||
                this.Name != null &&
                this.Name.Equals(other.Name)
                ) &&
                (
                object.ReferenceEquals(this.Description, other.Description) ||
                this.Description != null &&
                this.Description.Equals(other.Description)
                ) &&
                (
                object.ReferenceEquals(this.Group, other.Group) ||
                this.Group != null &&
                this.Group.Equals(other.Group)
                ) &&
                (
                object.ReferenceEquals(this.RTU, other.RTU) ||
                this.RTU != null &&
                this.RTU.Equals(other.RTU)
                ) &&
                (
                object.ReferenceEquals(this.BaseMessage, other.BaseMessage) ||
                this.BaseMessage != null &&
                this.BaseMessage.Equals(other.BaseMessage)
                ) &&
                (
                object.ReferenceEquals(this.MinEGU, other.MinEGU) ||
                this.MinEGU != null &&
                this.MinEGU.Equals(other.MinEGU)
                ) &&
                (
                object.ReferenceEquals(this.MaxEGU, other.MaxEGU) ||
                this.MaxEGU != null &&
                this.MaxEGU.Equals(other.MaxEGU)
                ) &&
                (
                object.ReferenceEquals(this.SourceOfData, other.SourceOfData) ||
                this.SourceOfData != null &&
                this.SourceOfData.Equals(other.SourceOfData)
                ) &&
                (
                object.ReferenceEquals(this.PriorityDisplay, other.PriorityDisplay) ||
                this.PriorityDisplay != null &&
                this.PriorityDisplay.Equals(other.PriorityDisplay)
                ) &&
                (
                object.ReferenceEquals(this.SafetyRelated, other.SafetyRelated) ||
                this.SafetyRelated != null &&
                this.SafetyRelated.Equals(other.SafetyRelated)
                ) &&
                (
                object.ReferenceEquals(this.PulseInputCoordinates, other.PulseInputCoordinates) ||
                this.PulseInputCoordinates != null &&
                this.PulseInputCoordinates.Equals(other.PulseInputCoordinates)
                ) &&
                (
                object.ReferenceEquals(this.PulseInputType, other.PulseInputType) ||
                this.PulseInputType != null &&
                this.PulseInputType.Equals(other.PulseInputType)
                ) &&
                (
                object.ReferenceEquals(this.AnalogInputType, other.AnalogInputType) ||
                this.AnalogInputType != null &&
                this.AnalogInputType.Equals(other.AnalogInputType)
                ) &&
                (
                object.ReferenceEquals(this.AnalogInputCoordinates, other.AnalogInputCoordinates) ||
                this.AnalogInputCoordinates != null &&
                this.AnalogInputCoordinates.Equals(other.AnalogInputCoordinates)
                ) &&
                (
                object.ReferenceEquals(this.ConvertRawToEGU, other.ConvertRawToEGU) ||
                this.ConvertRawToEGU != null &&
                this.ConvertRawToEGU.Equals(other.ConvertRawToEGU)
                ) &&
                (
                object.ReferenceEquals(this.MinRaw, other.MinRaw) ||
                this.MinRaw != null &&
                this.MinRaw.Equals(other.MinRaw)
                ) &&
                (
                object.ReferenceEquals(this.MaxRaw, other.MaxRaw) ||
                this.MaxRaw != null &&
                this.MaxRaw.Equals(other.MaxRaw)
                ) &&
                (
                object.ReferenceEquals(this.IntegrationEGUUnits, other.IntegrationEGUUnits) ||
                this.IntegrationEGUUnits != null &&
                this.IntegrationEGUUnits.Equals(other.IntegrationEGUUnits)
                ) &&
                (
                object.ReferenceEquals(this.RateEGUUnits, other.RateEGUUnits) ||
                this.RateEGUUnits != null &&
                this.RateEGUUnits.Equals(other.RateEGUUnits)
                ) &&
                (
                object.ReferenceEquals(this.HasHiAlarm, other.HasHiAlarm) ||
                this.HasHiAlarm != null &&
                this.HasHiAlarm.Equals(other.HasHiAlarm)
                ) &&
                (
                object.ReferenceEquals(this.HasLoAlarm, other.HasLoAlarm) ||
                this.HasLoAlarm != null &&
                this.HasLoAlarm.Equals(other.HasLoAlarm)
                ) &&
                (
                object.ReferenceEquals(this.HasLoLoAlarm, other.HasLoLoAlarm) ||
                this.HasLoLoAlarm != null &&
                this.HasLoLoAlarm.Equals(other.HasLoLoAlarm)
                ) &&
                (
                object.ReferenceEquals(this.HiHiLimit, other.HiHiLimit) ||
                this.HiHiLimit != null &&
                this.HiHiLimit.Equals(other.HiHiLimit)
                ) &&
                (
                object.ReferenceEquals(this.HiLimit, other.HiLimit) ||
                this.HiLimit != null &&
                this.HiLimit.Equals(other.HiLimit)
                ) &&
                (
                object.ReferenceEquals(this.LoLimit, other.LoLimit) ||
                this.LoLimit != null &&
                this.LoLimit.Equals(other.LoLimit)
                ) &&
                (
                object.ReferenceEquals(this.LoLoLimit, other.LoLoLimit) ||
                this.LoLoLimit != null &&
                this.LoLoLimit.Equals(other.LoLoLimit)
                );
        }
    }
}
