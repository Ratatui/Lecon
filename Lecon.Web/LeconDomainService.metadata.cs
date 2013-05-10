
namespace Lecon.Web
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.Data.Objects.DataClasses;
	using System.Linq;
	using System.ServiceModel.DomainServices.Hosting;
	using System.ServiceModel.DomainServices.Server;


	// The MetadataTypeAttribute identifies AssemblyMetadata as the class
	// that carries additional metadata for the Assembly class.
	[MetadataTypeAttribute(typeof(Assembly.AssemblyMetadata))]
	public partial class Assembly
	{

		// This class allows you to attach custom attributes to properties
		// of the Assembly class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class AssemblyMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private AssemblyMetadata()
			{
			}

			public Body Body { get; set; }

			public int BodyId { get; set; }

			public Cooler Cooler { get; set; }

			public int CoolerId { get; set; }

			public CPU CPU { get; set; }

			public int CPUId { get; set; }

			public GPU GPU { get; set; }

			public int GPUId { get; set; }

			public HardDrive HardDrive { get; set; }

			public int HardDriveId { get; set; }

			public int Id { get; set; }

			public Memory Memory { get; set; }

			public int MemoryId { get; set; }

			public Motherboard Motherboard { get; set; }

			public int MotherBoardId { get; set; }

			public PSU PSU { get; set; }

			public int PSUId { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies BodyMetadata as the class
	// that carries additional metadata for the Body class.
	[MetadataTypeAttribute(typeof(Body.BodyMetadata))]
	public partial class Body
	{

		// This class allows you to attach custom attributes to properties
		// of the Body class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class BodyMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private BodyMetadata()
			{
			}

			public EntityCollection<Assembly> Assemblys { get; set; }

			public Cooler Cooler { get; set; }

			public Nullable<int> CoolerId { get; set; }

			public Device Device { get; set; }

			public int DeviceId { get; set; }

			public FormFactor FormFactor { get; set; }

			public int FormFactorId { get; set; }

			public int Id { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies ChipsetMetadata as the class
	// that carries additional metadata for the Chipset class.
	[MetadataTypeAttribute(typeof(Chipset.ChipsetMetadata))]
	public partial class Chipset
	{

		// This class allows you to attach custom attributes to properties
		// of the Chipset class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class ChipsetMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private ChipsetMetadata()
			{
			}

			public int Id { get; set; }

			public EntityCollection<Motherboard> Motherboard { get; set; }

			public string Name { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies CoolerMetadata as the class
	// that carries additional metadata for the Cooler class.
	[MetadataTypeAttribute(typeof(Cooler.CoolerMetadata))]
	public partial class Cooler
	{

		// This class allows you to attach custom attributes to properties
		// of the Cooler class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class CoolerMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private CoolerMetadata()
			{
			}

			public EntityCollection<Assembly> Assembly { get; set; }

			public EntityCollection<Body> Bodys { get; set; }

			public Device Device { get; set; }

			public int DeviceId { get; set; }

			public DeviceType DeviceType { get; set; }

			public int DeviceTypeId { get; set; }

			public EntityCollection<GPU> GPUs { get; set; }

			public int Id { get; set; }

			public PowerType PowerType { get; set; }

			public int PowerTypeId { get; set; }

			public short Rotation { get; set; }

			public short Size { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies CPUMetadata as the class
	// that carries additional metadata for the CPU class.
	[MetadataTypeAttribute(typeof(CPU.CPUMetadata))]
	public partial class CPU
	{

		// This class allows you to attach custom attributes to properties
		// of the CPU class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class CPUMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private CPUMetadata()
			{
			}

			public EntityCollection<Assembly> Assemblys { get; set; }

			public short Cores { get; set; }

			public Device Device { get; set; }

			public int DeviceId { get; set; }

			public double Frequency { get; set; }

			public GPU GPU { get; set; }

			public Nullable<int> GPUId { get; set; }

			public int Id { get; set; }

			public Socket Socket { get; set; }

			public int SocketId { get; set; }

			public short СacheOne { get; set; }

			public short СacheThree { get; set; }

			public short СacheTwo { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies DeviceMetadata as the class
	// that carries additional metadata for the Device class.
	[MetadataTypeAttribute(typeof(Device.DeviceMetadata))]
	public partial class Device
	{

		// This class allows you to attach custom attributes to properties
		// of the Device class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class DeviceMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private DeviceMetadata()
			{
			}

			public EntityCollection<Body> Bodys { get; set; }

			public EntityCollection<Cooler> Coolers { get; set; }

			public EntityCollection<CPU> CPUs { get; set; }

			public EntityCollection<GPU> GPUs { get; set; }

			public EntityCollection<HardDrive> HardDrives { get; set; }

			public int Id { get; set; }

			public Manufacturer Manufacturer { get; set; }

			public int ManufacturerId { get; set; }

			public EntityCollection<Memory> Memorys { get; set; }

			public string Model { get; set; }

			public EntityCollection<Motherboard> Motherboards { get; set; }

			public double Price { get; set; }

			public EntityCollection<PSU> PSUs { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies DeviceTypeMetadata as the class
	// that carries additional metadata for the DeviceType class.
	[MetadataTypeAttribute(typeof(DeviceType.DeviceTypeMetadata))]
	public partial class DeviceType
	{

		// This class allows you to attach custom attributes to properties
		// of the DeviceType class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class DeviceTypeMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private DeviceTypeMetadata()
			{
			}

			public EntityCollection<Cooler> Coolers { get; set; }

			public int Id { get; set; }

			public string Name { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies FormFactorMetadata as the class
	// that carries additional metadata for the FormFactor class.
	[MetadataTypeAttribute(typeof(FormFactor.FormFactorMetadata))]
	public partial class FormFactor
	{

		// This class allows you to attach custom attributes to properties
		// of the FormFactor class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class FormFactorMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private FormFactorMetadata()
			{
			}

			public EntityCollection<Body> Bodys { get; set; }

			public int Id { get; set; }

			public EntityCollection<Motherboard> Motherboards { get; set; }

			public string Name { get; set; }

			public EntityCollection<PSU> PSUs { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies GPUMetadata as the class
	// that carries additional metadata for the GPU class.
	[MetadataTypeAttribute(typeof(GPU.GPUMetadata))]
	public partial class GPU
	{

		// This class allows you to attach custom attributes to properties
		// of the GPU class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class GPUMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private GPUMetadata()
			{
			}

			public bool AdditionalPower { get; set; }

			public EntityCollection<Assembly> AssemblyCollection { get; set; }

			public Cooler Cooler { get; set; }

			public int CoolerId { get; set; }

			public EntityCollection<CPU> CPUs { get; set; }

			public Device Device { get; set; }

			public int DeviceId { get; set; }

			public GraphicChip GraphicChip { get; set; }

			public int GraphicChipId { get; set; }

			public int Id { get; set; }

			public EntityCollection<Motherboard> Motherboards { get; set; }

			public short Power { get; set; }

			public short Size { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies GraphicChipMetadata as the class
	// that carries additional metadata for the GraphicChip class.
	[MetadataTypeAttribute(typeof(GraphicChip.GraphicChipMetadata))]
	public partial class GraphicChip
	{

		// This class allows you to attach custom attributes to properties
		// of the GraphicChip class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class GraphicChipMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private GraphicChipMetadata()
			{
			}

			public double Frequency { get; set; }

			public EntityCollection<GPU> GPUs { get; set; }

			public int Id { get; set; }

			public string Name { get; set; }

			public short Сapacity { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies HardDriveMetadata as the class
	// that carries additional metadata for the HardDrive class.
	[MetadataTypeAttribute(typeof(HardDrive.HardDriveMetadata))]
	public partial class HardDrive
	{

		// This class allows you to attach custom attributes to properties
		// of the HardDrive class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class HardDriveMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private HardDriveMetadata()
			{
			}

			public EntityCollection<Assembly> Assemblys { get; set; }

			public short Cache { get; set; }

			public Device Device { get; set; }

			public int DeviceId { get; set; }

			public int Id { get; set; }

			public PowerType PowerType { get; set; }

			public int PowerTypeId { get; set; }

			public short Rotation { get; set; }

			public short Size { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies ManufacturerMetadata as the class
	// that carries additional metadata for the Manufacturer class.
	[MetadataTypeAttribute(typeof(Manufacturer.ManufacturerMetadata))]
	public partial class Manufacturer
	{

		// This class allows you to attach custom attributes to properties
		// of the Manufacturer class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class ManufacturerMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private ManufacturerMetadata()
			{
			}

			public EntityCollection<Device> Devices { get; set; }

			public int Id { get; set; }

			public string Name { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies MemoryMetadata as the class
	// that carries additional metadata for the Memory class.
	[MetadataTypeAttribute(typeof(Memory.MemoryMetadata))]
	public partial class Memory
	{

		// This class allows you to attach custom attributes to properties
		// of the Memory class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class MemoryMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private MemoryMetadata()
			{
			}

			public EntityCollection<Assembly> Assemblys { get; set; }

			public Device Device { get; set; }

			public int DeviceId { get; set; }

			public short Frequency { get; set; }

			public int Id { get; set; }

			public MemoryType MemoryType { get; set; }

			public int MemoryTypeId { get; set; }

			public short Size { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies MemoryTypeMetadata as the class
	// that carries additional metadata for the MemoryType class.
	[MetadataTypeAttribute(typeof(MemoryType.MemoryTypeMetadata))]
	public partial class MemoryType
	{

		// This class allows you to attach custom attributes to properties
		// of the MemoryType class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class MemoryTypeMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private MemoryTypeMetadata()
			{
			}

			public int Id { get; set; }

			public EntityCollection<Memory> Memorys { get; set; }

			public EntityCollection<Motherboard> Motherboard { get; set; }

			public string Name { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies MotherboardMetadata as the class
	// that carries additional metadata for the Motherboard class.
	[MetadataTypeAttribute(typeof(Motherboard.MotherboardMetadata))]
	public partial class Motherboard
	{

		// This class allows you to attach custom attributes to properties
		// of the Motherboard class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class MotherboardMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private MotherboardMetadata()
			{
			}

			public EntityCollection<Assembly> Assemblys { get; set; }

			public Chipset Chipset { get; set; }

			public int ChipsetId { get; set; }

			public Device Device { get; set; }

			public int DeviceId { get; set; }

			public FormFactor FormFactor { get; set; }

			public int FormFactorId { get; set; }

			public short Frequency { get; set; }

			public GPU GPU { get; set; }

			public Nullable<int> GPUId { get; set; }

			public int Id { get; set; }

			public MemoryType MemoryType { get; set; }

			public int MemoryTypeId { get; set; }

			public PowerType PowerType { get; set; }

			public int PowerTypeId { get; set; }

			public short SATA { get; set; }

			public Socket Socket { get; set; }

			public int SocketId { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies PowerTypeMetadata as the class
	// that carries additional metadata for the PowerType class.
	[MetadataTypeAttribute(typeof(PowerType.PowerTypeMetadata))]
	public partial class PowerType
	{

		// This class allows you to attach custom attributes to properties
		// of the PowerType class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class PowerTypeMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private PowerTypeMetadata()
			{
			}

			public EntityCollection<Cooler> Coolers { get; set; }

			public EntityCollection<HardDrive> HardDrives { get; set; }

			public int Id { get; set; }

			public EntityCollection<Motherboard> Motherboards { get; set; }

			public string Name { get; set; }

			public EntityCollection<PSU> PSUs { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies PSUMetadata as the class
	// that carries additional metadata for the PSU class.
	[MetadataTypeAttribute(typeof(PSU.PSUMetadata))]
	public partial class PSU
	{

		// This class allows you to attach custom attributes to properties
		// of the PSU class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class PSUMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private PSUMetadata()
			{
			}

			public EntityCollection<Assembly> Assemblys { get; set; }

			public Device Device { get; set; }

			public int DeviceId { get; set; }

			public FormFactor FormFactor { get; set; }

			public int FormFactorId { get; set; }

			public int Id { get; set; }

			public short IDE { get; set; }

			public PowerType PowerType { get; set; }

			public int PowerTypeId { get; set; }

			public short SATA { get; set; }
		}
	}

	// The MetadataTypeAttribute identifies SocketMetadata as the class
	// that carries additional metadata for the Socket class.
	[MetadataTypeAttribute(typeof(Socket.SocketMetadata))]
	public partial class Socket
	{

		// This class allows you to attach custom attributes to properties
		// of the Socket class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class SocketMetadata
		{

			// Metadata classes are not meant to be instantiated.
			private SocketMetadata()
			{
			}

			public EntityCollection<CPU> CPUs { get; set; }

			public int Id { get; set; }

			public EntityCollection<Motherboard> Motherboards { get; set; }

			public string Name { get; set; }
		}
	}
}
