using System;

namespace DatabaseCompare.Models
{
    public class Status : IEquatable<Status>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }
        public string InhibitAbnormalAlarm { get; set; }
        public string InhibitNormalAlarm { get; set; }
        public string InhibitAbnormalLog { get; set; }
        public string InhibitNormalLog { get; set; }
        public string BaseMessage { get; set; }
        public string RTU { get; set; }
        public string PriorityDisplay { get; set; }
        public string SafetyRelated { get; set; }
        public string HasInput { get; set; }
        public string InputType { get; set; }
        public string AccumState { get; set; }
        public string NumberOfInputBits { get; set; }
        public string InputOneCoordinates { get; set; }
        public string InputOneBitNumber { get; set; }
        public string InputOneNormallyOpen { get; set; }
        public string InputTwoCoordinates { get; set; }
        public string InputTwoBitNumber { get; set; }
        public string InputTwoNormallyOpen { get; set; }
        public string HasOutput { get; set; }
        public string LogCMDSuccess { get; set; }
        public string CommandOnType1 { get; set; }
        public string CommandOnCmd1 { get; set; }
        public string CommandOnCmdtimeout1 { get; set; }
        public string CommandCoordinates1 { get; set; }
        public string CommandOffType2 { get; set; }
        public string CommandOffCmd2 { get; set; }
        public string CommandOffCmdtimeout2 { get; set; }
        public string CommandCoordinates2 { get; set; }
        public string SustainCOSAlarms { get; set; }
        public string AbnormalState0 { get; set; }
        public string AbnormalState1 { get; set; }
        public string AbnormalState2 { get; set; }
        public string AbnormalState3 { get; set; }
        public string PointClass { get; set; }
        public string PointSubClass { get; set; }
        public string Station { get; set; }
        public string WellUnit { get; set; }
        public string DisplayOrder { get; set; }
        public string ShortDescription { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Status);
        }

        public bool Equals(Status other)
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
                object.ReferenceEquals(this.BaseMessage, other.BaseMessage) ||
                this.BaseMessage != null &&
                this.BaseMessage.Equals(other.BaseMessage)
                ) &&
                (
                object.ReferenceEquals(this.RTU, other.RTU) ||
                this.RTU != null &&
                this.RTU.Equals(other.RTU)
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
                object.ReferenceEquals(this.HasInput, other.HasInput) ||
                this.HasInput != null &&
                this.HasInput.Equals(other.HasInput)
                ) &&
                (
                object.ReferenceEquals(this.NumberOfInputBits, other.NumberOfInputBits) ||
                this.NumberOfInputBits != null &&
                this.NumberOfInputBits.Equals(other.NumberOfInputBits)
                ) &&
                (
                object.ReferenceEquals(this.InputOneCoordinates, other.InputOneCoordinates) ||
                this.InputOneCoordinates != null &&
                this.InputOneCoordinates.Equals(other.InputOneCoordinates)
                ) &&
                (
                object.ReferenceEquals(this.InputOneBitNumber, other.InputOneBitNumber) ||
                this.InputOneBitNumber != null &&
                this.InputOneBitNumber.Equals(other.InputOneBitNumber)
                ) &&
                (
                object.ReferenceEquals(this.InputTwoCoordinates, other.InputTwoCoordinates) ||
                this.InputTwoCoordinates != null &&
                this.InputTwoCoordinates.Equals(other.InputTwoCoordinates)
                ) &&
                (
                object.ReferenceEquals(this.InputTwoBitNumber, other.InputTwoBitNumber) ||
                this.InputTwoBitNumber != null &&
                this.InputTwoBitNumber.Equals(other.InputTwoBitNumber)
                ) &&
                (
                object.ReferenceEquals(this.HasOutput, other.HasOutput) ||
                this.HasOutput != null &&
                this.HasOutput.Equals(other.HasOutput)
                ) &&
                (
                object.ReferenceEquals(this.CommandOnCmd1, other.CommandOnCmd1) ||
                this.CommandOnCmd1 != null &&
                this.CommandOnCmd1.Equals(other.CommandOnCmd1)
                ) &&
                (
                object.ReferenceEquals(this.CommandCoordinates1, other.CommandCoordinates1) ||
                this.CommandCoordinates1 != null &&
                this.CommandCoordinates1.Equals(other.CommandCoordinates1)
                ) &&
                (
                object.ReferenceEquals(this.CommandOffCmd2, other.CommandOffCmd2) ||
                this.CommandOffCmd2 != null &&
                this.CommandOffCmd2.Equals(other.CommandOffCmd2)
                ) &&
                (
                object.ReferenceEquals(this.CommandCoordinates2, other.CommandCoordinates2) ||
                this.CommandCoordinates2 != null &&
                this.CommandCoordinates2.Equals(other.CommandCoordinates2)
                );
        }
    }
}
