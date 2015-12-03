using System;

namespace Problem_3.Generic_List.Attributes
{

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct |
        AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = false)]

    public class VersionAttribute : Attribute
    {
        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version { get; set; }
    }
}