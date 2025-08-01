﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteLagoon.Application.Common.Interfaces
{
	public interface IUnitOfWork
	{
		IVillaRepository Villa { get; }
		IVillaNumberRepository VillaNumber { get; }	
		IAmenityRepository Amenity { get; }
		IBookingRepository Booking { get; }	
		IAppUserRepository User { get; }	
		 void Save();
	}
}
