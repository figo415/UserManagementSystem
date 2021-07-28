using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Megarobo.KunPengLIMS.Domain.RepoDefinitions;

namespace Megarobo.KunPengLIMS.Infrastructure.RepoImplementations
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly DbContext _dbContext;

        public RepositoryWrapper(LimsDbContext aasContext)
        {
            _dbContext = aasContext;
        }

        #region System management module

        private readonly IUserRepository _userRepo;
        private readonly IUserSkillRepository _userSkillRepo;
        private readonly IUserDepartmentRoleRepository _userDepartmentRoleRepo;
        private readonly ISkillRepository _skillRepo;
        private readonly IDepartmentRepository _departmentRepo;
        private readonly IRoleRepository _roleRepo;
        private readonly IRoleMenuRepository _roleMenuRepo;
        private readonly IMenuRepository _menuRepo;
        private readonly IDictItemRepository _dictItemRepo;
        private readonly ILogItemRepository _logItemRepo;

        public IUserRepository UserRepo => _userRepo ?? new UserRepository(_dbContext);

        public IUserSkillRepository UserSkillRepo => _userSkillRepo ?? new UserSkillRepository(_dbContext);

        public IUserDepartmentRoleRepository UserDepartmentRoleRepo => _userDepartmentRoleRepo ?? new UserDepartmentRoleRepository(_dbContext);

        public ISkillRepository SkillRepo => _skillRepo ?? new SkillRepository(_dbContext);

        public IDepartmentRepository DepartmentRepo => _departmentRepo ?? new DepartmentRepository(_dbContext);

        public IRoleRepository RoleRepo => _roleRepo ?? new RoleRepository(_dbContext);

        public IRoleMenuRepository RoleMenuRepo => _roleMenuRepo ?? new RoleMenuRepository(_dbContext);

        public IMenuRepository MenuRepo => _menuRepo ?? new MenuRepository(_dbContext);   

        public IDictItemRepository DictItemRepo => _dictItemRepo ?? new DictItemRepository(_dbContext);

        public ILogItemRepository LogItemRepo => _logItemRepo ?? new LogItemRepository(_dbContext);

        #endregion

        #region Basic data configuration module and Sample management module

        private readonly ISpeciesRepository _speciesRepo;
        private readonly ICellRepository _cellRepo;
        //private readonly IPositionRepository _positionRepo;
        private readonly ILabwareRepository _labwareRepo;
        private readonly IReagentRepository _reagentRepo;
        private readonly IDeviceRepository _deviceRepo;
        private readonly ISampleRepository _sampleRepo;
        public ISpeciesRepository SpeciesRepo => _speciesRepo ?? new SpeciesRepository(_dbContext);

        public ICellRepository CellRepo => _cellRepo ?? new CellRepository(_dbContext);

        //public IPositionRepository PositionRepo => _positionRepo ?? new PositionRepository(_dbContext);

        public ILabwareRepository LabwareRepo => _labwareRepo ?? new LabwareRepository(_dbContext);

        public IReagentRepository ReagentRepo => _reagentRepo ?? new ReagentRepository(_dbContext);

        public IDeviceRepository DeviceRepo => _deviceRepo ?? new DeviceRepository(_dbContext);

        public ISampleRepository SampleRepo => _sampleRepo ?? new SampleRepository(_dbContext);

        #endregion

        #region Production management module

        private readonly IOrderRepository _orderRepo;
        private readonly IMolecularCloningRepository _molecularCloningRepo;
        private readonly IPlasmidPurificationRepository _plasmidPurificationRepo;
        private readonly IQpcrDetectionRepository _qpcrDetectionRepo;
        private readonly ISdsPageDetectionRepository _sdsPageDetectionRepo;
        private readonly ISterilityDetectionRepository _sterilityDetectionRepo;
        private readonly IStockInRepository _stockInRepo;
        private readonly IShipmentRepository _shipmentRepo;

        public IOrderRepository OrderRepo => _orderRepo ?? new OrderRepository(_dbContext);

        public IMolecularCloningRepository MolecularCloningRepo => _molecularCloningRepo ?? new MolecularCloningRepository(_dbContext);

        public IPlasmidPurificationRepository PlasmidPurificationRepo => _plasmidPurificationRepo ?? new PlasmidPurificationRepository(_dbContext);

        public IQpcrDetectionRepository QpcrDetectionRepo => _qpcrDetectionRepo ?? new QpcrDetectionRepository(_dbContext);

        public ISdsPageDetectionRepository SdsPageDetectionRepo => _sdsPageDetectionRepo ?? new SdsPageDetectionRepository(_dbContext);

        public ISterilityDetectionRepository SterilityDetectionRepo => _sterilityDetectionRepo ?? new SterilityDetectionRepository(_dbContext);

        public IStockInRepository StockInRepo => _stockInRepo ?? new StockInRepository(_dbContext);

        public IShipmentRepository ShipmentRepo => _shipmentRepo ?? new ShipmentRepository(_dbContext);

        #endregion
    }
}
