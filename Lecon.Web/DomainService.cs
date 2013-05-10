
namespace Lecon.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // Implements application logic using the LeconEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class DomainService : LinqToEntitiesDomainService<LeconEntities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Assemblys' query.
        public IQueryable<Assembly> GetAssemblys()
        {
            return this.ObjectContext.Assemblys;
        }

        public void InsertAssembly(Assembly assembly)
        {
            if ((assembly.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(assembly, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Assemblys.AddObject(assembly);
            }
        }

        public void UpdateAssembly(Assembly currentAssembly)
        {
            this.ObjectContext.Assemblys.AttachAsModified(currentAssembly, this.ChangeSet.GetOriginal(currentAssembly));
        }

        public void DeleteAssembly(Assembly assembly)
        {
            if ((assembly.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(assembly, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Assemblys.Attach(assembly);
                this.ObjectContext.Assemblys.DeleteObject(assembly);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Bodys' query.
        public IQueryable<Body> GetBodys()
        {
            return this.ObjectContext.Bodys;
        }

        public void InsertBody(Body body)
        {
            if ((body.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(body, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Bodys.AddObject(body);
            }
        }

        public void UpdateBody(Body currentBody)
        {
            this.ObjectContext.Bodys.AttachAsModified(currentBody, this.ChangeSet.GetOriginal(currentBody));
        }

        public void DeleteBody(Body body)
        {
            if ((body.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(body, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Bodys.Attach(body);
                this.ObjectContext.Bodys.DeleteObject(body);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Chipsets' query.
        public IQueryable<Chipset> GetChipsets()
        {
            return this.ObjectContext.Chipsets;
        }

        public void InsertChipset(Chipset chipset)
        {
            if ((chipset.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(chipset, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Chipsets.AddObject(chipset);
            }
        }

        public void UpdateChipset(Chipset currentChipset)
        {
            this.ObjectContext.Chipsets.AttachAsModified(currentChipset, this.ChangeSet.GetOriginal(currentChipset));
        }

        public void DeleteChipset(Chipset chipset)
        {
            if ((chipset.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(chipset, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Chipsets.Attach(chipset);
                this.ObjectContext.Chipsets.DeleteObject(chipset);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Coolers' query.
        public IQueryable<Cooler> GetCoolers()
        {
            return this.ObjectContext.Coolers;
        }

        public void InsertCooler(Cooler cooler)
        {
            if ((cooler.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cooler, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Coolers.AddObject(cooler);
            }
        }

        public void UpdateCooler(Cooler currentCooler)
        {
            this.ObjectContext.Coolers.AttachAsModified(currentCooler, this.ChangeSet.GetOriginal(currentCooler));
        }

        public void DeleteCooler(Cooler cooler)
        {
            if ((cooler.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cooler, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Coolers.Attach(cooler);
                this.ObjectContext.Coolers.DeleteObject(cooler);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'CPUs' query.
        public IQueryable<CPU> GetCPUs()
        {
            return this.ObjectContext.CPUs;
        }

        public void InsertCPU(CPU cPU)
        {
            if ((cPU.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cPU, EntityState.Added);
            }
            else
            {
                this.ObjectContext.CPUs.AddObject(cPU);
            }
        }

        public void UpdateCPU(CPU currentCPU)
        {
            this.ObjectContext.CPUs.AttachAsModified(currentCPU, this.ChangeSet.GetOriginal(currentCPU));
        }

        public void DeleteCPU(CPU cPU)
        {
            if ((cPU.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cPU, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.CPUs.Attach(cPU);
                this.ObjectContext.CPUs.DeleteObject(cPU);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Devices' query.
        public IQueryable<Device> GetDevices()
        {
            return this.ObjectContext.Devices;
        }

        public void InsertDevice(Device device)
        {
            if ((device.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(device, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Devices.AddObject(device);
            }
        }

        public void UpdateDevice(Device currentDevice)
        {
            this.ObjectContext.Devices.AttachAsModified(currentDevice, this.ChangeSet.GetOriginal(currentDevice));
        }

        public void DeleteDevice(Device device)
        {
            if ((device.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(device, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Devices.Attach(device);
                this.ObjectContext.Devices.DeleteObject(device);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'DeviceTypes' query.
        public IQueryable<DeviceType> GetDeviceTypes()
        {
            return this.ObjectContext.DeviceTypes;
        }

        public void InsertDeviceType(DeviceType deviceType)
        {
            if ((deviceType.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(deviceType, EntityState.Added);
            }
            else
            {
                this.ObjectContext.DeviceTypes.AddObject(deviceType);
            }
        }

        public void UpdateDeviceType(DeviceType currentDeviceType)
        {
            this.ObjectContext.DeviceTypes.AttachAsModified(currentDeviceType, this.ChangeSet.GetOriginal(currentDeviceType));
        }

        public void DeleteDeviceType(DeviceType deviceType)
        {
            if ((deviceType.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(deviceType, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.DeviceTypes.Attach(deviceType);
                this.ObjectContext.DeviceTypes.DeleteObject(deviceType);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'FormFactors' query.
        public IQueryable<FormFactor> GetFormFactors()
        {
            return this.ObjectContext.FormFactors;
        }

        public void InsertFormFactor(FormFactor formFactor)
        {
            if ((formFactor.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(formFactor, EntityState.Added);
            }
            else
            {
                this.ObjectContext.FormFactors.AddObject(formFactor);
            }
        }

        public void UpdateFormFactor(FormFactor currentFormFactor)
        {
            this.ObjectContext.FormFactors.AttachAsModified(currentFormFactor, this.ChangeSet.GetOriginal(currentFormFactor));
        }

        public void DeleteFormFactor(FormFactor formFactor)
        {
            if ((formFactor.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(formFactor, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.FormFactors.Attach(formFactor);
                this.ObjectContext.FormFactors.DeleteObject(formFactor);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'GPUs' query.
        public IQueryable<GPU> GetGPUs()
        {
            return this.ObjectContext.GPUs;
        }

        public void InsertGPU(GPU gPU)
        {
            if ((gPU.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(gPU, EntityState.Added);
            }
            else
            {
                this.ObjectContext.GPUs.AddObject(gPU);
            }
        }

        public void UpdateGPU(GPU currentGPU)
        {
            this.ObjectContext.GPUs.AttachAsModified(currentGPU, this.ChangeSet.GetOriginal(currentGPU));
        }

        public void DeleteGPU(GPU gPU)
        {
            if ((gPU.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(gPU, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.GPUs.Attach(gPU);
                this.ObjectContext.GPUs.DeleteObject(gPU);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'GraphicChips' query.
        public IQueryable<GraphicChip> GetGraphicChips()
        {
            return this.ObjectContext.GraphicChips;
        }

        public void InsertGraphicChip(GraphicChip graphicChip)
        {
            if ((graphicChip.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(graphicChip, EntityState.Added);
            }
            else
            {
                this.ObjectContext.GraphicChips.AddObject(graphicChip);
            }
        }

        public void UpdateGraphicChip(GraphicChip currentGraphicChip)
        {
            this.ObjectContext.GraphicChips.AttachAsModified(currentGraphicChip, this.ChangeSet.GetOriginal(currentGraphicChip));
        }

        public void DeleteGraphicChip(GraphicChip graphicChip)
        {
            if ((graphicChip.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(graphicChip, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.GraphicChips.Attach(graphicChip);
                this.ObjectContext.GraphicChips.DeleteObject(graphicChip);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'HardDrives' query.
        public IQueryable<HardDrive> GetHardDrives()
        {
            return this.ObjectContext.HardDrives;
        }

        public void InsertHardDrive(HardDrive hardDrive)
        {
            if ((hardDrive.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(hardDrive, EntityState.Added);
            }
            else
            {
                this.ObjectContext.HardDrives.AddObject(hardDrive);
            }
        }

        public void UpdateHardDrive(HardDrive currentHardDrive)
        {
            this.ObjectContext.HardDrives.AttachAsModified(currentHardDrive, this.ChangeSet.GetOriginal(currentHardDrive));
        }

        public void DeleteHardDrive(HardDrive hardDrive)
        {
            if ((hardDrive.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(hardDrive, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.HardDrives.Attach(hardDrive);
                this.ObjectContext.HardDrives.DeleteObject(hardDrive);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Manufacturers' query.
        public IQueryable<Manufacturer> GetManufacturers()
        {
            return this.ObjectContext.Manufacturers;
        }

        public void InsertManufacturer(Manufacturer manufacturer)
        {
            if ((manufacturer.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(manufacturer, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Manufacturers.AddObject(manufacturer);
            }
        }

        public void UpdateManufacturer(Manufacturer currentManufacturer)
        {
            this.ObjectContext.Manufacturers.AttachAsModified(currentManufacturer, this.ChangeSet.GetOriginal(currentManufacturer));
        }

        public void DeleteManufacturer(Manufacturer manufacturer)
        {
            if ((manufacturer.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(manufacturer, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Manufacturers.Attach(manufacturer);
                this.ObjectContext.Manufacturers.DeleteObject(manufacturer);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Memorys' query.
        public IQueryable<Memory> GetMemorys()
        {
            return this.ObjectContext.Memorys;
        }

        public void InsertMemory(Memory memory)
        {
            if ((memory.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(memory, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Memorys.AddObject(memory);
            }
        }

        public void UpdateMemory(Memory currentMemory)
        {
            this.ObjectContext.Memorys.AttachAsModified(currentMemory, this.ChangeSet.GetOriginal(currentMemory));
        }

        public void DeleteMemory(Memory memory)
        {
            if ((memory.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(memory, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Memorys.Attach(memory);
                this.ObjectContext.Memorys.DeleteObject(memory);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'MemoryTypes' query.
        public IQueryable<MemoryType> GetMemoryTypes()
        {
            return this.ObjectContext.MemoryTypes;
        }

        public void InsertMemoryType(MemoryType memoryType)
        {
            if ((memoryType.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(memoryType, EntityState.Added);
            }
            else
            {
                this.ObjectContext.MemoryTypes.AddObject(memoryType);
            }
        }

        public void UpdateMemoryType(MemoryType currentMemoryType)
        {
            this.ObjectContext.MemoryTypes.AttachAsModified(currentMemoryType, this.ChangeSet.GetOriginal(currentMemoryType));
        }

        public void DeleteMemoryType(MemoryType memoryType)
        {
            if ((memoryType.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(memoryType, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.MemoryTypes.Attach(memoryType);
                this.ObjectContext.MemoryTypes.DeleteObject(memoryType);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Motherboards' query.
        public IQueryable<Motherboard> GetMotherboards()
        {
            return this.ObjectContext.Motherboards;
        }

        public void InsertMotherboard(Motherboard motherboard)
        {
            if ((motherboard.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(motherboard, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Motherboards.AddObject(motherboard);
            }
        }

        public void UpdateMotherboard(Motherboard currentMotherboard)
        {
            this.ObjectContext.Motherboards.AttachAsModified(currentMotherboard, this.ChangeSet.GetOriginal(currentMotherboard));
        }

        public void DeleteMotherboard(Motherboard motherboard)
        {
            if ((motherboard.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(motherboard, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Motherboards.Attach(motherboard);
                this.ObjectContext.Motherboards.DeleteObject(motherboard);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'PowerTypes' query.
        public IQueryable<PowerType> GetPowerTypes()
        {
            return this.ObjectContext.PowerTypes;
        }

        public void InsertPowerType(PowerType powerType)
        {
            if ((powerType.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(powerType, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PowerTypes.AddObject(powerType);
            }
        }

        public void UpdatePowerType(PowerType currentPowerType)
        {
            this.ObjectContext.PowerTypes.AttachAsModified(currentPowerType, this.ChangeSet.GetOriginal(currentPowerType));
        }

        public void DeletePowerType(PowerType powerType)
        {
            if ((powerType.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(powerType, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.PowerTypes.Attach(powerType);
                this.ObjectContext.PowerTypes.DeleteObject(powerType);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'PSUs' query.
        public IQueryable<PSU> GetPSUs()
        {
            return this.ObjectContext.PSUs;
        }

        public void InsertPSU(PSU pSU)
        {
            if ((pSU.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pSU, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PSUs.AddObject(pSU);
            }
        }

        public void UpdatePSU(PSU currentPSU)
        {
            this.ObjectContext.PSUs.AttachAsModified(currentPSU, this.ChangeSet.GetOriginal(currentPSU));
        }

        public void DeletePSU(PSU pSU)
        {
            if ((pSU.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pSU, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.PSUs.Attach(pSU);
                this.ObjectContext.PSUs.DeleteObject(pSU);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Sockets' query.
        public IQueryable<Socket> GetSockets()
        {
            return this.ObjectContext.Sockets;
        }

        public void InsertSocket(Socket socket)
        {
            if ((socket.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(socket, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Sockets.AddObject(socket);
            }
        }

        public void UpdateSocket(Socket currentSocket)
        {
            this.ObjectContext.Sockets.AttachAsModified(currentSocket, this.ChangeSet.GetOriginal(currentSocket));
        }

        public void DeleteSocket(Socket socket)
        {
            if ((socket.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(socket, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Sockets.Attach(socket);
                this.ObjectContext.Sockets.DeleteObject(socket);
            }
        }
    }
}


