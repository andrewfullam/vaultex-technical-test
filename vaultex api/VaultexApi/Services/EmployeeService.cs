﻿using System.Threading.Tasks;
using VaultexApi.Models;
using VaultexApi.Repositories.Abstractions;
using VaultexApi.Services.Abstractions;

namespace VaultexApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<APIResponseModel<EmployeeModel>> Get(int pageNumber, int pageSize)
        {
            return await _employeeRepository.Get(pageNumber, pageSize);
        }
    }
}
