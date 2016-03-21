using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
	unsafe public class Offset2D
	{
		internal Interop.Offset2D* m;

		public Offset2D ()
		{
			m = (Interop.Offset2D*) Interop.Structure.Allocate (typeof (Interop.Offset2D));
		}

		public Int32 X {
			get { return m->X; }
			set { m->X = value; }
		}

		public Int32 Y {
			get { return m->Y; }
			set { m->Y = value; }
		}
	}

	unsafe public class Offset3D
	{
		internal Interop.Offset3D* m;

		public Offset3D ()
		{
			m = (Interop.Offset3D*) Interop.Structure.Allocate (typeof (Interop.Offset3D));
		}

		public Int32 X {
			get { return m->X; }
			set { m->X = value; }
		}

		public Int32 Y {
			get { return m->Y; }
			set { m->Y = value; }
		}

		public Int32 Z {
			get { return m->Z; }
			set { m->Z = value; }
		}
	}

	unsafe public class Extent2D
	{
		internal Interop.Extent2D* m;

		public Extent2D ()
		{
			m = (Interop.Extent2D*) Interop.Structure.Allocate (typeof (Interop.Extent2D));
		}

		public UInt32 Width {
			get { return m->Width; }
			set { m->Width = value; }
		}

		public UInt32 Height {
			get { return m->Height; }
			set { m->Height = value; }
		}
	}

	unsafe public class Extent3D
	{
		internal Interop.Extent3D* m;

		public Extent3D ()
		{
			m = (Interop.Extent3D*) Interop.Structure.Allocate (typeof (Interop.Extent3D));
		}

		public UInt32 Width {
			get { return m->Width; }
			set { m->Width = value; }
		}

		public UInt32 Height {
			get { return m->Height; }
			set { m->Height = value; }
		}

		public UInt32 Depth {
			get { return m->Depth; }
			set { m->Depth = value; }
		}
	}

	unsafe public class Viewport
	{
		internal Interop.Viewport* m;

		public Viewport ()
		{
			m = (Interop.Viewport*) Interop.Structure.Allocate (typeof (Interop.Viewport));
		}

		public float X {
			get { return m->X; }
			set { m->X = value; }
		}

		public float Y {
			get { return m->Y; }
			set { m->Y = value; }
		}

		public float Width {
			get { return m->Width; }
			set { m->Width = value; }
		}

		public float Height {
			get { return m->Height; }
			set { m->Height = value; }
		}

		public float MinDepth {
			get { return m->MinDepth; }
			set { m->MinDepth = value; }
		}

		public float MaxDepth {
			get { return m->MaxDepth; }
			set { m->MaxDepth = value; }
		}
	}

	unsafe public class Rect2D
	{
		internal Interop.Rect2D* m;

		public Rect2D ()
		{
			m = (Interop.Rect2D*) Interop.Structure.Allocate (typeof (Interop.Rect2D));
		}

		Offset2D lOffset;
		public Offset2D Offset {
			get { return lOffset; }
			set { lOffset = value; m->Offset = (IntPtr) value.m; }
		}

		Extent2D lExtent;
		public Extent2D Extent {
			get { return lExtent; }
			set { lExtent = value; m->Extent = (IntPtr) value.m; }
		}
	}

	unsafe public class Rect3D
	{
		internal Interop.Rect3D* m;

		public Rect3D ()
		{
			m = (Interop.Rect3D*) Interop.Structure.Allocate (typeof (Interop.Rect3D));
		}

		Offset3D lOffset;
		public Offset3D Offset {
			get { return lOffset; }
			set { lOffset = value; m->Offset = (IntPtr) value.m; }
		}

		Extent3D lExtent;
		public Extent3D Extent {
			get { return lExtent; }
			set { lExtent = value; m->Extent = (IntPtr) value.m; }
		}
	}

	unsafe public class ClearRect
	{
		internal Interop.ClearRect* m;

		public ClearRect ()
		{
			m = (Interop.ClearRect*) Interop.Structure.Allocate (typeof (Interop.ClearRect));
		}

		Rect2D lRect;
		public Rect2D Rect {
			get { return lRect; }
			set { lRect = value; m->Rect = (IntPtr) value.m; }
		}

		public UInt32 BaseArrayLayer {
			get { return m->BaseArrayLayer; }
			set { m->BaseArrayLayer = value; }
		}

		public UInt32 LayerCount {
			get { return m->LayerCount; }
			set { m->LayerCount = value; }
		}
	}

	unsafe public class ComponentMapping
	{
		internal Interop.ComponentMapping* m;

		public ComponentMapping ()
		{
			m = (Interop.ComponentMapping*) Interop.Structure.Allocate (typeof (Interop.ComponentMapping));
		}

		public ComponentSwizzle R {
			get { return m->R; }
			set { m->R = value; }
		}

		public ComponentSwizzle G {
			get { return m->G; }
			set { m->G = value; }
		}

		public ComponentSwizzle B {
			get { return m->B; }
			set { m->B = value; }
		}

		public ComponentSwizzle A {
			get { return m->A; }
			set { m->A = value; }
		}
	}

	unsafe public class PhysicalDeviceProperties
	{
		internal Interop.PhysicalDeviceProperties* m;

		public PhysicalDeviceProperties ()
		{
			m = (Interop.PhysicalDeviceProperties*) Interop.Structure.Allocate (typeof (Interop.PhysicalDeviceProperties));
		}

		public UInt32 ApiVersion {
			get { return m->ApiVersion; }
			set { m->ApiVersion = value; }
		}

		public UInt32 DriverVersion {
			get { return m->DriverVersion; }
			set { m->DriverVersion = value; }
		}

		public UInt32 VendorID {
			get { return m->VendorID; }
			set { m->VendorID = value; }
		}

		public UInt32 DeviceID {
			get { return m->DeviceID; }
			set { m->DeviceID = value; }
		}

		public PhysicalDeviceType DeviceType {
			get { return m->DeviceType; }
			set { m->DeviceType = value; }
		}

		public char DeviceName {
			get { return m->DeviceName; }
			set { m->DeviceName = value; }
		}

		public Byte PipelineCacheUUID {
			get { return m->PipelineCacheUUID; }
			set { m->PipelineCacheUUID = value; }
		}

		PhysicalDeviceLimits lLimits;
		public PhysicalDeviceLimits Limits {
			get { return lLimits; }
			set { lLimits = value; m->Limits = (IntPtr) value.m; }
		}

		PhysicalDeviceSparseProperties lSparseProperties;
		public PhysicalDeviceSparseProperties SparseProperties {
			get { return lSparseProperties; }
			set { lSparseProperties = value; m->SparseProperties = (IntPtr) value.m; }
		}
	}

	unsafe public class ExtensionProperties
	{
		internal Interop.ExtensionProperties* m;

		public ExtensionProperties ()
		{
			m = (Interop.ExtensionProperties*) Interop.Structure.Allocate (typeof (Interop.ExtensionProperties));
		}

		public char ExtensionName {
			get { return m->ExtensionName; }
			set { m->ExtensionName = value; }
		}

		public UInt32 SpecVersion {
			get { return m->SpecVersion; }
			set { m->SpecVersion = value; }
		}
	}

	unsafe public class LayerProperties
	{
		internal Interop.LayerProperties* m;

		public LayerProperties ()
		{
			m = (Interop.LayerProperties*) Interop.Structure.Allocate (typeof (Interop.LayerProperties));
		}

		public char LayerName {
			get { return m->LayerName; }
			set { m->LayerName = value; }
		}

		public UInt32 SpecVersion {
			get { return m->SpecVersion; }
			set { m->SpecVersion = value; }
		}

		public UInt32 ImplementationVersion {
			get { return m->ImplementationVersion; }
			set { m->ImplementationVersion = value; }
		}

		public char Description {
			get { return m->Description; }
			set { m->Description = value; }
		}
	}

	unsafe public class ApplicationInfo
	{
		internal Interop.ApplicationInfo* m;

		public ApplicationInfo ()
		{
			m = (Interop.ApplicationInfo*) Interop.Structure.Allocate (typeof (Interop.ApplicationInfo));
			m->SType = StructureType.ApplicationInfo;
		}

		public string ApplicationName {
			get { return Marshal.PtrToStringAnsi (m->ApplicationName); }
			set { m->ApplicationName = Marshal.StringToHGlobalAnsi (value); }
		}

		public UInt32 ApplicationVersion {
			get { return m->ApplicationVersion; }
			set { m->ApplicationVersion = value; }
		}

		public string EngineName {
			get { return Marshal.PtrToStringAnsi (m->EngineName); }
			set { m->EngineName = Marshal.StringToHGlobalAnsi (value); }
		}

		public UInt32 EngineVersion {
			get { return m->EngineVersion; }
			set { m->EngineVersion = value; }
		}

		public UInt32 ApiVersion {
			get { return m->ApiVersion; }
			set { m->ApiVersion = value; }
		}
	}

	unsafe public class AllocationCallbacks
	{
		internal Interop.AllocationCallbacks* m;

		public AllocationCallbacks ()
		{
			m = (Interop.AllocationCallbacks*) Interop.Structure.Allocate (typeof (Interop.AllocationCallbacks));
		}

		public IntPtr UserData {
			get { return m->UserData; }
			set { m->UserData = value; }
		}

		public IntPtr PfnAllocation {
			get { return m->PfnAllocation; }
			set { m->PfnAllocation = value; }
		}

		public IntPtr PfnReallocation {
			get { return m->PfnReallocation; }
			set { m->PfnReallocation = value; }
		}

		public IntPtr PfnFree {
			get { return m->PfnFree; }
			set { m->PfnFree = value; }
		}

		public IntPtr PfnInternalAllocation {
			get { return m->PfnInternalAllocation; }
			set { m->PfnInternalAllocation = value; }
		}

		public IntPtr PfnInternalFree {
			get { return m->PfnInternalFree; }
			set { m->PfnInternalFree = value; }
		}
	}

	unsafe public class DeviceQueueCreateInfo
	{
		internal Interop.DeviceQueueCreateInfo* m;

		public DeviceQueueCreateInfo ()
		{
			m = (Interop.DeviceQueueCreateInfo*) Interop.Structure.Allocate (typeof (Interop.DeviceQueueCreateInfo));
			m->SType = StructureType.DeviceQueueCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 QueueFamilyIndex {
			get { return m->QueueFamilyIndex; }
			set { m->QueueFamilyIndex = value; }
		}

		public UInt32 QueueCount {
			get { return m->QueueCount; }
			set { m->QueueCount = value; }
		}

		public float QueuePriorities {
			get { return m->QueuePriorities; }
			set { m->QueuePriorities = value; }
		}
	}

	unsafe public class DeviceCreateInfo
	{
		internal Interop.DeviceCreateInfo* m;

		public DeviceCreateInfo ()
		{
			m = (Interop.DeviceCreateInfo*) Interop.Structure.Allocate (typeof (Interop.DeviceCreateInfo));
			m->SType = StructureType.DeviceCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 QueueCreateInfoCount {
			get { return m->QueueCreateInfoCount; }
			set { m->QueueCreateInfoCount = value; }
		}

		DeviceQueueCreateInfo lQueueCreateInfos;
		public DeviceQueueCreateInfo QueueCreateInfos {
			get { return lQueueCreateInfos; }
			set { lQueueCreateInfos = value; m->QueueCreateInfos = (IntPtr) value.m; }
		}

		public UInt32 EnabledLayerCount {
			get { return m->EnabledLayerCount; }
			set { m->EnabledLayerCount = value; }
		}

		public string PEnabledLayerNames {
			get { return Marshal.PtrToStringAnsi (m->PEnabledLayerNames); }
			set { m->PEnabledLayerNames = Marshal.StringToHGlobalAnsi (value); }
		}

		public UInt32 EnabledExtensionCount {
			get { return m->EnabledExtensionCount; }
			set { m->EnabledExtensionCount = value; }
		}

		public string PEnabledExtensionNames {
			get { return Marshal.PtrToStringAnsi (m->PEnabledExtensionNames); }
			set { m->PEnabledExtensionNames = Marshal.StringToHGlobalAnsi (value); }
		}

		PhysicalDeviceFeatures lEnabledFeatures;
		public PhysicalDeviceFeatures EnabledFeatures {
			get { return lEnabledFeatures; }
			set { lEnabledFeatures = value; m->EnabledFeatures = (IntPtr) value.m; }
		}
	}

	unsafe public class InstanceCreateInfo
	{
		internal Interop.InstanceCreateInfo* m;

		public InstanceCreateInfo ()
		{
			m = (Interop.InstanceCreateInfo*) Interop.Structure.Allocate (typeof (Interop.InstanceCreateInfo));
			m->SType = StructureType.InstanceCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		ApplicationInfo lApplicationInfo;
		public ApplicationInfo ApplicationInfo {
			get { return lApplicationInfo; }
			set { lApplicationInfo = value; m->ApplicationInfo = (IntPtr) value.m; }
		}

		public UInt32 EnabledLayerCount {
			get { return m->EnabledLayerCount; }
			set { m->EnabledLayerCount = value; }
		}

		public string PEnabledLayerNames {
			get { return Marshal.PtrToStringAnsi (m->PEnabledLayerNames); }
			set { m->PEnabledLayerNames = Marshal.StringToHGlobalAnsi (value); }
		}

		public UInt32 EnabledExtensionCount {
			get { return m->EnabledExtensionCount; }
			set { m->EnabledExtensionCount = value; }
		}

		public string PEnabledExtensionNames {
			get { return Marshal.PtrToStringAnsi (m->PEnabledExtensionNames); }
			set { m->PEnabledExtensionNames = Marshal.StringToHGlobalAnsi (value); }
		}
	}

	unsafe public class QueueFamilyProperties
	{
		internal Interop.QueueFamilyProperties* m;

		public QueueFamilyProperties ()
		{
			m = (Interop.QueueFamilyProperties*) Interop.Structure.Allocate (typeof (Interop.QueueFamilyProperties));
		}

		public UInt32 QueueFlags {
			get { return m->QueueFlags; }
			set { m->QueueFlags = value; }
		}

		public UInt32 QueueCount {
			get { return m->QueueCount; }
			set { m->QueueCount = value; }
		}

		public UInt32 TimestampValidBits {
			get { return m->TimestampValidBits; }
			set { m->TimestampValidBits = value; }
		}

		Extent3D lMinImageTransferGranularity;
		public Extent3D MinImageTransferGranularity {
			get { return lMinImageTransferGranularity; }
			set { lMinImageTransferGranularity = value; m->MinImageTransferGranularity = (IntPtr) value.m; }
		}
	}

	unsafe public class PhysicalDeviceMemoryProperties
	{
		internal Interop.PhysicalDeviceMemoryProperties* m;

		public PhysicalDeviceMemoryProperties ()
		{
			m = (Interop.PhysicalDeviceMemoryProperties*) Interop.Structure.Allocate (typeof (Interop.PhysicalDeviceMemoryProperties));
		}

		public UInt32 MemoryTypeCount {
			get { return m->MemoryTypeCount; }
			set { m->MemoryTypeCount = value; }
		}

		MemoryType lMemoryTypes;
		public MemoryType MemoryTypes {
			get { return lMemoryTypes; }
			set { lMemoryTypes = value; m->MemoryTypes = (IntPtr) value.m; }
		}

		public UInt32 MemoryHeapCount {
			get { return m->MemoryHeapCount; }
			set { m->MemoryHeapCount = value; }
		}

		MemoryHeap lMemoryHeaps;
		public MemoryHeap MemoryHeaps {
			get { return lMemoryHeaps; }
			set { lMemoryHeaps = value; m->MemoryHeaps = (IntPtr) value.m; }
		}
	}

	unsafe public class MemoryAllocateInfo
	{
		internal Interop.MemoryAllocateInfo* m;

		public MemoryAllocateInfo ()
		{
			m = (Interop.MemoryAllocateInfo*) Interop.Structure.Allocate (typeof (Interop.MemoryAllocateInfo));
			m->SType = StructureType.MemoryAllocateInfo;
		}

		public DeviceSize AllocationSize {
			get { return m->AllocationSize; }
			set { m->AllocationSize = value; }
		}

		public UInt32 MemoryTypeIndex {
			get { return m->MemoryTypeIndex; }
			set { m->MemoryTypeIndex = value; }
		}
	}

	unsafe public class MemoryRequirements
	{
		internal Interop.MemoryRequirements* m;

		public MemoryRequirements ()
		{
			m = (Interop.MemoryRequirements*) Interop.Structure.Allocate (typeof (Interop.MemoryRequirements));
		}

		public DeviceSize Size {
			get { return m->Size; }
			set { m->Size = value; }
		}

		public DeviceSize Alignment {
			get { return m->Alignment; }
			set { m->Alignment = value; }
		}

		public UInt32 MemoryTypeBits {
			get { return m->MemoryTypeBits; }
			set { m->MemoryTypeBits = value; }
		}
	}

	unsafe public class SparseImageFormatProperties
	{
		internal Interop.SparseImageFormatProperties* m;

		public SparseImageFormatProperties ()
		{
			m = (Interop.SparseImageFormatProperties*) Interop.Structure.Allocate (typeof (Interop.SparseImageFormatProperties));
		}

		public UInt32 AspectMask {
			get { return m->AspectMask; }
			set { m->AspectMask = value; }
		}

		Extent3D lImageGranularity;
		public Extent3D ImageGranularity {
			get { return lImageGranularity; }
			set { lImageGranularity = value; m->ImageGranularity = (IntPtr) value.m; }
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}
	}

	unsafe public class SparseImageMemoryRequirements
	{
		internal Interop.SparseImageMemoryRequirements* m;

		public SparseImageMemoryRequirements ()
		{
			m = (Interop.SparseImageMemoryRequirements*) Interop.Structure.Allocate (typeof (Interop.SparseImageMemoryRequirements));
		}

		SparseImageFormatProperties lFormatProperties;
		public SparseImageFormatProperties FormatProperties {
			get { return lFormatProperties; }
			set { lFormatProperties = value; m->FormatProperties = (IntPtr) value.m; }
		}

		public UInt32 ImageMipTailFirstLod {
			get { return m->ImageMipTailFirstLod; }
			set { m->ImageMipTailFirstLod = value; }
		}

		public DeviceSize ImageMipTailSize {
			get { return m->ImageMipTailSize; }
			set { m->ImageMipTailSize = value; }
		}

		public DeviceSize ImageMipTailOffset {
			get { return m->ImageMipTailOffset; }
			set { m->ImageMipTailOffset = value; }
		}

		public DeviceSize ImageMipTailStride {
			get { return m->ImageMipTailStride; }
			set { m->ImageMipTailStride = value; }
		}
	}

	unsafe public class MemoryType
	{
		internal Interop.MemoryType* m;

		public MemoryType ()
		{
			m = (Interop.MemoryType*) Interop.Structure.Allocate (typeof (Interop.MemoryType));
		}

		public UInt32 PropertyFlags {
			get { return m->PropertyFlags; }
			set { m->PropertyFlags = value; }
		}

		public UInt32 HeapIndex {
			get { return m->HeapIndex; }
			set { m->HeapIndex = value; }
		}
	}

	unsafe public class MemoryHeap
	{
		internal Interop.MemoryHeap* m;

		public MemoryHeap ()
		{
			m = (Interop.MemoryHeap*) Interop.Structure.Allocate (typeof (Interop.MemoryHeap));
		}

		public DeviceSize Size {
			get { return m->Size; }
			set { m->Size = value; }
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}
	}

	unsafe public class MappedMemoryRange
	{
		internal Interop.MappedMemoryRange* m;

		public MappedMemoryRange ()
		{
			m = (Interop.MappedMemoryRange*) Interop.Structure.Allocate (typeof (Interop.MappedMemoryRange));
			m->SType = StructureType.MappedMemoryRange;
		}

		DeviceMemory lMemory;
		public DeviceMemory Memory {
			get { return lMemory; }
			set { lMemory = value; m->Memory = (IntPtr) value.m; }
		}

		public DeviceSize Offset {
			get { return m->Offset; }
			set { m->Offset = value; }
		}

		public DeviceSize Size {
			get { return m->Size; }
			set { m->Size = value; }
		}
	}

	unsafe public class FormatProperties
	{
		internal Interop.FormatProperties* m;

		public FormatProperties ()
		{
			m = (Interop.FormatProperties*) Interop.Structure.Allocate (typeof (Interop.FormatProperties));
		}

		public UInt32 LinearTilingFeatures {
			get { return m->LinearTilingFeatures; }
			set { m->LinearTilingFeatures = value; }
		}

		public UInt32 OptimalTilingFeatures {
			get { return m->OptimalTilingFeatures; }
			set { m->OptimalTilingFeatures = value; }
		}

		public UInt32 BufferFeatures {
			get { return m->BufferFeatures; }
			set { m->BufferFeatures = value; }
		}
	}

	unsafe public class ImageFormatProperties
	{
		internal Interop.ImageFormatProperties* m;

		public ImageFormatProperties ()
		{
			m = (Interop.ImageFormatProperties*) Interop.Structure.Allocate (typeof (Interop.ImageFormatProperties));
		}

		Extent3D lMaxExtent;
		public Extent3D MaxExtent {
			get { return lMaxExtent; }
			set { lMaxExtent = value; m->MaxExtent = (IntPtr) value.m; }
		}

		public UInt32 MaxMipLevels {
			get { return m->MaxMipLevels; }
			set { m->MaxMipLevels = value; }
		}

		public UInt32 MaxArrayLayers {
			get { return m->MaxArrayLayers; }
			set { m->MaxArrayLayers = value; }
		}

		public UInt32 SampleCounts {
			get { return m->SampleCounts; }
			set { m->SampleCounts = value; }
		}

		public DeviceSize MaxResourceSize {
			get { return m->MaxResourceSize; }
			set { m->MaxResourceSize = value; }
		}
	}

	unsafe public class DescriptorBufferInfo
	{
		internal Interop.DescriptorBufferInfo* m;

		public DescriptorBufferInfo ()
		{
			m = (Interop.DescriptorBufferInfo*) Interop.Structure.Allocate (typeof (Interop.DescriptorBufferInfo));
		}

		Buffer lBuffer;
		public Buffer Buffer {
			get { return lBuffer; }
			set { lBuffer = value; m->Buffer = (IntPtr) value.m; }
		}

		public DeviceSize Offset {
			get { return m->Offset; }
			set { m->Offset = value; }
		}

		public DeviceSize Range {
			get { return m->Range; }
			set { m->Range = value; }
		}
	}

	unsafe public class DescriptorImageInfo
	{
		internal Interop.DescriptorImageInfo* m;

		public DescriptorImageInfo ()
		{
			m = (Interop.DescriptorImageInfo*) Interop.Structure.Allocate (typeof (Interop.DescriptorImageInfo));
		}

		Sampler lSampler;
		public Sampler Sampler {
			get { return lSampler; }
			set { lSampler = value; m->Sampler = (IntPtr) value.m; }
		}

		ImageView lImageView;
		public ImageView ImageView {
			get { return lImageView; }
			set { lImageView = value; m->ImageView = (IntPtr) value.m; }
		}

		public ImageLayout ImageLayout {
			get { return m->ImageLayout; }
			set { m->ImageLayout = value; }
		}
	}

	unsafe public class WriteDescriptorSet
	{
		internal Interop.WriteDescriptorSet* m;

		public WriteDescriptorSet ()
		{
			m = (Interop.WriteDescriptorSet*) Interop.Structure.Allocate (typeof (Interop.WriteDescriptorSet));
			m->SType = StructureType.WriteDescriptorSet;
		}

		DescriptorSet lDstSet;
		public DescriptorSet DstSet {
			get { return lDstSet; }
			set { lDstSet = value; m->DstSet = (IntPtr) value.m; }
		}

		public UInt32 DstBinding {
			get { return m->DstBinding; }
			set { m->DstBinding = value; }
		}

		public UInt32 DstArrayElement {
			get { return m->DstArrayElement; }
			set { m->DstArrayElement = value; }
		}

		public UInt32 DescriptorCount {
			get { return m->DescriptorCount; }
			set { m->DescriptorCount = value; }
		}

		public DescriptorType DescriptorType {
			get { return m->DescriptorType; }
			set { m->DescriptorType = value; }
		}

		DescriptorImageInfo lImageInfo;
		public DescriptorImageInfo ImageInfo {
			get { return lImageInfo; }
			set { lImageInfo = value; m->ImageInfo = (IntPtr) value.m; }
		}

		DescriptorBufferInfo lBufferInfo;
		public DescriptorBufferInfo BufferInfo {
			get { return lBufferInfo; }
			set { lBufferInfo = value; m->BufferInfo = (IntPtr) value.m; }
		}

		BufferView lTexelBufferView;
		public BufferView TexelBufferView {
			get { return lTexelBufferView; }
			set { lTexelBufferView = value; m->TexelBufferView = (IntPtr) value.m; }
		}
	}

	unsafe public class CopyDescriptorSet
	{
		internal Interop.CopyDescriptorSet* m;

		public CopyDescriptorSet ()
		{
			m = (Interop.CopyDescriptorSet*) Interop.Structure.Allocate (typeof (Interop.CopyDescriptorSet));
			m->SType = StructureType.CopyDescriptorSet;
		}

		DescriptorSet lSrcSet;
		public DescriptorSet SrcSet {
			get { return lSrcSet; }
			set { lSrcSet = value; m->SrcSet = (IntPtr) value.m; }
		}

		public UInt32 SrcBinding {
			get { return m->SrcBinding; }
			set { m->SrcBinding = value; }
		}

		public UInt32 SrcArrayElement {
			get { return m->SrcArrayElement; }
			set { m->SrcArrayElement = value; }
		}

		DescriptorSet lDstSet;
		public DescriptorSet DstSet {
			get { return lDstSet; }
			set { lDstSet = value; m->DstSet = (IntPtr) value.m; }
		}

		public UInt32 DstBinding {
			get { return m->DstBinding; }
			set { m->DstBinding = value; }
		}

		public UInt32 DstArrayElement {
			get { return m->DstArrayElement; }
			set { m->DstArrayElement = value; }
		}

		public UInt32 DescriptorCount {
			get { return m->DescriptorCount; }
			set { m->DescriptorCount = value; }
		}
	}

	unsafe public class BufferCreateInfo
	{
		internal Interop.BufferCreateInfo* m;

		public BufferCreateInfo ()
		{
			m = (Interop.BufferCreateInfo*) Interop.Structure.Allocate (typeof (Interop.BufferCreateInfo));
			m->SType = StructureType.BufferCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public DeviceSize Size {
			get { return m->Size; }
			set { m->Size = value; }
		}

		public UInt32 Usage {
			get { return m->Usage; }
			set { m->Usage = value; }
		}

		public SharingMode SharingMode {
			get { return m->SharingMode; }
			set { m->SharingMode = value; }
		}

		public UInt32 QueueFamilyIndexCount {
			get { return m->QueueFamilyIndexCount; }
			set { m->QueueFamilyIndexCount = value; }
		}

		public UInt32 QueueFamilyIndices {
			get { return m->QueueFamilyIndices; }
			set { m->QueueFamilyIndices = value; }
		}
	}

	unsafe public class BufferViewCreateInfo
	{
		internal Interop.BufferViewCreateInfo* m;

		public BufferViewCreateInfo ()
		{
			m = (Interop.BufferViewCreateInfo*) Interop.Structure.Allocate (typeof (Interop.BufferViewCreateInfo));
			m->SType = StructureType.BufferViewCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		Buffer lBuffer;
		public Buffer Buffer {
			get { return lBuffer; }
			set { lBuffer = value; m->Buffer = (IntPtr) value.m; }
		}

		public Format Format {
			get { return m->Format; }
			set { m->Format = value; }
		}

		public DeviceSize Offset {
			get { return m->Offset; }
			set { m->Offset = value; }
		}

		public DeviceSize Range {
			get { return m->Range; }
			set { m->Range = value; }
		}
	}

	unsafe public class ImageSubresource
	{
		internal Interop.ImageSubresource* m;

		public ImageSubresource ()
		{
			m = (Interop.ImageSubresource*) Interop.Structure.Allocate (typeof (Interop.ImageSubresource));
		}

		public UInt32 AspectMask {
			get { return m->AspectMask; }
			set { m->AspectMask = value; }
		}

		public UInt32 MipLevel {
			get { return m->MipLevel; }
			set { m->MipLevel = value; }
		}

		public UInt32 ArrayLayer {
			get { return m->ArrayLayer; }
			set { m->ArrayLayer = value; }
		}
	}

	unsafe public class ImageSubresourceLayers
	{
		internal Interop.ImageSubresourceLayers* m;

		public ImageSubresourceLayers ()
		{
			m = (Interop.ImageSubresourceLayers*) Interop.Structure.Allocate (typeof (Interop.ImageSubresourceLayers));
		}

		public UInt32 AspectMask {
			get { return m->AspectMask; }
			set { m->AspectMask = value; }
		}

		public UInt32 MipLevel {
			get { return m->MipLevel; }
			set { m->MipLevel = value; }
		}

		public UInt32 BaseArrayLayer {
			get { return m->BaseArrayLayer; }
			set { m->BaseArrayLayer = value; }
		}

		public UInt32 LayerCount {
			get { return m->LayerCount; }
			set { m->LayerCount = value; }
		}
	}

	unsafe public class ImageSubresourceRange
	{
		internal Interop.ImageSubresourceRange* m;

		public ImageSubresourceRange ()
		{
			m = (Interop.ImageSubresourceRange*) Interop.Structure.Allocate (typeof (Interop.ImageSubresourceRange));
		}

		public UInt32 AspectMask {
			get { return m->AspectMask; }
			set { m->AspectMask = value; }
		}

		public UInt32 BaseMipLevel {
			get { return m->BaseMipLevel; }
			set { m->BaseMipLevel = value; }
		}

		public UInt32 LevelCount {
			get { return m->LevelCount; }
			set { m->LevelCount = value; }
		}

		public UInt32 BaseArrayLayer {
			get { return m->BaseArrayLayer; }
			set { m->BaseArrayLayer = value; }
		}

		public UInt32 LayerCount {
			get { return m->LayerCount; }
			set { m->LayerCount = value; }
		}
	}

	unsafe public class MemoryBarrier
	{
		internal Interop.MemoryBarrier* m;

		public MemoryBarrier ()
		{
			m = (Interop.MemoryBarrier*) Interop.Structure.Allocate (typeof (Interop.MemoryBarrier));
			m->SType = StructureType.MemoryBarrier;
		}

		public UInt32 SrcAccessMask {
			get { return m->SrcAccessMask; }
			set { m->SrcAccessMask = value; }
		}

		public UInt32 DstAccessMask {
			get { return m->DstAccessMask; }
			set { m->DstAccessMask = value; }
		}
	}

	unsafe public class BufferMemoryBarrier
	{
		internal Interop.BufferMemoryBarrier* m;

		public BufferMemoryBarrier ()
		{
			m = (Interop.BufferMemoryBarrier*) Interop.Structure.Allocate (typeof (Interop.BufferMemoryBarrier));
			m->SType = StructureType.BufferMemoryBarrier;
		}

		public UInt32 SrcAccessMask {
			get { return m->SrcAccessMask; }
			set { m->SrcAccessMask = value; }
		}

		public UInt32 DstAccessMask {
			get { return m->DstAccessMask; }
			set { m->DstAccessMask = value; }
		}

		public UInt32 SrcQueueFamilyIndex {
			get { return m->SrcQueueFamilyIndex; }
			set { m->SrcQueueFamilyIndex = value; }
		}

		public UInt32 DstQueueFamilyIndex {
			get { return m->DstQueueFamilyIndex; }
			set { m->DstQueueFamilyIndex = value; }
		}

		Buffer lBuffer;
		public Buffer Buffer {
			get { return lBuffer; }
			set { lBuffer = value; m->Buffer = (IntPtr) value.m; }
		}

		public DeviceSize Offset {
			get { return m->Offset; }
			set { m->Offset = value; }
		}

		public DeviceSize Size {
			get { return m->Size; }
			set { m->Size = value; }
		}
	}

	unsafe public class ImageMemoryBarrier
	{
		internal Interop.ImageMemoryBarrier* m;

		public ImageMemoryBarrier ()
		{
			m = (Interop.ImageMemoryBarrier*) Interop.Structure.Allocate (typeof (Interop.ImageMemoryBarrier));
			m->SType = StructureType.ImageMemoryBarrier;
		}

		public UInt32 SrcAccessMask {
			get { return m->SrcAccessMask; }
			set { m->SrcAccessMask = value; }
		}

		public UInt32 DstAccessMask {
			get { return m->DstAccessMask; }
			set { m->DstAccessMask = value; }
		}

		public ImageLayout OldLayout {
			get { return m->OldLayout; }
			set { m->OldLayout = value; }
		}

		public ImageLayout NewLayout {
			get { return m->NewLayout; }
			set { m->NewLayout = value; }
		}

		public UInt32 SrcQueueFamilyIndex {
			get { return m->SrcQueueFamilyIndex; }
			set { m->SrcQueueFamilyIndex = value; }
		}

		public UInt32 DstQueueFamilyIndex {
			get { return m->DstQueueFamilyIndex; }
			set { m->DstQueueFamilyIndex = value; }
		}

		Image lImage;
		public Image Image {
			get { return lImage; }
			set { lImage = value; m->Image = (IntPtr) value.m; }
		}

		ImageSubresourceRange lSubresourceRange;
		public ImageSubresourceRange SubresourceRange {
			get { return lSubresourceRange; }
			set { lSubresourceRange = value; m->SubresourceRange = (IntPtr) value.m; }
		}
	}

	unsafe public class ImageCreateInfo
	{
		internal Interop.ImageCreateInfo* m;

		public ImageCreateInfo ()
		{
			m = (Interop.ImageCreateInfo*) Interop.Structure.Allocate (typeof (Interop.ImageCreateInfo));
			m->SType = StructureType.ImageCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public ImageType ImageType {
			get { return m->ImageType; }
			set { m->ImageType = value; }
		}

		public Format Format {
			get { return m->Format; }
			set { m->Format = value; }
		}

		Extent3D lExtent;
		public Extent3D Extent {
			get { return lExtent; }
			set { lExtent = value; m->Extent = (IntPtr) value.m; }
		}

		public UInt32 MipLevels {
			get { return m->MipLevels; }
			set { m->MipLevels = value; }
		}

		public UInt32 ArrayLayers {
			get { return m->ArrayLayers; }
			set { m->ArrayLayers = value; }
		}

		public UInt32 Samples {
			get { return m->Samples; }
			set { m->Samples = value; }
		}

		public ImageTiling Tiling {
			get { return m->Tiling; }
			set { m->Tiling = value; }
		}

		public UInt32 Usage {
			get { return m->Usage; }
			set { m->Usage = value; }
		}

		public SharingMode SharingMode {
			get { return m->SharingMode; }
			set { m->SharingMode = value; }
		}

		public UInt32 QueueFamilyIndexCount {
			get { return m->QueueFamilyIndexCount; }
			set { m->QueueFamilyIndexCount = value; }
		}

		public UInt32 QueueFamilyIndices {
			get { return m->QueueFamilyIndices; }
			set { m->QueueFamilyIndices = value; }
		}

		public ImageLayout InitialLayout {
			get { return m->InitialLayout; }
			set { m->InitialLayout = value; }
		}
	}

	unsafe public class SubresourceLayout
	{
		internal Interop.SubresourceLayout* m;

		public SubresourceLayout ()
		{
			m = (Interop.SubresourceLayout*) Interop.Structure.Allocate (typeof (Interop.SubresourceLayout));
		}

		public DeviceSize Offset {
			get { return m->Offset; }
			set { m->Offset = value; }
		}

		public DeviceSize Size {
			get { return m->Size; }
			set { m->Size = value; }
		}

		public DeviceSize RowPitch {
			get { return m->RowPitch; }
			set { m->RowPitch = value; }
		}

		public DeviceSize ArrayPitch {
			get { return m->ArrayPitch; }
			set { m->ArrayPitch = value; }
		}

		public DeviceSize DepthPitch {
			get { return m->DepthPitch; }
			set { m->DepthPitch = value; }
		}
	}

	unsafe public class ImageViewCreateInfo
	{
		internal Interop.ImageViewCreateInfo* m;

		public ImageViewCreateInfo ()
		{
			m = (Interop.ImageViewCreateInfo*) Interop.Structure.Allocate (typeof (Interop.ImageViewCreateInfo));
			m->SType = StructureType.ImageViewCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		Image lImage;
		public Image Image {
			get { return lImage; }
			set { lImage = value; m->Image = (IntPtr) value.m; }
		}

		public ImageViewType ViewType {
			get { return m->ViewType; }
			set { m->ViewType = value; }
		}

		public Format Format {
			get { return m->Format; }
			set { m->Format = value; }
		}

		ComponentMapping lComponents;
		public ComponentMapping Components {
			get { return lComponents; }
			set { lComponents = value; m->Components = (IntPtr) value.m; }
		}

		ImageSubresourceRange lSubresourceRange;
		public ImageSubresourceRange SubresourceRange {
			get { return lSubresourceRange; }
			set { lSubresourceRange = value; m->SubresourceRange = (IntPtr) value.m; }
		}
	}

	unsafe public class BufferCopy
	{
		internal Interop.BufferCopy* m;

		public BufferCopy ()
		{
			m = (Interop.BufferCopy*) Interop.Structure.Allocate (typeof (Interop.BufferCopy));
		}

		public DeviceSize SrcOffset {
			get { return m->SrcOffset; }
			set { m->SrcOffset = value; }
		}

		public DeviceSize DstOffset {
			get { return m->DstOffset; }
			set { m->DstOffset = value; }
		}

		public DeviceSize Size {
			get { return m->Size; }
			set { m->Size = value; }
		}
	}

	unsafe public class SparseMemoryBind
	{
		internal Interop.SparseMemoryBind* m;

		public SparseMemoryBind ()
		{
			m = (Interop.SparseMemoryBind*) Interop.Structure.Allocate (typeof (Interop.SparseMemoryBind));
		}

		public DeviceSize ResourceOffset {
			get { return m->ResourceOffset; }
			set { m->ResourceOffset = value; }
		}

		public DeviceSize Size {
			get { return m->Size; }
			set { m->Size = value; }
		}

		DeviceMemory lMemory;
		public DeviceMemory Memory {
			get { return lMemory; }
			set { lMemory = value; m->Memory = (IntPtr) value.m; }
		}

		public DeviceSize MemoryOffset {
			get { return m->MemoryOffset; }
			set { m->MemoryOffset = value; }
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}
	}

	unsafe public class SparseImageMemoryBind
	{
		internal Interop.SparseImageMemoryBind* m;

		public SparseImageMemoryBind ()
		{
			m = (Interop.SparseImageMemoryBind*) Interop.Structure.Allocate (typeof (Interop.SparseImageMemoryBind));
		}

		ImageSubresource lSubresource;
		public ImageSubresource Subresource {
			get { return lSubresource; }
			set { lSubresource = value; m->Subresource = (IntPtr) value.m; }
		}

		Offset3D lOffset;
		public Offset3D Offset {
			get { return lOffset; }
			set { lOffset = value; m->Offset = (IntPtr) value.m; }
		}

		Extent3D lExtent;
		public Extent3D Extent {
			get { return lExtent; }
			set { lExtent = value; m->Extent = (IntPtr) value.m; }
		}

		DeviceMemory lMemory;
		public DeviceMemory Memory {
			get { return lMemory; }
			set { lMemory = value; m->Memory = (IntPtr) value.m; }
		}

		public DeviceSize MemoryOffset {
			get { return m->MemoryOffset; }
			set { m->MemoryOffset = value; }
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}
	}

	unsafe public class SparseBufferMemoryBindInfo
	{
		internal Interop.SparseBufferMemoryBindInfo* m;

		public SparseBufferMemoryBindInfo ()
		{
			m = (Interop.SparseBufferMemoryBindInfo*) Interop.Structure.Allocate (typeof (Interop.SparseBufferMemoryBindInfo));
		}

		Buffer lBuffer;
		public Buffer Buffer {
			get { return lBuffer; }
			set { lBuffer = value; m->Buffer = (IntPtr) value.m; }
		}

		public UInt32 BindCount {
			get { return m->BindCount; }
			set { m->BindCount = value; }
		}

		SparseMemoryBind lBinds;
		public SparseMemoryBind Binds {
			get { return lBinds; }
			set { lBinds = value; m->Binds = (IntPtr) value.m; }
		}
	}

	unsafe public class SparseImageOpaqueMemoryBindInfo
	{
		internal Interop.SparseImageOpaqueMemoryBindInfo* m;

		public SparseImageOpaqueMemoryBindInfo ()
		{
			m = (Interop.SparseImageOpaqueMemoryBindInfo*) Interop.Structure.Allocate (typeof (Interop.SparseImageOpaqueMemoryBindInfo));
		}

		Image lImage;
		public Image Image {
			get { return lImage; }
			set { lImage = value; m->Image = (IntPtr) value.m; }
		}

		public UInt32 BindCount {
			get { return m->BindCount; }
			set { m->BindCount = value; }
		}

		SparseMemoryBind lBinds;
		public SparseMemoryBind Binds {
			get { return lBinds; }
			set { lBinds = value; m->Binds = (IntPtr) value.m; }
		}
	}

	unsafe public class SparseImageMemoryBindInfo
	{
		internal Interop.SparseImageMemoryBindInfo* m;

		public SparseImageMemoryBindInfo ()
		{
			m = (Interop.SparseImageMemoryBindInfo*) Interop.Structure.Allocate (typeof (Interop.SparseImageMemoryBindInfo));
		}

		Image lImage;
		public Image Image {
			get { return lImage; }
			set { lImage = value; m->Image = (IntPtr) value.m; }
		}

		public UInt32 BindCount {
			get { return m->BindCount; }
			set { m->BindCount = value; }
		}

		SparseImageMemoryBind lBinds;
		public SparseImageMemoryBind Binds {
			get { return lBinds; }
			set { lBinds = value; m->Binds = (IntPtr) value.m; }
		}
	}

	unsafe public class BindSparseInfo
	{
		internal Interop.BindSparseInfo* m;

		public BindSparseInfo ()
		{
			m = (Interop.BindSparseInfo*) Interop.Structure.Allocate (typeof (Interop.BindSparseInfo));
			m->SType = StructureType.BindSparseInfo;
		}

		public UInt32 WaitSemaphoreCount {
			get { return m->WaitSemaphoreCount; }
			set { m->WaitSemaphoreCount = value; }
		}

		Semaphore lWaitSemaphores;
		public Semaphore WaitSemaphores {
			get { return lWaitSemaphores; }
			set { lWaitSemaphores = value; m->WaitSemaphores = (IntPtr) value.m; }
		}

		public UInt32 BufferBindCount {
			get { return m->BufferBindCount; }
			set { m->BufferBindCount = value; }
		}

		SparseBufferMemoryBindInfo lBufferBinds;
		public SparseBufferMemoryBindInfo BufferBinds {
			get { return lBufferBinds; }
			set { lBufferBinds = value; m->BufferBinds = (IntPtr) value.m; }
		}

		public UInt32 ImageOpaqueBindCount {
			get { return m->ImageOpaqueBindCount; }
			set { m->ImageOpaqueBindCount = value; }
		}

		SparseImageOpaqueMemoryBindInfo lImageOpaqueBinds;
		public SparseImageOpaqueMemoryBindInfo ImageOpaqueBinds {
			get { return lImageOpaqueBinds; }
			set { lImageOpaqueBinds = value; m->ImageOpaqueBinds = (IntPtr) value.m; }
		}

		public UInt32 ImageBindCount {
			get { return m->ImageBindCount; }
			set { m->ImageBindCount = value; }
		}

		SparseImageMemoryBindInfo lImageBinds;
		public SparseImageMemoryBindInfo ImageBinds {
			get { return lImageBinds; }
			set { lImageBinds = value; m->ImageBinds = (IntPtr) value.m; }
		}

		public UInt32 SignalSemaphoreCount {
			get { return m->SignalSemaphoreCount; }
			set { m->SignalSemaphoreCount = value; }
		}

		Semaphore lSignalSemaphores;
		public Semaphore SignalSemaphores {
			get { return lSignalSemaphores; }
			set { lSignalSemaphores = value; m->SignalSemaphores = (IntPtr) value.m; }
		}
	}

	unsafe public class ImageCopy
	{
		internal Interop.ImageCopy* m;

		public ImageCopy ()
		{
			m = (Interop.ImageCopy*) Interop.Structure.Allocate (typeof (Interop.ImageCopy));
		}

		ImageSubresourceLayers lSrcSubresource;
		public ImageSubresourceLayers SrcSubresource {
			get { return lSrcSubresource; }
			set { lSrcSubresource = value; m->SrcSubresource = (IntPtr) value.m; }
		}

		Offset3D lSrcOffset;
		public Offset3D SrcOffset {
			get { return lSrcOffset; }
			set { lSrcOffset = value; m->SrcOffset = (IntPtr) value.m; }
		}

		ImageSubresourceLayers lDstSubresource;
		public ImageSubresourceLayers DstSubresource {
			get { return lDstSubresource; }
			set { lDstSubresource = value; m->DstSubresource = (IntPtr) value.m; }
		}

		Offset3D lDstOffset;
		public Offset3D DstOffset {
			get { return lDstOffset; }
			set { lDstOffset = value; m->DstOffset = (IntPtr) value.m; }
		}

		Extent3D lExtent;
		public Extent3D Extent {
			get { return lExtent; }
			set { lExtent = value; m->Extent = (IntPtr) value.m; }
		}
	}

	unsafe public class ImageBlit
	{
		internal Interop.ImageBlit* m;

		public ImageBlit ()
		{
			m = (Interop.ImageBlit*) Interop.Structure.Allocate (typeof (Interop.ImageBlit));
		}

		ImageSubresourceLayers lSrcSubresource;
		public ImageSubresourceLayers SrcSubresource {
			get { return lSrcSubresource; }
			set { lSrcSubresource = value; m->SrcSubresource = (IntPtr) value.m; }
		}

		Offset3D lSrcOffsets;
		public Offset3D SrcOffsets {
			get { return lSrcOffsets; }
			set { lSrcOffsets = value; m->SrcOffsets = (IntPtr) value.m; }
		}

		ImageSubresourceLayers lDstSubresource;
		public ImageSubresourceLayers DstSubresource {
			get { return lDstSubresource; }
			set { lDstSubresource = value; m->DstSubresource = (IntPtr) value.m; }
		}

		Offset3D lDstOffsets;
		public Offset3D DstOffsets {
			get { return lDstOffsets; }
			set { lDstOffsets = value; m->DstOffsets = (IntPtr) value.m; }
		}
	}

	unsafe public class BufferImageCopy
	{
		internal Interop.BufferImageCopy* m;

		public BufferImageCopy ()
		{
			m = (Interop.BufferImageCopy*) Interop.Structure.Allocate (typeof (Interop.BufferImageCopy));
		}

		public DeviceSize BufferOffset {
			get { return m->BufferOffset; }
			set { m->BufferOffset = value; }
		}

		public UInt32 BufferRowLength {
			get { return m->BufferRowLength; }
			set { m->BufferRowLength = value; }
		}

		public UInt32 BufferImageHeight {
			get { return m->BufferImageHeight; }
			set { m->BufferImageHeight = value; }
		}

		ImageSubresourceLayers lImageSubresource;
		public ImageSubresourceLayers ImageSubresource {
			get { return lImageSubresource; }
			set { lImageSubresource = value; m->ImageSubresource = (IntPtr) value.m; }
		}

		Offset3D lImageOffset;
		public Offset3D ImageOffset {
			get { return lImageOffset; }
			set { lImageOffset = value; m->ImageOffset = (IntPtr) value.m; }
		}

		Extent3D lImageExtent;
		public Extent3D ImageExtent {
			get { return lImageExtent; }
			set { lImageExtent = value; m->ImageExtent = (IntPtr) value.m; }
		}
	}

	unsafe public class ImageResolve
	{
		internal Interop.ImageResolve* m;

		public ImageResolve ()
		{
			m = (Interop.ImageResolve*) Interop.Structure.Allocate (typeof (Interop.ImageResolve));
		}

		ImageSubresourceLayers lSrcSubresource;
		public ImageSubresourceLayers SrcSubresource {
			get { return lSrcSubresource; }
			set { lSrcSubresource = value; m->SrcSubresource = (IntPtr) value.m; }
		}

		Offset3D lSrcOffset;
		public Offset3D SrcOffset {
			get { return lSrcOffset; }
			set { lSrcOffset = value; m->SrcOffset = (IntPtr) value.m; }
		}

		ImageSubresourceLayers lDstSubresource;
		public ImageSubresourceLayers DstSubresource {
			get { return lDstSubresource; }
			set { lDstSubresource = value; m->DstSubresource = (IntPtr) value.m; }
		}

		Offset3D lDstOffset;
		public Offset3D DstOffset {
			get { return lDstOffset; }
			set { lDstOffset = value; m->DstOffset = (IntPtr) value.m; }
		}

		Extent3D lExtent;
		public Extent3D Extent {
			get { return lExtent; }
			set { lExtent = value; m->Extent = (IntPtr) value.m; }
		}
	}

	unsafe public class ShaderModuleCreateInfo
	{
		internal Interop.ShaderModuleCreateInfo* m;

		public ShaderModuleCreateInfo ()
		{
			m = (Interop.ShaderModuleCreateInfo*) Interop.Structure.Allocate (typeof (Interop.ShaderModuleCreateInfo));
			m->SType = StructureType.ShaderModuleCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UIntPtr CodeSize {
			get { return m->CodeSize; }
			set { m->CodeSize = value; }
		}

		public UInt32 Code {
			get { return m->Code; }
			set { m->Code = value; }
		}
	}

	unsafe public class DescriptorSetLayoutBinding
	{
		internal Interop.DescriptorSetLayoutBinding* m;

		public DescriptorSetLayoutBinding ()
		{
			m = (Interop.DescriptorSetLayoutBinding*) Interop.Structure.Allocate (typeof (Interop.DescriptorSetLayoutBinding));
		}

		public UInt32 Binding {
			get { return m->Binding; }
			set { m->Binding = value; }
		}

		public DescriptorType DescriptorType {
			get { return m->DescriptorType; }
			set { m->DescriptorType = value; }
		}

		public UInt32 DescriptorCount {
			get { return m->DescriptorCount; }
			set { m->DescriptorCount = value; }
		}

		public UInt32 StageFlags {
			get { return m->StageFlags; }
			set { m->StageFlags = value; }
		}

		Sampler lImmutableSamplers;
		public Sampler ImmutableSamplers {
			get { return lImmutableSamplers; }
			set { lImmutableSamplers = value; m->ImmutableSamplers = (IntPtr) value.m; }
		}
	}

	unsafe public class DescriptorSetLayoutCreateInfo
	{
		internal Interop.DescriptorSetLayoutCreateInfo* m;

		public DescriptorSetLayoutCreateInfo ()
		{
			m = (Interop.DescriptorSetLayoutCreateInfo*) Interop.Structure.Allocate (typeof (Interop.DescriptorSetLayoutCreateInfo));
			m->SType = StructureType.DescriptorSetLayoutCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 BindingCount {
			get { return m->BindingCount; }
			set { m->BindingCount = value; }
		}

		DescriptorSetLayoutBinding lBindings;
		public DescriptorSetLayoutBinding Bindings {
			get { return lBindings; }
			set { lBindings = value; m->Bindings = (IntPtr) value.m; }
		}
	}

	unsafe public class DescriptorPoolSize
	{
		internal Interop.DescriptorPoolSize* m;

		public DescriptorPoolSize ()
		{
			m = (Interop.DescriptorPoolSize*) Interop.Structure.Allocate (typeof (Interop.DescriptorPoolSize));
		}

		public DescriptorType Type {
			get { return m->Type; }
			set { m->Type = value; }
		}

		public UInt32 DescriptorCount {
			get { return m->DescriptorCount; }
			set { m->DescriptorCount = value; }
		}
	}

	unsafe public class DescriptorPoolCreateInfo
	{
		internal Interop.DescriptorPoolCreateInfo* m;

		public DescriptorPoolCreateInfo ()
		{
			m = (Interop.DescriptorPoolCreateInfo*) Interop.Structure.Allocate (typeof (Interop.DescriptorPoolCreateInfo));
			m->SType = StructureType.DescriptorPoolCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 MaxSets {
			get { return m->MaxSets; }
			set { m->MaxSets = value; }
		}

		public UInt32 PoolSizeCount {
			get { return m->PoolSizeCount; }
			set { m->PoolSizeCount = value; }
		}

		DescriptorPoolSize lPoolSizes;
		public DescriptorPoolSize PoolSizes {
			get { return lPoolSizes; }
			set { lPoolSizes = value; m->PoolSizes = (IntPtr) value.m; }
		}
	}

	unsafe public class DescriptorSetAllocateInfo
	{
		internal Interop.DescriptorSetAllocateInfo* m;

		public DescriptorSetAllocateInfo ()
		{
			m = (Interop.DescriptorSetAllocateInfo*) Interop.Structure.Allocate (typeof (Interop.DescriptorSetAllocateInfo));
			m->SType = StructureType.DescriptorSetAllocateInfo;
		}

		DescriptorPool lDescriptorPool;
		public DescriptorPool DescriptorPool {
			get { return lDescriptorPool; }
			set { lDescriptorPool = value; m->DescriptorPool = (IntPtr) value.m; }
		}

		public UInt32 DescriptorSetCount {
			get { return m->DescriptorSetCount; }
			set { m->DescriptorSetCount = value; }
		}

		DescriptorSetLayout lSetLayouts;
		public DescriptorSetLayout SetLayouts {
			get { return lSetLayouts; }
			set { lSetLayouts = value; m->SetLayouts = (IntPtr) value.m; }
		}
	}

	unsafe public class SpecializationMapEntry
	{
		internal Interop.SpecializationMapEntry* m;

		public SpecializationMapEntry ()
		{
			m = (Interop.SpecializationMapEntry*) Interop.Structure.Allocate (typeof (Interop.SpecializationMapEntry));
		}

		public UInt32 ConstantID {
			get { return m->ConstantID; }
			set { m->ConstantID = value; }
		}

		public UInt32 Offset {
			get { return m->Offset; }
			set { m->Offset = value; }
		}

		public UIntPtr Size {
			get { return m->Size; }
			set { m->Size = value; }
		}
	}

	unsafe public class SpecializationInfo
	{
		internal Interop.SpecializationInfo* m;

		public SpecializationInfo ()
		{
			m = (Interop.SpecializationInfo*) Interop.Structure.Allocate (typeof (Interop.SpecializationInfo));
		}

		public UInt32 MapEntryCount {
			get { return m->MapEntryCount; }
			set { m->MapEntryCount = value; }
		}

		SpecializationMapEntry lMapEntries;
		public SpecializationMapEntry MapEntries {
			get { return lMapEntries; }
			set { lMapEntries = value; m->MapEntries = (IntPtr) value.m; }
		}

		public UIntPtr DataSize {
			get { return m->DataSize; }
			set { m->DataSize = value; }
		}

		public IntPtr Data {
			get { return m->Data; }
			set { m->Data = value; }
		}
	}

	unsafe public class PipelineShaderStageCreateInfo
	{
		internal Interop.PipelineShaderStageCreateInfo* m;

		public PipelineShaderStageCreateInfo ()
		{
			m = (Interop.PipelineShaderStageCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineShaderStageCreateInfo));
			m->SType = StructureType.PipelineShaderStageCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 Stage {
			get { return m->Stage; }
			set { m->Stage = value; }
		}

		ShaderModule lModule;
		public ShaderModule Module {
			get { return lModule; }
			set { lModule = value; m->Module = (IntPtr) value.m; }
		}

		public string Name {
			get { return Marshal.PtrToStringAnsi (m->Name); }
			set { m->Name = Marshal.StringToHGlobalAnsi (value); }
		}

		SpecializationInfo lSpecializationInfo;
		public SpecializationInfo SpecializationInfo {
			get { return lSpecializationInfo; }
			set { lSpecializationInfo = value; m->SpecializationInfo = (IntPtr) value.m; }
		}
	}

	unsafe public class ComputePipelineCreateInfo
	{
		internal Interop.ComputePipelineCreateInfo* m;

		public ComputePipelineCreateInfo ()
		{
			m = (Interop.ComputePipelineCreateInfo*) Interop.Structure.Allocate (typeof (Interop.ComputePipelineCreateInfo));
			m->SType = StructureType.ComputePipelineCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		PipelineShaderStageCreateInfo lStage;
		public PipelineShaderStageCreateInfo Stage {
			get { return lStage; }
			set { lStage = value; m->Stage = (IntPtr) value.m; }
		}

		PipelineLayout lLayout;
		public PipelineLayout Layout {
			get { return lLayout; }
			set { lLayout = value; m->Layout = (IntPtr) value.m; }
		}

		Pipeline lBasePipelineHandle;
		public Pipeline BasePipelineHandle {
			get { return lBasePipelineHandle; }
			set { lBasePipelineHandle = value; m->BasePipelineHandle = (IntPtr) value.m; }
		}

		public Int32 BasePipelineIndex {
			get { return m->BasePipelineIndex; }
			set { m->BasePipelineIndex = value; }
		}
	}

	unsafe public class VertexInputBindingDescription
	{
		internal Interop.VertexInputBindingDescription* m;

		public VertexInputBindingDescription ()
		{
			m = (Interop.VertexInputBindingDescription*) Interop.Structure.Allocate (typeof (Interop.VertexInputBindingDescription));
		}

		public UInt32 Binding {
			get { return m->Binding; }
			set { m->Binding = value; }
		}

		public UInt32 Stride {
			get { return m->Stride; }
			set { m->Stride = value; }
		}

		public VertexInputRate InputRate {
			get { return m->InputRate; }
			set { m->InputRate = value; }
		}
	}

	unsafe public class VertexInputAttributeDescription
	{
		internal Interop.VertexInputAttributeDescription* m;

		public VertexInputAttributeDescription ()
		{
			m = (Interop.VertexInputAttributeDescription*) Interop.Structure.Allocate (typeof (Interop.VertexInputAttributeDescription));
		}

		public UInt32 Location {
			get { return m->Location; }
			set { m->Location = value; }
		}

		public UInt32 Binding {
			get { return m->Binding; }
			set { m->Binding = value; }
		}

		public Format Format {
			get { return m->Format; }
			set { m->Format = value; }
		}

		public UInt32 Offset {
			get { return m->Offset; }
			set { m->Offset = value; }
		}
	}

	unsafe public class PipelineVertexInputStateCreateInfo
	{
		internal Interop.PipelineVertexInputStateCreateInfo* m;

		public PipelineVertexInputStateCreateInfo ()
		{
			m = (Interop.PipelineVertexInputStateCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineVertexInputStateCreateInfo));
			m->SType = StructureType.PipelineVertexInputStateCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 VertexBindingDescriptionCount {
			get { return m->VertexBindingDescriptionCount; }
			set { m->VertexBindingDescriptionCount = value; }
		}

		VertexInputBindingDescription lVertexBindingDescriptions;
		public VertexInputBindingDescription VertexBindingDescriptions {
			get { return lVertexBindingDescriptions; }
			set { lVertexBindingDescriptions = value; m->VertexBindingDescriptions = (IntPtr) value.m; }
		}

		public UInt32 VertexAttributeDescriptionCount {
			get { return m->VertexAttributeDescriptionCount; }
			set { m->VertexAttributeDescriptionCount = value; }
		}

		VertexInputAttributeDescription lVertexAttributeDescriptions;
		public VertexInputAttributeDescription VertexAttributeDescriptions {
			get { return lVertexAttributeDescriptions; }
			set { lVertexAttributeDescriptions = value; m->VertexAttributeDescriptions = (IntPtr) value.m; }
		}
	}

	unsafe public class PipelineInputAssemblyStateCreateInfo
	{
		internal Interop.PipelineInputAssemblyStateCreateInfo* m;

		public PipelineInputAssemblyStateCreateInfo ()
		{
			m = (Interop.PipelineInputAssemblyStateCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineInputAssemblyStateCreateInfo));
			m->SType = StructureType.PipelineInputAssemblyStateCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public PrimitiveTopology Topology {
			get { return m->Topology; }
			set { m->Topology = value; }
		}

		public bool PrimitiveRestartEnable {
			get { return m->PrimitiveRestartEnable; }
			set { m->PrimitiveRestartEnable = value; }
		}
	}

	unsafe public class PipelineTessellationStateCreateInfo
	{
		internal Interop.PipelineTessellationStateCreateInfo* m;

		public PipelineTessellationStateCreateInfo ()
		{
			m = (Interop.PipelineTessellationStateCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineTessellationStateCreateInfo));
			m->SType = StructureType.PipelineTessellationStateCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 PatchControlPoints {
			get { return m->PatchControlPoints; }
			set { m->PatchControlPoints = value; }
		}
	}

	unsafe public class PipelineViewportStateCreateInfo
	{
		internal Interop.PipelineViewportStateCreateInfo* m;

		public PipelineViewportStateCreateInfo ()
		{
			m = (Interop.PipelineViewportStateCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineViewportStateCreateInfo));
			m->SType = StructureType.PipelineViewportStateCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 ViewportCount {
			get { return m->ViewportCount; }
			set { m->ViewportCount = value; }
		}

		Viewport lViewports;
		public Viewport Viewports {
			get { return lViewports; }
			set { lViewports = value; m->Viewports = (IntPtr) value.m; }
		}

		public UInt32 ScissorCount {
			get { return m->ScissorCount; }
			set { m->ScissorCount = value; }
		}

		Rect2D lScissors;
		public Rect2D Scissors {
			get { return lScissors; }
			set { lScissors = value; m->Scissors = (IntPtr) value.m; }
		}
	}

	unsafe public class PipelineRasterizationStateCreateInfo
	{
		internal Interop.PipelineRasterizationStateCreateInfo* m;

		public PipelineRasterizationStateCreateInfo ()
		{
			m = (Interop.PipelineRasterizationStateCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineRasterizationStateCreateInfo));
			m->SType = StructureType.PipelineRasterizationStateCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public bool DepthClampEnable {
			get { return m->DepthClampEnable; }
			set { m->DepthClampEnable = value; }
		}

		public bool RasterizerDiscardEnable {
			get { return m->RasterizerDiscardEnable; }
			set { m->RasterizerDiscardEnable = value; }
		}

		public PolygonMode PolygonMode {
			get { return m->PolygonMode; }
			set { m->PolygonMode = value; }
		}

		public UInt32 CullMode {
			get { return m->CullMode; }
			set { m->CullMode = value; }
		}

		public FrontFace FrontFace {
			get { return m->FrontFace; }
			set { m->FrontFace = value; }
		}

		public bool DepthBiasEnable {
			get { return m->DepthBiasEnable; }
			set { m->DepthBiasEnable = value; }
		}

		public float DepthBiasConstantFactor {
			get { return m->DepthBiasConstantFactor; }
			set { m->DepthBiasConstantFactor = value; }
		}

		public float DepthBiasClamp {
			get { return m->DepthBiasClamp; }
			set { m->DepthBiasClamp = value; }
		}

		public float DepthBiasSlopeFactor {
			get { return m->DepthBiasSlopeFactor; }
			set { m->DepthBiasSlopeFactor = value; }
		}

		public float LineWidth {
			get { return m->LineWidth; }
			set { m->LineWidth = value; }
		}
	}

	unsafe public class PipelineMultisampleStateCreateInfo
	{
		internal Interop.PipelineMultisampleStateCreateInfo* m;

		public PipelineMultisampleStateCreateInfo ()
		{
			m = (Interop.PipelineMultisampleStateCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineMultisampleStateCreateInfo));
			m->SType = StructureType.PipelineMultisampleStateCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 RasterizationSamples {
			get { return m->RasterizationSamples; }
			set { m->RasterizationSamples = value; }
		}

		public bool SampleShadingEnable {
			get { return m->SampleShadingEnable; }
			set { m->SampleShadingEnable = value; }
		}

		public float MinSampleShading {
			get { return m->MinSampleShading; }
			set { m->MinSampleShading = value; }
		}

		public UInt32 SampleMask {
			get { return m->SampleMask; }
			set { m->SampleMask = value; }
		}

		public bool AlphaToCoverageEnable {
			get { return m->AlphaToCoverageEnable; }
			set { m->AlphaToCoverageEnable = value; }
		}

		public bool AlphaToOneEnable {
			get { return m->AlphaToOneEnable; }
			set { m->AlphaToOneEnable = value; }
		}
	}

	unsafe public class PipelineColorBlendAttachmentState
	{
		internal Interop.PipelineColorBlendAttachmentState* m;

		public PipelineColorBlendAttachmentState ()
		{
			m = (Interop.PipelineColorBlendAttachmentState*) Interop.Structure.Allocate (typeof (Interop.PipelineColorBlendAttachmentState));
		}

		public bool BlendEnable {
			get { return m->BlendEnable; }
			set { m->BlendEnable = value; }
		}

		public BlendFactor SrcColorBlendFactor {
			get { return m->SrcColorBlendFactor; }
			set { m->SrcColorBlendFactor = value; }
		}

		public BlendFactor DstColorBlendFactor {
			get { return m->DstColorBlendFactor; }
			set { m->DstColorBlendFactor = value; }
		}

		public BlendOp ColorBlendOp {
			get { return m->ColorBlendOp; }
			set { m->ColorBlendOp = value; }
		}

		public BlendFactor SrcAlphaBlendFactor {
			get { return m->SrcAlphaBlendFactor; }
			set { m->SrcAlphaBlendFactor = value; }
		}

		public BlendFactor DstAlphaBlendFactor {
			get { return m->DstAlphaBlendFactor; }
			set { m->DstAlphaBlendFactor = value; }
		}

		public BlendOp AlphaBlendOp {
			get { return m->AlphaBlendOp; }
			set { m->AlphaBlendOp = value; }
		}

		public UInt32 ColorWriteMask {
			get { return m->ColorWriteMask; }
			set { m->ColorWriteMask = value; }
		}
	}

	unsafe public class PipelineColorBlendStateCreateInfo
	{
		internal Interop.PipelineColorBlendStateCreateInfo* m;

		public PipelineColorBlendStateCreateInfo ()
		{
			m = (Interop.PipelineColorBlendStateCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineColorBlendStateCreateInfo));
			m->SType = StructureType.PipelineColorBlendStateCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public bool LogicOpEnable {
			get { return m->LogicOpEnable; }
			set { m->LogicOpEnable = value; }
		}

		public LogicOp LogicOp {
			get { return m->LogicOp; }
			set { m->LogicOp = value; }
		}

		public UInt32 AttachmentCount {
			get { return m->AttachmentCount; }
			set { m->AttachmentCount = value; }
		}

		PipelineColorBlendAttachmentState lAttachments;
		public PipelineColorBlendAttachmentState Attachments {
			get { return lAttachments; }
			set { lAttachments = value; m->Attachments = (IntPtr) value.m; }
		}

		public float BlendConstants {
			get { return m->BlendConstants; }
			set { m->BlendConstants = value; }
		}
	}

	unsafe public class PipelineDynamicStateCreateInfo
	{
		internal Interop.PipelineDynamicStateCreateInfo* m;

		public PipelineDynamicStateCreateInfo ()
		{
			m = (Interop.PipelineDynamicStateCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineDynamicStateCreateInfo));
			m->SType = StructureType.PipelineDynamicStateCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 DynamicStateCount {
			get { return m->DynamicStateCount; }
			set { m->DynamicStateCount = value; }
		}

		public DynamicState DynamicStates {
			get { return m->DynamicStates; }
			set { m->DynamicStates = value; }
		}
	}

	unsafe public class StencilOpState
	{
		internal Interop.StencilOpState* m;

		public StencilOpState ()
		{
			m = (Interop.StencilOpState*) Interop.Structure.Allocate (typeof (Interop.StencilOpState));
		}

		public StencilOp FailOp {
			get { return m->FailOp; }
			set { m->FailOp = value; }
		}

		public StencilOp PassOp {
			get { return m->PassOp; }
			set { m->PassOp = value; }
		}

		public StencilOp DepthFailOp {
			get { return m->DepthFailOp; }
			set { m->DepthFailOp = value; }
		}

		public CompareOp CompareOp {
			get { return m->CompareOp; }
			set { m->CompareOp = value; }
		}

		public UInt32 CompareMask {
			get { return m->CompareMask; }
			set { m->CompareMask = value; }
		}

		public UInt32 WriteMask {
			get { return m->WriteMask; }
			set { m->WriteMask = value; }
		}

		public UInt32 Reference {
			get { return m->Reference; }
			set { m->Reference = value; }
		}
	}

	unsafe public class PipelineDepthStencilStateCreateInfo
	{
		internal Interop.PipelineDepthStencilStateCreateInfo* m;

		public PipelineDepthStencilStateCreateInfo ()
		{
			m = (Interop.PipelineDepthStencilStateCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineDepthStencilStateCreateInfo));
			m->SType = StructureType.PipelineDepthStencilStateCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public bool DepthTestEnable {
			get { return m->DepthTestEnable; }
			set { m->DepthTestEnable = value; }
		}

		public bool DepthWriteEnable {
			get { return m->DepthWriteEnable; }
			set { m->DepthWriteEnable = value; }
		}

		public CompareOp DepthCompareOp {
			get { return m->DepthCompareOp; }
			set { m->DepthCompareOp = value; }
		}

		public bool DepthBoundsTestEnable {
			get { return m->DepthBoundsTestEnable; }
			set { m->DepthBoundsTestEnable = value; }
		}

		public bool StencilTestEnable {
			get { return m->StencilTestEnable; }
			set { m->StencilTestEnable = value; }
		}

		StencilOpState lFront;
		public StencilOpState Front {
			get { return lFront; }
			set { lFront = value; m->Front = (IntPtr) value.m; }
		}

		StencilOpState lBack;
		public StencilOpState Back {
			get { return lBack; }
			set { lBack = value; m->Back = (IntPtr) value.m; }
		}

		public float MinDepthBounds {
			get { return m->MinDepthBounds; }
			set { m->MinDepthBounds = value; }
		}

		public float MaxDepthBounds {
			get { return m->MaxDepthBounds; }
			set { m->MaxDepthBounds = value; }
		}
	}

	unsafe public class GraphicsPipelineCreateInfo
	{
		internal Interop.GraphicsPipelineCreateInfo* m;

		public GraphicsPipelineCreateInfo ()
		{
			m = (Interop.GraphicsPipelineCreateInfo*) Interop.Structure.Allocate (typeof (Interop.GraphicsPipelineCreateInfo));
			m->SType = StructureType.GraphicsPipelineCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 StageCount {
			get { return m->StageCount; }
			set { m->StageCount = value; }
		}

		PipelineShaderStageCreateInfo lStages;
		public PipelineShaderStageCreateInfo Stages {
			get { return lStages; }
			set { lStages = value; m->Stages = (IntPtr) value.m; }
		}

		PipelineVertexInputStateCreateInfo lVertexInputState;
		public PipelineVertexInputStateCreateInfo VertexInputState {
			get { return lVertexInputState; }
			set { lVertexInputState = value; m->VertexInputState = (IntPtr) value.m; }
		}

		PipelineInputAssemblyStateCreateInfo lInputAssemblyState;
		public PipelineInputAssemblyStateCreateInfo InputAssemblyState {
			get { return lInputAssemblyState; }
			set { lInputAssemblyState = value; m->InputAssemblyState = (IntPtr) value.m; }
		}

		PipelineTessellationStateCreateInfo lTessellationState;
		public PipelineTessellationStateCreateInfo TessellationState {
			get { return lTessellationState; }
			set { lTessellationState = value; m->TessellationState = (IntPtr) value.m; }
		}

		PipelineViewportStateCreateInfo lViewportState;
		public PipelineViewportStateCreateInfo ViewportState {
			get { return lViewportState; }
			set { lViewportState = value; m->ViewportState = (IntPtr) value.m; }
		}

		PipelineRasterizationStateCreateInfo lRasterizationState;
		public PipelineRasterizationStateCreateInfo RasterizationState {
			get { return lRasterizationState; }
			set { lRasterizationState = value; m->RasterizationState = (IntPtr) value.m; }
		}

		PipelineMultisampleStateCreateInfo lMultisampleState;
		public PipelineMultisampleStateCreateInfo MultisampleState {
			get { return lMultisampleState; }
			set { lMultisampleState = value; m->MultisampleState = (IntPtr) value.m; }
		}

		PipelineDepthStencilStateCreateInfo lDepthStencilState;
		public PipelineDepthStencilStateCreateInfo DepthStencilState {
			get { return lDepthStencilState; }
			set { lDepthStencilState = value; m->DepthStencilState = (IntPtr) value.m; }
		}

		PipelineColorBlendStateCreateInfo lColorBlendState;
		public PipelineColorBlendStateCreateInfo ColorBlendState {
			get { return lColorBlendState; }
			set { lColorBlendState = value; m->ColorBlendState = (IntPtr) value.m; }
		}

		PipelineDynamicStateCreateInfo lDynamicState;
		public PipelineDynamicStateCreateInfo DynamicState {
			get { return lDynamicState; }
			set { lDynamicState = value; m->DynamicState = (IntPtr) value.m; }
		}

		PipelineLayout lLayout;
		public PipelineLayout Layout {
			get { return lLayout; }
			set { lLayout = value; m->Layout = (IntPtr) value.m; }
		}

		RenderPass lRenderPass;
		public RenderPass RenderPass {
			get { return lRenderPass; }
			set { lRenderPass = value; m->RenderPass = (IntPtr) value.m; }
		}

		public UInt32 Subpass {
			get { return m->Subpass; }
			set { m->Subpass = value; }
		}

		Pipeline lBasePipelineHandle;
		public Pipeline BasePipelineHandle {
			get { return lBasePipelineHandle; }
			set { lBasePipelineHandle = value; m->BasePipelineHandle = (IntPtr) value.m; }
		}

		public Int32 BasePipelineIndex {
			get { return m->BasePipelineIndex; }
			set { m->BasePipelineIndex = value; }
		}
	}

	unsafe public class PipelineCacheCreateInfo
	{
		internal Interop.PipelineCacheCreateInfo* m;

		public PipelineCacheCreateInfo ()
		{
			m = (Interop.PipelineCacheCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineCacheCreateInfo));
			m->SType = StructureType.PipelineCacheCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UIntPtr InitialDataSize {
			get { return m->InitialDataSize; }
			set { m->InitialDataSize = value; }
		}

		public IntPtr InitialData {
			get { return m->InitialData; }
			set { m->InitialData = value; }
		}
	}

	unsafe public class PushConstantRange
	{
		internal Interop.PushConstantRange* m;

		public PushConstantRange ()
		{
			m = (Interop.PushConstantRange*) Interop.Structure.Allocate (typeof (Interop.PushConstantRange));
		}

		public UInt32 StageFlags {
			get { return m->StageFlags; }
			set { m->StageFlags = value; }
		}

		public UInt32 Offset {
			get { return m->Offset; }
			set { m->Offset = value; }
		}

		public UInt32 Size {
			get { return m->Size; }
			set { m->Size = value; }
		}
	}

	unsafe public class PipelineLayoutCreateInfo
	{
		internal Interop.PipelineLayoutCreateInfo* m;

		public PipelineLayoutCreateInfo ()
		{
			m = (Interop.PipelineLayoutCreateInfo*) Interop.Structure.Allocate (typeof (Interop.PipelineLayoutCreateInfo));
			m->SType = StructureType.PipelineLayoutCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 SetLayoutCount {
			get { return m->SetLayoutCount; }
			set { m->SetLayoutCount = value; }
		}

		DescriptorSetLayout lSetLayouts;
		public DescriptorSetLayout SetLayouts {
			get { return lSetLayouts; }
			set { lSetLayouts = value; m->SetLayouts = (IntPtr) value.m; }
		}

		public UInt32 PushConstantRangeCount {
			get { return m->PushConstantRangeCount; }
			set { m->PushConstantRangeCount = value; }
		}

		PushConstantRange lPushConstantRanges;
		public PushConstantRange PushConstantRanges {
			get { return lPushConstantRanges; }
			set { lPushConstantRanges = value; m->PushConstantRanges = (IntPtr) value.m; }
		}
	}

	unsafe public class SamplerCreateInfo
	{
		internal Interop.SamplerCreateInfo* m;

		public SamplerCreateInfo ()
		{
			m = (Interop.SamplerCreateInfo*) Interop.Structure.Allocate (typeof (Interop.SamplerCreateInfo));
			m->SType = StructureType.SamplerCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public Filter MagFilter {
			get { return m->MagFilter; }
			set { m->MagFilter = value; }
		}

		public Filter MinFilter {
			get { return m->MinFilter; }
			set { m->MinFilter = value; }
		}

		public SamplerMipmapMode MipmapMode {
			get { return m->MipmapMode; }
			set { m->MipmapMode = value; }
		}

		public SamplerAddressMode AddressModeU {
			get { return m->AddressModeU; }
			set { m->AddressModeU = value; }
		}

		public SamplerAddressMode AddressModeV {
			get { return m->AddressModeV; }
			set { m->AddressModeV = value; }
		}

		public SamplerAddressMode AddressModeW {
			get { return m->AddressModeW; }
			set { m->AddressModeW = value; }
		}

		public float MipLodBias {
			get { return m->MipLodBias; }
			set { m->MipLodBias = value; }
		}

		public bool AnisotropyEnable {
			get { return m->AnisotropyEnable; }
			set { m->AnisotropyEnable = value; }
		}

		public float MaxAnisotropy {
			get { return m->MaxAnisotropy; }
			set { m->MaxAnisotropy = value; }
		}

		public bool CompareEnable {
			get { return m->CompareEnable; }
			set { m->CompareEnable = value; }
		}

		public CompareOp CompareOp {
			get { return m->CompareOp; }
			set { m->CompareOp = value; }
		}

		public float MinLod {
			get { return m->MinLod; }
			set { m->MinLod = value; }
		}

		public float MaxLod {
			get { return m->MaxLod; }
			set { m->MaxLod = value; }
		}

		public BorderColor BorderColor {
			get { return m->BorderColor; }
			set { m->BorderColor = value; }
		}

		public bool UnnormalizedCoordinates {
			get { return m->UnnormalizedCoordinates; }
			set { m->UnnormalizedCoordinates = value; }
		}
	}

	unsafe public class CommandPoolCreateInfo
	{
		internal Interop.CommandPoolCreateInfo* m;

		public CommandPoolCreateInfo ()
		{
			m = (Interop.CommandPoolCreateInfo*) Interop.Structure.Allocate (typeof (Interop.CommandPoolCreateInfo));
			m->SType = StructureType.CommandPoolCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 QueueFamilyIndex {
			get { return m->QueueFamilyIndex; }
			set { m->QueueFamilyIndex = value; }
		}
	}

	unsafe public class CommandBufferAllocateInfo
	{
		internal Interop.CommandBufferAllocateInfo* m;

		public CommandBufferAllocateInfo ()
		{
			m = (Interop.CommandBufferAllocateInfo*) Interop.Structure.Allocate (typeof (Interop.CommandBufferAllocateInfo));
			m->SType = StructureType.CommandBufferAllocateInfo;
		}

		CommandPool lCommandPool;
		public CommandPool CommandPool {
			get { return lCommandPool; }
			set { lCommandPool = value; m->CommandPool = (IntPtr) value.m; }
		}

		public CommandBufferLevel Level {
			get { return m->Level; }
			set { m->Level = value; }
		}

		public UInt32 CommandBufferCount {
			get { return m->CommandBufferCount; }
			set { m->CommandBufferCount = value; }
		}
	}

	unsafe public class CommandBufferInheritanceInfo
	{
		internal Interop.CommandBufferInheritanceInfo* m;

		public CommandBufferInheritanceInfo ()
		{
			m = (Interop.CommandBufferInheritanceInfo*) Interop.Structure.Allocate (typeof (Interop.CommandBufferInheritanceInfo));
			m->SType = StructureType.CommandBufferInheritanceInfo;
		}

		RenderPass lRenderPass;
		public RenderPass RenderPass {
			get { return lRenderPass; }
			set { lRenderPass = value; m->RenderPass = (IntPtr) value.m; }
		}

		public UInt32 Subpass {
			get { return m->Subpass; }
			set { m->Subpass = value; }
		}

		Framebuffer lFramebuffer;
		public Framebuffer Framebuffer {
			get { return lFramebuffer; }
			set { lFramebuffer = value; m->Framebuffer = (IntPtr) value.m; }
		}

		public bool OcclusionQueryEnable {
			get { return m->OcclusionQueryEnable; }
			set { m->OcclusionQueryEnable = value; }
		}

		public UInt32 QueryFlags {
			get { return m->QueryFlags; }
			set { m->QueryFlags = value; }
		}

		public UInt32 PipelineStatistics {
			get { return m->PipelineStatistics; }
			set { m->PipelineStatistics = value; }
		}
	}

	unsafe public class CommandBufferBeginInfo
	{
		internal Interop.CommandBufferBeginInfo* m;

		public CommandBufferBeginInfo ()
		{
			m = (Interop.CommandBufferBeginInfo*) Interop.Structure.Allocate (typeof (Interop.CommandBufferBeginInfo));
			m->SType = StructureType.CommandBufferBeginInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		CommandBufferInheritanceInfo lInheritanceInfo;
		public CommandBufferInheritanceInfo InheritanceInfo {
			get { return lInheritanceInfo; }
			set { lInheritanceInfo = value; m->InheritanceInfo = (IntPtr) value.m; }
		}
	}

	unsafe public class RenderPassBeginInfo
	{
		internal Interop.RenderPassBeginInfo* m;

		public RenderPassBeginInfo ()
		{
			m = (Interop.RenderPassBeginInfo*) Interop.Structure.Allocate (typeof (Interop.RenderPassBeginInfo));
			m->SType = StructureType.RenderPassBeginInfo;
		}

		RenderPass lRenderPass;
		public RenderPass RenderPass {
			get { return lRenderPass; }
			set { lRenderPass = value; m->RenderPass = (IntPtr) value.m; }
		}

		Framebuffer lFramebuffer;
		public Framebuffer Framebuffer {
			get { return lFramebuffer; }
			set { lFramebuffer = value; m->Framebuffer = (IntPtr) value.m; }
		}

		Rect2D lRenderArea;
		public Rect2D RenderArea {
			get { return lRenderArea; }
			set { lRenderArea = value; m->RenderArea = (IntPtr) value.m; }
		}

		public UInt32 ClearValueCount {
			get { return m->ClearValueCount; }
			set { m->ClearValueCount = value; }
		}

		ClearValue lClearValues;
		public ClearValue ClearValues {
			get { return lClearValues; }
			set { lClearValues = value; m->ClearValues = (IntPtr) value.m; }
		}
	}

	unsafe public class ClearDepthStencilValue
	{
		internal Interop.ClearDepthStencilValue* m;

		public ClearDepthStencilValue ()
		{
			m = (Interop.ClearDepthStencilValue*) Interop.Structure.Allocate (typeof (Interop.ClearDepthStencilValue));
		}

		public float Depth {
			get { return m->Depth; }
			set { m->Depth = value; }
		}

		public UInt32 Stencil {
			get { return m->Stencil; }
			set { m->Stencil = value; }
		}
	}

	unsafe public class ClearAttachment
	{
		internal Interop.ClearAttachment* m;

		public ClearAttachment ()
		{
			m = (Interop.ClearAttachment*) Interop.Structure.Allocate (typeof (Interop.ClearAttachment));
		}

		public UInt32 AspectMask {
			get { return m->AspectMask; }
			set { m->AspectMask = value; }
		}

		public UInt32 ColorAttachment {
			get { return m->ColorAttachment; }
			set { m->ColorAttachment = value; }
		}

		ClearValue lClearValue;
		public ClearValue ClearValue {
			get { return lClearValue; }
			set { lClearValue = value; m->ClearValue = (IntPtr) value.m; }
		}
	}

	unsafe public class AttachmentDescription
	{
		internal Interop.AttachmentDescription* m;

		public AttachmentDescription ()
		{
			m = (Interop.AttachmentDescription*) Interop.Structure.Allocate (typeof (Interop.AttachmentDescription));
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public Format Format {
			get { return m->Format; }
			set { m->Format = value; }
		}

		public UInt32 Samples {
			get { return m->Samples; }
			set { m->Samples = value; }
		}

		public AttachmentLoadOp LoadOp {
			get { return m->LoadOp; }
			set { m->LoadOp = value; }
		}

		public AttachmentStoreOp StoreOp {
			get { return m->StoreOp; }
			set { m->StoreOp = value; }
		}

		public AttachmentLoadOp StencilLoadOp {
			get { return m->StencilLoadOp; }
			set { m->StencilLoadOp = value; }
		}

		public AttachmentStoreOp StencilStoreOp {
			get { return m->StencilStoreOp; }
			set { m->StencilStoreOp = value; }
		}

		public ImageLayout InitialLayout {
			get { return m->InitialLayout; }
			set { m->InitialLayout = value; }
		}

		public ImageLayout FinalLayout {
			get { return m->FinalLayout; }
			set { m->FinalLayout = value; }
		}
	}

	unsafe public class AttachmentReference
	{
		internal Interop.AttachmentReference* m;

		public AttachmentReference ()
		{
			m = (Interop.AttachmentReference*) Interop.Structure.Allocate (typeof (Interop.AttachmentReference));
		}

		public UInt32 Attachment {
			get { return m->Attachment; }
			set { m->Attachment = value; }
		}

		public ImageLayout Layout {
			get { return m->Layout; }
			set { m->Layout = value; }
		}
	}

	unsafe public class SubpassDescription
	{
		internal Interop.SubpassDescription* m;

		public SubpassDescription ()
		{
			m = (Interop.SubpassDescription*) Interop.Structure.Allocate (typeof (Interop.SubpassDescription));
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public PipelineBindPoint PipelineBindPoint {
			get { return m->PipelineBindPoint; }
			set { m->PipelineBindPoint = value; }
		}

		public UInt32 InputAttachmentCount {
			get { return m->InputAttachmentCount; }
			set { m->InputAttachmentCount = value; }
		}

		AttachmentReference lInputAttachments;
		public AttachmentReference InputAttachments {
			get { return lInputAttachments; }
			set { lInputAttachments = value; m->InputAttachments = (IntPtr) value.m; }
		}

		public UInt32 ColorAttachmentCount {
			get { return m->ColorAttachmentCount; }
			set { m->ColorAttachmentCount = value; }
		}

		AttachmentReference lColorAttachments;
		public AttachmentReference ColorAttachments {
			get { return lColorAttachments; }
			set { lColorAttachments = value; m->ColorAttachments = (IntPtr) value.m; }
		}

		AttachmentReference lResolveAttachments;
		public AttachmentReference ResolveAttachments {
			get { return lResolveAttachments; }
			set { lResolveAttachments = value; m->ResolveAttachments = (IntPtr) value.m; }
		}

		AttachmentReference lDepthStencilAttachment;
		public AttachmentReference DepthStencilAttachment {
			get { return lDepthStencilAttachment; }
			set { lDepthStencilAttachment = value; m->DepthStencilAttachment = (IntPtr) value.m; }
		}

		public UInt32 PreserveAttachmentCount {
			get { return m->PreserveAttachmentCount; }
			set { m->PreserveAttachmentCount = value; }
		}

		public UInt32 PreserveAttachments {
			get { return m->PreserveAttachments; }
			set { m->PreserveAttachments = value; }
		}
	}

	unsafe public class SubpassDependency
	{
		internal Interop.SubpassDependency* m;

		public SubpassDependency ()
		{
			m = (Interop.SubpassDependency*) Interop.Structure.Allocate (typeof (Interop.SubpassDependency));
		}

		public UInt32 SrcSubpass {
			get { return m->SrcSubpass; }
			set { m->SrcSubpass = value; }
		}

		public UInt32 DstSubpass {
			get { return m->DstSubpass; }
			set { m->DstSubpass = value; }
		}

		public UInt32 SrcStageMask {
			get { return m->SrcStageMask; }
			set { m->SrcStageMask = value; }
		}

		public UInt32 DstStageMask {
			get { return m->DstStageMask; }
			set { m->DstStageMask = value; }
		}

		public UInt32 SrcAccessMask {
			get { return m->SrcAccessMask; }
			set { m->SrcAccessMask = value; }
		}

		public UInt32 DstAccessMask {
			get { return m->DstAccessMask; }
			set { m->DstAccessMask = value; }
		}

		public UInt32 DependencyFlags {
			get { return m->DependencyFlags; }
			set { m->DependencyFlags = value; }
		}
	}

	unsafe public class RenderPassCreateInfo
	{
		internal Interop.RenderPassCreateInfo* m;

		public RenderPassCreateInfo ()
		{
			m = (Interop.RenderPassCreateInfo*) Interop.Structure.Allocate (typeof (Interop.RenderPassCreateInfo));
			m->SType = StructureType.RenderPassCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public UInt32 AttachmentCount {
			get { return m->AttachmentCount; }
			set { m->AttachmentCount = value; }
		}

		AttachmentDescription lAttachments;
		public AttachmentDescription Attachments {
			get { return lAttachments; }
			set { lAttachments = value; m->Attachments = (IntPtr) value.m; }
		}

		public UInt32 SubpassCount {
			get { return m->SubpassCount; }
			set { m->SubpassCount = value; }
		}

		SubpassDescription lSubpasses;
		public SubpassDescription Subpasses {
			get { return lSubpasses; }
			set { lSubpasses = value; m->Subpasses = (IntPtr) value.m; }
		}

		public UInt32 DependencyCount {
			get { return m->DependencyCount; }
			set { m->DependencyCount = value; }
		}

		SubpassDependency lDependencies;
		public SubpassDependency Dependencies {
			get { return lDependencies; }
			set { lDependencies = value; m->Dependencies = (IntPtr) value.m; }
		}
	}

	unsafe public class EventCreateInfo
	{
		internal Interop.EventCreateInfo* m;

		public EventCreateInfo ()
		{
			m = (Interop.EventCreateInfo*) Interop.Structure.Allocate (typeof (Interop.EventCreateInfo));
			m->SType = StructureType.EventCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}
	}

	unsafe public class FenceCreateInfo
	{
		internal Interop.FenceCreateInfo* m;

		public FenceCreateInfo ()
		{
			m = (Interop.FenceCreateInfo*) Interop.Structure.Allocate (typeof (Interop.FenceCreateInfo));
			m->SType = StructureType.FenceCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}
	}

	unsafe public class PhysicalDeviceFeatures
	{
		internal Interop.PhysicalDeviceFeatures* m;

		public PhysicalDeviceFeatures ()
		{
			m = (Interop.PhysicalDeviceFeatures*) Interop.Structure.Allocate (typeof (Interop.PhysicalDeviceFeatures));
		}

		public bool RobustBufferAccess {
			get { return m->RobustBufferAccess; }
			set { m->RobustBufferAccess = value; }
		}

		public bool FullDrawIndexUint32 {
			get { return m->FullDrawIndexUint32; }
			set { m->FullDrawIndexUint32 = value; }
		}

		public bool ImageCubeArray {
			get { return m->ImageCubeArray; }
			set { m->ImageCubeArray = value; }
		}

		public bool IndependentBlend {
			get { return m->IndependentBlend; }
			set { m->IndependentBlend = value; }
		}

		public bool GeometryShader {
			get { return m->GeometryShader; }
			set { m->GeometryShader = value; }
		}

		public bool TessellationShader {
			get { return m->TessellationShader; }
			set { m->TessellationShader = value; }
		}

		public bool SampleRateShading {
			get { return m->SampleRateShading; }
			set { m->SampleRateShading = value; }
		}

		public bool DualSrcBlend {
			get { return m->DualSrcBlend; }
			set { m->DualSrcBlend = value; }
		}

		public bool LogicOp {
			get { return m->LogicOp; }
			set { m->LogicOp = value; }
		}

		public bool MultiDrawIndirect {
			get { return m->MultiDrawIndirect; }
			set { m->MultiDrawIndirect = value; }
		}

		public bool DrawIndirectFirstInstance {
			get { return m->DrawIndirectFirstInstance; }
			set { m->DrawIndirectFirstInstance = value; }
		}

		public bool DepthClamp {
			get { return m->DepthClamp; }
			set { m->DepthClamp = value; }
		}

		public bool DepthBiasClamp {
			get { return m->DepthBiasClamp; }
			set { m->DepthBiasClamp = value; }
		}

		public bool FillModeNonSolid {
			get { return m->FillModeNonSolid; }
			set { m->FillModeNonSolid = value; }
		}

		public bool DepthBounds {
			get { return m->DepthBounds; }
			set { m->DepthBounds = value; }
		}

		public bool WideLines {
			get { return m->WideLines; }
			set { m->WideLines = value; }
		}

		public bool LargePoints {
			get { return m->LargePoints; }
			set { m->LargePoints = value; }
		}

		public bool AlphaToOne {
			get { return m->AlphaToOne; }
			set { m->AlphaToOne = value; }
		}

		public bool MultiViewport {
			get { return m->MultiViewport; }
			set { m->MultiViewport = value; }
		}

		public bool SamplerAnisotropy {
			get { return m->SamplerAnisotropy; }
			set { m->SamplerAnisotropy = value; }
		}

		public bool TextureCompressionETC2 {
			get { return m->TextureCompressionETC2; }
			set { m->TextureCompressionETC2 = value; }
		}

		public bool TextureCompressionASTCLdr {
			get { return m->TextureCompressionASTCLdr; }
			set { m->TextureCompressionASTCLdr = value; }
		}

		public bool TextureCompressionBC {
			get { return m->TextureCompressionBC; }
			set { m->TextureCompressionBC = value; }
		}

		public bool OcclusionQueryPrecise {
			get { return m->OcclusionQueryPrecise; }
			set { m->OcclusionQueryPrecise = value; }
		}

		public bool PipelineStatisticsQuery {
			get { return m->PipelineStatisticsQuery; }
			set { m->PipelineStatisticsQuery = value; }
		}

		public bool VertexPipelineStoresAndAtomics {
			get { return m->VertexPipelineStoresAndAtomics; }
			set { m->VertexPipelineStoresAndAtomics = value; }
		}

		public bool FragmentStoresAndAtomics {
			get { return m->FragmentStoresAndAtomics; }
			set { m->FragmentStoresAndAtomics = value; }
		}

		public bool ShaderTessellationAndGeometryPointSize {
			get { return m->ShaderTessellationAndGeometryPointSize; }
			set { m->ShaderTessellationAndGeometryPointSize = value; }
		}

		public bool ShaderImageGatherExtended {
			get { return m->ShaderImageGatherExtended; }
			set { m->ShaderImageGatherExtended = value; }
		}

		public bool ShaderStorageImageExtendedFormats {
			get { return m->ShaderStorageImageExtendedFormats; }
			set { m->ShaderStorageImageExtendedFormats = value; }
		}

		public bool ShaderStorageImageMultisample {
			get { return m->ShaderStorageImageMultisample; }
			set { m->ShaderStorageImageMultisample = value; }
		}

		public bool ShaderStorageImageReadWithoutFormat {
			get { return m->ShaderStorageImageReadWithoutFormat; }
			set { m->ShaderStorageImageReadWithoutFormat = value; }
		}

		public bool ShaderStorageImageWriteWithoutFormat {
			get { return m->ShaderStorageImageWriteWithoutFormat; }
			set { m->ShaderStorageImageWriteWithoutFormat = value; }
		}

		public bool ShaderUniformBufferArrayDynamicIndexing {
			get { return m->ShaderUniformBufferArrayDynamicIndexing; }
			set { m->ShaderUniformBufferArrayDynamicIndexing = value; }
		}

		public bool ShaderSampledImageArrayDynamicIndexing {
			get { return m->ShaderSampledImageArrayDynamicIndexing; }
			set { m->ShaderSampledImageArrayDynamicIndexing = value; }
		}

		public bool ShaderStorageBufferArrayDynamicIndexing {
			get { return m->ShaderStorageBufferArrayDynamicIndexing; }
			set { m->ShaderStorageBufferArrayDynamicIndexing = value; }
		}

		public bool ShaderStorageImageArrayDynamicIndexing {
			get { return m->ShaderStorageImageArrayDynamicIndexing; }
			set { m->ShaderStorageImageArrayDynamicIndexing = value; }
		}

		public bool ShaderClipDistance {
			get { return m->ShaderClipDistance; }
			set { m->ShaderClipDistance = value; }
		}

		public bool ShaderCullDistance {
			get { return m->ShaderCullDistance; }
			set { m->ShaderCullDistance = value; }
		}

		public bool ShaderFloat64 {
			get { return m->ShaderFloat64; }
			set { m->ShaderFloat64 = value; }
		}

		public bool ShaderInt64 {
			get { return m->ShaderInt64; }
			set { m->ShaderInt64 = value; }
		}

		public bool ShaderInt16 {
			get { return m->ShaderInt16; }
			set { m->ShaderInt16 = value; }
		}

		public bool ShaderResourceResidency {
			get { return m->ShaderResourceResidency; }
			set { m->ShaderResourceResidency = value; }
		}

		public bool ShaderResourceMinLod {
			get { return m->ShaderResourceMinLod; }
			set { m->ShaderResourceMinLod = value; }
		}

		public bool SparseBinding {
			get { return m->SparseBinding; }
			set { m->SparseBinding = value; }
		}

		public bool SparseResidencyBuffer {
			get { return m->SparseResidencyBuffer; }
			set { m->SparseResidencyBuffer = value; }
		}

		public bool SparseResidencyImage2D {
			get { return m->SparseResidencyImage2D; }
			set { m->SparseResidencyImage2D = value; }
		}

		public bool SparseResidencyImage3D {
			get { return m->SparseResidencyImage3D; }
			set { m->SparseResidencyImage3D = value; }
		}

		public bool SparseResidency2Samples {
			get { return m->SparseResidency2Samples; }
			set { m->SparseResidency2Samples = value; }
		}

		public bool SparseResidency4Samples {
			get { return m->SparseResidency4Samples; }
			set { m->SparseResidency4Samples = value; }
		}

		public bool SparseResidency8Samples {
			get { return m->SparseResidency8Samples; }
			set { m->SparseResidency8Samples = value; }
		}

		public bool SparseResidency16Samples {
			get { return m->SparseResidency16Samples; }
			set { m->SparseResidency16Samples = value; }
		}

		public bool SparseResidencyAliased {
			get { return m->SparseResidencyAliased; }
			set { m->SparseResidencyAliased = value; }
		}

		public bool VariableMultisampleRate {
			get { return m->VariableMultisampleRate; }
			set { m->VariableMultisampleRate = value; }
		}

		public bool InheritedQueries {
			get { return m->InheritedQueries; }
			set { m->InheritedQueries = value; }
		}
	}

	unsafe public class PhysicalDeviceSparseProperties
	{
		internal Interop.PhysicalDeviceSparseProperties* m;

		public PhysicalDeviceSparseProperties ()
		{
			m = (Interop.PhysicalDeviceSparseProperties*) Interop.Structure.Allocate (typeof (Interop.PhysicalDeviceSparseProperties));
		}

		public bool ResidencyStandard2DBlockShape {
			get { return m->ResidencyStandard2DBlockShape; }
			set { m->ResidencyStandard2DBlockShape = value; }
		}

		public bool ResidencyStandard2DMultisampleBlockShape {
			get { return m->ResidencyStandard2DMultisampleBlockShape; }
			set { m->ResidencyStandard2DMultisampleBlockShape = value; }
		}

		public bool ResidencyStandard3DBlockShape {
			get { return m->ResidencyStandard3DBlockShape; }
			set { m->ResidencyStandard3DBlockShape = value; }
		}

		public bool ResidencyAlignedMipSize {
			get { return m->ResidencyAlignedMipSize; }
			set { m->ResidencyAlignedMipSize = value; }
		}

		public bool ResidencyNonResidentStrict {
			get { return m->ResidencyNonResidentStrict; }
			set { m->ResidencyNonResidentStrict = value; }
		}
	}

	unsafe public class PhysicalDeviceLimits
	{
		internal Interop.PhysicalDeviceLimits* m;

		public PhysicalDeviceLimits ()
		{
			m = (Interop.PhysicalDeviceLimits*) Interop.Structure.Allocate (typeof (Interop.PhysicalDeviceLimits));
		}

		public UInt32 MaxImageDimension1D {
			get { return m->MaxImageDimension1D; }
			set { m->MaxImageDimension1D = value; }
		}

		public UInt32 MaxImageDimension2D {
			get { return m->MaxImageDimension2D; }
			set { m->MaxImageDimension2D = value; }
		}

		public UInt32 MaxImageDimension3D {
			get { return m->MaxImageDimension3D; }
			set { m->MaxImageDimension3D = value; }
		}

		public UInt32 MaxImageDimensionCube {
			get { return m->MaxImageDimensionCube; }
			set { m->MaxImageDimensionCube = value; }
		}

		public UInt32 MaxImageArrayLayers {
			get { return m->MaxImageArrayLayers; }
			set { m->MaxImageArrayLayers = value; }
		}

		public UInt32 MaxTexelBufferElements {
			get { return m->MaxTexelBufferElements; }
			set { m->MaxTexelBufferElements = value; }
		}

		public UInt32 MaxUniformBufferRange {
			get { return m->MaxUniformBufferRange; }
			set { m->MaxUniformBufferRange = value; }
		}

		public UInt32 MaxStorageBufferRange {
			get { return m->MaxStorageBufferRange; }
			set { m->MaxStorageBufferRange = value; }
		}

		public UInt32 MaxPushConstantsSize {
			get { return m->MaxPushConstantsSize; }
			set { m->MaxPushConstantsSize = value; }
		}

		public UInt32 MaxMemoryAllocationCount {
			get { return m->MaxMemoryAllocationCount; }
			set { m->MaxMemoryAllocationCount = value; }
		}

		public UInt32 MaxSamplerAllocationCount {
			get { return m->MaxSamplerAllocationCount; }
			set { m->MaxSamplerAllocationCount = value; }
		}

		public DeviceSize BufferImageGranularity {
			get { return m->BufferImageGranularity; }
			set { m->BufferImageGranularity = value; }
		}

		public DeviceSize SparseAddressSpaceSize {
			get { return m->SparseAddressSpaceSize; }
			set { m->SparseAddressSpaceSize = value; }
		}

		public UInt32 MaxBoundDescriptorSets {
			get { return m->MaxBoundDescriptorSets; }
			set { m->MaxBoundDescriptorSets = value; }
		}

		public UInt32 MaxPerStageDescriptorSamplers {
			get { return m->MaxPerStageDescriptorSamplers; }
			set { m->MaxPerStageDescriptorSamplers = value; }
		}

		public UInt32 MaxPerStageDescriptorUniformBuffers {
			get { return m->MaxPerStageDescriptorUniformBuffers; }
			set { m->MaxPerStageDescriptorUniformBuffers = value; }
		}

		public UInt32 MaxPerStageDescriptorStorageBuffers {
			get { return m->MaxPerStageDescriptorStorageBuffers; }
			set { m->MaxPerStageDescriptorStorageBuffers = value; }
		}

		public UInt32 MaxPerStageDescriptorSampledImages {
			get { return m->MaxPerStageDescriptorSampledImages; }
			set { m->MaxPerStageDescriptorSampledImages = value; }
		}

		public UInt32 MaxPerStageDescriptorStorageImages {
			get { return m->MaxPerStageDescriptorStorageImages; }
			set { m->MaxPerStageDescriptorStorageImages = value; }
		}

		public UInt32 MaxPerStageDescriptorInputAttachments {
			get { return m->MaxPerStageDescriptorInputAttachments; }
			set { m->MaxPerStageDescriptorInputAttachments = value; }
		}

		public UInt32 MaxPerStageResources {
			get { return m->MaxPerStageResources; }
			set { m->MaxPerStageResources = value; }
		}

		public UInt32 MaxDescriptorSetSamplers {
			get { return m->MaxDescriptorSetSamplers; }
			set { m->MaxDescriptorSetSamplers = value; }
		}

		public UInt32 MaxDescriptorSetUniformBuffers {
			get { return m->MaxDescriptorSetUniformBuffers; }
			set { m->MaxDescriptorSetUniformBuffers = value; }
		}

		public UInt32 MaxDescriptorSetUniformBuffersDynamic {
			get { return m->MaxDescriptorSetUniformBuffersDynamic; }
			set { m->MaxDescriptorSetUniformBuffersDynamic = value; }
		}

		public UInt32 MaxDescriptorSetStorageBuffers {
			get { return m->MaxDescriptorSetStorageBuffers; }
			set { m->MaxDescriptorSetStorageBuffers = value; }
		}

		public UInt32 MaxDescriptorSetStorageBuffersDynamic {
			get { return m->MaxDescriptorSetStorageBuffersDynamic; }
			set { m->MaxDescriptorSetStorageBuffersDynamic = value; }
		}

		public UInt32 MaxDescriptorSetSampledImages {
			get { return m->MaxDescriptorSetSampledImages; }
			set { m->MaxDescriptorSetSampledImages = value; }
		}

		public UInt32 MaxDescriptorSetStorageImages {
			get { return m->MaxDescriptorSetStorageImages; }
			set { m->MaxDescriptorSetStorageImages = value; }
		}

		public UInt32 MaxDescriptorSetInputAttachments {
			get { return m->MaxDescriptorSetInputAttachments; }
			set { m->MaxDescriptorSetInputAttachments = value; }
		}

		public UInt32 MaxVertexInputAttributes {
			get { return m->MaxVertexInputAttributes; }
			set { m->MaxVertexInputAttributes = value; }
		}

		public UInt32 MaxVertexInputBindings {
			get { return m->MaxVertexInputBindings; }
			set { m->MaxVertexInputBindings = value; }
		}

		public UInt32 MaxVertexInputAttributeOffset {
			get { return m->MaxVertexInputAttributeOffset; }
			set { m->MaxVertexInputAttributeOffset = value; }
		}

		public UInt32 MaxVertexInputBindingStride {
			get { return m->MaxVertexInputBindingStride; }
			set { m->MaxVertexInputBindingStride = value; }
		}

		public UInt32 MaxVertexOutputComponents {
			get { return m->MaxVertexOutputComponents; }
			set { m->MaxVertexOutputComponents = value; }
		}

		public UInt32 MaxTessellationGenerationLevel {
			get { return m->MaxTessellationGenerationLevel; }
			set { m->MaxTessellationGenerationLevel = value; }
		}

		public UInt32 MaxTessellationPatchSize {
			get { return m->MaxTessellationPatchSize; }
			set { m->MaxTessellationPatchSize = value; }
		}

		public UInt32 MaxTessellationControlPerVertexInputComponents {
			get { return m->MaxTessellationControlPerVertexInputComponents; }
			set { m->MaxTessellationControlPerVertexInputComponents = value; }
		}

		public UInt32 MaxTessellationControlPerVertexOutputComponents {
			get { return m->MaxTessellationControlPerVertexOutputComponents; }
			set { m->MaxTessellationControlPerVertexOutputComponents = value; }
		}

		public UInt32 MaxTessellationControlPerPatchOutputComponents {
			get { return m->MaxTessellationControlPerPatchOutputComponents; }
			set { m->MaxTessellationControlPerPatchOutputComponents = value; }
		}

		public UInt32 MaxTessellationControlTotalOutputComponents {
			get { return m->MaxTessellationControlTotalOutputComponents; }
			set { m->MaxTessellationControlTotalOutputComponents = value; }
		}

		public UInt32 MaxTessellationEvaluationInputComponents {
			get { return m->MaxTessellationEvaluationInputComponents; }
			set { m->MaxTessellationEvaluationInputComponents = value; }
		}

		public UInt32 MaxTessellationEvaluationOutputComponents {
			get { return m->MaxTessellationEvaluationOutputComponents; }
			set { m->MaxTessellationEvaluationOutputComponents = value; }
		}

		public UInt32 MaxGeometryShaderInvocations {
			get { return m->MaxGeometryShaderInvocations; }
			set { m->MaxGeometryShaderInvocations = value; }
		}

		public UInt32 MaxGeometryInputComponents {
			get { return m->MaxGeometryInputComponents; }
			set { m->MaxGeometryInputComponents = value; }
		}

		public UInt32 MaxGeometryOutputComponents {
			get { return m->MaxGeometryOutputComponents; }
			set { m->MaxGeometryOutputComponents = value; }
		}

		public UInt32 MaxGeometryOutputVertices {
			get { return m->MaxGeometryOutputVertices; }
			set { m->MaxGeometryOutputVertices = value; }
		}

		public UInt32 MaxGeometryTotalOutputComponents {
			get { return m->MaxGeometryTotalOutputComponents; }
			set { m->MaxGeometryTotalOutputComponents = value; }
		}

		public UInt32 MaxFragmentInputComponents {
			get { return m->MaxFragmentInputComponents; }
			set { m->MaxFragmentInputComponents = value; }
		}

		public UInt32 MaxFragmentOutputAttachments {
			get { return m->MaxFragmentOutputAttachments; }
			set { m->MaxFragmentOutputAttachments = value; }
		}

		public UInt32 MaxFragmentDualSrcAttachments {
			get { return m->MaxFragmentDualSrcAttachments; }
			set { m->MaxFragmentDualSrcAttachments = value; }
		}

		public UInt32 MaxFragmentCombinedOutputResources {
			get { return m->MaxFragmentCombinedOutputResources; }
			set { m->MaxFragmentCombinedOutputResources = value; }
		}

		public UInt32 MaxComputeSharedMemorySize {
			get { return m->MaxComputeSharedMemorySize; }
			set { m->MaxComputeSharedMemorySize = value; }
		}

		public UInt32 MaxComputeWorkGroupCount {
			get { return m->MaxComputeWorkGroupCount; }
			set { m->MaxComputeWorkGroupCount = value; }
		}

		public UInt32 MaxComputeWorkGroupInvocations {
			get { return m->MaxComputeWorkGroupInvocations; }
			set { m->MaxComputeWorkGroupInvocations = value; }
		}

		public UInt32 MaxComputeWorkGroupSize {
			get { return m->MaxComputeWorkGroupSize; }
			set { m->MaxComputeWorkGroupSize = value; }
		}

		public UInt32 SubPixelPrecisionBits {
			get { return m->SubPixelPrecisionBits; }
			set { m->SubPixelPrecisionBits = value; }
		}

		public UInt32 SubTexelPrecisionBits {
			get { return m->SubTexelPrecisionBits; }
			set { m->SubTexelPrecisionBits = value; }
		}

		public UInt32 MipmapPrecisionBits {
			get { return m->MipmapPrecisionBits; }
			set { m->MipmapPrecisionBits = value; }
		}

		public UInt32 MaxDrawIndexedIndexValue {
			get { return m->MaxDrawIndexedIndexValue; }
			set { m->MaxDrawIndexedIndexValue = value; }
		}

		public UInt32 MaxDrawIndirectCount {
			get { return m->MaxDrawIndirectCount; }
			set { m->MaxDrawIndirectCount = value; }
		}

		public float MaxSamplerLodBias {
			get { return m->MaxSamplerLodBias; }
			set { m->MaxSamplerLodBias = value; }
		}

		public float MaxSamplerAnisotropy {
			get { return m->MaxSamplerAnisotropy; }
			set { m->MaxSamplerAnisotropy = value; }
		}

		public UInt32 MaxViewports {
			get { return m->MaxViewports; }
			set { m->MaxViewports = value; }
		}

		public UInt32 MaxViewportDimensions {
			get { return m->MaxViewportDimensions; }
			set { m->MaxViewportDimensions = value; }
		}

		public float ViewportBoundsRange {
			get { return m->ViewportBoundsRange; }
			set { m->ViewportBoundsRange = value; }
		}

		public UInt32 ViewportSubPixelBits {
			get { return m->ViewportSubPixelBits; }
			set { m->ViewportSubPixelBits = value; }
		}

		public UIntPtr MinMemoryMapAlignment {
			get { return m->MinMemoryMapAlignment; }
			set { m->MinMemoryMapAlignment = value; }
		}

		public DeviceSize MinTexelBufferOffsetAlignment {
			get { return m->MinTexelBufferOffsetAlignment; }
			set { m->MinTexelBufferOffsetAlignment = value; }
		}

		public DeviceSize MinUniformBufferOffsetAlignment {
			get { return m->MinUniformBufferOffsetAlignment; }
			set { m->MinUniformBufferOffsetAlignment = value; }
		}

		public DeviceSize MinStorageBufferOffsetAlignment {
			get { return m->MinStorageBufferOffsetAlignment; }
			set { m->MinStorageBufferOffsetAlignment = value; }
		}

		public Int32 MinTexelOffset {
			get { return m->MinTexelOffset; }
			set { m->MinTexelOffset = value; }
		}

		public UInt32 MaxTexelOffset {
			get { return m->MaxTexelOffset; }
			set { m->MaxTexelOffset = value; }
		}

		public Int32 MinTexelGatherOffset {
			get { return m->MinTexelGatherOffset; }
			set { m->MinTexelGatherOffset = value; }
		}

		public UInt32 MaxTexelGatherOffset {
			get { return m->MaxTexelGatherOffset; }
			set { m->MaxTexelGatherOffset = value; }
		}

		public float MinInterpolationOffset {
			get { return m->MinInterpolationOffset; }
			set { m->MinInterpolationOffset = value; }
		}

		public float MaxInterpolationOffset {
			get { return m->MaxInterpolationOffset; }
			set { m->MaxInterpolationOffset = value; }
		}

		public UInt32 SubPixelInterpolationOffsetBits {
			get { return m->SubPixelInterpolationOffsetBits; }
			set { m->SubPixelInterpolationOffsetBits = value; }
		}

		public UInt32 MaxFramebufferWidth {
			get { return m->MaxFramebufferWidth; }
			set { m->MaxFramebufferWidth = value; }
		}

		public UInt32 MaxFramebufferHeight {
			get { return m->MaxFramebufferHeight; }
			set { m->MaxFramebufferHeight = value; }
		}

		public UInt32 MaxFramebufferLayers {
			get { return m->MaxFramebufferLayers; }
			set { m->MaxFramebufferLayers = value; }
		}

		public UInt32 FramebufferColorSampleCounts {
			get { return m->FramebufferColorSampleCounts; }
			set { m->FramebufferColorSampleCounts = value; }
		}

		public UInt32 FramebufferDepthSampleCounts {
			get { return m->FramebufferDepthSampleCounts; }
			set { m->FramebufferDepthSampleCounts = value; }
		}

		public UInt32 FramebufferStencilSampleCounts {
			get { return m->FramebufferStencilSampleCounts; }
			set { m->FramebufferStencilSampleCounts = value; }
		}

		public UInt32 FramebufferNoAttachmentsSampleCounts {
			get { return m->FramebufferNoAttachmentsSampleCounts; }
			set { m->FramebufferNoAttachmentsSampleCounts = value; }
		}

		public UInt32 MaxColorAttachments {
			get { return m->MaxColorAttachments; }
			set { m->MaxColorAttachments = value; }
		}

		public UInt32 SampledImageColorSampleCounts {
			get { return m->SampledImageColorSampleCounts; }
			set { m->SampledImageColorSampleCounts = value; }
		}

		public UInt32 SampledImageIntegerSampleCounts {
			get { return m->SampledImageIntegerSampleCounts; }
			set { m->SampledImageIntegerSampleCounts = value; }
		}

		public UInt32 SampledImageDepthSampleCounts {
			get { return m->SampledImageDepthSampleCounts; }
			set { m->SampledImageDepthSampleCounts = value; }
		}

		public UInt32 SampledImageStencilSampleCounts {
			get { return m->SampledImageStencilSampleCounts; }
			set { m->SampledImageStencilSampleCounts = value; }
		}

		public UInt32 StorageImageSampleCounts {
			get { return m->StorageImageSampleCounts; }
			set { m->StorageImageSampleCounts = value; }
		}

		public UInt32 MaxSampleMaskWords {
			get { return m->MaxSampleMaskWords; }
			set { m->MaxSampleMaskWords = value; }
		}

		public bool TimestampComputeAndGraphics {
			get { return m->TimestampComputeAndGraphics; }
			set { m->TimestampComputeAndGraphics = value; }
		}

		public float TimestampPeriod {
			get { return m->TimestampPeriod; }
			set { m->TimestampPeriod = value; }
		}

		public UInt32 MaxClipDistances {
			get { return m->MaxClipDistances; }
			set { m->MaxClipDistances = value; }
		}

		public UInt32 MaxCullDistances {
			get { return m->MaxCullDistances; }
			set { m->MaxCullDistances = value; }
		}

		public UInt32 MaxCombinedClipAndCullDistances {
			get { return m->MaxCombinedClipAndCullDistances; }
			set { m->MaxCombinedClipAndCullDistances = value; }
		}

		public UInt32 DiscreteQueuePriorities {
			get { return m->DiscreteQueuePriorities; }
			set { m->DiscreteQueuePriorities = value; }
		}

		public float PointSizeRange {
			get { return m->PointSizeRange; }
			set { m->PointSizeRange = value; }
		}

		public float LineWidthRange {
			get { return m->LineWidthRange; }
			set { m->LineWidthRange = value; }
		}

		public float PointSizeGranularity {
			get { return m->PointSizeGranularity; }
			set { m->PointSizeGranularity = value; }
		}

		public float LineWidthGranularity {
			get { return m->LineWidthGranularity; }
			set { m->LineWidthGranularity = value; }
		}

		public bool StrictLines {
			get { return m->StrictLines; }
			set { m->StrictLines = value; }
		}

		public bool StandardSampleLocations {
			get { return m->StandardSampleLocations; }
			set { m->StandardSampleLocations = value; }
		}

		public DeviceSize OptimalBufferCopyOffsetAlignment {
			get { return m->OptimalBufferCopyOffsetAlignment; }
			set { m->OptimalBufferCopyOffsetAlignment = value; }
		}

		public DeviceSize OptimalBufferCopyRowPitchAlignment {
			get { return m->OptimalBufferCopyRowPitchAlignment; }
			set { m->OptimalBufferCopyRowPitchAlignment = value; }
		}

		public DeviceSize NonCoherentAtomSize {
			get { return m->NonCoherentAtomSize; }
			set { m->NonCoherentAtomSize = value; }
		}
	}

	unsafe public class SemaphoreCreateInfo
	{
		internal Interop.SemaphoreCreateInfo* m;

		public SemaphoreCreateInfo ()
		{
			m = (Interop.SemaphoreCreateInfo*) Interop.Structure.Allocate (typeof (Interop.SemaphoreCreateInfo));
			m->SType = StructureType.SemaphoreCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}
	}

	unsafe public class QueryPoolCreateInfo
	{
		internal Interop.QueryPoolCreateInfo* m;

		public QueryPoolCreateInfo ()
		{
			m = (Interop.QueryPoolCreateInfo*) Interop.Structure.Allocate (typeof (Interop.QueryPoolCreateInfo));
			m->SType = StructureType.QueryPoolCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public QueryType QueryType {
			get { return m->QueryType; }
			set { m->QueryType = value; }
		}

		public UInt32 QueryCount {
			get { return m->QueryCount; }
			set { m->QueryCount = value; }
		}

		public UInt32 PipelineStatistics {
			get { return m->PipelineStatistics; }
			set { m->PipelineStatistics = value; }
		}
	}

	unsafe public class FramebufferCreateInfo
	{
		internal Interop.FramebufferCreateInfo* m;

		public FramebufferCreateInfo ()
		{
			m = (Interop.FramebufferCreateInfo*) Interop.Structure.Allocate (typeof (Interop.FramebufferCreateInfo));
			m->SType = StructureType.FramebufferCreateInfo;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		RenderPass lRenderPass;
		public RenderPass RenderPass {
			get { return lRenderPass; }
			set { lRenderPass = value; m->RenderPass = (IntPtr) value.m; }
		}

		public UInt32 AttachmentCount {
			get { return m->AttachmentCount; }
			set { m->AttachmentCount = value; }
		}

		ImageView lAttachments;
		public ImageView Attachments {
			get { return lAttachments; }
			set { lAttachments = value; m->Attachments = (IntPtr) value.m; }
		}

		public UInt32 Width {
			get { return m->Width; }
			set { m->Width = value; }
		}

		public UInt32 Height {
			get { return m->Height; }
			set { m->Height = value; }
		}

		public UInt32 Layers {
			get { return m->Layers; }
			set { m->Layers = value; }
		}
	}

	unsafe public class DrawIndirectCommand
	{
		internal Interop.DrawIndirectCommand* m;

		public DrawIndirectCommand ()
		{
			m = (Interop.DrawIndirectCommand*) Interop.Structure.Allocate (typeof (Interop.DrawIndirectCommand));
		}

		public UInt32 VertexCount {
			get { return m->VertexCount; }
			set { m->VertexCount = value; }
		}

		public UInt32 InstanceCount {
			get { return m->InstanceCount; }
			set { m->InstanceCount = value; }
		}

		public UInt32 FirstVertex {
			get { return m->FirstVertex; }
			set { m->FirstVertex = value; }
		}

		public UInt32 FirstInstance {
			get { return m->FirstInstance; }
			set { m->FirstInstance = value; }
		}
	}

	unsafe public class DrawIndexedIndirectCommand
	{
		internal Interop.DrawIndexedIndirectCommand* m;

		public DrawIndexedIndirectCommand ()
		{
			m = (Interop.DrawIndexedIndirectCommand*) Interop.Structure.Allocate (typeof (Interop.DrawIndexedIndirectCommand));
		}

		public UInt32 IndexCount {
			get { return m->IndexCount; }
			set { m->IndexCount = value; }
		}

		public UInt32 InstanceCount {
			get { return m->InstanceCount; }
			set { m->InstanceCount = value; }
		}

		public UInt32 FirstIndex {
			get { return m->FirstIndex; }
			set { m->FirstIndex = value; }
		}

		public Int32 VertexOffset {
			get { return m->VertexOffset; }
			set { m->VertexOffset = value; }
		}

		public UInt32 FirstInstance {
			get { return m->FirstInstance; }
			set { m->FirstInstance = value; }
		}
	}

	unsafe public class DispatchIndirectCommand
	{
		internal Interop.DispatchIndirectCommand* m;

		public DispatchIndirectCommand ()
		{
			m = (Interop.DispatchIndirectCommand*) Interop.Structure.Allocate (typeof (Interop.DispatchIndirectCommand));
		}

		public UInt32 X {
			get { return m->X; }
			set { m->X = value; }
		}

		public UInt32 Y {
			get { return m->Y; }
			set { m->Y = value; }
		}

		public UInt32 Z {
			get { return m->Z; }
			set { m->Z = value; }
		}
	}

	unsafe public class SubmitInfo
	{
		internal Interop.SubmitInfo* m;

		public SubmitInfo ()
		{
			m = (Interop.SubmitInfo*) Interop.Structure.Allocate (typeof (Interop.SubmitInfo));
			m->SType = StructureType.SubmitInfo;
		}

		public UInt32 WaitSemaphoreCount {
			get { return m->WaitSemaphoreCount; }
			set { m->WaitSemaphoreCount = value; }
		}

		Semaphore lWaitSemaphores;
		public Semaphore WaitSemaphores {
			get { return lWaitSemaphores; }
			set { lWaitSemaphores = value; m->WaitSemaphores = (IntPtr) value.m; }
		}

		public UInt32 WaitDstStageMask {
			get { return m->WaitDstStageMask; }
			set { m->WaitDstStageMask = value; }
		}

		public UInt32 CommandBufferCount {
			get { return m->CommandBufferCount; }
			set { m->CommandBufferCount = value; }
		}

		CommandBuffer lCommandBuffers;
		public CommandBuffer CommandBuffers {
			get { return lCommandBuffers; }
			set { lCommandBuffers = value; m->CommandBuffers = (IntPtr) value.m; }
		}

		public UInt32 SignalSemaphoreCount {
			get { return m->SignalSemaphoreCount; }
			set { m->SignalSemaphoreCount = value; }
		}

		Semaphore lSignalSemaphores;
		public Semaphore SignalSemaphores {
			get { return lSignalSemaphores; }
			set { lSignalSemaphores = value; m->SignalSemaphores = (IntPtr) value.m; }
		}
	}

	unsafe public class DisplayPropertiesKhr
	{
		internal Interop.DisplayPropertiesKhr* m;

		public DisplayPropertiesKhr ()
		{
			m = (Interop.DisplayPropertiesKhr*) Interop.Structure.Allocate (typeof (Interop.DisplayPropertiesKhr));
		}

		DisplayKhr lDisplay;
		public DisplayKhr Display {
			get { return lDisplay; }
			set { lDisplay = value; m->Display = (IntPtr) value.m; }
		}

		public string DisplayName {
			get { return Marshal.PtrToStringAnsi (m->DisplayName); }
			set { m->DisplayName = Marshal.StringToHGlobalAnsi (value); }
		}

		Extent2D lPhysicalDimensions;
		public Extent2D PhysicalDimensions {
			get { return lPhysicalDimensions; }
			set { lPhysicalDimensions = value; m->PhysicalDimensions = (IntPtr) value.m; }
		}

		Extent2D lPhysicalResolution;
		public Extent2D PhysicalResolution {
			get { return lPhysicalResolution; }
			set { lPhysicalResolution = value; m->PhysicalResolution = (IntPtr) value.m; }
		}

		public SurfaceTransformFlagsKhr SupportedTransforms {
			get { return m->SupportedTransforms; }
			set { m->SupportedTransforms = value; }
		}

		public bool PlaneReorderPossible {
			get { return m->PlaneReorderPossible; }
			set { m->PlaneReorderPossible = value; }
		}

		public bool PersistentContent {
			get { return m->PersistentContent; }
			set { m->PersistentContent = value; }
		}
	}

	unsafe public class DisplayPlanePropertiesKhr
	{
		internal Interop.DisplayPlanePropertiesKhr* m;

		public DisplayPlanePropertiesKhr ()
		{
			m = (Interop.DisplayPlanePropertiesKhr*) Interop.Structure.Allocate (typeof (Interop.DisplayPlanePropertiesKhr));
		}

		DisplayKhr lCurrentDisplay;
		public DisplayKhr CurrentDisplay {
			get { return lCurrentDisplay; }
			set { lCurrentDisplay = value; m->CurrentDisplay = (IntPtr) value.m; }
		}

		public UInt32 CurrentStackIndex {
			get { return m->CurrentStackIndex; }
			set { m->CurrentStackIndex = value; }
		}
	}

	unsafe public class DisplayModeParametersKhr
	{
		internal Interop.DisplayModeParametersKhr* m;

		public DisplayModeParametersKhr ()
		{
			m = (Interop.DisplayModeParametersKhr*) Interop.Structure.Allocate (typeof (Interop.DisplayModeParametersKhr));
		}

		Extent2D lVisibleRegion;
		public Extent2D VisibleRegion {
			get { return lVisibleRegion; }
			set { lVisibleRegion = value; m->VisibleRegion = (IntPtr) value.m; }
		}

		public UInt32 RefreshRate {
			get { return m->RefreshRate; }
			set { m->RefreshRate = value; }
		}
	}

	unsafe public class DisplayModePropertiesKhr
	{
		internal Interop.DisplayModePropertiesKhr* m;

		public DisplayModePropertiesKhr ()
		{
			m = (Interop.DisplayModePropertiesKhr*) Interop.Structure.Allocate (typeof (Interop.DisplayModePropertiesKhr));
		}

		DisplayModeKhr lDisplayMode;
		public DisplayModeKhr DisplayMode {
			get { return lDisplayMode; }
			set { lDisplayMode = value; m->DisplayMode = (IntPtr) value.m; }
		}

		DisplayModeParametersKhr lParameters;
		public DisplayModeParametersKhr Parameters {
			get { return lParameters; }
			set { lParameters = value; m->Parameters = (IntPtr) value.m; }
		}
	}

	unsafe public class DisplayModeCreateInfoKhr
	{
		internal Interop.DisplayModeCreateInfoKhr* m;

		public DisplayModeCreateInfoKhr ()
		{
			m = (Interop.DisplayModeCreateInfoKhr*) Interop.Structure.Allocate (typeof (Interop.DisplayModeCreateInfoKhr));
			m->SType = StructureType.DisplayModeCreateInfoKhr;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		DisplayModeParametersKhr lParameters;
		public DisplayModeParametersKhr Parameters {
			get { return lParameters; }
			set { lParameters = value; m->Parameters = (IntPtr) value.m; }
		}
	}

	unsafe public class DisplayPlaneCapabilitiesKhr
	{
		internal Interop.DisplayPlaneCapabilitiesKhr* m;

		public DisplayPlaneCapabilitiesKhr ()
		{
			m = (Interop.DisplayPlaneCapabilitiesKhr*) Interop.Structure.Allocate (typeof (Interop.DisplayPlaneCapabilitiesKhr));
		}

		public DisplayPlaneAlphaFlagsKhr SupportedAlpha {
			get { return m->SupportedAlpha; }
			set { m->SupportedAlpha = value; }
		}

		Offset2D lMinSrcPosition;
		public Offset2D MinSrcPosition {
			get { return lMinSrcPosition; }
			set { lMinSrcPosition = value; m->MinSrcPosition = (IntPtr) value.m; }
		}

		Offset2D lMaxSrcPosition;
		public Offset2D MaxSrcPosition {
			get { return lMaxSrcPosition; }
			set { lMaxSrcPosition = value; m->MaxSrcPosition = (IntPtr) value.m; }
		}

		Extent2D lMinSrcExtent;
		public Extent2D MinSrcExtent {
			get { return lMinSrcExtent; }
			set { lMinSrcExtent = value; m->MinSrcExtent = (IntPtr) value.m; }
		}

		Extent2D lMaxSrcExtent;
		public Extent2D MaxSrcExtent {
			get { return lMaxSrcExtent; }
			set { lMaxSrcExtent = value; m->MaxSrcExtent = (IntPtr) value.m; }
		}

		Offset2D lMinDstPosition;
		public Offset2D MinDstPosition {
			get { return lMinDstPosition; }
			set { lMinDstPosition = value; m->MinDstPosition = (IntPtr) value.m; }
		}

		Offset2D lMaxDstPosition;
		public Offset2D MaxDstPosition {
			get { return lMaxDstPosition; }
			set { lMaxDstPosition = value; m->MaxDstPosition = (IntPtr) value.m; }
		}

		Extent2D lMinDstExtent;
		public Extent2D MinDstExtent {
			get { return lMinDstExtent; }
			set { lMinDstExtent = value; m->MinDstExtent = (IntPtr) value.m; }
		}

		Extent2D lMaxDstExtent;
		public Extent2D MaxDstExtent {
			get { return lMaxDstExtent; }
			set { lMaxDstExtent = value; m->MaxDstExtent = (IntPtr) value.m; }
		}
	}

	unsafe public class DisplaySurfaceCreateInfoKhr
	{
		internal Interop.DisplaySurfaceCreateInfoKhr* m;

		public DisplaySurfaceCreateInfoKhr ()
		{
			m = (Interop.DisplaySurfaceCreateInfoKhr*) Interop.Structure.Allocate (typeof (Interop.DisplaySurfaceCreateInfoKhr));
			m->SType = StructureType.DisplaySurfaceCreateInfoKhr;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		DisplayModeKhr lDisplayMode;
		public DisplayModeKhr DisplayMode {
			get { return lDisplayMode; }
			set { lDisplayMode = value; m->DisplayMode = (IntPtr) value.m; }
		}

		public UInt32 PlaneIndex {
			get { return m->PlaneIndex; }
			set { m->PlaneIndex = value; }
		}

		public UInt32 PlaneStackIndex {
			get { return m->PlaneStackIndex; }
			set { m->PlaneStackIndex = value; }
		}

		public SurfaceTransformFlagsKhr Transform {
			get { return m->Transform; }
			set { m->Transform = value; }
		}

		public float GlobalAlpha {
			get { return m->GlobalAlpha; }
			set { m->GlobalAlpha = value; }
		}

		public DisplayPlaneAlphaFlagsKhr AlphaMode {
			get { return m->AlphaMode; }
			set { m->AlphaMode = value; }
		}

		Extent2D lImageExtent;
		public Extent2D ImageExtent {
			get { return lImageExtent; }
			set { lImageExtent = value; m->ImageExtent = (IntPtr) value.m; }
		}
	}

	unsafe public class DisplayPresentInfoKhr
	{
		internal Interop.DisplayPresentInfoKhr* m;

		public DisplayPresentInfoKhr ()
		{
			m = (Interop.DisplayPresentInfoKhr*) Interop.Structure.Allocate (typeof (Interop.DisplayPresentInfoKhr));
			m->SType = StructureType.DisplayPresentInfoKhr;
		}

		Rect2D lSrcRect;
		public Rect2D SrcRect {
			get { return lSrcRect; }
			set { lSrcRect = value; m->SrcRect = (IntPtr) value.m; }
		}

		Rect2D lDstRect;
		public Rect2D DstRect {
			get { return lDstRect; }
			set { lDstRect = value; m->DstRect = (IntPtr) value.m; }
		}

		public bool Persistent {
			get { return m->Persistent; }
			set { m->Persistent = value; }
		}
	}

	unsafe public class SurfaceCapabilitiesKhr
	{
		internal Interop.SurfaceCapabilitiesKhr* m;

		public SurfaceCapabilitiesKhr ()
		{
			m = (Interop.SurfaceCapabilitiesKhr*) Interop.Structure.Allocate (typeof (Interop.SurfaceCapabilitiesKhr));
		}

		public UInt32 MinImageCount {
			get { return m->MinImageCount; }
			set { m->MinImageCount = value; }
		}

		public UInt32 MaxImageCount {
			get { return m->MaxImageCount; }
			set { m->MaxImageCount = value; }
		}

		Extent2D lCurrentExtent;
		public Extent2D CurrentExtent {
			get { return lCurrentExtent; }
			set { lCurrentExtent = value; m->CurrentExtent = (IntPtr) value.m; }
		}

		Extent2D lMinImageExtent;
		public Extent2D MinImageExtent {
			get { return lMinImageExtent; }
			set { lMinImageExtent = value; m->MinImageExtent = (IntPtr) value.m; }
		}

		Extent2D lMaxImageExtent;
		public Extent2D MaxImageExtent {
			get { return lMaxImageExtent; }
			set { lMaxImageExtent = value; m->MaxImageExtent = (IntPtr) value.m; }
		}

		public UInt32 MaxImageArrayLayers {
			get { return m->MaxImageArrayLayers; }
			set { m->MaxImageArrayLayers = value; }
		}

		public SurfaceTransformFlagsKhr SupportedTransforms {
			get { return m->SupportedTransforms; }
			set { m->SupportedTransforms = value; }
		}

		public SurfaceTransformFlagsKhr CurrentTransform {
			get { return m->CurrentTransform; }
			set { m->CurrentTransform = value; }
		}

		public CompositeAlphaFlagsKhr SupportedCompositeAlpha {
			get { return m->SupportedCompositeAlpha; }
			set { m->SupportedCompositeAlpha = value; }
		}

		public UInt32 SupportedUsageFlags {
			get { return m->SupportedUsageFlags; }
			set { m->SupportedUsageFlags = value; }
		}
	}

	unsafe public class SurfaceFormatKhr
	{
		internal Interop.SurfaceFormatKhr* m;

		public SurfaceFormatKhr ()
		{
			m = (Interop.SurfaceFormatKhr*) Interop.Structure.Allocate (typeof (Interop.SurfaceFormatKhr));
		}

		public Format Format {
			get { return m->Format; }
			set { m->Format = value; }
		}

		public ColorSpaceKhr ColorSpace {
			get { return m->ColorSpace; }
			set { m->ColorSpace = value; }
		}
	}

	unsafe public class SwapchainCreateInfoKhr
	{
		internal Interop.SwapchainCreateInfoKhr* m;

		public SwapchainCreateInfoKhr ()
		{
			m = (Interop.SwapchainCreateInfoKhr*) Interop.Structure.Allocate (typeof (Interop.SwapchainCreateInfoKhr));
			m->SType = StructureType.SwapchainCreateInfoKhr;
		}

		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		SurfaceKhr lSurface;
		public SurfaceKhr Surface {
			get { return lSurface; }
			set { lSurface = value; m->Surface = (IntPtr) value.m; }
		}

		public UInt32 MinImageCount {
			get { return m->MinImageCount; }
			set { m->MinImageCount = value; }
		}

		public Format ImageFormat {
			get { return m->ImageFormat; }
			set { m->ImageFormat = value; }
		}

		public ColorSpaceKhr ImageColorSpace {
			get { return m->ImageColorSpace; }
			set { m->ImageColorSpace = value; }
		}

		Extent2D lImageExtent;
		public Extent2D ImageExtent {
			get { return lImageExtent; }
			set { lImageExtent = value; m->ImageExtent = (IntPtr) value.m; }
		}

		public UInt32 ImageArrayLayers {
			get { return m->ImageArrayLayers; }
			set { m->ImageArrayLayers = value; }
		}

		public UInt32 ImageUsage {
			get { return m->ImageUsage; }
			set { m->ImageUsage = value; }
		}

		public SharingMode ImageSharingMode {
			get { return m->ImageSharingMode; }
			set { m->ImageSharingMode = value; }
		}

		public UInt32 QueueFamilyIndexCount {
			get { return m->QueueFamilyIndexCount; }
			set { m->QueueFamilyIndexCount = value; }
		}

		public UInt32 QueueFamilyIndices {
			get { return m->QueueFamilyIndices; }
			set { m->QueueFamilyIndices = value; }
		}

		public SurfaceTransformFlagsKhr PreTransform {
			get { return m->PreTransform; }
			set { m->PreTransform = value; }
		}

		public CompositeAlphaFlagsKhr CompositeAlpha {
			get { return m->CompositeAlpha; }
			set { m->CompositeAlpha = value; }
		}

		public PresentModeKhr PresentMode {
			get { return m->PresentMode; }
			set { m->PresentMode = value; }
		}

		public bool Clipped {
			get { return m->Clipped; }
			set { m->Clipped = value; }
		}

		SwapchainKhr lOldSwapchain;
		public SwapchainKhr OldSwapchain {
			get { return lOldSwapchain; }
			set { lOldSwapchain = value; m->OldSwapchain = (IntPtr) value.m; }
		}
	}

	unsafe public class PresentInfoKhr
	{
		internal Interop.PresentInfoKhr* m;

		public PresentInfoKhr ()
		{
			m = (Interop.PresentInfoKhr*) Interop.Structure.Allocate (typeof (Interop.PresentInfoKhr));
			m->SType = StructureType.PresentInfoKhr;
		}

		public UInt32 WaitSemaphoreCount {
			get { return m->WaitSemaphoreCount; }
			set { m->WaitSemaphoreCount = value; }
		}

		Semaphore lWaitSemaphores;
		public Semaphore WaitSemaphores {
			get { return lWaitSemaphores; }
			set { lWaitSemaphores = value; m->WaitSemaphores = (IntPtr) value.m; }
		}

		public UInt32 SwapchainCount {
			get { return m->SwapchainCount; }
			set { m->SwapchainCount = value; }
		}

		SwapchainKhr lSwapchains;
		public SwapchainKhr Swapchains {
			get { return lSwapchains; }
			set { lSwapchains = value; m->Swapchains = (IntPtr) value.m; }
		}

		public UInt32 ImageIndices {
			get { return m->ImageIndices; }
			set { m->ImageIndices = value; }
		}

		public Result Results {
			get { return m->Results; }
			set { m->Results = value; }
		}
	}

	unsafe public class DebugReportCallbackCreateInfoExt
	{
		internal Interop.DebugReportCallbackCreateInfoExt* m;

		public DebugReportCallbackCreateInfoExt ()
		{
			m = (Interop.DebugReportCallbackCreateInfoExt*) Interop.Structure.Allocate (typeof (Interop.DebugReportCallbackCreateInfoExt));
			m->SType = StructureType.DebugReportCreateInfoExt;
		}

		public DebugReportFlagsExt Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public IntPtr PfnCallback {
			get { return m->PfnCallback; }
			set { m->PfnCallback = value; }
		}

		public IntPtr UserData {
			get { return m->UserData; }
			set { m->UserData = value; }
		}
	}
}
