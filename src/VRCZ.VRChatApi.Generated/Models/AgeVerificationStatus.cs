// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace VRCZ.VRChatApi.Generated.Models
{
    /// <summary>obsolete, use `ageVerified` instead.`ageVerificationStatus == &quot;18+&quot;` =&gt; `ageVerified == true``ageVerificationStatus != &quot;18+&quot;` =&gt; `ageVerified == false`</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum AgeVerificationStatus
    {
        [EnumMember(Value = "hidden")]
        #pragma warning disable CS1591
        Hidden,
        #pragma warning restore CS1591
        [EnumMember(Value = "verified")]
        #pragma warning disable CS1591
        Verified,
        #pragma warning restore CS1591
        [EnumMember(Value = "18+")]
        #pragma warning disable CS1591
        OneEight_plus,
        #pragma warning restore CS1591
    }
}
