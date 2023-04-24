using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MertProject.DataAccessLayer.Abstract;
using MertProject.DataAccessLayer.Concrate;
using MertProject.DataAccessLayer.Repositories;
using MertProject.EntityLayer.Concrate;

namespace MertProject.DataAccessLayer.EntityFramework
{
    public class EfSubscribeDal:GenericRepository<Subscribe>,ISubscribeDal
    {
        public EfSubscribeDal(Context context):base(context) 
        {
            
        }
    }
}
