using System;

namespace DatabaseCompare.Models
{
    public class Remote : IEquatable<Remote>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }
        public string PriorityDisplay { get; set; }
        public string Protocol { get; set; }
        public string Address { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Remote);
        }

        public bool Equals(Remote other)
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
                object.ReferenceEquals(this.PriorityDisplay, other.PriorityDisplay) ||
                this.PriorityDisplay != null &&
                this.PriorityDisplay.Equals(other.PriorityDisplay)
                ) &&
                (
                object.ReferenceEquals(this.Protocol, other.Protocol) ||
                this.Protocol != null &&
                this.Protocol.Equals(other.Protocol)
                ) &&
                (
                object.ReferenceEquals(this.Address, other.Address) ||
                this.Address != null &&
                this.Address.Equals(other.Address)
                );
        }
    }
}
