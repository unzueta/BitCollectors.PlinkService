﻿// This file is part of BitCollectors Plink Service.
// Copyright 2013 Adam Plocher (BitCollectors)
// 
// BitCollectors Plink Service is free software: you can redistribute it and/or 
// modify it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// BitCollectors Plink Service is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
// or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for 
// more details.
// 
// You should have received a copy of the GNU General Public License along with 
// BitCollectors Plink Service.  If not, see <http://www.gnu.org/licenses/>.

using System.ServiceProcess;

namespace BitCollectors.PlinkService.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new Service1() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
