﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YmatouMQMessageMongodb.Domain.IRepository;
using YmatouMQMessageMongodb.Domain.Module;
using YmatouMQMessageMongodb.Repository.Context;
using YmtSystem.Repository.Mongodb;
using YmtSystem.Repository.Mongodb.Context;

namespace YmatouMQMessageMongodb.Repository
{
    public class BusPushHealthRepository : MongodbRepository<BusPushHealth>, IBusPushHealthRepository
    {
        public BusPushHealthRepository(MongodbContext context)
            : base(context)
        {
        }

        public BusPushHealthRepository()
            : this(new BusPushHealthContext())
        {
        }
    }
}
