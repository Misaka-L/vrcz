// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace VRCZ.VRChatApi.Generated.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class FileAnalysisAvatarStats : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The animatorCount property</summary>
        public int? AnimatorCount { get; set; }
        /// <summary>The audioSourceCount property</summary>
        public int? AudioSourceCount { get; set; }
        /// <summary>The blendShapeCount property</summary>
        public int? BlendShapeCount { get; set; }
        /// <summary>The boneCount property</summary>
        public int? BoneCount { get; set; }
        /// <summary>The bounds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<double?>? Bounds { get; set; }
#nullable restore
#else
        public List<double?> Bounds { get; set; }
#endif
        /// <summary>The cameraCount property</summary>
        public int? CameraCount { get; set; }
        /// <summary>The clothCount property</summary>
        public int? ClothCount { get; set; }
        /// <summary>The constraintCount property</summary>
        public int? ConstraintCount { get; set; }
        /// <summary>The contactCount property</summary>
        public int? ContactCount { get; set; }
        /// <summary>The customExpressions property</summary>
        public bool? CustomExpressions { get; set; }
        /// <summary>The customizeAnimationLayers property</summary>
        public bool? CustomizeAnimationLayers { get; set; }
        /// <summary>The enableEyeLook property</summary>
        public bool? EnableEyeLook { get; set; }
        /// <summary>The lightCount property</summary>
        public int? LightCount { get; set; }
        /// <summary>The lineRendererCount property</summary>
        public int? LineRendererCount { get; set; }
        /// <summary>The lipSync property</summary>
        public int? LipSync { get; set; }
        /// <summary>The materialCount property</summary>
        public int? MaterialCount { get; set; }
        /// <summary>The materialSlotsUsed property</summary>
        public int? MaterialSlotsUsed { get; set; }
        /// <summary>The meshCount property</summary>
        public int? MeshCount { get; set; }
        /// <summary>The meshIndices property</summary>
        public int? MeshIndices { get; set; }
        /// <summary>The meshParticleMaxPolygons property</summary>
        public int? MeshParticleMaxPolygons { get; set; }
        /// <summary>The meshPolygons property</summary>
        public int? MeshPolygons { get; set; }
        /// <summary>The meshVertices property</summary>
        public int? MeshVertices { get; set; }
        /// <summary>The particleCollisionEnabled property</summary>
        public bool? ParticleCollisionEnabled { get; set; }
        /// <summary>The particleSystemCount property</summary>
        public int? ParticleSystemCount { get; set; }
        /// <summary>The particleTrailsEnabled property</summary>
        public bool? ParticleTrailsEnabled { get; set; }
        /// <summary>The physBoneColliderCount property</summary>
        public int? PhysBoneColliderCount { get; set; }
        /// <summary>The physBoneCollisionCheckCount property</summary>
        public int? PhysBoneCollisionCheckCount { get; set; }
        /// <summary>The physBoneComponentCount property</summary>
        public int? PhysBoneComponentCount { get; set; }
        /// <summary>The physBoneTransformCount property</summary>
        public int? PhysBoneTransformCount { get; set; }
        /// <summary>The physicsColliders property</summary>
        public int? PhysicsColliders { get; set; }
        /// <summary>The physicsRigidbodies property</summary>
        public int? PhysicsRigidbodies { get; set; }
        /// <summary>The skinnedMeshCount property</summary>
        public int? SkinnedMeshCount { get; set; }
        /// <summary>The skinnedMeshIndices property</summary>
        public int? SkinnedMeshIndices { get; set; }
        /// <summary>The skinnedMeshPolygons property</summary>
        public int? SkinnedMeshPolygons { get; set; }
        /// <summary>The skinnedMeshVertices property</summary>
        public int? SkinnedMeshVertices { get; set; }
        /// <summary>The totalClothVertices property</summary>
        public int? TotalClothVertices { get; set; }
        /// <summary>The totalIndices property</summary>
        public int? TotalIndices { get; set; }
        /// <summary>The totalMaxParticles property</summary>
        public int? TotalMaxParticles { get; set; }
        /// <summary>The totalPolygons property</summary>
        public int? TotalPolygons { get; set; }
        /// <summary>The totalTextureUsage property</summary>
        public int? TotalTextureUsage { get; set; }
        /// <summary>The totalVertices property</summary>
        public int? TotalVertices { get; set; }
        /// <summary>The trailRendererCount property</summary>
        public int? TrailRendererCount { get; set; }
        /// <summary>The writeDefaultsUsed property</summary>
        public bool? WriteDefaultsUsed { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::VRCZ.VRChatApi.Generated.Models.FileAnalysisAvatarStats"/> and sets the default values.
        /// </summary>
        public FileAnalysisAvatarStats()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::VRCZ.VRChatApi.Generated.Models.FileAnalysisAvatarStats"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::VRCZ.VRChatApi.Generated.Models.FileAnalysisAvatarStats CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::VRCZ.VRChatApi.Generated.Models.FileAnalysisAvatarStats();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "animatorCount", n => { AnimatorCount = n.GetIntValue(); } },
                { "audioSourceCount", n => { AudioSourceCount = n.GetIntValue(); } },
                { "blendShapeCount", n => { BlendShapeCount = n.GetIntValue(); } },
                { "boneCount", n => { BoneCount = n.GetIntValue(); } },
                { "bounds", n => { Bounds = n.GetCollectionOfPrimitiveValues<double?>()?.AsList(); } },
                { "cameraCount", n => { CameraCount = n.GetIntValue(); } },
                { "clothCount", n => { ClothCount = n.GetIntValue(); } },
                { "constraintCount", n => { ConstraintCount = n.GetIntValue(); } },
                { "contactCount", n => { ContactCount = n.GetIntValue(); } },
                { "customExpressions", n => { CustomExpressions = n.GetBoolValue(); } },
                { "customizeAnimationLayers", n => { CustomizeAnimationLayers = n.GetBoolValue(); } },
                { "enableEyeLook", n => { EnableEyeLook = n.GetBoolValue(); } },
                { "lightCount", n => { LightCount = n.GetIntValue(); } },
                { "lineRendererCount", n => { LineRendererCount = n.GetIntValue(); } },
                { "lipSync", n => { LipSync = n.GetIntValue(); } },
                { "materialCount", n => { MaterialCount = n.GetIntValue(); } },
                { "materialSlotsUsed", n => { MaterialSlotsUsed = n.GetIntValue(); } },
                { "meshCount", n => { MeshCount = n.GetIntValue(); } },
                { "meshIndices", n => { MeshIndices = n.GetIntValue(); } },
                { "meshParticleMaxPolygons", n => { MeshParticleMaxPolygons = n.GetIntValue(); } },
                { "meshPolygons", n => { MeshPolygons = n.GetIntValue(); } },
                { "meshVertices", n => { MeshVertices = n.GetIntValue(); } },
                { "particleCollisionEnabled", n => { ParticleCollisionEnabled = n.GetBoolValue(); } },
                { "particleSystemCount", n => { ParticleSystemCount = n.GetIntValue(); } },
                { "particleTrailsEnabled", n => { ParticleTrailsEnabled = n.GetBoolValue(); } },
                { "physBoneColliderCount", n => { PhysBoneColliderCount = n.GetIntValue(); } },
                { "physBoneCollisionCheckCount", n => { PhysBoneCollisionCheckCount = n.GetIntValue(); } },
                { "physBoneComponentCount", n => { PhysBoneComponentCount = n.GetIntValue(); } },
                { "physBoneTransformCount", n => { PhysBoneTransformCount = n.GetIntValue(); } },
                { "physicsColliders", n => { PhysicsColliders = n.GetIntValue(); } },
                { "physicsRigidbodies", n => { PhysicsRigidbodies = n.GetIntValue(); } },
                { "skinnedMeshCount", n => { SkinnedMeshCount = n.GetIntValue(); } },
                { "skinnedMeshIndices", n => { SkinnedMeshIndices = n.GetIntValue(); } },
                { "skinnedMeshPolygons", n => { SkinnedMeshPolygons = n.GetIntValue(); } },
                { "skinnedMeshVertices", n => { SkinnedMeshVertices = n.GetIntValue(); } },
                { "totalClothVertices", n => { TotalClothVertices = n.GetIntValue(); } },
                { "totalIndices", n => { TotalIndices = n.GetIntValue(); } },
                { "totalMaxParticles", n => { TotalMaxParticles = n.GetIntValue(); } },
                { "totalPolygons", n => { TotalPolygons = n.GetIntValue(); } },
                { "totalTextureUsage", n => { TotalTextureUsage = n.GetIntValue(); } },
                { "totalVertices", n => { TotalVertices = n.GetIntValue(); } },
                { "trailRendererCount", n => { TrailRendererCount = n.GetIntValue(); } },
                { "writeDefaultsUsed", n => { WriteDefaultsUsed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("animatorCount", AnimatorCount);
            writer.WriteIntValue("audioSourceCount", AudioSourceCount);
            writer.WriteIntValue("blendShapeCount", BlendShapeCount);
            writer.WriteIntValue("boneCount", BoneCount);
            writer.WriteCollectionOfPrimitiveValues<double?>("bounds", Bounds);
            writer.WriteIntValue("cameraCount", CameraCount);
            writer.WriteIntValue("clothCount", ClothCount);
            writer.WriteIntValue("constraintCount", ConstraintCount);
            writer.WriteIntValue("contactCount", ContactCount);
            writer.WriteBoolValue("customExpressions", CustomExpressions);
            writer.WriteBoolValue("customizeAnimationLayers", CustomizeAnimationLayers);
            writer.WriteBoolValue("enableEyeLook", EnableEyeLook);
            writer.WriteIntValue("lightCount", LightCount);
            writer.WriteIntValue("lineRendererCount", LineRendererCount);
            writer.WriteIntValue("lipSync", LipSync);
            writer.WriteIntValue("materialCount", MaterialCount);
            writer.WriteIntValue("materialSlotsUsed", MaterialSlotsUsed);
            writer.WriteIntValue("meshCount", MeshCount);
            writer.WriteIntValue("meshIndices", MeshIndices);
            writer.WriteIntValue("meshParticleMaxPolygons", MeshParticleMaxPolygons);
            writer.WriteIntValue("meshPolygons", MeshPolygons);
            writer.WriteIntValue("meshVertices", MeshVertices);
            writer.WriteBoolValue("particleCollisionEnabled", ParticleCollisionEnabled);
            writer.WriteIntValue("particleSystemCount", ParticleSystemCount);
            writer.WriteBoolValue("particleTrailsEnabled", ParticleTrailsEnabled);
            writer.WriteIntValue("physBoneColliderCount", PhysBoneColliderCount);
            writer.WriteIntValue("physBoneCollisionCheckCount", PhysBoneCollisionCheckCount);
            writer.WriteIntValue("physBoneComponentCount", PhysBoneComponentCount);
            writer.WriteIntValue("physBoneTransformCount", PhysBoneTransformCount);
            writer.WriteIntValue("physicsColliders", PhysicsColliders);
            writer.WriteIntValue("physicsRigidbodies", PhysicsRigidbodies);
            writer.WriteIntValue("skinnedMeshCount", SkinnedMeshCount);
            writer.WriteIntValue("skinnedMeshIndices", SkinnedMeshIndices);
            writer.WriteIntValue("skinnedMeshPolygons", SkinnedMeshPolygons);
            writer.WriteIntValue("skinnedMeshVertices", SkinnedMeshVertices);
            writer.WriteIntValue("totalClothVertices", TotalClothVertices);
            writer.WriteIntValue("totalIndices", TotalIndices);
            writer.WriteIntValue("totalMaxParticles", TotalMaxParticles);
            writer.WriteIntValue("totalPolygons", TotalPolygons);
            writer.WriteIntValue("totalTextureUsage", TotalTextureUsage);
            writer.WriteIntValue("totalVertices", TotalVertices);
            writer.WriteIntValue("trailRendererCount", TrailRendererCount);
            writer.WriteBoolValue("writeDefaultsUsed", WriteDefaultsUsed);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
