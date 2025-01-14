using DataAccessKatmanı.Context;
using DataAccessKatmanı.Repositories;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessKatmanı.Services
{
    public class AttendanceService
    {
        private readonly AttendanceService attendanceService;
        private AttendanceRepository _attendanceRepository;

        public AttendanceService(AttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }
    }
}
