using MertProject.DataAccessLayer.Abstract;
using MertProject.DataAccessLayer.Concrate;
using MertProject.DataAccessLayer.Repositories;
using MertProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertProject.DataAccessLayer.EntityFramework
{
    public  class EfRoomDal:GenericRepository<Room>,IRoomDal
    {
        public EfRoomDal(Context context):base(context) 
        {
            
        }
    }
}
