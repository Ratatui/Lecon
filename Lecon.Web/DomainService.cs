using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecon.Web
{
	public partial class LeconDomainService
	{
		public IQueryable<Cooler> GetCoolersForDeviceTypeName(string Name)
		{
			var deviceType = this.ObjectContext.DeviceTypes.Single(type => type.Name == Name);
			return this.ObjectContext.Coolers.Include("Device").Where(cooler =>  cooler.DeviceTypeId == deviceType.Id);
		}
	}
}