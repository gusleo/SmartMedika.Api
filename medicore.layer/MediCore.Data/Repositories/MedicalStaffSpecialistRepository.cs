﻿using dna.core.data.Repositories;
using dna.core.data.Repositories.Abstract;
using MediCore.Data.Entities;
using MediCore.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediCore.Data.Repositories
{
    public class MedicalStaffSpecialistRepository : EntityReadWriteBaseRepository<MedicalStaffSpecialist>, IMedicalStaffSpecialistRepository
    {
        public IMediCoreContext MediCoreContext
        {
            get { return _context as IMediCoreContext; }
        }
        public MedicalStaffSpecialistRepository(IMediCoreContext context) : base(context)
        {
        }
    }

    
}
