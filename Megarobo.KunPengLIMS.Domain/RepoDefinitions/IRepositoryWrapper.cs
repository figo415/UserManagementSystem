using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megarobo.KunPengLIMS.Domain.RepoDefinitions
{
    public interface IRepositoryWrapper
    {
        #region System management module
        IUserRepository UserRepo { get; }

        IUserSkillRepository UserSkillRepo { get; }

        IUserDepartmentRoleRepository UserDepartmentRoleRepo { get; }

        ISkillRepository SkillRepo { get; }

        IDepartmentRepository DepartmentRepo { get; }

        IRoleRepository RoleRepo { get; }

        IRoleMenuRepository RoleMenuRepo { get; }

        IMenuRepository MenuRepo { get; }

        IDictItemRepository DictItemRepo { get; }

        ILogItemRepository LogItemRepo { get; }

        #endregion

        #region Basic data configuration module

        ISpeciesRepository SpeciesRepo { get; }

        ICellRepository CellRepo { get; }

        //IPositionRepository PositionRepo { get; }

        ILabwareRepository LabwareRepo { get; }

        IReagentRepository ReagentRepo { get; }

        IDeviceRepository DeviceRepo { get; }

        #endregion

        #region Sample management module

        ISampleRepository SampleRepo { get; }

        #endregion

        #region Project management module



        #endregion

        #region Production management module

        IOrderRepository OrderRepo { get; }

        IMolecularCloningRepository MolecularCloningRepo { get; }

        IPlasmidPurificationRepository PlasmidPurificationRepo { get; }

        #endregion
    }
}
