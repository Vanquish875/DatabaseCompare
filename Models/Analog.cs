using System;

namespace DatabaseCompare.Models
{
    public class Analog : IEquatable<Analog>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SafetyRelated { get; set; }
        public string Group { get; set; }
        public string RTU { get; set; }
        public string OffNormalAlarm { get; set; }
        public string NormalAlarm { get; set; }
        public string OffNormalLog { get; set; }
        public string NormalLog { get; set; }
        public string BaseMessage { get; set; }
        public string EngineeringUnits { get; set; }
        public string PriorityDisplay { get; set; }
        public string PointType { get; set; }
        public string HasInput { get; set; }
        public string InputType { get; set; }
        public string InputCoordinates { get; set; }
        public string ConvertRawToEGU { get; set; }
        public string MinRaw { get; set; }
        public string MaxRaw { get; set; }
        public string MinEGU { get; set; }
        public string MaxEGU { get; set; }
        public string HasOutput { get; set; }
        public string OutputType { get; set; }
        public string OutputCoordinates { get; set; }
        public string CMDTimeout { get; set; }
        public string LogCmdSuccess { get; set; }
        public string OutConvertRawToEGU { get; set; }
        public string OutMinRaw { get; set; }
        public string OutMaxRaw { get; set; }
        public string OutMinEGU { get; set; }
        public string OutMaxEGU { get; set; }
        public string SetpointLowLimit { get; set; }
        public string SetpointHiLimit { get; set; }
        public string HasHiHiLimit { get; set; }
        public string HasHiLimit { get; set; }
        public string HasLoLimit { get; set; }
        public string HasLoLoLimit { get; set; }
        public string HiHiLimit { get; set; }
        public string HiLimit { get; set; }
        public string LoLimit { get; set; }
        public string LoLoLimit { get; set; }
        public string PointClass { get; set; }
        public string PointSubClass { get; set; }
        public string Station { get; set; }
        public string ShortDesc { get; set; }
        public string WellUnit { get; set; }
        public string DisplayOrder { get; set; }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Analog);
        }

        public bool Equals(Analog other)
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
                object.ReferenceEquals(this.SafetyRelated, other.SafetyRelated) ||
                this.SafetyRelated != null &&
                this.SafetyRelated.Equals(other.SafetyRelated)
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
                object.ReferenceEquals(this.EngineeringUnits, other.EngineeringUnits) ||
                this.EngineeringUnits != null &&
                this.EngineeringUnits.Equals(other.EngineeringUnits)
                ) &&
                (
                object.ReferenceEquals(this.PriorityDisplay, other.PriorityDisplay) ||
                this.PriorityDisplay != null &&
                this.PriorityDisplay.Equals(other.PriorityDisplay)
                ) &&
                (
                object.ReferenceEquals(this.HasInput, other.HasInput) ||
                this.HasInput != null &&
                this.HasInput.Equals(other.HasInput)
                ) &&
                (
                object.ReferenceEquals(this.InputType, other.InputType) ||
                this.InputType != null &&
                this.InputType.Equals(other.InputType)
                ) &&
                (
                object.ReferenceEquals(this.InputCoordinates, other.InputCoordinates) ||
                this.InputCoordinates != null &&
                this.InputCoordinates.Equals(other.InputCoordinates)
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
                object.ReferenceEquals(this.HasOutput, other.HasOutput) ||
                this.HasOutput != null &&
                this.HasOutput.Equals(other.HasOutput)
                ) &&
                (
                object.ReferenceEquals(this.OutputType, other.OutputType) ||
                this.OutputType != null &&
                this.OutputType.Equals(other.OutputType)
                ) &&
                (
                object.ReferenceEquals(this.OutputCoordinates, other.OutputCoordinates) ||
                this.OutputCoordinates != null &&
                this.OutputCoordinates.Equals(other.OutputCoordinates)
                ) &&
                (
                object.ReferenceEquals(this.OutConvertRawToEGU, other.OutConvertRawToEGU) ||
                this.OutConvertRawToEGU != null &&
                this.OutConvertRawToEGU.Equals(other.OutConvertRawToEGU)
                ) &&
                (
                object.ReferenceEquals(this.OutMinRaw, other.OutMinRaw) ||
                this.OutMinRaw != null &&
                this.OutMinRaw.Equals(other.OutMinRaw)
                ) &&
                (
                object.ReferenceEquals(this.OutMaxRaw, other.OutMaxRaw) ||
                this.OutMaxRaw != null &&
                this.OutMaxRaw.Equals(other.OutMaxRaw)
                ) &&
                (
                object.ReferenceEquals(this.OutMinEGU, other.OutMinEGU) ||
                this.OutMinEGU != null &&
                this.OutMinEGU.Equals(other.OutMinEGU)
                ) &&
                (
                object.ReferenceEquals(this.OutMaxEGU, other.OutMaxEGU) ||
                this.OutMaxEGU != null &&
                this.OutMaxEGU.Equals(other.OutMaxEGU)
                ) &&
                (
                object.ReferenceEquals(this.SetpointLowLimit, other.SetpointLowLimit) ||
                this.SetpointLowLimit != null &&
                this.SetpointLowLimit.Equals(other.SetpointLowLimit)
                ) &&
                (
                object.ReferenceEquals(this.SetpointHiLimit, other.SetpointHiLimit) ||
                this.SetpointHiLimit != null &&
                this.SetpointHiLimit.Equals(other.SetpointHiLimit)
                ) &&
                (
                object.ReferenceEquals(this.HasHiHiLimit, other.HasHiHiLimit) ||
                this.HasHiHiLimit != null &&
                this.HasHiHiLimit.Equals(other.HasHiHiLimit)
                ) &&
                (
                object.ReferenceEquals(this.HasHiLimit, other.HasHiLimit) ||
                this.HasHiLimit != null &&
                this.HasHiLimit.Equals(other.HasHiLimit)
                ) &&
                (
                object.ReferenceEquals(this.HasLoLimit, other.HasLoLimit) ||
                this.HasLoLimit != null &&
                this.HasLoLimit.Equals(other.HasLoLimit)
                ) &&
                (
                object.ReferenceEquals(this.HasLoLoLimit, other.HasLoLoLimit) ||
                this.HasLoLoLimit != null &&
                this.HasLoLoLimit.Equals(other.HasLoLoLimit)
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
